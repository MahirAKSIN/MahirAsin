using SatisProgrami.DataAccess;
using SatisProgrami.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        crudDAL cruD;
        Satis satis;
        UrunDALcs UrunDALcs;
        private void btn_satis_Click(object sender, EventArgs e)
        {
            cruD = new crudDAL();
            satis = new Satis();
            satis.satisAdet = int.Parse(txt_adet.Text);
            satis.urunid = int.Parse(cmb_urunSec.SelectedValue.ToString());
            satis.satisT = dtp_satisT.Value;
             cruD.insert(satis);
          //  MessageBox.Show(satis .urunid.ToString() );

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunDALcs = new UrunDALcs();
              
            cruD = new crudDAL();
            dgv_satis.DataSource = cruD.GetAll();

            cmb_urunSec.DataSource = UrunDALcs.GetAll();

            cmb_urunSec.ValueMember = "id";
            cmb_urunSec.DisplayMember = "urunad";


        }
    }
}
