﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel; //엑셀 파일을 읽어들이기 위한 Neget패키지 다운

namespace KW_Guidebook_UI
{
    public partial class oakui_lab : Form
    {
        public oakui_lab()
        {
            InitializeComponent(); System.Windows.Forms.Label label;
            for (int i = 0; i < 10; i++)
            {
                label = new System.Windows.Forms.Label();
                label.Location = new System.Drawing.Point(30, 120 + i * 30);
                label.Name = "label" + i.ToString();
                label.Size = new System.Drawing.Size(150, 23);
                label.TabIndex = i;
                label.Text = "교수님 연구실 정보" + i.ToString();
                label.ForeColor = Color.Linen;
                this.Controls.Add(label);
            }
        }

        private string filePath = ""; //엑셀 파일 주소
        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        /*영상처리 시스템 연구실 링크 라벨
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ipsl.kw.ac.kr/xe/");
        } */

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //엑셀 파일 로드 해결해야함
        private void Excel()
        {
            if (filePath != "")
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = application.Workbooks.Open(Filename: @filePath);
                Worksheet worksheet1 = workbook.Worksheets.get_Item("member");
                //Worksheet worksheet1 = workbook.Sheets[1] as Worksheet;
                application.Visible = false;
                Range range = worksheet1.UsedRange;
                String data = "";

                for (int i = 1; i <= range.Rows.Count; ++i)
                {
                    for (int j = 1; j <= range.Columns.Count; ++j)
                    {
                        data += ((range.Cells[i, j] as Range).Value2.ToString() + " ");
                    }
                    data += "\n";
                }


                // label = data;

                DeleteObject(worksheet1);
                DeleteObject(workbook);
                application.Quit();
                DeleteObject(application);
            }

        }
        private void DeleteObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("메모리 할당을 해제하는 중 문제가 발생하였습니다." + ex.ToString(), "경고!");
            }
            finally
            {
                GC.Collect();
            }
        }

        private void oakui_lab_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"PROVIDER=MICROSOFT.ACE.OLEDB.12.0;Data Source='C:\Users\이원빈\Documents\GitHub\KW_GuideBook\KW_GuideBook\옥의_연구실.cell'; Extended Properties = 'Excel 12.0; HDR=yes';");
            OleDbDataAdapter cmd = new OleDbDataAdapter("Select * from [Sheet1$]", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
