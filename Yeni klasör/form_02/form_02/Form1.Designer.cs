
namespace form_02
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
            this.btn_basla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tahminSayi = new System.Windows.Forms.TextBox();
            this.txt_arananSayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_msj = new System.Windows.Forms.Label();
            this.btn_tahminEt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_can = new System.Windows.Forms.TextBox();
            this.txt_puan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.Silver;
            this.btn_basla.Location = new System.Drawing.Point(120, 40);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(112, 46);
            this.btn_basla.TabIndex = 0;
            this.btn_basla.Text = "BASLA";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayi Tahmin Oynu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(4, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahmin Gir  -->";
            // 
            // txt_tahminSayi
            // 
            this.txt_tahminSayi.BackColor = System.Drawing.Color.Silver;
            this.txt_tahminSayi.Location = new System.Drawing.Point(120, 92);
            this.txt_tahminSayi.Name = "txt_tahminSayi";
            this.txt_tahminSayi.Size = new System.Drawing.Size(112, 20);
            this.txt_tahminSayi.TabIndex = 1;
            // 
            // txt_arananSayi
            // 
            this.txt_arananSayi.BackColor = System.Drawing.Color.Silver;
            this.txt_arananSayi.Location = new System.Drawing.Point(120, 119);
            this.txt_arananSayi.Name = "txt_arananSayi";
            this.txt_arananSayi.Size = new System.Drawing.Size(112, 20);
            this.txt_arananSayi.TabIndex = 2;
            this.txt_arananSayi.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(0, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aranan Sayi -->";
            // 
            // lbl_msj
            // 
            this.lbl_msj.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_msj.Location = new System.Drawing.Point(9, 196);
            this.lbl_msj.Name = "lbl_msj";
            this.lbl_msj.Size = new System.Drawing.Size(223, 50);
            this.lbl_msj.TabIndex = 4;
            this.lbl_msj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_tahminEt
            // 
            this.btn_tahminEt.BackColor = System.Drawing.Color.Silver;
            this.btn_tahminEt.Location = new System.Drawing.Point(120, 146);
            this.btn_tahminEt.Name = "btn_tahminEt";
            this.btn_tahminEt.Size = new System.Drawing.Size(112, 47);
            this.btn_tahminEt.TabIndex = 3;
            this.btn_tahminEt.Text = "Tahmin Et";
            this.btn_tahminEt.UseVisualStyleBackColor = false;
            this.btn_tahminEt.Click += new System.EventHandler(this.btn_tahminEt_Click);
            this.btn_tahminEt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_tahminEt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Can";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(46, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Puan";
            // 
            // txt_can
            // 
            this.txt_can.BackColor = System.Drawing.Color.Silver;
            this.txt_can.Location = new System.Drawing.Point(7, 66);
            this.txt_can.Name = "txt_can";
            this.txt_can.Size = new System.Drawing.Size(35, 20);
            this.txt_can.TabIndex = 5;
            // 
            // txt_puan
            // 
            this.txt_puan.BackColor = System.Drawing.Color.Silver;
            this.txt_puan.Location = new System.Drawing.Point(48, 66);
            this.txt_puan.Name = "txt_puan";
            this.txt_puan.Size = new System.Drawing.Size(35, 20);
            this.txt_puan.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(236, 252);
            this.Controls.Add(this.txt_puan);
            this.Controls.Add(this.txt_can);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_tahminEt);
            this.Controls.Add(this.lbl_msj);
            this.Controls.Add(this.txt_arananSayi);
            this.Controls.Add(this.txt_tahminSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_basla);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun oynikayak mi ha?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tahminSayi;
        private System.Windows.Forms.TextBox txt_arananSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_msj;
        private System.Windows.Forms.Button btn_tahminEt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_can;
        private System.Windows.Forms.TextBox txt_puan;
    }
}

