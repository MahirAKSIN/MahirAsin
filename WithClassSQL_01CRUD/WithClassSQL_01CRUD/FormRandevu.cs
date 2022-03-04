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
    public partial class FormRandevu : Form
    {

        cVeriTabani vt = new cVeriTabani();

        public FormRandevu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_aranaHasta_TextChanged(object sender, EventArgs e)
        {

        }

        void Doldur() {
            vt.BolumleriListeleCmb(cmb_bolum);
            cmb_bolum.DisplayMember = "bolumid";
            cmb_bolum.ValueMember = "id";


            vt.BolumleriListeleList(list_doktorlar,1);

        }
        private void FormRandevu_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
