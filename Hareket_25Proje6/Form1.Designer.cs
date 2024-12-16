namespace Hareket_25Proje6
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._DbHareket_25Proje_6DataSet = new Hareket_25Proje6._DbHareket_25Proje_6DataSet();
            this.hareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hareketTableAdapter = new Hareket_25Proje6._DbHareket_25Proje_6DataSetTableAdapters.HareketTableAdapter();
            this.hareketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.cbxSatici = new System.Windows.Forms.ComboBox();
            this.cbxMusteri = new System.Windows.Forms.ComboBox();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DbHareket_25Proje_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareketIdDataGridViewTextBoxColumn,
            this.ürünDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.müşteriDataGridViewTextBoxColumn,
            this.satıcıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hareketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(802, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _DbHareket_25Proje_6DataSet
            // 
            this._DbHareket_25Proje_6DataSet.DataSetName = "_DbHareket_25Proje_6DataSet";
            this._DbHareket_25Proje_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hareketBindingSource
            // 
            this.hareketBindingSource.DataMember = "Hareket";
            this.hareketBindingSource.DataSource = this._DbHareket_25Proje_6DataSet;
            // 
            // hareketTableAdapter
            // 
            this.hareketTableAdapter.ClearBeforeFill = true;
            // 
            // hareketIdDataGridViewTextBoxColumn
            // 
            this.hareketIdDataGridViewTextBoxColumn.DataPropertyName = "HareketId";
            this.hareketIdDataGridViewTextBoxColumn.HeaderText = "HareketId";
            this.hareketIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hareketIdDataGridViewTextBoxColumn.Name = "hareketIdDataGridViewTextBoxColumn";
            this.hareketIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ürünDataGridViewTextBoxColumn
            // 
            this.ürünDataGridViewTextBoxColumn.DataPropertyName = "Ürün";
            this.ürünDataGridViewTextBoxColumn.HeaderText = "Ürün";
            this.ürünDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ürünDataGridViewTextBoxColumn.Name = "ürünDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // müşteriDataGridViewTextBoxColumn
            // 
            this.müşteriDataGridViewTextBoxColumn.DataPropertyName = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.HeaderText = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.müşteriDataGridViewTextBoxColumn.Name = "müşteriDataGridViewTextBoxColumn";
            // 
            // satıcıDataGridViewTextBoxColumn
            // 
            this.satıcıDataGridViewTextBoxColumn.DataPropertyName = "Satıcı";
            this.satıcıDataGridViewTextBoxColumn.HeaderText = "Satıcı";
            this.satıcıDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.satıcıDataGridViewTextBoxColumn.Name = "satıcıDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(609, 73);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 38);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(286, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(306, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Satıcı :";
            // 
            // cbxUrun
            // 
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Location = new System.Drawing.Point(130, 46);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(121, 28);
            this.cbxUrun.TabIndex = 10;
            // 
            // cbxSatici
            // 
            this.cbxSatici.FormattingEnabled = true;
            this.cbxSatici.Location = new System.Drawing.Point(385, 107);
            this.cbxSatici.Name = "cbxSatici";
            this.cbxSatici.Size = new System.Drawing.Size(121, 28);
            this.cbxSatici.TabIndex = 13;
            // 
            // cbxMusteri
            // 
            this.cbxMusteri.FormattingEnabled = true;
            this.cbxMusteri.Location = new System.Drawing.Point(385, 46);
            this.cbxMusteri.Name = "cbxMusteri";
            this.cbxMusteri.Size = new System.Drawing.Size(121, 28);
            this.cbxMusteri.TabIndex = 12;
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(130, 108);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(121, 26);
            this.tbxFiyat.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(801, 515);
            this.Controls.Add(this.tbxFiyat);
            this.Controls.Add(this.cbxSatici);
            this.Controls.Add(this.cbxMusteri);
            this.Controls.Add(this.cbxUrun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DbHareket_25Proje_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _DbHareket_25Proje_6DataSet _DbHareket_25Proje_6DataSet;
        private System.Windows.Forms.BindingSource hareketBindingSource;
        private _DbHareket_25Proje_6DataSetTableAdapters.HareketTableAdapter hareketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxUrun;
        private System.Windows.Forms.ComboBox cbxSatici;
        private System.Windows.Forms.ComboBox cbxMusteri;
        private System.Windows.Forms.TextBox tbxFiyat;
    }
}

