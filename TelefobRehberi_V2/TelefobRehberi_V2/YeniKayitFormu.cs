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

namespace TelefobRehberi_V2
{
    public partial class YeniKayitFormu : Form
    {
        String sorguCumlesi;
        String baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database=sRehber ; User=sa ; Pwd=123 ";
        SqlConnection baglanti;
        SqlCommand komut;
        public YeniKayitFormu()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void YeniKayitFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_kapat.PerformClick();
        }
        void Add()
        {
            bool result = true;
            String ad = txt_ad.Text;
            String soyad = txt_soyad.Text;
            String tel = txt_tel.Text;
            String cinsiyet;

            if (cbm_cinsiyet.SelectedItem == "KADIN")
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }

            sorguCumlesi = $"insert into tblKisiler (Ad,Soyad,Cinsiyet,Telefon) values ('{ad}','{soyad}','{cinsiyet}','{tel}')";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            result = Convert.ToBoolean(komut.ExecuteNonQuery());
            if (result) 
            {
                MessageBox.Show("Yeni Kisi Eklendi");
            }
            else
            {
                MessageBox.Show("Eklenme islemi yapılamadi");


            }

            baglanti.Close();
            Clear();


        }
        void Clear()
        {
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tel.Text = "";

        }

        private void YeniKayitFormu_Load(object sender, EventArgs e)
        {
            cbm_cinsiyet.SelectedText = "SECİNİZ";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
