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
    public partial class bima_lab : Form
    {
        public bima_lab()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        //영상처리 시스템 연구실
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            System.Diagnostics.Process.Start("https://ipsl.kw.ac.kr/xe/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
