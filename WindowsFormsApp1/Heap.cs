using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Heap
    {
        public HeapDugum[] heapArray;
        private int maxSize;
        public int currentSize;

        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugum[maxSize];
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Otel o)
        {
            if (currentSize == maxSize)
                return false;

            int value = 0;
            value = Convert.ToInt32((o.ll.Head.Data as Personel).staffTcNo);

            HeapDugum newHeapDugumu = new HeapDugum(value);
            newHeapDugumu.otl = o;

            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugum bottom = heapArray[index];
            while (index > 0 && heapArray[parent].otelPuan < bottom.otelPuan)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugum GetHeapD(int i)
        {
            return heapArray[i];
        }
        public HeapDugum EnUygun()
        {
            return heapArray[0];
        }
    }
}
