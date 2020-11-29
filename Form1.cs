using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_Pop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int arrowX;
        int ballSize; //ball size duh
        int[] ballX = new int[5]; //ball x
        int[] ballY = new int[5]; //u dum or wat
        int[] ballSpeed = new int[5]; //djiasehgakuebrthatj
        int arrowSize;
        Graphics graphics;
        Brush background;
        Random rng = new Random(); //eyyyyyy

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timDebug_Tick(object sender, EventArgs e)
        {
            debug.Text = Convert.ToString(timGame.Enabled);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x;
            //spread balls w/ 20px padding
            ballSize = (int)((pnlGame.Width - 6 * 20) / 5);
            x = 10;
            for (int i = 0; i < 5; i++)
            {
                //the infamous for loop
                ballX[i] = x; //cycle ball sizes
                x += ballSize + 20;
            }
            //make pin 1/2 ball size
            arrowSize = (int)(ballSize / 2);
            graphics = pnlGame.CreateGraphics();
            background = new SolidBrush(pnlGame.BackColor);
            //give game focus
            this.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            graphics.Dispose();
            background.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //erase arrow at old loc
            graphics.FillRectangle(background, arrowX, pnlGame.Height - arrowSize, arrowSize, arrowSize); ;
            //check for a and d (use if switch doesn't work
            //if (e.KeyCode == Keys.A)
            //{
            //    arrowX = arrowX - 5;
            //}
            //else if (e.KeyCode == Keys.D)
            //{
            //    arrowX = arrowX + 5;
            //}
            switch (e.KeyCode) //look here if you are trying to find out how to work the game
            {
                case Keys.A:
                    arrowX -= 10; //move arrow left when A is pressed
                    break;
                case Keys.D:
                    arrowX += 10; //move arrow right when D is pressed
                    break;
                default:
                    break; //do nothing
            }
            graphics.DrawImage(picArrow.Image, arrowX, pnlGame.Height - arrowSize, arrowSize, arrowSize);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text != "Start")
            {
                //text is "Pause"
                txtOver.Visible = true;
                btnStart.Text = "Start";
                btnExit.Enabled = true;
            }
            else
            {
                //New game
                graphics.Clear(pnlGame.BackColor);
                txtOver.Visible = false;
                btnStart.Text = "Pause";
               btnExit.Enabled = false;
                txtScore.Text = "0";
                //SetAutoScrollMargin each ball off the top of the panel and give speed
                for (int i = 0; i < 5; i++)
                {
                    ballY[i] = -ballSize;
                    ballSpeed[i] = rng.Next(4) + 3;
                }
                //set arrow near centre
                arrowX = (int)(pnlGame.Width / 2);
                graphics.DrawImage(picArrow.Image, arrowX, pnlGame.Height - arrowSize, arrowSize, arrowSize);
                //umm
                this.Focus();
            }
            //toggle timers
            timBalls.Enabled = !(timBalls.Enabled);
            timGame.Enabled = !(timGame.Enabled);
        }

        private void timGame_Tick(object sender, EventArgs e)
        {
            //1 min elapsed
            timBalls.Enabled = false;
            timGame.Enabled = false;
            txtOver.Visible = true;
            btnStart.Text = "Start";
            btnExit.Enabled = true;
        }

        private void timBalls_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                //erase ball
                graphics.FillRectangle(background, ballX[i], ballY[i], ballSize, ballSize);

                //move ball
                ballY[i] += ballSpeed[i];

                //check if ball has popped
                if ((ballY[i] + ballSize) > (pnlGame.Height - arrowSize))
                {
                    if (ballX[i] < arrowX)
                    {
                        if ((ballX[i] + ballSize) > (arrowX + arrowSize))
                        {
                            //ball has popped
                            //increase score and move back to top
                            System.Media.SystemSounds.Hand.Play();
                            txtScore.Text = Convert.ToString(Convert.ToInt32(txtScore.Text) + 1);
                            ballY[i] = -ballSize;
                            ballSpeed[i] = rng.Next(4) + 3;
                        }
                    }
                }

                //check for moving of bottom
                if ((ballY[i] + ballSize) > pnlGame.Height)
                {
                    //someone's reaction time is bad
                    //move back to top with new (pseudo-random) speed
                    ballY[i] = -ballSize;
                    ballSpeed[i] = rng.Next(4) + 3;
                }

                //redraw ball at new loc
                graphics.DrawImage(picBall.Image, ballX[i], ballY[i], ballSize, ballSize);
            }
        }
    }
}
