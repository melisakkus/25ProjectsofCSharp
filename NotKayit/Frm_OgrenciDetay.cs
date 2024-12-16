using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotKayit
{
    public partial class Frm_OgrenciDetay : Form
    {
        public Frm_OgrenciDetay()
        {
            InitializeComponent();
        }

        public string OgrenciNo;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-B6FJQDJ\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void Frm_OgrenciDetay_Load(object sender, EventArgs e)
        {
            maskedTbxNo.Text = OgrenciNo;
            baglanti.Open();
            SqlCommand komutBilgiAl = new SqlCommand("Select * from Tbl_Ders where OgrenciNumara =@pNumara ",baglanti);
            komutBilgiAl.Parameters.AddWithValue("@pNumara", maskedTbxNo.Text);
            SqlDataReader dataReader = komutBilgiAl.ExecuteReader();
            while (dataReader.Read())
            {
                tbxId.Text = dataReader[0].ToString();
                tbxAd.Text = dataReader[2].ToString();
                tbxSoyad.Text = dataReader[3].ToString();
                tbxSinav1.Text = dataReader[4].ToString();
                tbxSinav2.Text = dataReader[5].ToString();
                tbxSinav3.Text = dataReader[6].ToString();
                tbxOrtalama.Text = dataReader[7].ToString();

                if (dataReader[8].ToString() == "True")
                {
                    tbxDurum.Text = "Geçti :)";
                }
                else
                {
                    tbxDurum.Text = "Kaldı :(";
                }
            }
            dataReader.Close();
            baglanti.Close();
        }

    }
}
