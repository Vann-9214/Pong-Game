namespace Pong_Game
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form : System.Windows.Forms.Form
    {
        Timer ResumeTimer = new Timer();
        Timer PauseTimer = new Timer();
        int countdownresume = 3;
        int ballxspeed = 8;
        int ballyspeed = 8;
        int speed = 6; // initial speed of the computer paddle
        Random rand = new Random();
        bool goDown, goUp;
        int computerSpeedChange = 50; // Cooldown Tick
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 7; // Speed of the Player Paddle
        int[] i = { 6, 8, 10, 11 }; // Speed of the Computer Paddle
        int[] j = { 11, 14, 15, 12, 13, 16 }; // Speed of the Ball, Both X and Y

        public Form()
        {
            InitializeComponent();
            MenuPanel.Visible = false;
            SettingsPanel.Visible = false;
            PauseTimer.Interval = 2000; // Seconds of interval
            ResumeTimer.Interval = 1000;
            PauseTimer.Tick += PauseTimer_Tick;
            ResumeTimer.Tick += ResumeTimer_Tick;
            this.KeyPreview = true;

            Countdown.Location = new Point(((this.ClientSize.Width - Countdown.Width) / 2) - 90, (this.ClientSize.Height - Countdown.Height) / 2);
            Menu.Location = new Point((this.ClientSize.Width - Ball.Width) / 2, 6);
            Player.Location = new Point((PanelLeft.Left + 19), (this.ClientSize.Height - Player.Height) / 2);
            Computer.Location = new Point((PanelRight.Left - 27), (this.ClientSize.Height - Computer.Height) / 2);
            Ball.Location = new Point((this.ClientSize.Width - Ball.Width) / 2, (this.ClientSize.Height - Ball.Height) / 2);
        }
        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            PauseTimer.Stop();
            GameTime.Start();
        }
        private void ResumeTimer_Tick(object sender, EventArgs e)
        {
            if (countdownresume > 1)
            {
                countdownresume--;
                Countdown.Text = $"Game Resumes in {countdownresume}";

            }
            else
            {
                Countdown.Text = "";
                ResumeTimer.Stop();
                GameTime.Start();
            }
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            Ball.Top += ballyspeed;
            Ball.Left += ballxspeed;

            if (Ball.Top < PanelUp.Bottom || Ball.Bottom > PanelDown.Top) // Ball Bounce in Boundaries
            {
                ballyspeed = -ballyspeed;
            }
            if (Ball.Left < -5) // When Computer Scores
            {
                Player.Location = new Point((PanelLeft.Left + 19), (this.ClientSize.Height - Player.Height) / 2);
                Computer.Location = new Point((PanelRight.Left - 27), (this.ClientSize.Height - Computer.Height) / 2);
                Ball.Left = this.ClientSize.Width / 2;
                Ball.Top = (this.ClientSize.Height - 65) / 2;
                ballxspeed = -7;
                ballyspeed = -7;
                computerScore++;
                ComputerScore.Text = $"Computer Score: {computerScore}";
                if (computerScore < 5)
                {
                    GameTime.Stop();
                    PauseTimer.Start();
                }
            }
            if (Ball.Right > this.ClientSize.Width + 5) // When Player Scores
            {
                Player.Location = new Point((PanelLeft.Left + 19), (this.ClientSize.Height - Player.Height) / 2);
                Computer.Location = new Point((PanelRight.Left - 27), (this.ClientSize.Height - Computer.Height) / 2);
                Ball.Left = this.ClientSize.Width / 2;
                Ball.Top = (this.ClientSize.Height - 65) / 2;
                ballxspeed = 7;
                ballyspeed = -7;
                playerScore++;
                PlayerScore.Text = $"Player Score: {playerScore}";
                if (playerScore < 5)
                {
                    GameTime.Stop();
                    PauseTimer.Start();
                }
            }
            if (Computer.Top <= PanelUp.Bottom) // Ensures the Computer Paddle doesn't go out of bounds when on top
            {
                Computer.Top = PanelUp.Bottom;
            }
            else if (Computer.Bottom >= PanelDown.Top) // Ensures the Computer Paddle doesn't go out of bounds when on bellow
            {
                Computer.Top = PanelDown.Top - Computer.Height;
            }

            if (Ball.Top < Computer.Top + (Computer.Height / 2) && Ball.Left > (this.ClientSize.Width - Ball.Width) / 2) // Computer Movement Up
            {
                Computer.Top -= speed;
            }
            if (Ball.Top > Computer.Top + (Computer.Height / 2) && Ball.Left > (this.ClientSize.Width - Ball.Width) / 2) // Computer Movement Down
            {
                Computer.Top += speed;
            }
            computerSpeedChange -= 1;

            if (computerSpeedChange < 0) // Cooldown for when the computer can change speed
            {
                speed = i[rand.Next(i.Length)];
                computerSpeedChange = 50;
            }

            if (goDown && Player.Top + Player.Height < PanelDown.Top - 6) // Player Movement Down
            {
                Player.Top += playerSpeed;
            }

            if (goUp && Player.Top > PanelUp.Bottom + 3) // Player Movement Up
            {
                Player.Top -= playerSpeed;
            }

            CheckCollision(Ball, Player, Player.Right + 5);
            CheckCollision(Ball, Computer, Computer.Left - 35);

            if (computerScore == 5)
            {
                GameOver("You Lost the game bruh.");
            }
            else if (playerScore == 5)
            {
                GameOver("You won the game bruh.");
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
        }
        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];

                if (ballxspeed < 0)
                {
                    ballxspeed = x;
                }
                else
                {
                    ballxspeed = -x;
                }

                if (ballyspeed < 0)
                {
                    ballyspeed = -y;
                }
                else
                {
                    ballyspeed = y;
                }
            }
        }
        private void GameOver(string Message)
        {
            GameTime.Stop();
            MessageBox.Show(Message, "Moo Says: ");
            computerScore = 0;
            playerScore = 0;
            ballxspeed = ballyspeed = 8;
            computerSpeedChange = 50;
            GameTime.Start();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            Countdown.Visible = false;
            MenuPanel.Visible = true;
            GameTime.Stop();
            ResumeTimer.Stop();
            PauseTimer.Stop();
        }
        private void Resume_Click(object sender, EventArgs e)
        {          
            countdownresume = 3;
            Countdown.Visible = true;
            Countdown.Text = $"Game Resumes in {countdownresume}";
            ResumeTimer.Start();
            MenuPanel.Visible = false;
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            PauseTimer.Stop();
            ResumeTimer.Stop();
            computerScore = 0;
            playerScore = 0;
            PlayerScore.Text = $"Player Score: {playerScore}";
            ComputerScore.Text = $"Computer Score: {computerScore}";
            Player.Location = new Point((PanelLeft.Left + 19), (this.ClientSize.Height - Player.Height) / 2);
            Computer.Location = new Point((PanelRight.Left - 27), (this.ClientSize.Height - Computer.Height) / 2);
            Ball.Location = new Point((this.ClientSize.Width - Ball.Width) / 2, (this.ClientSize.Height - Ball.Height) / 2);
            ballxspeed = ballyspeed = 8;
            computerSpeedChange = 50;
            PauseTimer.Start();
            MenuPanel.Visible = false;
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            MenuPanel.Visible = false;
        }
        private void View_Click(object sender, EventArgs e)
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            MenuPanel.Visible = true;
        }
    }
}