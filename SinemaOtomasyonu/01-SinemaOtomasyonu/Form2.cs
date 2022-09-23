using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_SinemaOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 ownerForm;
        string bilgi;
        private void Form2_Load(object sender, EventArgs e)
        {
            ownerForm = this.Owner as Form1;
            bilgi = ownerForm.ButonBilgisiGetir();
            if (!string.IsNullOrEmpty(bilgi))
            {
                string[] bilgiDizisi = bilgi.Split('-');
                txtAdSoyad.Text = bilgiDizisi[0];
                mtxtTCKN.Text = bilgiDizisi[1];
                if (bilgiDizisi[2] == "Erkek")
                {
                    rbErkek.Checked = true;
                }
                else
                {
                    rbKadin.Checked = true;
                }
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string tckn = mtxtTCKN.Text;
            string cinsiyet = rbErkek.Checked ? "Erkek" : "Kadın";

            if (string.IsNullOrEmpty(adSoyad.Trim()) || tckn.Contains(" "))
            {
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz");
                return;
            }
            ownerForm.ButonaRezervasyonAta(true, adSoyad, tckn, cinsiyet);
            this.Close(); //bu formu kapat
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bilgi))
            {
                DialogResult silelimMi = MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silelimMi == DialogResult.Yes)
                {
                    ownerForm.ButonaRezervasyonAta(false);
                }
            }
            this.Close();
        }
    }
}
