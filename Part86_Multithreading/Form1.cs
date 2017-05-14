using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Process - Process is what the os uses to facilitate the execution of a program by providng the resources required.
// Thread - Thread is a leight weight process. A process has at least one thread which is called as main thread. A process can have multiple threads.
// Benefits of multithreading is that it makes application responsive

namespace Part86_Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnDoTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            // At this point the application is unresponsive
            //DoTimeConsumingWork();
            // Create another thread
            Thread backgroundThread = new Thread(DoTimeConsumingWork);
            backgroundThread.Start();

            btnDoTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(1000);
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }
    }
}
