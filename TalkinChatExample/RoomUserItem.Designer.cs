namespace TalkinChatExample
{
    partial class RoomUserItem
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
            this.components = new System.ComponentModel.Container();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Label();
            this.contactsMaterialContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.openChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fillPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.contactsMaterialContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillPanel
            // 
            this.fillPanel.Controls.Add(this.panel3);
            this.fillPanel.Controls.Add(this.panel1);
            this.fillPanel.Controls.Add(this.divider);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(0, 0);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(130, 36);
            this.fillPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usernameLbl);
            this.panel3.Controls.Add(this.roleLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 35);
            this.panel3.TabIndex = 6;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoEllipsis = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(0, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(100, 17);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "username";
            this.usernameLbl.TextChanged += new System.EventHandler(this.usernameLbl_TextChanged);
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.BackColor = System.Drawing.Color.Transparent;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.ForeColor = System.Drawing.Color.DimGray;
            this.roleLbl.Location = new System.Drawing.Point(3, 18);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(54, 15);
            this.roleLbl.TabIndex = 0;
            this.roleLbl.Text = "member";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 35);
            this.panel1.TabIndex = 4;
            // 
            // userPic
            // 
            this.userPic.Image = global::TalkinChatExample.Properties.Resources.profile_user;
            this.userPic.Location = new System.Drawing.Point(2, 6);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(24, 24);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 0;
            this.userPic.TabStop = false;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.Gainsboro;
            this.divider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.divider.Location = new System.Drawing.Point(0, 35);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(130, 1);
            this.divider.TabIndex = 0;
            // 
            // contactsMaterialContextMenuStrip
            // 
            this.contactsMaterialContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contactsMaterialContextMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactsMaterialContextMenuStrip.Depth = 0;
            this.contactsMaterialContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contactsMaterialContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openChatToolStripMenuItem,
            this.viewProfileToolStripMenuItem});
            this.contactsMaterialContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactsMaterialContextMenuStrip.Name = "materialContextMenuStrip1";
            this.contactsMaterialContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contactsMaterialContextMenuStrip.ShowImageMargin = false;
            this.contactsMaterialContextMenuStrip.Size = new System.Drawing.Size(133, 52);
            // 
            // openChatToolStripMenuItem
            // 
            this.openChatToolStripMenuItem.Name = "openChatToolStripMenuItem";
            this.openChatToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.openChatToolStripMenuItem.Text = "Open Chat";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // RoomUserItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.fillPanel);
            this.Name = "RoomUserItem";
            this.Size = new System.Drawing.Size(130, 36);
            this.DoubleClick += new System.EventHandler(this.ContactItem_DoubleClick);
            this.fillPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.contactsMaterialContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label usernameLbl;
        private MaterialSkin.Controls.MaterialContextMenuStrip contactsMaterialContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolTip usernameToolTip;
    }
}
