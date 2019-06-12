using SalesManager.Controllers;
using SalesManager.Controllers.Movements;
using SalesManager.Controllers.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SalesManager
{
    public partial class MainWindow : Form
    {
        private Manager manager;
        int nextCode = 38000;
        private Sale currentSale;

        public MainWindow()
        {
            InitializeComponent();
            manager = new Manager();
            FileManager.Build(@"C:\Users\mateu\Desktop\AED\AEDprodutos.txt");
            FileManager.Run(@"C:\Users\mateu\Desktop\AED\AEDvendas.txt");
            currentSale = new Sale(nextCode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product toAdd = Stock.GetProduct(name.Text);

            for (int i = (int)amount.Value; i > 0; i--)
                currentSale.AddProduct(toAdd);

            UpdateConsole();
            Reset();
        }

        private void createNewSale_Click(object sender, EventArgs e)
        {
            Stock.AddSale(currentSale);
            foreach(Product p in currentSale.GetProducts().ToArray())
                Stock.AddSaleToProduct(currentSale.GetHashCode(), p);
            
            nextCode++;
            currentSale = new Sale(nextCode);
            UpdateConsole();
            Reset();
        }

        private void UpdateConsole()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Current Sale: ");
            if (currentSale.GetProducts().Size() != 0)
                str.AppendLine(currentSale.ToString());
            else
                str.AppendLine("No items");
            
            console.Text = str.ToString();
        }

        private void Reset()
        {
            name.ResetText();
            amount.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int type = int.Parse(report_product_code.Text);
            List<Product> products = Manager.ShowAllProducts(type);

            StringBuilder str = new StringBuilder("All products list:\n");
            foreach (Product p in products)
                str.AppendLine(p.ToString());
            console.Text = str.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            console.Text = "Amount Earned: R$" + Stock.AmountEarned.ToString() + 
                "\nAmount Spent: R$" + Stock.AmountSpent.ToString() +
                "\nProfit: R$" + (Stock.AmountEarned - Stock.AmountSpent);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string productName = report_product_name.Text;
            Product prod = Stock.GetProduct(productName);
            console.Text = "";
            if (prod != null)
            {
                StringBuilder s = new StringBuilder("Sales codes:");
                foreach (int i in prod.SalesNumber.Keys)
                    s.AppendLine(i.ToString());

                console.Text = s.ToString();
            } else
            {
                console.Text = "Product " + productName + " not found!";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
            console.Text = Manager.ShowProductWithBiggestSelledValue().ToString();
        }
    }
}
