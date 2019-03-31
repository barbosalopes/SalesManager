using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Controllers.Exceptions
{
    class InvalidProfit : Exception
    {
        public InvalidProfit(double min, double max) :
            base("The profit must be between " + min + " and " + max)
        { }
    }
}
