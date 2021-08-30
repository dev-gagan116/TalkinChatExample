namespace TalkinChatExample
{
    partial class AudioMessageControlLeft
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
            this.durationLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.msgContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgContainer
            // 
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.White;
            this.msgContainer.Controls.Add(this.panel1);
            this.msgContainer.Controls.Add(this.timeLbl);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(8, 8);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(214, 80);
            this.msgContainer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.durationProgress);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Controls.Add(this.durationLbl);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 48);
            this.panel1.TabIndex = 2;
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
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Gray;
            this.timeLbl.Location = new System.Drawing.Point(140, 58);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(70, 16);
            this.timeLbl.TabIndex = 13;
            this.timeLbl.Text = "09:25 am";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // AudioMessageControlLeft
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgContainer);
            this.Name = "AudioMessageControlLeft";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(600, 225);
            this.msgContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ProgressBar durationProgress;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Label timeLbl;
    }
}
