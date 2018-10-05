using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class MezuniyetLL : LinkedListADT
    {
        private MezuniyetBilgilerNode Bas;

        public MezuniyetLL()
        {

        }

        public override void InsertFirst(object Value)
        {
            MezuniyetBilgilerNode TempHead = new MezuniyetBilgilerNode((MezuniyetBilgilerNode)Value);
            if (Bas == null) { Bas = TempHead; }
            else { TempHead.Sonraki = Bas; Bas = TempHead; }
            Size++;
        }

        public override void InsertLast(object Value)
        {
            MezuniyetBilgilerNode TempHead = new MezuniyetBilgilerNode((MezuniyetBilgilerNode)Value);
            MezuniyetBilgilerNode Current = Bas;
            if (Current == null) { Bas = (MezuniyetBilgilerNode)Value; }
            else
            {
                while (Current != null)
                {
                    if (Current.Sonraki == null) { Current.Sonraki = TempHead; break; }
                }
            }
            Size++;
        }

        public override void InsertPosition(int Position, object Value)
        {
            MezuniyetBilgilerNode PositionNode = Bas; MezuniyetBilgilerNode TempSonraki = null;
            MezuniyetBilgilerNode NewNode = new MezuniyetBilgilerNode((MezuniyetBilgilerNode)Value);
            for (int i = 1; i < Position; i++)
            {
                if (PositionNode.Sonraki != null) { PositionNode = PositionNode.Sonraki; }
                else { return; }
            }
            TempSonraki = PositionNode.Sonraki;
            PositionNode.Sonraki = NewNode;
            NewNode.Sonraki = TempSonraki;
            Size++;
        }

        public override void DeleteFirst()
        {
            while (Bas != null)
            {
                MezuniyetBilgilerNode tmpNode = Bas;
                MezuniyetBilgilerNode headNext = Bas.Sonraki;
                if (headNext == null) { Bas = null; }
                else { Bas = headNext; tmpNode = null; }
                Size--;
            }
        }

        public override void DeleteLast()
        {
            MezuniyetBilgilerNode last = Bas, lastPrevNode = Bas;
            while (last.Sonraki != null)
            {
                lastPrevNode = last;
                last = last.Sonraki;
            }
            lastPrevNode.Sonraki = null;
            Size--;
        }

        public override void DeletePosition(int Position)
        {
            MezuniyetBilgilerNode posNode = Bas;
            MezuniyetBilgilerNode prevPosNode = new MezuniyetBilgilerNode();
            for (int i = 1; i < Position; i++)
            {
                if (posNode.Sonraki != null) { prevPosNode = posNode; posNode = posNode.Sonraki; }
                else { return; }
            }
            prevPosNode.Sonraki = posNode.Sonraki;
            posNode = null;
            Size--;
        }

        public override object GetElement(int Position)
        {
            MezuniyetBilgilerNode temp = Bas;
            for (int i = 1; i < Position; i++)
            {
                temp = temp.Sonraki;
            }
            return temp;
        }

        public double GetGraduationAverage(int Position)
        {
            MezuniyetBilgilerNode Temp = null;
            MezuniyetBilgilerNode Item = Bas;
            int PositionCounter = 0;
            while (Item != null)
            {
                if (PositionCounter == Position - 1) { Temp = Item; }
                Item = Item.Sonraki;
                PositionCounter++;
            }
            return Temp.NotOrtalamasi;
        }

        public override string DisplayElements()
        {
            string temp = "";
            MezuniyetBilgilerNode item = Bas;
            while (item != null)
            {
                temp += " " + item.BolumAdi + " " + item.BaslangicTarihi + " " + item.BitisTarihi + " " + item.NotOrtalamasi + " " + item.BasariBelgesi + Environment.NewLine;
                item = item.Sonraki;
            }
            return temp;
        }
    }
}
