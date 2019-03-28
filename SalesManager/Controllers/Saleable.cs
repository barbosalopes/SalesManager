namespace SalesManager.Controllers
{
    public interface Saleable
    {
        double GetPrice();
        double GetTax();
        double GetMaxProfit();
        double GetMinProfit();
    }

}
