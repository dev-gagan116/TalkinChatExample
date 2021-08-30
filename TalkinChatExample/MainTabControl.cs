using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkinClient;
using TalkinClient.User;
using System.Reflection;
using TalkinChatExample.Properties;
using System.Threading;
using TalkinClient.MultiUserChat;

namespace TalkinChatExample
{
    public partial class MainTabControl : UserControl
    {
        

        private TalkinChat talkin;
        private bool publicRoomSearchCompleted = true, joinedRoomSearchCompleted=true;
        public MainTabControl()
        {
            InitializeComponent();

            talkin = MainForm.Instance.Talkin;
            talkin.OnRoster += OnRoster;
            talkin.OnUserPresence += OnUserPresence;
            talkin.OnUserActivityResult += OnUserActivityResult;
            talkin.OnFriendRequest += OnFriendRequest;
            talkin.OnMucSearchComplete += OnMucSearchComplete;
            talkin.OnGetMucInfo += OnGetMucInfo;
            talkin.OnChatMessage += OnChatMessage;
            talkin.OnChatMessageSent += OnChatMessageSent;
            talkin.OnChatMessageAck += OnChatMessageAck;
            talkin.OnChatMessageStateChanged += OnChatMessageStateChanged;
            talkin.OnGetBlockedList += OnGetBlockedList;
            talkin.OnMucJoined += OnMucJoined;
            talkin.OnMucError += OnMucError;
            talkin.GetBlockedList();
           
        }

        private void OnUserActivityResult(TalkinChat talkin, UserActivity activity)
        {
           if(activity!=null)
            {
                if(contactsPanelView.Controls.ContainsKey(activity.From))
                {
                    ContactItem item = new ContactItem(activity.From);
                    item.LastSeen = activity.LastSeen;
                }
            }
        }
        
      

        private void OnMucError(TalkinChat talkin, string mucName, MucError error)
        {
            string errorMsg = "";
            switch(error)
            {
                case MucError.Outcast:
                    errorMsg = "You are banned in this room.";
                    break;
                case MucError.RequiredMembership:
                    errorMsg = "Room is members only.";
                    break;
                case MucError.RequiredPassword:
                    errorMsg = "Room is locked.";
                    break;
                case MucError.ErrorNotDefined:
                    errorMsg = "error-not-defined.";
                    break;
                case MucError.MaxUsers:
                    errorMsg = "Room has maximum users.";
                    break;
                case MucError.NotInMuc:
                    errorMsg = "You are not in room.";
                    break;
                case MucError.InsufficientPrivilege:
                    errorMsg = "You have insufficent privilege.";
                    break;
                case MucError.Unauthorized:
                    errorMsg = "Room banned your IP.";
                    break;
                case MucError.AlreadyJoined:
                    errorMsg = "You are already in room";
                    break;
                default:
                    errorMsg = "Unable to join room.";
                    break;

            }
            RoomMessageForm form = MainForm.Instance.getRoomForm(mucName);
            if (form != null)
            {
                form.showRoomError(mucName, errorMsg);
            }
            else
            {
               this.UIThread(()=> MessageBox.Show(errorMsg, mucName, MessageBoxButtons.OK, MessageBoxIcon.Error));

            }

        }

       

        private void OnMucJoined(TalkinChat talkin, Muc muc)
        {
            if(muc!=null)
            {
                RoomMessageForm form = MainForm.Instance.getRoomForm(muc.Name);
                if (form != null)
                {
                    form.roomJoined(muc);
                }
                else
                {
                    this.UIThread(() =>
                    {
                        form = new RoomMessageForm();
                        MainForm.Instance.addRoomForm(muc.Name, form);
                        form.Show();
                        form.RoomName = muc.Name;
                        form.RoomSuject = muc.SubjectMessage;
                        form.CurrentUsers = muc.CurrentUsers.Count;
                        form.roomJoined(muc);
                    });
                    

                }


            }
        }

        private void OnChatMessageStateChanged(TalkinChat talkin, TalkinClient.ChatMessage.MessageState state)
        {
            if(state!=null)
            {
                ChatMessageForm form = MainForm.Instance.getChatForm(state.From);
                if (form != null)
                {
                    string mode = "offline";
                    if (contactsPanelView.Controls.ContainsKey(state.From))
                    {
                        ContactItem item = (ContactItem)contactsPanelView.Controls[state.From];
                        mode = item.Mode;
                    }
                    form.msgState(state, mode);
                }
            }
            
        }

        private void OnChatMessageSent(TalkinChat talkin, string messageId, long timestamp)
        {
            Dictionary<string, ChatMessageForm> formList = MainForm.Instance.getChatFormList();
            for(int i=0;i<formList.Count;i++)
            {
                ChatMessageForm form = formList.ElementAt(i).Value;
                form.sentMsg(messageId, timestamp);
               
            }
        }

        private void OnChatMessageAck(TalkinChat talkin, TalkinClient.ChatMessage.MessageAck ack)
        {
            if(ack!=null)
            {
                ChatMessageForm form = MainForm.Instance.getChatForm(ack.From);
                if(form!=null)
                {
                    form.msgAck(ack);
                }
            }
        }

        private void OnGetBlockedList(TalkinChat talkin, List<string> blockedList)
        {
            updateBlockedUser(blockedList);
        }

        private void OnGetMucInfo(TalkinChat talkin, MucInfo info)
        {
            if(info!=null)
            {
                addJoinedRooms(info);
                RoomMessageForm form = MainForm.Instance.getRoomForm(info.Name);
                if (form != null)
                {
                    form.CurrentUsers = info.CurrentUsers;
                    form.MaxUsers = info.MaxUsers;
                }
            }
        }

        private void OnMucSearchComplete(TalkinChat talkin, TalkinClient.MultiUserChat.MucType mucType, List<TalkinClient.MultiUserChat.MucInfo> mucList)
        {
            switch (mucType)
            {
                case MucType.@public:

                    addPublicRooms(mucList);
                    break;
                case MucType.favourite:
                    addFavRooms(mucList);
                    break;
            }
            if (mucList.Count > 0 && mucType==MucType.@public)
            {
                new Thread(new ThreadStart(() => {
                    Thread.Sleep(2000);
                    if (talkin != null)
                    {
                        talkin.GetNextMucList();

                    }

                })).Start();

            }
            else
            {
                publicRoomSearchCompleted = true;
            }
        }

        private void OnFriendRequest(TalkinChat talkin, Roster roster)
        {
            addFriendRequest(roster);
        }

        private void OnUserPresence(TalkinChat talkin, UserPresence pres)
        {

            updateUserPres(pres.From, pres.IsOnline);
        }

      
        private void OnRoster(TalkinChat talkin, TalkinClient.User.Roster roster)
        {
            addUser(roster);
        }

        private void addPublicRooms(List<MucInfo> mucList)
        {
            if (mucList.Count > 0)
            {
                for (int i = 0; i < mucList.Count; i++)
                {
                    MucInfo info = mucList[i];

                    if (publicLayoutPanel.Controls.ContainsKey(info.Name))
                    {
                        RoomItem item = (RoomItem) publicLayoutPanel.Controls[info.Name];
                        item.Tag = info.CurrentUsers;
                        item.RoomUsers="(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                        item.IsRoomLocked = info.IsLocked;
                        item.IsRoomMemberOnly = info.IsMemberOnly;
                        

                    }
                    else
                    {
                        RoomItem item = new RoomItem(info.Name);
                        item.Tag = info.CurrentUsers;
                        item.RoomName = info.Name;
                        item.RoomPicText = info.Name[0];
                        item.RoomUsers = "(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                        item.IsRoomLocked = info.IsLocked;
                        item.IsRoomMemberOnly = info.IsMemberOnly;
                        publicLayoutPanel.UIThread(()=>publicLayoutPanel.Controls.Add(item));
                    }

                }

                publicLayoutPanel.UIThread(() => {

                    RoomItem[] itemArray = publicLayoutPanel.Controls.Cast<RoomItem>().OrderBy(x => x.Key).ToArray();
                    itemArray = publicLayoutPanel.Controls.Cast<RoomItem>().OrderByDescending(x => x.Tag).ToArray();
                    publicLayoutPanel.Controls.AddRange(itemArray);
                });
               

            }
        }

        private void addFavRooms(List<MucInfo> mucList)
        {
            if (mucList.Count > 0)
            {
                for (int i = 0; i < mucList.Count; i++)
                {
                    MucInfo info = mucList[i];

                    if (favLayoutPanel.Controls.ContainsKey(info.Name))
                    {
                        RoomItem item = (RoomItem)favLayoutPanel.Controls[info.Name];
                        item.Tag = info.CurrentUsers;
                        item.RoomUsers = "(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                        item.IsRoomLocked = info.IsLocked;
                        item.IsRoomMemberOnly = info.IsMemberOnly;

                    }
                    else
                    {
                        RoomItem item = new RoomItem(info.Name);
                        item.Tag = info.CurrentUsers;
                        item.RoomName = info.Name;
                        item.RoomPicText = info.Name[0];
                        item.RoomUsers = "(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                        item.IsRoomLocked = info.IsLocked;
                        item.IsRoomMemberOnly = info.IsMemberOnly;
                        favLayoutPanel.UIThread(()=>favLayoutPanel.Controls.Add(item));
                    }

                }
                favLayoutPanel.UIThread(() => {

                    RoomItem[] itemArray = favLayoutPanel.Controls.Cast<RoomItem>().OrderBy(x => x.Key).ToArray();
                    itemArray = favLayoutPanel.Controls.Cast<RoomItem>().OrderByDescending(x => x.Tag).ToArray();
                    favLayoutPanel.Controls.AddRange(itemArray);
                });
                

            }
        }

        private void addJoinedRooms(MucInfo info)
        {
            if (joinedLayoutPanel.Controls.ContainsKey(info.Name))
            {
                RoomItem item = (RoomItem)joinedLayoutPanel.Controls[info.Name];
                item.Tag = info.CurrentUsers;
                item.RoomUsers = "(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                item.IsRoomLocked = info.IsLocked;
                item.IsRoomMemberOnly = info.IsMemberOnly;

            }
            else
            {
                RoomItem item = new RoomItem(info.Name);
                item.Tag = info.CurrentUsers;
                item.RoomName = info.Name;
                item.RoomPicText = info.Name[0];
                item.RoomUsers = "(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                item.IsRoomLocked = info.IsLocked;
                item.IsRoomMemberOnly = info.IsMemberOnly;
                joinedLayoutPanel.UIThread(()=>joinedLayoutPanel.Controls.Add(item));
            }
            joinedLayoutPanel.UIThread(() => {

                RoomItem[] itemArray = joinedLayoutPanel.Controls.Cast<RoomItem>().OrderBy(x => x.Key).ToArray();
                itemArray = joinedLayoutPanel.Controls.Cast<RoomItem>().OrderByDescending(x => x.Tag).ToArray();
                joinedLayoutPanel.Controls.AddRange(itemArray);
            });
           

        }

        private void updateBlockedUser(List<string> blockedList)
        {
            foreach(string username in blockedList)
            {
                if (contactsPanelView.Controls.ContainsKey(username))
                {
                    ContactItem contact = (ContactItem)contactsPanelView.Controls[username];
                    contact.Tag = (int)contact.Tag-10;
                    contact.Mode = "blocked";
                    
                }
                
            }

            for (int i= 0;i<contactsPanelView.Controls.Count;i++)
            {
                ContactItem contact = (ContactItem)contactsPanelView.Controls[i];

                if((int)contact.Tag<=-9)
                {
                    if (blockedList.Count > 0)
                    {
                        if (!blockedList.Contains(contact.Username))
                        {
                            if (contact.Tag != null)
                            {
                                contact.Tag = (int)contact.Tag + 10;
                                
                            }

                        }
                    }
                    else
                    {
                        if (contact.Tag != null)
                        {
                            contact.Tag = (int)contact.Tag + 10;
                        }
                    }

                    if ((int)contact.Tag < -1)
                    {
                        contact.Mode = "blocked";
                    }
                    else
                    switch ((int)contact.Tag)
                    {

                        case -1:
                             contact.Mode = "pending";
                            break;
                        case 0:
                            contact.Mode = "offline";
                            break;
                        case 1:
                            contact.Mode = "online";
                            break;
                        default:
                            break;

                    }

                }


            }


            contactsPanelView.UIThread(() =>
            {

                ContactItem[] itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderBy(x => x.Key).ToArray();
                itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderByDescending(x => x.Tag).ToArray();
                contactsPanelView.Controls.AddRange(itemArray);


            });


        }
        private void updateUserPres(string username,bool isOnline)
        {
            if (contactsPanelView.Controls.ContainsKey(username))
            {
                ContactItem contact = (ContactItem)contactsPanelView.Controls[username];
                contact.Tag = isOnline ? 1 : 0;
                contact.IsOnline = isOnline;
                contact.Mode = isOnline ? "online" : "offline";
         

            }

            contactsPanelView.UIThread(() =>
            {

                ContactItem[] itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderBy(x => x.Key).ToArray();
                itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderByDescending(x => x.Tag).ToArray();
                contactsPanelView.Controls.AddRange(itemArray);


            });


        }
        private void addUser(Roster roster)
        {

            for (int i = 0; i < roster.Users.Count; i++)
            {
                UserStatus status = roster.Users[i];
                if (status != null)
                {
                    if (!string.IsNullOrWhiteSpace(status.From))
                    {

                        if(contactsPanelView.Controls.ContainsKey(status.From))
                        {
                            ContactItem contact = (ContactItem)contactsPanelView.Controls[status.From];
                            contact.Username = status.From;
                            contact.Message = status.Message;
                            contact.Tag = status.Mode==Mode.online ? 1 : 0;
                            contact.IsOnline = status.Mode == Mode.online;
                            contact.Mode=status.Mode == Mode.online ? "online" : "offline";
                            contact.PicUrl = status.PhotoUrl;
                           
                            
                            
                        }
                        else
                        {
                            ContactItem contact = new ContactItem(status.From);
                            contact.Size = new Size(270, 70);
                            contact.Username = status.From;
                            contact.Message = status.Message;
                            contact.Tag = status.Mode == Mode.online ? 1 : 0;
                            contact.IsOnline = status.Mode == Mode.online;
                            contact.Mode = status.Mode == Mode.online ? "online" : "offline";
                            contact.PicUrl = status.PhotoUrl;
                            contactsPanelView.UIThread(()=> contactsPanelView.Controls.Add(contact));
                            

                        }
                        if(status.Mode==Mode.offline)
                        {
                            new Thread(() => {
                                Thread.Sleep(1000);
                                if (talkin.IsLogged)
                                {
                                    talkin.CheckUserActivity(status.From);
                                }

                            }).Start();
                            
                        }

                      
                    }



                }
            }
            contactsPanelView.UIThread(() =>
            {
                ContactItem[] itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderBy(x => x.Key).ToArray();
                itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderByDescending(x => x.Tag).ToArray();
                contactsPanelView.Controls.AddRange(itemArray);

            });


        }

        private void addFriendRequest(Roster roster)
        {

            for (int i = 0; i < roster.Users.Count; i++)
            {
                UserStatus status = roster.Users[i];
                if (status != null)
                {
                    if (!string.IsNullOrWhiteSpace(status.From))
                    {

                        if (contactsPanelView.Controls.ContainsKey(status.From))
                        {
                            ContactItem contact = (ContactItem)contactsPanelView.Controls[status.From];
                            contact.Username = status.From;
                            contact.Message = status.Message;
                            contact.Tag = -1;
                            contact.Mode = "pending";
                            contact.PicUrl = status.PhotoUrl;
                            
                           

                        }
                        else
                        {
                            
                            ContactItem contact = new ContactItem(status.From);
                            contact.Size = new Size(270, 70);
                            contact.Username = status.From;
                            contact.Message = status.Message;
                            contact.Tag = -1;
                            contact.Mode = "pending";
                            contact.PicUrl = status.PhotoUrl;
                            contactsPanelView.UIThread(()=>contactsPanelView.Controls.Add(contact));


                        }


                    }



                }
            }
            contactsPanelView.UIThread(() => {

                ContactItem[] itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderBy(x => x.Key).ToArray();
                itemArray = contactsPanelView.Controls.Cast<ContactItem>().OrderByDescending(x => x.Tag).ToArray();
                contactsPanelView.Controls.AddRange(itemArray);


            });
           


        }

        private void OnChatMessage(TalkinChat talkin, TalkinClient.ChatMessage.Message chat)
        {
            if(chat!=null)
            {
                ChatMessageForm form = MainForm.Instance.getChatForm(chat.From);
                if (form != null)
                {
                    form.newMessage(chat);
                }
                else
                {

                    this.UIThread(() => {

                        form = new ChatMessageForm();
                        form.usernameLbl.Text = chat.From;
                        if (contactsPanelView.Controls.ContainsKey(chat.From))
                        {
                            ContactItem item = (ContactItem)contactsPanelView.Controls[chat.From];
                            if (!string.IsNullOrWhiteSpace(item.PicUrl))
                            {
                                form.userPic.LoadAsync(item.PicUrl);

                            }
                            form.userStateLbl.Text = item.Mode;
                        }
                        form.Show();
                        MainForm.Instance.addChatForm(chat.From, form);
                        form.newMessage(chat);
                    });
                   
                }

            }
        }

        private void contactsTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if(talkin.IsLogged)
            {
                if(e.TabPageIndex==1)
                {
                    switch(chatroomsTabControl.SelectedIndex)
                    {
                        case 0:
                            talkin.GetMucList(MucType.favourite);
                            publicRoomSearchCompleted = true;
                            break;
                        case 1:
                            if(publicRoomSearchCompleted)
                            {
                                talkin.GetMucList(MucType.@public);
                            }
                            break;
                        case 2:
                            List<Muc> joinedList = talkin.JoinedMucList;
                            if(joinedRoomSearchCompleted)
                            {
                                new Thread(new ThreadStart(() => {
                                    joinedRoomSearchCompleted = false;
                                    for (int i = 0; i < joinedList.Count; i++)
                                    {
                                        if (talkin.IsLogged)
                                        {
                                            talkin.GetMucInfo(joinedList[i].Name);
                                            Thread.Sleep(2000);
                                        }
                                    }
                                    joinedRoomSearchCompleted = true;

                                })).Start();
                            }
                           

                            break;
                        default:
                            break;
                    }
                    
                }
            }
        }

        private void chatroomsTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (talkin.IsLogged)
            {
                switch (chatroomsTabControl.SelectedIndex)
                {
                    case 0:
                        talkin.GetMucList(MucType.favourite);
                        publicRoomSearchCompleted = true;
                        break;
                    case 1:
                        if (publicRoomSearchCompleted)
                        {
                            talkin.GetMucList(MucType.@public);
                        }
                        break;
                    case 2:

                        List<Muc> joinedList = talkin.JoinedMucList;
                        if (joinedRoomSearchCompleted)
                        {
                            new Thread(new ThreadStart(() => {
                                joinedRoomSearchCompleted = false;
                                for (int i = 0; i < joinedList.Count; i++)
                                {
                                    if (talkin.IsLogged)
                                    {
                                        talkin.GetMucInfo(joinedList[i].Name);
                                        Thread.Sleep(2000);
                                    }
                                }
                                joinedRoomSearchCompleted = true;

                            })).Start();
                        }

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
