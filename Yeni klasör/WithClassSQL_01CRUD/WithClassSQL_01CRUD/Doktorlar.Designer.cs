
namespace WithClassSQL_01CRUD
{
    partial class Doktorlar
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
            this.cmb_bolum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sicilno = new System.Windows.Forms.TextBox();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_bolum
            // 
            this.cmb_bolum.FormattingEnabled = true;
            this.cmb_bolum.Location = new System.Drawing.Point(326, 38);
            this.cmb_bolum.Name = "cmb_bolum";
            this.cmb_bolum.Size = new System.Drawing.Size(138, 21);
            this.cmb_bolum.TabIndex = 0;
            this.cmb_bolum.SelectedIndexChanged += new System.EventHandler(this.cmb_bolum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sicil NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label1";
            // 
            // txt_sicilno
            // 
            this.txt_sicilno.Location = new System.Drawing.Point(109, 43);
            this.txt_sicilno.Name = "txt_sicilno";
            this.txt_sicilno.Size = new System.Drawing.Size(115, 20);
            this.txt_sicilno.TabIndex = 2;
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Location = new System.Drawing.Point(109, 78);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(115, 20);
            this.txt_adsoyad.TabIndex = 2;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(109, 111);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(115, 20);
            this.txt_tel.TabIndex = 2;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(109, 147);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(115, 20);
            this.txt_mail.TabIndex = 2;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(109, 173);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(115, 58);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_adsoyad);
            this.Controls.Add(this.txt_sicilno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_bolum);
            this.Name = "Doktorlar";
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_bolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sicilno;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Button btn_kaydet;
    }
}