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
    public partial class Otel_Ekle : Form 
    {
        public Otel_Ekle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelbilgisistemi.mdb");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOtelCancel_Click(object sender, EventArgs e)
        {
            YöneticiPaneli yönetici = new YöneticiPaneli();
            yönetici.Show();
            this.Close();
        }

        private void btnAddOtel_Click(object sender, EventArgs e)
        {            

            YöneticiPaneli yönetici = new YöneticiPaneli();
            Otel o = new Otel();

            o.hotelName = txtOtelAddName.Text;
            o.hotelAdress = cmbboxAddAdres.Text;
            o.hotelStar = cmbYıldız.Text;
            o.hotelPhoneNumber = txtHotelPhone.Text;
            o.hotelMail = txtHotelMail.Text;
            o.hotelRooms = txtRooms.Text;
            o.hotelRoomType = cmbOdaTipi.Text;          
            try
            {

                baglanti.Open();
                OleDbCommand ekle = new OleDbCommand("insert into Oteller (Isim,Adres,Yildiz,Telefon,Mail,OdaSayisi,OdaTipi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                ekle.Parameters.AddWithValue("@p1", txtOtelAddName.Text);
                ekle.Parameters.AddWithValue("@p2", cmbboxAddAdres.Text);
                ekle.Parameters.AddWithValue("@p3", cmbYıldız.Text);
                ekle.Parameters.AddWithValue("@p4", txtHotelPhone.Text);
                ekle.Parameters.AddWithValue("@p5", txtHotelMail.Text);
                ekle.Parameters.AddWithValue("@p6", txtRooms.Text);
                ekle.Parameters.AddWithValue("@p7", cmbOdaTipi.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Otel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yönetici.listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Otel eklenemedi!");
            }
            AgacaEkle();
            this.Close();
            yönetici.Show();  
        }

        public void AgacaEkle()
        {
            IkiliAramaAgac agac = new IkiliAramaAgac();
            Otel otel = new Otel();
            agac.Ekle(otel);
        }

        private void Otel_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
