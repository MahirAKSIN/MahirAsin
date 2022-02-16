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
            Clear();
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
            Clear();
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
            Clear();

        }
        void Delete()
        {


            String id = (lbl_id.Text);
            sorguCumlesi = $"delete from tblKisiler where ID='{id}' ";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisilerGetir();
            Clear();

        }
        void PersonAdd()
        {
            if (btn_yeni.Text == "YENI")
            {
                btn_yeni.Text = "KAYDET";
                Clear();

            }
            else
            {

                btn_yeni.Text = "Yeni";
                String tel = txt_tel.Text;
                String soyad = txt_soyad.Text;
                String ad = txt_ad.Text;
                String id = (lbl_id.Text);
                char cinsiyet;

                if (rdb_kadin.Checked = true)
                {
                    cinsiyet = 'K';
                }
                else
                {
                    cinsiyet = 'E';

                }
                sorguCumlesi = $"insert into tblKisiler (Ad,Soyad,Cinsiyet,Telefon) values('{ad}','{soyad}','{cinsiyet}','{tel}') ";
                baglanti = new SqlConnection(baglantiCumlesi);
                komut = new SqlCommand(sorguCumlesi, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                kisilerGetir();
                Clear();
            }
        }
        void Ara()
        {
            String arana = txt_aranan.Text;
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = $"Ad like '{arana}%'";
            // dgv_kisiler.DataSource = dv;



            //String ad = txt_ad.Text;
            //sorguCumlesi = $"select * from tblKisiler where Ad like '{txt_aranan.Text}%'";
            //baglanti = new SqlConnection(baglantiCumlesi);
            //komut = new SqlCommand(sorguCumlesi,baglanti);
            //baglanti.Open();
            //komut.ExecuteNonQuery();
            //baglanti.Close();


        }
        void Clear()
        {
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tel.Text = "";
            lbl_id.Text = "Yeni Kayit";

        }
        private void dgv_kisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }
        private void btn_duzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            PersonAdd();
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            Ara();
        }
        private void txt_aranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Ara();
            }
        }
        private void txt_aranan_KeyDown(object sender, KeyEventArgs e)
        {
            Ara();
        }
        private void txt_aranan_KeyUp(object sender, KeyEventArgs e)
        {
            Ara();
        }
    }
}
