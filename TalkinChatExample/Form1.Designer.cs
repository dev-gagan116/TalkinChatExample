namespace TalkinChatExample
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contactslistView = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roomTabControl = new System.Windows.Forms.TabControl();
            this.favPage = new System.Windows.Forms.TabPage();
            this.favlistView = new System.Windows.Forms.ListView();
            this.publicPage = new System.Windows.Forms.TabPage();
            this.puliclistView = new System.Windows.Forms.ListView();
            this.joinedPage = new System.Windows.Forms.TabPage();
            this.joinedlistView = new System.Windows.Forms.ListView();
            this.privatePage = new System.Windows.Forms.TabPage();
            this.privatelistView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.roomTabControl.SuspendLayout();
            this.favPage.SuspendLayout();
            this.publicPage.SuspendLayout();
            this.joinedPage.SuspendLayout();
            this.privatePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusLbl);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Panel";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(13, 127);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(20, 17);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "...";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(10, 88);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 35);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(89, 55);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(136, 22);
            this.passTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(89, 21);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(136, 22);
            this.usernameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contactslistView);
            this.groupBox2.Location = new System.Drawing.Point(1, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacts";
            // 
            // contactslistView
            // 
            this.contactslistView.Location = new System.Drawing.Point(4, 19);
            this.contactslistView.Name = "contactslistView";
            this.contactslistView.Size = new System.Drawing.Size(221, 248);
            this.contactslistView.TabIndex = 6;
            this.contactslistView.UseCompatibleStateImageBehavior = false;
            this.contactslistView.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.roomTabControl);
            this.groupBox3.Location = new System.Drawing.Point(237, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 422);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chat Rooms";
            // 
            // roomTabControl
            // 
            this.roomTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.roomTabControl.Controls.Add(this.favPage);
            this.roomTabControl.Controls.Add(this.publicPage);
            this.roomTabControl.Controls.Add(this.joinedPage);
            this.roomTabControl.Controls.Add(this.privatePage);
            this.roomTabControl.Location = new System.Drawing.Point(1, 18);
            this.roomTabControl.Name = "roomTabControl";
            this.roomTabControl.SelectedIndex = 0;
            this.roomTabControl.Size = new System.Drawing.Size(267, 401);
            this.roomTabControl.TabIndex = 0;
            this.roomTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.roomTabControl_Selected);
            // 
            // favPage
            // 
            this.favPage.Controls.Add(this.favlistView);
            this.favPage.Location = new System.Drawing.Point(4, 28);
            this.favPage.Name = "favPage";
            this.favPage.Size = new System.Drawing.Size(259, 369);
            this.favPage.TabIndex = 5;
            this.favPage.Text = "Favourite";
            this.favPage.UseVisualStyleBackColor = true;
            // 
            // favlistView
            // 
            this.favlistView.Location = new System.Drawing.Point(-1, -1);
            this.favlistView.Name = "favlistView";
            this.favlistView.Size = new System.Drawing.Size(264, 377);
            this.favlistView.TabIndex = 7;
            this.favlistView.UseCompatibleStateImageBehavior = false;
            this.favlistView.View = System.Windows.Forms.View.List;
            // 
            // publicPage
            // 
            this.publicPage.Controls.Add(this.puliclistView);
            this.publicPage.Location = new System.Drawing.Point(4, 28);
            this.publicPage.Name = "publicPage";
            this.publicPage.Padding = new System.Windows.Forms.Padding(3);
            this.publicPage.Size = new System.Drawing.Size(259, 369);
            this.publicPage.TabIndex = 1;
            this.publicPage.Text = "Public";
            this.publicPage.UseVisualStyleBackColor = true;
            // 
            // puliclistView
            // 
            this.puliclistView.Location = new System.Drawing.Point(-3, -4);
            this.puliclistView.Name = "puliclistView";
            this.puliclistView.Size = new System.Drawing.Size(264, 377);
            this.puliclistView.TabIndex = 8;
            this.puliclistView.UseCompatibleStateImageBehavior = false;
            // 
            // joinedPage
            // 
            this.joinedPage.Controls.Add(this.joinedlistView);
            this.joinedPage.Location = new System.Drawing.Point(4, 28);
            this.joinedPage.Name = "joinedPage";
            this.joinedPage.Size = new System.Drawing.Size(259, 369);
            this.joinedPage.TabIndex = 3;
            this.joinedPage.Text = "Joined";
            this.joinedPage.UseVisualStyleBackColor = true;
            // 
            // joinedlistView
            // 
            this.joinedlistView.Location = new System.Drawing.Point(-3, -4);
            this.joinedlistView.Name = "joinedlistView";
            this.joinedlistView.Size = new System.Drawing.Size(264, 377);
            this.joinedlistView.TabIndex = 8;
            this.joinedlistView.UseCompatibleStateImageBehavior = false;
            // 
            // privatePage
            // 
            this.privatePage.Controls.Add(this.privatelistView);
            this.privatePage.Location = new System.Drawing.Point(4, 28);
            this.privatePage.Name = "privatePage";
            this.privatePage.Size = new System.Drawing.Size(259, 369);
            this.privatePage.TabIndex = 4;
            this.privatePage.Text = "Private";
            this.privatePage.UseVisualStyleBackColor = true;
            // 
            // privatelistView
            // 
            this.privatelistView.Location = new System.Drawing.Point(-3, -4);
            this.privatelistView.Name = "privatelistView";
            this.privatelistView.Size = new System.Drawing.Size(264, 377);
            this.privatelistView.TabIndex = 8;
            this.privatelistView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TalkinChat - PC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.roomTabControl.ResumeLayout(false);
            this.favPage.ResumeLayout(false);
            this.publicPage.ResumeLayout(false);
            this.joinedPage.ResumeLayout(false);
            this.privatePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl roomTabControl;
        private System.Windows.Forms.TabPage publicPage;
        private System.Windows.Forms.TabPage joinedPage;
        private System.Windows.Forms.TabPage privatePage;
        private System.Windows.Forms.TabPage favPage;
        private System.Windows.Forms.ListView contactslistView;
        private System.Windows.Forms.ListView favlistView;
        private System.Windows.Forms.ListView puliclistView;
        private System.Windows.Forms.ListView joinedlistView;
        private System.Windows.Forms.ListView privatelistView;
    }
}

