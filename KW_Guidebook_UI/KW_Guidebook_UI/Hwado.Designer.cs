namespace KW_Guidebook_UI
{
    partial class Hwado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hwado));
            this.Hwado_Map = new System.Windows.Forms.PictureBox();
            this.saebit_label = new System.Windows.Forms.Label();
            this.information_btn = new System.Windows.Forms.Button();
            this.Hwado_Lab_btn = new System.Windows.Forms.Button();
            this.KWImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hwado_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Hwado_Map
            // 
            this.Hwado_Map.Image = ((System.Drawing.Image)(resources.GetObject("Hwado_Map.Image")));
            this.Hwado_Map.Location = new System.Drawing.Point(52, 171);
            this.Hwado_Map.Name = "Hwado_Map";
            this.Hwado_Map.Size = new System.Drawing.Size(999, 488);
            this.Hwado_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hwado_Map.TabIndex = 0;
            this.Hwado_Map.TabStop = false;
            // 
            // saebit_label
            // 
            this.saebit_label.AutoSize = true;
            this.saebit_label.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saebit_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.saebit_label.Location = new System.Drawing.Point(537, 31);
            this.saebit_label.Name = "saebit_label";
            this.saebit_label.Size = new System.Drawing.Size(273, 99);
            this.saebit_label.TabIndex = 1;
            this.saebit_label.Text = "Hwado";
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.information_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(1089, 574);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 5;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Hwado_Lab_btn
            // 
            this.Hwado_Lab_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Hwado_Lab_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hwado_Lab_btn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hwado_Lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("Hwado_Lab_btn.Image")));
            this.Hwado_Lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hwado_Lab_btn.Location = new System.Drawing.Point(1089, 470);
            this.Hwado_Lab_btn.Name = "Hwado_Lab_btn";
            this.Hwado_Lab_btn.Size = new System.Drawing.Size(158, 85);
            this.Hwado_Lab_btn.TabIndex = 4;
            this.Hwado_Lab_btn.Text = "Lab";
            this.Hwado_Lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hwado_Lab_btn.UseVisualStyleBackColor = false;
            this.Hwado_Lab_btn.Click += new System.EventHandler(this.Hwado_Lab_btn_Click);
            // 
            // KWImage
            // 
            this.KWImage.Image = ((System.Drawing.Image)(resources.GetObject("KWImage.Image")));
            this.KWImage.Location = new System.Drawing.Point(1155, 12);
            this.KWImage.Name = "KWImage";
            this.KWImage.Size = new System.Drawing.Size(121, 118);
            this.KWImage.TabIndex = 11;
            this.KWImage.TabStop = false;
            // 
            // Hwado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1288, 713);
            this.Controls.Add(this.KWImage);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.Hwado_Lab_btn);
            this.Controls.Add(this.saebit_label);
            this.Controls.Add(this.Hwado_Map);
            this.Name = "Hwado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hwado";
            ((System.ComponentModel.ISupportInitialize)(this.Hwado_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hwado_Map;
        private System.Windows.Forms.Label saebit_label;
        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button Hwado_Lab_btn;
        private System.Windows.Forms.PictureBox KWImage;
    }
}