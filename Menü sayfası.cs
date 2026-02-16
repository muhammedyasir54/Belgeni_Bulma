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

        private void sINIFSEÇİMİToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void sINIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sınıf seçimi yapılna yer


        }

        private void bılısım9ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BIlısım9 blm9 = new BIlısım9();
            blm9.Show();

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

        private void  hazırlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hazırlık hazırlık = new Hazırlık();
            hazırlık.Show();
        }
    }
}
