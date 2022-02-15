
namespace form_01
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
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_cıkarma = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(59, 12);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi1.TabIndex = 0;
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(59, 38);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi2.TabIndex = 0;
            // 
            // btn_topla
            // 
            this.btn_topla.BackColor = System.Drawing.Color.Red;
            this.btn_topla.ForeColor = System.Drawing.Color.Yellow;
            this.btn_topla.Location = new System.Drawing.Point(59, 97);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(100, 50);
            this.btn_topla.TabIndex = 1;
            this.btn_topla.Text = "TOPLA";
            this.btn_topla.UseVisualStyleBackColor = false;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayi 1 -->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayi 2 -->";
            // 
            // lbl_result
            // 
            this.lbl_result.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_result.ForeColor = System.Drawing.Color.Red;
            this.lbl_result.Location = new System.Drawing.Point(59, 68);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(100, 23);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "_________";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cıkarma
            // 
            this.btn_cıkarma.BackColor = System.Drawing.Color.Red;
            this.btn_cıkarma.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cıkarma.Location = new System.Drawing.Point(59, 153);
            this.btn_cıkarma.Name = "btn_cıkarma";
            this.btn_cıkarma.Size = new System.Drawing.Size(100, 50);
            this.btn_cıkarma.TabIndex = 1;
            this.btn_cıkarma.Text = "CIKARMA";
            this.btn_cıkarma.UseVisualStyleBackColor = false;
            this.btn_cıkarma.Click += new System.EventHandler(this.btn_cıkarma_Click);
            // 
            // btn_carpma
            // 
            this.btn_carpma.BackColor = System.Drawing.Color.Red;
            this.btn_carpma.ForeColor = System.Drawing.Color.Yellow;
            this.btn_carpma.Location = new System.Drawing.Point(59, 209);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(100, 50);
            this.btn_carpma.TabIndex = 1;
            this.btn_carpma.Text = "CARPMA";
            this.btn_carpma.UseVisualStyleBackColor = false;
            this.btn_carpma.Click += new System.EventHandler(this.btn_carpma_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.BackColor = System.Drawing.Color.Red;
            this.btn_bolme.ForeColor = System.Drawing.Color.Yellow;
            this.btn_bolme.Location = new System.Drawing.Point(59, 265);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(100, 50);
            this.btn_bolme.TabIndex = 1;
            this.btn_bolme.Text = "BOLME";
            this.btn_bolme.UseVisualStyleBackColor = false;
            this.btn_bolme.Click += new System.EventHandler(this.btn_bolme_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 339);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_carpma);
            this.Controls.Add(this.btn_cıkarma);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.txt_sayi1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iki Sayiyi Toplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_cıkarma;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Button btn_bolme;
    }
}