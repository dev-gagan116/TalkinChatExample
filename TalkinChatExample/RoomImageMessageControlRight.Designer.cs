namespace TalkinChatExample
{
    partial class RoomImageMessageControlRight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msgContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.imageMsg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.msgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // msgContainer
            // 
            this.msgContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.msgContainer.Controls.Add(this.usernameLbl);
            this.msgContainer.Controls.Add(this.divider);
            this.msgContainer.Controls.Add(this.imageMsg);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(208, 4);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(210, 210);
            this.msgContainer.TabIndex = 2;
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLbl.AutoEllipsis = true;
            this.usernameLbl.Location = new System.Drawing.Point(7, 4);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(199, 17);
            this.usernameLbl.TabIndex = 17;
            this.usernameLbl.Text = "you";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // divider
            // 
            this.divider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divider.BackColor = System.Drawing.Color.LightSlateGray;
            this.divider.Location = new System.Drawing.Point(4, 25);
            this.divider.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(202, 1);
            this.divider.TabIndex = 18;
            // 
            // imageMsg
            // 
            this.imageMsg.ErrorImage = global::TalkinChatExample.Properties.Resources.msg_error;
            this.imageMsg.InitialImage = global::TalkinChatExample.Properties.Resources.waiting;
            this.imageMsg.Location = new System.Drawing.Point(7, 31);
            this.imageMsg.Name = "imageMsg";
            this.imageMsg.Size = new System.Drawing.Size(196, 172);
            this.imageMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageMsg.TabIndex = 4;
            this.imageMsg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(424, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 216);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userPic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 32);
            this.panel2.TabIndex = 0;
            // 
            // userPic
            // 
            this.userPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPic.Image = global::TalkinChatExample.Properties.Resources.profile_user__white;
            this.userPic.Location = new System.Drawing.Point(0, 0);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(32, 32);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 0;
            this.userPic.TabStop = false;
            // 
            // RoomImageMessageControlRight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msgContainer);
            this.Name = "RoomImageMessageControlRight";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(460, 224);
            this.msgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.PictureBox imageMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label divider;
    }
}
