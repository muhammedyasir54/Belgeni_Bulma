using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace belge
{
    public partial class elektrık9 : Form
    {
        public elektrık9()
        {
            InitializeComponent();
        }

        double edb()
        {
            return Convert.ToDouble(textBoxEdebıyat.Text);
        }
        double mat()
        {
            return Convert.ToDouble(textBoxMat.Text);
        }
        double ıng()
        {
            return Convert.ToDouble(textBoxIngılızce.Text);
        }
        double fızık()
        {
            return Convert.ToDouble(textBoxFızık.Text);
        }
        double kımya()
        {
            return Convert.ToDouble(textBoxKımya.Text);
        }
        double bıyolcı()
        {
            return Convert.ToDouble(textBoxBıy.Text);
        }
        double tarıh()
        {
            return Convert.ToDouble(textBoxTar.Text);
        }
        double cograf()
        {
            return Convert.ToDouble(textBoxCograf.Text);
        }
        double dınKulturu()
        {
            return Convert.ToDouble(textBoxDınBılgıs.Text);
        }
        double beden()
        {
            return Convert.ToDouble(textBoxBeden.Text);
        }
        double sanat()
        {
            return Convert.ToDouble(textBoxSanat.Text);
        }
        double temelDın()
        {
            return Convert.ToDouble(textBoxSecmelıDın.Text);
        }
        double uzay()
        {
            return Convert.ToDouble(textBoxUzay.Text);
        }
        double Mga()
        {
            return Convert.ToDouble(textBoxMeslekıGelısım.Text);
        }
        double dısıplın()
        {
            return Convert.ToDouble(textBoxDısıplınMıktarı.Text);
        }
        double elektrık()
        {
            return Convert.ToDouble(textBoxElektrık.Text);
        }
        private void buttonBelgeBulucu_click(object sender, EventArgs e)
        {

            double çarpımları = (edb() * 5) + (mat() * 5) + (ıng() * 4) + (fızık() * 2) + (kımya() * 2) + (bıyolcı() * 2) + (tarıh() * 2) + (cograf() * 2) + (dınKulturu() * 2) + (beden() * 2) + (sanat() * 2) + (temelDın() * 1) + (uzay() * 2) + (elektrık() * 9) + (Mga() * 2);
            double genelort = çarpımları / 44;

            if (edb() > 100.0 || edb() < 0 || mat() > 100.0 || mat() < 0 || ıng() > 100.0 || ıng() < 0 || fızık() > 100.0 || fızık() < 0 || bıyolcı() > 100.0 || bıyolcı() < 0 || tarıh() > 100.0 || tarıh() < 0 || cograf() > 100.0 || cograf() < 0 || dınKulturu() > 100.0 || dınKulturu() < 0 || beden() > 100.0 || beden() < 0 || uzay() > 100.0 || uzay() < 0 || Mga() > 100.0 || Mga() < 0 || elektrık() > 100.0 || elektrık() < 0)
            {
                MessageBox.Show("Yanlış sayısı girişi yaptınız! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show( "yanlış sayı girişi ","sayı hatası ", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
            }
            else
            {
                if (edb() < 70)
                {
                    labelSonucu.Text = "Edebiyat notu 70 altı olduğu için belge alamazsınız.";
                    labelSonucu.Visible = true;
                }
                else if (dısıplın() > 0)
                {
                    labelSonucu.Text = "Disiplin cezanız olduğu için belge alamazsınız.";
                    labelSonucu.Visible = true;
                }
                else if (genelort >= 85)
                {
                    labelSonucu.Text = $"Ortalamanız {genelort}: Takdir Belgesi Aldınız!";
                    labelSonucu.Visible = true;
                }
                else if (genelort >= 70)
                {
                    labelSonucu.Text = $"Ortalamanız {genelort}: Teşekkür Belgesi Aldınız!";
                    labelSonucu.Visible = true;
                }
                else
                {
                    labelSonucu.Text = "Ortalamanız belge almak için yetersiz.";
                    labelSonucu.Visible = true;
                }
            }            
        }
    }
}