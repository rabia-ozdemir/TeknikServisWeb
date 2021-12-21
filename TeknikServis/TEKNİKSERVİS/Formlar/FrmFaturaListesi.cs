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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLFATURABILGI
                           select new
                           {
                               x.ID,
                               x.SERI,
                               x.SIRANO,
                               x.TARIH,
                               x.SAAT,
                               x.VERGIDAIRE,
                               CARI = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
            LookUpCari.Properties.DataSource = (from x in db.TBLCARI
                                                select new
                                                {
                                                    x.ID,
                                                    AD = x.AD + " " + x.SOYAD
                                                }).ToList();
            LookUpPersonel.Properties.DataSource = (from y in db.TBLPERSONEL
                                                    select new
                                                    {
                                                        y.ID,
                                                        AD = y.AD + " " + y.SOYAD
                                                    }).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = TxtSeri.Text;
            t.SIRANO = TxtSıraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERGIDAIRE = TxtVergiDairesi.Text;
            t.CARI = int.Parse(LookUpCari.EditValue.ToString());
            t.PERSONEL = short.Parse(LookUpPersonel.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLFATURABILGI
                           select new
                           {
                               x.ID,
                               x.SERI,
                               x.SIRANO,
                               x.TARIH,
                               x.SAAT,
                               x.VERGIDAIRE,
                               CARI = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            deger.SERI = TxtSeri.Text;
            deger.SIRANO = TxtSıraNo.Text;
            deger.TARIH = Convert.ToDateTime(TxtTarih.Text);
            deger.SAAT = TxtSaat.Text;
            deger.VERGIDAIRE = TxtVergiDairesi.Text;
            deger.CARI = int.Parse(LookUpCari.EditValue.ToString());
            deger.PERSONEL = short.Parse(LookUpPersonel.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            TxtSıraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            TxtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();

        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id =int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
           fr.Show();
        }
    }
}
