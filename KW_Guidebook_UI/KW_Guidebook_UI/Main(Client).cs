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
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace KW_Guidebook_UI
{
    public partial class KW_Guidebook_Main : Form
    {
        public KW_Guidebook_Main()
        {
            InitializeComponent();      
        }

        //Load Image 버튼을 클릭하면, 사용자의 파일 탐색기에서 사진 선택 후 사진 출력 
        private void button1_Click(object sender, EventArgs e)
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Connect 함수로 로컬(127.0.0.1)의 포트 번호 9999로 대기 중인 socket에 접속한다.
            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            // 보낼 메시지를 UTF8타입의 byte 배열로 변환한다.
           

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

            MemoryStream ms = new MemoryStream();

           
            Image image = Bitmap.FromFile(image_file);
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] data = ms.GetBuffer();
            try
            {
                int trans = 0;
                byte[] lbuf = BitConverter.GetBytes(data.Length);
                client.Send(lbuf);

                while(trans < data.Length)
                {
                    trans += client.Send(data, trans, data.Length - trans, SocketFlags.None);
                }
                client.Close();
                client = null;
            }
            catch
            {
                MessageBox.Show("잘못 입력하셨습니다.");
            }

            /*
            // 데이터의 길이를 수신하기 위한 배열을 생성한다. (4byte)
            data = new byte[4];
            // 데이터의 길이를 수신한다.
            client.Receive(data, data.Length, SocketFlags.None);
            // server에서 big엔디언으로 전송을 했는데도 little 엔디언으로 온다. big엔디언과 little엔디언은 배열의 순서가 반대이므로 reverse한다.
            Array.Reverse(data);
            // 데이터의 길이만큼 byte 배열을 생성한다.
            data = new byte[BitConverter.ToInt32(data, 0)];
            // 데이터를 수신한다.
            client.Receive(data, data.Length, SocketFlags.None);
            // 수신된 데이터를 UTF8인코딩으로 string 타입으로 변환 후에 콘솔에 출력한다.
            Console.WriteLine(Encoding.UTF8.GetString(data));
            */
        }

        private void image_pictureBox_Click(object sender, EventArgs e)
        {
            
        }
        static byte[] receiveBytes = new byte[1024];

            //이미지에 대한 정보를 출력할 버튼
            private void search_btn_Click(object sender, EventArgs e)
        {
            Socket transferSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            transferSocket.Connect(new IPEndPoint(IPAddress.Loopback, 10801));

            transferSocket.Receive(receiveBytes);
            Console.WriteLine(Encoding.Default.GetString(receiveBytes));



            // int i = getBuilding_number();
            int i =0; //프로그램 개발을 위한 임의의 값 사용

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
