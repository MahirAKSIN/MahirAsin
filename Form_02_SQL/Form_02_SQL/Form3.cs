using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Form_02_SQL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        String baglntiCumlesi = "";
        String sorguCumlesi = "";
        private void Form3_Load(object sender, EventArgs e)
        {
            verileriAl();
        }

        void verileriAl()
        {
            baglntiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database=Sirket10 ; User=sa ; Pwd =123";
            sorguCumlesi = "select * from [dbo].[tblPersonel]";
            SqlConnection baglanti = new SqlConnection(baglntiCumlesi);
            SqlDataAdapter adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_personel.DataSource = dt;


            dgv_personel.Columns["ID"].Visible=false;//istenmeyen kolonları saklar...



        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
