namespace TalkinChatExample
{
    partial class ImageMessageControlLeft
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
            this.timeLbl = new System.Windows.Forms.Label();
            this.imageMsg = new System.Windows.Forms.PictureBox();
            this.msgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // msgContainer
            // 
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.White;
            this.msgContainer.Controls.Add(this.imageMsg);
            this.msgContainer.Controls.Add(this.timeLbl);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(8, 8);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(210, 202);
            this.msgContainer.TabIndex = 1;
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Gray;
            this.timeLbl.Location = new System.Drawing.Point(136, 182);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(70, 16);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "09:25 am";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // imageMsg
            // 
            this.imageMsg.ErrorImage = global::TalkinChatExample.Properties.Resources.msg_error;
            this.imageMsg.InitialImage = global::TalkinChatExample.Properties.Resources.waiting;
            this.imageMsg.Location = new System.Drawing.Point(7, 7);
            this.imageMsg.Name = "imageMsg";
            this.imageMsg.Size = new System.Drawing.Size(196, 172);
            this.imageMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageMsg.TabIndex = 2;
            this.imageMsg.TabStop = false;
            // 
            // ImageMessageControlLeft
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgContainer);
            this.Name = "ImageMessageControlLeft";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(600, 225);
            this.msgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.PictureBox imageMsg;
    }
}
