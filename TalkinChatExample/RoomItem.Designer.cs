namespace TalkinChatExample
{
    partial class RoomItem
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
            this.roomUsersLbl = new System.Windows.Forms.Label();
            this.roomMemPic = new System.Windows.Forms.PictureBox();
            this.roomLockPic = new System.Windows.Forms.PictureBox();
            this.roomNameLbl = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomIconLbl = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.roomsMaterialContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.joinRoomStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.membersModeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lockedModeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fillPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomMemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomLockPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.roomsMaterialContextMenuStrip.SuspendLayout();
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
            this.fillPanel.Size = new System.Drawing.Size(260, 70);
            this.fillPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.roomUsersLbl);
            this.panel3.Controls.Add(this.roomMemPic);
            this.panel3.Controls.Add(this.roomLockPic);
            this.panel3.Controls.Add(this.roomNameLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(47, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 69);
            this.panel3.TabIndex = 4;
            // 
            // roomUsersLbl
            // 
            this.roomUsersLbl.AutoSize = true;
            this.roomUsersLbl.ForeColor = System.Drawing.Color.DimGray;
            this.roomUsersLbl.Location = new System.Drawing.Point(2, 36);
            this.roomUsersLbl.Name = "roomUsersLbl";
            this.roomUsersLbl.Size = new System.Drawing.Size(54, 17);
            this.roomUsersLbl.TabIndex = 5;
            this.roomUsersLbl.Text = "(20/50)";
            // 
            // roomMemPic
            // 
            this.roomMemPic.Image = global::TalkinChatExample.Properties.Resources.membersOnlyIcon;
            this.roomMemPic.Location = new System.Drawing.Point(181, 35);
            this.roomMemPic.Name = "roomMemPic";
            this.roomMemPic.Size = new System.Drawing.Size(16, 16);
            this.roomMemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roomMemPic.TabIndex = 4;
            this.roomMemPic.TabStop = false;
            // 
            // roomLockPic
            // 
            this.roomLockPic.Image = global::TalkinChatExample.Properties.Resources.lockedIcon;
            this.roomLockPic.Location = new System.Drawing.Point(159, 35);
            this.roomLockPic.Name = "roomLockPic";
            this.roomLockPic.Size = new System.Drawing.Size(16, 16);
            this.roomLockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roomLockPic.TabIndex = 3;
            this.roomLockPic.TabStop = false;
            // 
            // roomNameLbl
            // 
            this.roomNameLbl.AutoEllipsis = true;
            this.roomNameLbl.Depth = 0;
            this.roomNameLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.roomNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roomNameLbl.Location = new System.Drawing.Point(1, 10);
            this.roomNameLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomNameLbl.Name = "roomNameLbl";
            this.roomNameLbl.Size = new System.Drawing.Size(209, 24);
            this.roomNameLbl.TabIndex = 0;
            this.roomNameLbl.Text = "Room Name";
            this.roomNameLbl.TextChanged += new System.EventHandler(this.roomNameLbl_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.roomIconLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 69);
            this.panel1.TabIndex = 1;
            // 
            // roomIconLbl
            // 
            this.roomIconLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIconLbl.Location = new System.Drawing.Point(7, 17);
            this.roomIconLbl.Name = "roomIconLbl";
            this.roomIconLbl.Size = new System.Drawing.Size(32, 32);
            this.roomIconLbl.TabIndex = 0;
            this.roomIconLbl.Text = "R";
            this.roomIconLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.Gainsboro;
            this.divider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.divider.Location = new System.Drawing.Point(0, 69);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(260, 1);
            this.divider.TabIndex = 2;
            // 
            // roomsMaterialContextMenuStrip
            // 
            this.roomsMaterialContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roomsMaterialContextMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roomsMaterialContextMenuStrip.Depth = 0;
            this.roomsMaterialContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.roomsMaterialContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinRoomStripMenuItem,
            this.searchRoomToolStripMenuItem});
            this.roomsMaterialContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomsMaterialContextMenuStrip.Name = "materialContextMenuStrip1";
            this.roomsMaterialContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.roomsMaterialContextMenuStrip.ShowImageMargin = false;
            this.roomsMaterialContextMenuStrip.Size = new System.Drawing.Size(142, 52);
            this.roomsMaterialContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.roomsMaterialContextMenuStrip_Opening);
            // 
            // joinRoomStripMenuItem
            // 
            this.joinRoomStripMenuItem.Name = "joinRoomStripMenuItem";
            this.joinRoomStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.joinRoomStripMenuItem.Text = "Join Room";
            this.joinRoomStripMenuItem.Click += new System.EventHandler(this.joinRoomStripMenuItem_Click);
            // 
            // searchRoomToolStripMenuItem
            // 
            this.searchRoomToolStripMenuItem.Name = "searchRoomToolStripMenuItem";
            this.searchRoomToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.searchRoomToolStripMenuItem.Text = "Search Room";
            this.searchRoomToolStripMenuItem.Click += new System.EventHandler(this.searchRoomToolStripMenuItem_Click);
            // 
            // RoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.roomsMaterialContextMenuStrip;
            this.Controls.Add(this.fillPanel);
            this.Name = "RoomItem";
            this.Size = new System.Drawing.Size(260, 70);
            this.fillPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomMemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomLockPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.roomsMaterialContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label divider;
        private MaterialSkin.Controls.MaterialContextMenuStrip roomsMaterialContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem joinRoomStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchRoomToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel roomNameLbl;
        private System.Windows.Forms.Label roomIconLbl;
        private System.Windows.Forms.Label roomUsersLbl;
        private System.Windows.Forms.PictureBox roomMemPic;
        private System.Windows.Forms.PictureBox roomLockPic;
        private System.Windows.Forms.ToolTip roomNameToolTip;
        private System.Windows.Forms.ToolTip membersModeToolTip;
        private System.Windows.Forms.ToolTip lockedModeToolTip;
    }
}
