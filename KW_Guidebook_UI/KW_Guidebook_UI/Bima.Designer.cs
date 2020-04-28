namespace KW_Guidebook_UI
{
    partial class Bima
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
            this.bima_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bima_label
            // 
            this.bima_label.AutoSize = true;
            this.bima_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.bima_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.bima_label.Location = new System.Drawing.Point(520, 20);
            this.bima_label.Name = "bima_label";
            this.bima_label.Size = new System.Drawing.Size(285, 106);
            this.bima_label.TabIndex = 0;
            this.bima_label.Text = "비마관";
            // 
            // Bima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1284, 858);
            this.Controls.Add(this.bima_label);
            this.Name = "Bima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bima_Information";
            this.Load += new System.EventHandler(this.Child_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bima_label;
    }
}