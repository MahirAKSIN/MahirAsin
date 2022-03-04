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
    public partial class FormBolumler : Form
    {
        public FormBolumler()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String sorguCumlesi;
        cVeriTabani vt = new cVeriTabani();
        private void FormBolumler_Load(object sender, EventArgs e)
        {
            sorguCumlesi = "select * from [dbo].[tblBolumler]";
            vt.BolumleriListele(dgv_bolumler);
        }

        private void dgv_bolumler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String id=dgv_bolumler.CurrentRow.Cells[0].Value.ToString();
            txt_bolumAd.Text=dgv_bolumler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            String id = dgv_bolumler.CurrentRow.Cells[0].Value.ToString();
            String query = $"update tblBolumler set bolumAd='{txt_bolumAd.Text}' where id='{id}'";
            vt.Guncelle(query);
            vt.BolumleriListele(dgv_bolumler);
        }

        private void btn_bolumekle_Click(object sender, EventArgs e)
        {
            FormBolumEkle bolumEkle = new FormBolumEkle();
            bolumEkle.Show();
            this.Hide();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            String id = dgv_bolumler.CurrentRow.Cells[0].Value.ToString();

            vt.BolumSil(id);
            vt.BolumleriListele(dgv_bolumler);
        }

        private void FormBolumler_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaForm formBolumler = new AnaForm();
            formBolumler.Show();
        }
    }
}
