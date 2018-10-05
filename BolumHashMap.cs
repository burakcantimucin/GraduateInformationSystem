using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class BolumHashMap
    {
        public int TableSize { get; set; }
        private BolumHashEntry[] Mezunlar;

        public BolumHashMap()
        {
            this.TableSize = 1000;
            Mezunlar = new BolumHashEntry[TableSize];
            for (int i = 0; i < TableSize; i++)
                Mezunlar[i] = null;
        }

        public BolumHashMap(int TableSize)
        {
            this.TableSize = TableSize;
            Mezunlar = new BolumHashEntry[TableSize];
            for (int i = 0; i < TableSize; i++)
            {
                Mezunlar[i] = null;
            }
        }
        
        public bool BolumVarMiYokMu(int key)
        {
            int hash = (key % TableSize);
            while (Mezunlar[hash] != null && Mezunlar[hash].Anahtar != key) { return false; }
            return true;
        }

        public bool MezununBolumeAtanmasi(int bolumNo, MezunNode Mezun)
        {
            int hash = (bolumNo % TableSize);
            if (BolumVarMiYokMu(bolumNo) == true)
            {
                while (Mezunlar[hash] != null && Mezunlar[hash].BolumNo != bolumNo)
                    hash = (hash + 1) % TableSize;
                Mezunlar[hash] = new BolumHashEntry(bolumNo, Mezun);
                return true;
            }
            else { return Mezunlar[hash].MezunKisiler.Insert(Mezun); }
        }

        public BolumHashEntry[] HashTablosundakiMezunlar()
        {
            return Mezunlar;
        }

        public int[] MezunSayisi()
        {
            int[] MezunSayilari = new int[1000];
            for (int i = 0; i < 1000; i++) { MezunSayilari[i] = Mezunlar[i].MezunKisiler.CurrentSize; }
            return MezunSayilari;
        }

        public string UygunMezunSec()
        {
            string UygunMezunlar = "";
            for (int i = 0; i < TableSize; i++)
            {
                if (Mezunlar[i] != null) { UygunMezunlar += UygunMezunlariYazdir(Mezunlar[i].UygunMezunSec()); }
            }
            return UygunMezunlar;
        }

        private string UygunMezunlariYazdir(BolumeGoreMezunNode Mezun)
        {
            string UygunAdaylar = "";
            UygunAdaylar += "Mezun Adı: " + Mezun.MezunBilgileri.MezunBilgileri.Ad +
                            " ve Başarı Derecesi: " + Mezun.BasariDerecesi + Environment.NewLine;
            return UygunAdaylar;
        }
    }
}
