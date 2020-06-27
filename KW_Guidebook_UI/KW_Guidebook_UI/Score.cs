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
    public partial class Score : Form
    {
        TextBox[] titles; //교과목 textbox 배열
        ComboBox[] crds; // 학점 ComboBox 배열
        ComboBox[] grds; // 성적 ComboBox 배열
        public Score()
        {
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            textBox1.Text = "알고리즘";
            textBox2.Text = "응용소프트웨어실습";
            textBox3.Text = "데이터통신";
            textBox4.Text = "다학년다학기";

            crds = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4 };
            grds = new ComboBox[] { comboBox5, comboBox6, comboBox7, comboBox8 }; 
            titles = new TextBox[] { textBox1, textBox2, textBox3, textBox4 };

            int[] arrcredit = { 1, 2, 3 };
            List<String> lstGrade = new List<String> { "A+", "A0", "B+", "B0", "C+", "C0", "F" };

            foreach (var combo in crds)
            {
                foreach (var i in arrcredit)
                {
                    combo.Items.Add(i);
                }
                combo.SelectedItem = 3;
            }

            foreach (var cb in grds)
            {
                foreach (var gr in lstGrade)
                {
                    cb.Items.Add(gr);
                }
            }
        }

        private double GetGrade(string text)
        {
            double grade = 0;
            if (text == "A+") grade = 4.5;
            else if (text == "A0") grade = 4.0;
            else if (text == "B+") grade = 3.5;
            else if (text == "B0") grade = 3.0;
            else if (text == "C+") grade = 2.5;
            else if (text == "C0") grade = 2.0;
            else if (text == "F") grade = 0.0;
            return grade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for (int i = 0; i < crds.Length; i++)
            {
                if (titles[i].Text != "")
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalCredits += crd;
                    totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());

                }
            }
            label6.Text = (totalScore / totalCredits).ToString("0.00");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
