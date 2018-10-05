using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class StajDeneyimNode
    {
        public string SirketAdi { get; set; }
        public string Tarih { get; set; }
        public string Departman { get; set; }
        public string Gorev { get; set; }
        public StajDeneyimNode Sonraki { get; set; }

        public StajDeneyimNode()
        {

        }

        public StajDeneyimNode(StajDeneyimNode Dugum)
        {
            this.SirketAdi = Dugum.SirketAdi;
            this.Tarih = Dugum.Tarih;
            this.Departman = Dugum.Departman;
            this.Gorev = Dugum.Gorev;
        }
    }
}
