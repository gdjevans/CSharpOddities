namespace IOInfo_prog
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
            id_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            fname_Textbox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(147, 175);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 0;
            button1.Text = "Save Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // id_textBox
            // 
            id_textBox.Location = new Point(213, 68);
            id_textBox.Name = "id_textBox";
            id_textBox.Size = new Size(233, 23);
            id_textBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 71);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 112);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Full Name:";
            // 
            // fname_Textbox
            // 
            fname_Textbox.Location = new Point(213, 109);
            fname_Textbox.Name = "fname_Textbox";
            fname_Textbox.Size = new Size(233, 23);
            fname_Textbox.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(482, 68);
            button2.Name = "button2";
            button2.Size = new Size(111, 39);
            button2.TabIndex = 5;
            button2.Text = "Load Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(fname_Textbox);
            Controls.Add(label1);
            Controls.Add(id_textBox);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox id_textBox;
        private Label label1;
        private Label label2;
        private TextBox fname_Textbox;
        private Button button2;
    }
}
