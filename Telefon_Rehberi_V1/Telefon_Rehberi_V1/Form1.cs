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
        SqlCommand komut;


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
        void Aktar()
        {
            lbl_id.Text = dgv_kisiler.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dgv_kisiler.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = dgv_kisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgv_kisiler.CurrentRow.Cells[3].Value.ToString() == "K")
            {
                rdb_kadin.Checked = true;
            }
            else
            {
                rdb_erkek.Checked = true;
            }
            txt_tel.Text = dgv_kisiler.CurrentRow.Cells[4].Value.ToString();
        }
        private void dgv_kisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }
        void Duzelt()
        {
            String id = lbl_id.Text;
            String ad = txt_ad.Text;
            String soyad = txt_soyad.Text;
            char cinsiyet;
            String tel = txt_tel.Text;

            if (rdb_kadin.Checked == true)
            {
                cinsiyet = 'K';
            }
            else
            {
                cinsiyet = 'E';

            }

            sorguCumlesi = $"update tblKisiler set Ad = '{ad}', Soyad ='{soyad}', Cinsiyet = '{cinsiyet}', Telefon = '{tel}' where ID = '{id}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisilerGetir();

        }
        private void btn_duzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }
    }
}
