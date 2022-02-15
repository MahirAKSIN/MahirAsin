using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form03_TemelKontroller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            String adSoyad = txt_adSoyad.Text.ToUpper().Trim();
            ist_Kisiler.Items.Add(adSoyad);
            txt_adSoyad.Text = "";
            txt_adSoyad.Focus();
        }
        private void txt_adSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            String adSoyad = txt_adSoyad.Text;
            int uz = adSoyad.Length;
            if (uz >= 1)
            {
                int konum = uz - 1;

                // MessageBox.Show("konum : " + konum  +" uzunluk :  " + uz) ;

                if (adSoyad[konum].ToString() == "")
                {
                    e.Handled = ((e.KeyChar == (char)Keys.Space));
                }
            }
            else
            {
                e.Handled = ((e.KeyChar == (char)Keys.Space));
            }
        }

        private void btn_kisiSay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kisi sayisi " + ist_Kisiler.Items.Count);
        }
             
        void aranan()
        {
            string aranan = txt_arama.Text;
            if (ist_Kisiler.Items.Contains(aranan))
            {
                lbl_aranan.Text = aranan;
            }
            else
            {
                lbl_aranan.Text = "Aranan bulunamadi";
            }
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            aranan();
        }
        private void txt_arama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                aranan();

            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
