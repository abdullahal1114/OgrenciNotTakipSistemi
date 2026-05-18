using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrencinottakipsistemi
{
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=OgrenciNotTakip;Integrated Security=True;TrustServerCertificate=True");

        private void NotTemizle()
        {
            txtVize.Text = "";
            txtFinal.Text = "";
            txtBut.Text = "";
            cmbOgrenci.SelectedIndex = -1;
            cmbDers.SelectedIndex = -1;
            txtVize.Focus();
        }

        private void OgrencininDersleriniGetir()
        {
            
            if (cmbOgrenci.SelectedValue == null || cmbOgrenci.SelectedValue is DataRowView)
                return;

            int secilenOgrenciId = Convert.ToInt32(cmbOgrenci.SelectedValue);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                
                string sorgu = @"SELECT d.DersID, d.DersAdi 
                         FROM Notlar n 
                         INNER JOIN Dersler d ON n.DersID = d.DersID 
                         WHERE n.OgrenciID = @p1";

                SqlCommand komutDers = new SqlCommand(sorgu, baglanti);
                komutDers.Parameters.AddWithValue("@p1", secilenOgrenciId);

                SqlDataAdapter da2 = new SqlDataAdapter(komutDers);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                cmbDers.DisplayMember = "DersAdi";
                cmbDers.ValueMember = "DersID";
                cmbDers.DataSource = dt2;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                MessageBox.Show("Öğrencinin dersleri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnHesaplaVeKaydet_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtVize.Text) || string.IsNullOrEmpty(txtFinal.Text))
            {
                MessageBox.Show("Lütfen vize ve final notlarını giriniz!");
                return;
            }

           
            if (cmbOgrenci.SelectedValue == null || cmbDers.SelectedValue == null)
            {
                MessageBox.Show("Lütfen önce geçerli bir Öğrenci ve Ders seçiniz!");
                return;
            }

            double vize = Convert.ToDouble(txtVize.Text);
            double final = Convert.ToDouble(txtFinal.Text);
            double ortalama = 0;
            string durum = "";

           
            if (!string.IsNullOrEmpty(txtBut.Text))
            {
                double but = Convert.ToDouble(txtBut.Text);

               
                ortalama = (vize * 0.40) + (but * 0.60);

               
                if (but < 50)
                {
                    durum = "Kaldı";
                }
                else
                {
                    if (ortalama >= 50)
                    {
                        durum = "Geçti";
                    }
                    else
                    {
                        durum = "Kaldı";
                    }
                }
            }
            else
            {
               
                ortalama = (vize * 0.40) + (final * 0.60);

                
                if (final < 50)
                {
                    durum = "Kaldı";
                }
                else
                {
                    if (ortalama >= 50)
                    {
                        durum = "Geçti";
                    }
                    else
                    {
                        durum = "Kaldı";
                    }
                }
            }

           
            lblOrtalama.Text = "Ortalama: " + ortalama.ToString("0.00");

            try
            {
                baglanti.Open();

                string sorgu = @"UPDATE Notlar 
                         SET NotDegeri = @p3, Durum = @p4 
                         WHERE OgrenciID = @p1 AND DersID = @p2";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", cmbOgrenci.SelectedValue);
                komut.Parameters.AddWithValue("@p2", cmbDers.SelectedValue);
                komut.Parameters.AddWithValue("@p3", ortalama); 
                komut.Parameters.AddWithValue("@p4", durum);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show($"Hesaplandı: {ortalama:0.00}\nDurum: {durum}");

                btnNotListele.PerformClick();
                NotTemizle();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {

            
            baglanti.Open();
            SqlCommand komutOgrenci = new SqlCommand("SELECT OgrenciID, OgrenciAdi FROM Ogrenciler", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komutOgrenci);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cmbOgrenci.DisplayMember = "OgrenciAdi";
            cmbOgrenci.ValueMember = "OgrenciID";
            cmbOgrenci.DataSource = dt1;
            baglanti.Close();

            
            OgrencininDersleriniGetir();
        }

        private void btnNotListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT Notlar.NotID, Ogrenciler.OgrenciAdi, Dersler.DersAdi, Notlar.NotDegeri, Notlar.Durum FROM Notlar " +
                           "INNER JOIN Ogrenciler ON Notlar.OgrenciID = Ogrenciler.OgrenciID " +
                           "INNER JOIN Dersler ON Notlar.DersID = Dersler.DersID";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            NotTemizle();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Close();
        }

        private void cmbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrencininDersleriniGetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
