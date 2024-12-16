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
    public partial class Frm_OgrenciGiris : Form
    {
        public Frm_OgrenciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_OgrenciDetay detay = new Frm_OgrenciDetay();
            detay.OgrenciNo = maskedTbxNo.Text;
            detay.ShowDialog();
            this.Hide();
        }

        
        private void Frm_OgrenciGiris_Load(object sender, EventArgs e)
        {
        }
    }
}
