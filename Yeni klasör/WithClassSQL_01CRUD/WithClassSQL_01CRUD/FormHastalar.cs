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
    public partial class FormHastalar : System.Windows.Forms.Form
    {
        public FormHastalar()
        {
            InitializeComponent();
        }
        SqlConnnection bag;
        cVeriTabani vt = new cVeriTabani();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_tcno.Text == "" && txt_ad.Text == "" && txt_soyad.Text == "" && cmb_cinsiyet.Text == "SECINIZ")
            {
                MessageBox.Show("Bosluklari doldur");
            }
            else
            {
                String cinsiyet = cmb_cinsiyet.Text == "Kadin" ? "K" : "E";
                vt.ekle(txt_tcno.Text, txt_ad.Text, txt_soyad.Text, cinsiyet, txt_adre.Text, txt_tel.Text, txt_mail.Text);
                Clear();
            }
        }
        private void btn_don_Click(object sender, EventArgs e)
        {
            AnaForm form1 = new AnaForm();
            form1.Show();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaForm ana = new AnaForm();
            ana.Show();
            this.Hide();

        }
        public void aktar()
        {
            txt_tcno.Text = dgv_hastaAktar.CurrentRow.Cells[1].Value.ToString();
            txt_ad.Text = dgv_hastaAktar.CurrentRow.Cells[2].Value.ToString();
            txt_soyad.Text = dgv_hastaAktar.CurrentRow.Cells[3].Value.ToString();
            if (dgv_hastaAktar.CurrentRow.Cells[4].Value.ToString() == "K")
            {
                cmb_cinsiyet.Text = "KADIN";
            }
            else
            {

                cmb_cinsiyet.Text = "ERKEK";
            }

            txt_adre.Text = dgv_hastaAktar.CurrentRow.Cells[5].Value.ToString();
            txt_tel.Text = dgv_hastaAktar.CurrentRow.Cells[6].Value.ToString();
            txt_mail.Text = dgv_hastaAktar.CurrentRow.Cells[7].Value.ToString();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            vt.HastalariListele(dgv_hastaAktar);
        }
        private void dgv_hastaAktar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            aktar();
        }
        private void bt_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_tcno.Text == "" && txt_ad.Text == "" && txt_soyad.Text == "" && cmb_cinsiyet.Text == "SECINIZ")
            {
                MessageBox.Show("Bosluklari doldur");
            }
            else
            {
                String cinsiyet = cmb_cinsiyet.Text == "KADIN" ? "K" : "E";

                String id = dgv_hastaAktar.CurrentRow.Cells[0].Value.ToString();
                vt.Guncelle($"update  tblHastalar  set tcno='{txt_tcno.Text}',Ad='{txt_ad.Text}',Soyad='{txt_soyad.Text}',cinsiyet='{cinsiyet}',adres='{txt_adre.Text}',telefon='{txt_tel.Text}',mail='{txt_mail.Text}' where id='{id}'");
                vt.HastalariListele(dgv_hastaAktar);
                Clear();
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            String id = dgv_hastaAktar.CurrentRow.Cells[0].Value.ToString();

            vt.Sil(id);
            vt.HastalariListele(dgv_hastaAktar);

        }
        public void Clear()
        {
            txt_ad.Text = "";
            txt_adre.Text = "";
            txt_soyad.Text = "";
            txt_tcno.Text = "";
            txt_tel.Text = "";
            txt_mail.Text = "";
            cmb_cinsiyet.Text = "SECINIZ";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
