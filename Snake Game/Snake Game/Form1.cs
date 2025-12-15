using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        
        private const int CELL_SIZE = 20;
        private const int MIN_GRID = 20;

        private int gridWidth;
        private int gridHeight;

        
        private List<Rectangle> snake;
        private Rectangle food;
        private int direction; 
        private int score;
        private int highestScore = 0;
        private bool isPaused = false;
        private Random random = new Random();

        
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            EnableDoubleBuffering(pnlCanvas);
            KeyPreview = true;
            timer1.Stop();
            ResetToStartScreen();
        }
        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance
            )?.SetValue(control, true, null);
        }


        private void ResetToStartScreen()
        {
            snake = null;
            isPaused = false;
            timer1.Stop();

            btnStart.Visible = true;
            lblstartheading.Visible = true;
            lblInstructions.Visible = true;

            lblInstructions.Text =
                " HOW TO PLAY\n\n" +
                " Use Arrow Keys to move the snake\n" +
                " Eat food to gain points\n" +
                " Avoid walls and yourself\n" +
                " Pause / Resume anytime\n\n" +
                "Choose difficulty to start!";

            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;

            grpDifficultylevel.Visible = false;
            grpboxcanvas.Visible = false;

            btnPause.Enabled = false;
            btnResume.Enabled = false;
            btnRestart.Visible = false;

            lbltxtCurrentscore.Text = "0";
            lbltxtHighestScore.Text = highestScore.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            lblstartheading.Visible = false;
            lblInstructions.Visible = false;
            grpDifficultylevel.Visible = true;
        }

        
        private void btnEasy_Click(object sender, EventArgs e)
        {
            timer1.Interval = 120;
            StartGame();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            StartGame();
        }

        private void btnhard_Click(object sender, EventArgs e)
        {
            timer1.Interval = 80;
            StartGame();
        }

        private void StartGame()
        {
            grpDifficultylevel.Visible = false;
            grpboxcanvas.Visible = true;

            btnPause.Enabled = true;
            btnResume.Enabled = false;
            btnRestart.Visible = false;

            InitializeGame();
        }


        private void InitializeGame()
        {
            gridWidth = pnlCanvas.Width / CELL_SIZE;
            gridHeight = pnlCanvas.Height / CELL_SIZE;

            int startX = (gridWidth / 2) * CELL_SIZE;
            int startY = (gridHeight / 2) * CELL_SIZE;

            snake = new List<Rectangle>
    {
        new Rectangle(startX, startY, CELL_SIZE, CELL_SIZE),
        new Rectangle(startX - CELL_SIZE, startY, CELL_SIZE, CELL_SIZE),
        new Rectangle(startX - CELL_SIZE * 2, startY, CELL_SIZE, CELL_SIZE)
    };

            direction = 0;
            score = 0;
            lbltxtCurrentscore.Text = "0";

            GenerateFood();
            timer1.Start();
        }



        private void GenerateFood()
        {
            List<Point> freeCells = new List<Point>();

            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    Point p = new Point(x * CELL_SIZE, y * CELL_SIZE);
                    if (!snake.Exists(s => s.Location == p))
                        freeCells.Add(p);
                }
            }

            if (freeCells.Count == 0)
            {
                GameOver(); 
                return;
            }

            Point chosen = freeCells[random.Next(freeCells.Count)];
            food = new Rectangle(chosen.X, chosen.Y, CELL_SIZE, CELL_SIZE);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (snake == null || isPaused)
                return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                case Keys.Right:
                    if (direction != 2) direction = 0;
                    return true;
                case Keys.Down:
                    if (direction != 3) direction = 1;
                    return true;
                case Keys.Left:
                    if (direction != 0) direction = 2;
                    return true;
                case Keys.Up:
                    if (direction != 1) direction = 3;
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            pnlCanvas.Invalidate();
        }

        private void MoveSnake()
        {
            Rectangle oldHead = snake[0];

            Rectangle newHead = new Rectangle(
                oldHead.X,
                oldHead.Y,
                CELL_SIZE,
                CELL_SIZE
            );

            switch (direction)
            {
                case 0: newHead.X += CELL_SIZE; break;
                case 1: newHead.Y += CELL_SIZE; break;
                case 2: newHead.X -= CELL_SIZE; break;
                case 3: newHead.Y -= CELL_SIZE; break;
            }

            snake.Insert(0, newHead);

            if (newHead.Location == food.Location)
            {
                score += 10;
                lbltxtCurrentscore.Text = score.ToString();
                GenerateFood();   
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }


        private void CheckCollision()
        {
            Rectangle head = snake[0];

            if (head.X < 0 || head.Y < 0 ||
                head.X >= gridWidth * CELL_SIZE ||
                head.Y >= gridHeight * CELL_SIZE)
            {
                GameOver();
                return;
            }

            for (int i = 1; i < snake.Count; i++)
            {
                if (head.IntersectsWith(snake[i]))
                {
                    GameOver();
                    return;
                }
            }
        }

        
        private void GameOver()
        {
            timer1.Stop();

            if (score > highestScore)
            {
                highestScore = score;
                lbltxtHighestScore.Text = highestScore.ToString();
            }

            grpboxcanvas.Visible = false;
            btnPause.Enabled = false;
            btnResume.Enabled = false;
            btnRestart.Visible = true;
        }

        
        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;
            timer1.Stop();
            btnPause.Enabled = false;
            btnResume.Enabled = true;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            isPaused = false;
            timer1.Start();
            btnPause.Enabled = true;
            btnResume.Enabled = false;
        }

      
        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetToStartScreen();
        }

        
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (snake == null) return;

            Graphics g = e.Graphics;

            
            for (int x = 0; x <= gridWidth; x++)
                g.DrawLine(Pens.LightGray, x * CELL_SIZE, 0, x * CELL_SIZE, gridHeight * CELL_SIZE);
            for (int y = 0; y <= gridHeight; y++)
                g.DrawLine(Pens.LightGray, 0, y * CELL_SIZE, gridWidth * CELL_SIZE, y * CELL_SIZE);

            
            foreach (Rectangle part in snake)
                g.FillRectangle(Brushes.Green, part);

            
            g.FillRectangle(Brushes.Red, food);
        }

        
        private void lblSelectDifficulty_Click(object sender, EventArgs e) { }
        private void lblInstructions_Click(object sender, EventArgs e) { }
        private void grpboxcanvas_Enter(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void lblCurrentscore_Click(object sender, EventArgs e) { }
        private void txtCurrentscore_TextChanged(object sender, EventArgs e) { }
        private void lblHighestScore_Click(object sender, EventArgs e) { }
        private void txtHighestScore_TextChanged(object sender, EventArgs e) { }

        private void lbltxtCurrentscore_Click(object sender, EventArgs e)
        {

        }

        private void lbltxtHighestScore_Click(object sender, EventArgs e)
        {

        }
    }
}
