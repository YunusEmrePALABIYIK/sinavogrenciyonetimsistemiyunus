using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavyonetimsistemiyunus
{
    public partial class Sinavyonetimsistemi : Form
    {
        public Sinavyonetimsistemi()
        {
            InitializeComponent();
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        { 

        }

            private void Button1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void Usttoolstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Ogrencilerrr(object sender, EventArgs e)
        {
            //ogrenciler penceresini açmak için bunu yazıyoruz hocam
            Ogrenciler Ogrencilerformu = new Ogrenciler();
            Ogrencilerformu.Show();
        }

        private void Derslerrr(object sender, EventArgs e)
        {
            //Dersler penceresini açmak için bunu yazıyoruz hocam
            Dersler Derslerformu = new Dersler();
            Derslerformu.Show();
        }

        private void Dersliklerrr(object sender, EventArgs e)
        {
            //Derslikler penceresini açmak için bunu yazıyoruz hocam
            Derslikler Dersliklerformu = new Derslikler();
            Dersliklerformu.Show();
        }

        private void Sinavlarrr(object sender, EventArgs e)
        {
            //Sinavlar penceresini açmak için bunu yazıyoruz hocam
            Sinavlar Sinavlarformu = new Sinavlar();
            Sinavlarformu.Show();
        }

        private void Sinavsonuclariii(object sender, EventArgs e)
        {
            //Sınav sonuçları penceresini açmak için bunu yazıyoruz hocam
            Sinavsonuclari Sinavsonuclariformu = new Sinavsonuclari();
            Sinavsonuclariformu.Show();
        }

        private void Listeveraporrr(object sender, EventArgs e)
        {
            //ogrenciler penceresini açmak için bunu yazıyoruz hocam
            Listeverapor Listeveraporformu = new Listeverapor();
            Listeveraporformu.Show();
        }
    }
}
