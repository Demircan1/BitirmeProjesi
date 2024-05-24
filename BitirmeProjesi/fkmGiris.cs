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
    public partial class fkmGiris : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;User ID=root;Password='';");

        public fkmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM tblgiriş WHERE kullanici_adi=@pkullanici_adi AND sifre=@psifre";

                MySqlParameter adsoyad = new MySqlParameter("@pkullanici_adi", txtKullaniciAdi.Text);
                MySqlParameter parola = new MySqlParameter("@psifre", txtSifre.Text);

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.Add(adsoyad);
                komut.Parameters.Add(parola);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmBilgiler frm1 = new frmBilgiler();
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}





