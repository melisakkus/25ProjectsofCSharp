namespace NotKayit
{
    partial class Frm_OgretmenDetay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OgretmenDetay));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbxGecen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSinav2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSinav1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mtbxNumara = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxKalan = new System.Windows.Forms.TextBox();
            this.dbNotKayitDataSet = new NotKayit.DbNotKayitDataSet();
            this.tblDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DersTableAdapter = new NotKayit.DbNotKayitDataSetTableAdapters.Tbl_DersTableAdapter();
            this.ogrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinav1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinav2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinav3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(74, 218);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 41);
            this.btnGuncelle.TabIndex = 44;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(171, 220);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 39);
            this.btnKaydet.TabIndex = 43;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbxGecen
            // 
            this.tbxGecen.Location = new System.Drawing.Point(196, 102);
            this.tbxGecen.Name = "tbxGecen";
            this.tbxGecen.Size = new System.Drawing.Size(81, 26);
            this.tbxGecen.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(22, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Geçen Sayısı :";
            // 
            // tbxOrtalama
            // 
            this.tbxOrtalama.Location = new System.Drawing.Point(196, 61);
            this.tbxOrtalama.Name = "tbxOrtalama";
            this.tbxOrtalama.Size = new System.Drawing.Size(81, 26);
            this.tbxOrtalama.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(53, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ortalama :";
            // 
            // tbxSinav3
            // 
            this.tbxSinav3.Location = new System.Drawing.Point(146, 146);
            this.tbxSinav3.Name = "tbxSinav3";
            this.tbxSinav3.Size = new System.Drawing.Size(89, 26);
            this.tbxSinav3.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Sınav 3 :";
            // 
            // tbxSinav2
            // 
            this.tbxSinav2.Location = new System.Drawing.Point(146, 104);
            this.tbxSinav2.Name = "tbxSinav2";
            this.tbxSinav2.Size = new System.Drawing.Size(89, 26);
            this.tbxSinav2.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(32, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sınav 2 :";
            // 
            // tbxSinav1
            // 
            this.tbxSinav1.Location = new System.Drawing.Point(146, 63);
            this.tbxSinav1.Name = "tbxSinav1";
            this.tbxSinav1.Size = new System.Drawing.Size(89, 26);
            this.tbxSinav1.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(35, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Sınav 1 :";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(171, 168);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(100, 26);
            this.tbxSoyad.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(71, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Soyad :";
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(171, 127);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(100, 26);
            this.tbxAd.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(105, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Numara :";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(171, 44);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 26);
            this.tbxId.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Öğrenci Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIdDataGridViewTextBoxColumn,
            this.ogrenciNumaraDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.sinav1DataGridViewTextBoxColumn,
            this.sinav2DataGridViewTextBoxColumn,
            this.sinav3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblDersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(893, 231);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mtbxNumara
            // 
            this.mtbxNumara.Location = new System.Drawing.Point(171, 87);
            this.mtbxNumara.Mask = "0000";
            this.mtbxNumara.Name = "mtbxNumara";
            this.mtbxNumara.Size = new System.Drawing.Size(100, 26);
            this.mtbxNumara.TabIndex = 46;
            this.mtbxNumara.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxId);
            this.groupBox1.Controls.Add(this.mtbxNumara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.tbxAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxSoyad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 276);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kaydet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxSinav1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxSinav2);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxSinav3);
            this.groupBox2.Location = new System.Drawing.Point(340, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 275);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbxKalan);
            this.groupBox3.Controls.Add(this.tbxOrtalama);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbxGecen);
            this.groupBox3.Location = new System.Drawing.Point(616, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 275);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgiler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(24, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Kalan Sayısı :";
            // 
            // tbxKalan
            // 
            this.tbxKalan.Location = new System.Drawing.Point(196, 150);
            this.tbxKalan.Name = "tbxKalan";
            this.tbxKalan.Size = new System.Drawing.Size(81, 26);
            this.tbxKalan.TabIndex = 43;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDersBindingSource
            // 
            this.tblDersBindingSource.DataMember = "Tbl_Ders";
            this.tblDersBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // tbl_DersTableAdapter
            // 
            this.tbl_DersTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIdDataGridViewTextBoxColumn
            // 
            this.ogrenciIdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.HeaderText = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrenciIdDataGridViewTextBoxColumn.Name = "ogrenciIdDataGridViewTextBoxColumn";
            this.ogrenciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciNumaraDataGridViewTextBoxColumn
            // 
            this.ogrenciNumaraDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNumara";
            this.ogrenciNumaraDataGridViewTextBoxColumn.HeaderText = "OgrenciNumara";
            this.ogrenciNumaraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrenciNumaraDataGridViewTextBoxColumn.Name = "ogrenciNumaraDataGridViewTextBoxColumn";
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // sinav1DataGridViewTextBoxColumn
            // 
            this.sinav1DataGridViewTextBoxColumn.DataPropertyName = "Sinav1";
            this.sinav1DataGridViewTextBoxColumn.HeaderText = "Sinav1";
            this.sinav1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sinav1DataGridViewTextBoxColumn.Name = "sinav1DataGridViewTextBoxColumn";
            // 
            // sinav2DataGridViewTextBoxColumn
            // 
            this.sinav2DataGridViewTextBoxColumn.DataPropertyName = "Sinav2";
            this.sinav2DataGridViewTextBoxColumn.HeaderText = "Sinav2";
            this.sinav2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sinav2DataGridViewTextBoxColumn.Name = "sinav2DataGridViewTextBoxColumn";
            // 
            // sinav3DataGridViewTextBoxColumn
            // 
            this.sinav3DataGridViewTextBoxColumn.DataPropertyName = "Sinav3";
            this.sinav3DataGridViewTextBoxColumn.HeaderText = "Sinav3";
            this.sinav3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sinav3DataGridViewTextBoxColumn.Name = "sinav3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // Frm_OgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(918, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_OgretmenDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen";
            this.Load += new System.EventHandler(this.Frm_OgretmenDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbxGecen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSinav2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSinav1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtbxNumara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxKalan;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tblDersBindingSource;
        private DbNotKayitDataSetTableAdapters.Tbl_DersTableAdapter tbl_DersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinav1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinav2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinav3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}