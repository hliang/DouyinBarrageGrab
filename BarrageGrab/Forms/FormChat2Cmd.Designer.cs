using System;
using System.Windows.Forms;

namespace BarrageGrab.Forms
{
    partial class FormChat2Cmd
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDanmu = new System.Windows.Forms.TabPage();
            this.dataGridView_eventTable = new System.Windows.Forms.DataGridView();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel_msgFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exportTable = new System.Windows.Forms.Button();
            this.btn_convertC2C = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_onlineUserCount = new System.Windows.Forms.Label();
            this.lbl_hostName = new System.Windows.Forms.Label();
            this.lbl_roomTitle = new System.Windows.Forms.Label();
            this.picbx_hostAvatar = new System.Windows.Forms.PictureBox();
            this.txb_liveRoomUrl = new System.Windows.Forms.TextBox();
            this.btn_collectMsg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_C2CMappingTable = new System.Windows.Forms.DataGridView();
            this.btn_addC2CMapping = new System.Windows.Forms.Button();
            this.cbx_dstKey = new System.Windows.Forms.ComboBox();
            this.txb_srcChatMsg = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_removeC2CMapping = new System.Windows.Forms.Button();
            this.tabPageReadme = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageDanmu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eventTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_hostAvatar)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_C2CMappingTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageDanmu);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageReadme);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDanmu
            // 
            this.tabPageDanmu.Controls.Add(this.dataGridView_eventTable);
            this.tabPageDanmu.Controls.Add(this.flowLayoutPanel_msgFilter);
            this.tabPageDanmu.Controls.Add(this.panel1);
            this.tabPageDanmu.Location = new System.Drawing.Point(4, 22);
            this.tabPageDanmu.Name = "tabPageDanmu";
            this.tabPageDanmu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDanmu.Size = new System.Drawing.Size(776, 410);
            this.tabPageDanmu.TabIndex = 0;
            this.tabPageDanmu.Text = "弹幕采集";
            this.tabPageDanmu.UseVisualStyleBackColor = true;
            // 
            // dataGridView_eventTable
            // 
            this.dataGridView_eventTable.AllowUserToAddRows = false;
            this.dataGridView_eventTable.AllowUserToDeleteRows = false;
            this.dataGridView_eventTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_eventTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_eventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_eventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.colUserID,
            this.colUserNickname,
            this.colEventType,
            this.colEventContent});
            this.dataGridView_eventTable.Location = new System.Drawing.Point(0, 153);
            this.dataGridView_eventTable.Name = "dataGridView_eventTable";
            this.dataGridView_eventTable.ReadOnly = true;
            this.dataGridView_eventTable.RowHeadersVisible = false;
            this.dataGridView_eventTable.Size = new System.Drawing.Size(776, 254);
            this.dataGridView_eventTable.TabIndex = 5;
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "时间";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 56;
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "用户ID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Width = 67;
            // 
            // colUserNickname
            // 
            this.colUserNickname.HeaderText = "用户昵称";
            this.colUserNickname.Name = "colUserNickname";
            this.colUserNickname.ReadOnly = true;
            this.colUserNickname.Width = 80;
            // 
            // colEventType
            // 
            this.colEventType.HeaderText = "事件类别";
            this.colEventType.Name = "colEventType";
            this.colEventType.ReadOnly = true;
            this.colEventType.Width = 80;
            // 
            // colEventContent
            // 
            this.colEventContent.HeaderText = "事件内容";
            this.colEventContent.Name = "colEventContent";
            this.colEventContent.ReadOnly = true;
            this.colEventContent.Width = 80;
            // 
            // flowLayoutPanel_msgFilter
            // 
            this.flowLayoutPanel_msgFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_msgFilter.Location = new System.Drawing.Point(6, 117);
            this.flowLayoutPanel_msgFilter.Name = "flowLayoutPanel_msgFilter";
            this.flowLayoutPanel_msgFilter.Size = new System.Drawing.Size(764, 30);
            this.flowLayoutPanel_msgFilter.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exportTable);
            this.panel1.Controls.Add(this.btn_convertC2C);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txb_liveRoomUrl);
            this.panel1.Controls.Add(this.btn_collectMsg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 105);
            this.panel1.TabIndex = 3;
            // 
            // btn_exportTable
            // 
            this.btn_exportTable.Location = new System.Drawing.Point(290, 62);
            this.btn_exportTable.Name = "btn_exportTable";
            this.btn_exportTable.Size = new System.Drawing.Size(97, 23);
            this.btn_exportTable.TabIndex = 5;
            this.btn_exportTable.Text = "导出表格";
            this.btn_exportTable.UseVisualStyleBackColor = true;
            // 
            // btn_convertC2C
            // 
            this.btn_convertC2C.Location = new System.Drawing.Point(290, 31);
            this.btn_convertC2C.Name = "btn_convertC2C";
            this.btn_convertC2C.Size = new System.Drawing.Size(97, 23);
            this.btn_convertC2C.TabIndex = 4;
            this.btn_convertC2C.Text = "启动弹幕指令";
            this.btn_convertC2C.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_onlineUserCount);
            this.groupBox1.Controls.Add(this.lbl_hostName);
            this.groupBox1.Controls.Add(this.lbl_roomTitle);
            this.groupBox1.Controls.Add(this.picbx_hostAvatar);
            this.groupBox1.Location = new System.Drawing.Point(435, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_onlineUserCount
            // 
            this.lbl_onlineUserCount.AutoSize = true;
            this.lbl_onlineUserCount.Location = new System.Drawing.Point(92, 62);
            this.lbl_onlineUserCount.Name = "lbl_onlineUserCount";
            this.lbl_onlineUserCount.Size = new System.Drawing.Size(31, 13);
            this.lbl_onlineUserCount.TabIndex = 3;
            this.lbl_onlineUserCount.Text = "人数";
            // 
            // lbl_hostName
            // 
            this.lbl_hostName.AutoSize = true;
            this.lbl_hostName.Location = new System.Drawing.Point(92, 41);
            this.lbl_hostName.Name = "lbl_hostName";
            this.lbl_hostName.Size = new System.Drawing.Size(31, 13);
            this.lbl_hostName.TabIndex = 2;
            this.lbl_hostName.Text = "主播";
            // 
            // lbl_roomTitle
            // 
            this.lbl_roomTitle.AutoSize = true;
            this.lbl_roomTitle.Location = new System.Drawing.Point(92, 19);
            this.lbl_roomTitle.Name = "lbl_roomTitle";
            this.lbl_roomTitle.Size = new System.Drawing.Size(31, 13);
            this.lbl_roomTitle.TabIndex = 1;
            this.lbl_roomTitle.Text = "房间";
            // 
            // picbx_hostAvatar
            // 
            this.picbx_hostAvatar.BackColor = System.Drawing.Color.LightGray;
            this.picbx_hostAvatar.Location = new System.Drawing.Point(6, 19);
            this.picbx_hostAvatar.Name = "picbx_hostAvatar";
            this.picbx_hostAvatar.Size = new System.Drawing.Size(76, 75);
            this.picbx_hostAvatar.TabIndex = 0;
            this.picbx_hostAvatar.TabStop = false;
            // 
            // txb_liveRoomUrl
            // 
            this.txb_liveRoomUrl.Location = new System.Drawing.Point(65, 3);
            this.txb_liveRoomUrl.Name = "txb_liveRoomUrl";
            this.txb_liveRoomUrl.Size = new System.Drawing.Size(219, 20);
            this.txb_liveRoomUrl.TabIndex = 1;
            this.txb_liveRoomUrl.Text = "https://live.douyin.com/123456";
            // 
            // btn_collectMsg
            // 
            this.btn_collectMsg.Location = new System.Drawing.Point(290, 0);
            this.btn_collectMsg.Name = "btn_collectMsg";
            this.btn_collectMsg.Size = new System.Drawing.Size(97, 23);
            this.btn_collectMsg.TabIndex = 2;
            this.btn_collectMsg.Text = "开始采集";
            this.btn_collectMsg.UseVisualStyleBackColor = true;
            this.btn_collectMsg.Click += new System.EventHandler(this.btn_collectMsg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "直播地址";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.groupBox2);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(776, 410);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "配置选项";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_removeC2CMapping);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView_C2CMappingTable);
            this.groupBox2.Controls.Add(this.btn_addC2CMapping);
            this.groupBox2.Controls.Add(this.cbx_dstKey);
            this.groupBox2.Controls.Add(this.txb_srcChatMsg);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "键盘 <= 弹幕";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "按键";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "弹幕";
            // 
            // dataGridView_C2CMappingTable
            // 
            this.dataGridView_C2CMappingTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_C2CMappingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_C2CMappingTable.Location = new System.Drawing.Point(6, 65);
            this.dataGridView_C2CMappingTable.Name = "dataGridView_C2CMappingTable";
            this.dataGridView_C2CMappingTable.Size = new System.Drawing.Size(311, 290);
            this.dataGridView_C2CMappingTable.TabIndex = 2;
            // 
            // btn_addC2CMapping
            // 
            this.btn_addC2CMapping.Location = new System.Drawing.Point(350, 36);
            this.btn_addC2CMapping.Name = "btn_addC2CMapping";
            this.btn_addC2CMapping.Size = new System.Drawing.Size(75, 23);
            this.btn_addC2CMapping.TabIndex = 0;
            this.btn_addC2CMapping.Text = "添加";
            this.btn_addC2CMapping.UseVisualStyleBackColor = true;
            this.btn_addC2CMapping.Click += new System.EventHandler(this.btn_addC2CMapping_Click);
            // 
            // cbx_dstKey
            // 
            this.cbx_dstKey.FormattingEnabled = true;
            this.cbx_dstKey.Location = new System.Drawing.Point(196, 38);
            this.cbx_dstKey.Name = "cbx_dstKey";
            this.cbx_dstKey.Size = new System.Drawing.Size(121, 21);
            this.cbx_dstKey.TabIndex = 1;
            // 
            // txb_srcChatMsg
            // 
            this.txb_srcChatMsg.Location = new System.Drawing.Point(6, 39);
            this.txb_srcChatMsg.Name = "txb_srcChatMsg";
            this.txb_srcChatMsg.Size = new System.Drawing.Size(158, 20);
            this.txb_srcChatMsg.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btn_removeC2CMapping
            // 
            this.btn_removeC2CMapping.Location = new System.Drawing.Point(464, 36);
            this.btn_removeC2CMapping.Name = "btn_removeC2CMapping";
            this.btn_removeC2CMapping.Size = new System.Drawing.Size(75, 23);
            this.btn_removeC2CMapping.TabIndex = 5;
            this.btn_removeC2CMapping.Text = "删除";
            this.btn_removeC2CMapping.UseVisualStyleBackColor = true;
            // 
            // tabPageReadme
            // 
            this.tabPageReadme.Location = new System.Drawing.Point(4, 22);
            this.tabPageReadme.Name = "tabPageReadme";
            this.tabPageReadme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReadme.Size = new System.Drawing.Size(776, 410);
            this.tabPageReadme.TabIndex = 2;
            this.tabPageReadme.Text = "使用说明";
            this.tabPageReadme.UseVisualStyleBackColor = true;
            // 
            // FormChat2Cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormChat2Cmd";
            this.Text = "直播弹幕收集";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDanmu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eventTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_hostAvatar)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_C2CMappingTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDanmu;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button btn_collectMsg;
        private System.Windows.Forms.TextBox txb_liveRoomUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_hostName;
        private System.Windows.Forms.Label lbl_roomTitle;
        private System.Windows.Forms.PictureBox picbx_hostAvatar;
        private System.Windows.Forms.Button btn_convertC2C;
        private System.Windows.Forms.Button btn_exportTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_msgFilter;
        private System.Windows.Forms.DataGridView dataGridView_eventTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventContent;
        private System.Windows.Forms.Label lbl_onlineUserCount;
        private GroupBox groupBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridView dataGridView_C2CMappingTable;
        private Button btn_addC2CMapping;
        private ComboBox cbx_dstKey;
        private TextBox txb_srcChatMsg;
        private Label label3;
        private Label label2;
        private Button btn_removeC2CMapping;
        private TabPage tabPageReadme;
    }
}