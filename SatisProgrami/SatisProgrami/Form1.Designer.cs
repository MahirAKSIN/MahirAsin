
namespace SatisProgrami
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_urunSec = new System.Windows.Forms.ComboBox();
            this.dtp_satisT = new System.Windows.Forms.DateTimePicker();
            this.dgv_satis = new System.Windows.Forms.DataGridView();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.btn_satis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_satis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Satis Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adet";
            // 
            // cmb_urunSec
            // 
            this.cmb_urunSec.FormattingEnabled = true;
            this.cmb_urunSec.Location = new System.Drawing.Point(82, 242);
            this.cmb_urunSec.Name = "cmb_urunSec";
            this.cmb_urunSec.Size = new System.Drawing.Size(121, 21);
            this.cmb_urunSec.TabIndex = 1;
            // 
            // dtp_satisT
            // 
            this.dtp_satisT.Location = new System.Drawing.Point(82, 268);
            this.dtp_satisT.Name = "dtp_satisT";
            this.dtp_satisT.Size = new System.Drawing.Size(200, 20);
            this.dtp_satisT.TabIndex = 2;
            // 
            // dgv_satis
            // 
            this.dgv_satis.AllowUserToAddRows = false;
            this.dgv_satis.AllowUserToDeleteRows = false;
            this.dgv_satis.AllowUserToResizeColumns = false;
            this.dgv_satis.AllowUserToResizeRows = false;
            this.dgv_satis.BackgroundColor = System.Drawing.Color.White;
            this.dgv_satis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_satis.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_satis.Location = new System.Drawing.Point(0, 0);
            this.dgv_satis.Name = "dgv_satis";
            this.dgv_satis.ReadOnly = true;
            this.dgv_satis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_satis.Size = new System.Drawing.Size(399, 236);
            this.dgv_satis.TabIndex = 3;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(82, 294);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(121, 20);
            this.txt_adet.TabIndex = 4;
            // 
            // btn_satis
            // 
            this.btn_satis.Location = new System.Drawing.Point(82, 320);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(121, 51);
            this.btn_satis.TabIndex = 5;
            this.btn_satis.Text = "SATIS";
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 375);
            this.Controls.Add(this.btn_satis);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.dgv_satis);
            this.Controls.Add(this.dtp_satisT);
            this.Controls.Add(this.cmb_urunSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_satis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_urunSec;
        private System.Windows.Forms.DateTimePicker dtp_satisT;
        private System.Windows.Forms.DataGridView dgv_satis;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Button btn_satis;
    }
}

