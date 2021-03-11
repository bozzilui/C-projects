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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_playagain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
