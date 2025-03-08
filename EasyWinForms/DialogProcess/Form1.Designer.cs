namespace DialogProcess
{
    partial class Form1
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
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            textBox1 = new TextBox();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button3 = new Button();
            textBox2 = new TextBox();
            fontDialog1 = new FontDialog();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            button5 = new Button();
            textBox3 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(159, 43);
            button1.TabIndex = 0;
            button1.Text = "Change Background";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 88);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(455, 23);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(212, 88);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 2;
            button2.Text = "Folder Browser";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 138);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 4;
            button3.Text = "Font";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(351, 138);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(455, 23);
            textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(452, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(496, 348);
            button4.Name = "button4";
            button4.Size = new Size(119, 33);
            button4.TabIndex = 6;
            button4.Text = "Browse";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPG Files|*.jpg";
            // 
            // button5
            // 
            button5.Location = new Point(202, 431);
            button5.Name = "button5";
            button5.Size = new Size(109, 23);
            button5.TabIndex = 8;
            button5.Text = "Save As";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(341, 431);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(455, 23);
            textBox3.TabIndex = 7;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Txt Files|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 607);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ColorDialog colorDialog1;
        private TextBox textBox1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button3;
        private TextBox textBox2;
        private FontDialog fontDialog1;
        private PictureBox pictureBox1;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private Button button5;
        private TextBox textBox3;
        private SaveFileDialog saveFileDialog1;
    }
}
