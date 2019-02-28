using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models
{
    public abstract class Product
    {
        public abstract decimal Price { get; }
        public int Quantity { get; set; }
        

    }
}
