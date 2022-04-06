
namespace form03_TemelKontroller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_sayiKontrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sayiKontrol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_harf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_buyukHarf = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.rbb_evet = new System.Windows.Forms.RadioButton();
            this.rbb_hayir = new System.Windows.Forms.RadioButton();
            this.Cinsiyet = new System.Windows.Forms.GroupBox();
            this.rdb_Erkek = new System.Windows.Forms.RadioButton();
            this.rdb_Kadin = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_form2 = new System.Windows.Forms.Button();
            this.Cinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sayiKontrol
            // 
            this.txt_sayiKontrol.Location = new System.Drawing.Point(12, 27);
            this.txt_sayiKontrol.Name = "txt_sayiKontrol";
            this.txt_sayiKontrol.Size = new System.Drawing.Size(110, 20);
            this.txt_sayiKontrol.TabIndex = 0;
            this.txt_sayiKontrol.TextChanged += new System.EventHandler(this.txt_sayiKontrol_TextChanged);
            this.txt_sayiKontrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayiKontrol_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sadece Sayi Gir";
            // 
            // lbl_sayiKontrol
            // 
            this.lbl_sayiKontrol.AutoSize = true;
            this.lbl_sayiKontrol.Location = new System.Drawing.Point(9, 50);
            this.lbl_sayiKontrol.Name = "lbl_sayiKontrol";
            this.lbl_sayiKontrol.Size = new System.Drawing.Size(115, 13);
            this.lbl_sayiKontrol.TabIndex = 1;
            this.lbl_sayiKontrol.Text = "__________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sadece harf gir";
            // 
            // txt_harf
            // 
            this.txt_harf.Location = new System.Drawing.Point(158, 27);
            this.txt_harf.Name = "txt_harf";
            this.txt_harf.Size = new System.Drawing.Size(100, 20);
            this.txt_harf.TabIndex = 3;
            this.txt_harf.TextChanged += new System.EventHandler(this.txt_harf_TextChanged);
            this.txt_harf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_harf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sadece Buyuk harf gir";
            // 
            // txt_buyukHarf
            // 
            this.txt_buyukHarf.Location = new System.Drawing.Point(12, 94);
            this.txt_buyukHarf.Name = "txt_buyukHarf";
            this.txt_buyukHarf.Size = new System.Drawing.Size(100, 20);
            this.txt_buyukHarf.TabIndex = 3;
            this.txt_buyukHarf.TextChanged += new System.EventHandler(this.txt_harf_TextChanged);
            this.txt_buyukHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buyukHarf_KeyPress);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 208);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // rbb_evet
            // 
            this.rbb_evet.AutoSize = true;
            this.rbb_evet.Location = new System.Drawing.Point(12, 234);
            this.rbb_evet.Name = "rbb_evet";
            this.rbb_evet.Size = new System.Drawing.Size(47, 17);
            this.rbb_evet.TabIndex = 5;
            this.rbb_evet.TabStop = true;
            this.rbb_evet.Text = "Evet";
            this.rbb_evet.UseVisualStyleBackColor = true;
            // 
            // rbb_hayir
            // 
            this.rbb_hayir.AutoSize = true;
            this.rbb_hayir.Location = new System.Drawing.Point(12, 257);
            this.rbb_hayir.Name = "rbb_hayir";
            this.rbb_hayir.Size = new System.Drawing.Size(49, 17);
            this.rbb_hayir.TabIndex = 6;
            this.rbb_hayir.TabStop = true;
            this.rbb_hayir.Text = "Hayir";
            this.rbb_hayir.UseVisualStyleBackColor = true;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Controls.Add(this.rdb_Erkek);
            this.Cinsiyet.Controls.Add(this.rdb_Kadin);
            this.Cinsiyet.Location = new System.Drawing.Point(12, 120);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(62, 61);
            this.Cinsiyet.TabIndex = 7;
            this.Cinsiyet.TabStop = false;
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // rdb_Erkek
            // 
            this.rdb_Erkek.AutoSize = true;
            this.rdb_Erkek.Location = new System.Drawing.Point(6, 19);
            this.rdb_Erkek.Name = "rdb_Erkek";
            this.rdb_Erkek.Size = new System.Drawing.Size(32, 17);
            this.rdb_Erkek.TabIndex = 8;
            this.rdb_Erkek.TabStop = true;
            this.rdb_Erkek.Text = "E";
            this.rdb_Erkek.UseVisualStyleBackColor = true;
            // 
            // rdb_Kadin
            // 
            this.rdb_Kadin.AutoSize = true;
            this.rdb_Kadin.Location = new System.Drawing.Point(6, 42);
            this.rdb_Kadin.Name = "rdb_Kadin";
            this.rdb_Kadin.Size = new System.Drawing.Size(32, 17);
            this.rdb_Kadin.TabIndex = 9;
            this.rdb_Kadin.TabStop = true;
            this.rdb_Kadin.Text = "K";
            this.rdb_Kadin.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Galatasaray",
            "Fenerbahce",
            "Besiktas",
            "TrabzonSpor",
            "BursaSpor"});
            this.comboBox1.Location = new System.Drawing.Point(143, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(135, 183);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(95, 36);
            this.btn_form2.TabIndex = 11;
            this.btn_form2.Text = "form2 ye gec";
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 284);
            this.Controls.Add(this.btn_form2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rbb_evet);
            this.Controls.Add(this.rbb_hayir);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txt_buyukHarf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_harf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_sayiKontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sayiKontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Cinsiyet.ResumeLayout(false);
            this.Cinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sayiKontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sayiKontrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_harf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buyukHarf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton rbb_evet;
        private System.Windows.Forms.RadioButton rbb_hayir;
        private System.Windows.Forms.GroupBox Cinsiyet;
        private System.Windows.Forms.RadioButton rdb_Erkek;
        private System.Windows.Forms.RadioButton rdb_Kadin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_form2;
    }
}

