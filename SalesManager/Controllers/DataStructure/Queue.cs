using SalesManager.Controllers.Element;
using System;
using System.Collections.Generic;
namespace SalesManager.Controllers.DataStructure
{
    public class Queue<Type>
    {
        private Item<Type> First, Last, Aux;

        public Queue()
        {
            First = Last = null;
        }

        public int Size()
        {
            if (First == null) return 0;
            else
            {
                int size = 0;
                Aux = First;
                while (Aux != null)
                {
                    size++;
                    Aux = Aux.Next;
                }
                return size;
            }
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public virtual void Add(Type value)
        {
            Aux = new Item<Type>(value);
            if (IsEmpty())
                First = Last = Aux;
            else
            {
                Last.Next = Aux;
                Last = Aux;
            }
        }

        public virtual object Remove(Type value)
        {
            Item<Type> toRemove = new Item<Type>(value);

            if (IsEmpty()) return null;
            else
            {
                Aux = First;
                if (Aux.Value.Equals(toRemove.Value))
                {
                    First = First.Next;
                    return toRemove.Value;
                    // Remove reference for next
                }

                while (Aux.Next != null)
                {
                    if (Aux.Next.Equals(toRemove))
                    {
                        Aux.Next = Aux.Next.Next;
                        return toRemove.Value;

                    }
                    Aux = Aux.Next;
                }
                
                return null;
            }
        }

        public object Find(Type value)
        {
            Item<Type> aux = First;
            if (IsEmpty()) return null;
            if (aux.Value.Equals(value)) return value;
            while (aux.Next != null)
            {
                if (aux.Value.Equals(value)) return aux.Value;
                aux = aux.Next;
            }

            return null;
        }
    }
}
