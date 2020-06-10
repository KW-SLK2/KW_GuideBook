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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bima));
            this.bima_label = new System.Windows.Forms.Label();
            this.lab_btn = new System.Windows.Forms.Button();
            this.information_btn = new System.Windows.Forms.Button();
            this.Bima_Map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bima_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // bima_label
            // 
            this.bima_label.AutoSize = true;
            this.bima_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.bima_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.bima_label.Location = new System.Drawing.Point(331, 26);
            this.bima_label.Name = "bima_label";
            this.bima_label.Size = new System.Drawing.Size(285, 106);
            this.bima_label.TabIndex = 0;
            this.bima_label.Text = "비마관";
            // 
            // lab_btn
            // 
            this.lab_btn.BackColor = System.Drawing.Color.Pink;
            this.lab_btn.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("lab_btn.Image")));
            this.lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_btn.Location = new System.Drawing.Point(764, 322);
            this.lab_btn.Name = "lab_btn";
            this.lab_btn.Size = new System.Drawing.Size(158, 85);
            this.lab_btn.TabIndex = 1;
            this.lab_btn.Text = "Lab";
            this.lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_btn.UseVisualStyleBackColor = false;
            this.lab_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.Color.Pink;
            this.information_btn.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(764, 413);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 6;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Bima_Map
            // 
            this.Bima_Map.Image = ((System.Drawing.Image)(resources.GetObject("Bima_Map.Image")));
            this.Bima_Map.Location = new System.Drawing.Point(66, 201);
            this.Bima_Map.Name = "Bima_Map";
            this.Bima_Map.Size = new System.Drawing.Size(636, 297);
            this.Bima_Map.TabIndex = 9;
            this.Bima_Map.TabStop = false;
            this.Bima_Map.Click += new System.EventHandler(this.Bima_Map_Click);
            // 
            // Bima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(976, 572);
            this.Controls.Add(this.Bima_Map);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.lab_btn);
            this.Controls.Add(this.bima_label);
            this.Name = "Bima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bima_Information";
            this.Load += new System.EventHandler(this.Child_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bima_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bima_label;
        private System.Windows.Forms.Button lab_btn;
        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.PictureBox Bima_Map;
    }
}