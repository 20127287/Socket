using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TCPClient
{
    class Client
    {

        private Socket socket;
        private IPAddress IP;
        private int Port;
        private int buffer;
        private byte[] buffers;

        public Client(IPAddress ip,int port, int size=5000)
        {
            IP = ip;
            Port = port;
            buffer = size;
            buffers = new byte[buffer];
        }

        public void Connect()
        {
           
            try
            {

                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                socket.Connect(new IPEndPoint(IP,Port));
                MessageBox.Show("Kết nối thành công");
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        //Hien thi danh sach
        public void Send(string message)
        {

            socket.Send(Encoding.UTF8.GetBytes(message));
            //Nhan lai thong tin tu server
            //Recieve();
        }
        //tai anh
        

        

        //Nhan thong tin tu server
        void Recieve()
        {
            byte[] data = new byte[1024 * 5000];
            socket.Receive(data);

            string req = Encoding.UTF8.GetString(data);
            
            listView1.Items.Add(new ListViewItem() { Text = req });
        }
    }
}
