using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_OgrenciGiris ogrenciGiriş = new Frm_OgrenciGiris();
            ogrenciGiriş.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_OgretmenDetay ogretmenDetay = new Frm_OgretmenDetay();
            ogretmenDetay.ShowDialog();
            
        }
    }
}
