using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "1234")
            {
                FrmAnaMenu anaMenu = new FrmAnaMenu(); 
                anaMenu.Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!"); 
    }
        }
    }
}
