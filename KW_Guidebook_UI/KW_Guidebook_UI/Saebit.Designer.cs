namespace KW_Guidebook_UI
{
    partial class Saebit
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
            this.saebit_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saebit_label
            // 
            this.saebit_label.AutoSize = true;
            this.saebit_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.saebit_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.saebit_label.Location = new System.Drawing.Point(520, 20);
            this.saebit_label.Name = "saebit_label";
            this.saebit_label.Size = new System.Drawing.Size(285, 106);
            this.saebit_label.TabIndex = 0;
            this.saebit_label.Text = "새빛관";
            this.saebit_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Saebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1284, 858);
            this.Controls.Add(this.saebit_label);
            this.Name = "Saebit";
            this.Text = "Saebit_Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saebit_label;
    }
}