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

namespace TCPClient
{
    public partial class Form1 : Form
    {
        Client client;

        public Form1()
        {
            InitializeComponent();
        }

        //IPEndPoint IP;
        //Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        //Client sv = new Client(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
        public void Connect(object sender, EventArgs e)
        {

            //Client client = new Client(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            client = new Client(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            client.Connect();
        }

        private void Disconnect(object sender, EventArgs e)
        {
            //tat form
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
                textBox1.Text = "127.0.0.1";
                textBox2.Text = "8080";

            }
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "Input Port") return;
            textBox2.Text = " ";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "Input IP") return;
            textBox1.Text = " ";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "") return;
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Input IP";
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "") return;
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Input Port";
        }

        //Hien thi danh sach
        private void Display(object sender, EventArgs e)
        {
            client.Send("Display");
            //client.Send(buf);
            //Nhan lai thong tin tu server
            Recieve();
        }
        //tai anh
        private void LoadAvata(object sender, EventArgs e)
        {
            client.Send("LoadAvata");
            //Nhan lai thong tin tu server
            Recieve();
        }

        //gui ma so can tìm kiem
        private void Search(object sender, EventArgs e)
        {
            client.Send(textBox3.Text);
            //Nhan lai thong tin tu server
            Recieve();
        }

        //Nhan thong tin tu server
        void Recieve()
        {
            byte[] data = new byte[1024 * 5000];
            string req = Encoding.UTF8.GetString(data);
            listView1.Items.Add(new ListViewItem() { Text = req });
        }

        //void AddMessage(byte[] s)
        //{
        //    listView1.Items.Add(new ListViewItem() { Text = s });
        //}

    } 
}
