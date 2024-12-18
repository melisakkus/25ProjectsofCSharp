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

namespace KelimeOgren_25Proje7
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=DbKelimeOgren_25Proje.7;Integrated Security=True;");
        
        private void btnKayitYap_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komutGiris = new SqlCommand("Select * from TblKullaniciKayit",connection);
            SqlDataReader reader = komutGiris.ExecuteReader();
            while (reader.Read())
            {
                if (reader[1].ToString() == tbxKullaniciAdi.Text && reader[2].ToString() == tbxSifre.Text)
                {
                    Form1 form1 = new Form1();
                    form1.kullaniciAdi = tbxKullaniciAdi.Text; 
                    form1.Show();
                }
            }
            connection.Close();
        }
    }
}
