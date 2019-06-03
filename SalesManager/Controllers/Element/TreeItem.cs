using System;

cusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Controllers.Element
{
    public class TreeItem<Type>
    {
        public Type Value { set; get; }

        public TreeItem<Type> Left { set; get; }

        public TreeItem<Type> Right { set; get; }

        public TreeItem(Type value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public override bool Equals(object obj)
        {
            return Value.Equals((Type)obj);
        }

        public int CompareTo(TreeItem<Type> treeItem)
        {
            IComparable comparable = (IComparable)treeItem.Value;
            IComparable currentValue = (IComparable)Value;

            return currentValue.CompareTo(comparable);
        }
    }
}
