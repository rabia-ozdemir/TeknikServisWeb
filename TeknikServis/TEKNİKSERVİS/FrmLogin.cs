using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where x.KULLANICIAD == textBox1.Text & x.SIFRE == textBox2.Text
                        select x;
            if(sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKayitOl frmlgn = new FrmKayitOl();
            frmlgn.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreUnuttum frmlgn = new FrmSifreUnuttum();
            frmlgn.Show();
            this.Hide();
        }
    }
}
