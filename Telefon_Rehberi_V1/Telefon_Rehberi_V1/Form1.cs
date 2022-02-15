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

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = null;
        SqlDataAdapter adapter = null;
        DataTable dt = null;
        String baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database=sRehber ; User=sa ; Pwd =123";
        String sorguCumlesi;



        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerGetir();
        }

        void kisilerGetir()
        {
            sorguCumlesi = "select * from tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgv_kisiler.DataSource = dt;
        }

    }
}
