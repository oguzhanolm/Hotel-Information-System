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
    public partial class Personel_Ekle : Form
    {
        public Personel_Ekle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelbilgisistemi.mdb");

        private void btnAddPersonelCancel_Click(object sender, EventArgs e)
        {
            YöneticiPaneli yönetici = new YöneticiPaneli();
            yönetici.Show();
            this.Close();
        }

        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
            YöneticiPaneli yönetici = new YöneticiPaneli();

            try
            {

                baglanti.Open();
                OleDbCommand ekle = new OleDbCommand("insert into Personeller (Isim,TC,Departman,Puan,Telefon,Adres,Mail,Pozisyon) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                ekle.Parameters.AddWithValue("@p1", perAddName.Text);
                ekle.Parameters.AddWithValue("@p2", txPerTC.Text);
                ekle.Parameters.AddWithValue("@p3", cmbDepartman.Text);
                ekle.Parameters.AddWithValue("@p4", txPerPuan.Text);
                ekle.Parameters.AddWithValue("@p5", txPerTel.Text);
                ekle.Parameters.AddWithValue("@p6", txPerAdres.Text);
                ekle.Parameters.AddWithValue("@p7", txPerMail.Text);
                ekle.Parameters.AddWithValue("@p8", txPerPozisyon.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yönetici.listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Otel eklenemedi!");
            }
            this.Close();
            yönetici.Show();
        }

        private void Personel_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
