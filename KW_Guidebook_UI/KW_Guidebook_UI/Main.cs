using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KW_Guidebook_UI
{
    public partial class KW_Guidebook_Main : Form
    {
        public KW_Guidebook_Main()
        {
            InitializeComponent();
            
            //information_btn 버튼 이벤트 추가
            this.information_btn.Click += search_btn_Click;           
        }

        //Load Image 버튼을 클릭하면, 사용자의 파일 탐색기에서 사진 선택 후 사진 출력 
        private void button1_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty; //선택한 이미지를 저장하기 위한 변수

            OpenFileDialog dialog = new OpenFileDialog(); //다이얼로그 생성 
            dialog.InitialDirectory = @"C:\"; //다이얼로그 초기 위치 설정

            if (dialog.ShowDialog() == DialogResult.OK) //선택한 이미지 값을 변수에 넣음
            {
                image_file = dialog.FileName;
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel) //종료
            {
                return;
            }

            image_pictureBox.Image = Bitmap.FromFile(image_file); //Picturebox 컨트롤에 선택한 이미지 넣음
            image_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void image_pictureBox_Click(object sender, EventArgs e)
        {
            
        }

        //이미지에 대한 정보를 출력할 버튼
        private void search_btn_Click(object sender, EventArgs e)
        {
            // int i = getBuilding_number();
            int i=0; //프로그램 개발을 위한 임의의 값 사용

            //switch문을 사용하여 사진의 건물에 따른 information 창 출력
            switch (i) {
                case 0: //비마관일 경우
                    Bima newForm1 = new Bima();
                    newForm1.Location = new Point(this.Location.X, this.Location.Y); //새로운 창이 기존의 창과 같은 위치로 띄우도록 변경
                    newForm1.Show(); //새로운 창과 기존의 창이 둘다 컨트롤 가능하도록 Show()함수 사용
                    break;
                case 1: //새빛관일 경우
                    Saebit newForm2 = new Saebit();
                    newForm2.Location = new Point(this.Location.X, this.Location.Y); 
                    newForm2.Show(); 
                    break;
                case 2: //참빛관일 경우
                    Chambit newForm3 = new Chambit();
                    newForm3.Location = new Point(this.Location.X, this.Location.Y); 
                    newForm3.Show(); 
                    break;
            }
   
        }

        private void KW_Guidebook_Main_Load(object sender, EventArgs e)
        {

        }

        //CNN을 이용해 건물을 알아낸 후 건물값을 알려주는 함수
        /*
        private int getBuilding_number()
        {
        }
        */
    }
}
