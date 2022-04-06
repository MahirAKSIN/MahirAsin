using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btn_topla_Click(object sender, EventArgs e)
        {
            int say1 = int.Parse(txt_sayi1.Text);
            int say2 = int.Parse(txt_sayi2.Text);
            int sonuc = say2 + say1;
            lbl_result.Text = "Toplam : " + sonuc.ToString();
        }
        private void btn_cıkarma_Click(object sender, EventArgs e)
        {

            int say1 = int.Parse(txt_sayi1.Text);
            int say2 = int.Parse(txt_sayi2.Text);
            int sonuc = say1 - say2;
            lbl_result.Text = "CIKARMA : " + sonuc.ToString();
        }
        private void btn_carpma_Click(object sender, EventArgs e)
        {
            int say1 = int.Parse(txt_sayi1.Text);
            int say2 = int.Parse(txt_sayi2.Text);
            int sonuc = say1 * say2;
            lbl_result.Text = "CARPMA : " + sonuc.ToString();
        }
        private void btn_bolme_Click(object sender, EventArgs e)
        {
            int say1 = int.Parse(txt_sayi1.Text);
            int say2 = int.Parse(txt_sayi2.Text);
            if (say2 == 0)
            {
                lbl_result.Text = "TANIMSIZ";
            }
            else
            {
                int sonuc = say1 / say2;
                lbl_result.Text = "BOLME : " + sonuc.ToString();

            }
        }
    }
}
