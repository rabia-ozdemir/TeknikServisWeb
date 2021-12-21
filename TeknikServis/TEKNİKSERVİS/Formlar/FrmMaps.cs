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
    public partial class FrmMaps : Form
    {
        public FrmMaps()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadde = Txtcadde.Text;
            string ulke = Txtulke.Text;
            string sehir = Txtsehir.Text;
            string posta = Txtposta.Text;
            try
            {
                StringBuilder adresbul = new StringBuilder();
                adresbul.Append("http://maps.google.com/maps?q=");
                if (cadde != string.Empty)
                {
                    adresbul.Append(cadde + ",+");
                }
                if (sehir != string.Empty)
                {
                    adresbul.Append(sehir + ",+");
                }
                if (ulke != string.Empty)
                {
                    adresbul.Append(ulke + ",+");
                }
                if (posta != string.Empty)
                {
                    adresbul.Append(posta + ",+");
                }
                webBrowser1.Navigate(adresbul.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata");
            }
        }
    }
}
