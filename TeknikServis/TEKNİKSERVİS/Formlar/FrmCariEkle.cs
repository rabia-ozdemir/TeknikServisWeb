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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }


        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        int secilen;
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir,
                                                 }).ToList();
        }
        private void ımageSlider1_Click(object sender, EventArgs e)
        {

        }

        private void TxtSatisFiyat_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (TxtCariAd.Text != "" && TxtSoyad.Text != "" && TxtCariAd.Text.Length <= 30)
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtCariAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.TELEFON = TxtTelefon.Text;
                t.MAIL = TxtMail.Text;
                t.IL = lookUpEdit1.Text;
                t.ILCE = lookUpEdit2.Text;
                t.ADRES = TxtAdres.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void textEdit9_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLILCELER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir
                                                 }).Where(z => z.sehir == secilen).ToList();

        }
    }
}
