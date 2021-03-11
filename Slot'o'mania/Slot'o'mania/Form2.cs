using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_o_mania
{
    public partial class Form2 : Form
    {
        int extrapoints = 0;
        string run = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1(extrapoints, run);
            go.Show();
            this.Hide();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }
    }
}
