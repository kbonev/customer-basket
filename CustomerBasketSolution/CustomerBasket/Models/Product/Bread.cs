using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models
{
    public class Bread : Product
    {
        public override decimal Price => 0.8m;

        public Bread(): base()
        {
        }

        public Bread(int quantity): base(quantity)
        {
        }
    }
}
