using System;


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

        public TreeItem<Type> Predecessor { set; get; }

        public int Rate
        {
            get
            {
                if (Left != null && Right != null)
                    return 2;
                else if (Left != null)
                    return -1;
                else if (Right != null)
                    return 1;
                else
                    return 0;
            }
        }

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
