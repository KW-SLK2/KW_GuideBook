using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KW_Guidebook_UI
{
    public partial class hanoul_class : Form
    {
        public hanoul_class()
        {
            InitializeComponent();
        }

        private void hanoul_class_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"PROVIDER=MICROSOFT.ACE.OLEDB.12.0;Data Source='C:\Users\이원빈\Documents\GitHub\KW_GuideBook\KW_GuideBook\한울관_강의실.cell'; Extended Properties = 'Excel 12.0; HDR=yes';");
            OleDbDataAdapter cmd = new OleDbDataAdapter("Select * from [Sheet1$]", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
