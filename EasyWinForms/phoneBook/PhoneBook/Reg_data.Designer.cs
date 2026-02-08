namespace PhoneBook
{
    partial class Reg_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_data));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Info_group = new System.Windows.Forms.GroupBox();
            this.Comment_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Address_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cell_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tel_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LN_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FN_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Info_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_btn,
            this.Save_btn,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 56);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // New_btn
            // 
            this.New_btn.Image = ((System.Drawing.Image)(resources.GetObject("New_btn.Image")));
            this.New_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.New_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(83, 53);
            this.New_btn.Text = "New";
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Enabled = false;
            this.Save_btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.Image")));
            this.Save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(83, 53);
            this.Save_btn.Text = "Save";
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // Info_group
            // 
            this.Info_group.Controls.Add(this.Comment_txtbox);
            this.Info_group.Controls.Add(this.label7);
            this.Info_group.Controls.Add(this.Address_txtbox);
            this.Info_group.Controls.Add(this.label8);
            this.Info_group.Controls.Add(this.email_txtbox);
            this.Info_group.Controls.Add(this.label6);
            this.Info_group.Controls.Add(this.cell_txtbox);
            this.Info_group.Controls.Add(this.label5);
            this.Info_group.Controls.Add(this.Tel_txtbox);
            this.Info_group.Controls.Add(this.label4);
            this.Info_group.Controls.Add(this.LN_txtbox);
            this.Info_group.Controls.Add(this.label3);
            this.Info_group.Controls.Add(this.FN_txtbox);
            this.Info_group.Controls.Add(this.label2);
            this.Info_group.Controls.Add(this.ID_txtbox);
            this.Info_group.Controls.Add(this.label1);
            this.Info_group.Location = new System.Drawing.Point(24, 77);
            this.Info_group.Name = "Info_group";
            this.Info_group.Size = new System.Drawing.Size(490, 384);
            this.Info_group.TabIndex = 1;
            this.Info_group.TabStop = false;
            this.Info_group.Text = "Information";
            // 
            // Comment_txtbox
            // 
            this.Comment_txtbox.Location = new System.Drawing.Point(157, 261);
            this.Comment_txtbox.Name = "Comment_txtbox";
            this.Comment_txtbox.Size = new System.Drawing.Size(271, 20);
            this.Comment_txtbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comment:";
            // 
            // Address_txtbox
            // 
            this.Address_txtbox.Location = new System.Drawing.Point(157, 235);
            this.Address_txtbox.Name = "Address_txtbox";
            this.Address_txtbox.Size = new System.Drawing.Size(271, 20);
            this.Address_txtbox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address:";
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(157, 209);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(271, 20);
            this.email_txtbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // cell_txtbox
            // 
            this.cell_txtbox.Location = new System.Drawing.Point(157, 183);
            this.cell_txtbox.Name = "cell_txtbox";
            this.cell_txtbox.Size = new System.Drawing.Size(271, 20);
            this.cell_txtbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mob. Number:";
            // 
            // Tel_txtbox
            // 
            this.Tel_txtbox.Location = new System.Drawing.Point(157, 157);
            this.Tel_txtbox.Name = "Tel_txtbox";
            this.Tel_txtbox.Size = new System.Drawing.Size(271, 20);
            this.Tel_txtbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone:";
            // 
            // LN_txtbox
            // 
            this.LN_txtbox.Location = new System.Drawing.Point(157, 131);
            this.LN_txtbox.Name = "LN_txtbox";
            this.LN_txtbox.Size = new System.Drawing.Size(271, 20);
            this.LN_txtbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // FN_txtbox
            // 
            this.FN_txtbox.Location = new System.Drawing.Point(157, 105);
            this.FN_txtbox.Name = "FN_txtbox";
            this.FN_txtbox.Size = new System.Drawing.Size(271, 20);
            this.FN_txtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.Location = new System.Drawing.Point(157, 79);
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.Size = new System.Drawing.Size(271, 20);
            this.ID_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Reg_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(526, 473);
            this.Controls.Add(this.Info_group);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Reg_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Data";
            this.Load += new System.EventHandler(this.Reg_data_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Info_group.ResumeLayout(false);
            this.Info_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton New_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox Info_group;
        private System.Windows.Forms.TextBox Comment_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Address_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cell_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tel_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LN_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FN_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_txtbox;
        private System.Windows.Forms.Label label1;
    }
}