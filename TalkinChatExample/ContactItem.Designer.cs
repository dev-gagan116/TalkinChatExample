namespace TalkinChatExample
{
    partial class ContactItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactItem));
            this.fillPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernameLbl = new MaterialSkin.Controls.MaterialLabel();
            this.messageLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modePic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Label();
            this.openChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsMaterialContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.acceptReqStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unblockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.modeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fillPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modePic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.contactsMaterialContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillPanel
            // 
            this.fillPanel.Controls.Add(this.panel3);
            this.fillPanel.Controls.Add(this.panel2);
            this.fillPanel.Controls.Add(this.panel1);
            this.fillPanel.Controls.Add(this.divider);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(0, 0);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(270, 53);
            this.fillPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usernameLbl);
            this.panel3.Controls.Add(this.messageLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(46, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 52);
            this.panel3.TabIndex = 6;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoEllipsis = true;
            this.usernameLbl.Depth = 0;
            this.usernameLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLbl.Location = new System.Drawing.Point(4, 3);
            this.usernameLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(191, 24);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "username";
            this.usernameLbl.TextChanged += new System.EventHandler(this.usernameLbl_TextChanged);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.ForeColor = System.Drawing.Color.DimGray;
            this.messageLbl.Location = new System.Drawing.Point(6, 27);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(46, 17);
            this.messageLbl.TabIndex = 0;
            this.messageLbl.Text = "offline";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.modePic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(247, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 52);
            this.panel2.TabIndex = 5;
            // 
            // modePic
            // 
            this.modePic.Image = ((System.Drawing.Image)(resources.GetObject("modePic.Image")));
            this.modePic.Location = new System.Drawing.Point(4, 20);
            this.modePic.Name = "modePic";
            this.modePic.Size = new System.Drawing.Size(16, 16);
            this.modePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modePic.TabIndex = 3;
            this.modePic.TabStop = false;
            this.modePic.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.modePic_LoadCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 52);
            this.panel1.TabIndex = 4;
            // 
            // userPic
            // 
            this.userPic.Image = global::TalkinChatExample.Properties.Resources.profile_user;
            this.userPic.Location = new System.Drawing.Point(5, 11);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(32, 32);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 0;
            this.userPic.TabStop = false;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.Gainsboro;
            this.divider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.divider.Location = new System.Drawing.Point(0, 52);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(270, 1);
            this.divider.TabIndex = 0;
            // 
            // openChatToolStripMenuItem
            // 
            this.openChatToolStripMenuItem.Name = "openChatToolStripMenuItem";
            this.openChatToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.openChatToolStripMenuItem.Text = "Open Chat";
            this.openChatToolStripMenuItem.Click += new System.EventHandler(this.openChatToolStripMenuItem_Click);
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.blockToolStripMenuItem.Text = "Block";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.blockToolStripMenuItem_Click);
            // 
            // contactsMaterialContextMenuStrip
            // 
            this.contactsMaterialContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contactsMaterialContextMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactsMaterialContextMenuStrip.Depth = 0;
            this.contactsMaterialContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contactsMaterialContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptReqStripMenuItem,
            this.openChatToolStripMenuItem,
            this.viewProfileToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.blockToolStripMenuItem,
            this.unblockToolStripMenuItem});
            this.contactsMaterialContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactsMaterialContextMenuStrip.Name = "materialContextMenuStrip1";
            this.contactsMaterialContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contactsMaterialContextMenuStrip.ShowImageMargin = false;
            this.contactsMaterialContextMenuStrip.Size = new System.Drawing.Size(157, 148);
            this.contactsMaterialContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contactsMaterialContextMenuStrip_Opening);
            // 
            // acceptReqStripMenuItem
            // 
            this.acceptReqStripMenuItem.Name = "acceptReqStripMenuItem";
            this.acceptReqStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.acceptReqStripMenuItem.Text = "Accept Request";
            this.acceptReqStripMenuItem.Visible = false;
            this.acceptReqStripMenuItem.Click += new System.EventHandler(this.acceptReqStripMenuItem_Click);
            // 
            // unblockToolStripMenuItem
            // 
            this.unblockToolStripMenuItem.Name = "unblockToolStripMenuItem";
            this.unblockToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.unblockToolStripMenuItem.Text = "Unblock";
            this.unblockToolStripMenuItem.Visible = false;
            this.unblockToolStripMenuItem.Click += new System.EventHandler(this.unblockToolStripMenuItem_Click);
            // 
            // ContactItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ContextMenuStrip = this.contactsMaterialContextMenuStrip;
            this.Controls.Add(this.fillPanel);
            this.Name = "ContactItem";
            this.Size = new System.Drawing.Size(270, 53);
            this.DoubleClick += new System.EventHandler(this.ContactItem_DoubleClick);
            this.fillPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modePic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.contactsMaterialContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.ToolStripMenuItem openChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip contactsMaterialContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem acceptReqStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unblockToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel usernameLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.PictureBox modePic;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.ToolTip usernameToolTip;
        private System.Windows.Forms.ToolTip modeToolTip;
    }
}
