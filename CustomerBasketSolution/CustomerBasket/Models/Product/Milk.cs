using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models
{
    public class Milk : Product
    {
        public override decimal Price => 1.15m;

        public Milk(): base()
        {
        }

        public Milk(int quantity): base(quantity)
        {
        }
    }
}
