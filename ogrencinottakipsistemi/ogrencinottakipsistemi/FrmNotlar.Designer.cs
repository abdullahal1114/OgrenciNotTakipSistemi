namespace ogrencinottakipsistemi
{
    partial class FrmNotlar
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
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.btnHesaplaVeKaydet = new System.Windows.Forms.Button();
            this.btnNotListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(92, 75);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(121, 21);
            this.cmbOgrenci.TabIndex = 0;
            this.cmbOgrenci.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenci_SelectedIndexChanged);
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(92, 104);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 21);
            this.cmbDers.TabIndex = 1;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(92, 135);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 20);
            this.txtVize.TabIndex = 2;
            // 
            // btnHesaplaVeKaydet
            // 
            this.btnHesaplaVeKaydet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHesaplaVeKaydet.ForeColor = System.Drawing.Color.White;
            this.btnHesaplaVeKaydet.Location = new System.Drawing.Point(276, 207);
            this.btnHesaplaVeKaydet.Name = "btnHesaplaVeKaydet";
            this.btnHesaplaVeKaydet.Size = new System.Drawing.Size(130, 24);
            this.btnHesaplaVeKaydet.TabIndex = 3;
            this.btnHesaplaVeKaydet.Text = "Hesapla ve Kaydet";
            this.btnHesaplaVeKaydet.UseVisualStyleBackColor = false;
            this.btnHesaplaVeKaydet.Click += new System.EventHandler(this.btnHesaplaVeKaydet_Click);
            // 
            // btnNotListele
            // 
            this.btnNotListele.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNotListele.ForeColor = System.Drawing.Color.White;
            this.btnNotListele.Location = new System.Drawing.Point(441, 208);
            this.btnNotListele.Name = "btnNotListele";
            this.btnNotListele.Size = new System.Drawing.Size(75, 23);
            this.btnNotListele.TabIndex = 4;
            this.btnNotListele.Text = "Not Listele";
            this.btnNotListele.UseVisualStyleBackColor = false;
            this.btnNotListele.Click += new System.EventHandler(this.btnNotListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğrenci :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ders :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vize :";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Silver;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(30, 13);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Final :";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(92, 163);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 11;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(59, 198);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(0, 13);
            this.lblOrtalama.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Büt : ";
            // 
            // txtBut
            // 
            this.txtBut.Location = new System.Drawing.Point(92, 194);
            this.txtBut.Name = "txtBut";
            this.txtBut.Size = new System.Drawing.Size(100, 20);
            this.txtBut.TabIndex = 14;
            this.txtBut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNotListele);
            this.Controls.Add(this.btnHesaplaVeKaydet);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.cmbOgrenci);
            this.Name = "FrmNotlar";
            this.Text = "FrmNotlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Button btnHesaplaVeKaydet;
        private System.Windows.Forms.Button btnNotListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBut;
    }
}