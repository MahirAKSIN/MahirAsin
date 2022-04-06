
namespace WithClassSQL_01CRUD
{
    partial class FormBolumler
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
            this.txt_bolumAd = new System.Windows.Forms.TextBox();
            this.dgv_bolumler = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_bolumekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bolumler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bolum Ad";
            // 
            // txt_bolumAd
            // 
            this.txt_bolumAd.Location = new System.Drawing.Point(76, 18);
            this.txt_bolumAd.Name = "txt_bolumAd";
            this.txt_bolumAd.Size = new System.Drawing.Size(100, 20);
            this.txt_bolumAd.TabIndex = 2;
            this.txt_bolumAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_bolumler
            // 
            this.dgv_bolumler.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bolumler.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_bolumler.Location = new System.Drawing.Point(182, 0);
            this.dgv_bolumler.Name = "dgv_bolumler";
            this.dgv_bolumler.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_bolumler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bolumler.Size = new System.Drawing.Size(276, 235);
            this.dgv_bolumler.TabIndex = 3;
            this.dgv_bolumler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bolumler_CellEnter);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guncelle.Location = new System.Drawing.Point(20, 44);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(76, 44);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "GUNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Location = new System.Drawing.Point(98, 44);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(76, 44);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_bolumekle
            // 
            this.btn_bolumekle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bolumekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bolumekle.Location = new System.Drawing.Point(19, 90);
            this.btn_bolumekle.Name = "btn_bolumekle";
            this.btn_bolumekle.Size = new System.Drawing.Size(76, 44);
            this.btn_bolumekle.TabIndex = 4;
            this.btn_bolumekle.Text = "Bolum Ekle";
            this.btn_bolumekle.UseVisualStyleBackColor = false;
            this.btn_bolumekle.Click += new System.EventHandler(this.btn_bolumekle_Click);
            // 
            // FormBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 235);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_bolumekle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.dgv_bolumler);
            this.Controls.Add(this.txt_bolumAd);
            this.Controls.Add(this.label1);
            this.Name = "FormBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBolumler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBolumler_FormClosing);
            this.Load += new System.EventHandler(this.FormBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bolumler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bolumAd;
        private System.Windows.Forms.DataGridView dgv_bolumler;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_bolumekle;
    }
}