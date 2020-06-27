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
    public partial class Oakui : Form
    {
        public Oakui()
        {
            InitializeComponent();
        }

        private void Oakui_Map_Click(object sender, EventArgs e)
        {

        }

        private void lab_btn_Click(object sender, EventArgs e)
        {
            oakui_lab newForm = new oakui_lab();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show(); //새로운 창과 기존의 창이 둘다 컨트롤 가능하도록 Show()함수 사용
        }

        private void information_btn_Click(object sender, EventArgs e)
        {
            oakui_class newForm = new oakui_class();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show(); //새로운 창과 기존의 창이 둘다 컨트롤 가능하도록 Show()함수 사용
        }

        private void Oakui_Load(object sender, EventArgs e)
        {

        }
    }
}
