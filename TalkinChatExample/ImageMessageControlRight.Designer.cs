namespace TalkinChatExample
{
    partial class ImageMessageControlRight
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
            this.imageMsg = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.msgStatePic = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.msgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgStatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // msgContainer
            // 
            this.msgContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.msgContainer.Controls.Add(this.imageMsg);
            this.msgContainer.Controls.Add(this.panel3);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(384, 7);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(210, 210);
            this.msgContainer.TabIndex = 2;
            // 
            // imageMsg
            // 
            this.imageMsg.ErrorImage = global::TalkinChatExample.Properties.Resources.msg_error;
            this.imageMsg.InitialImage = global::TalkinChatExample.Properties.Resources.waiting;
            this.imageMsg.Location = new System.Drawing.Point(7, 7);
            this.imageMsg.Name = "imageMsg";
            this.imageMsg.Size = new System.Drawing.Size(196, 172);
            this.imageMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageMsg.TabIndex = 4;
            this.imageMsg.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.msgStatePic);
            this.panel3.Controls.Add(this.timeLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 182);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 24);
            this.panel3.TabIndex = 3;
            // 
            // msgStatePic
            // 
            this.msgStatePic.BackColor = System.Drawing.Color.Transparent;
            this.msgStatePic.Image = global::TalkinChatExample.Properties.Resources.msg_sending;
            this.msgStatePic.Location = new System.Drawing.Point(184, 9);
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
            // ImageMessageControlRight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgContainer);
            this.Name = "ImageMessageControlRight";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(600, 224);
            this.msgContainer.ResumeLayout(false);
            this.msgContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgStatePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox msgStatePic;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.PictureBox imageMsg;
    }
}
