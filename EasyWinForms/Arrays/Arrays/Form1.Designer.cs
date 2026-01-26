namespace Arrays
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
            this.manual_btn = new System.Windows.Forms.Button();
            this.infinite_array_btn = new System.Windows.Forms.Button();
            this.limited_array_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.index_txtbox = new System.Windows.Forms.TextBox();
            this.indexRead_btn = new System.Windows.Forms.Button();
            this.indexWrite_btn = new System.Windows.Forms.Button();
            this.Size_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manual_btn
            // 
            this.manual_btn.Location = new System.Drawing.Point(41, 12);
            this.manual_btn.Name = "manual_btn";
            this.manual_btn.Size = new System.Drawing.Size(144, 44);
            this.manual_btn.TabIndex = 0;
            this.manual_btn.Text = "Add Items Manually";
            this.manual_btn.UseVisualStyleBackColor = true;
            this.manual_btn.Click += new System.EventHandler(this.manual_btn_Click);
            // 
            // infinite_array_btn
            // 
            this.infinite_array_btn.Location = new System.Drawing.Point(277, 12);
            this.infinite_array_btn.Name = "infinite_array_btn";
            this.infinite_array_btn.Size = new System.Drawing.Size(199, 44);
            this.infinite_array_btn.TabIndex = 1;
            this.infinite_array_btn.Text = "Add Items by Infinite Array";
            this.infinite_array_btn.UseVisualStyleBackColor = true;
            this.infinite_array_btn.Click += new System.EventHandler(this.infinite_array_btn_Click);
            // 
            // limited_array_btn
            // 
            this.limited_array_btn.Location = new System.Drawing.Point(277, 62);
            this.limited_array_btn.Name = "limited_array_btn";
            this.limited_array_btn.Size = new System.Drawing.Size(199, 44);
            this.limited_array_btn.TabIndex = 2;
            this.limited_array_btn.Text = "Add Items by Limited Array";
            this.limited_array_btn.UseVisualStyleBackColor = true;
            this.limited_array_btn.Click += new System.EventHandler(this.limited_array_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(44, 330);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 212);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Index:";
            // 
            // index_txtbox
            // 
            this.index_txtbox.Location = new System.Drawing.Point(117, 121);
            this.index_txtbox.Name = "index_txtbox";
            this.index_txtbox.Size = new System.Drawing.Size(100, 22);
            this.index_txtbox.TabIndex = 5;
            // 
            // indexRead_btn
            // 
            this.indexRead_btn.Location = new System.Drawing.Point(256, 110);
            this.indexRead_btn.Name = "indexRead_btn";
            this.indexRead_btn.Size = new System.Drawing.Size(75, 44);
            this.indexRead_btn.TabIndex = 6;
            this.indexRead_btn.Text = "Read";
            this.indexRead_btn.UseVisualStyleBackColor = true;
            this.indexRead_btn.Click += new System.EventHandler(this.indexRead_btn_Click);
            // 
            // indexWrite_btn
            // 
            this.indexWrite_btn.Location = new System.Drawing.Point(337, 110);
            this.indexWrite_btn.Name = "indexWrite_btn";
            this.indexWrite_btn.Size = new System.Drawing.Size(75, 44);
            this.indexWrite_btn.TabIndex = 7;
            this.indexWrite_btn.Text = "Write";
            this.indexWrite_btn.UseVisualStyleBackColor = true;
            this.indexWrite_btn.Click += new System.EventHandler(this.indexWrite_btn_Click);
            // 
            // Size_btn
            // 
            this.Size_btn.Location = new System.Drawing.Point(418, 110);
            this.Size_btn.Name = "Size_btn";
            this.Size_btn.Size = new System.Drawing.Size(75, 44);
            this.Size_btn.TabIndex = 8;
            this.Size_btn.Text = "Get Size";
            this.Size_btn.UseVisualStyleBackColor = true;
            this.Size_btn.Click += new System.EventHandler(this.Size_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Read Array by For Each";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Read Array by For Loop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sort Descending";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "Sort Ascending";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(94, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Not Sorted";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(216, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 30);
            this.button6.TabIndex = 16;
            this.button6.Text = "Copy to";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(160, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 30);
            this.button7.TabIndex = 15;
            this.button7.Text = "Max";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(112, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 30);
            this.button8.TabIndex = 14;
            this.button8.Text = "Min";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(289, 242);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 30);
            this.button9.TabIndex = 17;
            this.button9.Text = "Resize";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(362, 242);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 30);
            this.button10.TabIndex = 18;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // search_txtbox
            // 
            this.search_txtbox.Location = new System.Drawing.Point(197, 290);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(100, 22);
            this.search_txtbox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Find item:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(316, 286);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(102, 30);
            this.button11.TabIndex = 21;
            this.button11.Text = "Find the Index";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(519, 554);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Size_btn);
            this.Controls.Add(this.indexWrite_btn);
            this.Controls.Add(this.indexRead_btn);
            this.Controls.Add(this.index_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.limited_array_btn);
            this.Controls.Add(this.infinite_array_btn);
            this.Controls.Add(this.manual_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrays in C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manual_btn;
        private System.Windows.Forms.Button infinite_array_btn;
        private System.Windows.Forms.Button limited_array_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox index_txtbox;
        private System.Windows.Forms.Button indexRead_btn;
        private System.Windows.Forms.Button indexWrite_btn;
        private System.Windows.Forms.Button Size_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button11;
    }
}

