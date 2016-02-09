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

namespace WFAwaitAsync
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Msg01) { Priority = ThreadPriority.Lowest };
            Thread t2 = new Thread(Msg02);            
            t.Start();            
            t2.Start();
        }

        private void Msg01()
        {           
                Thread.Sleep(500);
                MessageBox.Show("msg 01");           
                    }

        private void Msg02()
        {
            Thread.Sleep(500);
            MessageBox.Show("msg 02");

        }

        private async Task Msg03()
        {
            Thread.Sleep(500);
            MessageBox.Show("msg 03");
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            Task tsk1 = Task.Run(new Action(Msg01));            
            Task tsk2 = Task.Run(new Action(Msg02));
        }

        private void Msg04()
        {
            Thread.Sleep(10000);
            MessageBox.Show("msg 04");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(Msg01, Msg02);
        }
    }
}
