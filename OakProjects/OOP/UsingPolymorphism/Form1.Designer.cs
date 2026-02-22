namespace UsingPolymorphism
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnParameter = new System.Windows.Forms.Button();
            this.btn2Param = new System.Windows.Forms.Button();
            this.btn3Param = new System.Windows.Forms.Button();
            this.btn4Param = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(29, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 288);
            this.textBox1.TabIndex = 0;
            // 
            // btnParameter
            // 
            this.btnParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameter.Location = new System.Drawing.Point(321, 64);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(132, 58);
            this.btnParameter.TabIndex = 1;
            this.btnParameter.Text = "Parameter";
            this.btnParameter.UseVisualStyleBackColor = true;
            this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
            // 
            // btn2Param
            // 
            this.btn2Param.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Param.Location = new System.Drawing.Point(482, 64);
            this.btn2Param.Name = "btn2Param";
            this.btn2Param.Size = new System.Drawing.Size(132, 58);
            this.btn2Param.TabIndex = 2;
            this.btn2Param.Text = "2 Parameter";
            this.btn2Param.UseVisualStyleBackColor = true;
            this.btn2Param.Click += new System.EventHandler(this.btn2Param_Click);
            // 
            // btn3Param
            // 
            this.btn3Param.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Param.Location = new System.Drawing.Point(321, 150);
            this.btn3Param.Name = "btn3Param";
            this.btn3Param.Size = new System.Drawing.Size(132, 58);
            this.btn3Param.TabIndex = 3;
            this.btn3Param.Text = "3 Parameter";
            this.btn3Param.UseVisualStyleBackColor = true;
            this.btn3Param.Click += new System.EventHandler(this.btn3Param_Click);
            // 
            // btn4Param
            // 
            this.btn4Param.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Param.Location = new System.Drawing.Point(482, 150);
            this.btn4Param.Name = "btn4Param";
            this.btn4Param.Size = new System.Drawing.Size(132, 58);
            this.btn4Param.TabIndex = 4;
            this.btn4Param.Text = "4 Parameter";
            this.btn4Param.UseVisualStyleBackColor = true;
            this.btn4Param.Click += new System.EventHandler(this.btn4Param_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(482, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Override";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(321, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Virtual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn4Param);
            this.Controls.Add(this.btn3Param);
            this.Controls.Add(this.btn2Param);
            this.Controls.Add(this.btnParameter);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnParameter;
        private System.Windows.Forms.Button btn2Param;
        private System.Windows.Forms.Button btn3Param;
        private System.Windows.Forms.Button btn4Param;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

