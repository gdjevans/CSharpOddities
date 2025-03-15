namespace Combo_Prog
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            index_label2 = new Label();
            button3 = new Button();
            label2 = new Label();
            itm_count_lbl = new Label();
            comboBox2 = new ComboBox();
            button4 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Platipus", "Flat Stanley", "Hedge Row" });
            comboBox1.Location = new Point(275, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(538, 50);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 57);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name: ";
            // 
            // button2
            // 
            button2.Location = new Point(275, 140);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 4;
            button2.Text = "Delete Selected";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // index_label2
            // 
            index_label2.AutoSize = true;
            index_label2.Location = new Point(440, 102);
            index_label2.Name = "index_label2";
            index_label2.Size = new Size(13, 15);
            index_label2.TabIndex = 5;
            index_label2.Text = "0";
            // 
            // button3
            // 
            button3.Location = new Point(381, 140);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 6;
            button3.Text = "Delete All";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 102);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Items Count:";
            // 
            // itm_count_lbl
            // 
            itm_count_lbl.AutoSize = true;
            itm_count_lbl.Location = new Point(242, 102);
            itm_count_lbl.Name = "itm_count_lbl";
            itm_count_lbl.Size = new Size(13, 15);
            itm_count_lbl.TabIndex = 8;
            itm_count_lbl.Text = "0";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Platipus", "Flat Stanley", "Hedge Row" });
            comboBox2.Location = new Point(275, 253);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(502, 214);
            button4.Name = "button4";
            button4.Size = new Size(100, 29);
            button4.TabIndex = 10;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 217);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 12;
            label3.Text = "Search By: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(comboBox2);
            Controls.Add(itm_count_lbl);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(index_label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Label index_label2;
        private Button button3;
        private Label label2;
        private Label itm_count_lbl;
        private ComboBox comboBox2;
        private Button button4;
        private Label label3;
        private TextBox textBox2;
    }
}
