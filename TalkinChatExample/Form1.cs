using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkinClient;
using TalkinClient.MultiUserChat;
using TalkinClient.User;

namespace TalkinChatExample
{
    public partial class Form1 : MaterialForm
    {
        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
        private TalkinChat chat;
        private ChatMessageForm chatMessage;
        public Form1()
        {
            InitializeComponent();
            contactslistView.View = View.Tile;
            contactslistView.HeaderStyle = ColumnHeaderStyle.None;

            favlistView.View = View.Tile;
            favlistView.HeaderStyle = ColumnHeaderStyle.None;

            puliclistView.View = View.Tile;
            puliclistView.HeaderStyle = ColumnHeaderStyle.None;

            joinedlistView.View = View.Tile;
            joinedlistView.HeaderStyle = ColumnHeaderStyle.None;

            privatelistView.View = View.Tile;
            privatelistView.HeaderStyle = ColumnHeaderStyle.None;

        }
        private void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(loginBtn.Text=="Login")
            {
                loginMe();
            }
            else
            {
                if(chat!=null)
                {
                    chat.Logout();
                    chat = null;
                }
            }
        }


        private void loginMe()
        {
            SetControlPropertyThreadSafe(statusLbl, "Text", "Connecting...");
            chat = new TalkinChat();
            chat.AutoReconnect = true;
            chat.ReconnectInterval = 10000;
            chat.OnLogin += (talkin, authCode) =>
            {
                switch(authCode)
                {
                    case TalkinClient.User.AuthCode.Success:
                        SetControlPropertyThreadSafe(usernameTextBox, "Enabled", false);
                        SetControlPropertyThreadSafe(passTextBox, "Enabled", false);
                        SetControlPropertyThreadSafe(loginBtn, "Text", "Logout");
                        SetControlPropertyThreadSafe(loginBtn, "BackColor", Color.Red);
                        SetControlPropertyThreadSafe(statusLbl, "Text", "Login Success.");
                        SetControlPropertyThreadSafe(statusLbl, "ForeColor", Color.Green);
                        chat.GetMucList(TalkinClient.MultiUserChat.MucType.favourite);
                        break;

                    case TalkinClient.User.AuthCode.Failed:
                        SetControlPropertyThreadSafe(usernameTextBox, "Enabled", true);
                        SetControlPropertyThreadSafe(passTextBox, "Enabled", true);
                        SetControlPropertyThreadSafe(loginBtn, "Text", "Login");
                        SetControlPropertyThreadSafe(loginBtn, "BackColor", Color.Green);
                        SetControlPropertyThreadSafe(statusLbl, "Text", "Wrong Password.");
                        SetControlPropertyThreadSafe(statusLbl, "ForeColor", Color.Red);
                        break;

                    case TalkinClient.User.AuthCode.Disabled:
                        SetControlPropertyThreadSafe(usernameTextBox, "Enabled", true);
                        SetControlPropertyThreadSafe(passTextBox, "Enabled", true);
                        SetControlPropertyThreadSafe(loginBtn, "Text", "Login");
                        SetControlPropertyThreadSafe(loginBtn, "BackColor", Color.Green);
                        SetControlPropertyThreadSafe(statusLbl, "Text", "Account has been disabled.");
                        SetControlPropertyThreadSafe(statusLbl, "ForeColor", Color.Black);
                        break;
                    case TalkinClient.User.AuthCode.Error:
                        SetControlPropertyThreadSafe(usernameTextBox, "Enabled", true);
                        SetControlPropertyThreadSafe(passTextBox, "Enabled", true);
                        SetControlPropertyThreadSafe(loginBtn, "Text", "Login");
                        SetControlPropertyThreadSafe(loginBtn, "BackColor", Color.Green);
                        SetControlPropertyThreadSafe(statusLbl, "Text", "Unable to login.");
                        SetControlPropertyThreadSafe(statusLbl, "ForeColor", Color.Black);
                        break;

                }


            };
           
            chat.OnLogout+=(talkin)=>
            {
                SetControlPropertyThreadSafe(usernameTextBox, "Enabled", true);
                SetControlPropertyThreadSafe(passTextBox, "Enabled", true);
                SetControlPropertyThreadSafe(loginBtn, "Text", "Login");
                SetControlPropertyThreadSafe(loginBtn, "BackColor", Color.Green);
                SetControlPropertyThreadSafe(statusLbl, "Text", "Logged out.");
                SetControlPropertyThreadSafe(statusLbl, "ForeColor", Color.Black);
            };
            chat.OnClose += (talkin) =>
            {
                SetControlPropertyThreadSafe(usernameTextBox, "Enabled", true);
                SetControlPropertyThreadSafe(passTextBox, "Enabled", true);
                SetControlPropertyThreadSafe(loginBtn, "Text", "Login");
                SetControlPropertyThreadSafe(loginBtn, "BackColor", Color.Green);
                if(chat.AutoReconnect)
                {
                    SetControlPropertyThreadSafe(statusLbl, "Text", "Reconnecting...");
                }
                else
                {
                    SetControlPropertyThreadSafe(statusLbl, "Text", "Disconnected.");

                }
                SetControlPropertyThreadSafe(statusLbl, "ForeColor", Color.Black);
            };
            chat.OnError += (talkin, error) =>
            {
                SetControlPropertyThreadSafe(usernameTextBox, "Enabled", true);
                SetControlPropertyThreadSafe(passTextBox, "Enabled", true);
                SetControlPropertyThreadSafe(loginBtn, "Text", "Login");
                SetControlPropertyThreadSafe(loginBtn, "BackColor", Color.Green);
                SetControlPropertyThreadSafe(statusLbl, "Text", "Error: "+error);
                SetControlPropertyThreadSafe(statusLbl, "ForeColor", Color.Black);
            };
            chat.OnRoster += (talkin, roster) =>
            {

                if (contactslistView.InvokeRequired)
                {
                    contactslistView.Invoke(new MethodInvoker(delegate
                    {

                        addUser(roster);


                    }));
                }
                else
                {

                    addUser(roster);
                }
                
            };

            chat.OnFriendRequest += (talkin, roster) =>
            {
                if (contactslistView.InvokeRequired)
                {
                    contactslistView.Invoke(new MethodInvoker(delegate
                    {

                        addUser(roster);


                    }));
                }
                else
                {

                    addUser(roster);
                }
            };
            chat.OnUserPresence += (talkin, pres) =>
            {
                if (contactslistView.InvokeRequired)
                {
                    contactslistView.Invoke(new MethodInvoker(delegate
                    {

                        updateUserPres(pres.From, pres.IsOnline);


                    }));
                }
                else
                {
                    updateUserPres(pres.From, pres.IsOnline);
                }
               

            };
            chat.OnChatMessage += (talkin, msg) =>
            {
                if(chatMessage==null)
                {
                    chatMessage = new ChatMessageForm();
                    

                }
                if(!chatMessage.Visible)
                {
                    chatMessage.SetBounds(Cursor.Position.X, Cursor.Position.Y, chatMessage.Width, chatMessage.Height);
                    chatMessage.Show();
                }
                chatMessage.newMessage(msg);

            };


            chat.OnMucSearchComplete += (talkin,mucType, mucList) =>
            {
                switch (mucType)
                {
                    case MucType.@public:

                        if (puliclistView.InvokeRequired)
                        {
                            puliclistView.Invoke(new MethodInvoker(delegate {

                                addPublicRooms(mucList);

                            }));
                        }
                        else
                        {
                            addFavRooms(mucList);
                        }
                        break;
                    case MucType.favourite:
                        if (favlistView.InvokeRequired)
                        {
                            favlistView.Invoke(new MethodInvoker(delegate {

                                addFavRooms(mucList);

                            }));
                        }
                        else
                        {
                            addFavRooms(mucList);
                        }
                        break;
                    case MucType.@private:
                        if (privatelistView.InvokeRequired)
                        {
                            privatelistView.Invoke(new MethodInvoker(delegate {

                                addPrivateRooms(mucList);

                            }));
                        }
                        else
                        {
                            addPrivateRooms(mucList);
                        }
                        break;
                }
                if(mucList.Count>0)
                {
                    new Thread(new ThreadStart(() => {
                        Thread.Sleep(2000);
                        if(chat!=null)
                        {
                            chat.GetNextMucList();

                        }

                    })).Start();
                    
                }
            };
            if(!string.IsNullOrWhiteSpace(usernameTextBox.Text) && !string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                chat.Login(usernameTextBox.Text, passTextBox.Text);
            }
            
            
        }


        private void updateUserPres(string username,bool isOnline)
        {
            if (contactslistView.Items.ContainsKey(username))
            {
                contactslistView.Items[username].ImageIndex = isOnline ? 1 : 0;
               
            }
            else
            {
                contactslistView.Items.Add(username, username, isOnline ? 1 : 0);
                
            }
           
            contactslistView.ListViewItemSorter = new ContactSorter(true);
            contactslistView.Sort();
            contactslistView.ListViewItemSorter = new ContactSorter(false);
            contactslistView.Sort();
        }
        private void addUser(Roster roster)
        {
            for (int i = 0; i < roster.Users.Count; i++)
            {
                UserStatus status = roster.Users[i];
                if (status != null)
                {
                    if(!string.IsNullOrWhiteSpace(status.From))
                    {

                        if (contactslistView.Items.ContainsKey(status.From))
                        {

                            contactslistView.Items[status.From].ImageIndex = status.Mode == Mode.online ? 1 : 0;
                            
                        }
                        else
                        {
                            contactslistView.Items.Add(status.From, status.From, status.Mode == Mode.online ? 1 : 0);
                            contactslistView.Items[status.From].SubItems.Add(status.Message);
                            
                        }
                    }
                    


                }
            }

            contactslistView.ListViewItemSorter = new ContactSorter(true);
            contactslistView.Sort();
            contactslistView.ListViewItemSorter = new ContactSorter(false);
            contactslistView.Sort();
            

        }


        private void addPublicRooms(List<MucInfo> mucList)
        {
            if(mucList.Count>0)
            {
                for(int i=0;i<mucList.Count;i++)
                {
                    MucInfo info = mucList[i];
                    
                    if(puliclistView.Items.ContainsKey(info.Name))
                    {
                        puliclistView.Items[info.Name].ImageIndex = info.CurrentUsers;
                        if(info.IsLocked && info.IsMemberOnly)
                        {
                            puliclistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒 👥";

                        }
                        else
                        if(info.IsLocked)
                        {
                            puliclistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒";

                        }
                        else
                        if(info.IsMemberOnly)
                        {
                            puliclistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 👥";

                        }
                        else
                        {
                            puliclistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ")";

                        }

                    }
                    else
                    {
                        if (info.IsLocked && info.IsMemberOnly)
                        {
                            puliclistView.Items.Add(info.Name,info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒 👥",info.CurrentUsers);

                        }
                        else
                        if (info.IsLocked)
                        {
                            puliclistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒",info.CurrentUsers);

                        }
                        else
                        if (info.IsMemberOnly)
                        {
                            puliclistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 👥",info.CurrentUsers);

                        }
                        else
                        {
                            puliclistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ")", info.CurrentUsers);

                        }
                    }
                    
                }
                puliclistView.ListViewItemSorter = new RoomSorter(true);
                puliclistView.Sort();
                puliclistView.ListViewItemSorter = new RoomSorter(false);
                puliclistView.Sort();
                
            }
        }

        private void addFavRooms(List<MucInfo> mucList)
        {
            if (mucList.Count > 0)
            {
                for (int i = 0; i < mucList.Count; i++)
                {
                    MucInfo info = mucList[i];

                    if (favlistView.Items.ContainsKey(info.Name))
                    {
                        favlistView.Items[info.Name].ImageIndex = info.CurrentUsers;
                        if (info.IsLocked && info.IsMemberOnly)
                        {
                            favlistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒 👥";

                        }
                        else
                        if (info.IsLocked)
                        {
                            favlistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒";

                        }
                        else
                        if (info.IsMemberOnly)
                        {
                            favlistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 👥";

                        }
                        else
                        {
                            favlistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ")";

                        }

                    }
                    else
                    {
                        if (info.IsLocked && info.IsMemberOnly)
                        {
                            favlistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒 👥", info.CurrentUsers);

                        }
                        else
                        if (info.IsLocked)
                        {
                            favlistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒", info.CurrentUsers);

                        }
                        else
                        if (info.IsMemberOnly)
                        {
                            favlistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 👥", info.CurrentUsers);

                        }
                        else
                        {
                            favlistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ")", info.CurrentUsers);

                        }
                    }

                }
                favlistView.ListViewItemSorter = new RoomSorter(true);
                favlistView.Sort();
                favlistView.ListViewItemSorter = new RoomSorter(false);
                favlistView.Sort();
                
            }
        }

        private void addPrivateRooms(List<MucInfo> mucList)
        {
            if (mucList.Count > 0)
            {
                for (int i = 0; i < mucList.Count; i++)
                {
                    MucInfo info = mucList[i];

                    if (privatelistView.Items.ContainsKey(info.Name))
                    {
                        privatelistView.Items[info.Name].ImageIndex = info.CurrentUsers;
                        if (info.IsLocked && info.IsMemberOnly)
                        {
                            privatelistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒 👥";

                        }
                        else
                        if (info.IsLocked)
                        {
                            privatelistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒";

                        }
                        else
                        if (info.IsMemberOnly)
                        {
                            privatelistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 👥";

                        }
                        else
                        {
                            privatelistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ")";

                        }

                    }
                    else
                    {
                        if (info.IsLocked && info.IsMemberOnly)
                        {
                            privatelistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒 👥", info.CurrentUsers);

                        }
                        else
                        if (info.IsLocked)
                        {
                            privatelistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 🔒", info.CurrentUsers);

                        }
                        else
                        if (info.IsMemberOnly)
                        {
                            privatelistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ") 👥", info.CurrentUsers);

                        }
                        else
                        {
                            privatelistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers + "/" + info.MaxUsers + ")", info.CurrentUsers);

                        }
                    }

                }
                privatelistView.ListViewItemSorter = new RoomSorter(true);
                privatelistView.Sort();
                privatelistView.ListViewItemSorter = new RoomSorter(false);
                privatelistView.Sort();
                
            }
        }

        private void addJoinedRooms(List<Muc> mucList)
        {
            if (mucList.Count > 0)
            {
                for (int i = 0; i < mucList.Count; i++)
                {
                    Muc info = mucList[i];

                    if (joinedlistView.Items.ContainsKey(info.Name))
                    {
                        joinedlistView.Items[info.Name].ImageIndex = info.CurrentUsers.Count;
                        joinedlistView.Items[info.Name].Text = info.Name + " (" + info.CurrentUsers.Count+")";
                    }
                    else
                    {
                        joinedlistView.Items.Add(info.Name, info.Name + " (" + info.CurrentUsers.Count+")", info.CurrentUsers.Count);
                    }

                }
                joinedlistView.ListViewItemSorter = new RoomSorter(true);
                joinedlistView.Sort();
                joinedlistView.ListViewItemSorter = new RoomSorter(false);
                joinedlistView.Sort();
                
            }
        }
        private void roomTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if(chat!=null)
            {
                switch(e.TabPageIndex)
                {
                    case 0:
                        chat.GetMucList(MucType.favourite);
                        break;

                    case 1:
                        chat.GetMucList(MucType.@public);
                        break;
                    case 2:
                        addJoinedRooms(chat.JoinedMucList);
                        break;
                    case 3:
                        chat.GetMucList(MucType.@private);
                        break;
                }
            }
            
        }
    }
}
