using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace belge
{
    public partial class bılısımWEB10 : Form
    {
        public bılısımWEB10()
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
        double felsefe()
        {
            return Convert.ToDouble(textBoxFelsefe.Text);
        }

        double adabı_Muşaret()
        {
            return Convert.ToDouble(textBoxAdabı_Muşaret.Text);
        }
        double turk_Dunyası()
        {
            return Convert.ToDouble(textBoxTruk_Dunyası.Text);

        }
        double demokrası()
        {
            return Convert.ToDouble(textBoxDemokrası.Text);

        }
        double Robotık()
        {
            return Convert.ToDouble(textBoxRobot.Text);
        }
        double agSıstemlerı()
        {
            return Convert.ToDouble(textBoxAgSıstemlerı.Text);
        }
        double dısıplın()
        {
            return Convert.ToDouble(textBoxDısıplınMıktarı.Text);
        }
        private void buttonBelgeBulucu_click(object sender, EventArgs e)
        {

            double çarpımları = (edb() * 4) + (mat() * 5) + (ıng() * 2) + (fızık() * 2) + (kımya() * 2) + (bıyolcı() * 2) + (tarıh() * 2) + (cograf() * 2) + (dınKulturu() * 2) + (beden() * 2) + (felsefe() * 2) + (demokrası() * 1) + (turk_Dunyası() * 2) + (agSıstemlerı() * 10) + (Robotık() * 3);
            double genelort = çarpımları / 44;




            if (edb() > 100.0 || edb() < 0 || mat() > 100.0 || mat() < 0 || ıng() > 100.0 || ıng() < 0 || fızık() > 100.0 || fızık() < 0 || bıyolcı() > 100.0 || bıyolcı() < 0 || tarıh() > 100.0 || tarıh() < 0 || cograf() > 100.0 || cograf() < 0 || dınKulturu() > 100.0 || dınKulturu() < 0 || beden() > 100.0 || beden() < 0 || felsefe() > 100.0 || felsefe() < 0 || adabı_Muşaret() > 100.0 || adabı_Muşaret() < 0 || turk_Dunyası() > 100.0 || turk_Dunyası() < 0 || demokrası() > 100.0 || demokrası() < 0 || agSıstemlerı() > 100.0 || agSıstemlerı() < 0 || Robotık() > 100.0 || Robotık() < 0)
            {
                MessageBox.Show("Yanlış sayısı girişi yaptınız! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
