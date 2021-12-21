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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
         }

        // Son Hali
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmUrunListesi frurunlist;
        private void BtnUrunListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frurunlist == null || frurunlist.IsDisposed)
            {
                frurunlist = new Formlar.FrmUrunListesi();
                frurunlist.MdiParent = this;
                frurunlist.Show();
            }
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.YeniUrun fr = new Formlar.YeniUrun();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmKategori frktg;
        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frktg == null || frktg.IsDisposed)
            {
                frktg = new Formlar.FrmKategori();
                frktg.MdiParent = this;
                frktg.Show();
            }
        }
        Formlar.FrmArizaListesi frarizaliste;
        private void BtnAriza_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frarizaliste == null || frarizaliste.IsDisposed)
            {
                frarizaliste = new Formlar.FrmArizaListesi();
                frarizaliste.MdiParent = this;
                frarizaliste.Show();
            }
        }

        private void BtnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi fr = new Formlar.FrmArizaliUrunKaydi();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRKod fr = new Formlar.FrmQRKod();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnArizaDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunDetaylari fr = new Formlar.FrmArizaliUrunDetaylari();
            fr.MdiParent = this;
            fr.Show();
        }
        
        Formlar.FrmCariListesi frcariliste;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frcariliste == null || frcariliste.IsDisposed)
            {
                frcariliste = new Formlar.FrmCariListesi();
                frcariliste.MdiParent = this;
                frcariliste.Show();
            }
        }
        Formlar.FrmCariIller frcariilistatistik;
        private void BtnCariİlİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frcariilistatistik == null || frcariilistatistik.IsDisposed)
            {
                frcariilistatistik = new Formlar.FrmCariIller();
                frcariilistatistik.MdiParent = this;
                frcariilistatistik.Show();
            }
        }

        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturayaKalemGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalem fr = new Formlar.FrmFaturaKalem();
            fr.MdiParent = this;
            fr.Show();
        }
        FrmTakvim frtakvim;
        private void BtnTakvim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frtakvim == null || frtakvim.IsDisposed)
            {
                frtakvim = new FrmTakvim();
                //frtakvim.MdiParent = this;
                frtakvim.Show();
            }
        }
        Formlar.FrmGMAP frgmaps;
        private void BtnGMAP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frgmaps == null || frgmaps.IsDisposed)
            {
                frgmaps = new Formlar.FrmGMAP();
                frgmaps.MdiParent = this;
                frgmaps.Show();
            }
        }
        Formlar.FrmMaps frmaps;
        private void BtnMap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmaps == null || frmaps.IsDisposed)
            {
                frmaps = new Formlar.FrmMaps();
                frmaps.MdiParent = this;
                frmaps.Show();
            }
        }
        Formlar.FrmPersonel frpersonel;
        private void BtnListePersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frpersonel == null || frpersonel.IsDisposed)
            {
                frpersonel = new Formlar.FrmPersonel();
                frpersonel.MdiParent = this;
                frpersonel.Show();
            }
        }
        Formlar.FrmDepartman frdepartman;
        private void BtnListeDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frdepartman == null || frdepartman.IsDisposed)
            {
                frdepartman = new Formlar.FrmDepartman();
                frdepartman.MdiParent = this;
                frdepartman.Show();
            }
        }

        private void BtnDepartmanYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem8_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar frkurlar;
        private void BtnDoviz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frkurlar == null || frkurlar.IsDisposed)
            {
                frkurlar = new Formlar.FrmKurlar();
                frkurlar.MdiParent = this;
                frkurlar.Show();
            }
        }

        private void BtnWordAç_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcelAç_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmYoutube fryoutube;
        private void BtnYoutubeAç_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fryoutube == null || fryoutube.IsDisposed)
            {
                fryoutube = new Formlar.FrmYoutube();
                fryoutube.MdiParent = this;
                fryoutube.Show();
            }
        }
        Formlar.FrmRapor frrapor;
        private void BtnRaporSihirbazı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frrapor == null || frrapor.IsDisposed)
            {
                frrapor = new Formlar.FrmRapor();
                frrapor.MdiParent = this;
                frrapor.Show();
            }
        }
        İletisim.FrmRehber frrehber;
        private void BtnRehberListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frrehber == null || frrehber.IsDisposed)
            {
                frrehber = new İletisim.FrmRehber();
                frrehber.MdiParent = this;
                frrehber.Show();
            }
        }

        private void BtnMailKutusu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            İletisim.FrmMail fr = new İletisim.FrmMail();
            fr.Show();
        }
        İletisim.FrmGelenMesajlar frgelenmesaj;
        private void BtnGelenMesajllar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frgelenmesaj == null || frgelenmesaj.IsDisposed)
            {
                frgelenmesaj = new İletisim.FrmGelenMesajlar();
                frgelenmesaj.MdiParent = this;
                frgelenmesaj.Show();
            }
        }
        Formlar.FrmGauge frgauge;
        private void btngauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frgauge == null || frgauge.IsDisposed)
            {
                frgauge = new Formlar.FrmGauge();
                frgauge.MdiParent = this;
                frgauge.Show();
            }
        }
        Formlar.FrmHarita frharita;
        private void BtnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frharita == null || frharita.IsDisposed)
            {
                frharita = new Formlar.FrmHarita();
                frharita.MdiParent = this;
                frharita.Show();
            }
        }

        private void BtnPersonelYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniPersonel fr = new Formlar.FrmYeniPersonel();
            //fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmAnasayfa fr;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnasayfa();
            }
            fr.MdiParent = this;
            fr.Show();
        }
        
        private void barButtonItem7_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnasayfa();
            }
            fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmMarkalar frmarka;
        private void btnmarka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmarka == null || frmarka.IsDisposed)
            {
                frmarka = new Formlar.FrmMarkalar();
                frmarka.MdiParent = this;
                frmarka.Show();
            }
        }

        private void btnfaturalistei_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaListesi fr = new Formlar.FrmFaturaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetay fr = new Formlar.FrmArizaDetay();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnyeniurunsatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatis fr = new Formlar.FrmUrunSatis();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnlistesatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSatislar fr = new Formlar.FrmSatislar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btndetaylıkalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalemleri fr = new Formlar.FrmFaturaKalemleri();
            fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmIstatistik fristatistik;
        private void btnistatistikurun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fristatistik == null || fristatistik.IsDisposed)
            {
                fristatistik = new Formlar.FrmIstatistik();
                fristatistik.MdiParent = this;
                fristatistik.Show();
            }
        }
        Formlar.FrmNotlar frnotliste;
        private void btnajandalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frnotliste == null || frnotliste.IsDisposed)
            {
                frnotliste = new Formlar.FrmNotlar();
                frnotliste.MdiParent = this;
                frnotliste.Show();
            }
        }
    }
}
