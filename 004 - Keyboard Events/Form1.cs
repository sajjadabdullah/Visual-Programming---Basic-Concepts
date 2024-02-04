using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004___Keyboard_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            listBox1.Items.Add($"Key Down {e.KeyCode}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Items.Add($"Key Up {e.KeyCode}");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox1.Items.Add($"Key Press {e.KeyChar}");
        }
    }
}
