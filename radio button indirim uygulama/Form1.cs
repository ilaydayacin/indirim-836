using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radio_button_indirim_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            double toplam, sonuc = 0;

            if (rb25.Checked)
            {
                toplam = fiyat * 25 / 100;
                sonuc = fiyat - toplam;
            }

            else if (rb50.Checked)
            {
                toplam = fiyat * 50 / 100;
                sonuc = fiyat - toplam;
            }

            else if (rb75.Checked)
            {
                toplam = fiyat * 75 / 100;
                sonuc = (fiyat - toplam);
            }
            else if (rb90.Checked)
            {
                toplam = fiyat * 90 / 100;
                sonuc = fiyat - toplam;
            }
            lblSonuc.Text = "İndirimli fiyati: " + sonuc.ToString();
        }
    }
}
