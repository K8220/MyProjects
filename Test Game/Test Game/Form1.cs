using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Game
{
    public partial class Form1 : Form
    {
        bool til = false;
        bool til1 = false;
        bool cr = false;
        bool cl = true;
        
        public Form1()
        {
           
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (til == true)
            {
                PictureShot.Location = picturePlayer.Location;
            }
            if (til1 == true)
            {
                PictureShot.Top -= 50;
            }
            if (pictureMoving.Top > Height)
            {
                til1 = false;
                til = false;
            }

            if (pictureMoving.Bounds.IntersectsWith(PictureShot.Bounds))
            {
                progressBar1.Value -= 20;
                til = true;
                til1 = false;
            }
            
            if(progressBar1.Value == 0)
            {
                timer1.Enabled = false;
                labelStart.Text = "to start press Enter";
            }
            if(cl == true)
            {
                pictureMoving.Left -= 12;
            }
            if(cr == true)
            {
                pictureMoving.Left += 12;
            }
            if (pictureMoving.Left > Width)
            {
                cl = true;
                cr = false;
            }
            if (pictureMoving.Left < 0)
            {
                cl = false;
                cr = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                picturePlayer.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                picturePlayer.Left += 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                picturePlayer.Top -= 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                picturePlayer.Top += 10;
            }
            if (e.KeyCode == Keys.Space)
            {
                til = true;
            }
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                MessageBox.Show("Thanks for playing!");
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = true;
                labelEnd.Text = "";
                labelStart.Text = "";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                til1 = true;
                til = false;
            }
        }
    }
}
