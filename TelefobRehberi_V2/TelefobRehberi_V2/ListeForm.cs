using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefobRehberi_V2
{
    public partial class ListeForm : Form
    {
        String sorguCumlesi;
        String baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database=sRehber ; User=sa ; Pwd=123 ";
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter = null;
        DataTable dt;
        public ListeForm()
        {
            InitializeComponent();
        }
        private void ListeForm_Load(object sender, EventArgs e)
        {
            kisilerGetir();

        }
        private void ListeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
        }
        private void btn_duzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }
        private void dgv_kisi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            aktar();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete();


        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
        void kisilerGetir()
        {
            sorguCumlesi = "select * from tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgv_kisi.DataSource = dt;
        }
        void aktar()
        {

            String id = dgv_kisi.CurrentRow.Cells[0].Value.ToString();
            txt_adL.Text = dgv_kisi.CurrentRow.Cells[1].Value.ToString();
            txt_soyadL.Text = dgv_kisi.CurrentRow.Cells[2].Value.ToString();
            txt_telL.Text = dgv_kisi.CurrentRow.Cells[4].Value.ToString();
            if (dgv_kisi.CurrentRow.Cells[3].Value.ToString() == "K")
            {
                cbm_cinsiyetL.Text = "KADIN";
            }
            else
            {
                cbm_cinsiyetL.Text = "ERKEK";
            }
        }
        void Duzelt()
        {
            String id = lbl_idL.Text;
            String ad = txt_adL.Text;
            String soyad = txt_soyadL.Text;
            char cinsiyet;
            String tel = txt_telL.Text;

            if (cbm_cinsiyetL.SelectedItem == "KADIN")
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
        void Delete()
        {
            String id = dgv_kisi.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"delete from tblKisiler where ID='{id.ToString()}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisilerGetir();
        }

    }
}
