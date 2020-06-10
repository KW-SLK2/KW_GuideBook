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
using System.Net;
using System.Net.Sockets;
using TensorFlow;

namespace KW_Guidebook_UI
{
    public partial class KW_Guidebook_Main : Form
    {
        string cnn_Result; //파이썬에 사용자가 선택한 사진을 보낸 후, CNN모델에 적용해 건물의 이름을 파악하여 C#에 건물이름을 전송한 값을 저장한 변수 
        public KW_Guidebook_Main()
        {
            InitializeComponent();      
        }

        //Load Image 버튼을 클릭하면, 사용자의 파일 탐색기에서 사진 선택 후 사진 출력 
        private void button1_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty; //선택한 이미지를 저장하기 위한 변수
            OpenFileDialog dialog = new OpenFileDialog(); //다이얼로그 생성 
            dialog.InitialDirectory = @"C:\"; //다이얼로그 초기 위치 설정

            if (dialog.ShowDialog() == DialogResult.OK) //선택한 이미지 값을 변수에 넣음
            {

                image_file = dialog.FileName; //이미지 경로
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel) //종료
            {
                return;
            }

            image_pictureBox.Image = Bitmap.FromFile(image_file); //Picturebox 컨트롤에 선택한 이미지 넣음
            Image image =Bitmap.FromFile(image_file);
            var image_=GetBytesOfImage(image);
            image_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

         
            // 소켓 생성
            
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999)); // Connect 함수로 로컬(127.0.0.1)의 포트 번호 9999로 대기 중인 socket에 접속

                var data = Encoding.UTF8.GetBytes(image_file); // python 파일에 이미지 경로를 UTF8타입의 byte 배열로 변환
               
                client.Send(BitConverter.GetBytes(data.Length)); // big엔디언으로 데이터 길이를 변환하고 서버로 보낼 데이터의 길이보냄
                
                client.Send(data); //데이터 전송

                data = new byte[4];  // 데이터의 길이를 수신하기 위한 배열생성
               
                client.Receive(data, data.Length, SocketFlags.None); // 데이터의 길이를 수신

                Array.Reverse(data);

                data = new byte[BitConverter.ToInt32(data, 0)]; // 데이터의 길이만큼 byte 배열을 생성

                client.Receive(data, data.Length, SocketFlags.None); // 데이터 수신

                Console.WriteLine(Encoding.UTF8.GetString(data));  // 수신된 데이터를 UTF8인코딩으로 string 타입으로 변환 후 콘솔에 출력

                cnn_Result=Encoding.UTF8.GetString(data); //파이썬에서 돌린 CNN 모델 결과값을 C#에 전송해, cnn_Result에 저장
            
            }
            Console.WriteLine("wait...");
            Console.ReadLine();
            
        }
        //이미지 타입 이미지를 바이트타입으로 변환
        public static byte[] GetBytesOfImage(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void image_pictureBox_Click(object sender, EventArgs e)
        {
            
        }

        //이미지에 대한 정보를 출력할 버튼
        private void search_btn_Click(object sender, EventArgs e)
        {
            string CNN_result = "";
            // 소켓 생성
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999)); // Connect 함수로 로컬(127.0.0.1)의 포트 번호 9999로 대기 중인 socket에 접속

                var data = Encoding.UTF8.GetBytes("hello"); // python 파일에 이미지 경로를 UTF8타입의 byte 배열로 변환

                client.Send(BitConverter.GetBytes(data.Length)); // big엔디언으로 데이터 길이를 변환하고 서버로 보낼 데이터의 길이보냄

                client.Send(data); //데이터 전송

                data = new byte[4];  // 데이터의 길이를 수신하기 위한 배열생성

                client.Receive(data, data.Length, SocketFlags.None); // 데이터의 길이를 수신

                Array.Reverse(data);

                data = new byte[BitConverter.ToInt32(data, 0)]; // 데이터의 길이만큼 byte 배열을 생성

                client.Receive(data, data.Length, SocketFlags.None); // 데이터 수신

                Console.WriteLine(Encoding.UTF8.GetString(data));  // 수신된 데이터를 UTF8인코딩으로 string 타입으로 변환 후 콘솔에 출력

                CNN_result = Encoding.UTF8.GetString(data); //파이썬에서 돌린 CNN 모델 결과값을 C#에 전송해, cnn_Result에 저장
            }
            Console.WriteLine("wait...");
            Console.ReadLine();


            //switch문을 사용하여 사진의 건물에 따른 information 창 출력
            
            switch (CNN_result)
            {
                case "bima": //비마관일 경우
                    Bima newForm1 = new Bima();
                    newForm1.Location = new Point(this.Location.X, this.Location.Y); //새로운 창이 기존의 창과 같은 위치로 띄우도록 변경
                    newForm1.Show(); //새로운 창과 기존의 창이 둘다 컨트롤 가능하도록 Show()함수 사용
                    break;
                case "saebit": //새빛관일 경우
                    Saebit newForm2 = new Saebit();
                    newForm2.Location = new Point(this.Location.X, this.Location.Y);
                    newForm2.Show();
                    break;
                case "chambit": //참빛관일 경우
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
