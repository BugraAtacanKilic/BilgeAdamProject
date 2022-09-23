using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _241121PersonelKayitOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            personeller = new List<Personel>();
            personeller = PersonelManagement.DeSerialize();
            FillListView();
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
        }
        Personel personel;
        List<Personel> personeller;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                personel = new Personel()
                {
                    Id = Convert.ToInt32(txtPersonelId.Text),
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Adres = txtAdres.Text,
                    Email = txtMail.Text,
                    IseGirisTarihi = dtpIseGirisTarihi.Value,
                    TelNo = mTxtTelefon.Text,
                    Unvan = (Unvan)cmbUnvan.SelectedIndex,
                    //Unvan = (Unvan)Enum.Parse(typeof(Unvan), cmbUnvan.SelectedItem.ToString())

                };
                if (pbResim.Image != null)
                {
                    //seçili resmi kendi projeme kayıt ettim
                    string yol = Application.StartupPath + "/Images/" + Guid.NewGuid() + ".png";
                    pbResim.Image.Save(yol);

                    //Benim projemdeki yolunu personelin property bilgisine ata
                    personel.FotoYolu = yol;
                }
                personeller.Add(personel);
                FillListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillListView()
        {
            lvListe.Items.Clear();
            ListViewItem lvi;
            foreach (var item in personeller)
            {
                lvi = new ListViewItem(item.Id.ToString());
                lvi.SubItems.Add(item.Ad);
                lvi.SubItems.Add(item.Soyad);
                lvi.SubItems.Add(item.IseGirisTarihi.ToShortDateString());
                lvi.SubItems.Add(item.Email);
                lvListe.Items.Add(lvi);
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            //Bilgisayardaki fotoğrafi pictureBoxa ata
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dialogResult = ofd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonelManagement.Serialize(personeller);


        }
    }
}
