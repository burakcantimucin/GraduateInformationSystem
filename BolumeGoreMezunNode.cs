using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class BolumeGoreMezunNode
    {
        public MezunNode MezunBilgileri { get; set; }
        public double BasariDerecesi { get; set; }

        public BolumeGoreMezunNode()
        {

        }

        public BolumeGoreMezunNode(MezunNode Mezun)
        {
            MezunBilgileri = new MezunNode();
            this.MezunBilgileri = Mezun;
            this.BasariDerecesi = Mezun.MezunBilgileri.Mezuniyet.BasariNotu;
        }
    }
}
