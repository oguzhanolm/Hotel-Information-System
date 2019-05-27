using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size;

        public abstract void InsertLast(object value);
        public abstract string DisplayGetElement(object position);
    }
}
