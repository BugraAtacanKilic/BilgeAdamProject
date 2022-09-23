using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Hamburgerci
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MyMDIForm mdiForm = this.MdiParent as MyMDIForm;
         
            if (File.Exists("tamamlananSiparisler.txt")) //böyle bir dosya var mı ? 
            {
                FileStream stream = new FileStream("tamamlananSiparisler.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                int verilenSiparisAdedi = 0;
                decimal toplamCiro = 0;
                int urunAdeti = 0;
                decimal ekstraMalzemeGeliri = 0;
                while (reader.Peek() >= 0)
                {
                    //Dizinin eleman sayısını 
                    verilenSiparisAdedi++;
                   string siparis  =reader.ReadLine();
                   string[] siparisDetaylari = siparis.Split('-');
                    toplamCiro+=Convert.ToDecimal(siparisDetaylari[siparisDetaylari.Length - 1].Trim());
                    urunAdeti += Convert.ToInt32(siparisDetaylari[siparisDetaylari.Length - 2].Trim());
                 ekstraMalzemeGeliri += siparisDetaylari.Length==5?  mdiForm.EkstraMalzemeGelirHesapla(siparisDetaylari[siparisDetaylari.Length - 3].Trim()): 0;
                }
                reader.Close();
                stream.Close();


                lblCiro.Text = toplamCiro.ToString();
                lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString();
                lblsiparisAdeti.Text = verilenSiparisAdedi.ToString();
                lblUrunAdeti.Text = urunAdeti.ToString();
            }
        }
    }
}
