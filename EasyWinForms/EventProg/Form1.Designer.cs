namespace EventProg
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
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            listBox1 = new ListBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(341, 12);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 0;
            button1.Text = "Hey Babe!!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // button2
            // 
            button2.Location = new Point(341, 55);
            button2.Name = "button2";
            button2.Size = new Size(114, 37);
            button2.TabIndex = 1;
            button2.Text = "Save Changes (F5)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 3;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(288, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 4;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(341, 246);
            button3.Name = "button3";
            button3.Size = new Size(114, 37);
            button3.TabIndex = 5;
            button3.Text = "Events";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(516, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Auto Search";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cat", "Dog", "Horse", "Gator", "Pigeon", "Troglodite" });
            comboBox1.Location = new Point(196, 343);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(203, 388);
            button4.Name = "button4";
            button4.Size = new Size(111, 37);
            button4.TabIndex = 8;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Cat", "Rabbit", "Cabit", "Dog", "Pony", "Yoplate" });
            listBox1.Location = new Point(477, 343);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 124);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(507, 483);
            button5.Name = "button5";
            button5.Size = new Size(111, 37);
            button5.TabIndex = 10;
            button5.Text = "Show";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Button button4;
        private ListBox listBox1;
        private Button button5;
    }
}
