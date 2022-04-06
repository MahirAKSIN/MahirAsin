
namespace TelefobRehberi_V2
{
    partial class ListeForm
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
            this.dgv_kisi = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_duzelt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbm_cinsiyetL = new System.Windows.Forms.ComboBox();
            this.txt_telL = new System.Windows.Forms.TextBox();
            this.txt_soyadL = new System.Windows.Forms.TextBox();
            this.txt_adL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_idL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kisi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_kisi
            // 
            this.dgv_kisi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_kisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_kisi.Location = new System.Drawing.Point(0, 0);
            this.dgv_kisi.Name = "dgv_kisi";
            this.dgv_kisi.Size = new System.Drawing.Size(611, 209);
            this.dgv_kisi.TabIndex = 0;
            this.dgv_kisi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kisi_CellEnter);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Silver;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(0, 272);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 48);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Sil";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_duzelt
            // 
            this.btn_duzelt.BackColor = System.Drawing.Color.Silver;
            this.btn_duzelt.Location = new System.Drawing.Point(0, 213);
            this.btn_duzelt.Name = "btn_duzelt";
            this.btn_duzelt.Size = new System.Drawing.Size(129, 51);
            this.btn_duzelt.TabIndex = 1;
            this.btn_duzelt.Text = "Duzelt";
            this.btn_duzelt.UseVisualStyleBackColor = false;
            this.btn_duzelt.Click += new System.EventHandler(this.btn_duzelt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbm_cinsiyetL);
            this.panel1.Controls.Add(this.txt_telL);
            this.panel1.Controls.Add(this.txt_soyadL);
            this.panel1.Controls.Add(this.txt_adL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_idL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(135, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 164);
            this.panel1.TabIndex = 2;
            // 
            // cbm_cinsiyetL
            // 
            this.cbm_cinsiyetL.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbm_cinsiyetL.FormattingEnabled = true;
            this.cbm_cinsiyetL.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cbm_cinsiyetL.Location = new System.Drawing.Point(114, 101);
            this.cbm_cinsiyetL.Name = "cbm_cinsiyetL";
            this.cbm_cinsiyetL.Size = new System.Drawing.Size(95, 26);
            this.cbm_cinsiyetL.TabIndex = 10;
            // 
            // txt_telL
            // 
            this.txt_telL.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telL.Location = new System.Drawing.Point(114, 133);
            this.txt_telL.Name = "txt_telL";
            this.txt_telL.Size = new System.Drawing.Size(160, 26);
            this.txt_telL.TabIndex = 11;
            // 
            // txt_soyadL
            // 
            this.txt_soyadL.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyadL.Location = new System.Drawing.Point(114, 69);
            this.txt_soyadL.Name = "txt_soyadL";
            this.txt_soyadL.Size = new System.Drawing.Size(160, 26);
            this.txt_soyadL.TabIndex = 9;
            // 
            // txt_adL
            // 
            this.txt_adL.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adL.Location = new System.Drawing.Point(113, 37);
            this.txt_adL.Name = "txt_adL";
            this.txt_adL.Size = new System.Drawing.Size(160, 26);
            this.txt_adL.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad";
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Silver;
            this.btn_kapat.Location = new System.Drawing.Point(0, 328);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(129, 49);
            this.btn_kapat.TabIndex = 13;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_idL
            // 
            this.lbl_idL.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_idL.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_idL.Location = new System.Drawing.Point(4, 3);
            this.lbl_idL.Name = "lbl_idL";
            this.lbl_idL.Size = new System.Drawing.Size(10, 22);
            this.lbl_idL.TabIndex = 8;
            // 
            // ListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_duzelt);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_kisi);
            this.Name = "ListeForm";
            this.Text = "Liste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListeForm_FormClosing);
            this.Load += new System.EventHandler(this.ListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kisi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kisi;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_duzelt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbm_cinsiyetL;
        private System.Windows.Forms.TextBox txt_telL;
        private System.Windows.Forms.TextBox txt_soyadL;
        private System.Windows.Forms.TextBox txt_adL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_idL;
    }
}