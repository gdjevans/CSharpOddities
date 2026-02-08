namespace MainOperators
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 20.25F, FontStyle.Bold);
            button1.Location = new Point(252, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "First No:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 55);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Second No:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 114);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Font = new Font("Rockwell", 20.25F, FontStyle.Bold);
            button2.Location = new Point(333, 163);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 7;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Rockwell", 20.25F, FontStyle.Bold);
            button3.Location = new Point(414, 163);
            button3.Name = "button3";
            button3.Size = new Size(75, 50);
            button3.TabIndex = 8;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Rockwell", 20.25F, FontStyle.Bold);
            button4.Location = new Point(495, 163);
            button4.Name = "button4";
            button4.Size = new Size(75, 50);
            button4.TabIndex = 9;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(333, 296);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 23);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 296);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 12;
            label4.Text = "Second No:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(333, 267);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(208, 23);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 267);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "First No:";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(343, 342);
            button5.Name = "button5";
            button5.Size = new Size(186, 31);
            button5.TabIndex = 14;
            button5.Text = "Is First Num Greater";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button button5;
    }
}
