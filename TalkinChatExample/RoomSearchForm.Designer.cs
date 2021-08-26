namespace TalkinChatExample
{
    partial class RoomSearchForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.searchBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.roomsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 40);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchTextField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 40);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 40);
            this.panel3.TabIndex = 7;
            // 
            // searchTextField
            // 
            this.searchTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchTextField.Depth = 0;
            this.searchTextField.Hint = "Enter room name";
            this.searchTextField.Location = new System.Drawing.Point(9, 8);
            this.searchTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTextField.Name = "searchTextField";
            this.searchTextField.PasswordChar = '\0';
            this.searchTextField.SelectedText = "";
            this.searchTextField.SelectionLength = 0;
            this.searchTextField.SelectionStart = 0;
            this.searchTextField.Size = new System.Drawing.Size(151, 28);
            this.searchTextField.TabIndex = 0;
            this.searchTextField.UseSystemPasswordChar = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Depth = 0;
            this.searchBtn.Location = new System.Drawing.Point(6, 4);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Primary = true;
            this.searchBtn.Size = new System.Drawing.Size(79, 36);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // roomsPanel
            // 
            this.roomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.roomsPanel.Location = new System.Drawing.Point(0, 40);
            this.roomsPanel.Name = "roomsPanel";
            this.roomsPanel.Size = new System.Drawing.Size(257, 333);
            this.roomsPanel.TabIndex = 6;
            this.roomsPanel.WrapContents = false;
            // 
            // RoomSearchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(257, 373);
            this.Controls.Add(this.roomsPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 420);
            this.Name = "RoomSearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Room Search";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton searchBtn;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchTextField;
        private System.Windows.Forms.FlowLayoutPanel roomsPanel;
    }
}