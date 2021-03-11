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
using System.Dynamic;


namespace Slot_o_mania
{
    public partial class Form1 : Form
    {
        string run;
        int jordancnt = 0;
        double points = 1000;
        double bet = 0;
        string lines = "one";
        int winnum= 0;
        int picnum = 0;
        Random box = new Random();

        string[,] machine = new string[3,5]
        {
            {"","","","","" },
            {"","","","","" },
            {"","","","","" }
        };

        public Form1(double extrapoints, string run)
        {
            InitializeComponent();
            if (extrapoints > 0)
            {
                points = extrapoints;
                lbl_points.Text = points.ToString();
                run = "none";
            }
            else if (extrapoints == 0)
            {
                points = 1000;
                lbl_points.Text = points.ToString();
            }
            cb_lines.SelectedIndex = 0;
            cb_bets.SelectedIndex = 0;
        }

        private void showpictures()
        {
            for(int i = 0;i<3; i++)
            {
                for(int g = 0 ; g<5;g++)
                {
                    picnum = box.Next(0, 7);
                    if (picnum == 0)
                    {
                        picnum = box.Next(0, 7);
                        if (picnum == 0)
                        {
                            jordancnt++;
                        }
                    }
                    machine[i, g] = picnum.ToString();
                 
                }
            }
            
            for (int i = 0; i < 3; i++)
            {
                for(int g = 0; g<5;g++)
                {
                    if(machine[i,g] == "0")
                    {
                        this.Controls["p" + g + i].BackgroundImage = Properties.Resources.jordanhead;
                    }
                    else if (machine[i, g] == "1")
                    {
                        this.Controls["p" + g + i].BackgroundImage = Properties.Resources.lebronhead;
                    }
                    else if (machine[i, g] == "2")
                    {
                        this.Controls["p" + g + i].BackgroundImage = Properties.Resources.duranthead;

                    }
                    else if (machine[i, g] == "3")
                    {
                        this.Controls["p" + g + i].BackgroundImage = Properties.Resources.lonzohead;
                    }
                    else if (machine[i, g] == "4")
                    {
                        this.Controls["p" + g + i].BackgroundImage = Properties.Resources.kyriehead;

                    }
                    else if (machine[i, g] == "5")
                    {
                        this.Controls["p" + g + i].BackgroundImage = Properties.Resources.kembahead;
                    }
                    else if (machine[i, g] == "6")
                    {
                        this.Controls["p" + g + i].BackgroundImage = Properties.Resources.javalehead;
                    }
                }
            }


        }

        private void oneline()
        {
            
            if ((machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3] && machine[1, 3] == machine[1, 4]))
            {
               
                
                winnum = 1;
                checkwinnumhorz();
            }
            if (jordancnt >= 3)
            {
                MessageBox.Show("bonus!");
                Form3 bonus = new Form3 (points, run);
                bonus.Show();
                this.Hide();
            }
            
        }

        private void twolines()
        {
            
            if ((machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3] && machine[1, 3] == machine[1, 4]))
            {
                
                winnum = 1;
                checkwinnumhorz();
            }
            if ((machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3] && machine[2, 3] == machine[2, 4]))
            {
                
                winnum = 2;
                checkwinnumhorz();
            }
            if (jordancnt == 3)
            {
                MessageBox.Show("bonus!");
                Form3 bonus = new Form3 (points, run);
                bonus.Show();
                this.Hide();
            }
            
        }

        private void threelines()
        {
            
            if ((machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3] && machine[1, 3] == machine[1, 4]))
            {
                
                
                winnum = 1;
                checkwinnumhorz();
            }
            if ((machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3] && machine[2, 3] == machine[2, 4]))
            {
                 
                winnum = 2;
                checkwinnumhorz();
            }
            if ((machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2]) || (machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2] && machine[0, 2] == machine[0, 3]) || (machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2] && machine[0, 2] == machine[0, 3] && machine[0, 3] == machine[0, 4]))
            {
                
                 
                winnum = 0;
                checkwinnumhorz();
            }
            if (jordancnt == 3)
            {
                MessageBox.Show("bonus!");
                Form3 bonus = new Form3 (points, run);
                bonus.Show();
                this.Hide();
            }
            
        }

        private void fourlines()
        {
            
            if ((machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3] && machine[1, 3] == machine[1, 4]))
            {
                 
                winnum = 1;
                checkwinnumhorz();
            }
            if ((machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3] && machine[2, 3] == machine[2, 4]))
            {
                 
                winnum = 2;
                checkwinnumhorz();
            }
            if ((machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2]) || (machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2] && machine[0, 2] == machine[0, 3]) || (machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2] && machine[0, 2] == machine[0, 3] && machine[0, 3] == machine[0, 4]))
            {
                 
                winnum = 0;
                checkwinnumhorz();
            }
            if ((machine[0, 0] == machine[1, 1] && machine[1, 1] == machine[2, 2]) || (machine[0, 0] == machine[1, 1] && machine[1, 1] == machine[2, 2] && machine[2, 2] == machine[1, 3]) || (machine[0, 0] == machine[1, 1] && machine[1, 1] == machine[2, 2] && machine[2, 2] == machine[1, 3] && machine[1,3] == machine[0,4]))
            {
                 
                winnum = 0;
                checkwindiag();
            }
            if (jordancnt == 3)
            {
                MessageBox.Show("bonus!");
                Form3 bonus = new Form3 (points, run);
                bonus.Show();
                this.Hide();
            }
            
        }

        private void fivelines()
        {
            
            if ((machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3]) || (machine[1, 0] == machine[1, 1] && machine[1, 1] == machine[1, 2] && machine[1, 2] == machine[1, 3] && machine[1, 3] == machine[1, 4]))
            {
                 
                winnum = 1;
                checkwinnumhorz();
            }
            if ((machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3]) || (machine[2, 0] == machine[2, 1] && machine[2, 1] == machine[2, 2] && machine[2, 2] == machine[2, 3] && machine[2, 3] == machine[2, 4]))
            {
                 
                winnum = 2;
                checkwinnumhorz();
            }
            if ((machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2]) || (machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2] && machine[0, 2] == machine[0, 3]) || (machine[0, 0] == machine[0, 1] && machine[0, 1] == machine[0, 2] && machine[0, 2] == machine[0, 3] && machine[0, 3] == machine[0, 4]))
            {
                 
                winnum = 0;
                checkwinnumhorz();
            }
            if ((machine[0, 0] == machine[1, 1] && machine[1, 1] == machine[2, 2]) || (machine[0, 0] == machine[1, 1] && machine[1, 1] == machine[2, 2] && machine[2, 2] == machine[1, 3]) || (machine[0, 0] == machine[1, 1] && machine[1, 1] == machine[2, 2] && machine[2, 2] == machine[1, 3] && machine[1, 3] == machine[2, 4]))
            {
                 
                winnum = 0;
                checkwindiag();
            }
            if ((machine[2, 0] == machine[1, 1] && machine[1, 1] == machine[0, 2]) || (machine[2, 0] == machine[1, 1] && machine[1, 1] == machine[0, 2] && machine[0, 2] == machine[1, 3]) || (machine[2, 0] == machine[1, 1] && machine[1, 1] == machine[0, 2] && machine[0, 2] == machine[1, 3] && machine[1, 3] == machine[0, 4]))
            {
                 
                winnum = 2;
                checkwindiag();
            }
            if (jordancnt == 3)
            {
                MessageBox.Show("bonus!");
                Form3 bonus = new Form3 (points, run);
                bonus.Show();
                this.Hide();
            }
            
        }

        

        private void test_Click(object sender, EventArgs e)
        {
            if (cb_bets.SelectedIndex == 0)
            {
                bet = 20;
            }
            if (cb_bets.SelectedIndex == 1)
            {
                bet = 50;
            }
            if (cb_bets.SelectedIndex == 2)
            {
                bet = 100;
            }
            if (cb_bets.SelectedIndex == 3)
            {
                bet = 250;
            }
            if (cb_bets.SelectedIndex == 4)
            {
                bet = 500;
            }

            if (points < bet)
            {
                MessageBox.Show("You dont have enough points for that!");
                cb_bets.SelectedIndex = 0;

            }
            else if(points <= 0)
            {
                MessageBox.Show("You're all out of points!");
            }
            else
            {
                
                if (lines == "one")
                {
                    showpictures();
                    points = points - bet;
                    lbl_points.Text = points.ToString();
                    oneline();

                    jordancnt = 0;
                }
                if (lines == "two")
                {
                    bet = bet * 1.5;
                    if (points < bet)
                    {
                        MessageBox.Show("You dont have enough points for that!");
                        cb_bets.SelectedIndex = 0;
                        cb_lines.SelectedIndex = 0;

                    }
                    else
                    {
                        showpictures();
                        points = points - bet;
                        lbl_points.Text = points.ToString();
                        twolines();

                        jordancnt = 0;
                    }
                }
                if (lines == "three")
                {
                    bet = bet * 1.75;
                    if (points < bet)
                    {
                        MessageBox.Show("You dont have enough points for that!");
                        cb_bets.SelectedIndex = 0;
                        cb_lines.SelectedIndex = 0;

                    }
                    else
                    {
                        showpictures();
                        points = points - bet;
                        lbl_points.Text = points.ToString();
                        threelines();
                        jordancnt = 0;
                    }
                   
                }
                if (lines == "four")
                {
                    bet = bet * 2;
                    if (points < bet)
                    {
                        MessageBox.Show("You dont have enough points for that!");
                        cb_bets.SelectedIndex = 0;
                        cb_lines.SelectedIndex = 0;

                    }
                    else
                    {
                        showpictures();
                        points = points - bet;
                        lbl_points.Text = points.ToString();
                        fourlines();
                        jordancnt = 0;
                    }
                }
                if (lines == "five")
                {
                    bet = bet * 2.5;
                    if (points < bet)
                    {
                        MessageBox.Show("You dont have enough points for that!");
                        cb_bets.SelectedIndex = 0;
                        cb_lines.SelectedIndex = 0;

                    }
                    else
                    {
                        showpictures();
                        points = points - bet;
                        lbl_points.Text = points.ToString();
                        fivelines();
                        jordancnt = 0;
                    }
                }
            }
        }

        private void checkwindiag()
        {
            if (winnum == 0)
            {
                if (machine[0, 0] == machine[2, 2] && machine[2, 2] != machine[1, 3])
                {
                    checkbetwin3();
                }
                else if (machine[0, 0] == machine[2, 2] && machine[2, 2] == machine[1, 3] && machine[1, 3] != machine[0, 4])
                {
                    checkbetwin4();
                }
                else if (machine[0, 0] == machine[2, 2] && machine[2, 2] == machine[1, 3] && machine[1, 3] == machine[0, 4])
                {
                    checkbetwin5();
                }
            }
            else if (winnum == 2)
            {
                if (machine[2, 0] == machine[0, 2] && machine[0, 2] != machine[1, 3])
                {
                    checkbetwin3();
                }
                else if (machine[2, 0] == machine[0, 2] && machine[0, 2] == machine[1, 3] && machine[1, 3] != machine[2, 4])
                {
                    checkbetwin4();
                }
                else if (machine[2, 0] == machine[0, 2] && machine[0, 2] == machine[1, 3] && machine[1, 3] == machine[2, 4])
                {
                    checkbetwin5();
                }
            }
        }

        private void checkwinnumhorz()
        {
            if (machine[winnum, 0] == machine[winnum, 2] && machine[winnum, 2] != machine[winnum, 3])
            {
                checkbetwin3();
            }
            else if (machine[winnum, 0] == machine[winnum, 2] && machine[winnum, 2] == machine[winnum, 3] && machine[winnum, 3] != machine[winnum, 4])
            {
                checkbetwin4();
            }
            else if (machine[winnum, 0] == machine[winnum, 2] && machine[winnum, 2] == machine[winnum, 3] && machine[winnum, 3] == machine[winnum, 4])
            {
                checkbetwin5();
            }
        }

        private void checkbetwin3()
        {
            switch (machine[winnum, 0])
            {
                case "1":
                    MessageBox.Show("3 lebrons! plus 400 points!");
                    points = points + 400;
                    lbl_points.Text = points.ToString();
                    break;
                case "2":
                    MessageBox.Show("3 durants! plus 300 points!");
                    points = points + 300;
                    lbl_points.Text = points.ToString();
                    break;
                case "3":
                    MessageBox.Show("3 lonzos! plus 25 points!");
                    points = points + 25;
                    lbl_points.Text = points.ToString();
                    break;
                case "4":
                    MessageBox.Show("3 kyries! plus 250 points!");
                    points = points + 250;
                    lbl_points.Text = points.ToString();
                    break;
                case "5":
                    MessageBox.Show("3 kembas! plus 100 points!");
                    points = points + 100;
                    lbl_points.Text = points.ToString();
                    break;
                case "6":
                    MessageBox.Show("3 javales! plus 50 points!");
                    points = points + 50;
                    lbl_points.Text = points.ToString();
                    break;

            }






        }

        private void checkbetwin4()
        {
            switch (machine[winnum, 0])
            {
                case "1":
                    MessageBox.Show("4 lebrons! plus 600 points!");
                    points = points + 600;
                    lbl_points.Text = points.ToString();
                    break;
                case "2":
                    MessageBox.Show("4 durants! plus 450 points!");
                    points = points + 450;
                    lbl_points.Text = points.ToString();
                    break;
                case "3":
                    MessageBox.Show("4 lonzos! plus 50 points!");
                    points = points + 50;
                    lbl_points.Text = points.ToString();
                    break;
                case "4":
                    MessageBox.Show("4 kyries! plus 300 points!");
                    points = points + 300;
                    lbl_points.Text = points.ToString();
                    break;
                case "5":
                    MessageBox.Show("4 kembas! plus 200 points!");
                    points = points + 200;
                    lbl_points.Text = points.ToString();
                    break;
                case "6":
                    MessageBox.Show("4 javales! plus 150 points!");
                    points = points + 150;
                    lbl_points.Text = points.ToString();
                    break;

            }
        }

        private void checkbetwin5()
        {
            switch (machine[winnum, 0])
            {
                case "1":
                    MessageBox.Show("5 lebrons! plus 1000 points!");
                    points = points + 1000;
                    lbl_points.Text = points.ToString();
                    break;
                case "2":
                    MessageBox.Show("5 durants! plus 750 points!");
                    points = points + 750;
                    lbl_points.Text = points.ToString();
                    break;
                case "3":
                    MessageBox.Show("5 lonzos! plus 100 points!");
                    points = points + 100;
                    lbl_points.Text = points.ToString();
                    break;
                case "4":
                    MessageBox.Show("5 kyries! plus 500 points!");
                    points = points + 500;
                    lbl_points.Text = points.ToString();
                    break;
                case "5":
                    MessageBox.Show("5 kembas! plus 350 points!");
                    points = points + 350;
                    lbl_points.Text = points.ToString();
                    break;
                case "6":
                    MessageBox.Show("5 javales! plus 200 points!");
                    points = points + 200;
                    lbl_points.Text = points.ToString();
                    break;

            }
        }

        private void changelines(object sender, EventArgs e)
        {
            if(cb_lines.SelectedIndex == 0)
            {
                lines = "one";
            }
            else if(cb_lines.SelectedIndex == 1)
            {
                lines = "two";
            }
            else if (cb_lines.SelectedIndex == 2)
            {
                lines = "three";
            }
            else if (cb_lines.SelectedIndex == 3)
            {
                lines = "four";
            }
            else if (cb_lines.SelectedIndex == 4)
            {
                lines = "five";
            }
        }

        private void changebet(object sender, EventArgs e)
        {
            if(cb_bets.SelectedIndex == 0)
            {
                bet = 20;
            }
            if (cb_bets.SelectedIndex == 1)
            {
                bet = 50;
            }
            if (cb_bets.SelectedIndex == 2)
            {
                bet = 100;
            }
            if (cb_bets.SelectedIndex == 3)
            {
                bet = 250;
            }
            if (cb_bets.SelectedIndex == 4)
            {
                bet = 500;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (points < 1000)
            {
                Form4 lose = new Form4();
                lose.Show();
            }
            else if (points > 1000)
            {
                Form5 win = new Form5();
                win.Show();
            }
            else if(points == 1000)
            {
               if (MessageBox.Show("You haven't gained any money are you sure you want to leave?", "Cash Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
               else
                {

                }
            }
        }
    }
}
