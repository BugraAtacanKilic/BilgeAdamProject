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

namespace notdefteri
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "notdefteri.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonKaydet.Enabled = false;         
            if (File.Exists(dosya_dizini) == true) // dizindeki dosya var mı ?
            {
                // varsa

                FileStream liste = new FileStream(dosya_dizini, FileMode.Open, FileAccess.Read);
                StreamReader listeAl = new StreamReader(liste);
                string tumListe = listeAl.ReadLine();

                while (tumListe != null)
                {
                    string[] sonDeger = tumListe.Split('-');
                    listBoxNotlar.Items.Add(sonDeger[0]);
                    tumListe = listeAl.ReadLine();

                }
                liste.Close();
                listeAl.Close();

            }
            else
            {
               //Yoksa
            
            }
           

        }             

        private void buttonYeniNot_Click(object sender, EventArgs e)
        {
            textBoxBaslik.Visible = true;
            textBoxMetin.Visible = true;
            buttonKaydet.Enabled = true;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            veriKaydet();           
            
        }

        private void veriKaydet()
        {
            try
            {
            string list = textBoxBaslik.Text.ToString() + "-" + textBoxMetin.Text.ToString();  
            FileStream fw = new FileStream(dosya_dizini, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fw);
            sw.WriteLine(list);
            sw.Close();
            fw.Close();
            textBoxBaslik.Visible = false;
            textBoxMetin.Visible = false;
            buttonKaydet.Enabled = false;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }
           
        }        

        private void buttonNotuSil_Click(object sender, EventArgs e)
        {
            int numara = listBoxNotlar.SelectedIndex;
            listBoxNotlar.Items.RemoveAt(numara);
            veriKaydet();
        }
    }
}
