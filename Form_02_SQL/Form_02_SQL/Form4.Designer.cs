
namespace Form_02_SQL
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_userNmae = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_pBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(109, 41);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // txt_userNmae
            // 
            this.txt_userNmae.Location = new System.Drawing.Point(109, 12);
            this.txt_userNmae.Name = "txt_userNmae";
            this.txt_userNmae.Size = new System.Drawing.Size(100, 20);
            this.txt_userNmae.TabIndex = 1;
            this.txt_userNmae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_userNmae_KeyPress);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(108, 64);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(100, 77);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "GIRIS";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            this.btn_giris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_giris_KeyPress);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(12, 156);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(35, 13);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_pBar
            // 
            this.lbl_pBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_pBar.Location = new System.Drawing.Point(12, 177);
            this.lbl_pBar.Name = "lbl_pBar";
            this.lbl_pBar.Size = new System.Drawing.Size(10, 23);
            this.lbl_pBar.TabIndex = 4;
            this.lbl_pBar.Text = "label3";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 199);
            this.Controls.Add(this.lbl_pBar);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_userNmae);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_userNmae;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_pBar;
    }
}