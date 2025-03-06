namespace Hello_cs_code
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            button7 = new Button();
            button8 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            button10 = new Button();
            button9 = new Button();
            textBox3 = new TextBox();
            tabPage4 = new TabPage();
            button11 = new Button();
            tabPage5 = new TabPage();
            pictureBox1 = new PictureBox();
            button12 = new Button();
            tabPage6 = new TabPage();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button14 = new Button();
            button13 = new Button();
            textBox4 = new TextBox();
            tabPage7 = new TabPage();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            tabPage8 = new TabPage();
            button18 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            process1 = new System.Diagnostics.Process();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(86, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Hello C#";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(86, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(88, 134);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.Location = new Point(75, 163);
            button4.Name = "button4";
            button4.Size = new Size(100, 38);
            button4.TabIndex = 3;
            button4.Text = "Change Color";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(82, 223);
            button5.Name = "button5";
            button5.Size = new Size(83, 23);
            button5.TabIndex = 5;
            button5.Text = "Change Text";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(123, 54);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 23);
            textBox2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(43, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 274);
            panel1.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button7
            // 
            button7.Location = new Point(331, 258);
            button7.Name = "button7";
            button7.Size = new Size(107, 44);
            button7.TabIndex = 9;
            button7.Text = "Enable";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(331, 310);
            button8.Name = "button8";
            button8.Size = new Size(107, 39);
            button8.TabIndex = 10;
            button8.Text = "Disable";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(897, 414);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(889, 386);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(889, 386);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(889, 386);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Clock";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(380, 258);
            button10.Name = "button10";
            button10.Size = new Size(129, 49);
            button10.TabIndex = 2;
            button10.Text = "Stop";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(378, 203);
            button9.Name = "button9";
            button9.Size = new Size(131, 49);
            button9.TabIndex = 1;
            button9.Text = "Start";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.WindowText;
            textBox3.Font = new Font("Splash", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(6, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(877, 76);
            textBox3.TabIndex = 0;
            textBox3.Text = "12:36";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button11);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(889, 386);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Msg Box";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(360, 283);
            button11.Name = "button11";
            button11.Size = new Size(221, 53);
            button11.TabIndex = 0;
            button11.Text = "Show Message Box";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage5.Controls.Add(pictureBox1);
            tabPage5.Controls.Add(button12);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(889, 386);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Picture";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(329, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button12
            // 
            button12.Location = new Point(369, 287);
            button12.Name = "button12";
            button12.Size = new Size(160, 43);
            button12.TabIndex = 0;
            button12.Text = "Load";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBox6);
            tabPage6.Controls.Add(textBox5);
            tabPage6.Controls.Add(button14);
            tabPage6.Controls.Add(button13);
            tabPage6.Controls.Add(textBox4);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(889, 386);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Variables";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(618, 95);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(176, 23);
            textBox6.TabIndex = 4;
            textBox6.Text = "25";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(618, 124);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 23);
            textBox5.TabIndex = 3;
            textBox5.Text = "36";
            // 
            // button14
            // 
            button14.Location = new Point(615, 173);
            button14.Name = "button14";
            button14.Size = new Size(179, 44);
            button14.TabIndex = 2;
            button14.Text = "Show Sum";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Location = new Point(109, 108);
            button13.Name = "button13";
            button13.Size = new Size(179, 44);
            button13.TabIndex = 1;
            button13.Text = "Show message";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 23);
            textBox4.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(button17);
            tabPage7.Controls.Add(button16);
            tabPage7.Controls.Add(button15);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(889, 386);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "RunApp";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(282, 220);
            button17.Name = "button17";
            button17.Size = new Size(147, 36);
            button17.TabIndex = 2;
            button17.Text = "Run Paint";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(282, 158);
            button16.Name = "button16";
            button16.Size = new Size(147, 39);
            button16.TabIndex = 1;
            button16.Text = "Run NotePad";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Location = new Point(282, 96);
            button15.Name = "button15";
            button15.Size = new Size(147, 39);
            button15.TabIndex = 0;
            button15.Text = "Run Calc";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(button18);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(889, 386);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Close";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Image = (Image)resources.GetObject("button18.Image");
            button18.ImageAlign = ContentAlignment.MiddleLeft;
            button18.Location = new Point(214, 68);
            button18.Name = "button18";
            button18.Size = new Size(306, 233);
            button18.TabIndex = 0;
            button18.Text = "Exit";
            button18.TextAlign = ContentAlignment.MiddleRight;
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(927, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Hello C Sharp Programming I Love You!";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private TextBox textBox2;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Button button7;
        private Button button8;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer2;
        private Button button10;
        private Button button9;
        private TabPage tabPage4;
        private Button button11;
        private TabPage tabPage5;
        private PictureBox pictureBox1;
        private Button button12;
        private TabPage tabPage6;
        private Button button13;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button14;
        private TabPage tabPage7;
        private Button button15;
        private System.Diagnostics.Process process1;
        private Button button16;
        private Button button17;
        private TabPage tabPage8;
        private Button button18;
    }
}
