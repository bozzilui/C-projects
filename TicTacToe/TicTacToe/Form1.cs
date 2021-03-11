using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player1 = true;
        bool player2 = false;

        string[] spots = { "", "", "", "", "", "", "", "", "", "", };

        public Form1()
        {
            InitializeComponent();
        }

        //when a box is clicked
        private void Selectspot(object sender, EventArgs e)
        {

            PictureBox oneiclicked = (PictureBox)sender;         
            char[] temparray = oneiclicked.Name.ToCharArray();
            string tempnum = "";
            tempnum = tempnum + temparray[4];
            int num_in_name = int.Parse(tempnum);
            if (player1 == true)
            {
                lbl_playerturn.Text = "Player 2's turn";
                oneiclicked.Enabled = false;
                spots[num_in_name] = "x";
                player1 = false;
                player2 = true;
                oneiclicked.BackgroundImage = Properties.Resources.ctlogo;
                Player1move();
                
            }
            else if (player2 == true)
            {
                lbl_playerturn.Text = "Player 1's turn";
                oneiclicked.Enabled = false;
                spots[num_in_name] = "o";
                player2 = false;
                player1 = true;
                oneiclicked.BackgroundImage = Properties.Resources.tlogo;
                Player2move();
            }

        }

        #region playermoves
        //if its player1's turn
        private void Player1move()
        {
            
            
                //check for horizontal
                if ((spots[0] == "x" && spots[1] == "x" && spots[2] == "x") || (spots[3] == "x" && spots[4] == "x" && spots[5] == "x") || (spots[6] == "x" && spots[7] == "x" && spots[8] == "x"))
                {

                    if ((spots[0] == spots[1] && spots[1] == spots[2]) || (spots[3] == spots[4] && spots[4] == spots[5]) || (spots[6] == spots[7] && spots[7] == spots[8]))
                    {
                        if (spots[0] == "x" || spots[3] == "x" || spots[6] == "x")
                        {
                            Form3 ctwin = new Form3();
                            ctwin.Show();
                            this.Hide();
                        }
                    }

                }
                //check for vertical
                if ((spots[0] == "x" && spots[3] == "x" && spots[6] == "x") || (spots[1] == "x" && spots[4] == "x" && spots[7] == "x") || (spots[2] == "x" && spots[5] == "x" && spots[8] == "x"))
                {

                    if ((spots[0] == spots[3] && spots[3] == spots[6]) || (spots[1] == spots[4] && spots[4] == spots[7]) || (spots[2] == spots[5] && spots[5] == spots[8]))
                    {
                        if (spots[0] == "x" || spots[1] == "x" || spots[2] == "x")
                        {
                            Form3 ctwin = new Form3();
                            ctwin.Show();
                            this.Hide();
                        }
                    }

                }
                //check for diagonal
                if ((spots[0] == "x" && spots[4] == "x" && spots[8] == "x") || (spots[2] == "x" && spots[4] == "x" && spots[6] == "x"))
                {

                    if ((spots[0] == spots[4] && spots[4] == spots[8]) || (spots[2] == spots[4] && spots[4] == spots[6]))
                    {
                        if (spots[0] == "x" || spots[2] == "x")
                        {
                            Form3 ctwin = new Form3();
                            ctwin.Show();
                            this.Hide();
                        }
                    }

                }
                //if its a catsgame
                if (spots[0] != "" && spots[3] != "" && spots[6] != "" && spots[1] != "" && spots[4] != "" && spots[7] != "" && (spots[2] != "" && spots[5] != "" && spots[8] != ""))
                {
                    MessageBox.Show("catsgame");
                    Application.Restart();
                }
            
        }
        //if its player2's turn
        private void Player2move()
        {


            //check for horizontal
            if ((spots[0] == "o" && spots[1] == "o" && spots[2] == "o") || (spots[3] == "o" && spots[4] == "o" && spots[5] == "o") || (spots[6] == "o" && spots[7] == "o" && spots[8] == "o"))
            {

                    if ((spots[0] == spots[1] && spots[1] == spots[2]) || (spots[3] == spots[4] && spots[4] == spots[5]) || (spots[6] == spots[7] && spots[7] == spots[8]))
                    {
                        if (spots[0] == "o" || spots[3] == "o" || spots[6] == "o")
                        {
                            Form4 twin = new Form4();
                            twin.Show();
                            this.Hide();
                        }
                    }

                }
                //check for vertical
                if ((spots[0] == "o" && spots[3] == "o" && spots[6] == "o") || (spots[1] == "o" && spots[4] == "o" && spots[7] == "o") || (spots[2] == "o" && spots[5] == "o" && spots[8] == "o"))
                {

                    if ((spots[0] == spots[3] && spots[3] == spots[6]) || (spots[1] == spots[4] && spots[4] == spots[7]) || (spots[2] == spots[5] && spots[5] == spots[8]))
                    {
                        if (spots[0] == "o" || spots[1] == "o" || spots[2] == "o")
                        {
                            Form4 twin = new Form4();
                            twin.Show();
                            this.Hide();
                        }
                    }

                }
                //check for diagonal
                if ((spots[0] == "o" && spots[4] == "o" && spots[8] == "o") || (spots[2] == "o" && spots[4] == "o" && spots[6] == "o"))
                {

                    if ((spots[0] == spots[4] && spots[4] == spots[8]) || (spots[2] == spots[4] && spots[4] == spots[6]))
                    {
                        if (spots[0] == "o" || spots[2] == "o")
                        {
                            Form4 twin = new Form4();
                            twin.Show();
                            this.Hide();
                        }
                    }

                }
            
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
