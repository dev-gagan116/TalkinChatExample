namespace TalkinChatExample
{
    partial class LoginControl
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
            this.loginBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.passTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusLbl = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = true;
            this.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.Depth = 0;
            this.loginBtn.Location = new System.Drawing.Point(44, 360);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Primary = true;
            this.loginBtn.Size = new System.Drawing.Size(73, 36);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Sign In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Depth = 0;
            this.passTextBox.Hint = "Password";
            this.passTextBox.Location = new System.Drawing.Point(44, 252);
            this.passTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionLength = 0;
            this.passTextBox.SelectionStart = 0;
            this.passTextBox.Size = new System.Drawing.Size(213, 28);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.UseSystemPasswordChar = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Hint = "Username";
            this.usernameTextBox.Location = new System.Drawing.Point(44, 203);
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.Size = new System.Drawing.Size(213, 28);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TalkinChatExample.Properties.Resources.talkinchatIcon;
            this.pictureBox1.Location = new System.Drawing.Point(118, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statusLbl.Depth = 0;
            this.statusLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.statusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLbl.Location = new System.Drawing.Point(0, 442);
            this.statusLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLbl.Size = new System.Drawing.Size(299, 20);
            this.statusLbl.TabIndex = 9;
            this.statusLbl.Text = "...";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(300, 465);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton loginBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField passTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel statusLbl;
    }
}
