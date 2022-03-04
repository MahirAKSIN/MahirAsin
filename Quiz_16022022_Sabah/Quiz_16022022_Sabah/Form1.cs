using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_16022022_Sabah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DESKTOP-8M7D7GE\SQLEXPRESS
        private void Form1_Load(object sender, EventArgs e)
        {
            KisiGetir();
        }

        String sorguCumlesi;
        String baglatiCumlesi= @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database=sRehber ; User=sa ; Pwd=123";
                SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;



        void KisiGetir() 
               
        {

            sorguCumlesi = "select * from tblKisiler";
        baglanti=new SqlConnection(baglatiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dvg.DataSource = dt;

        }

    }
}
