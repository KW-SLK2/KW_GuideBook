using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KW_Guidebook_UI
{
    public partial class Bima : Form
    {
        public Bima()
        {
            InitializeComponent();

            //information_btn 버튼 이벤트 추가
            this.lab_btn.Click += button1_Click;
        }

        private void Child_Load(object sender, EventArgs e)
        {

        }

        //연구실 버튼 클릭시
        private void button1_Click(object sender, EventArgs e)
        {
            bima_lab newForm1 = new bima_lab();
            newForm1.Location = new Point(this.Location.X, this.Location.Y); //새로운 창이 기존의 창과 같은 위치로 띄우도록 변경
            newForm1.Show(); //새로운 창과 기존의 창이 둘다 컨트롤 가능하도록 Show()함수 사용
        }
    }
}
