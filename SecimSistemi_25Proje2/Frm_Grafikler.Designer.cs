namespace SecimSistemi_25Proje2
{
    partial class Frm_Grafikler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Grafikler));
            this.gbxGrafikler = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxIlceDegerleri = new System.Windows.Forms.GroupBox();
            this.progressE = new System.Windows.Forms.ProgressBar();
            this.progressD = new System.Windows.Forms.ProgressBar();
            this.progressC = new System.Windows.Forms.ProgressBar();
            this.progressB = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressA = new System.Windows.Forms.ProgressBar();
            this.cbxIlceSecim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.gbxGrafikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbxIlceDegerleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGrafikler
            // 
            this.gbxGrafikler.Controls.Add(this.chart1);
            this.gbxGrafikler.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.gbxGrafikler.Location = new System.Drawing.Point(31, 26);
            this.gbxGrafikler.Name = "gbxGrafikler";
            this.gbxGrafikler.Size = new System.Drawing.Size(614, 247);
            this.gbxGrafikler.TabIndex = 0;
            this.gbxGrafikler.TabStop = false;
            this.gbxGrafikler.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 26);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(608, 218);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // gbxIlceDegerleri
            // 
            this.gbxIlceDegerleri.Controls.Add(this.lblE);
            this.gbxIlceDegerleri.Controls.Add(this.lblD);
            this.gbxIlceDegerleri.Controls.Add(this.lblC);
            this.gbxIlceDegerleri.Controls.Add(this.lblB);
            this.gbxIlceDegerleri.Controls.Add(this.lblA);
            this.gbxIlceDegerleri.Controls.Add(this.progressE);
            this.gbxIlceDegerleri.Controls.Add(this.progressD);
            this.gbxIlceDegerleri.Controls.Add(this.progressC);
            this.gbxIlceDegerleri.Controls.Add(this.progressB);
            this.gbxIlceDegerleri.Controls.Add(this.label6);
            this.gbxIlceDegerleri.Controls.Add(this.label5);
            this.gbxIlceDegerleri.Controls.Add(this.label4);
            this.gbxIlceDegerleri.Controls.Add(this.label3);
            this.gbxIlceDegerleri.Controls.Add(this.label2);
            this.gbxIlceDegerleri.Controls.Add(this.progressA);
            this.gbxIlceDegerleri.Controls.Add(this.cbxIlceSecim);
            this.gbxIlceDegerleri.Controls.Add(this.label1);
            this.gbxIlceDegerleri.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.gbxIlceDegerleri.Location = new System.Drawing.Point(28, 279);
            this.gbxIlceDegerleri.Name = "gbxIlceDegerleri";
            this.gbxIlceDegerleri.Size = new System.Drawing.Size(617, 387);
            this.gbxIlceDegerleri.TabIndex = 1;
            this.gbxIlceDegerleri.TabStop = false;
            this.gbxIlceDegerleri.Text = "İlçe Değerleri";
            // 
            // progressE
            // 
            this.progressE.Location = new System.Drawing.Point(176, 310);
            this.progressE.Maximum = 200;
            this.progressE.Name = "progressE";
            this.progressE.Size = new System.Drawing.Size(338, 35);
            this.progressE.TabIndex = 19;
            // 
            // progressD
            // 
            this.progressD.Location = new System.Drawing.Point(176, 256);
            this.progressD.Maximum = 200;
            this.progressD.Name = "progressD";
            this.progressD.Size = new System.Drawing.Size(338, 35);
            this.progressD.TabIndex = 18;
            // 
            // progressC
            // 
            this.progressC.Location = new System.Drawing.Point(176, 202);
            this.progressC.Maximum = 200;
            this.progressC.Name = "progressC";
            this.progressC.Size = new System.Drawing.Size(338, 35);
            this.progressC.TabIndex = 17;
            // 
            // progressB
            // 
            this.progressB.Location = new System.Drawing.Point(176, 148);
            this.progressB.Maximum = 200;
            this.progressB.Name = "progressB";
            this.progressB.Size = new System.Drawing.Size(338, 35);
            this.progressB.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(83, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "E Parti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(82, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "D Parti :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(83, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "C Parti :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "B Parti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "A Parti :";
            // 
            // progressA
            // 
            this.progressA.Location = new System.Drawing.Point(176, 94);
            this.progressA.Maximum = 200;
            this.progressA.Name = "progressA";
            this.progressA.Size = new System.Drawing.Size(338, 35);
            this.progressA.TabIndex = 4;
            // 
            // cbxIlceSecim
            // 
            this.cbxIlceSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIlceSecim.FormattingEnabled = true;
            this.cbxIlceSecim.Location = new System.Drawing.Point(176, 43);
            this.cbxIlceSecim.Name = "cbxIlceSecim";
            this.cbxIlceSecim.Size = new System.Drawing.Size(178, 32);
            this.cbxIlceSecim.TabIndex = 1;
            this.cbxIlceSecim.SelectedIndexChanged += new System.EventHandler(this.cbxIlceSecim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlçe Seçim :";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(521, 102);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 24);
            this.lblA.TabIndex = 20;
            this.lblA.Text = "0";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(521, 155);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 24);
            this.lblB.TabIndex = 21;
            this.lblB.Text = "0";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(520, 261);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(24, 24);
            this.lblD.TabIndex = 23;
            this.lblD.Text = "0";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(520, 210);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(24, 24);
            this.lblC.TabIndex = 22;
            this.lblC.Text = "0";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(520, 314);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(24, 24);
            this.lblE.TabIndex = 24;
            this.lblE.Text = "0";
            // 
            // Frm_Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(657, 678);
            this.Controls.Add(this.gbxIlceDegerleri);
            this.Controls.Add(this.gbxGrafikler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Grafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Frm_Grafikler_Load);
            this.gbxGrafikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbxIlceDegerleri.ResumeLayout(false);
            this.gbxIlceDegerleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGrafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox gbxIlceDegerleri;
        private System.Windows.Forms.ComboBox cbxIlceSecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressE;
        private System.Windows.Forms.ProgressBar progressD;
        private System.Windows.Forms.ProgressBar progressC;
        private System.Windows.Forms.ProgressBar progressB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
    }
}