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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        void liste()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON,
                               u.DEPARTMAN
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            liste();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //Personel 1
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl3.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl5.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl2.Text = ad1 + " " + soyad1;
            //Personel 2
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl10.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl8.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            labelControl12.Text = ad2 + " " + soyad2;
            //Personel 3
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl15.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl17.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            labelControl19.Text = ad3 + " " + soyad3;
            //Personel 4
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl23.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl21.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;
            labelControl25.Text = ad4 + " " + soyad4;



        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

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
            liste();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLPERSONEL.Find(id);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.DEPARTMAN = Byte.Parse(lookUpEdit1.EditValue.ToString());
            deger.MAIL = TxtMail.Text;
            deger.TELEFON = TxtTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Boş Veya Hatalı Karakter Var");
            }
        }
    }
}
