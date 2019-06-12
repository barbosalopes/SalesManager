using SalesManager.Controllers;
using SalesManager.Controllers.Movements;
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

        public MainWindow()
        {
            InitializeComponent();
            manager = new Manager();
            FileManager.Build(@"C:\Users\mateu\Desktop\AED\AEDprodutos.txt");
            FileManager.Run(@"C:\Users\mateu\Desktop\AED\AEDvendas.txt");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (drink.Checked)
                manager.AddDrink(name.Text, (double)basePrice.Value, (double)profit.Value, 
                    (int)amount.Value, (double)tax.Value);
            else if(food.Checked)
                manager.AddDrink(name.Text, (double)basePrice.Value, (double)profit.Value, 
                    (int)amount.Value, (double)tax.Value);
            else if (domesticUtensil.Checked)
                manager.AddDomesticUtensil(name.Text, (double)basePrice.Value, (double)profit.Value,
                    (int)amount.Value, (double)tax.Value);
            else if (officeSupplie.Checked)
                manager.AddOfficeSupplie(name.Text, (double)basePrice.Value, (double)profit.Value,
                    (int)amount.Value, (double)tax.Value);

            UpdateConsole();
            Reset();
        }

        private void createNewSale_Click(object sender, EventArgs e)
        {
            manager.AddSale(nextCode);
            nextCode++;
            UpdateConsole();
            Reset();
        }

        private void UpdateConsole()
        {
            console.Text = manager.ToString();
        }

        private void Reset()
        {
            name.ResetText();
            basePrice.ResetText();
            profit.ResetText();
            amount.ResetText();
            tax.ResetText();
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
    }
}
