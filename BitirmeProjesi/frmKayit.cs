using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BitirmeProjesi
{
    public partial class frmKayit : Form
    {
        long ogrenciNo = -1;

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;User ID=root;Password='';");
        DataSet egitimBilgileri = new DataSet();
        DataSet isBilgileri = new DataSet();

        public frmKayit()
        {
            InitializeComponent();
        }


        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            int satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();

            komut.CommandText = "INSERT INTO tblBilgiler (ogrenciNo, ad, soyad, mezuniyetTarihi, cepTel, ePosta, evTel, evUlke, evSehir, evAdres) " +
                "VALUES (@pOgrenciNo, @pAd, @pSoyad, @pMezuniyetTarihi, @pCepTel, @peposta, @pEvTel, @pEvUlke, @pEvSehir, @pEvAdres)";

            komut.Parameters.AddWithValue("@pOgrenciNo", txtOgrenciNo.Text);
            komut.Parameters.AddWithValue("@pAd", txtAd.Text);
            komut.Parameters.AddWithValue("@pSoyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@pMezuniyetTarihi", txtMTarih.Text);
            komut.Parameters.AddWithValue("@pCepTel", txtCep.Text);
            komut.Parameters.AddWithValue("@peposta", txtEposta.Text);
            komut.Parameters.AddWithValue("@pEvTel", txtEvTel.Text);
            komut.Parameters.AddWithValue("@pEvUlke", txtUlke.Text);
            komut.Parameters.AddWithValue("@pEvSehir", txtSehir.Text);
            komut.Parameters.AddWithValue("@pEvAdres", txtAdres.Text);
            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satır eklendi");
            komut.Dispose();
            baglanti.Close();

            this.Close();
        }

        private void buttonKayitGuncelle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void MezunYukle(MezunlarDataSet1.tblBilgilerRow mezun)
        {
            if (mezun == null)
            {
                buttonKayitGuncelle.Visible = false;
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                return;
            }

            btnKayitEkle.Visible = false;
            ogrenciNo = mezun.ogrenciNo;

            txtOgrenciNo.Text = mezun.ogrenciNo.ToString();
            txtAd.Text = mezun.ad.ToString();
            txtSoyad.Text = mezun.soyad.ToString();
            txtMTarih.Text = mezun.mezuniyetTarihi.ToString();
            txtCep.Text = mezun.cepTel.ToString();
            txtEposta.Text = mezun.ePosta.ToString();
            txtEvTel.Text = mezun.evTel.ToString();
            txtUlke.Text = mezun.evUlke.ToString();
            txtSehir.Text = mezun.evSehir.ToString();
            txtAdres.Text = mezun.evAdres.ToString();

            EgitimBilgileriListele();
            IsBilgileriListele();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {
            // This method intentionally left empty.
        }

        private void IsBilgileriListele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblIsBilgileri WHERE ogrenciNo = " + ogrenciNo + " ORDER BY id", baglanti);
            isBilgileri.Clear();
            adapter.Fill(isBilgileri, "tblIsBilgileri");
            var data = isBilgileri.Tables["tblIsBilgileri"];
            gridIs.DataSource = data;
            adapter.Dispose();
            baglanti.Close();
        }

        private void EgitimBilgileriListele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblEgitim WHERE ogrenciNo = " + ogrenciNo + " ORDER BY kimlik", baglanti);
            egitimBilgileri.Clear();
            adapter.Fill(egitimBilgileri, "tblEgitim");
            var data = egitimBilgileri.Tables["tblEgitim"];
            dataGridView1.DataSource = data;
            adapter.Dispose();
            baglanti.Close();
        }
    }
}




