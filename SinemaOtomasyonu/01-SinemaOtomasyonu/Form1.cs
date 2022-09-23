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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbBos.Image = Image.FromFile(@"..\..\Images\imagesmavi.jpg");
            pbBos.BackgroundImageLayout = ImageLayout.Stretch;
            pbDolu.Image = Image.FromFile(@"..\..\Images\imageskirmizi.jpg");
            pbDolu.BackgroundImageLayout = ImageLayout.Stretch;

            Button btn;
            int sayac = 0;
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    sayac++;
                    btn = new Button();
                    btn.Height = btn.Width = 40;
                    btn.BackColor = Color.Blue;
                    //btn.BackgroundImageLayout = ImageLayout.Center;

                    btn.Text = sayac.ToString();
                    btn.ForeColor = Color.White;
                    if (i % 2 == 1)
                    {
                        if (j > 8)
                        {
                            continue;
                        }
                        btn.Location = new Point(90 + (btn.Width + 5) * j, (btn.Height + 5) * i);
                    }
                    else
                    {
                        btn.Location = new Point((btn.Width + 5) * j, (btn.Height + 5) * i);
                    }
                    btn.Click += btn_Click;
                    pnlKoltuklar.Controls.Add(btn);
                }
            }
        }
        Button tiklanilan; //en son seçilen koltuk 
        private void btn_Click(object sender, EventArgs e)
        {
            //runtime oluşturulan 40 koltuktan seçileni aldım 
            tiklanilan = sender as Button;

            //formu açtı 
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
        }

        public void ButonaRezervasyonAta(bool KayitMi,string adSoyad=null, string tckn=null, string cinsiyet=null )
        {
            if (KayitMi)
            {
                tiklanilan.Tag = $"{adSoyad}-{tckn}-{cinsiyet}";
                tiklanilan.BackColor = Color.Red;
            }
            else
            {
                tiklanilan.Tag = null;
                tiklanilan.BackColor = Color.Blue;
            }
        }

        //public void ButonaRezervasyonIptal()
        //{
        //    tiklanilan.Tag = null;

        //    tiklanilan.BackColor = Color.Blue;
        //}

        public string ButonBilgisiGetir()
        {
            if (tiklanilan.Tag != null)
            {
                return tiklanilan.Tag.ToString();
            }
            return string.Empty;
        }

        private void btnKadinErkekSayisi_Click(object sender, EventArgs e)
        {
            int kadinSayisi = 0;
            int erkekSayisi = 0;
            foreach (Button item in pnlKoltuklar.Controls)
            {
                if (item.Tag != null)
                {
                    string bilgi = item.Tag.ToString();
                    if (bilgi.EndsWith("Erkek"))
                    {
                        erkekSayisi++;
                    }
                    else 
                    {
                        kadinSayisi++;
                    }
                }
            }
            MessageBox.Show($"Kadın Seyirci Sayısı : {kadinSayisi}\nErkek Seyirci Sayisi : {erkekSayisi}");
        }

        private void btnIzleyiciSayisi_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            foreach (Button item in pnlKoltuklar.Controls)
            {
                if (item.Tag != null)
                {
                    sayac++;
                }
            }
            MessageBox.Show($"Toplam Seyirci Sayısı : {sayac}");
        }
    }
}
