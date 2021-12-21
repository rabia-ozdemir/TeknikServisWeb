﻿using System;
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
    public partial class YeniUrun : Form
    {
        public YeniUrun()
        {
            InitializeComponent();
        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.MARKA = TxtMarka.Text;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürünler Başarıyla Kaydedildi");
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUrunAd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtUrunAd_Click(object sender, EventArgs e)
        {
            TxtUrunAd.Text = "";
            TxtUrunAd.Focus();
        }

        private void TxtMarka_Click(object sender, EventArgs e)
        {
            TxtMarka.Text = "";
            TxtMarka.Focus();
        }

        private void TxtKategori_Click(object sender, EventArgs e)
        {
            lookUpEdit1.Text = "";
            lookUpEdit1.Focus();
        }

        private void TxtAlisFiyat_Click(object sender, EventArgs e)
        {
            TxtAlisFiyat.Text = "";
            TxtAlisFiyat.Focus();
        }

        private void TxtSatisFiyat_Click(object sender, EventArgs e)
        {
            TxtSatisFiyat.Text = "";
            TxtSatisFiyat.Focus();
        }

        private void TxtStok_Click(object sender, EventArgs e)
        {
            TxtStok.Text = "";
            TxtStok.Focus();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void YeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }
    }
}
