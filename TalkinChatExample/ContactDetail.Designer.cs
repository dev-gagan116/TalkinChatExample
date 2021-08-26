namespace TalkinChatExample
{
    partial class ContactDetail
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
            this.components = new System.ComponentModel.Container();
            this.usernameLbl = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageLbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.maleLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.friendsLbl = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.activityLbl = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.createdLbl = new System.Windows.Forms.Label();
            this.merchantLbl = new System.Windows.Forms.Label();
            this.usernameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameLbl.AutoEllipsis = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Depth = 0;
            this.usernameLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLbl.Location = new System.Drawing.Point(0, 108);
            this.usernameLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(177, 21);
            this.usernameLbl.TabIndex = 4;
            this.usernameLbl.Text = "@username";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameLbl.TextChanged += new System.EventHandler(this.usernameLbl_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 135);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.profilePicBox);
            this.panel4.Controls.Add(this.usernameLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(45, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 135);
            this.panel4.TabIndex = 8;
            // 
            // profilePicBox
            // 
            this.profilePicBox.Image = global::TalkinChatExample.Properties.Resources.profile_user;
            this.profilePicBox.Location = new System.Drawing.Point(50, 29);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(72, 72);
            this.profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicBox.TabIndex = 3;
            this.profilePicBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(225, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 135);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 135);
            this.panel2.TabIndex = 6;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoEllipsis = true;
            this.messageLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.messageLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.messageLbl.Location = new System.Drawing.Point(0, 135);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(270, 25);
            this.messageLbl.TabIndex = 6;
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 52);
            this.panel5.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.maleLbl);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(90, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(87, 52);
            this.panel8.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(0, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maleLbl
            // 
            this.maleLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.maleLbl.Location = new System.Drawing.Point(0, 35);
            this.maleLbl.Name = "maleLbl";
            this.maleLbl.Size = new System.Drawing.Size(87, 17);
            this.maleLbl.TabIndex = 3;
            this.maleLbl.Text = "N/A";
            this.maleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.ageLbl);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(177, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(93, 52);
            this.panel7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(0, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Age";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageLbl
            // 
            this.ageLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ageLbl.Location = new System.Drawing.Point(0, 35);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(93, 17);
            this.ageLbl.TabIndex = 5;
            this.ageLbl.Text = "N/A";
            this.ageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.countryLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(90, 52);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Country";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryLabel
            // 
            this.countryLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.countryLabel.Location = new System.Drawing.Point(0, 35);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(90, 17);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.Text = "N/A";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 212);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 55);
            this.panel9.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.friendsLbl);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(90, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(87, 55);
            this.panel12.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(0, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Friends";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendsLbl
            // 
            this.friendsLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.friendsLbl.Location = new System.Drawing.Point(0, 38);
            this.friendsLbl.Name = "friendsLbl";
            this.friendsLbl.Size = new System.Drawing.Size(87, 17);
            this.friendsLbl.TabIndex = 3;
            this.friendsLbl.Text = "N/A";
            this.friendsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.activityLbl);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(177, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(93, 55);
            this.panel11.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(0, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Last Activity";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activityLbl
            // 
            this.activityLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activityLbl.Location = new System.Drawing.Point(0, 38);
            this.activityLbl.Name = "activityLbl";
            this.activityLbl.Size = new System.Drawing.Size(93, 17);
            this.activityLbl.TabIndex = 3;
            this.activityLbl.Text = "N/A";
            this.activityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.createdLbl);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(90, 55);
            this.panel10.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(0, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Created";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createdLbl
            // 
            this.createdLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createdLbl.Location = new System.Drawing.Point(0, 38);
            this.createdLbl.Name = "createdLbl";
            this.createdLbl.Size = new System.Drawing.Size(90, 17);
            this.createdLbl.TabIndex = 3;
            this.createdLbl.Text = "N/A";
            this.createdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // merchantLbl
            // 
            this.merchantLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.merchantLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merchantLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.merchantLbl.Location = new System.Drawing.Point(0, 267);
            this.merchantLbl.Name = "merchantLbl";
            this.merchantLbl.Size = new System.Drawing.Size(270, 103);
            this.merchantLbl.TabIndex = 9;
            this.merchantLbl.Text = "Merchant";
            this.merchantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.merchantLbl.Visible = false;
            // 
            // ContactDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(270, 370);
            this.Controls.Add(this.merchantLbl);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(288, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(288, 417);
            this.Name = "ContactDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Profile";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox profilePicBox;
        private MaterialSkin.Controls.MaterialLabel usernameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label maleLbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label friendsLbl;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label activityLbl;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label createdLbl;
        private System.Windows.Forms.Label merchantLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip usernameToolTip;
    }
}