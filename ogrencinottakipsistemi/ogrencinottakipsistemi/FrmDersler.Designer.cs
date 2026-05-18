namespace ogrencinottakipsistemi
{
    partial class FrmDersler
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
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersListele = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı :";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(110, 98);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(100, 20);
            this.txtDersAd.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDersEkle.ForeColor = System.Drawing.Color.White;
            this.btnDersEkle.Location = new System.Drawing.Point(281, 190);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 3;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnDersSil.ForeColor = System.Drawing.Color.White;
            this.btnDersSil.Location = new System.Drawing.Point(381, 190);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(75, 23);
            this.btnDersSil.TabIndex = 4;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDersGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDersGuncelle.Location = new System.Drawing.Point(266, 228);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(101, 23);
            this.btnDersGuncelle.TabIndex = 5;
            this.btnDersGuncelle.Text = "Ders Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = false;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnDersListele
            // 
            this.btnDersListele.BackColor = System.Drawing.Color.SlateGray;
            this.btnDersListele.ForeColor = System.Drawing.Color.White;
            this.btnDersListele.Location = new System.Drawing.Point(381, 228);
            this.btnDersListele.Name = "btnDersListele";
            this.btnDersListele.Size = new System.Drawing.Size(75, 23);
            this.btnDersListele.TabIndex = 6;
            this.btnDersListele.Text = "Ders Listele";
            this.btnDersListele.UseVisualStyleBackColor = false;
            this.btnDersListele.Click += new System.EventHandler(this.btnDersListele_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Silver;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(29, 13);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Öğrenci Seç :";
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(110, 67);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(121, 21);
            this.cmbOgrenciler.TabIndex = 9;
            // 
            // FrmDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDersListele);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.label1);
            this.Name = "FrmDersler";
            this.Text = "FrmDersler";
            this.Load += new System.EventHandler(this.FrmDersler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnDersListele;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
    }
}