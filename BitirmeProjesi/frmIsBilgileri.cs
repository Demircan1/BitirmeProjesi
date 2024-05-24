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

namespace BitirmeProjesi
{
    public partial class frmIsBilgileri : Form

    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Mezunlar.accdb");
        public frmIsBilgileri()
        {
            InitializeComponent();
        }

        private void eğitimBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEgitimBilgileri frm = new frmEgitimBilgileri();
            frm.Show();
            this.Hide();

        }

        private void genelBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.Show();
            this.Hide();

        }
    }
}
