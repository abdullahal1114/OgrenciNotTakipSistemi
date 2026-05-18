using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrencinottakipsistemi
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=OgrenciNotTakip;Integrated Security=True;TrustServerCertificate=True");
        void Listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Temizle()
        {
            txtNo.Text = "";
            txtAd.Text = "";
            txtAd.Focus(); 
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Ogrenciler (OgrenciNo, OgrenciAdi) VALUES (@p1, @p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtNo.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Öğrenci başarıyla eklendi.");
            }
            catch (SqlException ex)
            {
                // 2627, SQL'de Unique Constraint (Benzersizlik) hatası kodudur
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Bu öğrenci numarası zaten kayıtlı! Lütfen farklı bir numara giriniz.");
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            finally
            {
                baglanti.Close();
                Listele();
                Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("DELETE FROM Ogrenciler WHERE OgrenciID = @p1", baglanti);
           
            komut.Parameters.AddWithValue("@p1", dataGridView1.CurrentRow.Cells[0].Value);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Öğrenci silindi!"); 
             Listele();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); 
            SqlCommand komut = new SqlCommand("UPDATE Ogrenciler SET OgrenciAdi=@p1, OgrenciNo=@p2 WHERE OgrenciID=@p3", baglanti);

            komut.Parameters.AddWithValue("@p1", txtAd.Text); 
            komut.Parameters.AddWithValue("@p2", txtNo.Text); 
            komut.Parameters.AddWithValue("@p3", dataGridView1.CurrentRow.Cells[0].Value); 

            komut.ExecuteNonQuery(); 
            baglanti.Close(); 

            MessageBox.Show("Öğrenci bilgileri güncellendi!"); 
            Listele();
            Temizle();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Close();
        }
    }
}
