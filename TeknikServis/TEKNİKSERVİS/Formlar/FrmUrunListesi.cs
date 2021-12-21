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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        void metot1()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORİ = u.TBLKATEGORI.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT

                           };
            gridControl1.DataSource = degerler.ToList();

        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //Listeleme ToList Add Remove
            //var degerler = db.TBLURUN.ToList();
            metot1();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlısFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.DURUM = false;
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //var degerler = db.TBLURUN.ToList();
            //gridControl1.DataSource = degerler;
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try { 
            TxtUrunID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAlısFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
              }
            catch (Exception)
            {
                MessageBox.Show("Hata Boş Veya Hatalı Karakter Var");
            }
            }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtUrunID.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtUrunID.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TxtUrunAd.Text;
            deger.STOK = short.Parse(TxtStok.Text);
            deger.MARKA = TxtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(TxtAlısFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            deger.KATEGORI = Byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TxtAlısFiyat.Text = "";
            TxtMarka.Text = "";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            TxtUrunAd.Text = "";
            TxtUrunID.Text = "";
        }
    }
}
