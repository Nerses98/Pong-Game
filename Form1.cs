using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace New_Pong
{
    public partial class Form1 : Form
    {
        PlayerRect player1 = new PlayerRect();
        PlayerRect player2 = new PlayerRect();
        Circle ball = new Circle();
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public Form1()
        {
            InitializeComponent();
            new Settings();
            GameTimer.Interval = 1;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();
            StartGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGame()
        {               
            new Settings();
            player1.X = (gamefield.Width / 2);
            player1.Y = ((gamefield.Height))-15;
            player2.X = (gamefield.Width / 2);
            player2.Y = 1;
            ball.X = (gamefield.Width/2);
            ball.Y =(gamefield.Height/2);
        }

        private void UpdateScreen(object sender, EventArgs e)
        {                      
                if (Input.KeyPressed(Keys.Space))
                {
                    StartGame();
                }         
                ball.X+=Settings.ballvelX;
                ball.Y+=Settings.ballvelY;          
                if (Input.KeyPressed(Keys.Right))
                {
                    Settings.direction = Direction.Right;
                    player1.X+=Settings.playervelX;
                }
                if (Input.KeyPressed(Keys.Left))
                {
                    Settings.direction = Direction.Left;
                    player1.X-=Settings.playervelX;
                }
                if (Input.KeyPressed(Keys.D))
                {
                    Settings.direction = Direction.Right;
                    player2.X+=Settings.playervelX;
                }
                if (Input.KeyPressed(Keys.A))
                {
                    Settings.direction = Direction.Left;
                    player2.X-=Settings.playervelX;
                }
                        
            CheckInteraction();
            gamefield.Invalidate();
        }

        private void CheckInteraction()
        {
            if (player1.X + Settings.RectWidth >= gamefield.Width)
                player1.X = gamefield.Width - Settings.RectWidth;
            if (player1.X <= 0)
                player1.X = 0;
            if (player2.X + Settings.RectWidth >= gamefield.Width)
                player2.X = gamefield.Width - Settings.RectWidth;
            if (player2.X <= 0)
                player2.X = 0;

            if (ball.X+Settings.CircleWidth > gamefield.Width || ball.X <= 0)
                Settings.ballvelX*=-1;
            if (ball.Y > gamefield.Height)
            {
                Player2Score++;
                p2score.Text = Player2Score.ToString();
                StartGame();
            }
            if (ball.Y <= 0)
            {
                Player1Score++;
                p1score.Text = Player1Score.ToString();
                StartGame();
            }
            if (ball.X+Settings.CircleWidth > player1.X && ball.X < player1.X+Settings.RectWidth && ball.Y +Settings.CircleHeight > player1.Y)
               Settings.ballvelY*=-1;
           if (ball.X + Settings.CircleWidth > player2.X && ball.X < player2.X + Settings.RectWidth && ball.Y < player2.Y+Settings.RectHeight)
              Settings.ballvelY *= -1;
        }

      
        private void gamefield_Paint(object sender, PaintEventArgs e)
        {
            Graphics fieldpaint = e.Graphics;
            //if (!Settings.GameOver)
           // {
                fieldpaint.FillEllipse(Brushes.Black, new Rectangle(ball.X, ball.Y, Settings.CircleWidth, Settings.CircleHeight));
                fieldpaint.FillRectangle(Brushes.Red, new Rectangle(player1.X, player1.Y, Settings.RectWidth, Settings.RectHeight));
                fieldpaint.FillRectangle(Brushes.Blue, new Rectangle(player2.X, player2.Y , Settings.RectWidth, Settings.RectHeight));

          //  }
      
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}
