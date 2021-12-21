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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
            TBLADMIN t = new TBLADMIN();
            t.KULLANICIAD = TxtAd.Text;
            t.SIFRE = TxtSifre.Text;
            db.TBLADMIN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Başarıyla Kaydedildi");

            FrmLogin frmlgn = new FrmLogin();
            frmlgn.Show();
            this.Hide();
        }
    }
}
