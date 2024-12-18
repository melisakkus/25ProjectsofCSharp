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

namespace KelimeOgren_25Proje7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=DbKelimeOgren_25Proje.7;Integrated Security=True;");

        Random random = new Random();
        int sure = 90;
        int kelime = 0;
        public string kullaniciAdi;
        public void KelimeGetir()
        {
            int sayi;
            sayi = random.Next(1, 201);
            lblCevap.Text = sayi.ToString();

            connection.Open();
            SqlCommand engGetir = new SqlCommand("Select * from TblWords where id=@p1", connection);
            engGetir.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader reader = engGetir.ExecuteReader();
            while (reader.Read())
            {
                tbxIng.Text = reader[1].ToString();
                lblCevap.Text = reader[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = kullaniciAdi.ToString();
            KelimeGetir();
            timer1.Start();
        }

        private void tbxTurkce_TextChanged(object sender, EventArgs e)
        {
            tbxTurkce.Text = tbxTurkce.Text.ToLower();
            if(tbxTurkce.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                KelimeGetir();
                tbxTurkce.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                tbxTurkce.Enabled = false;
                tbxIng.Enabled = false;
                MessageBox.Show("Süre doldu! Doğru bilinen kelime sayısı : "+ kelime,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
