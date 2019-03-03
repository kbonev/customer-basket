using CustomerBasket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models.Discount
{
    public class PercentageBreadDiscount : IDiscount
    {
        //debatable if I should provide this flexibility this early, but as I code for myself - I don't like relying on hard-coded values.
        private decimal _percentageDiscount;
        private IProduct _condition;

        public PercentageBreadDiscount(IProduct condition, decimal percentageDiscount)
        {
            _condition = condition;
            _percentageDiscount = percentageDiscount;
        }

        public decimal Calculate(List<IProduct> products)
        {
            var productMatching = products.Where(x => x.GetType() == _condition.GetType()).ToList();
            var productMatchingCount = productMatching.Sum(x => x.Quantity);

            if (productMatchingCount == 0 || productMatchingCount < _condition.Quantity)
                return 0;

            var discountQuantity = productMatchingCount / _condition.Quantity;      
            var discountAmount = (_percentageDiscount / 100) * new Bread().Price;

            return discountQuantity * discountAmount;
        }
    }
}
