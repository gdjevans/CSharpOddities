namespace PingPong
{
    partial class gameForm
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
            playGround = new Panel();
            racket = new PictureBox();
            ball = new PictureBox();
            score_lbl = new Label();
            points_lbl = new Label();
            gameOver_lbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)racket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // playGround
            // 
            playGround.Controls.Add(gameOver_lbl);
            playGround.Controls.Add(points_lbl);
            playGround.Controls.Add(score_lbl);
            playGround.Controls.Add(ball);
            playGround.Controls.Add(racket);
            playGround.Dock = DockStyle.Fill;
            playGround.Location = new Point(0, 0);
            playGround.Name = "playGround";
            playGround.Size = new Size(800, 450);
            playGround.TabIndex = 0;
            // 
            // racket
            // 
            racket.BackColor = Color.Black;
            racket.Location = new Point(300, 409);
            racket.Name = "racket";
            racket.Size = new Size(200, 20);
            racket.TabIndex = 0;
            racket.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Red;
            ball.Location = new Point(80, 168);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // score_lbl
            // 
            score_lbl.AutoSize = true;
            score_lbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score_lbl.Location = new Point(12, 9);
            score_lbl.Name = "score_lbl";
            score_lbl.Size = new Size(156, 65);
            score_lbl.TabIndex = 2;
            score_lbl.Text = "Score:";
            // 
            // points_lbl
            // 
            points_lbl.AutoSize = true;
            points_lbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            points_lbl.Location = new Point(164, 9);
            points_lbl.Name = "points_lbl";
            points_lbl.Size = new Size(54, 65);
            points_lbl.TabIndex = 3;
            points_lbl.Text = "0";
            // 
            // gameOver_lbl
            // 
            gameOver_lbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameOver_lbl.Location = new Point(287, 52);
            gameOver_lbl.Name = "gameOver_lbl";
            gameOver_lbl.Size = new Size(319, 273);
            gameOver_lbl.TabIndex = 4;
            gameOver_lbl.Text = "Game Over!\r\n\r\nF1 - Restart Game\r\n\r\nEsc - Exit\r\n";
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playGround);
            Name = "gameForm";
            Text = "Ping Pong Game";
            playGround.ResumeLayout(false);
            playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)racket).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel playGround;
        private PictureBox racket;
        private Label gameOver_lbl;
        private Label points_lbl;
        private Label score_lbl;
        private PictureBox ball;
        private System.Windows.Forms.Timer timer1;
    }
}
