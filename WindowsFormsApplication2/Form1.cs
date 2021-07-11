using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Threading;

namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        //Thread wacthSerivce = new Thread(null);
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread wacthSerivce = new Thread(new ThreadStart(refreshService));
            wacthSerivce.Start();
        }

        //程序退出清除所有线程
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button_runServiceA_Click(object sender, EventArgs e)
        {
            SetServiceStatus("ZhuDongFangYu", (button_runServiceA.Text == "运行" ? 1 : 0));
        }

        private void button_runServiceB_Click(object sender, EventArgs e)
        {
            SetServiceStatus("AxInstSV", (button_runServiceB.Text == "运行" ? 1 : 0));
        }

        //服务状态监听
        private void refreshService()
        {
            while (true) {
                string[] status = { GetServiceStatus("XZSS"), GetServiceStatus("AxInstSV") };
                button_runServiceA.Text = status[0] == "Running" ? "停止" : "运行";
                button_runServiceB.Text = status[1] == "Running" ? "停止" : "运行";
                label_Status_A.Text = "服务状态：" + status[0];
                label_Status_B.Text = "服务状态：" + status[1];
                System.Threading.Thread.Sleep(500);
            }
        }

        //获取服务状态
        private string GetServiceStatus(string serviceName)
        {
            if (Array.Find(ServiceController.GetServices(), service => service.ServiceName == serviceName) == null) return null;
            return new ServiceController(serviceName).Status.ToString();
        }

        //设置服务状态
        private bool SetServiceStatus(string serviceName,int StatusType)
        {
            ServiceController Service = new ServiceController(serviceName);
            string ServiceStatus = GetServiceStatus(serviceName);
            if (ServiceStatus == null) return false;
            try
            {
                if (ServiceStatus == "Stopped" && StatusType == 1) Service.Start();
                if (ServiceStatus == "Running" && StatusType == 0) Service.Stop();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败："+ex.ToString());
                return false;
            }
        }
    }
}
