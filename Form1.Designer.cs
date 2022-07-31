namespace btech_app1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlusNumber = new System.Windows.Forms.Button();
            this.btnMinusNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlusNumber
            // 
            this.btnPlusNumber.Font = new System.Drawing.Font("Leelawadee", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlusNumber.Location = new System.Drawing.Point(34, 197);
            this.btnPlusNumber.Name = "btnPlusNumber";
            this.btnPlusNumber.Size = new System.Drawing.Size(75, 58);
            this.btnPlusNumber.TabIndex = 2;
            this.btnPlusNumber.Text = "+";
            this.btnPlusNumber.UseVisualStyleBackColor = true;
            this.btnPlusNumber.Click += new System.EventHandler(this.btnPlusNumber_Click);
            // 
            // btnMinusNumber
            // 
            this.btnMinusNumber.Font = new System.Drawing.Font("Leelawadee", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinusNumber.Location = new System.Drawing.Point(115, 197);
            this.btnMinusNumber.Name = "btnMinusNumber";
            this.btnMinusNumber.Size = new System.Drawing.Size(75, 58);
            this.btnMinusNumber.TabIndex = 2;
            this.btnMinusNumber.Text = "-";
            this.btnMinusNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 329);
            this.Controls.Add(this.btnMinusNumber);
            this.Controls.Add(this.btnPlusNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button btnPlusNumber;
        private Button btnMinusNumber;
    }
}