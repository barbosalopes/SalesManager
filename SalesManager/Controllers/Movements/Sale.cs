using SalesManager.Controllers.DataStructure;
using SalesManager.Controllers.Exceptions;
using System.Text;

namespace SalesManager.Controllers.Movements
{
    public class Sale
    {
        protected Queue<Product> Products;

        public Sale()
        {
            Products = new Queue<Product>();
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
    }
}
