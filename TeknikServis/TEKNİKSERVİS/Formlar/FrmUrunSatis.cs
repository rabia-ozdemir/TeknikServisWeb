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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN = int.Parse(lookUpEdit1.EditValue.ToString());
            t.MUSTERI = int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit3.EditValue.ToString());
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı");

        }

        private void TxtUrunID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLURUN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from y in db.TBLCARI
                                                 select new
                                                 {
                                                     y.ID,
                                                     AD = y.AD + " " + y.SOYAD
                                                 }).ToList();
            lookUpEdit3.Properties.DataSource = (from z in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     z.ID,
                                                     AD = z.AD + " " + z.SOYAD
                                                 }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToString();
        }

        private void TxtAdet_Click(object sender, EventArgs e)
        {
            TxtAdet.Text = "";
            TxtAdet.Focus();
        }

        private void TxtSatisFiyat_Click(object sender, EventArgs e)
        {
            TxtSatisFiyat.Text = "";
            TxtSatisFiyat.Focus();
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
            TxtSeriNo.Focus();
        }
    }
}
