using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project1
{
    class PhoneBookSever
    {
        public string code { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
        public PhoneBookSever()
        {
            code = "";
            name = "";
            phone = "";
            email = "";
            avatar = "";
        }
    }

    class PhoneBookClient
    {
        public string code { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public byte[] avatar { get; set; }

        public PhoneBookClient()
        {
            code = "";
            name = "";
            phone = "";
            email = "";
            avatar = null;
        }

        public PhoneBookClient(PhoneBookSever phoneBookSever)
        {
            code = phoneBookSever.code;
            name = phoneBookSever.name;
            phone = phoneBookSever.phone;
            email = phoneBookSever.email;
                        
            try
            {
                MemoryStream ms = new MemoryStream();
                Bitmap bmp = new Bitmap(phoneBookSever.avatar);
                bmp.Save(ms, ImageFormat.Jpeg);
                avatar = ms.ToArray();
            }
            catch
            {
                avatar = null;
            }            
        }
    }

    class Server
    {
        private IPAddress IP;
        private int port;
        private List<Socket> ClientSockets;
        private Socket serverSocket;
        private string db;
        private int buffer;
        private byte[] request;
        


        public Server(IPAddress _ip, int _port, string _db, int _buffer)
        {
            IP = _ip;
            port = _port;
            db = _db;
            buffer = _buffer;
            request = new byte[buffer];
            ClientSockets = new List<Socket>();           
        }

        public void Start()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IP, port));
            serverSocket.Listen(0);
            serverSocket.BeginAccept(AcceptCallBack, null);
        }
        public void CloseAll()
        {
            foreach (Socket socket in ClientSockets)
                socket.Close();
            ClientSockets.Clear(); 
            serverSocket.Close();
        }

        private void AcceptCallBack(IAsyncResult AR)
        {
            try
            {
                Socket socket = serverSocket.EndAccept(AR);
                ClientSockets.Add(socket);
                socket.BeginReceive(request, 0, buffer, SocketFlags.None, ReceiveCallBack, socket);
                serverSocket.BeginAccept(AcceptCallBack, null);
            }
            catch
            {

            } 
        }

        private void ReceiveCallBack(IAsyncResult AR)
        {

            Socket socket = (Socket)AR.AsyncState;
            string req = readReques(AR, socket);
            if (req != null)
            {
                List<PhoneBookClient> phoneBookClients = new List<PhoneBookClient>();

                ReadJson("DB/DanhBa.json", phoneBookClients);

                if (req == "Display")
                {
                    string convert = JsonConvert.SerializeObject(phoneBookClients);

                    socket.Send(Encoding.UTF8.GetBytes(convert));
                }
                else
                {
                    foreach (PhoneBookClient phoneBookClient in phoneBookClients)
                        if (req == phoneBookClient.code)
                        {
                            string convert = JsonConvert.SerializeObject(phoneBookClient);
                            socket.Send(Encoding.UTF8.GetBytes(convert));

                            socket.BeginReceive(request, 0, buffer, SocketFlags.None, ReceiveCallBack, socket);
                            return;
                        }
                    socket.Send(Encoding.UTF8.GetBytes("false"));
                    
                }
                socket.BeginReceive(request, 0, buffer, SocketFlags.None, ReceiveCallBack, socket);
            }
        }

///////
        private string readReques(IAsyncResult AR, Socket socket)
        {
            try
            {
                int received = socket.EndReceive(AR);
                byte[] resbuffer = new byte[received];
                Array.Copy(request, resbuffer, received);
                string req = Encoding.UTF8.GetString(resbuffer);
                return req;
            }
            catch
            {
                socket.Close();
            }
            return null;
        }

        private void ReadJson (string address, List<PhoneBookClient> phoneBookClients)
        {
            string data = System.IO.File.ReadAllText(address);
            List<PhoneBookSever> phoneBookSevers = JsonConvert.DeserializeObject<List<PhoneBookSever>>(data);            

            foreach (PhoneBookSever phoneBookSever in phoneBookSevers)
            {
                PhoneBookClient phoneBookClient = new PhoneBookClient(phoneBookSever);
                
                phoneBookClients.Add(phoneBookClient);
            }
        }
    }
}
