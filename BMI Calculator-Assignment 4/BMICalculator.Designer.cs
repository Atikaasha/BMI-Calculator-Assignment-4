namespace BMI_Calculator_Assignment_4
{
    partial class BMICalculator
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
            this.metricButton = new System.Windows.Forms.RadioButton();
            this.imperialButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // metricButton
            // 
            this.metricButton.AutoSize = true;
            this.metricButton.Location = new System.Drawing.Point(15, 13);
            this.metricButton.Name = "metricButton";
            this.metricButton.Size = new System.Drawing.Size(106, 35);
            this.metricButton.TabIndex = 0;
            this.metricButton.TabStop = true;
            this.metricButton.Text = "Metric";
            this.metricButton.UseVisualStyleBackColor = true;
            // 
            // imperialButton
            // 
            this.imperialButton.AutoSize = true;
            this.imperialButton.Location = new System.Drawing.Point(164, 13);
            this.imperialButton.Name = "imperialButton";
            this.imperialButton.Size = new System.Drawing.Size(128, 35);
            this.imperialButton.TabIndex = 1;
            this.imperialButton.TabStop = true;
            this.imperialButton.Text = "Imperial";
            this.imperialButton.UseVisualStyleBackColor = true;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.imperialButton);
            this.Controls.Add(this.metricButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton metricButton;
        private System.Windows.Forms.RadioButton imperialButton;
    }
}

