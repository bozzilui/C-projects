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
    public partial class Form1 : Form
    {
        Form2 bluewin = new Form2();
        Form3 redwin = new Form3();
        bool red = false;
        bool blue = false;
        bool done = false;
        int num = 0;
        string checkwincolourvert = "";
        string checkwincolourhorz = "";
        string[,] board = 
        {
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""},
            { "","","","","","",""}
            
        };

        Random box = new Random();
        
        public Form1()
        {
            InitializeComponent();
            num = box.Next(1, 3);
            if (num == 1)
            {
                red = true;
                turnpic.Image = Properties.Resources.Red;
            }
            else if (num == 2)
            {
                blue = true;
                turnpic.Image = Properties.Resources.Blue;
            }

        }

        

        private void slotselect(object sender, EventArgs e)
        {
            PictureBox slotselected = (PictureBox)sender;
            char[] slotname = slotselected.Name.ToCharArray();
            int spot = int.Parse(slotname[6].ToString());

            if (red == true)
            {
                done = false;
                for (int i = 5; i >= 0; i--)
                {
                    if (done == false)
                    {
                        if (board[i, spot] == "")
                        {
                            board[i, spot] = "red";
                            for (int j = 0; j < i; j++)
                            {
                                this.Controls["p" + spot + j].BackgroundImage = Properties.Resources.Red;
                                this.Update();
                                Thread.Sleep(100);
                                this.Controls["p" + spot + j].BackgroundImage = null;
                                this.Update();
                                Thread.Sleep(100);
                                
                            }
                            this.Controls["p" + spot + i].BackgroundImage = Properties.Resources.Red;
                            done = true;
                            blue = true;
                            red = false;
                            turnpic.Image = Properties.Resources.Blue;
                        }
                    }
                    
                }
                wincheck();
            }
            else if (blue == true)
            {
                done = false;
                for (int i = 5; i >= 0; i--)
                {
                    if (done == false)
                    {
                        if (board[i, spot] == "")
                        {
                            board[i, spot] = "blue";
                            for (int j = 0; j < i; j++)
                            {
                                this.Controls["p" + spot + j].BackgroundImage = Properties.Resources.Blue;
                                this.Update();
                                Thread.Sleep(100);
                                this.Controls["p" + spot + j].BackgroundImage = null;
                                this.Update();
                                Thread.Sleep(100);
                                
                            }
                            this.Controls["p" + spot + i].BackgroundImage = Properties.Resources.Blue;
                            done = true;
                            blue = false;
                            red = true;
                            turnpic.Image = Properties.Resources.Red;
                        }
                    }

                }
                wincheck();
            }

            
        }

        private void wincheck()
        {
            //check vertical
            for (int d = 0; d < 7; d++)
            {
                for (int i = 0; i < 6; i++)
                {
                    checkwincolourvert = checkwincolourvert + board[i, d];
                    if (checkwincolourvert.Contains("blueblueblueblue"))
                    {
                        bluewin.Show();
                        this.Hide();
                    }
                    else if (checkwincolourvert.Contains("redredredred"))
                    {
                        redwin.Show();
                        this.Hide();
                    }
                }
                checkwincolourvert = "";
            }
           
           

            //check horizontal
            for (int d = 0; d < 6; d++)
            {
                for (int i = 0; i < 7; i++)
                {
                    checkwincolourhorz = checkwincolourhorz + board[d,i];
                    if (checkwincolourhorz.Contains("blueblueblueblue"))
                    {
                        bluewin.Show();
                        this.Hide();
                    }
                    else if (checkwincolourhorz.Contains("redredredred"))
                    {
                        redwin.Show();
                        this.Hide();
                    }
                }
                checkwincolourhorz = "";
            }

            //check diagonal
            for (int i = 0; i < 4; i++)
            {
                for (int d = 0; d < 6; d++)
                {
                    if ((board[d,i] == "blue") && (board[d - 1, i + 1] == "blue") && (board[d - 2, i + 2] == "blue") && (board[d - 3, i + 3] == "blue"))
                    {
                        bluewin.Show();
                        this.Hide();
                    }
                    else if ((board[d, i] == "red") && (board[d - 1, i + 1] == "red") && (board[d - 2, i + 2] == "red") && (board[d - 3, i + 3] == "red"))
                    {
                        redwin.Show();
                        this.Hide();
                    }
                }
            }
            for (int i = 6; i > 4; i--)
            {
                for (int d = 0; d < 6; d++)
                {
                    if ((board[d, i] == "blue") && (board[d - 1, i - 1] == "blue") && (board[d - 2, i - 2] == "blue") && (board[d - 3, i - 3] == "blue"))
                    {
                        bluewin.Show();
                        this.Hide();
                    }
                    else if ((board[d, i] == "red") && (board[d - 1, i - 1] == "red") && (board[d - 2, i - 2] == "red") && (board[d - 3, i - 3] == "red"))
                    {
                        redwin.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void showpiece(object sender, EventArgs e)
        {
            PictureBox hovered = (PictureBox)sender;
            

            if (red == true)
            {
                hovered.Image = Properties.Resources.Red;
            }
            else if (blue == true)
            {
                hovered.Image = Properties.Resources.Blue;
            }
        }

        private void mouseexit(object sender, EventArgs e)
        {
            PictureBox hovered = (PictureBox)sender;

            hovered.Image = null;
        }
    }
}
