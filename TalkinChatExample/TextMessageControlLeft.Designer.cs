namespace TalkinChatExample
{
    partial class TextMessageControlLeft
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
            this.timeLbl = new System.Windows.Forms.Label();
            this.msgContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgContainer
            // 
            this.msgContainer.AutoSize = true;
            this.msgContainer.BackColor = System.Drawing.Color.White;
            this.msgContainer.Controls.Add(this.textMsgLbl);
            this.msgContainer.Controls.Add(this.timeLbl);
            this.msgContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msgContainer.Location = new System.Drawing.Point(8, 8);
            this.msgContainer.Name = "msgContainer";
            this.msgContainer.Padding = new System.Windows.Forms.Padding(4);
            this.msgContainer.Size = new System.Drawing.Size(90, 44);
            this.msgContainer.TabIndex = 1;
            // 
            // textMsgLbl
            // 
            this.textMsgLbl.AutoSize = true;
            this.textMsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.textMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textMsgLbl.Location = new System.Drawing.Point(4, 4);
            this.textMsgLbl.Margin = new System.Windows.Forms.Padding(0);
            this.textMsgLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.textMsgLbl.MinimumSize = new System.Drawing.Size(80, 16);
            this.textMsgLbl.Name = "textMsgLbl";
            this.textMsgLbl.Size = new System.Drawing.Size(80, 20);
            this.textMsgLbl.TabIndex = 11;
            this.textMsgLbl.Text = "Hi";
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Gray;
            this.timeLbl.Location = new System.Drawing.Point(14, 24);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(70, 16);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "09:25 am";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TextMessageControlLeft
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msgContainer);
            this.Name = "TextMessageControlLeft";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(600, 150);
            this.msgContainer.ResumeLayout(false);
            this.msgContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel msgContainer;
        private System.Windows.Forms.Label textMsgLbl;
        private System.Windows.Forms.Label timeLbl;
    }
}
