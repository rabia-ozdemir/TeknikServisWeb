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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLFATURADETAY
                           select new
                           {
                               x.FATURADETAYID,
                               x.URUN,
                               x.ADET,
                               x.FIYAT,
                               x.TUTAR,
                               x.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN = TxtUrun.Text;
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.TUTAR = decimal.Parse(TxtTutar.Text);
            t.FATURAID = int.Parse(TxtFaturaID.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Girişi Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLFATURADETAY
                           select new
                           {
                               x.FATURADETAYID,
                               x.URUN,
                               x.ADET,
                               x.FIYAT,
                               x.TUTAR,
                               x.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = TxtUrun.Text;
            deger.ADET = short.Parse(TxtAdet.Text);
            deger.FIYAT = decimal.Parse(TxtFiyat.Text);
            deger.TUTAR = decimal.Parse(TxtTutar.Text);
            deger.FATURAID = int.Parse(TxtFaturaID.Text);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            TxtUrun.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtFiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            TxtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            TxtFaturaID.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();

        }
    }
}
