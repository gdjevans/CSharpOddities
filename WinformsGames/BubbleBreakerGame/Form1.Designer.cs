namespace BubbleBreakerGame
{
    partial class frmBubbleBreaker
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
            lblInfo = new Label();
            txtName = new TextBox();
            btnName = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(46, 37);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 15);
            lblInfo.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(357, 406);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // btnName
            // 
            btnName.Location = new Point(367, 369);
            btnName.Name = "btnName";
            btnName.Size = new Size(75, 23);
            btnName.TabIndex = 2;
            btnName.Text = "button1";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnName_Click;
            // 
            // frmBubbleBreaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnName);
            Controls.Add(txtName);
            Controls.Add(lblInfo);
            Name = "frmBubbleBreaker";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmBubbleBreaker_Load;
            Paint += Form_Paint;
            MouseDown += Form_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private TextBox txtName;
        private Button btnName;
    }
}
