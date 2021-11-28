namespace TCPClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CodeView = new System.Windows.Forms.TextBox();
            this.NameView = new System.Windows.Forms.TextBox();
            this.PhoneView = new System.Windows.Forms.TextBox();
            this.EmailView = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.ord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(225, 49);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "8080";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(45, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "127.0.0.1";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Connect);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Disconnect);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(715, 125);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(121, 22);
            this.SearchTextBox.TabIndex = 17;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "Display";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Display);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(569, 119);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 34);
            this.button5.TabIndex = 20;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Search);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(569, 185);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(372, 350);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(43, 204);
            this.CodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(40, 16);
            this.CodeLabel.TabIndex = 23;
            this.CodeLabel.Text = "Code";
            this.CodeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(43, 298);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(43, 397);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(46, 16);
            this.PhoneLabel.TabIndex = 23;
            this.PhoneLabel.Text = "Phone";
            this.PhoneLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(43, 500);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 23;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // CodeView
            // 
            this.CodeView.Location = new System.Drawing.Point(101, 199);
            this.CodeView.Margin = new System.Windows.Forms.Padding(4);
            this.CodeView.Name = "CodeView";
            this.CodeView.Size = new System.Drawing.Size(376, 22);
            this.CodeView.TabIndex = 24;
            // 
            // NameView
            // 
            this.NameView.Location = new System.Drawing.Point(101, 293);
            this.NameView.Margin = new System.Windows.Forms.Padding(4);
            this.NameView.Name = "NameView";
            this.NameView.Size = new System.Drawing.Size(376, 22);
            this.NameView.TabIndex = 25;
            // 
            // PhoneView
            // 
            this.PhoneView.Location = new System.Drawing.Point(101, 392);
            this.PhoneView.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneView.Name = "PhoneView";
            this.PhoneView.Size = new System.Drawing.Size(376, 22);
            this.PhoneView.TabIndex = 26;
            // 
            // EmailView
            // 
            this.EmailView.Location = new System.Drawing.Point(101, 495);
            this.EmailView.Margin = new System.Windows.Forms.Padding(4);
            this.EmailView.Name = "EmailView";
            this.EmailView.Size = new System.Drawing.Size(376, 22);
            this.EmailView.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(640, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 36);
            this.button3.TabIndex = 28;
            this.button3.Text = "Default";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(321, 119);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(125, 34);
            this.Next.TabIndex = 29;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Enabled = false;
            this.Back.Location = new System.Drawing.Point(42, 119);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(125, 34);
            this.Back.TabIndex = 30;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ord
            // 
            this.ord.BackColor = System.Drawing.SystemColors.Control;
            this.ord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ord.Enabled = false;
            this.ord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ord.Location = new System.Drawing.Point(225, 98);
            this.ord.Name = "ord";
            this.ord.ReadOnly = true;
            this.ord.Size = new System.Drawing.Size(31, 15);
            this.ord.TabIndex = 31;
            this.ord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ord.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 569);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EmailView);
            this.Controls.Add(this.PhoneView);
            this.Controls.Add(this.NameView);
            this.Controls.Add(this.CodeView);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox CodeView;
        private System.Windows.Forms.TextBox NameView;
        private System.Windows.Forms.TextBox PhoneView;
        private System.Windows.Forms.TextBox EmailView;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox ord;
    }
}

