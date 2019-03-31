using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Controllers.Exceptions
{
    class ProductUnavailable : Exception
    {
        public ProductUnavailable(string location) : base("The product does not exists on the " + location) { }
    }
}
