
namespace WithClassSQL_01CRUD
{
    partial class FormHastalar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_adre = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_don = new System.Windows.Forms.Button();
            this.dgv_hastaAktar = new System.Windows.Forms.DataGridView();
            this.bt_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastaAktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon";
            // 
            // txt_tcno
            // 
            this.txt_tcno.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcno.Location = new System.Drawing.Point(87, 18);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(157, 26);
            this.txt_tcno.TabIndex = 0;
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(87, 51);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(157, 26);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(87, 85);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(157, 26);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_adre
            // 
            this.txt_adre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adre.Location = new System.Drawing.Point(87, 152);
            this.txt_adre.Multiline = true;
            this.txt_adre.Name = "txt_adre";
            this.txt_adre.Size = new System.Drawing.Size(157, 71);
            this.txt_adre.TabIndex = 4;
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(87, 238);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(157, 26);
            this.txt_tel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(87, 269);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(157, 26);
            this.txt_mail.TabIndex = 6;
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(87, 117);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(102, 26);
            this.cmb_cinsiyet.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.White;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(244, 180);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(157, 57);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "Yeni Kayit";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_don
            // 
            this.btn_don.BackColor = System.Drawing.Color.White;
            this.btn_don.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_don.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_don.Location = new System.Drawing.Point(244, 238);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(157, 57);
            this.btn_don.TabIndex = 7;
            this.btn_don.Text = "KAPAT";
            this.btn_don.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_don.UseVisualStyleBackColor = false;
            this.btn_don.Click += new System.EventHandler(this.btn_don_Click);
            // 
            // dgv_hastaAktar
            // 
            this.dgv_hastaAktar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_hastaAktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hastaAktar.Location = new System.Drawing.Point(245, 18);
            this.dgv_hastaAktar.Name = "dgv_hastaAktar";
            this.dgv_hastaAktar.ReadOnly = true;
            this.dgv_hastaAktar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hastaAktar.Size = new System.Drawing.Size(523, 161);
            this.dgv_hastaAktar.TabIndex = 4;
            this.dgv_hastaAktar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hastaAktar_CellEnter);
            // 
            // bt_guncelle
            // 
            this.bt_guncelle.BackColor = System.Drawing.Color.White;
            this.bt_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_guncelle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_guncelle.Location = new System.Drawing.Point(402, 180);
            this.bt_guncelle.Name = "bt_guncelle";
            this.bt_guncelle.Size = new System.Drawing.Size(157, 57);
            this.bt_guncelle.TabIndex = 8;
            this.bt_guncelle.Text = "Guncelle";
            this.bt_guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guncelle.UseVisualStyleBackColor = false;
            this.bt_guncelle.Click += new System.EventHandler(this.bt_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(402, 238);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(157, 57);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // FormHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 309);
            this.Controls.Add(this.dgv_hastaAktar);
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.bt_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_adre);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHastalar";
            this.Text = "Hastalar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastaAktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_adre;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_don;
        private System.Windows.Forms.DataGridView dgv_hastaAktar;
        private System.Windows.Forms.Button bt_guncelle;
        private System.Windows.Forms.Button btn_sil;
    }
}