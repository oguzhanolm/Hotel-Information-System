using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class HashEntry
    {
        private int anahtar;

        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }
        private Heap veri;

        public Heap Veri
        {
            get { return veri; }
            set { veri = value; }
        }

        public HashEntry(int anahtar, Heap veri)
        {
            this.anahtar = anahtar;
            this.veri = veri;
        }
    }
}
