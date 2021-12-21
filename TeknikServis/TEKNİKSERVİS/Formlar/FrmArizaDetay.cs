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
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }
        
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = TxtSeriNo.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.TBLURUNTAKIP.Add(t);            

            //2. Güncelleme
            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunid =int.Parse(id.ToString());
            var deger = db.TBLURUNKABUL.Find(urunid);
            deger.URUNDURUMDETAY = comboBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayları Güncellendi");
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string id,serino;
        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Text = serino;
        }
    }
}
