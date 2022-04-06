
namespace form03_TemelKontroller
{
    partial class Form2
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
            this.txt_adSoyad = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.ist_Kisiler = new System.Windows.Forms.ListBox();
            this.btn_kisiSay = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.lbl_aranan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad";
            // 
            // txt_adSoyad
            // 
            this.txt_adSoyad.Location = new System.Drawing.Point(64, 5);
            this.txt_adSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_adSoyad.Name = "txt_adSoyad";
            this.txt_adSoyad.Size = new System.Drawing.Size(116, 22);
            this.txt_adSoyad.TabIndex = 0;
            this.txt_adSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_adSoyad_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(64, 30);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(117, 70);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // ist_Kisiler
            // 
            this.ist_Kisiler.FormattingEnabled = true;
            this.ist_Kisiler.ItemHeight = 16;
            this.ist_Kisiler.Location = new System.Drawing.Point(64, 103);
            this.ist_Kisiler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ist_Kisiler.Name = "ist_Kisiler";
            this.ist_Kisiler.Size = new System.Drawing.Size(116, 100);
            this.ist_Kisiler.TabIndex = 3;
            // 
            // btn_kisiSay
            // 
            this.btn_kisiSay.Location = new System.Drawing.Point(184, 30);
            this.btn_kisiSay.Name = "btn_kisiSay";
            this.btn_kisiSay.Size = new System.Drawing.Size(117, 70);
            this.btn_kisiSay.TabIndex = 5;
            this.btn_kisiSay.Text = "Kisi Sayisi";
            this.btn_kisiSay.UseVisualStyleBackColor = true;
            this.btn_kisiSay.Click += new System.EventHandler(this.btn_kisiSay_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(184, 151);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(117, 52);
            this.btn_ara.TabIndex = 5;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arama";
            // 
            // txt_arama
            // 
            this.txt_arama.Location = new System.Drawing.Point(184, 122);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(100, 22);
            this.txt_arama.TabIndex = 7;
            this.txt_arama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_arama_KeyPress);
            // 
            // lbl_aranan
            // 
            this.lbl_aranan.AutoSize = true;
            this.lbl_aranan.Location = new System.Drawing.Point(198, 151);
            this.lbl_aranan.Name = "lbl_aranan";
            this.lbl_aranan.Size = new System.Drawing.Size(0, 16);
            this.lbl_aranan.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.lbl_aranan);
            this.Controls.Add(this.txt_arama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_kisiSay);
            this.Controls.Add(this.ist_Kisiler);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_adSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.AutoSizeChanged += new System.EventHandler(this.btn_ekle_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_adSoyad;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListBox ist_Kisiler;
        private System.Windows.Forms.Button btn_kisiSay;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Label lbl_aranan;
    }
}