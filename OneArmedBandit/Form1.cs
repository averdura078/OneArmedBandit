﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator and int value for score
        Random randGenerator = new Random();
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            // get random values for each reel
            int reel1Value = randGenerator.Next(1, 4);
            int reel2Value = randGenerator.Next(1, 4);
            int reel3Value = randGenerator.Next(1, 4);

            for (int i = 1; i <= 10; i++)
            {
                pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                //Refresh(pictureBox1.BackgroundImage);
                Thread.Sleep(5);

                pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                Refresh();
                Thread.Sleep(5);

                pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                Refresh();
                Thread.Sleep(5);
            }

            //changing of the image, followed by a refresh, followed by a short pause. 
            //To make it look even better have the pause get longer and longer as the reels spin. 


            // check value of reel 1 with a switch statement and set appropriate image
            switch (reel1Value)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // check value of reel 2 with a switch statement and set appropriate image
            switch (reel2Value)
            {
                case 1:
                    pictureBox2.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox2.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement and set appropriate image
            switch (reel3Value)
            {
                case 1:
                    pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // use compound if statement to check if all reels are equal 
            // in all same show "winner" statement and add 3 to score
            // else show "play again" statement and subtract 1 from score         
            if (reel1Value == reel2Value && reel1Value == reel3Value)
            {
                outputLabel.Text = "WINNER!!";
                score = score + 3;
            }
            else
            {
                outputLabel.Text = "Play Again?";
                score--;
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (score <= 0)
            {
                outputLabel.Text = "You Lose";
                spinButton.Enabled = false;
            }

            // display updated score
            scoreDisplay.Text = Convert.ToString(score);
        }
    }
}
