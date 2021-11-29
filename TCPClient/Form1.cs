using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using java.io;
using Newtonsoft.Json;

namespace TCPClient
{    
    public partial class TCPClient : Form
    {
        Client client;
        private bool run = false;
        List<PhoneBookClient> phoneBookClients = new List<PhoneBookClient>();
        int i;
        int count;

        class PhoneBookClient
        {
            public Int64 code { get; set; }
            public string name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public byte[] avatar { get; set; }
        }

        public TCPClient()
        {
            InitializeComponent();
        }

        //IPEndPoint IP;
        //Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        //Client sv = new Client(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
        public void Connect(object sender, EventArgs e)
        {

            //Client client = new Client(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            const Int32 sizePictureMax = 1000000000;
            client = new Client(IPAddress.Parse(IPTextbox.Text), Int32.Parse(PortTextbox.Text), sizePictureMax);
            client.Connect();
            ConnectButton.Enabled = false;
            DisconnectedButton.Enabled = true;
            run = true;

        }



        private void Disconnect(object sender, EventArgs e)
        {
            if (run == true)
            {
                ConnectButton.Enabled = true;
                DisconnectedButton.Enabled = false;
                MessageBox.Show("Đóng kết nối thành công");
                this.Close();
            }
            else
                MessageBox.Show("Chưa kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //************************************************************************

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (IPTextbox.Text != "")
                IPTextbox.ForeColor = Color.Black;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (IPTextbox.Text == "Nhập IP")
                IPTextbox.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (IPTextbox.Text == "")
                IPTextbox.Text = "Nhập IP";
            IPTextbox.ForeColor = Color.Gray;
        }
        //************************************************************************


        private void textBox2_Click(object sender, EventArgs e)
        {
            if (PortTextbox.Text != "")
                PortTextbox.ForeColor = Color.Black;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (PortTextbox.Text == "Nhập Port")
                PortTextbox.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (PortTextbox.Text == "")
                PortTextbox.Text = "Nhập Port";
            PortTextbox.ForeColor = Color.Gray;
        }
        //************************************************************************


        public void Display(object sender, EventArgs e)
        {
            client.Send("Display");

            string convert = Encoding.UTF8.GetString(client.Recieve());

            phoneBookClients = JsonConvert.DeserializeObject<List<PhoneBookClient>>(convert);

            i = 0;
            count = phoneBookClients.Count;

            showObject(phoneBookClients[i]);

            if (count > 1) NextButton.Enabled = true;
            BackButton.Enabled = false;

            ord.Visible = true;
            ord.Text = (i + 1).ToString() + "/" + count.ToString();

            GoTextbox.Enabled = true;
            GoButton.Enabled = true;

            DisplayButton.Enabled = false;
        }  
        //gui ma so can tìm kiem
        private void Search(object sender, EventArgs e)
        {
            client.Send(SearchTextBox.Text);

            //Nhan lai thong tin tu server
            string data = Encoding.UTF8.GetString(client.Recieve());

            PhoneBookClient phoneBookClient = new PhoneBookClient();
            phoneBookClient = JsonConvert.DeserializeObject<PhoneBookClient>(data);

            showObject(phoneBookClient);

            NextButton.Enabled = BackButton.Enabled = false;
            ord.Visible = false;

            GoTextbox.Enabled = false;
            GoButton.Enabled = false;

            DisplayButton.Enabled = true;
        }

        private void showObject(PhoneBookClient phoneBookClient)
        {
            CodeView.Text = phoneBookClient.code.ToString();
            NameView.Text = phoneBookClient.name;
            PhoneView.Text = phoneBookClient.phone;
            EmailView.Text = phoneBookClient.email;
            pictureBox.Image = new Bitmap(Image.FromStream(new MemoryStream(phoneBookClient.avatar)), new Size(100, 100));
        }

		private void button3_Click(object sender, EventArgs e)
		{
            IPTextbox.Text = "127.0.0.1";
            PortTextbox.Text = "8080";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            BackButton.Enabled = true;

            showObject(phoneBookClients[++i]);
            ord.Text = (i + 1).ToString() + "/" + count.ToString();

            if (i == count - 1) NextButton.Enabled = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            NextButton.Enabled = true;

            showObject(phoneBookClients[--i]);
            ord.Text = (i + 1).ToString() + "/" + count.ToString();

            if (i == 0) BackButton.Enabled = false;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(GoTextbox.Text);
            
            if (tmp < 1 || tmp > count)
                MessageBox.Show("Số vừa nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                i = tmp - 1;
                showObject(phoneBookClients[i]);
                ord.Text = tmp.ToString() + "/" + count.ToString();

                if (i == 0) BackButton.Enabled = false;
                else BackButton.Enabled = true;

                if (i == count - 1) NextButton.Enabled = false;
                else NextButton.Enabled = true;
            }

            GoTextbox.Text = "";
        }
    }
}
