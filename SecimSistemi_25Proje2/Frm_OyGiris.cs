using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecimSistemi_25Proje2
{
    public partial class Frm_OyGiris : Form
    {
        public Frm_OyGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Grafikler grafikForm = new Frm_Grafikler();
            grafikForm.ShowDialog();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=DbSecim_25Proje.2;Integrated Security=True");
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Ilce (IlceAd,AParti,BParti,CParti,DParti,EParti) values (@pIlceAd,@pA,@pB,@pC,@pD,@pE)",baglanti);
            komutEkle.Parameters.AddWithValue("@pIlceAd", tbxIlceAd.Text);
            komutEkle.Parameters.AddWithValue("@pA",tbxA.Text);
            komutEkle.Parameters.AddWithValue("@pB",tbxB.Text);
            komutEkle.Parameters.AddWithValue("@pC",tbxC.Text);
            komutEkle.Parameters.AddWithValue("@pD",tbxD.Text);
            komutEkle.Parameters.AddWithValue("@pE",tbxE.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi yapıldı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Temizleme();
        }

        public void Temizleme()
        {
            tbxIlceAd.Clear();
            tbxA.Clear();
            tbxB.Clear();
            tbxC.Clear();
            tbxD.Clear();
            tbxE.Clear();
        }
    }
}
