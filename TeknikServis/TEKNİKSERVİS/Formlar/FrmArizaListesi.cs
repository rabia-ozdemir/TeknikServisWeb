using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TEKNİKSERVİS.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARI = x.TBLCARI.AD +" "+ x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD +" "+ x.TBLPERSONEL.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIH,
                               x.URUNSERINO,
                               x.URUNDURUM
                           };
            gridControl1.DataSource = degerler.ToList();

            labelControl4.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            labelControl2.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            labelControl11.Text = db.TBLURUNKABUL.Count().ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            labelControl13.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
        labelControl9.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Edilen İşlemler").ToString();


            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H5AEC02\SQLEXPRESS;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY, COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Urunler"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();

       }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetay fr = new FrmArizaDetay();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
