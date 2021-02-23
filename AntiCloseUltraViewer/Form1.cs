using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCloseUltraViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            btnOnOff.Enabled = false;
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    Process[] processes = Process.GetProcessesByName("UltraViewer_Desktop");
                    if (processes.Length == 0)
                        System.Diagnostics.Process.Start("C:\\Program Files (x86)\\UltraViewer\\UltraViewer_Desktop.exe");
                    Thread.Sleep(5000);
                }
            }).Start();
            btnOnOff.Text = "Đã mở UltraViewer vĩnh viễn";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            // Cho hiện notifyIcon
            notifyIcon1.Visible = true;
            // Hiện BaloonTip hoặc không
            //notifyIcon1.ShowBalloonTip(10);

            // Chọn ẩn
            this.Hide();
            // Hoặc
            this.ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            // Hoặc cả 2 để ẩn form
        }

        private void itemCloseClick(object sender, ToolStripItemClickedEventArgs e)
        {
            Close();
        }

        private void showClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void none(object sender, MouseEventArgs e)
        {

        }
    }
}
