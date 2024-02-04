using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            //it will change the background color of the label to DarkRed
            lblHelloWorld.BackColor = Color.DarkRed;
            lblHelloWorld.ForeColor = Color.White;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblHelloWorld.BackColor = Color.DarkGreen;
            lblHelloWorld.ForeColor = Color.White;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblHelloWorld.BackColor = Color.DarkBlue;
            lblHelloWorld.ForeColor = Color.White;
        }
    }
}
