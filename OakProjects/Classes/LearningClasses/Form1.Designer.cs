namespace LearningClasses
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
            this.btnGetValues = new System.Windows.Forms.Button();
            this.btnSetValues = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetValues
            // 
            this.btnGetValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetValues.Location = new System.Drawing.Point(105, 48);
            this.btnGetValues.Name = "btnGetValues";
            this.btnGetValues.Size = new System.Drawing.Size(139, 55);
            this.btnGetValues.TabIndex = 0;
            this.btnGetValues.Text = "Get Values";
            this.btnGetValues.UseVisualStyleBackColor = true;
            // 
            // btnSetValues
            // 
            this.btnSetValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetValues.Location = new System.Drawing.Point(293, 48);
            this.btnSetValues.Name = "btnSetValues";
            this.btnSetValues.Size = new System.Drawing.Size(139, 55);
            this.btnSetValues.TabIndex = 1;
            this.btnSetValues.Text = "Set Values";
            this.btnSetValues.UseVisualStyleBackColor = true;
            this.btnSetValues.Click += new System.EventHandler(this.btnSetValues_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(105, 163);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(241, 20);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 201);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(105, 241);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(241, 20);
            this.txtAge.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(483, 48);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 55);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send Values";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnSetValues);
            this.Controls.Add(this.btnGetValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetValues;
        private System.Windows.Forms.Button btnSetValues;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSend;
    }
}

