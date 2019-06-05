using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Controllers.DataStructure
{
    public class HashTable<Type>
    {
        protected Type[] hash;

        public HashTable(int size)
        {
            hash = new Type[size];
        }

        public void SetItem(int pos, Type value)
        {
            hash[pos] = value;
        }

        public Type GetItem(int pos)
        {
            return hash[pos];
        }

    }
}
