namespace ogrencinottakipsistemi
{
    partial class FrmAnaMenu
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
            this.btnOgrenciIslemleri = new System.Windows.Forms.Button();
            this.btnDersIslemleri = new System.Windows.Forms.Button();
            this.btnNotIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciIslemleri
            // 
            this.btnOgrenciIslemleri.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOgrenciIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciIslemleri.Location = new System.Drawing.Point(54, 52);
            this.btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            this.btnOgrenciIslemleri.Size = new System.Drawing.Size(188, 40);
            this.btnOgrenciIslemleri.TabIndex = 0;
            this.btnOgrenciIslemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btnOgrenciIslemleri.UseVisualStyleBackColor = false;
            this.btnOgrenciIslemleri.Click += new System.EventHandler(this.btnOgrenciIslemleri_Click);
            // 
            // btnDersIslemleri
            // 
            this.btnDersIslemleri.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDersIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnDersIslemleri.Location = new System.Drawing.Point(54, 96);
            this.btnDersIslemleri.Name = "btnDersIslemleri";
            this.btnDersIslemleri.Size = new System.Drawing.Size(188, 40);
            this.btnDersIslemleri.TabIndex = 1;
            this.btnDersIslemleri.Text = "DERS İŞLEMLERİ";
            this.btnDersIslemleri.UseVisualStyleBackColor = false;
            this.btnDersIslemleri.Click += new System.EventHandler(this.btnDersIslemleri_Click);
            // 
            // btnNotIslemleri
            // 
            this.btnNotIslemleri.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNotIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnNotIslemleri.Location = new System.Drawing.Point(54, 142);
            this.btnNotIslemleri.Name = "btnNotIslemleri";
            this.btnNotIslemleri.Size = new System.Drawing.Size(188, 62);
            this.btnNotIslemleri.TabIndex = 2;
            this.btnNotIslemleri.Text = "NOT İŞLEMLERİ  HESAPLAMA";
            this.btnNotIslemleri.UseVisualStyleBackColor = false;
            this.btnNotIslemleri.Click += new System.EventHandler(this.btnNotIslemleri_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNotIslemleri);
            this.Controls.Add(this.btnDersIslemleri);
            this.Controls.Add(this.btnOgrenciIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Takip Sistemi - Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciIslemleri;
        private System.Windows.Forms.Button btnDersIslemleri;
        private System.Windows.Forms.Button btnNotIslemleri;
    }
}