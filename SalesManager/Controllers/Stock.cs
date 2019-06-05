using SalesManager.Controllers.DataStructure;
using SalesManager.Controllers.Movements;
using SalesManager.Controllers.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Controllers
{
    public static class Stock
    {
        private static Tree<Product> products = new Tree<Product>();
        private static Tree<Sale> sales = new Tree<Sale>();

        public static double AmountSpent { get { return amountSpent; } }
        private static double amountSpent = 0;
        public static double AmountEarned { get { return amountEarned; } }
        private static double amountEarned = 0;

        public const int DRINK_TYPE = 1;
        public const int FOOD_TYPE = 2;
        public const int OFFICE_SUPLIE_TYPE = 3;
        public const int DOMESTIC_UTENSIL_TYPE = 4;

        public static Tree<Product> GetProducts()
        {
            return products;
        }

        public static Tree<Sale> GetSales()
        {
            return sales;
        }

        public static Product GetProduct(string productName)
        {
            Product p = new Food(productName, 0, 0);
            return products.Search(p);
        }

        public static void AddProduct(Product product)
        {
            products.Insert(product);
        }
        public static void AddProducts(Product[] products)
        {
            foreach (Product p in products)
            {
                AddProduct(p);
            }
        }
        public static Product RemoveProduct(Product product)
        {
            Product removeItem = products.Remove(product);
            return removeItem;
        }
        public static void RemoveProducts(Product[] products)
        {
            List<Product> removedProducts = new List<Product>();
            foreach (Product p in products)
            {
                removedProducts.Add(RemoveProduct(p));
            }
        }
        public static void AddSale(Sale sale)
        {
            sales.Insert(sale);
            foreach(Product p in sale.GetProducts().ToArray())
            {
                // To avoid more complexity on reading from Sale.GetBasePrice and Sale.GetBilledValue
                amountEarned += p.GetPrice();
                amountSpent += p.GetBasePrice();

                Product product = products.Search(p);
                product.AddSale(sales.GetHashCode());
            }
        }
    }
}
