﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class gameScreen : Form
    {

        // Game variables

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        int counter = 1;
        
        public gameScreen()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            // Moving the bird and pipes 

            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            // Displying the score

            scoreText.Text = "Score: " + score.ToString();
           
            // Spawning the pipes

            if(pipeBottom.Left < -100)
            {
                pipeBottom.Left = 600;
                score++;
            }

            if(pipeTop.Left < -120)
            {
                pipeTop.Left = 720;
                score++;
            }

            // Increasing game speed

            if(score / 10 == counter)
            {
                pipeSpeed++;
                counter++;
            }

            // End game

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

        }

        
        // Game key configuration
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            //MessageBox.Show("GAME OVER!");
            scoreText.Text += " GAME OVER";
        }
    }
}
