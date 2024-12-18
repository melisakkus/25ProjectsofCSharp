using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneHareket_25Proje8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            footballer.Left -= 5;
            runningman1.Left -= 5;
            runningman2.Left -= 5;
            runningman3.Left += 5;
            if(footballer.Left <= 290)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            footballer.Top = footballer.Top + 10;
            runningman2.Top = runningman2.Top + 5;
            runningman1.Left = runningman1.Left -3;
            footballer.Left = footballer.Left - 10;
            runningman3.Left = runningman3.Left + 1;
            if(footballer.Left <= 200)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            footballer.Top -= 5;
            footballer.Left -= 10;
            if(footballer.Left <= 100)
            {
                timer3.Stop();
                MessageBox.Show("Game Over","Finish",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
