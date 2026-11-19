using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        int color = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Red.BackColor = Color.White;
            Yellow.BackColor = Color.White;
            Green.BackColor = Color.White;
            color = 0;

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (color == 0)
            {
                Red.BackColor = Color.Red;
                color = 1;
            }
            else if (color == 1)
            {
                Yellow.BackColor = Color.Yellow;
                color = 2;
            }
            else if (color == 2)
            {
                Green.BackColor = Color.Green;
            }
        }
    }
}
