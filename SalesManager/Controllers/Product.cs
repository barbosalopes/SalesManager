using SalesManager.Controllers.DataStructure;
using SalesManager.Controllers.Exceptions;
using SalesManager.Controllers.Movements;
using System;
using System.Text;

namespace SalesManager.Controllers
{
    public abstract class Product : Saleable, IComparable
    {
        protected double BasePrice;
        protected double Tax;
        protected double Profit;
        protected string Name;

        protected System.Collections.Generic.Dictionary<int, int> salesNumbers;
        public System.Collections.Generic.Dictionary<int, int> SalesNumber { get { return salesNumbers; } }

        public Product(string name, double basePrice, double profit, double tax = 0)
        {
            BasePrice = basePrice;
            Tax = tax;
            Profit = profit;
            Name = name;
            salesNumbers = new System.Collections.Generic.Dictionary<int, int>();
        }

        public virtual void SetProfit(double profit)
        {
            if (profit < GetMinProfit() || profit > GetMaxProfit())
            {
                throw new InvalidProfit(GetMinProfit(), GetMaxProfit());
            }
            else
            {
                Profit = profit;
            }
        }

        public abstract double GetMaxProfit();

        public abstract double GetMinProfit();

        public virtual double GetProfit()
        {
            return Profit;
        }

        public virtual double GetPrice()
        {
            return BasePrice * (1 + Profit) * (1 + GetTax());
        }

        public virtual double GetBasePrice()
        {
            return BasePrice;
        }

        public virtual double GetPriceWithoutTax()
        {
            return BasePrice * (1 + Profit);
        }

        public virtual double GetTax()
        {
            return Tax;
        }

        public abstract int GetMinAmount();

        public virtual string GetName()
        {
            return Name;
        }

        public abstract int GetTypeCode();

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            return GetName() == product.GetName();
        }

        public override int GetHashCode()
        {
            var hashCode = 839513692;
            hashCode = hashCode * -1521134295 + BasePrice.GetHashCode();
            hashCode = hashCode * -1521134295 + Tax.GetHashCode();
            hashCode = hashCode * -1521134295 + Profit.GetHashCode();
            hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Name: " + GetName() + "\nValue: R$" + GetPrice());
            return str.ToString();
        }

        public void AddSale(int Identifier)
        {
            if (salesNumbers.ContainsKey(Identifier))
                salesNumbers[Identifier]++;
            else
                salesNumbers.Add(Identifier, 1);
        }

        public Product Clone()
        {
            return (Product)MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Product toCompare = (Product)obj;
            return Name.CompareTo(toCompare.Name);
        }
    }
}
