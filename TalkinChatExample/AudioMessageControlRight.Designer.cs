namespace TalkinChatExample
{
    partial class AudioMessageControlRight
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.durationProgress = new System.Windows.Forms.ProgressBar();
            this.playBtn = new System.Windows.Forms.Button();
            this.durationLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.msgStatePic = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.msgContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgStatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // msgContainer
            // 
            this.msgContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.msgContainer.Controls.Add(this.panel1);
            this.msgContainer.Controls.Add(this.panel3);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(380, 7);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(214, 88);
            this.msgContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.durationProgress);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Controls.Add(this.durationLbl);
            this.panel1.Location = new System.Drawing.Point(7, 7);
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
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.msgStatePic);
            this.panel3.Controls.Add(this.timeLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 26);
            this.panel3.TabIndex = 5;
            // 
            // msgStatePic
            // 
            this.msgStatePic.BackColor = System.Drawing.Color.Transparent;
            this.msgStatePic.Image = global::TalkinChatExample.Properties.Resources.msg_sending;
            this.msgStatePic.Location = new System.Drawing.Point(191, 11);
            this.msgStatePic.Name = "msgStatePic";
            this.msgStatePic.Size = new System.Drawing.Size(12, 12);
            this.msgStatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.msgStatePic.TabIndex = 14;
            this.msgStatePic.TabStop = false;
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Gray;
            this.timeLbl.Location = new System.Drawing.Point(0, 2);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(64, 19);
            this.timeLbl.TabIndex = 13;
            this.timeLbl.Text = "09:25 am";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AudioMessageControlRight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgContainer);
            this.Name = "AudioMessageControlRight";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(600, 150);
            this.msgContainer.ResumeLayout(false);
            this.msgContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgStatePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar durationProgress;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox msgStatePic;
        private System.Windows.Forms.Label timeLbl;
    }
}
