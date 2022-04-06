
namespace TelefobRehberi_V2
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
            this.btn_yeniKayit = new System.Windows.Forms.Button();
            this.btn_liste = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yeniKayit
            // 
            this.btn_yeniKayit.BackColor = System.Drawing.Color.Gray;
            this.btn_yeniKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yeniKayit.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeniKayit.Location = new System.Drawing.Point(12, 12);
            this.btn_yeniKayit.Name = "btn_yeniKayit";
            this.btn_yeniKayit.Size = new System.Drawing.Size(132, 113);
            this.btn_yeniKayit.TabIndex = 0;
            this.btn_yeniKayit.Text = "Yeni Kayit";
            this.btn_yeniKayit.UseVisualStyleBackColor = false;
            this.btn_yeniKayit.Click += new System.EventHandler(this.btn_yeniKayit_Click);
            // 
            // btn_liste
            // 
            this.btn_liste.BackColor = System.Drawing.Color.Gray;
            this.btn_liste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_liste.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_liste.Location = new System.Drawing.Point(12, 131);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(132, 113);
            this.btn_liste.TabIndex = 0;
            this.btn_liste.Text = "Liste";
            this.btn_liste.UseVisualStyleBackColor = false;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Gray;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(12, 250);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(132, 113);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.Text = "Cikis";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 370);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_liste);
            this.Controls.Add(this.btn_yeniKayit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Rehberi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yeniKayit;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.Button btn_cikis;
    }
}

