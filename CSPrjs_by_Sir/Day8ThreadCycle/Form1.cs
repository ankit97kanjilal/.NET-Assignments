using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Day8ThreadCycle
{
    public partial class Form1 : Form
    {

        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MyWatch watch = new MyWatch();
            ParameterizedThreadStart ts1 = new ParameterizedThreadStart(watch.StartTimer);
            t1 = new Thread(ts1);
            t1.Start(lblTime);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t1.Abort();
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            t1.Suspend();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            t1.Resume();
        }
    }

    class MyWatch
    {
        Label lbl;

        public void StartTimer(object lbl)
        {
            this.lbl = (Label)lbl;

            while (true)
            {
                this.lbl.Text = DateTime.Now.ToString("hh:mm:ss");
                Thread.Sleep(1000);
            }
        }
    }
}
