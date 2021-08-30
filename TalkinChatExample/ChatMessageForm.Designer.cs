namespace TalkinChatExample
{
    partial class ChatMessageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sendBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.moreBtn = new System.Windows.Forms.PictureBox();
            this.userStateLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moreBtn)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.chatPanel);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 442);
            this.panel1.TabIndex = 0;
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.BackColor = System.Drawing.Color.LightGray;
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatPanel.Location = new System.Drawing.Point(0, 41);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.chatPanel.Size = new System.Drawing.Size(650, 340);
            this.chatPanel.TabIndex = 5;
            this.chatPanel.WrapContents = false;
            this.chatPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.chatPanel_ControlAdded);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 381);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(650, 61);
            this.panel6.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.richTextBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(588, 57);
            this.panel8.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(588, 57);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "write a message...";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.sendBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(588, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(58, 57);
            this.panel7.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.sendBtn.Image = global::TalkinChatExample.Properties.Resources.attachments;
            this.sendBtn.Location = new System.Drawing.Point(6, 5);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(12);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Padding = new System.Windows.Forms.Padding(12);
            this.sendBtn.Size = new System.Drawing.Size(48, 48);
            this.sendBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sendBtn.TabIndex = 2;
            this.sendBtn.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.usernameLbl);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.userStateLbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 41);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // usernameLbl
            // 
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(49, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(577, 19);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.moreBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(626, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 41);
            this.panel4.TabIndex = 4;
            // 
            // moreBtn
            // 
            this.moreBtn.Image = global::TalkinChatExample.Properties.Resources.more;
            this.moreBtn.Location = new System.Drawing.Point(5, 5);
            this.moreBtn.Margin = new System.Windows.Forms.Padding(8);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(16, 30);
            this.moreBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moreBtn.TabIndex = 0;
            this.moreBtn.TabStop = false;
            // 
            // userStateLbl
            // 
            this.userStateLbl.AutoSize = true;
            this.userStateLbl.BackColor = System.Drawing.Color.Transparent;
            this.userStateLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userStateLbl.Location = new System.Drawing.Point(51, 23);
            this.userStateLbl.Name = "userStateLbl";
            this.userStateLbl.Size = new System.Drawing.Size(46, 17);
            this.userStateLbl.TabIndex = 3;
            this.userStateLbl.Text = "offline";
            this.userStateLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userPic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 41);
            this.panel3.TabIndex = 1;
            // 
            // userPic
            // 
            this.userPic.BackColor = System.Drawing.Color.Transparent;
            this.userPic.Image = global::TalkinChatExample.Properties.Resources.profile_user_wheat;
            this.userPic.Location = new System.Drawing.Point(7, 2);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(36, 36);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 1;
            this.userPic.TabStop = false;
            // 
            // ChatMessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(650, 463);
            this.Controls.Add(this.panel1);
            this.Name = "ChatMessageForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatMessageForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatMessageForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moreBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.Label userStateLbl;
        internal System.Windows.Forms.PictureBox userPic;
        internal System.Windows.Forms.Label usernameLbl;
        internal System.Windows.Forms.PictureBox moreBtn;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        internal System.Windows.Forms.PictureBox sendBtn;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
    }
}