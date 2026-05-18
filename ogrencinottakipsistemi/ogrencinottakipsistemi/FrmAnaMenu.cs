using ogrencinottakipsistemi;
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
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
            this.Hide();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci frOgr = new FrmOgrenci();
            frOgr.Show();
            this.Hide();

        }

        private void btnNotIslemleri_Click(object sender, EventArgs e)
        {
            FrmNotlar frNot = new FrmNotlar();
            frNot.Show();
            this.Hide();
        }
    }
}



    