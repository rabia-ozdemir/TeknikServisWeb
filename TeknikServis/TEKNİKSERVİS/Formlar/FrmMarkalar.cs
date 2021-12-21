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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl3.Text = db.TBLURUN.Count().ToString();
            labelControl2.Text = (from x in db.TBLURUN
                                  select x.MARKA).Distinct().Count().ToString();
            labelControl5.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending
                                  select x.MARKA).FirstOrDefault();
            //chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("Beko", 3);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 1);
            
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H5AEC02\SQLEXPRESS;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT MARKA, COUNT(*) FROM TBLURUN GROUP BY MARKA", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString( dr[0]),int.Parse( dr[1].ToString()));
            }
            baglanti.Close();

            //2. CHART

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TBLKATEGORI.AD,COUNT(*) FROM TBLURUN  INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID = TBLURUN.KATEGORI GROUP BY TBLKATEGORI.AD ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();
           


            labelControl4.Text = db.maksmarkaurun().FirstOrDefault();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit12_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
