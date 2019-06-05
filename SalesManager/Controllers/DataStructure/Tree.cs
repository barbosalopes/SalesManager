using SalesManager.Controllers.Element;
using System.Collections.Generic;

namespace SalesManager.Controllers.DataStructure
{
    public class Tree<Type>
    {

        public TreeItem<Type> root;

        public Tree()
        {
            root = null;
        }

        public void Insert(Type value)
        {
            TreeItem<Type> item = new TreeItem<Type>(value);
            root = RecursiveInsert(item, root);
        }

        private TreeItem<Type> RecursiveInsert(TreeItem<Type> item, TreeItem<Type> root)
        {
            if (root == null)
            {
                return item;
            }
            if (item.CompareTo(root) < 0)
                root.Left = RecursiveInsert(item, root.Left);
            else
                root.Right = RecursiveInsert(item, root.Right);

            return root;
        }

        public Type Search(Type value)
        {
            TreeItem<Type> item = new TreeItem<Type>(value);
            item = RecursiveSearch(item, root);
            if (item != null) return item.Value;
            else return default(Type);
        }

        private TreeItem<Type> RecursiveSearch(TreeItem<Type> item, TreeItem<Type> root)
        {
            if (root == null)
                return null;
            if (item.CompareTo(root) == 0)
                return root;
            else if (item.CompareTo(root) < 0)
                return RecursiveSearch(item, root.Left);
            else
                return RecursiveSearch(item, root.Right);
        }

        public Type Remove(Type value)
        {
            TreeItem<Type> item = new TreeItem<Type>(value);
            TreeItem<Type> aux;

            RecursiveRemove(item, root, out aux);

            if (aux != null) return aux.Value;
            else return default(Type);
        }

        private TreeItem<Type> RecursiveRemove(TreeItem<Type> who, TreeItem<Type> where, out TreeItem<Type> output)
        {
            output = null;

            if (where == null) return null;
            if (who.CompareTo(where) < 0)
                where.Left = RecursiveRemove(who, where.Left, out output);
            else if (who.CompareTo(where) > 0)
                where.Right = RecursiveRemove(who, where.Right, out output);
            else
            {
                output = new TreeItem<Type>(where.Value);
                int rate = where.Rate;
                switch (rate)
                {
                    case 0: return null;
                    case -1: return where.Left;
                    case 1: return where.Right;
                    case 2:
                        // Corrigir pois predec = where.predecessor. Codigo assim pra fazer funcionar o resto :p
                        TreeItem<Type> predec = where;
                        where.Value = predec.Value;
                        where.Left = RecursiveRemove(predec, where.Left, out output);
                        break;
                }
            }
            return where;
        }

        public override string ToString()
        {
            return InOrder(root);
        }

        public Type[] ToArray()
        {
            return _toArray(root).ToArray();
        } 

        private List<Type> _toArray(TreeItem<Type> root)
        {
            if (root != null)
            {
                List<Type> aux = new List<Type>();
                aux.AddRange(_toArray(root.Left));
                aux.Add(root.Value);
                aux.AddRange(_toArray(root.Right));
                return aux;
            }
            else return new List<Type>();
        }

        private string InOrder(TreeItem<Type> root)
        {
            if (root != null)
            {
                string aux = "";
                aux = InOrder(root.Left);
                aux += "\n" + root.Value.ToString();
                aux += "\n" + InOrder(root.Right);
                return aux;
            }
            else return "";
        }
    }
}
