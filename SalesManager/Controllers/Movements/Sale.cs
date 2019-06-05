using SalesManager.Controllers.DataStructure;
using SalesManager.Controllers.Exceptions;
using System;
using System.Text;

namespace SalesManager.Controllers.Movements
{
    public class Sale : IComparable
    {
        protected Queue<Product> Products;
        protected int cod;

        public Sale(int cod)
        {
            Products = new Queue<Product>();
        }

        public int GetCod()
        {
            return cod;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Product couldRemove;
            couldRemove = (Product)Products.Remove(product);
            if (couldRemove == null)
            {
                throw new ProductUnavailable("Movement");
            }
        }

        public double GetBilledValue()
        {
            double billedValue = 0;

            foreach (Product product in Products.ToArray())
            {
                billedValue += product.GetPrice();
            }

            return billedValue;
        }

        public double GetBasePrice()
        {
            double basePrice = 0;

            foreach (Product product in Products.ToArray())
            {
                basePrice += product.GetBasePrice();
            }

            return basePrice;
        }

        public Queue<Product> GetProducts()
        {
            return Products;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Sale:");
            str.AppendLine(Products.ToString());
            return str.ToString();
        }

        public int CompareTo(object obj)
        {
            Sale toCompare = (Sale)obj;
            return GetHashCode().CompareTo(toCompare.GetHashCode());
        }
    }
}
