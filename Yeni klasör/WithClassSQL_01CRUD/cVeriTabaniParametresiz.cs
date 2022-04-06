using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQL_01CRUD
{
    class cVeriTabani
    {
        String sorguCümlesi;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable dt;
        //bir veri tabani baglantisi yapacak method yapilacak...
        public SqlConnection Baglan()
        {
            String baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database=sHastane ; User =sa ; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            return baglanti;
        }
        internal void ekle(TextBox txt_ad, TextBox txt_soyad, string cinsiyet, TextBox txt_adre, TextBox txt_tel, TextBox txt_mail)
        {
            throw new NotImplementedException();
        }
        public void Kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();
            }

        }
        public void HastalariListele(DataGridView dgv)
        {
            sorguCümlesi = "select * from tblHastalar";
            adapter = new SqlDataAdapter(sorguCümlesi, Baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }
        public void ekle(String tcNo, String ad, String soyad, String cinsiyet, String adres, String tel, String mail)
        {
            sorguCümlesi = $"insert into tblHastalar  values ('{tcNo}','{ad}','{soyad}','{cinsiyet}','{adres}','{tel}','{mail}') ";
            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void Guncelle(String query)
        {

            komut = new SqlCommand(query, Baglan());
            komut.ExecuteNonQuery();
            Kapat();


        }
        public void Sil(string id)
        {
            sorguCümlesi = $"delete from tblHastalar where id='{id}' ";
            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();


        }
        public bool Filtre(String tcno, String ad, String soyad, String cinsiyet)
        {
            cVeriTabani cVeri = new cVeriTabani();

            if (tcno != "" && ad != "" && soyad != "" && cinsiyet != "")
            {
                MessageBox.Show("Bosluklari doldur");

            }
            return true;
        }
        public void Islem(String query) 
        {
            komut = new SqlCommand(query, Baglan());
            komut.ExecuteNonQuery();
            Kapat();

        }
        public void BolumleriListele(DataGridView dgv)
        {
            sorguCümlesi = "select * from [dbo].[tblBolumler]";
            adapter = new SqlDataAdapter(sorguCümlesi, Baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }
        public void BolumEkle(String bolumAd)
        {
            sorguCümlesi = $"insert into tblBolumler values ('{bolumAd}') ";
            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void BolumSil (String id)
        {
            sorguCümlesi = $"delete from tblBolumler  where id='{id}'";
            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void BolumleriListeleCmb(ComboBox cmb)
        {
            sorguCümlesi = "select * from [dbo].[tblBolumler]";
            adapter = new SqlDataAdapter(sorguCümlesi, Baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            cmb.DataSource = dt;
        }
        public void BolumleriListeleList(ListBox list,int id)
        {
            sorguCümlesi = $"select * from [dbo].[tblDoktorlar] where bolumid='{id}'";
            adapter = new SqlDataAdapter(sorguCümlesi, Baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            list.DataSource = dt;
        }
        public void Clear() { }
    }
}
