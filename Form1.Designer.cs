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
            PanelUp = new Panel();
            PanelDown = new Panel();
            PanelLeft = new Panel();
            PanelRight = new Panel();
            MenuPanel = new Panel();
            Exit = new Button();
            View = new Button();
            Settings = new Button();
            Restart = new Button();
            Resume = new Button();
            label1 = new Label();
            Countdown = new Label();
            SettingsPanel = new Panel();
            Back = new Button();
            PaddleSize = new Button();
            BallSpeed = new Button();
            Difficulty = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            MenuPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
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
            Menu.Click += Menu_Click;
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
            // PanelUp
            // 
            PanelUp.BackColor = SystemColors.ButtonShadow;
            PanelUp.Location = new Point(12, 54);
            PanelUp.Name = "PanelUp";
            PanelUp.Size = new Size(1414, 15);
            PanelUp.TabIndex = 6;
            // 
            // PanelDown
            // 
            PanelDown.BackColor = SystemColors.ButtonShadow;
            PanelDown.Location = new Point(12, 616);
            PanelDown.Name = "PanelDown";
            PanelDown.Size = new Size(1414, 15);
            PanelDown.TabIndex = 7;
            // 
            // PanelLeft
            // 
            PanelLeft.BackColor = SystemColors.ButtonShadow;
            PanelLeft.Location = new Point(12, 54);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(15, 577);
            PanelLeft.TabIndex = 7;
            // 
            // PanelRight
            // 
            PanelRight.BackColor = SystemColors.ButtonShadow;
            PanelRight.Location = new Point(1411, 54);
            PanelRight.Name = "PanelRight";
            PanelRight.Size = new Size(15, 577);
            PanelRight.TabIndex = 8;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Gainsboro;
            MenuPanel.Controls.Add(Exit);
            MenuPanel.Controls.Add(View);
            MenuPanel.Controls.Add(Settings);
            MenuPanel.Controls.Add(Restart);
            MenuPanel.Controls.Add(Resume);
            MenuPanel.Controls.Add(label1);
            MenuPanel.Location = new Point(419, 6);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(600, 604);
            MenuPanel.TabIndex = 9;
            // 
            // Exit
            // 
            Exit.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic);
            Exit.Location = new Point(69, 506);
            Exit.Name = "Exit";
            Exit.Size = new Size(462, 94);
            Exit.TabIndex = 5;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // View
            // 
            View.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic);
            View.Location = new Point(69, 406);
            View.Name = "View";
            View.Size = new Size(462, 94);
            View.TabIndex = 4;
            View.Text = "View Control";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // Settings
            // 
            Settings.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic);
            Settings.Location = new Point(69, 306);
            Settings.Name = "Settings";
            Settings.Size = new Size(462, 94);
            Settings.TabIndex = 3;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // Restart
            // 
            Restart.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Restart.Location = new Point(69, 206);
            Restart.Name = "Restart";
            Restart.Size = new Size(462, 94);
            Restart.TabIndex = 2;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // Resume
            // 
            Resume.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Resume.Location = new Point(69, 104);
            Resume.Name = "Resume";
            Resume.Size = new Size(462, 94);
            Resume.TabIndex = 1;
            Resume.Text = "Resume";
            Resume.UseVisualStyleBackColor = true;
            Resume.Click += Resume_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Courier New", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(594, 84);
            label1.TabIndex = 0;
            label1.Text = "Game Paused";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Countdown
            // 
            Countdown.AutoSize = true;
            Countdown.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Countdown.ForeColor = SystemColors.ControlLightLight;
            Countdown.Location = new Point(1068, 20);
            Countdown.Name = "Countdown";
            Countdown.Size = new Size(0, 32);
            Countdown.TabIndex = 10;
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.Gainsboro;
            SettingsPanel.Controls.Add(Back);
            SettingsPanel.Controls.Add(PaddleSize);
            SettingsPanel.Controls.Add(BallSpeed);
            SettingsPanel.Controls.Add(Difficulty);
            SettingsPanel.Controls.Add(label2);
            SettingsPanel.Location = new Point(419, 6);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(600, 604);
            SettingsPanel.TabIndex = 10;
            // 
            // Back
            // 
            Back.BackColor = Color.Gainsboro;
            Back.BackgroundImage = (Image)resources.GetObject("Back.BackgroundImage");
            Back.BackgroundImageLayout = ImageLayout.Stretch;
            Back.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Back.FlatAppearance.BorderSize = 0;
            Back.FlatAppearance.MouseOverBackColor = Color.White;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Location = new Point(524, 90);
            Back.Name = "Back";
            Back.Size = new Size(73, 59);
            Back.TabIndex = 4;
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // PaddleSize
            // 
            PaddleSize.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic);
            PaddleSize.Location = new Point(69, 431);
            PaddleSize.Name = "PaddleSize";
            PaddleSize.Size = new Size(462, 94);
            PaddleSize.TabIndex = 3;
            PaddleSize.Text = "Paddle Size";
            PaddleSize.UseVisualStyleBackColor = true;
            // 
            // BallSpeed
            // 
            BallSpeed.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BallSpeed.Location = new Point(69, 294);
            BallSpeed.Name = "BallSpeed";
            BallSpeed.Size = new Size(462, 94);
            BallSpeed.TabIndex = 2;
            BallSpeed.Text = "Ball Speed";
            BallSpeed.UseVisualStyleBackColor = true;
            // 
            // Difficulty
            // 
            Difficulty.Font = new Font("Lucida Console", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Difficulty.Location = new Point(69, 157);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(462, 94);
            Difficulty.TabIndex = 1;
            Difficulty.Text = "Difficulty";
            Difficulty.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Courier New", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(594, 84);
            label2.TabIndex = 0;
            label2.Text = "Settings";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1438, 643);
            Controls.Add(SettingsPanel);
            Controls.Add(MenuPanel);
            Controls.Add(Player);
            Controls.Add(PanelRight);
            Controls.Add(PanelLeft);
            Controls.Add(PanelDown);
            Controls.Add(PanelUp);
            Controls.Add(ComputerScore);
            Controls.Add(Menu);
            Controls.Add(PlayerScore);
            Controls.Add(Computer);
            Controls.Add(Ball);
            Controls.Add(Countdown);
            DoubleBuffered = true;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            MenuPanel.ResumeLayout(false);
            SettingsPanel.ResumeLayout(false);
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
        private Panel PanelUp;
        private Panel PanelDown;
        private Panel PanelLeft;
        private Panel PanelRight;
        private Panel MenuPanel;
        private Label label1;
        private Button Resume;
        private Button View;
        private Button Settings;
        private Button Restart;
        private Button Exit;
        private Label Countdown;
        private Panel SettingsPanel;
        private Button PaddleSize;
        private Button BallSpeed;
        private Button Difficulty;
        private Label label2;
        private Button Back;
    }
}
