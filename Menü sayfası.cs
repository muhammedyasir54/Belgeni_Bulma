using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace belge
{
    public partial class Menü_sayfası : Form
    {
        public Menü_sayfası()
        {
            InitializeComponent();
        }
        private void bilişimToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BIlısım9 blm9 = new BIlısım9();
            blm9.Show();

        }

        private void elektrikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elektrık9 eltrık9 = new elektrık9();

            eltrık9.Show();
        }

        private void hazırlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hazırlık hazırlık = new Hazırlık();
            hazırlık.Show();
        }
        private void yazılımGeliştirmeDalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BılısımYazılım10 bılsım10 = new BılısımYazılım10();
            bılsım10.Show();
        }

        private void uçakElektroniğiDalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcakELEktrık10 ucak10 = new UcakELEktrık10();
            ucak10.Show();
        }

        private void ağİşletmenliğiVeSiberGüvenlikDalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bılısımWEB10 bılısımWEB10 = new bılısımWEB10();
            bılısımWEB10.Show();
        }
    }
}
