using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sinavyonetimsistemiyunus
{
    public partial class Derslikler : Form
    {
        public Derslikler()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //DERSLİK KAYIT penceresini açmak için bunu yazıyoruz hocam
            Derslikkayit Derslikkayitformu = new Derslikkayit();
            Derslikkayitformu.Show();
        }
    }
}
