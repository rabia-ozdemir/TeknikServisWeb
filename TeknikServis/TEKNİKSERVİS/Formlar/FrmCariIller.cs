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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H5AEC02\SQLEXPRESS;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
       
        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["İller"].Points.AddPoint("Ankara", 22);
            //chartControl1.Series["İller"].Points.AddPoint("Aksaray", 2);
            //chartControl1.Series["İller"].Points.AddPoint("İstanbul", 25);
            //chartControl1.Series["İller"].Points.AddPoint("Şanlıurfa", 15);
            //chartControl1.Series["İller"].Points.AddPoint("Tekirdağ", 5);
            //chartControl1.Series["İller"].Points.AddPoint("Ardahan", 1);

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,COUNT(*)FROM TBLCARI group by IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["İller"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
