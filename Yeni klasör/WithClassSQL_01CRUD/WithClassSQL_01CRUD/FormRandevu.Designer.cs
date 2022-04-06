
namespace WithClassSQL_01CRUD
{
    partial class FormRandevu
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
            this.dgv_randevu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_bolum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.list_doktorlar = new System.Windows.Forms.ListBox();
            this.btn_randevu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_saat = new System.Windows.Forms.DateTimePicker();
            this.txt_arananHasta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_randevu
            // 
            this.dgv_randevu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_randevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_randevu.Location = new System.Drawing.Point(4, 9);
            this.dgv_randevu.Name = "dgv_randevu";
            this.dgv_randevu.Size = new System.Drawing.Size(391, 310);
            this.dgv_randevu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(401, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bolum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(401, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // cmb_bolum
            // 
            this.cmb_bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_bolum.FormattingEnabled = true;
            this.cmb_bolum.Location = new System.Drawing.Point(492, 13);
            this.cmb_bolum.Name = "cmb_bolum";
            this.cmb_bolum.Size = new System.Drawing.Size(162, 24);
            this.cmb_bolum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(401, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doktor Sec";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_tarih.Location = new System.Drawing.Point(492, 235);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(162, 22);
            this.dtp_tarih.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(409, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "RTarihi";
            // 
            // list_doktorlar
            // 
            this.list_doktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_doktorlar.FormattingEnabled = true;
            this.list_doktorlar.ItemHeight = 16;
            this.list_doktorlar.Location = new System.Drawing.Point(492, 76);
            this.list_doktorlar.Name = "list_doktorlar";
            this.list_doktorlar.Size = new System.Drawing.Size(162, 100);
            this.list_doktorlar.TabIndex = 5;
            // 
            // btn_randevu
            // 
            this.btn_randevu.BackColor = System.Drawing.Color.White;
            this.btn_randevu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_randevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevu.Location = new System.Drawing.Point(492, 261);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(162, 58);
            this.btn_randevu.TabIndex = 6;
            this.btn_randevu.Text = "Randevu Kaydet";
            this.btn_randevu.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(409, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtp_saat
            // 
            this.dtp_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_saat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_saat.Location = new System.Drawing.Point(492, 200);
            this.dtp_saat.Name = "dtp_saat";
            this.dtp_saat.Size = new System.Drawing.Size(87, 22);
            this.dtp_saat.TabIndex = 4;
            // 
            // txt_arananHasta
            // 
            this.txt_arananHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_arananHasta.Location = new System.Drawing.Point(492, 45);
            this.txt_arananHasta.Name = "txt_arananHasta";
            this.txt_arananHasta.Size = new System.Drawing.Size(162, 22);
            this.txt_arananHasta.TabIndex = 7;
            // 
            // FormRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 341);
            this.Controls.Add(this.txt_arananHasta);
            this.Controls.Add(this.btn_randevu);
            this.Controls.Add(this.list_doktorlar);
            this.Controls.Add(this.dtp_saat);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.cmb_bolum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_randevu);
            this.Name = "FormRandevu";
            this.Text = "Randevu Ver";
            this.Load += new System.EventHandler(this.FormRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_randevu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_bolum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_doktorlar;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_saat;
        private System.Windows.Forms.TextBox txt_arananHasta;
    }
}