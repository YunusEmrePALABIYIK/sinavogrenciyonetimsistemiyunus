using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sinavyonetimsistemiyunus
{
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //DERS KAYIT penceresini açmak için bunu yazıyoruz hocam
            Derskayit Derskayitformu = new Derskayit();
            Derskayitformu.Show();
        }
    }
}
