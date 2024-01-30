using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarrageGrab.Modles.JsonEntity;
using WindowsInput.Native;
using WindowsInput;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BarrageGrab.Modles.ProtoEntity;
using System.Collections.Specialized;
using System.Diagnostics;

namespace BarrageGrab.Forms
{
    public partial class FormChat2Cmd : Form
    {
        WsBarrageService barServer = AppRuntime.WssService;
        private readonly InputSimulator isim = new InputSimulator();
        List<C2CMappingItem> C2CMappingList = new List<C2CMappingItem>();
        Dictionary<string, VirtualKeyCode> C2CMappingDict = new Dictionary<string, VirtualKeyCode>();
        BindingSource C2CMappingTableSource = new BindingSource();

        List<C2CKey> C2CKeyOptionList = new List<C2CKey>
            {
                new C2CKey() { Name = "A", Value = VirtualKeyCode.VK_A },
                new C2CKey() { Name = "B", Value = VirtualKeyCode.VK_B },
                new C2CKey() { Name = "C", Value = VirtualKeyCode.VK_C },
                new C2CKey() { Name = "D", Value = VirtualKeyCode.VK_D },
                new C2CKey() { Name = "S", Value = VirtualKeyCode.VK_S },
                new C2CKey() { Name = "X", Value = VirtualKeyCode.VK_X },
                new C2CKey() { Name = "Y", Value = VirtualKeyCode.VK_Y },
                new C2CKey() { Name = "Z", Value = VirtualKeyCode.VK_Z },
                new C2CKey() { Name = "上", Value = VirtualKeyCode.UP },
                new C2CKey() { Name = "下", Value = VirtualKeyCode.DOWN },
                new C2CKey() { Name = "左", Value = VirtualKeyCode.LEFT },
                new C2CKey() { Name = "右", Value = VirtualKeyCode.RIGHT },
                new C2CKey() { Name = "鼠标左键", Value = VirtualKeyCode.LBUTTON },
                new C2CKey() { Name = "鼠标右键", Value = VirtualKeyCode.RBUTTON },
            };

        public FormChat2Cmd()
        {
            InitializeComponent();
            barServer.OnNewRoomMessageEvent += WssService_OnNewRoomMessageEvent;
            InitFilterList();
            InitSettingsTabPage();
        }

        private void InitFilterList()
        {
            var msgTypes = GetMsgTypes();
            var panel = flowLayoutPanel_msgFilter;
            if (panel == null) return;
            foreach (var label in msgTypes)
            {
                var ck = new CheckBox()
                {
                    Text = label.Value,
                    Tag = label.Key,
                    Parent = panel,
                    Padding = new Padding(0),
                    Margin = new Padding(0, 0, 10, 0),
                    Width = 60,
                };
                string type = "console";
                ck.Checked = Appsetting.Current.PrintFilter.Contains(label.Key);

                ck.Name = $"cbx_bartype_{type}_{label.Key}";
                ck.CheckedChanged += Ck_CheckedChanged;
                panel.Controls.Add(ck);
            }
        }

        private void InitSettingsTabPage()
        {
            
            
            //Setup data binding
            cbx_dstKey.DataSource = C2CKeyOptionList;
            cbx_dstKey.DisplayMember = "Name";
            cbx_dstKey.ValueMember = "Value";

            // mapping table
            //dataGridView_C2CMappingTable.ReadOnly = true;
            //C2CMappingTableSource.DataSource = C2CMappingList;
            //dataGridView_C2CMappingTable.DataSource = C2CMappingTableSource;
            
            dataGridView_C2CMappingTable.AutoGenerateColumns = false;
            //dataGridView_C2CMappingTable.DataSource = C2CMappingList;
            C2CMappingTableSource.DataSource = C2CMappingList;
            dataGridView_C2CMappingTable.DataSource = C2CMappingTableSource;
            AddC2CMappingTableColumns();

        }

        private void AddC2CMappingTableColumns()
        {
            DataGridViewTextBoxColumn msgColumn = new DataGridViewTextBoxColumn();
            msgColumn.Name = "弹幕";
            msgColumn.DataPropertyName = "chat";

            DataGridViewComboBoxColumn cmdColumn = new DataGridViewComboBoxColumn();
            foreach (var item in C2CKeyOptionList) cmdColumn.Items.Add(item);
            cmdColumn.Name = "按键";
            cmdColumn.DataPropertyName = "C2CKey";
            cmdColumn.DisplayMember = "Name";
            cmdColumn.ValueMember = "Value";

            dataGridView_C2CMappingTable.Columns.Add(msgColumn);
            dataGridView_C2CMappingTable.Columns.Add(cmdColumn);
        }


        private Dictionary<int, string> GetMsgTypes()
        {
            var dic = new Dictionary<int, string>();
            Type enumType = typeof(PackMsgType);
            FieldInfo[] fields = enumType.GetFields(BindingFlags.Public | BindingFlags.Static);
            foreach (var field in fields)
            {
                DescriptionAttribute attribute = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute), false);
                int value = (int)field.GetValue(null);
                if (attribute != null && value > 0)
                {
                    dic.Add(value, attribute.Description);
                }
            }

            return dic;
        }

        private void Ck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbx = sender as CheckBox;
            if (cbx == null) return;
            var selected = GetCheckedBarTypes((FlowLayoutPanel)cbx.Parent);
            //Console.WriteLine("selected checkboxes " + selected);
            Appsetting.Current.PrintFilter = selected;
            Appsetting.Current.Save();
        }


        private int[] GetCheckedBarTypes(FlowLayoutPanel panel)
        {
            List<int> list = new List<int>();
            foreach (Control ctr in panel.Controls)
            {
                var cbk = ctr as CheckBox;
                if (cbk == null) continue;
                if (cbk.Checked && cbk.Name.StartsWith("cbx_bartype_"))
                {
                    list.Add((int)cbk.Tag);
                }
            }
            return list.OrderBy(o => o).ToArray();
        }

        private void WssService_OnNewRoomMessageEvent(object sender, WsBarrageService.RoomMessageEvent e)
        {
            //Console.WriteLine("WssService_OnNewRoomMessageEvent started 11111");
            //将弹幕输出到richTextBox
            //颜色转换
            Color color = Appsetting.Current.ColorMap[e.MsgType].Item2;
            string msg = e.Message;
            string[] newRow = { $"{DateTime.Now.ToString("MM-dd HH:mm:ss")}", $"{e.MsgData?.User?.DisplayId}", $"{e.MsgData?.User?.Nickname}", $"{e.MsgType}", $"{e.MsgData.Content}" };

            this.Invoke(new Action(() =>
            {
                Console.WriteLine("WssService_OnNewRoomMessageEvent invoked " + msg);
                if (e.MsgType == PackMsgType.直播间统计)
                {
                    var roomInfo = AppRuntime.RoomCaches.GetCachedWebRoomInfo(e.MsgData.RoomId.ToString());
                    this.lbl_onlineUserCount.Text = "人数 " + ((UserSeqMsg)e.MsgData).OnlineUserCountStr;
                    this.lbl_hostName.Text = "主播 " + roomInfo?.Owner?.Nickname;
                    this.lbl_roomTitle.Text = "房间 " + roomInfo?.Title;
                }
                this.dataGridView_eventTable.Rows.Add(newRow);
                dataGridView_eventTable.FirstDisplayedScrollingRowIndex = dataGridView_eventTable.RowCount - 1;

                switch (e.MsgType)
                {
                    case PackMsgType.弹幕消息: ChatToCmd(e.MsgData); break;
                    case PackMsgType.礼物消息: GiftToCmd((GiftMsg)e.MsgData); break;
                    default: break;
                }
                
                ////输出到richTextBox
                //this.rich_output.SelectionColor = color;
                //this.rich_output.AppendText(msg + "\n");
                //this.rich_output.ScrollToCaret();
            }));

            Console.WriteLine("WssService_OnNewRoomMessageEvent started 22222");
            //if (++printCount > 10000)
            //{
            //    this.rich_output.Clear();
            //    printCount = 0;
            //}
        }

        private void ChatToCmd(Msg msgData)
        {
            string chat = msgData.Content;
            string chatU = chat.Trim().ToUpper();
            if (chatU.Length == 0) return;

            var firstChar = chatU[0];
            switch (firstChar)
            {
                case 'W':
                    Console.WriteLine("ccccccc UP");
                    break;
                case 'A':
                    Console.WriteLine("ccccccc LEFT");
                    break;
                case 'S':
                    Console.WriteLine("ccccccc DOWN");
                    break;
                case 'D':
                    Console.WriteLine("ccccccc RIGHT");
                    break;
                default:
                    //Console.WriteLine("ccccccc NOOOOOO");
                    break;
            }
            //this.isim.Keyboard.KeyPress(VirtualKeyCode.UP);
        }

        private void GiftToCmd(GiftMsg msgData)
        {
            Console.WriteLine("ggggggg gift" + msgData.GiftName);
        }

        private void btn_collectMsg_Click(object sender, EventArgs e)
        {
            //Process.Start("http://google.com", "-incognito");  // opens new tab
            //Process.Start(@"chrome.exe", $"--guest --profile-directory=\"C:\\temp\\profile\" --user-data-dir=\"C:\\temp\\profile\\userdata\" --proxy-server=127.0.0.1:{Appsetting.Current.ProxyPort} https://live.douyin.com/567789235524");
        }

        //private void DataGrid_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    if (dataGridView_eventTable.Items.Count > 0 && e.NewStartingIndex == dataGridView_eventTable.Items.Count - 1)
        //    {
        //        if (VisualTreeHelper.GetChild(MyDataGrid, 0) is Decorator border)
        //        {
        //            if (border.Child is ScrollViewer scroll) scroll.ScrollToEnd();
        //        }
        //    }
        //}

        class C2CKey
        {
            public string Name { get; set; }
            public VirtualKeyCode Value { get; set; }
        }
        
        class C2CMappingItem
        {
            public string chat { get; set; }
            public C2CKey command { get; set; }
            public string command2 { get; set; }
        }

        private void btn_addC2CMapping_Click(object sender, EventArgs e)
        {
            string srcChatMsg = this.txb_srcChatMsg.Text.Trim();
            if (srcChatMsg.Length == 0) return;
            if (this.cbx_dstKey.SelectedValue == null) return;
            VirtualKeyCode dstKeyValue = (VirtualKeyCode)this.cbx_dstKey.SelectedValue;
            Console.WriteLine($"adding mapping {srcChatMsg} {dstKeyValue}");
            C2CMappingDict[srcChatMsg] = dstKeyValue;
            C2CKey command = (C2CKey)this.cbx_dstKey.SelectedItem;
            C2CMappingList.Add(new C2CMappingItem() { chat = srcChatMsg, command = command, command2 = command.Name });
            C2CMappingTableSource.ResetBindings(false);

            // update table

        }
    }
}
