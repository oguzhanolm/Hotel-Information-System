using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class HeapDugum
    {
        public Otel otl;
        public int otelPuan { get; set; }

        public HeapDugum()
        {

        }
        public HeapDugum(int value)
        {
            otl = new Otel();
            this.otelPuan = value;
        }
    }
}

