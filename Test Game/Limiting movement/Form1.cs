using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limiting_movement
{
    public partial class Form1 : Form
    {
        bool holdSword = false;
        bool activeSword = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_player.Bounds.IntersectsWith(pictureBoxWallLeft.Bounds))
                {
                    pictureBox_player.Left -= 0;
                }
                else pictureBox_player.Left -= 15;

                if (holdSword == true)
                {
                    pictureBoxSword.Location = pictureBox_player.Location;
                    activeSword = false;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox_player.Bounds.IntersectsWith(pictureBoxWallRight.Bounds))
                {
                    pictureBox_player.Left -= 0;
                }
                else pictureBox_player.Left += 15;

                if (holdSword == true)
                {
                    pictureBoxSword.Location = pictureBox_player.Location;
                    activeSword = false;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (pictureBox_player.Bounds.IntersectsWith(pictureBoxWallTop.Bounds))
                {
                    pictureBox_player.Left -= 0;
                }
                else pictureBox_player.Top -= 15;

                if (holdSword == true)
                {
                    pictureBoxSword.Location = pictureBox_player.Location;
                    activeSword = false;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (pictureBox_player.Bounds.IntersectsWith(pictureBoxWallBottom.Bounds))
                {
                    pictureBox_player.Left -= 0;
                }
                else pictureBox_player.Top += 15;

                if (holdSword == true)
                {
                    pictureBoxSword.Location = pictureBox_player.Location;
                    activeSword = false;
                }
            }

            if (e.KeyCode == Keys.X)
            {
                if (pictureBox_player.Bounds.IntersectsWith(pictureBoxNPC.Bounds) && label1.Text.Equals("Hi!"))
                {
                    label1.Text = "Sup!";
                }

                if (pictureBox_player.Bounds.IntersectsWith(pictureBoxNPC.Bounds) && label1.Text.Equals(""))
                {
                    label1.Text = "Hi!";
                }

                if (pictureBox_player.Bounds.IntersectsWith(pictureBoxSword.Bounds) && (holdSword == false))
                {
                    holdSword = true;
                }
            }

            if (e.KeyCode == Keys.Z)
            {
                if (holdSword == true)
                {
                    if (activeSword == false)
                    {
                        activeSword = true;
                        pictureBoxSword.Top += 20;
                    }
                    else if (activeSword == true)
                    {
                        pictureBoxSword.Top -= 0;
                    }
                }
            }
            if (pictureBoss.Bounds.IntersectsWith(pictureBoxSword.Bounds) && (activeSword == true))
            {
                if (progressBar1.Value >= 5)
                {
                    progressBar1.Value -= 5;
                }
                else progressBar1.Value = 0;
            }
            

            if (!pictureBox_player.Bounds.IntersectsWith(pictureBoxNPC.Bounds))
            {
                if (progressBar1.Value <= 4)
                {
                    label1.Text = "You did it, yay!";
                }
                else label1.Text = "";
            }
        }
    }
}
