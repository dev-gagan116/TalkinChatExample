namespace TalkinChatExample
{
    partial class MainTabControl
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
            this.contactsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.contactstabPage = new System.Windows.Forms.TabPage();
            this.contactsPanelView = new System.Windows.Forms.FlowLayoutPanel();
            this.roomstabPage = new System.Windows.Forms.TabPage();
            this.chatroomsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.favtabPage = new System.Windows.Forms.TabPage();
            this.favLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.publictabPage = new System.Windows.Forms.TabPage();
            this.publicLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.joinedtabPage = new System.Windows.Forms.TabPage();
            this.joinedLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chatroomsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.contactsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.contactsTabControl.SuspendLayout();
            this.contactstabPage.SuspendLayout();
            this.roomstabPage.SuspendLayout();
            this.chatroomsTabControl.SuspendLayout();
            this.favtabPage.SuspendLayout();
            this.publictabPage.SuspendLayout();
            this.joinedtabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsTabControl
            // 
            this.contactsTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.contactsTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.contactsTabControl.Controls.Add(this.contactstabPage);
            this.contactsTabControl.Controls.Add(this.roomstabPage);
            this.contactsTabControl.Depth = 0;
            this.contactsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsTabControl.ItemSize = new System.Drawing.Size(146, 28);
            this.contactsTabControl.Location = new System.Drawing.Point(0, 0);
            this.contactsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactsTabControl.Name = "contactsTabControl";
            this.contactsTabControl.SelectedIndex = 0;
            this.contactsTabControl.Size = new System.Drawing.Size(300, 419);
            this.contactsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.contactsTabControl.TabIndex = 0;
            this.contactsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.contactsTabControl_Selected);
            // 
            // contactstabPage
            // 
            this.contactstabPage.Controls.Add(this.contactsPanelView);
            this.contactstabPage.Location = new System.Drawing.Point(4, 4);
            this.contactstabPage.Name = "contactstabPage";
            this.contactstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactstabPage.Size = new System.Drawing.Size(292, 0);
            this.contactstabPage.TabIndex = 0;
            this.contactstabPage.Text = "Contact list";
            this.contactstabPage.UseVisualStyleBackColor = true;
            // 
            // contactsPanelView
            // 
            this.contactsPanelView.AutoScroll = true;
            this.contactsPanelView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.contactsPanelView.Location = new System.Drawing.Point(0, 0);
            this.contactsPanelView.Name = "contactsPanelView";
            this.contactsPanelView.Size = new System.Drawing.Size(296, 421);
            this.contactsPanelView.TabIndex = 0;
            this.contactsPanelView.WrapContents = false;
            // 
            // roomstabPage
            // 
            this.roomstabPage.Controls.Add(this.chatroomsTabControl);
            this.roomstabPage.Controls.Add(this.chatroomsTabSelector);
            this.roomstabPage.Location = new System.Drawing.Point(4, 4);
            this.roomstabPage.Name = "roomstabPage";
            this.roomstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomstabPage.Size = new System.Drawing.Size(292, 0);
            this.roomstabPage.TabIndex = 1;
            this.roomstabPage.Text = "Chat Rooms";
            this.roomstabPage.UseVisualStyleBackColor = true;
            // 
            // chatroomsTabControl
            // 
            this.chatroomsTabControl.Controls.Add(this.favtabPage);
            this.chatroomsTabControl.Controls.Add(this.publictabPage);
            this.chatroomsTabControl.Controls.Add(this.joinedtabPage);
            this.chatroomsTabControl.Depth = 0;
            this.chatroomsTabControl.Location = new System.Drawing.Point(-1, 39);
            this.chatroomsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.chatroomsTabControl.Name = "chatroomsTabControl";
            this.chatroomsTabControl.SelectedIndex = 0;
            this.chatroomsTabControl.Size = new System.Drawing.Size(296, 385);
            this.chatroomsTabControl.TabIndex = 1;
            this.chatroomsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.chatroomsTabControl_Selected);
            // 
            // favtabPage
            // 
            this.favtabPage.Controls.Add(this.favLayoutPanel);
            this.favtabPage.Location = new System.Drawing.Point(4, 29);
            this.favtabPage.Name = "favtabPage";
            this.favtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.favtabPage.Size = new System.Drawing.Size(288, 352);
            this.favtabPage.TabIndex = 0;
            this.favtabPage.Text = "Favourite";
            this.favtabPage.UseVisualStyleBackColor = true;
            // 
            // favLayoutPanel
            // 
            this.favLayoutPanel.AutoScroll = true;
            this.favLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.favLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.favLayoutPanel.Name = "favLayoutPanel";
            this.favLayoutPanel.Size = new System.Drawing.Size(282, 346);
            this.favLayoutPanel.TabIndex = 3;
            this.favLayoutPanel.WrapContents = false;
            // 
            // publictabPage
            // 
            this.publictabPage.Controls.Add(this.publicLayoutPanel);
            this.publictabPage.Location = new System.Drawing.Point(4, 29);
            this.publictabPage.Name = "publictabPage";
            this.publictabPage.Padding = new System.Windows.Forms.Padding(3);
            this.publictabPage.Size = new System.Drawing.Size(288, 352);
            this.publictabPage.TabIndex = 1;
            this.publictabPage.Text = "Public";
            this.publictabPage.UseVisualStyleBackColor = true;
            // 
            // publicLayoutPanel
            // 
            this.publicLayoutPanel.AutoScroll = true;
            this.publicLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publicLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.publicLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.publicLayoutPanel.Name = "publicLayoutPanel";
            this.publicLayoutPanel.Size = new System.Drawing.Size(282, 346);
            this.publicLayoutPanel.TabIndex = 3;
            this.publicLayoutPanel.WrapContents = false;
            // 
            // joinedtabPage
            // 
            this.joinedtabPage.Controls.Add(this.joinedLayoutPanel);
            this.joinedtabPage.Location = new System.Drawing.Point(4, 29);
            this.joinedtabPage.Name = "joinedtabPage";
            this.joinedtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.joinedtabPage.Size = new System.Drawing.Size(288, 352);
            this.joinedtabPage.TabIndex = 2;
            this.joinedtabPage.Text = "Joined";
            this.joinedtabPage.UseVisualStyleBackColor = true;
            // 
            // joinedLayoutPanel
            // 
            this.joinedLayoutPanel.AutoScroll = true;
            this.joinedLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinedLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.joinedLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.joinedLayoutPanel.Name = "joinedLayoutPanel";
            this.joinedLayoutPanel.Size = new System.Drawing.Size(282, 346);
            this.joinedLayoutPanel.TabIndex = 3;
            this.joinedLayoutPanel.WrapContents = false;
            // 
            // chatroomsTabSelector
            // 
            this.chatroomsTabSelector.BaseTabControl = this.chatroomsTabControl;
            this.chatroomsTabSelector.Depth = 0;
            this.chatroomsTabSelector.Location = new System.Drawing.Point(-4, -4);
            this.chatroomsTabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.chatroomsTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.chatroomsTabSelector.Name = "chatroomsTabSelector";
            this.chatroomsTabSelector.Size = new System.Drawing.Size(313, 40);
            this.chatroomsTabSelector.TabIndex = 0;
            this.chatroomsTabSelector.Text = "materialTabSelector1";
            // 
            // contactsTabSelector
            // 
            this.contactsTabSelector.BaseTabControl = this.contactsTabControl;
            this.contactsTabSelector.Depth = 0;
            this.contactsTabSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactsTabSelector.Location = new System.Drawing.Point(0, 425);
            this.contactsTabSelector.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.contactsTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactsTabSelector.Name = "contactsTabSelector";
            this.contactsTabSelector.Size = new System.Drawing.Size(300, 40);
            this.contactsTabSelector.TabIndex = 1;
            this.contactsTabSelector.Text = "materialTabSelector1";
            // 
            // MainTabControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.contactsTabSelector);
            this.Controls.Add(this.contactsTabControl);
            this.MaximumSize = new System.Drawing.Size(300, 465);
            this.MinimumSize = new System.Drawing.Size(300, 465);
            this.Name = "MainTabControl";
            this.Size = new System.Drawing.Size(300, 465);
            this.contactsTabControl.ResumeLayout(false);
            this.contactstabPage.ResumeLayout(false);
            this.roomstabPage.ResumeLayout(false);
            this.chatroomsTabControl.ResumeLayout(false);
            this.favtabPage.ResumeLayout(false);
            this.publictabPage.ResumeLayout(false);
            this.joinedtabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl contactsTabControl;
        private System.Windows.Forms.TabPage contactstabPage;
        private System.Windows.Forms.TabPage roomstabPage;
        private MaterialSkin.Controls.MaterialTabSelector contactsTabSelector;
        private MaterialSkin.Controls.MaterialTabControl chatroomsTabControl;
        private System.Windows.Forms.TabPage favtabPage;
        private System.Windows.Forms.TabPage publictabPage;
        private System.Windows.Forms.TabPage joinedtabPage;
        private MaterialSkin.Controls.MaterialTabSelector chatroomsTabSelector;
        private System.Windows.Forms.FlowLayoutPanel contactsPanelView;
        private System.Windows.Forms.FlowLayoutPanel favLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel publicLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel joinedLayoutPanel;
    }
}
