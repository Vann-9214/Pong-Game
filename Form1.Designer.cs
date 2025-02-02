namespace Pong_Game
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            Player = new PictureBox();
            Computer = new PictureBox();
            Ball = new PictureBox();
            GameTime = new System.Windows.Forms.Timer(components);
            Menu = new Button();
            PlayerScore = new Label();
            ComputerScore = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackgroundImage = (Image)resources.GetObject("Player.BackgroundImage");
            Player.BackgroundImageLayout = ImageLayout.None;
            Player.Location = new Point(33, 276);
            Player.Name = "Player";
            Player.Size = new Size(24, 141);
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // Computer
            // 
            Computer.BackgroundImage = (Image)resources.GetObject("Computer.BackgroundImage");
            Computer.BackgroundImageLayout = ImageLayout.None;
            Computer.Location = new Point(1381, 276);
            Computer.Name = "Computer";
            Computer.Size = new Size(24, 141);
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            // 
            // Ball
            // 
            Ball.BackgroundImage = (Image)resources.GetObject("Ball.BackgroundImage");
            Ball.BackgroundImageLayout = ImageLayout.Stretch;
            Ball.Location = new Point(778, 276);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            // 
            // GameTime
            // 
            GameTime.Enabled = true;
            GameTime.Interval = 20;
            GameTime.Tick += GameTimerEvent;
            // 
            // Menu
            // 
            Menu.BackgroundImage = (Image)resources.GetObject("Menu.BackgroundImage");
            Menu.BackgroundImageLayout = ImageLayout.Stretch;
            Menu.Location = new Point(700, 6);
            Menu.Name = "Menu";
            Menu.Size = new Size(55, 45);
            Menu.TabIndex = 4;
            Menu.UseVisualStyleBackColor = true;
            // 
            // PlayerScore
            // 
            PlayerScore.AutoSize = true;
            PlayerScore.BackColor = Color.Black;
            PlayerScore.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerScore.ForeColor = Color.FromArgb(57, 255, 20);
            PlayerScore.Location = new Point(12, 9);
            PlayerScore.Name = "PlayerScore";
            PlayerScore.Size = new Size(223, 42);
            PlayerScore.TabIndex = 3;
            PlayerScore.Text = "Player Score: 0";
            // 
            // ComputerScore
            // 
            ComputerScore.AutoSize = true;
            ComputerScore.BackColor = Color.Black;
            ComputerScore.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputerScore.ForeColor = Color.Red;
            ComputerScore.Location = new Point(1153, 9);
            ComputerScore.Name = "ComputerScore";
            ComputerScore.Size = new Size(273, 42);
            ComputerScore.TabIndex = 5;
            ComputerScore.Text = "Computer Score: 0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 15);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(12, 616);
            panel2.Name = "panel2";
            panel2.Size = new Size(1414, 15);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(12, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 577);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(1411, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 577);
            panel4.TabIndex = 8;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1438, 643);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ComputerScore);
            Controls.Add(Menu);
            Controls.Add(PlayerScore);
            Controls.Add(Computer);
            Controls.Add(Player);
            Controls.Add(Ball);
            DoubleBuffered = true;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player;
        private PictureBox Computer;
        private PictureBox Ball;
        private System.Windows.Forms.Timer GameTime;
        private Button Menu;
        private Label PlayerScore;
        private Label ComputerScore;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
