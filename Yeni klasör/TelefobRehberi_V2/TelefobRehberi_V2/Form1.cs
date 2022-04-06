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
    public partial class Form1 : Form
    {

        String baglantiCumlesi= @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database=sRehber User=sa ; Pwd=123 ";
        String sorguCumlesi;
        SqlConnection baglanti;
        SqlCommand komut;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_yeniKayit_Click(object sender, EventArgs e)
        {
            YeniKayitFormu yeniKayitFormu = new YeniKayitFormu();
            yeniKayitFormu.Show();
            this.Hide();
        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            ListeForm listeForm = new ListeForm();
            listeForm.Show();
        }
    
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_cikis.PerformClick();
        }
    }
}
