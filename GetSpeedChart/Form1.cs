using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotKit;
using OxyPlot;
using OxyPlot.Series;
using System.Threading;
using System.Threading.Tasks;

namespace GetSpeedChart
{
    public partial class Form_Main : Form
    {
        SoapClient sc = null;
        Thread tr = null;
        bool bExit = false;
        double[,] speeddata = new double[1000, 2];
        int ReadCount = 0;
        int ChartCount = 0;

        bool Pause;

        int LineCount = 0;

        bool GetDataByTime;

        int polltime;
        PlotModel pm = new PlotModel
        {
            Title = "Staubli机器人末端移动速度",
            // Subtitle = "Example using the FunctionSeries",
            PlotType = PlotType.Cartesian,
            Background = OxyColors.White
        };
        public Form_Main()
        {
            InitializeComponent();

            // PV_Chart.Model = pm;

        }

        private void BT_Login_Click(object sender, EventArgs e)
        {

            if (CB_IP.Text == "")
            {
                MessageBox.Show("请输入CS8C IP 地址");
                return;
            }

            if (CB_App.Text == "")
            {
                MessageBox.Show("请输入下位机加载的应用程序名");
                return;
            }

            sc = new SoapClient(CB_IP.Text.Trim());
            if (!sc.PingNet())
            {

                MessageBox.Show("网络不通，请检查IP地址是否正确或者网络链接");
                return;

            }
            if (!sc.Login())
            {

                MessageBox.Show("Soap登录失败");
                return;

            }
            sc.SoapGetAppname = @"Disk://" + CB_App.Text + "/" + CB_App.Text + ".pjx";

            byte[] data = sc.GetAppdata();

            if (!RobotKit.StaubliXML.IsGlobelData("nRobotSpeed", data))
            {

                MessageBox.Show("应用程序中 nRobotSpeed变量不存在");
                return;
            }

            GetDataByTime = RD_Time.Checked;
            if (!GetDataByTime)
            {
                if (!RobotKit.StaubliXML.IsGlobelData("nID", data))
                {

                    MessageBox.Show("应用程序中nID变量不存在");
                    return;
                }


            }

            MessageBox.Show("登录成功");
            BT_Start.Enabled = true;
            GB_Setting.Enabled = false;



        }






        private void Poll()
        {
            double nidbuff = double.MaxValue;
            DateTime dt = DateTime.Now;
            while (!bExit)
            {

                if (ReadCount - ChartCount < 99 && !Pause)
                {
                    byte[] data = sc.GetAppdata();

                    double nid = (DateTime.Now - dt).TotalSeconds;
                    if (!GetDataByTime)
                    {

                        nid = StaubliXML.GetXMLDouble("nID", StaubliXML.Byte2xd(data));

                    }
                    double nSpeed = StaubliXML.GetXMLDouble("nRobotSpeed", StaubliXML.Byte2xd(data));

                    if (nid != nidbuff && nid > 0)
                    {
                        nidbuff = nid;
                    
                        speeddata[ReadCount % 100, 0] = nid;
                        speeddata[ReadCount % 100, 1] = nSpeed;
                        ReadCount++;

                    }


                }
                System.Threading.Thread.Sleep(polltime);









            }




        }

        private void BT_Start_Click(object sender, EventArgs e)
        {

            if (BT_Start.Text == "开始")
            {
                if (tr != null && tr.IsAlive)
                {

                    tr.Abort();
                }
                polltime = (int)NUD_Time.Value * 1000;
                bExit = false;
                tr = new Thread(new ThreadStart(Poll));
                tr.Start();

                BT_Start.Text = "终止";
                BT_Pause.Enabled = true;
                pm.Series.Clear();
                Task.Factory.StartNew(() =>
                {
                    double nIDbuff = double.MaxValue;
                    LineSeries ls = new LineSeries();
                    int LineIndex = 0;
                    var rd = new Random();

               
                    while (!bExit)
                    {
                        if (ReadCount > ChartCount)
                        {

                            for (int i = ChartCount; i < ReadCount; i++)
                            {
                                if (speeddata[i % 100, 0] < nIDbuff)
                                {
                                    byte[] clr = new byte[3];
                                    rd.NextBytes(clr);


                                    ls = new LineSeries();
                                    ls.Title = "轨迹" + (LineIndex + 1).ToString();
                                    ls.Color = OxyColor.FromRgb(clr[0], clr[1], clr[2]); ;

                                    pm.Series.Add(ls);

                                    LineIndex++;
                                }
                                nIDbuff = speeddata[i % 100, 0];
                                ls.Points.Add(new DataPoint(speeddata[i % 100, 0], speeddata[i % 100, 1]));
                                ChartCount++;


                            }
                            PV_Chart.Model = pm;

                            PV_Chart.Model.InvalidatePlot(true);
                        }



                        Thread.Sleep(500);
                    }
                });



            }
            else
            {
                bExit = true;
                Thread.SpinWait(100);
                if (tr != null && tr.IsAlive)
                {

                    tr.Abort();
                }


                BT_Start.Text = "开始";
                BT_Pause.Enabled = false;
            }

        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            bExit = true;
            if (tr != null && tr.IsAlive)
            {

                tr.Abort();
            }

        }

        private void BT_Pause_Click(object sender, EventArgs e)
        {
            if (BT_Pause.Text == "暂停")
            {
                BT_Pause.Text = "继续";
                Pause = true;

            }
            else
            {

                BT_Pause.Text = "暂停";
                Pause = false;

            }


        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            if (pm != null && pm.Series.Count != LineCount)
            {

                LineCount = pm.Series.Count;
                string[] name = new string[LineCount];
                for(int i=0;i<LineCount;i++)
                {
                    name[i] = pm.Series[i].Title;

                }
                if(LineCount<CLB_Item.Items.Count)
                {
                    CLB_Item.Items.Clear();
                    CLB_Item.Items.AddRange(name);
                    for(int i=0;i<name.Length;i++)
                    {
                        CLB_Item.SetItemChecked(i,true);
                    }

                }
                else
                {

                    for(int i=CLB_Item.Items.Count;i<LineCount;i++)
                    {

                        CLB_Item.Items.Add(name[i]);
                        CLB_Item.SetItemChecked(i, true);
                    }

                }


            }
        }

        private void CLB_Item_ItemCheck(object sender, ItemCheckEventArgs e)
        {


        }

        private void CLB_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CLB_Item.Items.Count <= 0 || pm == null || pm.Series.Count < 1 || pm.Series.Count != CLB_Item.Items.Count)

            {
                return;
            }
            for (int i = 0; i < CLB_Item.Items.Count; i++)
            {

                pm.Series[i].IsVisible = CLB_Item.GetItemChecked(i);

            }
            PV_Chart.Model.InvalidatePlot(true);
            
        }

        private void RB_All_CheckedChanged(object sender, EventArgs e)
        {
            if (CLB_Item.Items.Count <= 0 || pm == null || pm.Series.Count < 1 || pm.Series.Count != CLB_Item.Items.Count)

            {
                return;
            }
            for (int i = 0; i < CLB_Item.Items.Count; i++)
            {

                pm.Series[i].IsVisible = RB_All.Checked;

            }
            PV_Chart.Model.InvalidatePlot(true);
        }

        private void RB_None_CheckedChanged(object sender, EventArgs e)
        {
            if (CLB_Item.Items.Count <= 0 || pm == null || pm.Series.Count < 1 || pm.Series.Count != CLB_Item.Items.Count)

            {
                return;
            }
            for (int i = 0; i < CLB_Item.Items.Count; i++)
            {

                pm.Series[i].IsVisible = !RB_None.Checked;

            }
            PV_Chart.Model.InvalidatePlot(true);
        }
    }
}
