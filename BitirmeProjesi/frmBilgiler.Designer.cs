namespace BitirmeProjesi
{
    partial class frmBilgiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOgrenciRapor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mezuniyetTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evUlkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBilgilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mezunlarDataSet1 = new BitirmeProjesi.MezunlarDataSet1();
            this.tblBilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBilgilerTableAdapter = new BitirmeProjesi.MezunlarDataSet1TableAdapters.tblBilgilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBilgilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBilgilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mezun Bilgi Sistemi";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.ForeColor = System.Drawing.Color.Black;
            this.btnYeniKayit.Location = new System.Drawing.Point(34, 86);
            this.btnYeniKayit.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(78, 31);
            this.btnYeniKayit.TabIndex = 2;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(116, 86);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 31);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnOgrenciRapor
            // 
            this.btnOgrenciRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciRapor.ForeColor = System.Drawing.Color.Black;
            this.btnOgrenciRapor.Location = new System.Drawing.Point(198, 86);
            this.btnOgrenciRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgrenciRapor.Name = "btnOgrenciRapor";
            this.btnOgrenciRapor.Size = new System.Drawing.Size(160, 31);
            this.btnOgrenciRapor.TabIndex = 4;
            this.btnOgrenciRapor.Text = "Öğrenci Listesi Rapor";
            this.btnOgrenciRapor.UseVisualStyleBackColor = true;
            this.btnOgrenciRapor.Click += new System.EventHandler(this.btnOgrenciRapor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.mezuniyetTarihiDataGridViewTextBoxColumn,
            this.cepTelDataGridViewTextBoxColumn,
            this.ePostaDataGridViewTextBoxColumn,
            this.evTelDataGridViewTextBoxColumn,
            this.evUlkeDataGridViewTextBoxColumn,
            this.evSehirDataGridViewTextBoxColumn,
            this.evAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBilgilerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 264);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciNoDataGridViewTextBoxColumn
            // 
            this.ogrenciNoDataGridViewTextBoxColumn.DataPropertyName = "ogrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.HeaderText = "ogrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciNoDataGridViewTextBoxColumn.Name = "ogrenciNoDataGridViewTextBoxColumn";
            this.ogrenciNoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ogrenciNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ogrenciNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // mezuniyetTarihiDataGridViewTextBoxColumn
            // 
            this.mezuniyetTarihiDataGridViewTextBoxColumn.DataPropertyName = "mezuniyetTarihi";
            this.mezuniyetTarihiDataGridViewTextBoxColumn.HeaderText = "mezuniyetTarihi";
            this.mezuniyetTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mezuniyetTarihiDataGridViewTextBoxColumn.Name = "mezuniyetTarihiDataGridViewTextBoxColumn";
            this.mezuniyetTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cepTelDataGridViewTextBoxColumn
            // 
            this.cepTelDataGridViewTextBoxColumn.DataPropertyName = "cepTel";
            this.cepTelDataGridViewTextBoxColumn.HeaderText = "cepTel";
            this.cepTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cepTelDataGridViewTextBoxColumn.Name = "cepTelDataGridViewTextBoxColumn";
            this.cepTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // ePostaDataGridViewTextBoxColumn
            // 
            this.ePostaDataGridViewTextBoxColumn.DataPropertyName = "ePosta";
            this.ePostaDataGridViewTextBoxColumn.HeaderText = "ePosta";
            this.ePostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ePostaDataGridViewTextBoxColumn.Name = "ePostaDataGridViewTextBoxColumn";
            this.ePostaDataGridViewTextBoxColumn.Width = 125;
            // 
            // evTelDataGridViewTextBoxColumn
            // 
            this.evTelDataGridViewTextBoxColumn.DataPropertyName = "evTel";
            this.evTelDataGridViewTextBoxColumn.HeaderText = "evTel";
            this.evTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evTelDataGridViewTextBoxColumn.Name = "evTelDataGridViewTextBoxColumn";
            this.evTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // evUlkeDataGridViewTextBoxColumn
            // 
            this.evUlkeDataGridViewTextBoxColumn.DataPropertyName = "evUlke";
            this.evUlkeDataGridViewTextBoxColumn.HeaderText = "evUlke";
            this.evUlkeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evUlkeDataGridViewTextBoxColumn.Name = "evUlkeDataGridViewTextBoxColumn";
            this.evUlkeDataGridViewTextBoxColumn.Width = 125;
            // 
            // evSehirDataGridViewTextBoxColumn
            // 
            this.evSehirDataGridViewTextBoxColumn.DataPropertyName = "evSehir";
            this.evSehirDataGridViewTextBoxColumn.HeaderText = "evSehir";
            this.evSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evSehirDataGridViewTextBoxColumn.Name = "evSehirDataGridViewTextBoxColumn";
            this.evSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // evAdresDataGridViewTextBoxColumn
            // 
            this.evAdresDataGridViewTextBoxColumn.DataPropertyName = "evAdres";
            this.evAdresDataGridViewTextBoxColumn.HeaderText = "evAdres";
            this.evAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evAdresDataGridViewTextBoxColumn.Name = "evAdresDataGridViewTextBoxColumn";
            this.evAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblBilgilerBindingSource1
            // 
            this.tblBilgilerBindingSource1.DataMember = "tblBilgiler";
            this.tblBilgilerBindingSource1.DataSource = this.mezunlarDataSet1;
            // 
            // mezunlarDataSet1
            // 
            this.mezunlarDataSet1.DataSetName = "MezunlarDataSet1";
            this.mezunlarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBilgilerBindingSource
            // 
            this.tblBilgilerBindingSource.DataMember = "tblBilgiler";
            this.tblBilgilerBindingSource.DataSource = this.mezunlarDataSet1;
            // 
            // tblBilgilerTableAdapter
            // 
            this.tblBilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // frmBilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOgrenciRapor);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBilgiler";
            this.Text = "Öğrenciler";
            this.Load += new System.EventHandler(this.frmBilgiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBilgilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBilgilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOgrenciRapor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MezunlarDataSet1 mezunlarDataSet1;
        private System.Windows.Forms.BindingSource tblBilgilerBindingSource;
        private MezunlarDataSet1TableAdapters.tblBilgilerTableAdapter tblBilgilerTableAdapter;
        private System.Windows.Forms.DataGridViewLinkColumn ogrenciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mezuniyetTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evUlkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblBilgilerBindingSource1;
    }
}