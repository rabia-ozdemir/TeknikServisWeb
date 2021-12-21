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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnAra_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtId.Text);

            var degerler = (from x in db.TBLFATURADETAY
                            select new
                            {
                                x.FATURADETAYID,
                                x.URUN,
                                x.ADET,
                                x.FIYAT,
                                x.TUTAR,
                                x.FATURAID,
                            }).Where(x => x.FATURAID == id);
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmFaturaKalemleri_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }


    }
}
