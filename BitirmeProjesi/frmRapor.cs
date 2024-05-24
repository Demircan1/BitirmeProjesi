using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BitirmeProjesi
{
    public partial class frmRapor : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;User ID=root;Password='';");
        DataSet genelBilgiler = new DataSet();
        DataSet isBilgileri = new DataSet();

        public frmRapor()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RaporListele(string sorgu)
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
            genelBilgiler.Clear();
            adapter.Fill(genelBilgiler, "tblegitimbilgileri");
            var data = genelBilgiler.Tables["tblegitimbilgileri"];
            gridRapor.DataSource = data;
            adapter.Dispose();
            baglanti.Close();
        }

        private void RaporListeleIs(string sorgu)
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
            isBilgileri.Clear();
            adapter.Fill(isBilgileri, "tblIsBilgileri");
            var data = isBilgileri.Tables["tblIsBilgileri"];
            gridRapor.DataSource = data;
            adapter.Dispose();
            baglanti.Close();
        }

        private void btnDoktora_Click(object sender, EventArgs e)
        {
            RaporListele(
                "SELECT DISTINCT tblBilgiler.* " +
                "FROM tblBilgiler " +
                "INNER JOIN tblegitimbilgileri ON tblBilgiler.ogrenciNo = tblegitimbilgileri.ogrenciNo " +
                "WHERE tblegitimbilgileri.akademikEgitim LIKE 'Doktora'");
        }

        private void btnYdDoktora_Click(object sender, EventArgs e)
        {
            RaporListele(
                "SELECT DISTINCT tblBilgiler.* " +
                "FROM tblBilgiler " +
                "INNER JOIN tblegitimbilgileri ON tblBilgiler.ogrenciNo = tblegitimbilgileri.ogrenciNo " +
                "WHERE tblegitimbilgileri.akademikEgitim LIKE 'Doktora' AND tblegitimbilgileri.ulke NOT LIKE 'Türkiye'");
        }

        private void btnTrDoktora_Click(object sender, EventArgs e)
        {
            RaporListele(
                "SELECT DISTINCT tblBilgiler.* " +
                "FROM tblBilgiler " +
                "INNER JOIN tblegitimbilgileri ON tblBilgiler.ogrenciNo = tblegitimbilgileri.ogrenciNo " +
                "WHERE tblegitimbilgileri.akademikEgitim LIKE 'Doktora' AND tblegitimbilgileri.ulke LIKE 'Türkiye'");
        }

        private void btnYuksekLisans_Click(object sender, EventArgs e)
        {
            RaporListele(
                "SELECT DISTINCT tblBilgiler.* " +
                "FROM tblBilgiler " +
                "INNER JOIN tblegitimbilgileri ON tblBilgiler.ogrenciNo = tblegitimbilgileri.ogrenciNo " +
                "WHERE tblegitimbilgileri.akademikEgitim LIKE 'Yüksek Lisans'");
        }

        private void btnTrYuksekLisans_Click(object sender, EventArgs e)
        {
            RaporListele(
                "SELECT DISTINCT tblBilgiler.* " +
                "FROM tblBilgiler " +
                "INNER JOIN tblegitimbilgileri ON tblBilgiler.ogrenciNo =tblegitimbilgileri.ogrenciNo " +
                "WHERE tblegitimbilgileri.akademikEgitim LIKE 'Yüksek Lisans' AND tblegitimbilgileri.ulke LIKE 'Türkiye'");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RaporListele(
                "SELECT DISTINCT tblBilgiler.* " +
                "FROM tblBilgiler " +
                "INNER JOIN tblegitimbilgileri ON tblBilgiler.ogrenciNo = tblegitimbilgileri.ogrenciNo " +
                "WHERE tblegitimbilgileri.akademikEgitim LIKE 'Yüksek Lisans' AND tblegitimbilgileri.ulke NOT LIKE 'Türkiye'");
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            // Implement this method
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implement this method
        }

        private void gridRapor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement this method
        }
    }
}