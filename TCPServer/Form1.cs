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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Server sv;
        private bool run = false;
        private void button1_Click(object sender, EventArgs e)
        {
            sv = new Server(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text), "", 8 * 1024);
            sv.Start();
            MessageBox.Show("Server đang chạy");
            button1.Enabled = false;
            button2.Enabled = true;
            run = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (run == true)
            {
                sv.Close();
                button1.Enabled = true;
                button2.Enabled = false;
                MessageBox.Show("Đóng kết nối thành công");
            }
            else
                MessageBox.Show("Chưa tạo kết nối");
        }
		private void button3_Click(object sender, EventArgs e)
		{
            textBox1.Text = "127.0.0.1";
            textBox2.Text = "8080";
        }
		//************************************************************************

		private void textBox1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				textBox1.ForeColor = Color.Black;
		}

		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
			if (textBox1.Text == "Nhập IP")
				textBox1.Text = "";
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
				textBox1.Text = "Nhập IP";
			textBox1.ForeColor = Color.Gray;
		}
		//************************************************************************


		private void textBox2_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "")
				textBox2.ForeColor = Color.Black;
		}

		private void textBox2_MouseClick(object sender, MouseEventArgs e)
		{
			if (textBox2.Text == "Nhập Port")
				textBox2.Text = "";
		}

		private void textBox2_Leave(object sender, EventArgs e)
		{
			if (textBox2.Text == "")
				textBox2.Text = "Nhập Port";
			textBox2.ForeColor = Color.Gray;
		}
	}
}
