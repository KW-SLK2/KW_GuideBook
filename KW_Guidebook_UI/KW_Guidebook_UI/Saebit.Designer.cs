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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saebit));
            this.saebit_label = new System.Windows.Forms.Label();
            this.information_btn = new System.Windows.Forms.Button();
            this.Hwado_Lab_btn = new System.Windows.Forms.Button();
            this.Saebit_Map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Saebit_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // saebit_label
            // 
            this.saebit_label.AutoSize = true;
            this.saebit_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.saebit_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.saebit_label.Location = new System.Drawing.Point(311, 44);
            this.saebit_label.Name = "saebit_label";
            this.saebit_label.Size = new System.Drawing.Size(285, 106);
            this.saebit_label.TabIndex = 0;
            this.saebit_label.Text = "새빛관";
            this.saebit_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.Color.Pink;
            this.information_btn.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(717, 437);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 7;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Hwado_Lab_btn
            // 
            this.Hwado_Lab_btn.BackColor = System.Drawing.Color.Pink;
            this.Hwado_Lab_btn.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hwado_Lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("Hwado_Lab_btn.Image")));
            this.Hwado_Lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hwado_Lab_btn.Location = new System.Drawing.Point(717, 334);
            this.Hwado_Lab_btn.Name = "Hwado_Lab_btn";
            this.Hwado_Lab_btn.Size = new System.Drawing.Size(158, 85);
            this.Hwado_Lab_btn.TabIndex = 6;
            this.Hwado_Lab_btn.Text = "Lab";
            this.Hwado_Lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hwado_Lab_btn.UseVisualStyleBackColor = false;
            this.Hwado_Lab_btn.Click += new System.EventHandler(this.Hwado_Lab_btn_Click);
            // 
            // Saebit_Map
            // 
            this.Saebit_Map.Image = ((System.Drawing.Image)(resources.GetObject("Saebit_Map.Image")));
            this.Saebit_Map.Location = new System.Drawing.Point(45, 225);
            this.Saebit_Map.Name = "Saebit_Map";
            this.Saebit_Map.Size = new System.Drawing.Size(654, 297);
            this.Saebit_Map.TabIndex = 8;
            this.Saebit_Map.TabStop = false;
            // 
            // Saebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(920, 590);
            this.Controls.Add(this.Saebit_Map);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.Hwado_Lab_btn);
            this.Controls.Add(this.saebit_label);
            this.Name = "Saebit";
            this.Text = "Saebit_Information";
            ((System.ComponentModel.ISupportInitialize)(this.Saebit_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saebit_label;
        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button Hwado_Lab_btn;
        private System.Windows.Forms.PictureBox Saebit_Map;
    }
}