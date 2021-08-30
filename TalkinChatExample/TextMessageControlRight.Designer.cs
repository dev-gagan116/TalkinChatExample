namespace TalkinChatExample
{
    partial class TextMessageControlRight
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
            this.textMsgLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgStatePic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeLbl = new System.Windows.Forms.Label();
            this.msgContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgStatePic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgContainer
            // 
            this.msgContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.msgContainer.Controls.Add(this.textMsgLbl);
            this.msgContainer.Controls.Add(this.panel3);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(481, 7);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(113, 52);
            this.msgContainer.TabIndex = 2;
            // 
            // textMsgLbl
            // 
            this.textMsgLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textMsgLbl.AutoSize = true;
            this.textMsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.textMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgLbl.ForeColor = System.Drawing.Color.Black;
            this.textMsgLbl.Location = new System.Drawing.Point(29, 4);
            this.textMsgLbl.Margin = new System.Windows.Forms.Padding(0);
            this.textMsgLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.textMsgLbl.MinimumSize = new System.Drawing.Size(80, 16);
            this.textMsgLbl.Name = "textMsgLbl";
            this.textMsgLbl.Size = new System.Drawing.Size(80, 20);
            this.textMsgLbl.TabIndex = 11;
            this.textMsgLbl.Text = "Hi";
            this.textMsgLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(4, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 24);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(75, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 24);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msgStatePic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(77, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 24);
            this.panel1.TabIndex = 4;
            // 
            // msgStatePic
            // 
            this.msgStatePic.BackColor = System.Drawing.Color.Transparent;
            this.msgStatePic.Image = global::TalkinChatExample.Properties.Resources.msg_sending;
            this.msgStatePic.Location = new System.Drawing.Point(8, 7);
            this.msgStatePic.Name = "msgStatePic";
            this.msgStatePic.Size = new System.Drawing.Size(12, 12);
            this.msgStatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.msgStatePic.TabIndex = 15;
            this.msgStatePic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.timeLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 24);
            this.panel2.TabIndex = 3;
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Gray;
            this.timeLbl.Location = new System.Drawing.Point(7, 1);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(62, 20);
            this.timeLbl.TabIndex = 14;
            this.timeLbl.Text = "09:25 am";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextMessageControlRight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgContainer);
            this.Name = "TextMessageControlRight";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(600, 208);
            this.msgContainer.ResumeLayout(false);
            this.msgContainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgStatePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label textMsgLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox msgStatePic;
    }
}
