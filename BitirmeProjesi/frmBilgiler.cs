using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BitirmeProjesi
{
    public partial class frmBilgiler : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;User ID=root;Password='';");
        DataSet ds = new DataSet();

        public frmBilgiler()
        {
            InitializeComponent();
        }

        private void frmBilgiler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.MezunYukle(null);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var tumVeri = this.tblBilgilerTableAdapter.GetData();

            var mezun = tumVeri[e.RowIndex];

            frmKayit frm = new frmKayit();
            frm.MezunYukle(mezun);
            frm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            int satir;
            cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                baglanti.Open();

                int no = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string sorgu = "DELETE FROM tblBilgiler WHERE ogrenciNo=@pOgrenciNo";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@pOgrenciNo", no);

                satir = komut.ExecuteNonQuery();
                MessageBox.Show(satir + " Satır Silindi.");

                baglanti.Close();
                ds.Clear();
                listele();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kişiyi seçin.");
            }
        }

        private void listele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblBilgiler", baglanti);
            adapter.Fill(ds, "tblBilgiler");
            dataGridView1.DataSource = ds.Tables["tblBilgiler"];
            adapter.Dispose();
            baglanti.Close();
        }

        private void btnOgrenciRapor_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            frm.ShowDialog();
        }
    }
}

