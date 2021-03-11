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
    
    public partial class PlayForm : Form
    {
        int bet;
        int money = 1000;
        string name;
        int character;
        int sum = 0;
        int c = 0;
        int dealersum = 0;
        int playerwon = 0;
        int dealerwon = 0;

        int[] Ranks = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        int[] Suits = new int[4] { 1, 2, 3, 4 };
        PictureBox[] cards;
       
        Random rdrank = new Random();
        Random rdsuit = new Random();

        public PictureBox[] Cards { get => cards; set => cards = value; }

        public PlayForm(string x, int y)
        {
            InitializeComponent();
            name = x;
            character = y;
            lblname.Text = (name + "'s Sum:");
            if (character == 1)
            {
                characterpb.Image = Properties.Resources.avatar1;
            }
            else if (character == 2)
            {
                characterpb.Image = Properties.Resources.avatar2;
            }
            else if (character == 2)
            {
                characterpb.Image = Properties.Resources.avatar2;
            }
            else if (character == 3)
            {
                characterpb.Image = Properties.Resources.avatar3;
            }
            else if (character == 4)
            {
                characterpb.Image = Properties.Resources.avatar4;
            }
            else if (character == 5)
            {
                characterpb.Image = Properties.Resources.avatar5;
            }
            else if (character == 6)
            {
                characterpb.Image = Properties.Resources.avatar6;
            }
            if (bet == 0)
            {
                Hitme.Enabled = false;
            }
            lblmoney.Text = money.ToString();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Hitme_Click(object sender, EventArgs e)
        {
            Disablebets();
           
            if (money < 0)
            {
                MessageBox.Show("You lost all your money, the house wins");
                Application.Restart();
            }
            if (bet == 0)
            {
                Hitme.Enabled = false;
            }
            {
                
                c = c + 1;
                Randomcard();
                Sumcount();
                
            }
            
        }

        //getting a random card for the player
        private void Randomcard()
        {
            Cardamount();
            //random suit is chosen from the suits array
            string picname = "" + c;
            int randomsuit = Suits[rdsuit.Next(0, Suits.Length)];
            //if hearts is chosen
            if (randomsuit == 1)
            {
                //random rank is chosen
                int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
                

                if (randomrank == 1)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.AHeart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    
                    if (sum >= 11)
                    {
                        sum = sum + 1;
                    }
                    else
                    {
                        sum = sum + 11;
                    }
                }
                else if (randomrank == 2)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._2Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 3)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._3Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 4)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._4Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 5)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._5Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 6)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._6Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 7)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._7Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 8)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._8Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 9)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._9Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 10)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._10Heart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 11)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.JHeart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 12)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.QHeart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 13)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.KHeart;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
            }
            //if spades is chosen
            else if (randomsuit == 2)
            {
                int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
               

                if (randomrank == 1)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.ASpade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    
                    if (sum >= 11)
                    {
                        sum = sum + 1;
                    }
                    else
                    {
                        sum = sum + 11;
                    }
                }
                else if (randomrank == 2)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._2Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;

                }
                else if (randomrank == 3)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._3Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 4)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._4Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 5)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._5Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 6)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._6Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 7)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._7Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 8)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._8Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 9)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._9Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 10)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._10Spade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 11)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.JSpade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 12)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.QSpade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 13)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.KSpade;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
            }
            //if diamonds is chosen
            else if (randomsuit == 3)
            {
                int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
               

                if (randomrank == 1)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.ADiamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    
                    if (sum >= 11)
                    {
                        sum = sum + 1;
                    }
                    else
                    {
                        sum = sum + 11;
                    }
                }
                else if (randomrank == 2)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._2Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 3)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._3Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 4)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._4Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 5)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._5Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 6)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._6Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 7)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._7Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 8)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._8Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 9)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._9Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 10)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._10Diamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 11)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.JDiamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 12)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.QDiamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 13)
                {
                    
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.KDiamond;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                    this.Refresh();
                }
            }

            //if clubs is chosen
            else if (randomsuit == 4)
            {
                int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
                

                if (randomrank == 1)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.AClub;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    
                    if (sum >= 11)
                    {
                        sum = sum + 1;
                    }
                    else
                    {
                        sum = sum + 11;
                    }
                }
                else if (randomrank == 2)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._2Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 3)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._3Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 4)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._4Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 5)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._5Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 6)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._6Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 7)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._7Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 8)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._8Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 9)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._9Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 10)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources._10Club;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + randomrank;
                }
                else if (randomrank == 11)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.JClub;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 12)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.QClub;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
                else if (randomrank == 13)
                {
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BackgroundImage = Properties.Resources.KClub;
                    ((PictureBox)this.Controls["pic" + picname.ToString()]).BringToFront();
                    sum = sum + 10;
                }
            }

            lblsum.Text = sum.ToString();

        }

        //counting the sum of all the players cards
        private void Sumcount()
        {
            if (sum < 21)
            {
                btnstop.Visible = true;
            }
            else if (sum > 21)
            {
                MessageBox.Show("Bust! The dealer wins");
               
                lblmoney.Text = money.ToString();
                c = 0;
                sum = 0;
                dealersum = 0;
                bet = 0;
                lblbet.Text = bet.ToString();
                lblsum.Text = sum.ToString();
                btnstop.Visible = false;
                Hitme.Enabled = false;
                Enablebets();
                ClearPictures();
            }
            else if (sum == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                
                money = money + (bet * 2);
                lblmoney.Text = money.ToString();
                c = 0;
                sum = 0;
                lblsum.Text = sum.ToString();
                dealersum = 0;
                bet = 0;
                lblbet.Text = bet.ToString();
                btnstop.Visible = false;
                Hitme.Enabled = false;
                Enablebets();
                ClearPictures();
            }
        }

        //amount of cards in players hand
       private void Cardamount()
        {
            if (c == 1)
            {
                pic1.Visible = true;
            }
            else if (c == 2)
            {
                pic2.Visible = true;
            }
            else if (c == 3)
            {
                pic3.Visible = true;
            }
            else if (c == 4)
            {
                pic4.Visible = true;
            }
            else if (c == 5)
            {
                pic5.Visible = true;
            }
            else if (c == 6)
            {
                pic6.Visible = true;
            }
            else if (c == 7)
            {
                pic7.Visible = true;
            }
            else if (c == 8)
            {
                pic8.Visible = true;
            }
            else if (c == 9)
            {
                pic9.Visible = true;
            }
            else if (c == 10)
            {
                pic10.Visible = true;
            }
            else if (c == 11)
            {
                pic11.Visible = true;
            }

        }

       

        private void btnstop_Click(object sender, EventArgs e)
        {
            Enablebets();
            Hitme.Enabled = false;
            //loop for dealer to get cards
            for (int d = 1; d < 6; d++)
            {
                lbldealersum.Text = dealersum.ToString();
                //all of these will reset the game
                if (dealersum == 21)
                {
                    MessageBox.Show("The dealer wins!");                                      
                    lbldealersum.Text = dealersum.ToString();
                    lblmoney.Text = money.ToString();
                    c = 0;
                    sum = 0;
                    dealersum = 0;
                    bet = 0;                   
                    lblbet.Text = bet.ToString();
                    lblsum.Text = sum.ToString();
                    btnstop.Visible = false;
                    ClearPictures();
                    break;
                }
                else if (dealersum > 21)
                {
                    MessageBox.Show("The dealer losses, You win!");                   
                    lbldealersum.Text = dealersum.ToString();
                    money = money + (bet * 2);
                    lblmoney.Text = money.ToString();
                    c = 0;
                    sum = 0;
                    dealersum = 0;
                    bet = 0;                   
                    lblbet.Text = bet.ToString();
                    lblsum.Text = sum.ToString();
                    btnstop.Visible = false;
                    ClearPictures();
                    break;
                }
                else if (dealersum > sum)
                {
                    MessageBox.Show("The dealer wins!");                    
                    lbldealersum.Text = dealersum.ToString();
                    c = 0;
                    sum = 0;
                    dealersum = 0;
                    bet = 0;                    
                    lblmoney.Text = money.ToString();
                    lblbet.Text = bet.ToString();
                    lblsum.Text = sum.ToString();
                    btnstop.Visible = false;
                    ClearPictures();
                    break;
                }
                             
                //number of cards in dealers hand
                string cardnum = "" + d;
                
               //card number in loop
               if (d == 1)
               {
                    dealercard1.Visible = true;
                    int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
                    Checkdealercards();
                   
                    //random card number
                    if (randomrank == 1)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.AHeart;

                        
                        if (sum >= 11)
                        {
                            dealersum = dealersum + randomrank;
                        }
                        else
                        {
                            sum = sum + 11;
                        }
                    }
                    else if (randomrank == 2)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._2Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 3)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._3Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 4)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._4Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 5)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._5Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 6)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._6Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 7)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._7Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 8)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._8Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 9)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._9Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 10)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._10Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 11)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.JHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 12)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.QHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 13)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.KHeart;

                        dealersum = dealersum + 10;
                    }
                }
               else if (d == 2)
                {
                    dealercard2.Visible = true;
                    int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
                    Checkdealercards();
                    

                    if (randomrank == 1)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.AHeart;

                        
                        if (sum >= 11)
                        {
                            dealersum = dealersum + randomrank;
                        }
                        else
                        {
                            sum = sum + 11;
                        }
                    }
                    else if (randomrank == 2)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._2Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 3)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._3Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 4)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._4Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 5)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._5Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 6)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._6Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 7)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._7Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 8)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._8Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 9)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._9Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 10)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._10Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 11)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.JHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 12)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.QHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 13)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.KHeart;

                        dealersum = dealersum + 10;
                    }
                }
               else if (d == 3)
                {
                    dealercard3.Visible = true;
                    int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
                    Checkdealercards();
                    
                    if (randomrank == 1)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.AHeart;

                        
                        if (sum >= 11)
                        {
                            dealersum = dealersum + randomrank;
                        }
                        else
                        {
                            sum = sum + 11;
                        }
                    }
                    else if (randomrank == 2)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._2Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 3)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._3Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 4)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._4Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 5)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._5Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 6)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._6Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 7)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._7Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 8)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._8Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 9)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._9Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 10)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._10Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 11)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.JHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 12)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.QHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 13)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.KHeart;

                        dealersum = dealersum + 10;
                    }
                }
               else if (d == 4)
                {
                    dealercard4.Visible = true;
                    int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
                    Checkdealercards();
                    
                    if (randomrank == 1)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.AHeart;

                        
                        if (sum >= 11)
                        {
                            dealersum = dealersum + randomrank;
                        }
                        else
                        {
                            sum = sum + 11;
                        }
                    }
                    else if (randomrank == 2)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._2Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 3)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._3Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 4)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._4Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 5)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._5Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 6)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._6Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 7)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._7Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 8)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._8Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 9)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._9Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 10)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._10Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 11)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.JHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 12)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.QHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 13)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.KHeart;

                        dealersum = dealersum + 10;
                    }
                }
               else if (d == 5)
                {
                    dealercard5.Visible = true;
                    int randomrank = Ranks[rdrank.Next(0, Ranks.Length)];
                    Checkdealercards();
                    
                    if (randomrank == 1)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.AHeart;

                        
                        if (sum >= 11)
                        {
                            dealersum = dealersum + randomrank;
                        }
                        else
                        {
                            sum = sum + 11;
                        }
                    }
                    else if (randomrank == 2)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._2Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 3)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._3Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 4)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._4Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 5)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._5Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 6)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._6Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 7)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._7Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 8)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._8Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 9)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._9Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 10)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources._10Heart;

                        dealersum = dealersum + randomrank;
                    }
                    else if (randomrank == 11)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.JHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 12)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.QHeart;

                        dealersum = dealersum + 10;
                    }
                    else if (randomrank == 13)
                    {
                        ((PictureBox)this.Controls["dealercard" + cardnum.ToString()]).Image = Properties.Resources.KHeart;

                        dealersum = dealersum + 10;
                    }
                }
            }
            lbldealersum.Text = dealersum.ToString();
            Checkdealercards();
            

        }

        //see if dealer or player won
        //then 'resets' game
        private void Checkdealercards()
        {
            if (dealersum == 21)
            {
                MessageBox.Show("The dealer wins!");
                
                dealerwon = dealerwon + 1;
                lbldealersum.Text = dealersum.ToString();
                lblmoney.Text = money.ToString();
                c = 0;
                sum = 0;
                dealersum = 0;
                bet = 0;
                dealerwon = 0;
                lblbet.Text = bet.ToString();
                lblsum.Text = sum.ToString();
                ClearPictures();
            }
            else if (dealersum > 21)
            {
                MessageBox.Show("The dealer losses, You win!");
                playerwon = playerwon + 1;
                lbldealersum.Text = dealersum.ToString();
                money = money + (bet * 2);
                lblmoney.Text = money.ToString();
                c = 0;
                sum = 0;
                dealersum = 0;
                bet = 0;
                playerwon = 0;
                lblbet.Text = bet.ToString();
                lblsum.Text = sum.ToString();
                ClearPictures();
            }
            else if (dealersum > sum)
            {
                MessageBox.Show("The dealer wins!");
                dealerwon = dealerwon + 1;
                lbldealersum.Text = dealersum.ToString();
                c = 0;
                sum = 0;
                dealersum = 0;
                bet = 0;
                dealerwon = 0;
                lblmoney.Text = money.ToString();
                lblbet.Text = bet.ToString();
                lblsum.Text = sum.ToString();
                ClearPictures();
            }
        }


        private void bet5_Click(object sender, EventArgs e)
        {
            bet = bet + 5;
            if (bet > money)
            {
                MessageBox.Show("You dont have that much money");
                Hitme.Enabled = false;
                money = money + bet;
                bet = 0;
            }
            else
            {
                Hitme.Enabled = true;
            }
            if (money <= 0)
            {
                MessageBox.Show("You have no more money");
                Application.Exit();
            }
            Hitme.Enabled = true;
            money = money - 5;
            lblmoney.Text = money.ToString();
            lblbet.Text = bet.ToString();
        }

        private void bet10_Click(object sender, EventArgs e)
        {
            bet = bet + 10;
            if (money < 10)
            {
                MessageBox.Show("You dont have that much money");
                Hitme.Enabled = false;
                money = money + bet;
                bet = 0;
            }
            else
            {
                Hitme.Enabled = true;
            }
            if (money <= 0)
            {
                MessageBox.Show("You have no more money");
                Application.Exit();
            }
           
            money = money - 10;
            lblmoney.Text = money.ToString();
            lblbet.Text = bet.ToString();
        }

        private void bet50_Click(object sender, EventArgs e)
        {
            bet = bet + 50;
            if (money < 50)
            {
                MessageBox.Show("You dont have that much money");
                Hitme.Enabled = false;
                money = money + bet;
                bet = 0;
            }
            else
            {
                Hitme.Enabled = true;
            }
            if (money <= 0)
            {
                MessageBox.Show("You have no more money");
                Application.Exit();
            }
            money = money - 50;
            lblmoney.Text = money.ToString();
            lblbet.Text = bet.ToString();
        }

        private void bet100_Click(object sender, EventArgs e)
        {
            bet = bet + 100;
            if (money < 100)
            {
                MessageBox.Show("You dont have that much money");
                Hitme.Enabled = false;
                money = money + bet;
                bet = 0;
            }
            else
            {
                Hitme.Enabled = true;
            }
            if (money <= 0)
            {
                MessageBox.Show("You have no more money");
                Application.Exit();
            }
            money = money - 100;
            lblmoney.Text = money.ToString();
            lblbet.Text = bet.ToString();
        }

        private void bet500_Click(object sender, EventArgs e)
        {
            bet = bet + 500;
            if (money < 500)
            {
                MessageBox.Show("You dont have that much money");
                Hitme.Enabled = false;
                money = money + bet;
                bet = 0;
            }
            else if ( money == 500)
            {
                Hitme.Enabled = true;
            }
            else
            {
                Hitme.Enabled = true;
            }
            if ( money <= 0)
            {
                MessageBox.Show("You have no more money");
                Application.Exit();
            }
            money = money - 500;
            lblmoney.Text = money.ToString();
            lblbet.Text = bet.ToString();
        }

        private void ClearPictures()
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
            pic8.Visible = false;
            pic9.Visible = false;
            pic10.Visible = false;
            pic11.Visible = false;
            dealercard1.Visible = false;
            dealercard2.Visible = false;
            dealercard3.Visible = false;
            dealercard4.Visible = false;
            dealercard5.Visible = false;
            dealercard6.Visible = false;
            dealercard7.Visible = false;

        }

        private void Disablebets()
        {
            bet10.Visible = false;
            bet5.Visible = false;
            bet50.Visible = false;
            bet100.Visible = false;
            bet500.Visible = false;
            lbl10.Visible = false;
            lbl5.Visible = false;
            lbl50.Visible = false;
            lbl100.Visible = false;
            lbl500.Visible = false;
        }

        private void Enablebets()
        {
            bet10.Visible = true;
            bet5.Visible = true;
            bet50.Visible = true;
            bet100.Visible = true;
            bet500.Visible = true;
            lbl10.Visible = true;
            lbl5.Visible = true;
            lbl50.Visible = true;
            lbl100.Visible = true;
            lbl500.Visible = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have cashed out with $" + money);
            Application.Exit();
        }
    }
} 
