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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl20.Text = db.TBLPERSONEL.Count().ToString();

            labelControl12.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl20.Text = db.TBLPERSONEL.Count().ToString();

            
            

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();

            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" )
            {
                t.AD = TxtAd.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void labelControl20_Click(object sender, EventArgs e)
        {

        }
    }
}
