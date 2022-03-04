
namespace WithClassSQL_01CRUD
{
    partial class AnaForm
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
            this.btn_hastalar = new System.Windows.Forms.Button();
            this.btn_bolumlereGit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hastalar
            // 
            this.btn_hastalar.Location = new System.Drawing.Point(12, 3);
            this.btn_hastalar.Name = "btn_hastalar";
            this.btn_hastalar.Size = new System.Drawing.Size(120, 61);
            this.btn_hastalar.TabIndex = 0;
            this.btn_hastalar.Text = "Hastalar";
            this.btn_hastalar.UseVisualStyleBackColor = true;
            this.btn_hastalar.Click += new System.EventHandler(this.btn_hastalar_Click);
            // 
            // btn_bolumlereGit
            // 
            this.btn_bolumlereGit.Location = new System.Drawing.Point(13, 70);
            this.btn_bolumlereGit.Name = "btn_bolumlereGit";
            this.btn_bolumlereGit.Size = new System.Drawing.Size(120, 61);
            this.btn_bolumlereGit.TabIndex = 0;
            this.btn_bolumlereGit.Text = "Bolumler";
            this.btn_bolumlereGit.UseVisualStyleBackColor = true;
            this.btn_bolumlereGit.Click += new System.EventHandler(this.btn_bolumlereGit_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 361);
            this.Controls.Add(this.btn_bolumlereGit);
            this.Controls.Add(this.btn_hastalar);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.AnaForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_hastalar;
        private System.Windows.Forms.Button btn_bolumlereGit;
    }
}

