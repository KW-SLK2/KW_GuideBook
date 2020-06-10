﻿namespace KW_Guidebook_UI
{
    partial class Oakui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oakui));
            this.Oakui_Map = new System.Windows.Forms.PictureBox();
            this.information_btn = new System.Windows.Forms.Button();
            this.lab_btn = new System.Windows.Forms.Button();
            this.oakui_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Oakui_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // Oakui_Map
            // 
            this.Oakui_Map.Image = ((System.Drawing.Image)(resources.GetObject("Oakui_Map.Image")));
            this.Oakui_Map.Location = new System.Drawing.Point(78, 215);
            this.Oakui_Map.Name = "Oakui_Map";
            this.Oakui_Map.Size = new System.Drawing.Size(638, 311);
            this.Oakui_Map.TabIndex = 16;
            this.Oakui_Map.TabStop = false;
            this.Oakui_Map.Click += new System.EventHandler(this.Oakui_Map_Click);
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.Color.Pink;
            this.information_btn.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(766, 441);
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
            this.lab_btn.Location = new System.Drawing.Point(766, 350);
            this.lab_btn.Name = "lab_btn";
            this.lab_btn.Size = new System.Drawing.Size(158, 85);
            this.lab_btn.TabIndex = 14;
            this.lab_btn.Text = "Lab";
            this.lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_btn.UseVisualStyleBackColor = false;
            this.lab_btn.Click += new System.EventHandler(this.lab_btn_Click);
            // 
            // oakui_label
            // 
            this.oakui_label.AutoSize = true;
            this.oakui_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold);
            this.oakui_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.oakui_label.Location = new System.Drawing.Point(368, 64);
            this.oakui_label.Name = "oakui_label";
            this.oakui_label.Size = new System.Drawing.Size(285, 106);
            this.oakui_label.TabIndex = 13;
            this.oakui_label.Text = "옥의관";
            // 
            // Oakui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(992, 623);
            this.Controls.Add(this.Oakui_Map);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.lab_btn);
            this.Controls.Add(this.oakui_label);
            this.Name = "Oakui";
            this.Text = "Oakui";
            ((System.ComponentModel.ISupportInitialize)(this.Oakui_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Oakui_Map;
        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button lab_btn;
        private System.Windows.Forms.Label oakui_label;
    }
}