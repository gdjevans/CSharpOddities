namespace PongGame
{
    partial class frmPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPong));
            picPlayer = new PictureBox();
            picComputer = new PictureBox();
            picDivider = new PictureBox();
            picBall = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picComputer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDivider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // picPlayer
            // 
            picPlayer.BackColor = Color.IndianRed;
            picPlayer.Location = new Point(136, 84);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(15, 66);
            picPlayer.TabIndex = 0;
            picPlayer.TabStop = false;
            // 
            // picComputer
            // 
            picComputer.BackColor = Color.MediumTurquoise;
            picComputer.Location = new Point(179, 84);
            picComputer.Name = "picComputer";
            picComputer.Size = new Size(15, 66);
            picComputer.TabIndex = 1;
            picComputer.TabStop = false;
            // 
            // picDivider
            // 
            picDivider.BackColor = Color.White;
            picDivider.Location = new Point(261, 55);
            picDivider.Name = "picDivider";
            picDivider.Size = new Size(10, 136);
            picDivider.TabIndex = 2;
            picDivider.TabStop = false;
            // 
            // picBall
            // 
            picBall.Image = (Image)resources.GetObject("picBall.Image");
            picBall.Location = new Point(293, 243);
            picBall.Name = "picBall";
            picBall.Size = new Size(30, 30);
            picBall.TabIndex = 3;
            picBall.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // frmPong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(picBall);
            Controls.Add(picComputer);
            Controls.Add(picPlayer);
            Controls.Add(picDivider);
            Name = "frmPong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmPong_Load;
            KeyDown += Pong_KeyDown;
            KeyUp += Pong_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picComputer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDivider).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picPlayer;
        private PictureBox picComputer;
        private PictureBox picDivider;
        private PictureBox picBall;
        private System.Windows.Forms.Timer timer;
    }
}
