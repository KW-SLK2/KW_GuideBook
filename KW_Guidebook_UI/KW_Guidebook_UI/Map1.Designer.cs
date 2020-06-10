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
            ((System.ComponentModel.ISupportInitialize)(this.map_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // map_Image
            // 
            this.map_Image.Image = ((System.Drawing.Image)(resources.GetObject("map_Image.Image")));
            this.map_Image.Location = new System.Drawing.Point(53, 102);
            this.map_Image.Name = "map_Image";
            this.map_Image.Size = new System.Drawing.Size(694, 324);
            this.map_Image.TabIndex = 0;
            this.map_Image.TabStop = false;
            // 
            // roadmap_label
            // 
            this.roadmap_label.AutoSize = true;
            this.roadmap_label.Font = new System.Drawing.Font("휴먼엑스포", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roadmap_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.roadmap_label.Location = new System.Drawing.Point(337, 19);
            this.roadmap_label.Name = "roadmap_label";
            this.roadmap_label.Size = new System.Drawing.Size(149, 67);
            this.roadmap_label.TabIndex = 1;
            this.roadmap_label.Text = "지도";
            // 
            // Map1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(802, 468);
            this.Controls.Add(this.roadmap_label);
            this.Controls.Add(this.map_Image);
            this.Name = "Map1";
            this.Text = "Map1";
            ((System.ComponentModel.ISupportInitialize)(this.map_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map_Image;
        private System.Windows.Forms.Label roadmap_label;
    }
}