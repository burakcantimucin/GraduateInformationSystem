using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class BolumHashEntry
    {
        private int anahtar;

        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }

        private int bolumNo;

        public int BolumNo
        {
            get { return bolumNo; }
            set { bolumNo = value; }
        }

        private BolumeGoreMezunHeap mezunKisiler;

        public BolumeGoreMezunHeap MezunKisiler
        {
            get { return mezunKisiler; }
            set { mezunKisiler = value; }
        }

        public BolumHashEntry()
        {

        }

        public BolumHashEntry(int BolumNo, MezunNode MezunBilgi)
        {
            this.BolumNo = BolumNo;
            this.MezunKisiler = new BolumeGoreMezunHeap(20);
            this.MezunKisiler.Insert(MezunBilgi);
        }

        public BolumeGoreMezunNode UygunMezunSec()
        {
            return MezunKisiler.EnIyiMezunaIsTeklifEt();
        }
    }
}
