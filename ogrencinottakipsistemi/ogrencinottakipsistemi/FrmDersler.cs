using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrencinottakipsistemi
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=OgrenciNotTakip;Integrated Security=True;TrustServerCertificate=True");
        void DersListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DersTemizle()
        {
            txtDersAd.Text = "";
            txtDersAd.Focus(); 
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            
            if (cmbOgrenciler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçiniz!");
                return;
            }
            int secilenOgrenciId = Convert.ToInt32(cmbOgrenciler.SelectedValue);

            
            string girilenDersAdi = txtDersAd.Text.Trim();
            if (string.IsNullOrEmpty(girilenDersAdi))
            {
                MessageBox.Show("Lütfen bir ders adı giriniz!");
                return;
            }

            baglanti.Open();

            int dersId = 0;

           
            SqlCommand dersKontrolKomut = new SqlCommand("SELECT DersID FROM Dersler WHERE LOWER(DersAdi) = LOWER(@p1)", baglanti);
            dersKontrolKomut.Parameters.AddWithValue("@p1", girilenDersAdi);
            object dersIdSonuc = dersKontrolKomut.ExecuteScalar();

            if (dersIdSonuc != null)
            {
                
                dersId = Convert.ToInt32(dersIdSonuc);
            }
            else
            {
                
                SqlCommand dersEkleKomut = new SqlCommand("INSERT INTO Dersler (DersAdi) VALUES (@p1); SELECT SCOPE_IDENTITY();", baglanti);
                dersEkleKomut.Parameters.AddWithValue("@p1", girilenDersAdi);
                dersId = Convert.ToInt32(dersEkleKomut.ExecuteScalar());
            }

            
            SqlCommand ogrenciDersKontrol = new SqlCommand("SELECT COUNT(*) FROM Notlar WHERE OgrenciID = @o1 AND DersID = @d1", baglanti);
            ogrenciDersKontrol.Parameters.AddWithValue("@o1", secilenOgrenciId);
            ogrenciDersKontrol.Parameters.AddWithValue("@d1", dersId);
            int varMi = Convert.ToInt32(ogrenciDersKontrol.ExecuteScalar());

            if (varMi > 0)
            {
                MessageBox.Show("Bu ders bu öğrenciye zaten eklenmiş!");
                baglanti.Close();
                return;
            }

            
            SqlCommand notlarEkleKomut = new SqlCommand("INSERT INTO Notlar (OgrenciID, DersID, NotDegeri, Durum) VALUES (@o2, @d2, 0, 'Kayıtlı')", baglanti);
            notlarEkleKomut.Parameters.AddWithValue("@o2", secilenOgrenciId);
            notlarEkleKomut.Parameters.AddWithValue("@d2", dersId);
            notlarEkleKomut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show($"{girilenDersAdi} dersi seçilen öğrenciye başarıyla tanımlandı!");

            
            DersListele();
            DersTemizle();
        }
        

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
            SqlCommand komut = new SqlCommand("UPDATE Dersler SET DersAdi=@p1 WHERE DersID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtDersAd.Text);
            komut.Parameters.AddWithValue("@p2", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders başarıyla güncellendi!");
            DersListele();
            DersTemizle();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("DELETE FROM Dersler WHERE DersID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders silindi!");
            DersListele();
            DersTemizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtDersAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDersListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            DersTemizle();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Close();
        }

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

               
                SqlCommand komut = new SqlCommand("SELECT OgrenciID, OgrenciAdi FROM Ogrenciler", baglanti);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbOgrenciler.DataSource = dt;

               
                cmbOgrenciler.DisplayMember = "OgrenciAdi";

                
                cmbOgrenciler.ValueMember = "OgrenciID";

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                MessageBox.Show("Öğrenciler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
    }

