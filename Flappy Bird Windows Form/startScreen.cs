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
    public partial class startScreen : Form
    {
        public startScreen()
        {
            InitializeComponent();
        }

        private void loadGame(object sender, EventArgs e)
        {
            gameScreen gameWindow = new gameScreen();

            gameWindow.Show();

        }
    }
}
