using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQL_01CRUD
{
    public partial class FormBolumEkle : Form
    {
        public FormBolumEkle()
        {
            InitializeComponent();
        }
        String sorguCumlesi;
        cVeriTabani vt = new cVeriTabani();
        private void btn_bolumekle_Click(object sender, EventArgs e)
        {
            vt.BolumEkle(txt_bolumAd.Text);
            txt_bolumAd.Text = "";
        }

        private void FormBolumEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBolumler formBolumler = new FormBolumler();
            formBolumler.Show();
        }
    }
}
