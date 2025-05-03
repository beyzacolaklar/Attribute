using System;
using System.Windows.Forms;
using OgrenciApp.Attributes;

namespace OgrenciApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            var ogrenci = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            bool hataVarMi = false;
            string hataMesajlari = "";

            foreach (var prop in typeof(Ogrenci).GetProperties())
            {
                var attribute = Attribute.GetCustomAttribute(prop, typeof(ZorunluAlanAttribute)) as ZorunluAlanAttribute;
                var deger = prop.GetValue(ogrenci) as string;

                if (attribute != null && string.IsNullOrWhiteSpace(deger))
                {
                    hataVarMi = true;
                    hataMesajlari += attribute.HataMesaji + Environment.NewLine;
                }
            }

            if (hataVarMi)
            {
                MessageBox.Show(hataMesajlari, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblSonuc.Text = $"Ad: {ogrenci.Ad}, Soyad: {ogrenci.Soyad}, Bölüm: {ogrenci.Bolum}";
            }
        }
    }
}

