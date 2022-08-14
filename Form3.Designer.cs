namespace btech_app1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.HHour = new System.Windows.Forms.Label();
            this.MMin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HHour
            // 
            this.HHour.AutoSize = true;
            this.HHour.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HHour.Location = new System.Drawing.Point(308, 180);
            this.HHour.Name = "HHour";
            this.HHour.Size = new System.Drawing.Size(62, 50);
            this.HHour.TabIndex = 0;
            this.HHour.Text = "00";
            // 
            // MMin
            // 
            this.MMin.AutoSize = true;
            this.MMin.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MMin.Location = new System.Drawing.Point(376, 180);
            this.MMin.Name = "MMin";
            this.MMin.Size = new System.Drawing.Size(62, 50);
            this.MMin.TabIndex = 1;
            this.MMin.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SSec
            // 
            this.SSec.AutoSize = true;
            this.SSec.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SSec.Location = new System.Drawing.Point(444, 180);
            this.SSec.Name = "SSec";
            this.SSec.Size = new System.Drawing.Size(62, 50);
            this.SSec.TabIndex = 2;
            this.SSec.Text = "00";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SSec);
            this.Controls.Add(this.MMin);
            this.Controls.Add(this.HHour);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HHour;
        private Label MMin;
        private System.Windows.Forms.Timer timer1;
        private Label SSec;
    }
}