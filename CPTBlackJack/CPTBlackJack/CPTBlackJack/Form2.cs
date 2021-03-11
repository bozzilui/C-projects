using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPTBlackJack
{
    public partial class Form2 : Form
    {
        string name;
        int character;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Changeavatar(object sender, EventArgs e)
        {
            if (cbcharacter.SelectedIndex == 0)
            {
                pbcharacter.Image = Properties.Resources.avatar1;
                character = 1;
            }
            else if (cbcharacter.SelectedIndex == 1)
            {
                pbcharacter.Image = Properties.Resources.avatar2;
                character = 2;
            }
            else if (cbcharacter.SelectedIndex == 2)
            {
                pbcharacter.Image = Properties.Resources.avatar3;
                character = 3;
            }
            else if (cbcharacter.SelectedIndex == 3)
            {
                pbcharacter.Image = Properties.Resources.avatar4;
                character = 4;
            }
            else if (cbcharacter.SelectedIndex == 4)
            {
                pbcharacter.Image = Properties.Resources.avatar5;
                character = 5;
            }
            else if (cbcharacter.SelectedIndex == 5)
            {
                pbcharacter.Image = Properties.Resources.avatar6;
                character = 6;
            }

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            name = txtname.Text;
            PlayForm a = new PlayForm(name,character);
            a.Show();
            this.Hide();
        }
    }
}
