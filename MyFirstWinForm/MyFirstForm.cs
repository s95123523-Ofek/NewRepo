using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class MyFirstForm : Form
    {
        int interval = 1000;
        private bool Flag = false;

        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            if (Flag)
            {
                this.BackColor = Color.DodgerBlue;
                this.ForeColor = Color.Pink;
                BtnClickMe.BackColor = Color.Red;
                Flag = false;
            }
            else
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.Brown;
                BtnClickMe.BackColor = Color.DodgerBlue;
                Flag = true;
            }
        }

        private void TxtMyFirstTxt_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("you entered " + TxtMyFirstTxt.Text);
        }
        private void Start_Timer(object sender, EventArgs e)
        {
            tmrMyTimer.Interval = interval;
            tmrMyTimer.Start();
        }
        private void Stop_timer(object sender, EventArgs e)
        {
            tmrMyTimer.Stop(); 
        }
        private void tmrMyTimer_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


    }
}
