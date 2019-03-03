using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Interfaces
{
    public interface IProduct
    {
        int Quantity { get; }
        void AddQuantity(int amount);

        decimal Total();
    }
}
