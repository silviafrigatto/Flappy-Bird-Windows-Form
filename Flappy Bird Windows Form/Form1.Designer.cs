namespace Flappy_Bird_Windows_Form
{
    partial class gameScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.endMenu = new System.Windows.Forms.GroupBox();
            this.menu = new System.Windows.Forms.PictureBox();
            this.highestScoreText = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.endMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scoreText.Font = new System.Drawing.Font("Whimsy TT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scoreText.Location = new System.Drawing.Point(328, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(48, 45);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "0";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // endMenu
            // 
            this.endMenu.BackColor = System.Drawing.Color.DarkKhaki;
            this.endMenu.Controls.Add(this.menu);
            this.endMenu.Controls.Add(this.highestScoreText);
            this.endMenu.Controls.Add(this.quit);
            this.endMenu.Controls.Add(this.restart);
            this.endMenu.Controls.Add(this.pictureBox1);
            this.endMenu.Location = new System.Drawing.Point(144, 98);
            this.endMenu.Name = "endMenu";
            this.endMenu.Size = new System.Drawing.Size(406, 374);
            this.endMenu.TabIndex = 6;
            this.endMenu.TabStop = false;
            // 
            // menu
            // 
            this.menu.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.Menu_button_sprite;
            this.menu.Location = new System.Drawing.Point(122, 228);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(172, 62);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 11;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // highestScoreText
            // 
            this.highestScoreText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.highestScoreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highestScoreText.Font = new System.Drawing.Font("Whimsy TT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestScoreText.Location = new System.Drawing.Point(122, 121);
            this.highestScoreText.Name = "highestScoreText";
            this.highestScoreText.Size = new System.Drawing.Size(172, 25);
            this.highestScoreText.TabIndex = 7;
            this.highestScoreText.Text = "Best score: 0";
            this.highestScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quit
            // 
            this.quit.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.Quit_button_sprite;
            this.quit.Location = new System.Drawing.Point(122, 296);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(172, 62);
            this.quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quit.TabIndex = 10;
            this.quit.TabStop = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // restart
            // 
            this.restart.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.Restart_button_sprite;
            this.restart.Location = new System.Drawing.Point(122, 160);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(172, 62);
            this.restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restart.TabIndex = 9;
            this.restart.TabStop = false;
            this.restart.Click += new System.EventHandler(this.restart_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.game_over_sprite;
            this.pictureBox1.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-10, 478);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(733, 82);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(538, -36);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(108, 229);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeBottom.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(404, 336);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(108, 173);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(27, 189);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(52, 45);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-10, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(696, 495);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.enemy;
            this.enemy.Location = new System.Drawing.Point(667, 242);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(72, 58);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy.TabIndex = 9;
            this.enemy.TabStop = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.flappy_bird_backgorund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 547);
            this.Controls.Add(this.endMenu);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pictureBox2);
            this.Name = "gameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            this.endMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox endMenu;
        private System.Windows.Forms.Label highestScoreText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox restart;
        private System.Windows.Forms.PictureBox quit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox enemy;
    }
}

