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
    public partial class FrmTakvim : Form
    {
        public FrmTakvim()
        {
            InitializeComponent();
        }

        private void btnsakla_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }
    }
}
