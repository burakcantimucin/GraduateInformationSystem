using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class Sirket
    {
        public string Ad { get; set; }
        public string Bolum { get; set; }
        public List<Sirket> Sirketler { get; set; }

        public Sirket()
        {
            this.Sirketler = new List<Sirket>();
        }

        public Sirket(string Ad, string Bolum)
        {
            this.Ad = Ad;
            this.Bolum = Bolum;
        }

        public void SirketEkle(Sirket sirket)
        {
            Sirketler.Add(sirket);
        }

        public string SirketGoruntule()
        {
            string temp = "";
            int i = 0;
            foreach (var item in Sirketler)
            {
                i++;
                temp += i + ". Şirket Adı: " + item.Ad + " ve bölümü: " + item.Bolum + Environment.NewLine;
            }
            return temp;
        }
    }
}
