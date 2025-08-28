namespace DiaryProject.otherForms
{
    partial class AboutUs
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesignerName = new System.Windows.Forms.Label();
            this.lblProgammerName = new System.Windows.Forms.Label();
            this.lblCopyrightYear = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(111, 60);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(285, 38);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Absolute Enterprises";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(85, 126);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(311, 38);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name: Diary App Project";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(85, 164);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(311, 26);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: 1.1.10.3";
            // 
            // lblDesignerName
            // 
            this.lblDesignerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignerName.Location = new System.Drawing.Point(85, 203);
            this.lblDesignerName.Name = "lblDesignerName";
            this.lblDesignerName.Size = new System.Drawing.Size(311, 26);
            this.lblDesignerName.TabIndex = 3;
            this.lblDesignerName.Text = "Designer: Grey Liaisons";
            // 
            // lblProgammerName
            // 
            this.lblProgammerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgammerName.Location = new System.Drawing.Point(85, 243);
            this.lblProgammerName.Name = "lblProgammerName";
            this.lblProgammerName.Size = new System.Drawing.Size(311, 26);
            this.lblProgammerName.TabIndex = 4;
            this.lblProgammerName.Text = "Programmer: Pillow Talk";
            // 
            // lblCopyrightYear
            // 
            this.lblCopyrightYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrightYear.Location = new System.Drawing.Point(215, 388);
            this.lblCopyrightYear.Name = "lblCopyrightYear";
            this.lblCopyrightYear.Size = new System.Drawing.Size(47, 21);
            this.lblCopyrightYear.TabIndex = 5;
            this.lblCopyrightYear.Text = "2025";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(164, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "All Rights Reserved";
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCopyrightYear);
            this.Controls.Add(this.lblProgammerName);
            this.Controls.Add(this.lblDesignerName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abuot Us";
            this.Load += new System.EventHandler(this.AboutUs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesignerName;
        private System.Windows.Forms.Label lblProgammerName;
        private System.Windows.Forms.Label lblCopyrightYear;
        private System.Windows.Forms.Label label7;
    }
}