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
    public partial class YöneticiPaneli : Form
    {
        public YöneticiPaneli()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelbilgisistemi.mdb");
        public void listele()
        {
            DataTable dtO = new DataTable();
            OleDbDataAdapter daO = new OleDbDataAdapter("Select * From Oteller", baglanti);
            daO.Fill(dtO);
            dataGridOtel.DataSource = dtO;

            DataTable dtP = new DataTable();
            OleDbDataAdapter daP = new OleDbDataAdapter("Select * From Personeller", baglanti);
            daP.Fill(dtP);
            dataGridPer.DataSource = dtP;
        }
        public DataTable DepartmanaGoreListele()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Personeller ORDER BY Departman desc", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }
        public DataTable PuanaGoreSirala()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Personeller ORDER BY Puan desc", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }
        private void YöneticiPaneli_Load(object sender, EventArgs e)
        {
            listele();
        }
        int secilenOtel;
        private void dataGridOtel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridOtel.SelectedCells[0].RowIndex;
            txIsim.Text = dataGridOtel.Rows[secilen].Cells[1].Value.ToString();
            txAdres.Text = dataGridOtel.Rows[secilen].Cells[2].Value.ToString();
            cmYildiz.Text = dataGridOtel.Rows[secilen].Cells[3].Value.ToString();
            txTelefon.Text = dataGridOtel.Rows[secilen].Cells[4].Value.ToString();
            txMail.Text = dataGridOtel.Rows[secilen].Cells[5].Value.ToString();
            txOdaSayisi.Text = dataGridOtel.Rows[secilen].Cells[6].Value.ToString();
            cmOdaTipi.Text = dataGridOtel.Rows[secilen].Cells[7].Value.ToString();
            string secilenotel;
            secilenotel = dataGridOtel.Rows[secilen].Cells[0].Value.ToString();
            secilenOtel = Convert.ToUInt16(secilenotel);
            
        }
        public int secilenDondur()
        {
            return secilenOtel;

        } 
        private void button1_Click(object sender, EventArgs e)
        {
            IkiliAramaAgac agac = new IkiliAramaAgac();
            Otel o = new Otel();
            OtelProvider op = new OtelProvider();
            op.AgacOtelSil(secilenOtel);
            try
            {   
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("Delete From Oteller where ID=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", secilenOtel);
                sil.ExecuteNonQuery();
                listele();
                MessageBox.Show("Otel Sistemden Silindi!");
                baglanti.Close();
            } 
            catch (Exception)
            {
                MessageBox.Show("Otel Sistemden Silinemedi!");
            }

        }

        int secilenPersonel;

        private void dataGridPer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenPer = dataGridPer.SelectedCells[0].RowIndex; 
            string secilenpersonel;
            secilenpersonel = dataGridPer.Rows[secilenPer].Cells[0].Value.ToString();
            secilenPersonel = Convert.ToUInt16(secilenpersonel);
        }

        private void btnRemovePersonel_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("Delete From Personeller where ID=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", secilenPersonel);
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Otel Sistemden Silindi!");
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Otel Sistemden Silinemedi!");
            }
        }  
        
        private void btnUpdateHotel_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand güncelle = new OleDbCommand("Update Oteller Set Isim=@p1,Adres=@p2,Yildiz=@p3,Telefon=@p4,Mail=@p5,OdaSayisi=@p6,OdaTipi=@p7 where ID=@p8", baglanti);
                güncelle.Parameters.AddWithValue("@p1", txIsim.Text);
                güncelle.Parameters.AddWithValue("@p2", txAdres.Text);
                güncelle.Parameters.AddWithValue("@p3", cmYildiz.Text);
                güncelle.Parameters.AddWithValue("@p4", txTelefon.Text);
                güncelle.Parameters.AddWithValue("@p5", txMail.Text);
                güncelle.Parameters.AddWithValue("@p6", txOdaSayisi.Text);
                güncelle.Parameters.AddWithValue("@p7", cmOdaTipi.Text);
                güncelle.Parameters.AddWithValue("@p8", secilenOtel);
                güncelle.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Otel başarı ile güncellendi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Otel güncellenemedi!");
            }

        }
        private void btnOpenAddOtelForm_Click(object sender, EventArgs e)
        {
            Otel_Ekle otelekle = new Otel_Ekle();
            otelekle.Show();
            this.Hide();
        }
        private void btnOpenAddPersonelForm_Click(object sender, EventArgs e)
        {
            Personel_Ekle personelekle = new Personel_Ekle();
            personelekle.Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridPer.DataSource = DepartmanaGoreListele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridPer.DataSource = PuanaGoreSirala();
        }

        private void btnUpdatePersonel_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand güncelle = new OleDbCommand("Update Personeller Set Isim=@p1,TC=@p2,Departman=@p3,Puan=@p4,Telefon=@p5,Adres=@p6,Mail=@p7,Pozisyon=@p9 where ID=@p8", baglanti);
                güncelle.Parameters.AddWithValue("@p1", txPerIsim.Text);
                güncelle.Parameters.AddWithValue("@p2", txPerTC.Text);
                güncelle.Parameters.AddWithValue("@p3", txPerDepart.Text);
                güncelle.Parameters.AddWithValue("@p4", txPerPuan.Text);
                güncelle.Parameters.AddWithValue("@p5", txPerTelefon.Text);
                güncelle.Parameters.AddWithValue("@p6", txPerAdres.Text);
                güncelle.Parameters.AddWithValue("@p7", txPerMail.Text);
                güncelle.Parameters.AddWithValue("@p8", secilenOtel);
                güncelle.Parameters.AddWithValue("@p8", txPerPozisyon.Text);
                güncelle.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Personel başarı ile güncellendi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Personel güncellenemedi!");
            }
        }
        private void oTELİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otelÇıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }  
        private void button2_Click(object sender, EventArgs e)
        {


         
        }
        private void dataGridOtel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridPer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbOtel_Click(object sender, EventArgs e)
        {

        }
    }
}

