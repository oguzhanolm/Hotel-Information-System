using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public class OtelProvider
    {
        OleDbConnection con;
        OleDbCommand cmd;

        public OtelProvider() //Kurucu metotta bağlantı yolumuzu belirledik.
        {
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=otelbilgisistemi.mdb");
        }

        public IkiliAramaAgac AgacaOtelEkle()
        {
            IkiliAramaAgac agac = new IkiliAramaAgac();
            con.Open();
            cmd = new OleDbCommand("SELECT *FROM Oteller", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Otel o = new Otel();
                o.hotelName = dr[1].ToString();
                o.hotelAdress = dr[2].ToString();
                o.hotelStar = dr[3].ToString();
                o.hotelPhoneNumber = dr[4].ToString();
                o.hotelMail = dr[5].ToString();
                o.hotelRooms = dr[6].ToString();
                o.hotelRoomType = dr[7].ToString();
                agac.Ekle(o);
            }
            con.Close();
            return agac;
        }

        public IkiliAramaAgac AgacOtelSil(int secilenOtel)
        {
            IkiliAramaAgac agac = new IkiliAramaAgac();
            con.Open();
            cmd = new OleDbCommand("SELECT *FROM Oteller where ID=@p1", con);
            cmd.Parameters.AddWithValue("@p1", secilenOtel);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            OleDbDataReader dr = cmd.ExecuteReader();
            Otel o = new Otel();
            dr.Read();
            o.hotelName = dr[1].ToString();
            //agac.Sil(o);
            return agac;
        }
    }
}
