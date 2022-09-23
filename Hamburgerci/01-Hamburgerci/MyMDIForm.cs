using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Hamburgerci
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        private void siparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 siparisEklemeEkrani = new Form1();
            siparisEklemeEkrani.MdiParent = this; //sen bu formun içerine gömülü açılacaksın
            siparisEklemeEkrani.Dock = DockStyle.Fill;
            this.Width = siparisEklemeEkrani.Width + 50;
            this.Height = siparisEklemeEkrani.Height + 50;

            siparisEklemeEkrani.Show();

        }

        private void siparişÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ozetEkrani = new Form2();
            ozetEkrani.MdiParent = this;
            ozetEkrani.Dock = DockStyle.Fill;
            this.Width = ozetEkrani.Width + 50;
            this.Height = ozetEkrani.Height + 50;
            ozetEkrani.Show();

        }
        Dictionary<string, decimal> ekstralar = new Dictionary<string, decimal>();
        private void MyMDIForm_Load(object sender, EventArgs e)
        {
            ekstralar.Add("Mayonez", 1);
            ekstralar.Add("Ketçap", 1.5M);
            ekstralar.Add("Ranch", 1.5M);
            ekstralar.Add("Buffalo", 1.5M);
            ekstralar.Add("Hardal", 2.5M);
            ekstralar.Add("Barbekü", 2.5M);
        }
        public Dictionary<string, decimal> GetEktraMalzemeler() 
        {
            return ekstralar;
        }

        public decimal EkstraMalzemeGelirHesapla(string ekstraIsimleri) 
        {
            decimal toplam = 0;
            foreach (string item in ekstraIsimleri.Split(','))//Ketçap,Mayonez
            {
               toplam+= ekstralar[item.Trim()];
            }
            return toplam;
        }
    }
}
