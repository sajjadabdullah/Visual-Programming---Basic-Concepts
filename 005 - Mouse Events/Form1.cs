using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005___Mouse_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblWelcomeUser_MouseEnter(object sender, EventArgs e)
        {
            lblResponse.Text = "Welcome";
        }

        private void lblWelcomeUser_MouseLeave(object sender, EventArgs e)
        {
            lblResponse.Text = "Bye";
        }

        private void lblWelcomeUser_Click(object sender, EventArgs e)
        {
            lblResponse.Text = $"Clicked";
        }

        private void lblWelcomeUser_MouseClick(object sender, MouseEventArgs e)
        {
            lblResponse.Text = $"Clicked with Mouse at {e.X}, {e.Y}, {e.Button}";
        }

        private void lblWelcomeUser_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoords.Text = $"{e.X}, {e.Y}";
        }
    }
}
