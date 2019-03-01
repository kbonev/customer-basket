using CustomerBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Interfaces
{
    public interface IDiscount
    {
        decimal Calculate(List<Product> products);
    }
}
