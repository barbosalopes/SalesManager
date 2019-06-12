using SalesManager.Controllers.DataStructure;
using SalesManager.Controllers.Movements;
using SalesManager.Controllers.Products;
using System.Text;

namespace SalesManager.Controllers
{
    public class Manager
    {
        private Queue<Sale> Sales;
        private Sale CurrentSale { set; get; }

        public Manager()
        {
            Sales = new Queue<Sale>();
        }

        public void AddProduct(Product product, int amount = 1)
        {
            for (int i = 0; i < amount; i++)
                CurrentSale.AddProduct(product.Clone());
        }

        public void AddFood(string name, double basePrice, double profit, int amount = 1, double tax = 0)
        {
            AddProduct(new Food(name, basePrice, profit, tax), amount);
        }

        public void AddDrink(string name, double basePrice, double profit, int amount = 1, double tax = 0)
        {
            AddProduct(new Drink(name, basePrice, profit, tax), amount);
        }

        public void AddDomesticUtensil(string name, double basePrice, double profit, int amount = 1, double tax = 0)
        {
            AddProduct(new DomesticUtensil(name, basePrice, profit, tax), amount);
        }

        public void AddOfficeSupplie(string name, double basePrice, double profit, int amount = 1, double tax = 0)
        {
            AddProduct(new OfficeSupplie(name, basePrice, profit, tax), amount);
        }

        public static System.Collections.Generic.List<Product> ShowAllProducts(int type)
        {
            System.Collections.Generic.List<Product> productsToReturn = new System.Collections.Generic.List<Product>();
            foreach (Product p in Stock.GetProducts().ToArray())
                if (p.GetTypeCode() == type) productsToReturn.Add(p);
            return productsToReturn;
        }

        public static Product ShowProductWithBiggestSelledValue()
        {
            Product[] products = Stock.GetProducts().ToArray();
            Product product = new Food("Mock", 0, 0);
            double mostSelledValue = 0, selledValue = 0;

            foreach(Product p in products)
            {
                foreach (int sell in p.SalesNumber.Keys) selledValue += p.GetPrice() * p.SalesNumber[sell];
                if(selledValue > mostSelledValue)
                {
                    mostSelledValue = selledValue;
                    product = p;
                }

                selledValue = 0;
            }
            return product;
        }
    }
}
