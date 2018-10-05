using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class Mezun
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string ePosta { get; set; }
        public string Uyruk { get; set; }
        public string DogumTarihi { get; set; }
        public int OgrenciNo { get; set; }
        public string IngilizceSeviye { get; set; }
        public string IlgiAlanlari { get; set; }
        public StajDeneyimNode StajDeneyim { get; set; }
        public MezuniyetBilgilerNode Mezuniyet { get; set; }

        public Mezun()
        {
            this.StajDeneyim = new StajDeneyimNode();
            this.Mezuniyet = new MezuniyetBilgilerNode();
        }

        public Mezun(StajDeneyimNode StajDeneyim, MezuniyetBilgilerNode Mezuniyet)
        {
            this.StajDeneyim = new StajDeneyimNode(StajDeneyim);
            this.Mezuniyet = new MezuniyetBilgilerNode(Mezuniyet);
        }
    }
}
