using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ListViewItem row = new ListViewItem();
           
            row.Text = txtAd.Text;
            row.SubItems.Add(txtSoyad.Text);
            row.SubItems.Add(nudOkulNo.Value.ToString());
            row.SubItems.Add(txtOkulAdi.Text);
            lvOgrenciler.Items.Add(row);          
        }
    }
}
