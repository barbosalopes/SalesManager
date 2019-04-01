using SalesManager.Controllers.Movements;
using SalesManager.Controllers.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Controllers
{
    public class Manager
    {
        private Queue<Sale> Sales;
        private Sale CurrentSale { set; get; }

        public Manager()
        {
            Sales = new Queue<Sale>();
            CurrentSale = new Sale();
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

        public void AddOfficeSuplie(string name, double basePrice, double profit, int amount = 1, double tax = 0)
        {
            AddProduct(new OfficeSupplie(name, basePrice, profit, tax), amount);
        }
    }
}
