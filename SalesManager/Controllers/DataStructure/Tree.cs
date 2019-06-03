using SalesManager.Controllers.Element;

namespace SalesManager.Controllers.DataStructure
{
    class Tree<Type>
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
            return RecursiveSearch(item, root).Value;
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
            return aux.Value;
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
                        TreeItem<Type> predec = where.Predecessor;
                        where.Value = predec.Value;
                        where.Left = RecursiveRemove(predec, where.Left, out output);
                }
            }
            return where;
        }
    }
}
