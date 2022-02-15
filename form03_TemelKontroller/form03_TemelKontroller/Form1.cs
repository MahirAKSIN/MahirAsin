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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_sayiKontrol_TextChanged(object sender, EventArgs e)
        {
            // lbl_sayiKontrol.Text = txt_sayiKontrol.Text;
        }

        private void txt_sayiKontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar.ToString() == "A")
            //{

            //    MessageBox.Show("11111111111111111");
            //}
            //else
            //    MessageBox.Show("dsaasdsa");

            //if (char.IsDigit(e.KeyChar)) 
            //{
            //    MessageBox.Show("Numeric");
            //}else
            //    MessageBox.Show("sozelci");
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_harf_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsLetter(e.KeyChar)||e.KeyChar==(char)Keys.Back)) {
            //    e.Handled = true;
            //}
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txt_buyukHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLower(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rbb_evet.Checked = true;
            doldur();
            doldur2();
        }
        void doldur()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("HAGI");
            comboBox1.Items.Add("POPESCU");
            comboBox1.Items.Add("TAFAREL");
        }
        void doldur2()
        {
            comboBox2.Items.Clear();
            String[] iller = { "Mardin", "Istanbul", "Izmir" };

            comboBox2.Items.AddRange(iller);
            ;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form3 form3 = new Form3();
            form3.Show();
            //form1.Dispose();
            this.Hide();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
