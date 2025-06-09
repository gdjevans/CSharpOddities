namespace LoginForm
{
    partial class frmLoggedIn
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(79, 131);
            label1.Name = "label1";
            label1.Size = new Size(647, 58);
            label1.TabIndex = 0;
            label1.Text = "You have Logged In Successfully!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLoggedIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmLoggedIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logged In";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}