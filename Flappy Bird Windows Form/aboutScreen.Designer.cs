namespace Flappy_Bird_Windows_Form
{
    partial class aboutScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Whimsy TT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi!\r\n\r\nWrite something about the game\r\n";
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.Menu_button_sprite;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Location = new System.Drawing.Point(258, 444);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(172, 62);
            this.menu.TabIndex = 1;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.loadMenu);
            // 
            // aboutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.flappy_bird_backgorund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 547);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Name = "aboutScreen";
            this.Text = "aboutScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menu;
    }
}