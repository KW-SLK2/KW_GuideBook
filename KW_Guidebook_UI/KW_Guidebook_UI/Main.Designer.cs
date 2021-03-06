﻿namespace KW_Guidebook_UI
{
    partial class KW_Guidebook_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KW_Guidebook_Main));
            this.KW_Guidebook_label = new System.Windows.Forms.Label();
            this.load_image_btn = new System.Windows.Forms.Button();
            this.image_pictureBox = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.information_btn = new System.Windows.Forms.Button();
            this.road_map_btn = new System.Windows.Forms.Button();
            this.KWImage = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).BeginInit();
            this.SuspendLayout();
            // 
            // KW_Guidebook_label
            // 
            this.KW_Guidebook_label.AutoSize = true;
            this.KW_Guidebook_label.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KW_Guidebook_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.KW_Guidebook_label.Location = new System.Drawing.Point(403, 51);
            this.KW_Guidebook_label.Name = "KW_Guidebook_label";
            this.KW_Guidebook_label.Size = new System.Drawing.Size(532, 99);
            this.KW_Guidebook_label.TabIndex = 0;
            this.KW_Guidebook_label.Text = "KW GuideBook";
            // 
            // load_image_btn
            // 
            this.load_image_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.load_image_btn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_image_btn.Image = ((System.Drawing.Image)(resources.GetObject("load_image_btn.Image")));
            this.load_image_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.load_image_btn.Location = new System.Drawing.Point(1063, 371);
            this.load_image_btn.Name = "load_image_btn";
            this.load_image_btn.Size = new System.Drawing.Size(158, 85);
            this.load_image_btn.TabIndex = 1;
            this.load_image_btn.Text = "Load \r\nimage";
            this.load_image_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.load_image_btn.UseVisualStyleBackColor = false;
            this.load_image_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // image_pictureBox
            // 
            this.image_pictureBox.Location = new System.Drawing.Point(252, 184);
            this.image_pictureBox.Name = "image_pictureBox";
            this.image_pictureBox.Size = new System.Drawing.Size(725, 396);
            this.image_pictureBox.TabIndex = 2;
            this.image_pictureBox.TabStop = false;
            this.image_pictureBox.Click += new System.EventHandler(this.image_pictureBox_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.information_btn.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(1063, 471);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 3;
            this.information_btn.Text = "Infor\r\nmation";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // road_map_btn
            // 
            this.road_map_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.road_map_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.road_map_btn.Image = ((System.Drawing.Image)(resources.GetObject("road_map_btn.Image")));
            this.road_map_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.road_map_btn.Location = new System.Drawing.Point(1063, 272);
            this.road_map_btn.Name = "road_map_btn";
            this.road_map_btn.Size = new System.Drawing.Size(158, 85);
            this.road_map_btn.TabIndex = 4;
            this.road_map_btn.Text = "Road\r\nmap";
            this.road_map_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.road_map_btn.UseVisualStyleBackColor = false;
            this.road_map_btn.Click += new System.EventHandler(this.road_map_btn_Click);
            // 
            // KWImage
            // 
            this.KWImage.Image = ((System.Drawing.Image)(resources.GetObject("KWImage.Image")));
            this.KWImage.Location = new System.Drawing.Point(276, 32);
            this.KWImage.Name = "KWImage";
            this.KWImage.Size = new System.Drawing.Size(121, 118);
            this.KWImage.TabIndex = 5;
            this.KWImage.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Linen;
            this.linkLabel1.Location = new System.Drawing.Point(440, 636);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(465, 41);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kwangwoon_University Web Site";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1063, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 85);
            this.button1.TabIndex = 7;
            this.button1.Text = "Grade\r\nCalculator";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(977, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 8;
            // 
            // KW_Guidebook_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1288, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.KWImage);
            this.Controls.Add(this.road_map_btn);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.image_pictureBox);
            this.Controls.Add(this.load_image_btn);
            this.Controls.Add(this.KW_Guidebook_label);
            this.Name = "KW_Guidebook_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KW_Guidebook_Main";
            this.Load += new System.EventHandler(this.KW_Guidebook_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KW_Guidebook_label;
        private System.Windows.Forms.Button load_image_btn;
        private System.Windows.Forms.PictureBox image_pictureBox;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button road_map_btn;
        private System.Windows.Forms.PictureBox KWImage;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

