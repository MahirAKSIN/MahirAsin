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

namespace Form_02_SQL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        String baglantiSorgusu = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS ; Database =Sirket10 ; User=sa ; Pwd=123";
        String sorgu = "";
        SqlConnection baglanti = null;
        SqlCommand komut = null;
        SqlDataReader dr = null;
        int sayac = 1;


        private void Form4_Load(object sender, EventArgs e)
        {
            //  Login();
        }
        void Login()
        {
            String ad = txt_userNmae.Text;
            String pass = txt_pass.Text;


            sorgu = $"select * from tblUsers where userNmae='{ad}' and pass='{pass}'";
            baglanti = new SqlConnection(baglantiSorgusu);
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            if (dr.Read())
            {

                lbl_info.Text = "Giris basarili ";
                timer1.Start();

            }
            else

                lbl_info.Text = "Kullanici adi ve sifrenizi kontrol ediniz..";
        }
        void status()
        {
            
            lbl_pBar.Text += " ";
            timer1.Start();
            sayac++;


        }


        private void btn_giris_Click(object sender, EventArgs e)
        {



            Login();
            txt_pass.Text = "";
            txt_userNmae.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac <= 5)
            {

                status();
            }
            else
            {

                timer1.Stop();
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }

        }

        private void btn_giris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char)Keys.Enter) {
                Login();
            
            }

           
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();

            }
        }

        private void txt_userNmae_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_pass.Focus();

            }
        }
    }
}
