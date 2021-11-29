namespace TCPClient
{
    partial class TCPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPClient));
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.IPTextbox = new System.Windows.Forms.TextBox();
            this.PortLable = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectedButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CodeView = new System.Windows.Forms.TextBox();
            this.NameView = new System.Windows.Forms.TextBox();
            this.PhoneView = new System.Windows.Forms.TextBox();
            this.EmailView = new System.Windows.Forms.TextBox();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ord = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.GoTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PortTextbox
            // 
            this.PortTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortTextbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PortTextbox.Location = new System.Drawing.Point(225, 49);
            this.PortTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(121, 27);
            this.PortTextbox.TabIndex = 12;
            this.PortTextbox.Text = "8080";
            this.PortTextbox.Click += new System.EventHandler(this.textBox2_Click);
            this.PortTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.PortTextbox.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // IPTextbox
            // 
            this.IPTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTextbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IPTextbox.Location = new System.Drawing.Point(45, 49);
            this.IPTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.IPTextbox.Name = "IPTextbox";
            this.IPTextbox.Size = new System.Drawing.Size(122, 27);
            this.IPTextbox.TabIndex = 11;
            this.IPTextbox.Text = "127.0.0.1";
            this.IPTextbox.Click += new System.EventHandler(this.textBox1_Click);
            this.IPTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.IPTextbox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // PortLable
            // 
            this.PortLable.AutoSize = true;
            this.PortLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLable.Location = new System.Drawing.Point(221, 25);
            this.PortLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLable.Name = "PortLable";
            this.PortLable.Size = new System.Drawing.Size(40, 20);
            this.PortLable.TabIndex = 10;
            this.PortLable.Text = "Port";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.Location = new System.Drawing.Point(41, 25);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(91, 20);
            this.IPLabel.TabIndex = 9;
            this.IPLabel.Text = "IP Address";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(463, 43);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(125, 35);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.Connect);
            // 
            // DisconnectedButton
            // 
            this.DisconnectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectedButton.Location = new System.Drawing.Point(816, 42);
            this.DisconnectedButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisconnectedButton.Name = "DisconnectedButton";
            this.DisconnectedButton.Size = new System.Drawing.Size(125, 36);
            this.DisconnectedButton.TabIndex = 14;
            this.DisconnectedButton.Text = "Disconnect";
            this.DisconnectedButton.UseVisualStyleBackColor = true;
            this.DisconnectedButton.Click += new System.EventHandler(this.Disconnect);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(715, 122);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(121, 27);
            this.SearchTextBox.TabIndex = 17;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(182, 119);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(125, 34);
            this.DisplayButton.TabIndex = 30;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.Display);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(569, 119);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 34);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(569, 222);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(372, 350);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel.Location = new System.Drawing.Point(38, 222);
            this.CodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(48, 20);
            this.CodeLabel.TabIndex = 23;
            this.CodeLabel.Text = "Code";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(38, 316);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(38, 415);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(56, 20);
            this.PhoneLabel.TabIndex = 23;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(38, 518);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 23;
            this.EmailLabel.Text = "Email";
            // 
            // CodeView
            // 
            this.CodeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeView.Location = new System.Drawing.Point(42, 246);
            this.CodeView.Margin = new System.Windows.Forms.Padding(4);
            this.CodeView.Name = "CodeView";
            this.CodeView.Size = new System.Drawing.Size(404, 27);
            this.CodeView.TabIndex = 24;
            // 
            // NameView
            // 
            this.NameView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameView.Location = new System.Drawing.Point(42, 340);
            this.NameView.Margin = new System.Windows.Forms.Padding(4);
            this.NameView.Name = "NameView";
            this.NameView.Size = new System.Drawing.Size(404, 27);
            this.NameView.TabIndex = 25;
            // 
            // PhoneView
            // 
            this.PhoneView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneView.Location = new System.Drawing.Point(42, 439);
            this.PhoneView.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneView.Name = "PhoneView";
            this.PhoneView.Size = new System.Drawing.Size(404, 27);
            this.PhoneView.TabIndex = 26;
            // 
            // EmailView
            // 
            this.EmailView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailView.Location = new System.Drawing.Point(42, 542);
            this.EmailView.Margin = new System.Windows.Forms.Padding(4);
            this.EmailView.Name = "EmailView";
            this.EmailView.Size = new System.Drawing.Size(404, 27);
            this.EmailView.TabIndex = 27;
            // 
            // DefaultButton
            // 
            this.DefaultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultButton.Location = new System.Drawing.Point(640, 42);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(125, 36);
            this.DefaultButton.TabIndex = 28;
            this.DefaultButton.Text = "Default";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(322, 119);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(125, 34);
            this.NextButton.TabIndex = 29;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.Next_Click);
            // 
            // BackButton
            // 
            this.BackButton.Enabled = false;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(42, 119);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 34);
            this.BackButton.TabIndex = 30;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // ord
            // 
            this.ord.BackColor = System.Drawing.SystemColors.Control;
            this.ord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ord.Enabled = false;
            this.ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ord.Location = new System.Drawing.Point(181, 93);
            this.ord.Name = "ord";
            this.ord.ReadOnly = true;
            this.ord.Size = new System.Drawing.Size(125, 20);
            this.ord.TabIndex = 31;
            this.ord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ord.Visible = false;
            // 
            // GoButton
            // 
            this.GoButton.Enabled = false;
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(111, 173);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(125, 34);
            this.GoButton.TabIndex = 32;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // GoTextbox
            // 
            this.GoTextbox.Enabled = false;
            this.GoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoTextbox.Location = new System.Drawing.Point(253, 176);
            this.GoTextbox.Name = "GoTextbox";
            this.GoTextbox.Size = new System.Drawing.Size(121, 27);
            this.GoTextbox.TabIndex = 33;
            this.GoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 616);
            this.Controls.Add(this.GoTextbox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.EmailView);
            this.Controls.Add(this.PhoneView);
            this.Controls.Add(this.NameView);
            this.Controls.Add(this.CodeView);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.DisconnectedButton);
            this.Controls.Add(this.PortTextbox);
            this.Controls.Add(this.IPTextbox);
            this.Controls.Add(this.PortLable);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SearchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCPClient";
            this.Text = "TCPClient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PortTextbox;
        private System.Windows.Forms.TextBox IPTextbox;
        private System.Windows.Forms.Label PortLable;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectedButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox CodeView;
        private System.Windows.Forms.TextBox NameView;
        private System.Windows.Forms.TextBox PhoneView;
        private System.Windows.Forms.TextBox EmailView;
		private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox ord;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox GoTextbox;
    }
}

