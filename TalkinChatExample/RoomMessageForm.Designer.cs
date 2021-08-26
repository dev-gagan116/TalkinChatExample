namespace TalkinChatExample
{
    partial class RoomMessageForm
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
            this.currentUsersLbl = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Panel();
            this.roomUserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sendBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomNameLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.moreBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moreBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.currentUsersLbl);
            this.panel1.Controls.Add(this.divider);
            this.panel1.Controls.Add(this.roomUserPanel);
            this.panel1.Controls.Add(this.chatPanel);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 442);
            this.panel1.TabIndex = 0;
            // 
            // currentUsersLbl
            // 
            this.currentUsersLbl.AutoSize = true;
            this.currentUsersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUsersLbl.Location = new System.Drawing.Point(493, 42);
            this.currentUsersLbl.Name = "currentUsersLbl";
            this.currentUsersLbl.Size = new System.Drawing.Size(149, 15);
            this.currentUsersLbl.TabIndex = 7;
            this.currentUsersLbl.Text = "Current Users: (20/50)";
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.DarkGray;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider.Location = new System.Drawing.Point(490, 41);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(2, 340);
            this.divider.TabIndex = 6;
            // 
            // roomUserPanel
            // 
            this.roomUserPanel.AutoScroll = true;
            this.roomUserPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.roomUserPanel.Location = new System.Drawing.Point(492, 60);
            this.roomUserPanel.Name = "roomUserPanel";
            this.roomUserPanel.Size = new System.Drawing.Size(168, 321);
            this.roomUserPanel.TabIndex = 0;
            this.roomUserPanel.WrapContents = false;
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.BackColor = System.Drawing.Color.LightGray;
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.chatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatPanel.Location = new System.Drawing.Point(0, 41);
            this.chatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(490, 340);
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
            this.panel6.Size = new System.Drawing.Size(660, 61);
            this.panel6.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.richTextBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(598, 57);
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
            this.richTextBox1.Size = new System.Drawing.Size(598, 57);
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
            this.panel7.Location = new System.Drawing.Point(598, 0);
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
            this.panel2.Controls.Add(this.roomNameLbl);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 41);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // roomNameLbl
            // 
            this.roomNameLbl.AutoEllipsis = true;
            this.roomNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.roomNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLbl.ForeColor = System.Drawing.Color.White;
            this.roomNameLbl.Location = new System.Drawing.Point(0, 0);
            this.roomNameLbl.Name = "roomNameLbl";
            this.roomNameLbl.Size = new System.Drawing.Size(636, 35);
            this.roomNameLbl.TabIndex = 1;
            this.roomNameLbl.Text = "Room Name";
            this.roomNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.moreBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(636, 0);
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
            // RoomMessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(660, 463);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 463);
            this.MinimumSize = new System.Drawing.Size(660, 463);
            this.Name = "RoomMessageForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomMessageForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moreBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.Label roomNameLbl;
        internal System.Windows.Forms.PictureBox moreBtn;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        internal System.Windows.Forms.PictureBox sendBtn;
        private System.Windows.Forms.FlowLayoutPanel roomUserPanel;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label currentUsersLbl;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
    }
}