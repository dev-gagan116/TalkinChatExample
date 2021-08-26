using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkinClient;

namespace TalkinChatExample
{
    public partial class MainForm : MaterialForm
    {
        private static MainForm _instance;
        private TalkinChat chat;
        private Dictionary<string, ChatMessageForm> chatFormList;
        private Dictionary<string, RoomMessageForm> roomFormList;

        public MainForm()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green500, Primary.Green600, Accent.LightGreen200, TextShade.WHITE);


        }

        public static MainForm Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new MainForm();
                }
                return _instance;
            }
        }
        public  Panel BaseContainer
        {
            get
            {
                return MainContainer;
            }
        }

        public TalkinChat Talkin
        {
            get
            {
                if(chat==null)
                {
                    chat = new TalkinChat();
                }
                return chat;
            }
        }

        public Dictionary<string,ChatMessageForm> getChatFormList()
        {
            if(chatFormList==null)
            {
                chatFormList = new Dictionary<string, ChatMessageForm>();
            }
            return chatFormList;
        }
        public ChatMessageForm getChatForm(string key)
        {

            if(chatFormList!=null && chatFormList.ContainsKey(key))
            {
                return chatFormList[key];
            }
            else
            {
                return null;
            }
        }

        public void addChatForm(string key,ChatMessageForm form)
        {
            if(chatFormList==null)
            {
                chatFormList = new Dictionary<string, ChatMessageForm>();
            }
            if(!chatFormList.ContainsKey(key))
            {
                chatFormList.Add(key, form);
            }
        }

        public void removeChatForm(string key)
        {
            if(chatFormList!=null)
            {
                if(chatFormList.ContainsKey(key))
                {
                    
                    chatFormList.Remove(key);
                }
            }
        }


        public Dictionary<string, RoomMessageForm> getRoomFormList()
        {
            if (roomFormList == null)
            {
                roomFormList = new Dictionary<string, RoomMessageForm>();
            }
            return roomFormList;
        }
        public RoomMessageForm getRoomForm(string key)
        {

            if (roomFormList != null && roomFormList.ContainsKey(key))
            {
                return roomFormList[key];
            }
            else
            {
                return null;
            }
        }

        public void addRoomForm(string key, RoomMessageForm form)
        {
            if (roomFormList == null)
            {
                roomFormList = new Dictionary<string, RoomMessageForm>();
            }
            if (!roomFormList.ContainsKey(key))
            {
                roomFormList.Add(key, form);
            }
        }

        public void removeRoomForm(string key)
        {
            if (roomFormList != null)
            {
                if (roomFormList.ContainsKey(key))
                {

                    roomFormList.Remove(key);
                }
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            _instance = this;
            chatFormList = new Dictionary<string, ChatMessageForm>();
            roomFormList = new Dictionary<string, RoomMessageForm>();
            MainContainer.Controls.Add(new LoginControl() { Dock=DockStyle.Fill});
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            if(Talkin.IsLogged)
            {
                Talkin.Logout();
            }   
            Application.Exit();
        }
    }

   
}
