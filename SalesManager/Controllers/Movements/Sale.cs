using SalesManager.Controllers.DataStructure;
using SalesManager.Controllers.Exceptions;

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
    }
}
