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
    public partial class Form3 : Form
    {
        double morepoints = 0;
        double extrapoints = 0;
        int tries = 4;
        string run;

        Random box = new Random();
        string[] items = { "Kareem", "Kareem", "Kareem", "Jordan", "Jordan", "Jordan", "Shaq", "Shaq", "Shaq", "Magic", "Magic", "Magic", "Larry", "Larry", "Larry", "Larry", "Shaq" };
        string[] mixeditems = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        public Form3(double points, string run)
        {

            InitializeComponent();

            run = "extra";
            extrapoints = extrapoints + points;
            lblpoints.Text = morepoints.ToString();
            
            int arrayspot;
            int newaspot = 0;
            while (newaspot < items.Length)
            {
                arrayspot = box.Next(0, items.Length);
                if (items[arrayspot] != "taken")
                {
                    mixeditems[newaspot] = items[arrayspot];
                    items[arrayspot] = "taken";
                    newaspot++;

                }

            }
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            


        }

        private void reveal(object sender, EventArgs e)
        {
            //displaying picture in box clicked
            PictureBox oneclicked = (PictureBox)sender;
            char[] temparray = oneclicked.Name.ToCharArray();
            string tempnum = "";
            if (temparray[3] != '0') tempnum = tempnum + temparray[3];
            tempnum = tempnum + temparray[4];
            int num_in_name = int.Parse(tempnum);

            switch (mixeditems[num_in_name])

            {
                case "Jordan":
                    oneclicked.Image = Properties.Resources.jordanhead;
                    MessageBox.Show("Plus 400 extrapoints");
                    morepoints = morepoints + 400; lblpoints.Text = morepoints.ToString();
                    tries = tries - 1;
                    if (tries == 3) live1.Visible = false;
                    if (tries == 2) live2.Visible = false;
                    if (tries == 1) live3.Visible = false;
                    if (tries == 0)
                    {
                        MessageBox.Show("You're all out of tries! You cashed out with " + morepoints + " extra extrapoints!");
                        extrapoints = extrapoints + morepoints;
                        Form1 done = new Form1 (extrapoints, run);
                        done.Show();


                        this.Hide();

                        this.Hide();
                    }
                    break;
                case "Larry":
                    
                    tries = tries - 1;
                    oneclicked.Image = Properties.Resources.larryhead;
                    MessageBox.Show("Plus 300 extrapoints"); morepoints = morepoints + 300; lblpoints.Text = morepoints.ToString();
                    if (tries == 3) live1.Visible = false;
                    if (tries == 2) live2.Visible = false;
                    if (tries == 1) live3.Visible = false;
                    if (tries == 0)
                    {
                        MessageBox.Show("You're all out of tries! You cashed out with " + morepoints + " extra extrapoints!");
                        extrapoints = extrapoints + morepoints;
                        Form1 done = new Form1 (extrapoints, run);
                        done.Show();


                        this.Hide();
                    }
                    break;
                case "Shaq":
                    oneclicked.Image = Properties.Resources.shaqhead; morepoints = morepoints + 200; lblpoints.Text = morepoints.ToString(); MessageBox.Show("Plus 200 extrapoints");
                    tries = tries - 1;
                    if (tries == 3) live1.Visible = false;
                    if (tries == 2) live2.Visible = false;
                    if (tries == 1) live3.Visible = false;
                    if (tries == 0)
                    {
                        MessageBox.Show("You're all out of tries! You cashed out with " + morepoints + " extra extrapoints!");
                        extrapoints = extrapoints + morepoints;
                        Form1 done = new Form1 (extrapoints, run);
                        done.Show();


                        this.Hide();


                        this.Hide();
                    }
                    break;
                case "Magic":
                    oneclicked.Image = Properties.Resources.magichead; morepoints = morepoints + 250; lblpoints.Text = morepoints.ToString(); MessageBox.Show("Plus 250 extrapoints!");
                    tries = tries - 1;
                    if (tries == 3) live1.Visible = false;
                    if (tries == 2) live2.Visible = false;
                    if (tries == 1) live3.Visible = false;
                    if (tries == 0)
                    {
                        MessageBox.Show("You're all out of tries! You cashed out with " + morepoints + " extra extrapoints!");
                        extrapoints = extrapoints + morepoints;
                        Form1 done = new Form1 (extrapoints, run);
                        done.Show();


                        this.Hide();

                        this.Hide();
                    }
                    break;
                case "Kareem":
                    oneclicked.Image = Properties.Resources.kareemheadshot; MessageBox.Show("Plus 350 extrapoints!"); morepoints = morepoints + 350; lblpoints.Text = morepoints.ToString();
                    tries = tries - 1;
                    if (tries == 3) live1.Visible = false;
                    if (tries == 2) live2.Visible = false;
                    if (tries == 1) live3.Visible = false;
                    if (tries == 0)
                    {
                        MessageBox.Show("You're all out of tries! You cashed out with " + morepoints + " extra extrapoints!");
                        extrapoints = extrapoints + morepoints;
                        Form1 done = new Form1 (extrapoints, run);
                        done.Show();


                        this.Hide();

                        this.Hide();
                    }
                    break;

            }


        }

        private void lblpoints_Click(object sender, EventArgs e)
        {

        }

        private void message(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Hall of Fame bonus game! Just click on a basketball and you will be rewarded with points, you have four tries");
        }
    }
}
