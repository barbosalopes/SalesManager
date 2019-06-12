using SalesManager.Controllers.Movements;
using SalesManager.Controllers.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Controllers
{
    class FileManager
    {
        public static void Build(string fileLocation)
        {
            string line;
            StreamReader buildFile = new StreamReader(@fileLocation);

            Product p = null;
            string name;
            int category, initialStock, minStock;
            double basePrice, profit;

            while ((line = buildFile.ReadLine()) != null)
            {
                string[] productParams = line.Split(';');
                name = productParams[0];
                category = int.Parse(productParams[1]);
                profit = double.Parse(productParams[2]);
                profit /= 100;
                basePrice = double.Parse(productParams[3]);
                initialStock = int.Parse(productParams[4]);
                minStock = int.Parse(productParams[5]);

                switch (category)
                {
                    case 1:
                        p = new Drink(name, basePrice, profit);
                        break;
                    case 2:
                        p = new Food(name, basePrice, profit);
                        break;
                    case 3:
                        p = new OfficeSupplie(name, basePrice, profit);
                        break;
                    case 4:
                        p = new DomesticUtensil(name, basePrice, profit);
                        break;
                }
                
                // Remove it because will be not needed now
                //for (int i = 0; i < initialStock; i++)

                if (Stock.GetProducts().Search(p) == null)
                    Stock.AddProduct(p);
            }
        }

        public static void Run(string fileLocation)
        {
            string line;
            StreamReader runFile = new StreamReader(@fileLocation);

            Product p = null, pAux = null;
            Sale s = null;
            string productName;
            int productAmount, selledAmount, saleCode;

            while ((line = runFile.ReadLine()) != null)
            {
                string[] sellParams = line.Split(';');
                saleCode = int.Parse(sellParams[0]);
                productAmount = int.Parse(sellParams[1]);
                s = new Sale(saleCode);

                for (int i = 0; i < productAmount; i++)
                {
                    line = runFile.ReadLine();
                    string[] saleParams = line.Split(';');
                    productName = saleParams[0];
                    selledAmount = int.Parse(saleParams[1]);
                    pAux = Stock.GetProduct(productName);
                    
                    for (int j = 0; j < selledAmount; j++)
                    {
                        s.AddProduct(pAux);
                        Stock.AddSaleToProduct(s.GetHashCode(), pAux);
                    }
                }
                Stock.AddSale(s);
            }
        }
    }
}
