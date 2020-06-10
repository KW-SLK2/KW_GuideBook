namespace KW_Guidebook_UI
{
    partial class Nuri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuri));
            this.Chambit_Map = new System.Windows.Forms.PictureBox();
            this.information_btn = new System.Windows.Forms.Button();
            this.lab_btn = new System.Windows.Forms.Button();
            this.Nuri_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chambit_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // Chambit_Map
            // 
            this.Chambit_Map.Image = ((System.Drawing.Image)(resources.GetObject("Chambit_Map.Image")));
            this.Chambit_Map.Location = new System.Drawing.Point(30, 211);
            this.Chambit_Map.Name = "Chambit_Map";
            this.Chambit_Map.Size = new System.Drawing.Size(662, 297);
            this.Chambit_Map.TabIndex = 16;
            this.Chambit_Map.TabStop = false;
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.Color.Pink;
            this.information_btn.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(728, 423);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 15;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // lab_btn
            // 
            this.lab_btn.BackColor = System.Drawing.Color.Pink;
            this.lab_btn.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("lab_btn.Image")));
            this.lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_btn.Location = new System.Drawing.Point(728, 332);
            this.lab_btn.Name = "lab_btn";
            this.lab_btn.Size = new System.Drawing.Size(158, 85);
            this.lab_btn.TabIndex = 14;
            this.lab_btn.Text = "Lab";
            this.lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_btn.UseVisualStyleBackColor = false;
            this.lab_btn.Click += new System.EventHandler(this.lab_btn_Click);
            // 
            // Nuri_label
            // 
            this.Nuri_label.AutoSize = true;
            this.Nuri_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.Nuri_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Nuri_label.Location = new System.Drawing.Point(316, 24);
            this.Nuri_label.Name = "Nuri_label";
            this.Nuri_label.Size = new System.Drawing.Size(285, 106);
            this.Nuri_label.TabIndex = 13;
            this.Nuri_label.Text = "누리관";
            // 
            // Nuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(916, 533);
            this.Controls.Add(this.Chambit_Map);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.lab_btn);
            this.Controls.Add(this.Nuri_label);
            this.Name = "Nuri";
            this.Text = "Nuri";
            ((System.ComponentModel.ISupportInitialize)(this.Chambit_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Chambit_Map;
        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button lab_btn;
        private System.Windows.Forms.Label Nuri_label;
    }
}