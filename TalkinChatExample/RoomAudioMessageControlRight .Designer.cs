namespace TalkinChatExample
{
    partial class RoomAudioMessageControlRight
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.durationProgress = new System.Windows.Forms.ProgressBar();
            this.durationLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.msgContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.msgContainer.Controls.Add(this.panel1);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(204, 4);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(214, 86);
            this.msgContainer.TabIndex = 2;
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(179, 4);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(31, 17);
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
            this.divider.Size = new System.Drawing.Size(206, 1);
            this.divider.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.durationProgress);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Controls.Add(this.durationLbl);
            this.panel1.Location = new System.Drawing.Point(7, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 48);
            this.panel1.TabIndex = 4;
            // 
            // durationProgress
            // 
            this.durationProgress.Location = new System.Drawing.Point(40, 17);
            this.durationProgress.MarqueeAnimationSpeed = 10;
            this.durationProgress.Name = "durationProgress";
            this.durationProgress.Size = new System.Drawing.Size(154, 5);
            this.durationProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.durationProgress.TabIndex = 3;
            // 
            // durationLbl
            // 
            this.durationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durationLbl.BackColor = System.Drawing.Color.Transparent;
            this.durationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLbl.ForeColor = System.Drawing.Color.Gray;
            this.durationLbl.Location = new System.Drawing.Point(123, 27);
            this.durationLbl.Margin = new System.Windows.Forms.Padding(0);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(70, 16);
            this.durationLbl.TabIndex = 13;
            this.durationLbl.Text = "00:00";
            this.durationLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(424, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 142);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userPic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 32);
            this.panel3.TabIndex = 0;
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
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.ForeColor = System.Drawing.Color.Transparent;
            this.playBtn.Image = global::TalkinChatExample.Properties.Resources.play_icon;
            this.playBtn.Location = new System.Drawing.Point(3, 3);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(32, 32);
            this.playBtn.TabIndex = 2;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // RoomAudioMessageControlRight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.msgContainer);
            this.Name = "RoomAudioMessageControlRight";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(460, 150);
            this.msgContainer.ResumeLayout(false);
            this.msgContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar durationProgress;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label divider;
    }
}
