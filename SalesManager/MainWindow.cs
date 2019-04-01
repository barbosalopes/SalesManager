using SalesManager.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManager
{
    public partial class MainWindow : Form
    {
        private Manager manager;

        public MainWindow()
        {
            InitializeComponent();
            manager = new Manager();
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
            manager.AddSale();
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
    }
}
