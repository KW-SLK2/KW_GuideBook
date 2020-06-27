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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chambit));
            this.chambit_label = new System.Windows.Forms.Label();
            this.Chambit_Map = new System.Windows.Forms.PictureBox();
            this.information_btn = new System.Windows.Forms.Button();
            this.lab_btn = new System.Windows.Forms.Button();
            this.KWImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chambit_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).BeginInit();
            this.SuspendLayout();
            // 
            // chambit_label
            // 
            this.chambit_label.AutoSize = true;
            this.chambit_label.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chambit_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.chambit_label.Location = new System.Drawing.Point(497, 31);
            this.chambit_label.Name = "chambit_label";
            this.chambit_label.Size = new System.Drawing.Size(338, 99);
            this.chambit_label.TabIndex = 0;
            this.chambit_label.Text = "Chambit";
            // 
            // Chambit_Map
            // 
            this.Chambit_Map.Image = ((System.Drawing.Image)(resources.GetObject("Chambit_Map.Image")));
            this.Chambit_Map.Location = new System.Drawing.Point(50, 182);
            this.Chambit_Map.Name = "Chambit_Map";
            this.Chambit_Map.Size = new System.Drawing.Size(1013, 487);
            this.Chambit_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chambit_Map.TabIndex = 12;
            this.Chambit_Map.TabStop = false;
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.information_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(1106, 584);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 11;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // lab_btn
            // 
            this.lab_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_btn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("lab_btn.Image")));
            this.lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_btn.Location = new System.Drawing.Point(1106, 469);
            this.lab_btn.Name = "lab_btn";
            this.lab_btn.Size = new System.Drawing.Size(158, 85);
            this.lab_btn.TabIndex = 10;
            this.lab_btn.Text = "Lab";
            this.lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_btn.UseVisualStyleBackColor = false;
            this.lab_btn.Click += new System.EventHandler(this.lab_btn_Click);
            // 
            // KWImage
            // 
            this.KWImage.Image = ((System.Drawing.Image)(resources.GetObject("KWImage.Image")));
            this.KWImage.Location = new System.Drawing.Point(1143, 12);
            this.KWImage.Name = "KWImage";
            this.KWImage.Size = new System.Drawing.Size(121, 118);
            this.KWImage.TabIndex = 13;
            this.KWImage.TabStop = false;
            // 
            // Chambit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1288, 713);
            this.Controls.Add(this.KWImage);
            this.Controls.Add(this.Chambit_Map);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.lab_btn);
            this.Controls.Add(this.chambit_label);
            this.Name = "Chambit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chambit";
            this.Load += new System.EventHandler(this.Chambit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chambit_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chambit_label;
        private System.Windows.Forms.PictureBox Chambit_Map;
        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button lab_btn;
        private System.Windows.Forms.PictureBox KWImage;
    }
}