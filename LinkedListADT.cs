using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public abstract class LinkedListADT
    {
        protected int Size = 0;
        public abstract void InsertFirst(object Value);
        public abstract void InsertLast(object Value);
        public abstract void InsertPosition(int Position, object Value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePosition(int Position);
        public abstract object GetElement(int Position);
        public abstract string DisplayElements();
    }
}
