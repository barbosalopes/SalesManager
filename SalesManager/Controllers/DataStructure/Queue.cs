using SalesManager.Controllers.Element;
using System.Text;

namespace SalesManager.Controllers.DataStructure
{
    public class Queue<Type>
    {
        private Item<Type> First, Last;

        public Queue()
        {
            First = Last = null;
        }

        public int Size()
        {
            Item<Type> Aux;
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
            Item<Type> Aux = new Item<Type>(value);
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
            Item<Type> Aux;

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
                    if (Aux.Next.Value.Equals(toRemove.Value))
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

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            Item<Type> Aux = First;

            while(Aux != null)
            {
                str.AppendLine(Aux.Value.ToString());
                Aux = Aux.Next;
            }
            return str.ToString();
        }

        public Type[] ToArray()
        {
            Type[] values = new Type[Size()];
            Item<Type> Aux = First;
            for(int i = 0; i < values.Length; i++)
            {
                values[i] = Aux.Value;
                Aux = Aux.Next;
            }
            return values;
        }
    }
}
