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
        int gravity = 15;
        int score = 0;
        
        public gameScreen()
        {
            InitializeComponent();
        }


        // Game methods
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }
    }
}