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

        public void AddSale(int cod)
        {
            if(CurrentSale.GetProducts().Size() != 0)
            {
                Sales.Add(CurrentSale);
                CurrentSale = new Sale(cod);
            }

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

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Current Sale: ");
            if (CurrentSale.GetProducts().Size() != 0)
                str.AppendLine(CurrentSale.ToString());
            else
                str.AppendLine("No items");

            str.AppendLine("Sales:");
            str.AppendLine(Sales.ToString());
            return str.ToString();
        }

        public static System.Collections.Generic.List<Product> ShowAllProducts(int type)
        {
            System.Collections.Generic.List<Product> productsToReturn = new System.Collections.Generic.List<Product>();
            foreach (Product p in Stock.GetProducts().ToArray())
                if (p.GetTypeCode() == type) productsToReturn.Add(p);
            return productsToReturn;
        }
    }
}
