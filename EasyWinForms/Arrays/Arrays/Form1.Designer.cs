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
            this.listBox1.Location = new System.Drawing.Point(41, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 324);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(519, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

