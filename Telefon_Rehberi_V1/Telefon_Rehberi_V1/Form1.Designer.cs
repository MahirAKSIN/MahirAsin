
namespace Telefon_Rehberi_V1
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
            this.dgv_kisiler = new System.Windows.Forms.DataGridView();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.rdb_kadin = new System.Windows.Forms.RadioButton();
            this.rdb_erkek = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.btn_duzelt = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kisiler
            // 
            this.dgv_kisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_kisiler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_kisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kisiler.Location = new System.Drawing.Point(12, 44);
            this.dgv_kisiler.Name = "dgv_kisiler";
            this.dgv_kisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kisiler.Size = new System.Drawing.Size(342, 343);
            this.dgv_kisiler.TabIndex = 0;
            this.dgv_kisiler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kisiler_CellEnter);
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.Color.LightGray;
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(466, 81);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(157, 22);
            this.txt_ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(355, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(355, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(355, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cinsiyet";
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.Color.LightGray;
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(466, 118);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(157, 22);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.Color.LightGray;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(466, 201);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(157, 22);
            this.txt_tel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(355, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_id.Location = new System.Drawing.Point(463, 43);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(68, 16);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "------------";
            // 
            // rdb_kadin
            // 
            this.rdb_kadin.AutoSize = true;
            this.rdb_kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_kadin.Location = new System.Drawing.Point(466, 163);
            this.rdb_kadin.Name = "rdb_kadin";
            this.rdb_kadin.Size = new System.Drawing.Size(65, 20);
            this.rdb_kadin.TabIndex = 3;
            this.rdb_kadin.TabStop = true;
            this.rdb_kadin.Text = "Kadin";
            this.rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // rdb_erkek
            // 
            this.rdb_erkek.AutoSize = true;
            this.rdb_erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_erkek.Location = new System.Drawing.Point(537, 163);
            this.rdb_erkek.Name = "rdb_erkek";
            this.rdb_erkek.Size = new System.Drawing.Size(66, 20);
            this.rdb_erkek.TabIndex = 3;
            this.rdb_erkek.TabStop = true;
            this.rdb_erkek.Text = "Erkek";
            this.rdb_erkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(355, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefon No";
            // 
            // btn_yeni
            // 
            this.btn_yeni.BackColor = System.Drawing.Color.Silver;
            this.btn_yeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_yeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_yeni.Location = new System.Drawing.Point(360, 229);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_yeni.Size = new System.Drawing.Size(263, 52);
            this.btn_yeni.TabIndex = 4;
            this.btn_yeni.Text = "YENI";
            this.btn_yeni.UseVisualStyleBackColor = false;
            // 
            // btn_duzelt
            // 
            this.btn_duzelt.BackColor = System.Drawing.Color.Silver;
            this.btn_duzelt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_duzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duzelt.Location = new System.Drawing.Point(360, 284);
            this.btn_duzelt.Name = "btn_duzelt";
            this.btn_duzelt.Size = new System.Drawing.Size(263, 49);
            this.btn_duzelt.TabIndex = 4;
            this.btn_duzelt.Text = "Duzelt";
            this.btn_duzelt.UseVisualStyleBackColor = false;
            this.btn_duzelt.Click += new System.EventHandler(this.btn_duzelt_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Silver;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(361, 336);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(263, 49);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "SIL";
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // txt_aranan
            // 
            this.txt_aranan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_aranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aranan.Location = new System.Drawing.Point(12, 12);
            this.txt_aranan.Name = "txt_aranan";
            this.txt_aranan.Size = new System.Drawing.Size(176, 22);
            this.txt_aranan.TabIndex = 1;
            // 
            // btn_ara
            // 
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Location = new System.Drawing.Point(246, 8);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(108, 29);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(633, 405);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_duzelt);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_yeni);
            this.Controls.Add(this.rdb_erkek);
            this.Controls.Add(this.rdb_kadin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_aranan);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.dgv_kisiler);
            this.Name = "Form1";
            this.Text = "Telefon Rehberi V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kisiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kisiler;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.RadioButton rdb_kadin;
        private System.Windows.Forms.RadioButton rdb_erkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.Button btn_duzelt;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.Button btn_ara;
    }
}

