using System;

namespace BitirmeProjesi
{
    partial class frmKayit
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
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblMezuniyetTa = new System.Windows.Forms.Label();
            this.lblePosta = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.lblEvTel = new System.Windows.Forms.Label();
            this.lblEvUlke = new System.Windows.Forms.Label();
            this.lblEvSehir = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtMTarih = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEvTel = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonKayitGuncelle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEgitimSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.txtEgtmsehir = new System.Windows.Forms.TextBox();
            this.txtEgtmUlke = new System.Windows.Forms.TextBox();
            this.txtEgtmBitis = new System.Windows.Forms.TextBox();
            this.txtEgtmBaslangic = new System.Windows.Forms.TextBox();
            this.txtEgtmAkademik = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEgitimEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonIsSil = new System.Windows.Forms.Button();
            this.txtpozisyon = new System.Windows.Forms.TextBox();
            this.txtunvan = new System.Windows.Forms.TextBox();
            this.txtsektor = new System.Windows.Forms.TextBox();
            this.txtkamu = new System.Windows.Forms.TextBox();
            this.txtAyrilis = new System.Windows.Forms.TextBox();
            this.txtIsGiris = new System.Windows.Forms.TextBox();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblSektor = new System.Windows.Forms.Label();
            this.lblKamuOzel = new System.Windows.Forms.Label();
            this.lblIsAyrılıs = new System.Windows.Forms.Label();
            this.lblIsGiris = new System.Windows.Forms.Label();
            this.btnIsEkle = new System.Windows.Forms.Button();
            this.gridIs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.mezunlarDataSet1 = new BitirmeProjesi.MezunlarDataSet1();
            this.btnKapat = new System.Windows.Forms.Button();
            this.mezunlarDataSet2 = new BitirmeProjesi.MezunlarDataSet2();
            this.mezunlarDataSet = new BitirmeProjesi.MezunlarDataSet();
            this.mezunlarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciNo.Location = new System.Drawing.Point(8, 60);
            this.lblOgrenciNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(78, 16);
            this.lblOgrenciNo.TabIndex = 0;
            this.lblOgrenciNo.Text = "Öğrenci No:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(8, 92);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 16);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(8, 125);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 16);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblMezuniyetTa
            // 
            this.lblMezuniyetTa.AutoSize = true;
            this.lblMezuniyetTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMezuniyetTa.Location = new System.Drawing.Point(4, 165);
            this.lblMezuniyetTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMezuniyetTa.Name = "lblMezuniyetTa";
            this.lblMezuniyetTa.Size = new System.Drawing.Size(107, 16);
            this.lblMezuniyetTa.TabIndex = 3;
            this.lblMezuniyetTa.Text = "Mezuniyet Tarihi:";
            // 
            // lblePosta
            // 
            this.lblePosta.AutoSize = true;
            this.lblePosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblePosta.Location = new System.Drawing.Point(4, 202);
            this.lblePosta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblePosta.Name = "lblePosta";
            this.lblePosta.Size = new System.Drawing.Size(58, 16);
            this.lblePosta.TabIndex = 4;
            this.lblePosta.Text = "E-Posta:";
            // 
            // lblCepTel
            // 
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCepTel.Location = new System.Drawing.Point(2, 245);
            this.lblCepTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(91, 16);
            this.lblCepTel.TabIndex = 5;
            this.lblCepTel.Text = "Cep Telefonu:";
            // 
            // lblEvTel
            // 
            this.lblEvTel.AutoSize = true;
            this.lblEvTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvTel.Location = new System.Drawing.Point(4, 280);
            this.lblEvTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvTel.Name = "lblEvTel";
            this.lblEvTel.Size = new System.Drawing.Size(82, 16);
            this.lblEvTel.TabIndex = 6;
            this.lblEvTel.Text = "Ev Telefonu:";
            // 
            // lblEvUlke
            // 
            this.lblEvUlke.AutoSize = true;
            this.lblEvUlke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvUlke.Location = new System.Drawing.Point(309, 60);
            this.lblEvUlke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvUlke.Name = "lblEvUlke";
            this.lblEvUlke.Size = new System.Drawing.Size(57, 16);
            this.lblEvUlke.TabIndex = 7;
            this.lblEvUlke.Text = "Ev Ulke:";
            // 
            // lblEvSehir
            // 
            this.lblEvSehir.AutoSize = true;
            this.lblEvSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvSehir.Location = new System.Drawing.Point(309, 98);
            this.lblEvSehir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvSehir.Name = "lblEvSehir";
            this.lblEvSehir.Size = new System.Drawing.Size(60, 16);
            this.lblEvSehir.TabIndex = 8;
            this.lblEvSehir.Text = "Ev Sehir:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(309, 144);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(46, 16);
            this.lblAdres.TabIndex = 9;
            this.lblAdres.Text = "Adres:";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(308, 184);
            this.lblNot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(46, 16);
            this.lblNot.TabIndex = 10;
            this.lblNot.Text = "Notlar:";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(115, 56);
            this.txtOgrenciNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(107, 20);
            this.txtOgrenciNo.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(115, 91);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(107, 20);
            this.txtAd.TabIndex = 12;
            // 
            // txtMTarih
            // 
            this.txtMTarih.Location = new System.Drawing.Point(115, 161);
            this.txtMTarih.Margin = new System.Windows.Forms.Padding(2);
            this.txtMTarih.Name = "txtMTarih";
            this.txtMTarih.Size = new System.Drawing.Size(107, 20);
            this.txtMTarih.TabIndex = 13;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(115, 195);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(107, 20);
            this.txtEposta.TabIndex = 14;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(115, 124);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(107, 20);
            this.txtSoyad.TabIndex = 15;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(115, 238);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(107, 20);
            this.txtCep.TabIndex = 16;
            // 
            // txtEvTel
            // 
            this.txtEvTel.Location = new System.Drawing.Point(115, 277);
            this.txtEvTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvTel.Name = "txtEvTel";
            this.txtEvTel.Size = new System.Drawing.Size(107, 20);
            this.txtEvTel.TabIndex = 17;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(392, 56);
            this.txtUlke.Margin = new System.Windows.Forms.Padding(2);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(107, 20);
            this.txtUlke.TabIndex = 18;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(392, 98);
            this.txtSehir.Margin = new System.Windows.Forms.Padding(2);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(107, 20);
            this.txtSehir.TabIndex = 19;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(392, 137);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(107, 20);
            this.txtAdres.TabIndex = 20;
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(392, 177);
            this.txtNotlar.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(107, 20);
            this.txtNotlar.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mezun Bilgi Sistemi";
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitEkle.ForeColor = System.Drawing.Color.Red;
            this.btnKayitEkle.Location = new System.Drawing.Point(332, 362);
            this.btnKayitEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(93, 33);
            this.btnKayitEkle.TabIndex = 25;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 437);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonKayitGuncelle);
            this.tabPage1.Controls.Add(this.btnKayitEkle);
            this.tabPage1.Controls.Add(this.lblOgrenciNo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblAd);
            this.tabPage1.Controls.Add(this.lblSoyad);
            this.tabPage1.Controls.Add(this.txtNotlar);
            this.tabPage1.Controls.Add(this.lblMezuniyetTa);
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.lblePosta);
            this.tabPage1.Controls.Add(this.txtSehir);
            this.tabPage1.Controls.Add(this.lblCepTel);
            this.tabPage1.Controls.Add(this.txtUlke);
            this.tabPage1.Controls.Add(this.lblEvTel);
            this.tabPage1.Controls.Add(this.txtEvTel);
            this.tabPage1.Controls.Add(this.lblEvUlke);
            this.tabPage1.Controls.Add(this.txtCep);
            this.tabPage1.Controls.Add(this.lblEvSehir);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.lblAdres);
            this.tabPage1.Controls.Add(this.txtEposta);
            this.tabPage1.Controls.Add(this.lblNot);
            this.tabPage1.Controls.Add(this.txtMTarih);
            this.tabPage1.Controls.Add(this.txtOgrenciNo);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(837, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonKayitGuncelle
            // 
            this.buttonKayitGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonKayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitGuncelle.ForeColor = System.Drawing.Color.Black;
            this.buttonKayitGuncelle.Location = new System.Drawing.Point(332, 362);
            this.buttonKayitGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKayitGuncelle.Name = "buttonKayitGuncelle";
            this.buttonKayitGuncelle.Size = new System.Drawing.Size(109, 33);
            this.buttonKayitGuncelle.TabIndex = 28;
            this.buttonKayitGuncelle.Text = "Kayıt Güncelle";
            this.buttonKayitGuncelle.UseVisualStyleBackColor = true;
            this.buttonKayitGuncelle.Click += new System.EventHandler(this.buttonKayitGuncelle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonEgitimSil);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txtUni);
            this.tabPage2.Controls.Add(this.txtEgtmsehir);
            this.tabPage2.Controls.Add(this.txtEgtmUlke);
            this.tabPage2.Controls.Add(this.txtEgtmBitis);
            this.tabPage2.Controls.Add(this.txtEgtmBaslangic);
            this.tabPage2.Controls.Add(this.txtEgtmAkademik);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnEgitimEkle);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(837, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eğitim Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonEgitimSil
            // 
            this.buttonEgitimSil.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEgitimSil.ForeColor = System.Drawing.Color.Red;
            this.buttonEgitimSil.Location = new System.Drawing.Point(538, 194);
            this.buttonEgitimSil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEgitimSil.Name = "buttonEgitimSil";
            this.buttonEgitimSil.Size = new System.Drawing.Size(134, 33);
            this.buttonEgitimSil.TabIndex = 21;
            this.buttonEgitimSil.Text = "Sil";
            this.buttonEgitimSil.UseVisualStyleBackColor = true;
            this.buttonEgitimSil.Click += new System.EventHandler(this.buttonEgitimSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 125);
            this.dataGridView1.TabIndex = 20;
            // 
            // txtUni
            // 
            this.txtUni.Location = new System.Drawing.Point(288, 225);
            this.txtUni.Margin = new System.Windows.Forms.Padding(2);
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(103, 20);
            this.txtUni.TabIndex = 19;
            // 
            // txtEgtmsehir
            // 
            this.txtEgtmsehir.Location = new System.Drawing.Point(170, 225);
            this.txtEgtmsehir.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgtmsehir.Name = "txtEgtmsehir";
            this.txtEgtmsehir.Size = new System.Drawing.Size(88, 20);
            this.txtEgtmsehir.TabIndex = 18;
            this.txtEgtmsehir.TextChanged += new System.EventHandler(this.txtEgtmsehir_TextChanged);
            // 
            // txtEgtmUlke
            // 
            this.txtEgtmUlke.Location = new System.Drawing.Point(28, 225);
            this.txtEgtmUlke.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgtmUlke.Name = "txtEgtmUlke";
            this.txtEgtmUlke.Size = new System.Drawing.Size(111, 20);
            this.txtEgtmUlke.TabIndex = 17;
            // 
            // txtEgtmBitis
            // 
            this.txtEgtmBitis.Location = new System.Drawing.Point(298, 135);
            this.txtEgtmBitis.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgtmBitis.Name = "txtEgtmBitis";
            this.txtEgtmBitis.Size = new System.Drawing.Size(93, 20);
            this.txtEgtmBitis.TabIndex = 16;
            // 
            // txtEgtmBaslangic
            // 
            this.txtEgtmBaslangic.Location = new System.Drawing.Point(170, 135);
            this.txtEgtmBaslangic.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgtmBaslangic.Name = "txtEgtmBaslangic";
            this.txtEgtmBaslangic.Size = new System.Drawing.Size(88, 20);
            this.txtEgtmBaslangic.TabIndex = 15;
            // 
            // txtEgtmAkademik
            // 
            this.txtEgtmAkademik.Location = new System.Drawing.Point(28, 135);
            this.txtEgtmAkademik.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgtmAkademik.Name = "txtEgtmAkademik";
            this.txtEgtmAkademik.Size = new System.Drawing.Size(111, 20);
            this.txtEgtmAkademik.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(295, 194);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Üniversite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(172, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Şehir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(47, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ülke";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(308, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bitiş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(177, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Başlangıç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Akademik Eğitim";
            // 
            // btnEgitimEkle
            // 
            this.btnEgitimEkle.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgitimEkle.ForeColor = System.Drawing.Color.Red;
            this.btnEgitimEkle.Location = new System.Drawing.Point(538, 128);
            this.btnEgitimEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEgitimEkle.Name = "btnEgitimEkle";
            this.btnEgitimEkle.Size = new System.Drawing.Size(134, 33);
            this.btnEgitimEkle.TabIndex = 3;
            this.btnEgitimEkle.Text = "Ekle";
            this.btnEgitimEkle.UseVisualStyleBackColor = true;
            this.btnEgitimEkle.Click += new System.EventHandler(this.btnEgitimEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mezun Bilgi Sistemi";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonIsSil);
            this.tabPage3.Controls.Add(this.txtpozisyon);
            this.tabPage3.Controls.Add(this.txtunvan);
            this.tabPage3.Controls.Add(this.txtsektor);
            this.tabPage3.Controls.Add(this.txtkamu);
            this.tabPage3.Controls.Add(this.txtAyrilis);
            this.tabPage3.Controls.Add(this.txtIsGiris);
            this.tabPage3.Controls.Add(this.lblPozisyon);
            this.tabPage3.Controls.Add(this.lblUnvan);
            this.tabPage3.Controls.Add(this.lblSektor);
            this.tabPage3.Controls.Add(this.lblKamuOzel);
            this.tabPage3.Controls.Add(this.lblIsAyrılıs);
            this.tabPage3.Controls.Add(this.lblIsGiris);
            this.tabPage3.Controls.Add(this.btnIsEkle);
            this.tabPage3.Controls.Add(this.gridIs);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(837, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İş Bilgileri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonIsSil
            // 
            this.buttonIsSil.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIsSil.ForeColor = System.Drawing.Color.Red;
            this.buttonIsSil.Location = new System.Drawing.Point(554, 181);
            this.buttonIsSil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIsSil.Name = "buttonIsSil";
            this.buttonIsSil.Size = new System.Drawing.Size(138, 33);
            this.buttonIsSil.TabIndex = 22;
            this.buttonIsSil.Text = "Sil";
            this.buttonIsSil.UseVisualStyleBackColor = true;
            this.buttonIsSil.Click += new System.EventHandler(this.buttonIsSil_Click);
            // 
            // txtpozisyon
            // 
            this.txtpozisyon.Location = new System.Drawing.Point(134, 195);
            this.txtpozisyon.Margin = new System.Windows.Forms.Padding(2);
            this.txtpozisyon.Name = "txtpozisyon";
            this.txtpozisyon.Size = new System.Drawing.Size(104, 20);
            this.txtpozisyon.TabIndex = 20;
            // 
            // txtunvan
            // 
            this.txtunvan.Location = new System.Drawing.Point(388, 195);
            this.txtunvan.Margin = new System.Windows.Forms.Padding(2);
            this.txtunvan.Name = "txtunvan";
            this.txtunvan.Size = new System.Drawing.Size(119, 20);
            this.txtunvan.TabIndex = 19;
            // 
            // txtsektor
            // 
            this.txtsektor.Location = new System.Drawing.Point(388, 158);
            this.txtsektor.Margin = new System.Windows.Forms.Padding(2);
            this.txtsektor.Name = "txtsektor";
            this.txtsektor.Size = new System.Drawing.Size(119, 20);
            this.txtsektor.TabIndex = 18;
            // 
            // txtkamu
            // 
            this.txtkamu.Location = new System.Drawing.Point(388, 118);
            this.txtkamu.Margin = new System.Windows.Forms.Padding(2);
            this.txtkamu.Name = "txtkamu";
            this.txtkamu.Size = new System.Drawing.Size(119, 20);
            this.txtkamu.TabIndex = 17;
            // 
            // txtAyrilis
            // 
            this.txtAyrilis.Location = new System.Drawing.Point(134, 157);
            this.txtAyrilis.Margin = new System.Windows.Forms.Padding(2);
            this.txtAyrilis.Name = "txtAyrilis";
            this.txtAyrilis.Size = new System.Drawing.Size(99, 20);
            this.txtAyrilis.TabIndex = 16;
            // 
            // txtIsGiris
            // 
            this.txtIsGiris.Location = new System.Drawing.Point(135, 118);
            this.txtIsGiris.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsGiris.Name = "txtIsGiris";
            this.txtIsGiris.Size = new System.Drawing.Size(98, 20);
            this.txtIsGiris.TabIndex = 15;
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.Location = new System.Drawing.Point(21, 197);
            this.lblPozisyon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(72, 20);
            this.lblPozisyon.TabIndex = 12;
            this.lblPozisyon.Text = "Pozisyon:";
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan.Location = new System.Drawing.Point(281, 197);
            this.lblUnvan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(58, 20);
            this.lblUnvan.TabIndex = 11;
            this.lblUnvan.Text = "Ünvan:";
            // 
            // lblSektor
            // 
            this.lblSektor.AutoSize = true;
            this.lblSektor.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSektor.Location = new System.Drawing.Point(281, 158);
            this.lblSektor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSektor.Name = "lblSektor";
            this.lblSektor.Size = new System.Drawing.Size(57, 20);
            this.lblSektor.TabIndex = 10;
            this.lblSektor.Text = "Sektör:";
            // 
            // lblKamuOzel
            // 
            this.lblKamuOzel.AutoSize = true;
            this.lblKamuOzel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKamuOzel.Location = new System.Drawing.Point(281, 120);
            this.lblKamuOzel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKamuOzel.Name = "lblKamuOzel";
            this.lblKamuOzel.Size = new System.Drawing.Size(89, 20);
            this.lblKamuOzel.TabIndex = 9;
            this.lblKamuOzel.Text = "Kamu/Özel:";
            // 
            // lblIsAyrılıs
            // 
            this.lblIsAyrılıs.AutoSize = true;
            this.lblIsAyrılıs.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsAyrılıs.Location = new System.Drawing.Point(21, 155);
            this.lblIsAyrılıs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsAyrılıs.Name = "lblIsAyrılıs";
            this.lblIsAyrılıs.Size = new System.Drawing.Size(112, 20);
            this.lblIsAyrılıs.TabIndex = 8;
            this.lblIsAyrılıs.Text = "İş Ayrılış Tarihi:";
            // 
            // lblIsGiris
            // 
            this.lblIsGiris.AutoSize = true;
            this.lblIsGiris.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsGiris.Location = new System.Drawing.Point(21, 120);
            this.lblIsGiris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsGiris.Name = "lblIsGiris";
            this.lblIsGiris.Size = new System.Drawing.Size(101, 20);
            this.lblIsGiris.TabIndex = 7;
            this.lblIsGiris.Text = "İş Giriş Tarihi:";
            // 
            // btnIsEkle
            // 
            this.btnIsEkle.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsEkle.ForeColor = System.Drawing.Color.Red;
            this.btnIsEkle.Location = new System.Drawing.Point(554, 132);
            this.btnIsEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnIsEkle.Name = "btnIsEkle";
            this.btnIsEkle.Size = new System.Drawing.Size(138, 37);
            this.btnIsEkle.TabIndex = 3;
            this.btnIsEkle.Text = "Ekle ";
            this.btnIsEkle.UseVisualStyleBackColor = true;
            this.btnIsEkle.Click += new System.EventHandler(this.btnIsEkle_Click);
            // 
            // gridIs
            // 
            this.gridIs.AllowUserToAddRows = false;
            this.gridIs.AllowUserToDeleteRows = false;
            this.gridIs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridIs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIs.Location = new System.Drawing.Point(25, 245);
            this.gridIs.Margin = new System.Windows.Forms.Padding(2);
            this.gridIs.MultiSelect = false;
            this.gridIs.Name = "gridIs";
            this.gridIs.ReadOnly = true;
            this.gridIs.RowHeadersWidth = 51;
            this.gridIs.RowTemplate.Height = 24;
            this.gridIs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIs.Size = new System.Drawing.Size(793, 168);
            this.gridIs.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mezun Bilgi Sistemi ";
            // 
            // mezunlarDataSet1
            // 
            this.mezunlarDataSet1.DataSetName = "MezunlarDataSet1";
            this.mezunlarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(751, 455);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 33);
            this.btnKapat.TabIndex = 27;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // mezunlarDataSet2
            // 
            this.mezunlarDataSet2.DataSetName = "MezunlarDataSet2";
            this.mezunlarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mezunlarDataSet
            // 
            this.mezunlarDataSet.DataSetName = "MezunlarDataSet";
            this.mezunlarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mezunlarDataSetBindingSource
            // 
            this.mezunlarDataSetBindingSource.DataSource = this.mezunlarDataSet;
            this.mezunlarDataSetBindingSource.Position = 0;
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 499);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKayit";
            this.Text = "Kayıt Ekle/Güncelle";
            this.Load += new System.EventHandler(this.frmKayit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezunlarDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnIsEkle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonIsSil_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEgitimEkle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtEgtmsehir_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonEgitimSil_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblMezuniyetTa;
        private System.Windows.Forms.Label lblePosta;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.Label lblEvTel;
        private System.Windows.Forms.Label lblEvUlke;
        private System.Windows.Forms.Label lblEvSehir;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtMTarih;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEvTel;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label2;
        private MezunlarDataSet1 mezunlarDataSet1;
        private System.Windows.Forms.DataGridView gridIs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEgitimEkle;
        private System.Windows.Forms.Button btnIsEkle;
        private System.Windows.Forms.TextBox txtpozisyon;
        private System.Windows.Forms.TextBox txtunvan;
        private System.Windows.Forms.TextBox txtsektor;
        private System.Windows.Forms.TextBox txtkamu;
        private System.Windows.Forms.TextBox txtAyrilis;
        private System.Windows.Forms.TextBox txtIsGiris;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.Label lblSektor;
        private System.Windows.Forms.Label lblKamuOzel;
        private System.Windows.Forms.Label lblIsAyrılıs;
        private System.Windows.Forms.Label lblIsGiris;
        private MezunlarDataSet2 mezunlarDataSet2;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.TextBox txtEgtmsehir;
        private System.Windows.Forms.TextBox txtEgtmUlke;
        private System.Windows.Forms.TextBox txtEgtmBitis;
        private System.Windows.Forms.TextBox txtEgtmBaslangic;
        private System.Windows.Forms.TextBox txtEgtmAkademik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MezunlarDataSet mezunlarDataSet;
        private System.Windows.Forms.BindingSource mezunlarDataSetBindingSource;
        private System.Windows.Forms.Button buttonKayitGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEgitimSil;
        private System.Windows.Forms.Button buttonIsSil;
    }
}