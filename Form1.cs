
namespace Pong_Game
{ 
        using System.Windows.Forms;

    public partial class Form : System.Windows.Forms.Form
    {
        Timer pauseTimer = new Timer();

        int ballxspeed = 7;
        int ballyspeed = 7;
        int speed = 5;
        Random rand = new Random();
        bool goDown, goUp;
        int computerSpeedChange = 50; // Cooldown Tick
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 7; // Speed of the Player Paddle
        int[] i = { 5, 8, 10, 11}; // Speed of the Computer Paddle
        int[] j = {10, 13, 14, 11, 12, 15 }; // Speed of the Ball, Both X and Y

        public Form()
        {
            InitializeComponent();

            pauseTimer.Interval = 2000;
            pauseTimer.Tick += PauseTimer_Tick;

            this.KeyPreview = true;

            Menu.Location = new Point((this.ClientSize.Width - Ball.Width) / 2, 6);
            Player.Location = new Point(33, (this.ClientSize.Height - Player.Height) / 2);
            Computer.Location = new Point(1375, (this.ClientSize.Height - Computer.Height) / 2);
            Ball.Location = new Point((this.ClientSize.Width - Ball.Width) / 2, (this.ClientSize.Height - Ball.Height) / 2);
        }

        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            pauseTimer.Stop();
            GameTime.Start();
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            Ball.Top += ballyspeed;
            Ball.Left += ballxspeed;

            PlayerScore.Text = $"Player Score: {playerScore}";
            ComputerScore.Text = $"Computer Score: {computerScore}";

            if (Ball.Top < 71 || Ball.Bottom > 616) // Ball Bounce in Boundaries
            {
                ballyspeed = -ballyspeed;
            }
            if (Ball.Left < -5) // When Computer Scores
            {
                Player.Location = new Point(33, (this.ClientSize.Height - Player.Height) / 2);
                Computer.Location = new Point(1375, (this.ClientSize.Height - Computer.Height) / 2);
                Ball.Left = this.ClientSize.Width / 2;
                Ball.Top = (this.ClientSize.Height - 65) / 2;
                ballxspeed = -7;
                ballyspeed = -7;
                computerScore++;
                if (computerScore < 5)
                {
                    GameTime.Stop();
                    pauseTimer.Start();
                }
            }
            if (Ball.Right > this.ClientSize.Width + 5) // When Player Scores
            {
                Player.Location = new Point(33, (this.ClientSize.Height - Player.Height) / 2);
                Computer.Location = new Point(1375, (this.ClientSize.Height - Computer.Height) / 2);
                Ball.Left = this.ClientSize.Width / 2;
                Ball.Top = (this.ClientSize.Height - 65) / 2;
                ballxspeed = 7;
                ballyspeed = -7;
                playerScore++;
                if (playerScore < 5)
                {
                    GameTime.Stop();
                    pauseTimer.Start();
                }
            }
            if (Computer.Top <= 71) // Ensures the Computer Paddle doesn't go out of bounds when on top
            {
                Computer.Top = 71;
            }
            else if (Computer.Bottom >= 616) // Ensures the Computer Paddle doesn't go out of bounds when on bellow
            {
                Computer.Top = 616 - Computer.Height;
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

            if (goDown && Player.Top + Player.Height < 616) // Player Movement Down
            {
               Player.Top += playerSpeed;   
            }

            if (goUp && Player.Top > 71) // Player Movement Up
            {
                Player.Top -= playerSpeed;
            }

            CheckCollision(Ball, Player, Player.Right + 5);
            CheckCollision(Ball, Computer, Computer.Left - 35);

            if (computerScore > 5)
            {
                GameOver("You Lost the game bruh.");
            }
            else if (playerScore > 5)
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
            ballxspeed = ballyspeed = 4;
            computerSpeedChange = 50;
            GameTime.Start();
        }
    }
}
