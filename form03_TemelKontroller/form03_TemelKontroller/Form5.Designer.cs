
namespace form03_TemelKontroller
{
    partial class Form5
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
            this.lbl_sayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdb_cift = new System.Windows.Forms.RadioButton();
            this.rdb_tek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sayi
            // 
            this.lbl_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi.ForeColor = System.Drawing.Color.Teal;
            this.lbl_sayi.Location = new System.Drawing.Point(294, 94);
            this.lbl_sayi.Name = "lbl_sayi";
            this.lbl_sayi.Size = new System.Drawing.Size(250, 240);
            this.lbl_sayi.TabIndex = 0;
            this.lbl_sayi.Text = "100";
            this.lbl_sayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_sayi.Click += new System.EventHandler(this.lbl_sayi_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdb_cift
            // 
            this.rdb_cift.AutoSize = true;
            this.rdb_cift.Location = new System.Drawing.Point(683, 22);
            this.rdb_cift.Name = "rdb_cift";
            this.rdb_cift.Size = new System.Drawing.Size(63, 17);
            this.rdb_cift.TabIndex = 1;
            this.rdb_cift.TabStop = true;
            this.rdb_cift.Text = "Cift Sayi";
            this.rdb_cift.UseVisualStyleBackColor = true;
            // 
            // rdb_tek
            // 
            this.rdb_tek.AutoSize = true;
            this.rdb_tek.Location = new System.Drawing.Point(683, 57);
            this.rdb_tek.Name = "rdb_tek";
            this.rdb_tek.Size = new System.Drawing.Size(67, 17);
            this.rdb_tek.TabIndex = 2;
            this.rdb_tek.TabStop = true;
            this.rdb_tek.Text = "Tek Sayi";
            this.rdb_tek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(592, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 216);
            this.label1.TabIndex = 3;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb_tek);
            this.Controls.Add(this.rdb_cift);
            this.Controls.Add(this.lbl_sayi);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdb_cift;
        private System.Windows.Forms.RadioButton rdb_tek;
        private System.Windows.Forms.Label label1;
    }
}