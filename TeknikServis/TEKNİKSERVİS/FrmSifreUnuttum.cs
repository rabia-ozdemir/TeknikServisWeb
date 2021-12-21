using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS
{
    public partial class FrmSifreUnuttum : Form
    {
        public FrmSifreUnuttum()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLADMIN.Find(id);
            deger.KULLANICIAD = TxtAd.Text;
            deger.SIFRE = TxtSifre.Text;
            db.SaveChanges();
            MessageBox.Show("Şifre Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            FrmLogin frmlgn = new FrmLogin();
            frmlgn.Show();
            this.Hide();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
