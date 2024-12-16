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
        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi;
            sayi = random.Next(1,201);
            lblCevap.Text = sayi.ToString();

            connection.Open();
            SqlCommand engGetir = new SqlCommand("Select ingilizce from TblWords where id=@p1",connection);
            engGetir.Parameters.AddWithValue("@p1",sayi);

        }
    }
}
