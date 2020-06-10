namespace KW_Guidebook_UI
{
    partial class Hanoul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hanoul));
            this.information_btn = new System.Windows.Forms.Button();
            this.Ginyeom_Lab_btn = new System.Windows.Forms.Button();
            this.hanoul_label = new System.Windows.Forms.Label();
            this.Ginyeom_Map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ginyeom_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.Color.Pink;
            this.information_btn.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(695, 403);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 13;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Ginyeom_Lab_btn
            // 
            this.Ginyeom_Lab_btn.BackColor = System.Drawing.Color.Pink;
            this.Ginyeom_Lab_btn.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ginyeom_Lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("Ginyeom_Lab_btn.Image")));
            this.Ginyeom_Lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ginyeom_Lab_btn.Location = new System.Drawing.Point(695, 303);
            this.Ginyeom_Lab_btn.Name = "Ginyeom_Lab_btn";
            this.Ginyeom_Lab_btn.Size = new System.Drawing.Size(158, 85);
            this.Ginyeom_Lab_btn.TabIndex = 12;
            this.Ginyeom_Lab_btn.Text = "Lab";
            this.Ginyeom_Lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ginyeom_Lab_btn.UseVisualStyleBackColor = false;
            this.Ginyeom_Lab_btn.Click += new System.EventHandler(this.Ginyeom_Lab_btn_Click);
            // 
            // hanoul_label
            // 
            this.hanoul_label.AutoSize = true;
            this.hanoul_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.hanoul_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.hanoul_label.Location = new System.Drawing.Point(313, 30);
            this.hanoul_label.Name = "hanoul_label";
            this.hanoul_label.Size = new System.Drawing.Size(285, 106);
            this.hanoul_label.TabIndex = 11;
            this.hanoul_label.Text = "한울관";
            // 
            // Ginyeom_Map
            // 
            this.Ginyeom_Map.Image = ((System.Drawing.Image)(resources.GetObject("Ginyeom_Map.Image")));
            this.Ginyeom_Map.Location = new System.Drawing.Point(28, 180);
            this.Ginyeom_Map.Name = "Ginyeom_Map";
            this.Ginyeom_Map.Size = new System.Drawing.Size(661, 308);
            this.Ginyeom_Map.TabIndex = 10;
            this.Ginyeom_Map.TabStop = false;
            // 
            // Hanoul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(880, 519);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.Ginyeom_Lab_btn);
            this.Controls.Add(this.hanoul_label);
            this.Controls.Add(this.Ginyeom_Map);
            this.Name = "Hanoul";
            this.Text = "Hanoul";
            ((System.ComponentModel.ISupportInitialize)(this.Ginyeom_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button Ginyeom_Lab_btn;
        private System.Windows.Forms.Label hanoul_label;
        private System.Windows.Forms.PictureBox Ginyeom_Map;
    }
}