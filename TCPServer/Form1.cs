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

namespace Project1
{
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }
        Server sv;
        private bool run = false;
        private void button1_Click(object sender, EventArgs e)
        {
            sv = new Server(IPAddress.Parse(IPTextbox.Text), Int32.Parse(PortTextbox.Text), "", 8 * 1024);
            sv.Start();
            MessageBox.Show("Server đang chạy");
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            run = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (run == true)
            {
                sv.Close();
                StartButton.Enabled = true;
                StopButton.Enabled = false;
                MessageBox.Show("Đóng kết nối thành công");
            }
            else
				MessageBox.Show("Chưa tạo kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void button3_Click(object sender, EventArgs e)
		{
            IPTextbox.Text = "127.0.0.1";
            PortTextbox.Text = "8080";
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
	}
}
