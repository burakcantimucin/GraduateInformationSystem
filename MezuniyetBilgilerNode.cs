using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class MezuniyetBilgilerNode
    {
        public string BolumAdi { get; set; }
        public int BaslangicTarihi { get; set; }
        public int BitisTarihi { get; set; }
        public double NotOrtalamasi { get; set; }
        public bool BasariBelgesi { get; set; }
        public double BasariNotu { get; set; }
        public MezuniyetBilgilerNode Sonraki { get; set; }

        public MezuniyetBilgilerNode()
        {

        }

        public MezuniyetBilgilerNode(MezuniyetBilgilerNode Dugum)
        {
            this.BolumAdi = Dugum.BolumAdi;
            this.BaslangicTarihi = Dugum.BaslangicTarihi;
            this.BitisTarihi = Dugum.BitisTarihi;
            this.NotOrtalamasi = Dugum.NotOrtalamasi;
            this.BasariBelgesi = Dugum.BasariBelgesi;
            if (this.BasariBelgesi == true) { this.BasariNotu = this.NotOrtalamasi + 10.00; }
            else { this.BasariNotu = this.NotOrtalamasi; }
        }
    }
}
