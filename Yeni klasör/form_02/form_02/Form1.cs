using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_02
{
    public partial class Form1 : Form
    {
        public int hedef;
        public int sayac = 5;
        public int puan = 100;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_basla_Click(object sender, EventArgs e)
        {
            txt_tahminSayi.Focus();
            RastgeleSayi();
        }
        public void RastgeleSayi()
        {
            Random rnd = new Random();
            hedef = rnd.Next(10);
            txt_arananSayi.Text = Convert.ToString(hedef);
        }
        public void KontrolEt(int tahminEd)
        {
            if (hedef == tahminEd)
            {
                lbl_msj.Text = " TEBRIKLER " + sayac + " caniniz var ";
            }
            else
            {
                sayac--;
                puan -= 20;
                lbl_msj.Text = "Dogru tahmin degil." + sayac + " caniniz kaldi ";
                //  txt_tahminSayi.Text = "";
            }
            if (sayac == 0 || puan == 0)
            {
                lbl_msj.Text = "KAYBETINIZ" + " Kalan puaniniz : " + puan + "\n Kalab caniniz : " + sayac;
            }
            txt_can.Text = sayac.ToString();
            txt_puan.Text = puan.ToString();
        }
        void tahminClick()
        {

            int thmnSayi = int.Parse(txt_tahminSayi.Text);

            KontrolEt(thmnSayi);
        }
        private void btn_tahminEt_Click(object sender, EventArgs e)
        {
            int thmnSayi = int.Parse(txt_tahminSayi.Text);

            KontrolEt(thmnSayi);
        }

        private void btn_tahminEt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter) 
            {
                tahminClick();
            }
        }
    }
}
