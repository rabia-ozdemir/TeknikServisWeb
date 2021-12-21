using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace TEKNİKSERVİS.Formlar
{
    public partial class FrmGMAP : Form
    {
        public FrmGMAP() { InitializeComponent(); }


        private void FrmGMAP_Load(object sender, EventArgs e)
        {
            //GMapProviders.GoogleMap.ApiKey = @"AIzaSyDNdOV4bolXRbxNveqV1_6J13ZkDP3NMIg";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double enlem = Convert.ToDouble(txtenlem.Text);
            double boylam = Convert.ToDouble(txtboylam.Text);
            map.Position = new PointLatLng(enlem, boylam);
            map.MinZoom = 1; //Minimum Yakınlaştırma Seviyesi
            map.MaxZoom = 100; //Maksimum Yakınlaştırma Seviyesi
            map.Zoom = 10; // Geçerli Yakınlaştırma Düzeyi

            PointLatLng point = new PointLatLng(enlem, boylam);

            //Özel İşaretleyici Oluşturma
            Bitmap bmpmarker = (Bitmap)Image.FromFile("C:\\Resim/marker.ico");
            GMapMarker marker = new GMarkerGoogle(point, bmpmarker);

            // 1.Bindirme oluşturma
            GMapOverlay markers = new GMapOverlay("markers");
            //2. Mevcut tüm işaretleyicileri bu kaplamaya ekleyin
            markers.Markers.Add(marker);
            //3. Bindirme ile kapak haritası
            map.Overlays.Add(markers);

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        
    }
}
