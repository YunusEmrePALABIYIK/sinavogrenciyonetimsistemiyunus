using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sinavyonetimsistemiyunus
{
    public partial class Sinavlar : Form
    {
        public Sinavlar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //SINAV KAYIT penceresini açmak için bunu yazıyoruz hocam
            Sinavkayit Sinavkayitformu = new Sinavkayit();
            Sinavkayitformu.Show();
        }
    }
}
