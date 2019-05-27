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
    public partial class KullanıcıPaneli : Form
    {
        public KullanıcıPaneli()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelbilgisistemi.mdb");


        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();  
        }

        private void lstboxUserHotels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        IkiliAramaAgac agac = new IkiliAramaAgac();

        private void KullanıcıPaneli_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = IsmeGoreSirala();
        }

        public DataTable IsmeGoreSirala()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Oteller ORDER BY Isim desc", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }

        public DataTable IlceyeGoreSirala()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Oteller ORDER BY Adres desc", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }

        public DataTable PuanaGoreSirala()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Oteller ORDER BY OtelPuan desc", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }

        public DataTable YildizaGoreSirala()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Oteller ORDER BY Yildiz desc", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = IlceyeGoreSirala();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PuanaGoreSirala();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = YildizaGoreSirala();
        }

        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenOtel = dataGridView1.SelectedCells[0].RowIndex;
            string secilenotel;
            secilenotel = dataGridView1.Rows[secilenOtel].Cells[0].Value.ToString();
            secilen = Convert.ToUInt16(secilenotel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Update Oteller Set OtelPuan=@p1 where ID=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txPuan.Text);
                komut.Parameters.AddWithValue("@p2", secilen);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txPuan.Text = "";
                dataGridView1.DataSource = IsmeGoreSirala();
                MessageBox.Show("Puan başarı ile verildi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Puan verilemedi!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand yorum = new OleDbCommand("insert into Yorum (OtelID,Yorumcu,Yorum) values (@p1,@p2,@p3)", baglanti);
                yorum.Parameters.AddWithValue("@p1", secilen);
                yorum.Parameters.AddWithValue("@p2", txYorumcu.Text);
                yorum.Parameters.AddWithValue("@p3", txYorum.Text);
                yorum.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yorum yapıldı!");
                txYorum.Text = "";
                txYorumcu.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Yorum yapılamadı!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public DataTable YorumSirala()
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Yorum ORDER BY OtelID desc", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();
            return ds.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = YorumSirala();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgacIslemleri agac = new AgacIslemleri();
            agac.Show();
        }
    }
}
