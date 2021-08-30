namespace TalkinChatExample
{
    partial class RoomEventUpdateMiddle
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
            this.eventMsgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventMsgLbl
            // 
            this.eventMsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.eventMsgLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventMsgLbl.ForeColor = System.Drawing.Color.Gray;
            this.eventMsgLbl.Location = new System.Drawing.Point(4, 4);
            this.eventMsgLbl.Margin = new System.Windows.Forms.Padding(0);
            this.eventMsgLbl.Name = "eventMsgLbl";
            this.eventMsgLbl.Size = new System.Drawing.Size(452, 32);
            this.eventMsgLbl.TabIndex = 13;
            this.eventMsgLbl.Text = "you joined as member.";
            this.eventMsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomEventUpdateMiddle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.eventMsgLbl);
            this.Name = "RoomEventUpdateMiddle";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(460, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventMsgLbl;
    }
}
