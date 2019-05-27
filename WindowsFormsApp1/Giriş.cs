using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelbilgisistemi.mdb");
       /* IkiliAramaAgac aramaAgaci;
        OleDbCommand cmd;
        OleDbDataReader dr;*/

        private void Giris_Load(object sender, EventArgs e)
        {
            OtelProvider op = new OtelProvider();
            op.AgacaOtelEkle();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YöneticiPaneli yönetici = new YöneticiPaneli();
            yönetici.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıPaneli kullanıcı = new KullanıcıPaneli();
            kullanıcı.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
