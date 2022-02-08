using System;
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
        int enemySpeed = 12;
        int gravity = 10;
        int score = 0;
        int highestScore = 0;
        int counter = 1;
        
        public gameScreen()
        {
            InitializeComponent();
            endMenu.Hide();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            // Moving the bird and pipes 

            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            enemy.Left -= enemySpeed;   

            // Displying the score

            scoreText.Text = /*"Score: " + */score.ToString();
            if (score > highestScore)
            {
                highestScore = score;
            }
            highestScoreText.Text = "Best score: " + highestScore.ToString();

            // Spawning the pipes

            if (pipeBottom.Left < -100)
            {
                pipeBottom.Left = 600;
                score++;
            }

            if(pipeTop.Left < -120)
            {
                pipeTop.Left = 720;
                score++;
            }

            // Spawning the enemies

            if(enemy.Left < -100)
            {
                enemy.Left = 2500;
            }

            // Increasing game speed

            if(score / 10 == counter)
            {
                pipeSpeed++;
                enemySpeed++;
                counter++;
            }

            // End game

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
               flappyBird.Bounds.IntersectsWith(limit.Bounds) ||
               flappyBird.Bounds.IntersectsWith(enemy.Bounds))
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
            flappyBird.Hide();
            enemy.Hide();
            endMenu.Show();
               
        }


        // Reseting the game
        private void restart_Click_1(object sender, EventArgs e)
        {
            gameTimer.Start();
            score = 0;
            counter = 1;
            pipeSpeed = 8;
            enemySpeed = 12;
            endMenu.Hide();
            flappyBird.Show();
            enemy.Show();
            enemy.Location = new Point(2500, 242);
            flappyBird.Location = new Point(27, 189);
            pipeTop.Location = new Point(538, -36);
            pipeBottom.Location = new Point(404, 336);
        }

        // Quit game
        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            startScreen startWindow = new startScreen();
            startWindow.Show();
            this.Hide();
        }
    }
}
