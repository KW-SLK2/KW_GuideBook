namespace KW_Guidebook_UI
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
            this.KW_Guidebook_label = new System.Windows.Forms.Label();
            this.load_image_btn = new System.Windows.Forms.Button();
            this.image_pictureBox = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.information_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // KW_Guidebook_label
            // 
            this.KW_Guidebook_label.AutoSize = true;
            this.KW_Guidebook_label.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KW_Guidebook_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.KW_Guidebook_label.Location = new System.Drawing.Point(329, 20);
            this.KW_Guidebook_label.Name = "KW_Guidebook_label";
            this.KW_Guidebook_label.Size = new System.Drawing.Size(624, 106);
            this.KW_Guidebook_label.TabIndex = 0;
            this.KW_Guidebook_label.Text = "KW GuideBook";
            // 
            // load_image_btn
            // 
            this.load_image_btn.Font = new System.Drawing.Font("맑은 고딕 Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.load_image_btn.Location = new System.Drawing.Point(360, 590);
            this.load_image_btn.Name = "load_image_btn";
            this.load_image_btn.Size = new System.Drawing.Size(158, 85);
            this.load_image_btn.TabIndex = 1;
            this.load_image_btn.Text = "Load image";
            this.load_image_btn.UseVisualStyleBackColor = true;
            this.load_image_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // image_pictureBox
            // 
            this.image_pictureBox.Location = new System.Drawing.Point(297, 129);
            this.image_pictureBox.Name = "image_pictureBox";
            this.image_pictureBox.Size = new System.Drawing.Size(702, 427);
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
            this.information_btn.Font = new System.Drawing.Font("맑은 고딕 Semilight", 13.8F);
            this.information_btn.Location = new System.Drawing.Point(703, 590);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 3;
            this.information_btn.Text = "Information";
            this.information_btn.UseVisualStyleBackColor = true;
            this.information_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // KW_Guidebook_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1284, 858);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.image_pictureBox);
            this.Controls.Add(this.load_image_btn);
            this.Controls.Add(this.KW_Guidebook_label);
            this.Name = "KW_Guidebook_Main";
            this.Text = "KW_Guidebook_Main";
            this.Load += new System.EventHandler(this.KW_Guidebook_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KW_Guidebook_label;
        private System.Windows.Forms.Button load_image_btn;
        private System.Windows.Forms.PictureBox image_pictureBox;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button information_btn;
    }
}

