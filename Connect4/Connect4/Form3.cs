using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Connect4
{
    public partial class Form3 : Form
    {
        string[,] board =
        {
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""}

        };
        public Form3()
        {
            InitializeComponent();
        }


        private void flash()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int g = 0; g < 6; g++)
                {
                    this.Controls["p" + i + g].BackgroundImage = Properties.Resources.Red;
                    
                }
            }

        }

        private void clearit()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int g = 0; g < 6; g++)
                {
                    this.Controls["p" + i + g].BackgroundImage = null;

                }
            }
        }
        private void displaywin()
        {

            for (int d = 0; d < 7; d++)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (board[i, d] == "")
                    {
                        for (int j = 5; j > i; j--)
                        {
                            this.Controls["p" + d + j].BackgroundImage = Properties.Resources.Red;
                            this.Update();
                            Thread.Sleep(20);



                        }
                        this.Controls["p" + d + i].BackgroundImage = Properties.Resources.Red;
                    }
                }

            }

            while (true)
            {
                flash();
                this.Update();
                Thread.Sleep(50);
                clearit();
                this.Update();
                Thread.Sleep(50);
            }

        }

        private void show(object sender, EventArgs e)
        {
            displaywin();
        }
    }
}
