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
    public partial class Doktorlar : Form
    {
        public Doktorlar()
        {
            InitializeComponent();
        }
        cVeriTabani vt = new cVeriTabani();
        private void Doktorlar_Load(object sender, EventArgs e)
        {
            vt.BolumleriListeleCmb(cmb_bolum);
            cmb_bolum.DisplayMember = "bolumAd";
            cmb_bolum.ValueMember = "id";
        }

        private void cmb_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_bolum.SelectedIndex.ToString());
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            String query = $"insert into tblDoktorlar values ('{txt_sicilno.Text}',{txt_adsoyad.Text}',{txt_tel.Text}',{txt_tel.Text}') ";
        }

    }
}

