using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sinavyonetimsistemiyunus
{
    public partial class Ogrenciler : Form
    {
        public Ogrenciler()
        {
            InitializeComponent();
        }


    private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //OGRENCİ KAYIT penceresini açmak için bunu yazıyoruz hocam
            Ogrencikayit Kayitogrenciformu = new Ogrencikayit();
            Kayitogrenciformu.Show();
        }


    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
