using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class MezunNode
    {
        public MezunNode Sol { get; set; }
        public MezunNode Sag { get; set; }
        public Mezun MezunBilgileri { get; set; }
        public StajDeneyimLL StajDeneyimBilgileri { get; set; }
        public MezuniyetLL MezuniyetBilgileri { get; set; }

        public MezunNode()
        {

        }

        public MezunNode(Mezun Mezun)
        {
            this.MezunBilgileri = Mezun;
        }

        public MezunNode(Mezun Mezun, StajDeneyimNode StajDeneyim, MezuniyetBilgilerNode Mezuniyet)
        {
            this.MezunBilgileri = new Mezun();
            this.MezunBilgileri = Mezun;

            this.StajDeneyimBilgileri = new StajDeneyimLL();
            this.StajDeneyimBilgileri.InsertLast(StajDeneyim);

            this.MezuniyetBilgileri = new MezuniyetLL();
            this.MezuniyetBilgileri.InsertLast(Mezuniyet);

            this.Sol = null;
            this.Sag = null;
        }
    }
}
