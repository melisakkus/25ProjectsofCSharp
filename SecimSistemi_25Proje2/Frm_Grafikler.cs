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
    public partial class Frm_Grafikler : Form
    {
        public Frm_Grafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=DbSecim_25Proje.2;Integrated Security=True");

        private void Frm_Grafikler_Load(object sender, EventArgs e)
        {
            //ilçe listeleme
            baglanti.Open();
            SqlCommand komutIlceler = new SqlCommand("Select IlceAd from Tbl_Ilce",baglanti);
            SqlDataReader dataReader = komutIlceler.ExecuteReader();
            while (dataReader.Read()) 
            {
                cbxIlceSecim.Items.Add(dataReader[0]);
            }
            dataReader.Close();
            baglanti.Close();

            //grafiğe sonuç çekme 
            baglanti.Open();
            SqlCommand komutGrafik = new SqlCommand("Select Sum(AParti),Sum(BParti),Sum(CParti),Sum(DParti),Sum(EParti) from Tbl_Ilce", baglanti);
            SqlDataReader dataReader2 = komutGrafik.ExecuteReader();
            while (dataReader2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti",dataReader2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dataReader2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dataReader2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dataReader2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dataReader2[4]);
            }
            dataReader2.Close();
            baglanti.Close();
        }

        private void cbxIlceSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //progress bar düzenleme
            baglanti.Open();
            SqlCommand komutProgressBar = new SqlCommand("Select * from Tbl_Ilce where IlceAd = @pIlce", baglanti);
            komutProgressBar.Parameters.AddWithValue("@pIlce",cbxIlceSecim.Text);
            SqlDataReader dataReader = komutProgressBar.ExecuteReader();
            while (dataReader.Read())
            {
                progressA.Value = int.Parse(dataReader[2].ToString());
                progressB.Value = int.Parse(dataReader[3].ToString());
                progressC.Value = int.Parse(dataReader[4].ToString());
                progressD.Value = int.Parse(dataReader[5].ToString());
                progressE.Value = int.Parse(dataReader[6].ToString());

                lblA.Text = dataReader[2].ToString();
                lblB.Text = dataReader[3].ToString();
                lblC.Text = dataReader[4].ToString();
                lblD.Text = dataReader[5].ToString();
                lblE.Text = dataReader[6].ToString();
            }
            dataReader.Close();
            baglanti.Close();
        }
    }
}
