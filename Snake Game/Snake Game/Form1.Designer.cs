
namespace Snake_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblstartheading = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lblSelectDifficulty = new System.Windows.Forms.Label();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnhard = new System.Windows.Forms.Button();
            this.grpDifficultylevel = new System.Windows.Forms.GroupBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpboxcanvas = new System.Windows.Forms.GroupBox();
            this.lbltxtHighestScore = new System.Windows.Forms.Label();
            this.lbltxtCurrentscore = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.lblCurrentscore = new System.Windows.Forms.Label();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.grpDifficultylevel.SuspendLayout();
            this.grpboxcanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.IndianRed;
            this.btnStart.Location = new System.Drawing.Point(355, 142);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 75);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblstartheading
            // 
            this.lblstartheading.AutoSize = true;
            this.lblstartheading.BackColor = System.Drawing.Color.Bisque;
            this.lblstartheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartheading.ForeColor = System.Drawing.Color.Brown;
            this.lblstartheading.Location = new System.Drawing.Point(297, 56);
            this.lblstartheading.Name = "lblstartheading";
            this.lblstartheading.Size = new System.Drawing.Size(286, 52);
            this.lblstartheading.TabIndex = 2;
            this.lblstartheading.Text = "Snake Game";
            // 
            // btnEasy
            // 
            this.btnEasy.AutoSize = true;
            this.btnEasy.BackColor = System.Drawing.Color.Bisque;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.ForeColor = System.Drawing.Color.Brown;
            this.btnEasy.Location = new System.Drawing.Point(141, 161);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(109, 60);
            this.btnEasy.TabIndex = 3;
            this.btnEasy.Text = "Easy ";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // lblSelectDifficulty
            // 
            this.lblSelectDifficulty.AutoSize = true;
            this.lblSelectDifficulty.BackColor = System.Drawing.Color.Bisque;
            this.lblSelectDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDifficulty.ForeColor = System.Drawing.Color.Brown;
            this.lblSelectDifficulty.Location = new System.Drawing.Point(132, 35);
            this.lblSelectDifficulty.Name = "lblSelectDifficulty";
            this.lblSelectDifficulty.Size = new System.Drawing.Size(367, 52);
            this.lblSelectDifficulty.TabIndex = 4;
            this.lblSelectDifficulty.Text = "Choose Difficulty";
            this.lblSelectDifficulty.Click += new System.EventHandler(this.lblSelectDifficulty_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.AutoSize = true;
            this.btnMedium.BackColor = System.Drawing.Color.Bisque;
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.ForeColor = System.Drawing.Color.Brown;
            this.btnMedium.Location = new System.Drawing.Point(300, 161);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(136, 60);
            this.btnMedium.TabIndex = 5;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnhard
            // 
            this.btnhard.BackColor = System.Drawing.Color.Bisque;
            this.btnhard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhard.ForeColor = System.Drawing.Color.Brown;
            this.btnhard.Location = new System.Drawing.Point(500, 161);
            this.btnhard.Name = "btnhard";
            this.btnhard.Size = new System.Drawing.Size(109, 60);
            this.btnhard.TabIndex = 7;
            this.btnhard.Text = "Hard";
            this.btnhard.UseVisualStyleBackColor = false;
            this.btnhard.Click += new System.EventHandler(this.btnhard_Click);
            // 
            // grpDifficultylevel
            // 
            this.grpDifficultylevel.Controls.Add(this.lblSelectDifficulty);
            this.grpDifficultylevel.Controls.Add(this.btnhard);
            this.grpDifficultylevel.Controls.Add(this.btnEasy);
            this.grpDifficultylevel.Controls.Add(this.btnMedium);
            this.grpDifficultylevel.Location = new System.Drawing.Point(96, 44);
            this.grpDifficultylevel.Name = "grpDifficultylevel";
            this.grpDifficultylevel.Size = new System.Drawing.Size(757, 540);
            this.grpDifficultylevel.TabIndex = 8;
            this.grpDifficultylevel.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.Bisque;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Brown;
            this.lblInstructions.Location = new System.Drawing.Point(127, 288);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(677, 285);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Click += new System.EventHandler(this.lblInstructions_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.BackColor = System.Drawing.Color.Bisque;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Brown;
            this.btnRestart.Location = new System.Drawing.Point(355, 223);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(153, 62);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grpboxcanvas
            // 
            this.grpboxcanvas.Controls.Add(this.lbltxtHighestScore);
            this.grpboxcanvas.Controls.Add(this.lbltxtCurrentscore);
            this.grpboxcanvas.Controls.Add(this.lblHighestScore);
            this.grpboxcanvas.Controls.Add(this.lblCurrentscore);
            this.grpboxcanvas.Controls.Add(this.pnlCanvas);
            this.grpboxcanvas.Controls.Add(this.btnResume);
            this.grpboxcanvas.Controls.Add(this.btnPause);
            this.grpboxcanvas.ForeColor = System.Drawing.Color.Brown;
            this.grpboxcanvas.Location = new System.Drawing.Point(22, 12);
            this.grpboxcanvas.Name = "grpboxcanvas";
            this.grpboxcanvas.Size = new System.Drawing.Size(911, 579);
            this.grpboxcanvas.TabIndex = 11;
            this.grpboxcanvas.TabStop = false;
            this.grpboxcanvas.Text = "canvas";
            this.grpboxcanvas.Enter += new System.EventHandler(this.grpboxcanvas_Enter);
            // 
            // lbltxtHighestScore
            // 
            this.lbltxtHighestScore.BackColor = System.Drawing.Color.Bisque;
            this.lbltxtHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtHighestScore.Location = new System.Drawing.Point(704, 382);
            this.lbltxtHighestScore.Name = "lbltxtHighestScore";
            this.lbltxtHighestScore.Size = new System.Drawing.Size(100, 23);
            this.lbltxtHighestScore.TabIndex = 8;
            this.lbltxtHighestScore.Click += new System.EventHandler(this.lbltxtHighestScore_Click);
            // 
            // lbltxtCurrentscore
            // 
            this.lbltxtCurrentscore.BackColor = System.Drawing.Color.Bisque;
            this.lbltxtCurrentscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtCurrentscore.Location = new System.Drawing.Point(704, 266);
            this.lbltxtCurrentscore.Name = "lbltxtCurrentscore";
            this.lbltxtCurrentscore.Size = new System.Drawing.Size(100, 23);
            this.lbltxtCurrentscore.TabIndex = 7;
            this.lbltxtCurrentscore.Click += new System.EventHandler(this.lbltxtCurrentscore_Click);
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.BackColor = System.Drawing.Color.Bisque;
            this.lblHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestScore.ForeColor = System.Drawing.Color.Brown;
            this.lblHighestScore.Location = new System.Drawing.Point(709, 311);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(178, 29);
            this.lblHighestScore.TabIndex = 5;
            this.lblHighestScore.Text = "Highest Score";
            this.lblHighestScore.Click += new System.EventHandler(this.lblHighestScore_Click);
            // 
            // lblCurrentscore
            // 
            this.lblCurrentscore.BackColor = System.Drawing.Color.Bisque;
            this.lblCurrentscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentscore.ForeColor = System.Drawing.Color.Brown;
            this.lblCurrentscore.Location = new System.Drawing.Point(704, 204);
            this.lblCurrentscore.Name = "lblCurrentscore";
            this.lblCurrentscore.Size = new System.Drawing.Size(189, 31);
            this.lblCurrentscore.TabIndex = 4;
            this.lblCurrentscore.Text = "Current Score";
            this.lblCurrentscore.Click += new System.EventHandler(this.lblCurrentscore_Click);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Location = new System.Drawing.Point(30, 49);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(634, 410);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // btnResume
            // 
            this.btnResume.AutoSize = true;
            this.btnResume.BackColor = System.Drawing.Color.Bisque;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.Brown;
            this.btnResume.Location = new System.Drawing.Point(704, 119);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(167, 50);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.AutoSize = true;
            this.btnPause.BackColor = System.Drawing.Color.Bisque;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Brown;
            this.btnPause.Location = new System.Drawing.Point(704, 49);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(134, 50);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(957, 596);
            this.Controls.Add(this.grpboxcanvas);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.grpDifficultylevel);
            this.Controls.Add(this.lblstartheading);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDifficultylevel.ResumeLayout(false);
            this.grpDifficultylevel.PerformLayout();
            this.grpboxcanvas.ResumeLayout(false);
            this.grpboxcanvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblstartheading;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lblSelectDifficulty;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnhard;
        private System.Windows.Forms.GroupBox grpDifficultylevel;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox grpboxcanvas;
        private System.Windows.Forms.Label lblCurrentscore;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Label lbltxtHighestScore;
        private System.Windows.Forms.Label lbltxtCurrentscore;
    }
}

