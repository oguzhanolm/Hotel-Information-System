using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Otel 
    {
        public string hotelName { get; set; }
        public string hotelAdress { get; set; }
        public float hotelScore { get; set; }
        public string hotelStar { get; set; }
        public string hotelMail { get; set; }
        public string hotelRooms { get; set; }
        public string hotelRoomType { get; set; }
        public string hotelPhoneNumber { get; set; }

        public otelLinkedList ll { get; set; }

        public Otel(Personel personel)
        {
            this.ll = new otelLinkedList();
            this.ll.InsertLast(personel);
        }

        public Otel()
        {
        }
    }
}
