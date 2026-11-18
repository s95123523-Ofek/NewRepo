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
    public partial class MySecondForm : Form
    {
        private bool Flag = false;
        public MySecondForm()
        {
            InitializeComponent();
        }

        private void MySecondForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (Flag)
            {
                this.BackColor = Color.DodgerBlue;
                this.ForeColor = Color.Pink;
                btnClickMe.BackColor = Color.Red;
                Flag = false;
            }
            else
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.Brown;
                btnClickMe.BackColor = Color.DodgerBlue;
                Flag = true;
            }
        }
    }
}
