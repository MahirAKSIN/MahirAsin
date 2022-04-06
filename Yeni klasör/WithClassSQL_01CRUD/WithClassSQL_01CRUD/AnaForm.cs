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
    public partial class AnaForm : System.Windows.Forms.Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        cVeriTabani vt = new cVeriTabani();
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            //vt.HastalariListele(dgv_hastalar);
            //dgv_hastalar.Columns[0].Visible = false;

        }
        private void AnaForm_Activated(object sender, EventArgs e)
        {

        }
        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btn_hastalar_Click(object sender, EventArgs e)
        {
            FormHastalar form = new FormHastalar();
            form.Show();
            this.Hide();
        }
        private void btn_bolumlereGit_Click(object sender, EventArgs e)
        {
            FormBolumler form1 = new FormBolumler();
            form1.Show();
            this.Hide();
        }
    }
}
