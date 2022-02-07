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
    public partial class aboutScreen : Form
    {
        public aboutScreen()
        {
            InitializeComponent();
        }

        private void loadMenu(object sender, EventArgs e)
        {
            startScreen startWindow = new startScreen();
            startWindow.Show();
            this.Close();
        }
    }
}
