using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _01_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, decimal> menuler = new Dictionary<string, decimal>();

        Dictionary<string, decimal> ekstralar;
        private void Form1_Load(object sender, EventArgs e)
        {
            MyMDIForm mdiForm = this.MdiParent as MyMDIForm;
            ekstralar = mdiForm.GetEktraMalzemeler();

            menuler.Add("Steak Menü", 30);
            menuler.Add("Chicken Menü", 25);
            menuler.Add("Fish Menü", 20);
            menuler.Add("Big Menü", 35);
            menuler.Add("Texas Menü", 40);



            foreach (KeyValuePair<string, decimal> item in ekstralar)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item.Key;
                checkBox.Tag = item.Value;
                checkBox.Font = new Font(FontFamily.GenericSansSerif, 9);
                checkBox.Width = 81;
                flpEkstralar.Controls.Add(checkBox);
            }

            foreach (string item in menuler.Keys)
            {
                cbMenu.Items.Add(item);
            }
        }

        List<string> mevcutSiparisler = new List<string>();
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            string menuAdi = cbMenu.SelectedItem.ToString();
            decimal menuUcreti = menuler[menuAdi];
            decimal toplamTutar = 0;
            string bilgiMetni = string.Empty;
            bilgiMetni += $"{menuAdi}-";

            if (rbOrta.Checked)
            {
                menuUcreti += 4;
                bilgiMetni += $"{rbOrta.Text}-";
            }
            else if (rbBuyuk.Checked)
            {
                menuUcreti += 8;
                bilgiMetni += $"{rbBuyuk.Text}-";
            }
            else
            {
                bilgiMetni += $"{rbKucuk.Text}-";
            }

            bool isChecked = false;
            foreach (CheckBox item in flpEkstralar.Controls)
            {
                if (item.Checked)
                {
                    isChecked = true;
                    menuUcreti += Convert.ToDecimal(item.Tag);
                    //menuUcreti += ekstralar[item.Text];
                    bilgiMetni += $"{item.Text},";
                }

            }
            if (isChecked)
            {
                bilgiMetni = bilgiMetni.Trim(' ').Trim(',');
                bilgiMetni += "-";
            }

            toplamTutar = menuUcreti;
            int adet = Convert.ToInt32(nudMenuAdet.Value);
            toplamTutar *= adet;
            bilgiMetni += $"{adet}-{toplamTutar}";

            mevcutSiparisler.Add(bilgiMetni);
            FillListBox(bilgiMetni);
            #region Controls
            //foreach (Control item in flpEkstralar.Controls)
            //{
            //    if (item is CheckBox)
            //    {
            //        CheckBox checkBox = (CheckBox)item;
            //        if (checkBox.Checked)
            //        {
            //            menuUcreti += Convert.ToDecimal(item.Tag);
            //        }
            //    }
            //}
            #endregion

            decimal mevcutSiparisToplami = 0;
            foreach (string item in mevcutSiparisler)
            {
                string[] siparisParcalari = item.Split('-');
                decimal fiyat = Convert.ToDecimal(siparisParcalari[siparisParcalari.Length - 1].Trim());
                mevcutSiparisToplami += fiyat;

            }
            lblToplamTutar.Text = mevcutSiparisToplami.ToString();

        }

        void FillListBox(string siparis)
        {
            string[] dizi = siparis.Split('-');
            string listBoxMetni = string.Empty;
            if (dizi.Length == 5)
            {
                listBoxMetni = $"Menu: {dizi[0]} Boyut: {dizi[1]} EkstraMalzeler: {dizi[2]} Adet: {dizi[3]} Toplam Tutar : {dizi[4]}";
            }
            else
            {
                listBoxMetni = $"Menu: {dizi[0]} Boyut: {dizi[1]} Adet: {dizi[2]} Toplam Tutar : {dizi[3]}";
            }
            lbSiparisler.Items.Add(listBoxMetni);
        }


        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Siparişi Tamamlayalım Mı ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                FileStream stream = new FileStream("tamamlananSiparisler.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                foreach (string item in mevcutSiparisler)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
                stream.Close();
            }

            mevcutSiparisler.Clear();
            lbSiparisler.Items.Clear();
            lblToplamTutar.Text = 0.ToString();
        }
    }
}
