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
    public partial class Form3 : Form
    {
        public String cinsiyet = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdbKadin.Checked = true;
        }

        string cinisyet()
        {
            if (rdbKadin.Checked == true)
            {
                return "Kadin";
            }
            else
            {
                return "Erkek";
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txt_adSoayd.Text;
            lvi.SubItems.Add(cinisyet());
            list.Items.Add(lvi);
            temizle();
        }
        void temizle() {

            txt_adSoayd.Text = "";
            rdbKadin.Checked = true;
        }
    }
}
