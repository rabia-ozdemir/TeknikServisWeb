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
    public partial class FrmGauge : Form
    {
        public FrmGauge()
        {
            InitializeComponent();
        }

        private void FrmHakkımızda_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value += 5;
            arcScaleComponent2.Value += 5;
            arcScaleComponent3.Value += 5;
            arcScaleComponent4.Value += 5;
            if (arcScaleComponent1.Value == 180 )
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value -= 5;
            arcScaleComponent2.Value -= 5;
            arcScaleComponent3.Value -= 5;
            arcScaleComponent4.Value -= 5;
            if (arcScaleComponent1.Value == 0 )
            {
                
                timer1.Start();
                timer2.Stop();
            }
        }
    }
}
