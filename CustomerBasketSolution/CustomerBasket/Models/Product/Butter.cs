using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models
{
    public class Butter : Product
    {
        public override decimal Price => 0.8m;

        public Butter(): base()
        {
        }

        public Butter(int quantity): base(quantity)
        {
        }
    }
}
