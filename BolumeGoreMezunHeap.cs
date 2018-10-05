using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class BolumeGoreMezunHeap
    {
        private BolumeGoreMezunNode[] heapArray;
        public int CurrentSize { get; set; }
        public int MaxSize { get; set; }
        public string ZiyaretElemanlar { get; set; }

        public BolumeGoreMezunHeap()
        {

        }

        public BolumeGoreMezunHeap(int MaxSize)
        {
            this.MaxSize = MaxSize;
            heapArray = new BolumeGoreMezunNode[this.MaxSize];
            this.CurrentSize = 0;
        }

        public bool Insert(object Mezun)
        {
            if (CurrentSize == MaxSize)
                return false;
            BolumeGoreMezunNode newHeapDugum = new BolumeGoreMezunNode((MezunNode)Mezun);
            if (MezunBul(newHeapDugum) == true)
                return false;
            heapArray[CurrentSize] = newHeapDugum;
            MoveToUp(CurrentSize++);
            return true;
        }

        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            BolumeGoreMezunNode bottom = heapArray[index];

            while (index > 0 && heapArray[parent].BasariDerecesi < bottom.BasariDerecesi)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }

        private bool MezunBul(BolumeGoreMezunNode Mezun)
        {
            for (int m = 0; m < CurrentSize; m++)
            {
                if (heapArray[m].MezunBilgileri.MezunBilgileri.Ad != Mezun.MezunBilgileri.MezunBilgileri.Ad) { }
                else
                    return true;
            }
            return false;
        }

        public BolumeGoreMezunNode[] MezunlariListele()
        {
            return heapArray;
        }

        public BolumeGoreMezunNode EnIyiMezunaIsTeklifEt()
        {
            BolumeGoreMezunNode aday = heapArray[0];
            return aday;
        }
    }
}
