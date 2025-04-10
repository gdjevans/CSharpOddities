namespace CurrencyConverter
{
    partial class currencyConvert
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
            btnConverter = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.MediumTurquoise;
            btnConverter.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnConverter.Location = new Point(12, 12);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(776, 52);
            btnConverter.TabIndex = 0;
            btnConverter.Text = "Currency Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 70);
            webView21.Name = "webView21";
            webView21.Size = new Size(776, 368);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            // 
            // currencyConvert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Controls.Add(btnConverter);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "currencyConvert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "World Currency Converter";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConverter;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
