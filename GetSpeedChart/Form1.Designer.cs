namespace GetSpeedChart
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SC_Main = new System.Windows.Forms.SplitContainer();
            this.PV_Chart = new OxyPlot.WindowsForms.PlotView();
            this.CB_IP = new System.Windows.Forms.ComboBox();
            this.ll_ip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_App = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_Time = new System.Windows.Forms.NumericUpDown();
            this.BT_Login = new System.Windows.Forms.Button();
            this.BT_Start = new System.Windows.Forms.Button();
            this.BT_Pause = new System.Windows.Forms.Button();
            this.RD_MoveID = new System.Windows.Forms.RadioButton();
            this.RD_Time = new System.Windows.Forms.RadioButton();
            this.GB_Setting = new System.Windows.Forms.GroupBox();
            this.GB_Analysis = new System.Windows.Forms.GroupBox();
            this.CLB_Item = new System.Windows.Forms.CheckedListBox();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SC_Main)).BeginInit();
            this.SC_Main.Panel1.SuspendLayout();
            this.SC_Main.Panel2.SuspendLayout();
            this.SC_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Time)).BeginInit();
            this.GB_Setting.SuspendLayout();
            this.GB_Analysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // SC_Main
            // 
            this.SC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_Main.Location = new System.Drawing.Point(0, 0);
            this.SC_Main.Name = "SC_Main";
            // 
            // SC_Main.Panel1
            // 
            this.SC_Main.Panel1.Controls.Add(this.GB_Analysis);
            this.SC_Main.Panel1.Controls.Add(this.BT_Pause);
            this.SC_Main.Panel1.Controls.Add(this.BT_Start);
            this.SC_Main.Panel1.Controls.Add(this.BT_Login);
            this.SC_Main.Panel1.Controls.Add(this.GB_Setting);
            // 
            // SC_Main.Panel2
            // 
            this.SC_Main.Panel2.Controls.Add(this.PV_Chart);
            this.SC_Main.Size = new System.Drawing.Size(830, 547);
            this.SC_Main.SplitterDistance = 276;
            this.SC_Main.TabIndex = 0;
            // 
            // PV_Chart
            // 
            this.PV_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PV_Chart.Location = new System.Drawing.Point(0, 0);
            this.PV_Chart.Name = "PV_Chart";
            this.PV_Chart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PV_Chart.Size = new System.Drawing.Size(550, 547);
            this.PV_Chart.TabIndex = 0;
            this.PV_Chart.Text = "plotView1";
            this.PV_Chart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PV_Chart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PV_Chart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // CB_IP
            // 
            this.CB_IP.FormattingEnabled = true;
            this.CB_IP.Items.AddRange(new object[] {
            "127.0.0.1",
            "192.168.0.254",
            "172.31.0.1"});
            this.CB_IP.Location = new System.Drawing.Point(93, 24);
            this.CB_IP.Name = "CB_IP";
            this.CB_IP.Size = new System.Drawing.Size(134, 21);
            this.CB_IP.TabIndex = 0;
            this.CB_IP.Text = "127.0.0.1";
            // 
            // ll_ip
            // 
            this.ll_ip.AutoSize = true;
            this.ll_ip.Location = new System.Drawing.Point(18, 29);
            this.ll_ip.Name = "ll_ip";
            this.ll_ip.Size = new System.Drawing.Size(47, 13);
            this.ll_ip.TabIndex = 1;
            this.ll_ip.Text = "CS8C IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "应用程序名";
            // 
            // CB_App
            // 
            this.CB_App.FormattingEnabled = true;
            this.CB_App.Items.AddRange(new object[] {
            "DataBase",
            "LasMAN"});
            this.CB_App.Location = new System.Drawing.Point(93, 69);
            this.CB_App.Name = "CB_App";
            this.CB_App.Size = new System.Drawing.Size(134, 21);
            this.CB_App.TabIndex = 2;
            this.CB_App.Text = "DataBase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "轮询时间(秒)";
            // 
            // NUD_Time
            // 
            this.NUD_Time.DecimalPlaces = 1;
            this.NUD_Time.Location = new System.Drawing.Point(93, 112);
            this.NUD_Time.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUD_Time.Name = "NUD_Time";
            this.NUD_Time.Size = new System.Drawing.Size(134, 20);
            this.NUD_Time.TabIndex = 5;
            this.NUD_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // BT_Login
            // 
            this.BT_Login.Location = new System.Drawing.Point(58, 197);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(128, 36);
            this.BT_Login.TabIndex = 6;
            this.BT_Login.Text = "登录";
            this.BT_Login.UseVisualStyleBackColor = true;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // BT_Start
            // 
            this.BT_Start.Enabled = false;
            this.BT_Start.Location = new System.Drawing.Point(58, 252);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(128, 36);
            this.BT_Start.TabIndex = 7;
            this.BT_Start.Text = "开始";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // BT_Pause
            // 
            this.BT_Pause.Enabled = false;
            this.BT_Pause.Location = new System.Drawing.Point(58, 309);
            this.BT_Pause.Name = "BT_Pause";
            this.BT_Pause.Size = new System.Drawing.Size(128, 36);
            this.BT_Pause.TabIndex = 8;
            this.BT_Pause.Text = "暂停";
            this.BT_Pause.UseVisualStyleBackColor = true;
            this.BT_Pause.Click += new System.EventHandler(this.BT_Pause_Click);
            // 
            // RD_MoveID
            // 
            this.RD_MoveID.AutoSize = true;
            this.RD_MoveID.Location = new System.Drawing.Point(76, 149);
            this.RD_MoveID.Name = "RD_MoveID";
            this.RD_MoveID.Size = new System.Drawing.Size(63, 17);
            this.RD_MoveID.TabIndex = 9;
            this.RD_MoveID.Text = "MoveID";
            this.RD_MoveID.UseVisualStyleBackColor = true;
            // 
            // RD_Time
            // 
            this.RD_Time.AutoSize = true;
            this.RD_Time.Checked = true;
            this.RD_Time.Location = new System.Drawing.Point(21, 148);
            this.RD_Time.Name = "RD_Time";
            this.RD_Time.Size = new System.Drawing.Size(49, 17);
            this.RD_Time.TabIndex = 10;
            this.RD_Time.TabStop = true;
            this.RD_Time.Text = "时间";
            this.RD_Time.UseVisualStyleBackColor = true;
            // 
            // GB_Setting
            // 
            this.GB_Setting.Controls.Add(this.RD_Time);
            this.GB_Setting.Controls.Add(this.CB_IP);
            this.GB_Setting.Controls.Add(this.RD_MoveID);
            this.GB_Setting.Controls.Add(this.ll_ip);
            this.GB_Setting.Controls.Add(this.CB_App);
            this.GB_Setting.Controls.Add(this.label2);
            this.GB_Setting.Controls.Add(this.label3);
            this.GB_Setting.Controls.Add(this.NUD_Time);
            this.GB_Setting.Location = new System.Drawing.Point(13, 2);
            this.GB_Setting.Name = "GB_Setting";
            this.GB_Setting.Size = new System.Drawing.Size(251, 180);
            this.GB_Setting.TabIndex = 11;
            this.GB_Setting.TabStop = false;
            this.GB_Setting.Text = "配置";
            // 
            // GB_Analysis
            // 
            this.GB_Analysis.Controls.Add(this.CLB_Item);
            this.GB_Analysis.Location = new System.Drawing.Point(13, 351);
            this.GB_Analysis.Name = "GB_Analysis";
            this.GB_Analysis.Size = new System.Drawing.Size(251, 175);
            this.GB_Analysis.TabIndex = 12;
            this.GB_Analysis.TabStop = false;
            this.GB_Analysis.Text = "分析";
            // 
            // CLB_Item
            // 
            this.CLB_Item.FormattingEnabled = true;
            this.CLB_Item.Location = new System.Drawing.Point(21, 20);
            this.CLB_Item.Name = "CLB_Item";
            this.CLB_Item.Size = new System.Drawing.Size(206, 139);
            this.CLB_Item.TabIndex = 0;
            this.CLB_Item.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLB_Item_ItemCheck);
            this.CLB_Item.SelectedIndexChanged += new System.EventHandler(this.CLB_Item_SelectedIndexChanged);
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Interval = 1000;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 547);
            this.Controls.Add(this.SC_Main);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staubli机器人末端移动速度";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.SC_Main.Panel1.ResumeLayout(false);
            this.SC_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_Main)).EndInit();
            this.SC_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Time)).EndInit();
            this.GB_Setting.ResumeLayout(false);
            this.GB_Setting.PerformLayout();
            this.GB_Analysis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SC_Main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_App;
        private System.Windows.Forms.Label ll_ip;
        private System.Windows.Forms.ComboBox CB_IP;
        private OxyPlot.WindowsForms.PlotView PV_Chart;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.NumericUpDown NUD_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Pause;
        private System.Windows.Forms.RadioButton RD_Time;
        private System.Windows.Forms.RadioButton RD_MoveID;
        private System.Windows.Forms.GroupBox GB_Analysis;
        private System.Windows.Forms.CheckedListBox CLB_Item;
        private System.Windows.Forms.GroupBox GB_Setting;
        private System.Windows.Forms.Timer timer_Refresh;
    }
}

