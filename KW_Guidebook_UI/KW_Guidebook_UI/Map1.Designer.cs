namespace KW_Guidebook_UI
{
    partial class Map1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map1));
            this.map_Image = new System.Windows.Forms.PictureBox();
            this.roadmap_label = new System.Windows.Forms.Label();
            this.KWImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.map_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).BeginInit();
            this.SuspendLayout();
            // 
            // map_Image
            // 
            this.map_Image.Image = ((System.Drawing.Image)(resources.GetObject("map_Image.Image")));
            this.map_Image.Location = new System.Drawing.Point(42, 156);
            this.map_Image.Name = "map_Image";
            this.map_Image.Size = new System.Drawing.Size(1179, 502);
            this.map_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map_Image.TabIndex = 0;
            this.map_Image.TabStop = false;
            // 
            // roadmap_label
            // 
            this.roadmap_label.AutoSize = true;
            this.roadmap_label.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roadmap_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.roadmap_label.Location = new System.Drawing.Point(589, 30);
            this.roadmap_label.Name = "roadmap_label";
            this.roadmap_label.Size = new System.Drawing.Size(146, 75);
            this.roadmap_label.TabIndex = 1;
            this.roadmap_label.Text = "Map";
            // 
            // KWImage
            // 
            this.KWImage.Image = ((System.Drawing.Image)(resources.GetObject("KWImage.Image")));
            this.KWImage.Location = new System.Drawing.Point(1100, 12);
            this.KWImage.Name = "KWImage";
            this.KWImage.Size = new System.Drawing.Size(121, 118);
            this.KWImage.TabIndex = 11;
            this.KWImage.TabStop = false;
            // 
            // Map1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1288, 713);
            this.Controls.Add(this.KWImage);
            this.Controls.Add(this.roadmap_label);
            this.Controls.Add(this.map_Image);
            this.Name = "Map1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map1";
            ((System.ComponentModel.ISupportInitialize)(this.map_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map_Image;
        private System.Windows.Forms.Label roadmap_label;
        private System.Windows.Forms.PictureBox KWImage;
    }
}