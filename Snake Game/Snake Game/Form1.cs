using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        // ================= GRID SETTINGS =================
        private const int CELL_SIZE = 20;
        private const int MIN_GRID = 20;

        private int gridWidth;
        private int gridHeight;

        // ================= GAME DATA =================
        private List<Rectangle> snake;
        private Rectangle food;
        private int direction; 
        private int score;
        private int highestScore = 0;
        private bool isPaused = false;
        private Random random = new Random();

        // ================= CONSTRUCTOR =================
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            timer1.Stop();
            ResetToStartScreen();
        }

        // ================= START SCREEN =================
        private void ResetToStartScreen()
        {
            snake = null;
            isPaused = false;
            timer1.Stop();

            btnStart.Visible = true;
            lblstartheading.Visible = true;
            lblInstructions.Visible = true;

            lblInstructions.Text =
                "🎮 HOW TO PLAY\n\n" +
                "➡ Use Arrow Keys to move the snake\n" +
                "🍎 Eat food to gain points\n" +
                "💥 Avoid walls and yourself\n" +
                "⏸ Pause / Resume anytime\n\n" +
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

        // ================= DIFFICULTY =================
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

        // ================= GAME INIT =================
        private void InitializeGame()
        {
            gridWidth = Math.Max(MIN_GRID, pnlCanvas.Width / CELL_SIZE);
            gridHeight = Math.Max(MIN_GRID, pnlCanvas.Height / CELL_SIZE);

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
            this.ActiveControl = null;
            this.Focus();
            timer1.Start();
        }

        // ================= FOOD GENERATION =================
        private void GenerateFood()
        {
            Rectangle newFood;
            bool collision;

            do
            {
                collision = false;
                newFood = new Rectangle(
                    random.Next(0, gridWidth) * CELL_SIZE,
                    random.Next(0, gridHeight) * CELL_SIZE,
                    CELL_SIZE,
                    CELL_SIZE
                );

                foreach (Rectangle part in snake)
                {
                    if (newFood.IntersectsWith(part))
                    {
                        collision = true;
                        break;
                    }
                }

            } while (collision);

            food = newFood;
            pnlCanvas.Invalidate();
        }

        // ================= KEYBOARD INPUT =================
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

        // ================= GAME LOOP =================
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            pnlCanvas.Invalidate();
        }

        private void MoveSnake()
        {
            Rectangle head = snake[0];

            switch (direction)
            {
                case 0: head.X += CELL_SIZE; break;
                case 1: head.Y += CELL_SIZE; break;
                case 2: head.X -= CELL_SIZE; break;
                case 3: head.Y -= CELL_SIZE; break;
            }

            snake.Insert(0, head);

            if (head.IntersectsWith(food))
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

        // ================= GAME OVER =================
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

        // ================= PAUSE / RESUME =================
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

        // ================= RESTART =================
        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetToStartScreen();
        }

        // ================= DRAWING =================
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (snake == null) return;

            Graphics g = e.Graphics;

            // Draw grid
            for (int x = 0; x <= gridWidth; x++)
                g.DrawLine(Pens.LightGray, x * CELL_SIZE, 0, x * CELL_SIZE, gridHeight * CELL_SIZE);
            for (int y = 0; y <= gridHeight; y++)
                g.DrawLine(Pens.LightGray, 0, y * CELL_SIZE, gridWidth * CELL_SIZE, y * CELL_SIZE);

            // Draw snake
            foreach (Rectangle part in snake)
                g.FillRectangle(Brushes.Green, part);

            // Draw food
            g.FillRectangle(Brushes.Red, food);
        }

        // ===== EMPTY EVENTS (DESIGNER SAFE) =====
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
