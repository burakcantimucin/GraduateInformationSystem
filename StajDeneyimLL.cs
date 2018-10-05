using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class StajDeneyimLL : LinkedListADT
    {
        private StajDeneyimNode Bas;

        public StajDeneyimLL()
        {

        }

        public override void InsertFirst(object Value)
        {
            StajDeneyimNode tmpHead = new StajDeneyimNode((StajDeneyimNode)Value);
            if (Bas == null) { Bas = tmpHead; }
            else { tmpHead.Sonraki = Bas; Bas = tmpHead; }
            Size++;
        }

        public override void InsertLast(object Value)
        {
            StajDeneyimNode TempHead = new StajDeneyimNode((StajDeneyimNode)Value);
            StajDeneyimNode Current = Bas;
            if (Current == null)
            {
                Bas = (StajDeneyimNode)Value;
            }
            else
            {
                while (Current != null)
                {
                    if (Current.Sonraki == null)
                    {
                        Current.Sonraki = TempHead;
                        break;
                    }
                    Current = Current.Sonraki;
                }
            }
            Size++;
        }

        public override void InsertPosition(int Position, object Value)
        {
            StajDeneyimNode PositionNode = Bas; StajDeneyimNode TempSonraki = null;
            StajDeneyimNode NewNode = new StajDeneyimNode((StajDeneyimNode)Value);
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
                StajDeneyimNode tmpNode = Bas;
                StajDeneyimNode headNext = Bas.Sonraki;
                if (headNext == null) { Bas = null; }
                else { Bas = headNext; tmpNode = null; }
                Size--;
            }
        }

        public override void DeleteLast()
        {
            StajDeneyimNode last = Bas, lastPrevNode = Bas;
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
            StajDeneyimNode posNode = Bas;
            StajDeneyimNode prevPosNode = new StajDeneyimNode();
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
            StajDeneyimNode temp = Bas;
            for (int i = 1; i < Position; i++)
            {
                temp = temp.Sonraki;
            }
            return temp;
        }

        public override string DisplayElements()
        {
            string temp = "";
            StajDeneyimNode item = Bas;
            while (item != null)
            {
                temp += " " + item.SirketAdi + " " + item.Tarih + " " + item.Departman + " " + item.Gorev + Environment.NewLine;
                item = item.Sonraki;
            }
            return temp;
        }
    }
}
