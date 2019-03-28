namespace SalesManager.Controllers.Element
{
    public class Item<Type>
    {
        public Type Value { set; get; }

        public Item<Type> Next { set; get; }

        public Item(Type value)
        {
            Value = value;
            Next = null;
        }

        public override bool Equals(object obj)
        {
            return Value.Equals((Type)obj);
        }
    }
}
