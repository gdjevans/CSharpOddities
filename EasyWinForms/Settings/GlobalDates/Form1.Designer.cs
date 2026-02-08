namespace GlobalDates
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_monthName = new System.Windows.Forms.Label();
            this.txtDayNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.lblDayDate = new System.Windows.Forms.Label();
            this.lblDayName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(629, 47);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(220, 20);
            this.txt_year.TabIndex = 1;
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(629, 82);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(220, 20);
            this.txt_month.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month:";
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(629, 156);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(220, 20);
            this.txt_day.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Day:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_monthName
            // 
            this.lbl_monthName.AutoSize = true;
            this.lbl_monthName.Location = new System.Drawing.Point(871, 85);
            this.lbl_monthName.Name = "lbl_monthName";
            this.lbl_monthName.Size = new System.Drawing.Size(13, 13);
            this.lbl_monthName.TabIndex = 7;
            this.lbl_monthName.Text = "=";
            // 
            // txtDayNo
            // 
            this.txtDayNo.Location = new System.Drawing.Point(629, 117);
            this.txtDayNo.Name = "txtDayNo";
            this.txtDayNo.Size = new System.Drawing.Size(220, 20);
            this.txtDayNo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Day:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 450);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GlobalDates.Properties.Resources.calendar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDayName);
            this.panel2.Controls.Add(this.lblDayDate);
            this.panel2.Controls.Add(this.lblMonthName);
            this.panel2.Controls.Add(this.lblYear);
            this.panel2.Location = new System.Drawing.Point(8, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 284);
            this.panel2.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(39, 69);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 28);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "2019";
            // 
            // lblMonthName
            // 
            this.lblMonthName.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthName.ForeColor = System.Drawing.Color.White;
            this.lblMonthName.Location = new System.Drawing.Point(137, 69);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(101, 28);
            this.lblMonthName.TabIndex = 1;
            this.lblMonthName.Text = "December";
            this.lblMonthName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDayDate
            // 
            this.lblDayDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDayDate.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayDate.ForeColor = System.Drawing.Color.Black;
            this.lblDayDate.Location = new System.Drawing.Point(28, 110);
            this.lblDayDate.Name = "lblDayDate";
            this.lblDayDate.Size = new System.Drawing.Size(210, 76);
            this.lblDayDate.TabIndex = 2;
            this.lblDayDate.Text = "20";
            this.lblDayDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDayName
            // 
            this.lblDayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDayName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayName.ForeColor = System.Drawing.Color.Black;
            this.lblDayName.Location = new System.Drawing.Point(29, 196);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(196, 28);
            this.lblDayName.TabIndex = 3;
            this.lblDayName.Text = "Tuesday";
            this.lblDayName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDayNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_monthName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_monthName;
        private System.Windows.Forms.TextBox txtDayNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.Label lblDayName;
        private System.Windows.Forms.Label lblDayDate;
    }
}

