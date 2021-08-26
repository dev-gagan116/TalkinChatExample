namespace TalkinChatExample
{
    partial class RoomTextMessageControlLeft
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.msgContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.textMsgLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.msgContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 142);
            this.panel1.TabIndex = 0;
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
            // msgContainer
            // 
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.White;
            this.msgContainer.Controls.Add(this.usernameLbl);
            this.msgContainer.Controls.Add(this.divider);
            this.msgContainer.Controls.Add(this.textMsgLbl);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(42, 7);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(90, 52);
            this.msgContainer.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoEllipsis = true;
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(4, 4);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(71, 17);
            this.usernameLbl.TabIndex = 18;
            this.usernameLbl.Text = "username";
            // 
            // divider
            // 
            this.divider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divider.BackColor = System.Drawing.Color.Gainsboro;
            this.divider.Location = new System.Drawing.Point(4, 25);
            this.divider.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(80, 1);
            this.divider.TabIndex = 5;
            // 
            // textMsgLbl
            // 
            this.textMsgLbl.AutoSize = true;
            this.textMsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.textMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textMsgLbl.Location = new System.Drawing.Point(4, 28);
            this.textMsgLbl.Margin = new System.Windows.Forms.Padding(0);
            this.textMsgLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.textMsgLbl.MinimumSize = new System.Drawing.Size(80, 16);
            this.textMsgLbl.Name = "textMsgLbl";
            this.textMsgLbl.Size = new System.Drawing.Size(80, 20);
            this.textMsgLbl.TabIndex = 11;
            this.textMsgLbl.Text = "Hi";
            // 
            // RoomTextMessageControlLeft
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgContainer);
            this.Controls.Add(this.panel1);
            this.Name = "RoomTextMessageControlLeft";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(460, 150);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.msgContainer.ResumeLayout(false);
            this.msgContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Label textMsgLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label divider;
    }
}
