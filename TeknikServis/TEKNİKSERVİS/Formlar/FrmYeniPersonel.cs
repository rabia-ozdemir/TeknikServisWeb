using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS.Formlar
{
    public partial class FrmYeniPersonel : Form
    {
        public FrmYeniPersonel()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.TELEFON = TxtTelefon.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmYeniPersonel_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

        }
    }
}
