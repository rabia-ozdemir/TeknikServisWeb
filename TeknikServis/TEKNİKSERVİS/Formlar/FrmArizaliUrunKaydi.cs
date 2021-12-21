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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD= x.AD+" "+x.SOYAD 
                                                 }).ToList();
        //Personel
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD= x.AD+" "+x.SOYAD 
                                                 }).ToList();
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GELISTARIH = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Başarıyla Gerçekleştirildi");

        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
            TxtSeriNo.Focus();
        }

        private void lookUpEdit2_Click(object sender, EventArgs e)
        {
            lookUpEdit2.Text = "";
            lookUpEdit2.Focus();
        }

        private void lookUpEdit1_Click(object sender, EventArgs e)
        {
            lookUpEdit1.Text = "";
            lookUpEdit1.Focus();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToString();
        }

        private void TxtTarih_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
