
namespace WithClassSQL_01CRUD
{
    partial class FormBolumEkle
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
            this.txt_bolumAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bolumekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_bolumAd
            // 
            this.txt_bolumAd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_bolumAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bolumAd.Location = new System.Drawing.Point(86, 12);
            this.txt_bolumAd.Name = "txt_bolumAd";
            this.txt_bolumAd.Size = new System.Drawing.Size(152, 27);
            this.txt_bolumAd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bolum Ad";
            // 
            // btn_bolumekle
            // 
            this.btn_bolumekle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bolumekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bolumekle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bolumekle.Location = new System.Drawing.Point(86, 43);
            this.btn_bolumekle.Name = "btn_bolumekle";
            this.btn_bolumekle.Size = new System.Drawing.Size(152, 44);
            this.btn_bolumekle.TabIndex = 5;
            this.btn_bolumekle.Text = "Bolum Ekle";
            this.btn_bolumekle.UseVisualStyleBackColor = false;
            this.btn_bolumekle.Click += new System.EventHandler(this.btn_bolumekle_Click);
            // 
            // FormBolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 101);
            this.Controls.Add(this.btn_bolumekle);
            this.Controls.Add(this.txt_bolumAd);
            this.Controls.Add(this.label1);
            this.Name = "FormBolumEkle";
            this.Text = "FormBolumEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBolumEkle_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bolumAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bolumekle;
    }
}