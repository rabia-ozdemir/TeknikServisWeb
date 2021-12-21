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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        int secilen;

        void liste()
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON,
                               u.IL,
                               u.ILCE
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            liste();

            labelControl12.Text = db.TBLCARI.Count().ToString();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir,
                                                 }).ToList();

            labelControl16.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl18.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
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
            liste();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Tekrar Deneyin");
            }
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCariID.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtCariID.Text);
            var deger = db.TBLCARI.Find(id);
            deger.AD = TxtCariAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.TELEFON = TxtTelefon.Text;
            deger.MAIL = TxtMail.Text;
            deger.IL = lookUpEdit1.Text;
            deger.ILCE = lookUpEdit2.Text;
            deger.ADRES = TxtAdres.Text;
            db.TBLCARI.Add(deger);
            db.SaveChanges(); db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtCariID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtCariAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
                TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
                lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
                }
            catch (Exception)
            {
                MessageBox.Show("Hata Boş Veya Hatalı Karakter Var");
            }
        }
    }
}
