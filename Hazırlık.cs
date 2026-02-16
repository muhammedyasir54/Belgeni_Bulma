using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace belge
{
    public partial class Hazırlık : Form
    {
        public Hazırlık()
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
        double beden()
        {
            return Convert.ToDouble(textBoxBeden.Text);
        }
        double sanat()
        {
            return Convert.ToDouble(textBoxSanat.Text);

        }
        double maınCourse()
        {
            return Convert.ToDouble(textBoxMaın.Text);
        }

        double speak()
        {
            return Convert.ToDouble(textBoxSpeak.Text);
        }
        double skıls()
        {
            return Convert.ToDouble(textBoxSkıls.Text);

        }
        double kodlama()
        {
            return Convert.ToDouble( textBoxBılısımTekno.Text);
        }
        double dısıplın()
        {
            return Convert.ToDouble(textBoxDsıplın.Text);
        }

        private void buttonBelgeBulucu_Click(object sender, EventArgs e)
        {
            double genelort = ((mat()*3)+(edb()*4)+(kodlama()*4)+(beden()*2)+ (sanat()*2)+(maınCourse()*14)+(speak()*4)+(skıls()*6))/39;

            if (edb() > 100.0 || edb() < 0 || mat() > 100.0 || mat() < 0  || beden() > 100.0 || beden() < 0 || sanat() > 100.0 || sanat() < 0|| maınCourse() > 100.0 || maınCourse() < 0||speak() > 100.0 || speak() < 0||skıls() > 100.0 || skıls() < 0)
            {
                MessageBox.Show("Yanlış sayısı girişi yaptınız! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show( "yanlış sayı girişi ","sayı hatası ", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
            }
            else
            {
                if (edb() < 70||maınCourse() < 70 )
                {
                    labelSonucu.Text = "Edebiyat veya Main Course ders notu   70 altı olduğu için belge alamazsınız.";
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
