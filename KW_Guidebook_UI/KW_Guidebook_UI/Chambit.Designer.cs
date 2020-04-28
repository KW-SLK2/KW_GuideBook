namespace KW_Guidebook_UI
{
    partial class Chambit
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
            this.chambit_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chambit_label
            // 
            this.chambit_label.AutoSize = true;
            this.chambit_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.chambit_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.chambit_label.Location = new System.Drawing.Point(520, 20);
            this.chambit_label.Name = "chambit_label";
            this.chambit_label.Size = new System.Drawing.Size(285, 106);
            this.chambit_label.TabIndex = 0;
            this.chambit_label.Text = "참빛관";
            // 
            // Chambit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1284, 858);
            this.Controls.Add(this.chambit_label);
            this.Name = "Chambit";
            this.Text = "Chambit_Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chambit_label;
    }
}