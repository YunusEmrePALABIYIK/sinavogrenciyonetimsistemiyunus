using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sinavyonetimsistemiyunus
{
    public partial class Sinavsonuclari : Form
    {
        public Sinavsonuclari()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //SINAV SONUCLARI KAYIT penceresini açmak için bunu yazıyoruz hocam
            Sinavsonuckayit Sinavsonuckayitformu = new Sinavsonuckayit();
            Sinavsonuckayitformu.Show();
        }
    }
}
