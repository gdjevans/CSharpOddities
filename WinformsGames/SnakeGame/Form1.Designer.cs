namespace SnakeGame
{
    partial class frmSnake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            picGameBoard = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            imgList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picGameBoard).BeginInit();
            SuspendLayout();
            // 
            // picGameBoard
            // 
            picGameBoard.Location = new Point(16, 16);
            picGameBoard.Name = "picGameBoard";
            picGameBoard.Size = new Size(420, 420);
            picGameBoard.TabIndex = 0;
            picGameBoard.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            // 
            // imgList
            // 
            imgList.ColorDepth = ColorDepth.Depth8Bit;
            imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
            imgList.TransparentColor = Color.Transparent;
            imgList.Images.SetKeyName(0, "bonus1.png");
            imgList.Images.SetKeyName(1, "bonus2.png");
            imgList.Images.SetKeyName(2, "bonus3.png");
            imgList.Images.SetKeyName(3, "bonus4.png");
            imgList.Images.SetKeyName(4, "snake_body.png");
            imgList.Images.SetKeyName(5, "snake_head.png");
            imgList.Images.SetKeyName(6, "wall.png");
            // 
            // frmSnake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 450);
            Controls.Add(picGameBoard);
            Name = "frmSnake";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmSnake_Load;
            KeyDown += frmSnake_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picGameBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGameBoard;
        private System.Windows.Forms.Timer timer;
        private ImageList imgList;
    }
}
