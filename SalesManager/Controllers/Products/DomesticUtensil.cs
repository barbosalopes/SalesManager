﻿namespace SalesManager.Controllers.Products
{
    public class DomesticUtensil : Product
    {
        private static int MinAmount;

        public DomesticUtensil(string name, double basePrice, double profit, double tax = 0) : base(name, basePrice, profit, tax)
        {
        }

        public static void SetMinAmount(int minAmount)
        {
            if (minAmount > 0)
                MinAmount = minAmount;
        }

        public override double GetMaxProfit()
        {
            return 0.25;
        }

        public override int GetMinAmount()
        {
            return MinAmount;
        }


        public override double GetMinProfit()
        {
            return 0.15;
        }

        public override int GetTypeCode()
        {
            return 4;
        }
    }
}
