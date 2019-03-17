using CustomerBasket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models.Discount
{
    public class PercentagePriceDiscount : IDiscount
    {
        private decimal _percentageDiscount;
        private IProduct _target;
        private IProduct _condition;

        public PercentagePriceDiscount(IProduct condition, IProduct target, decimal percentageDiscount)
        {
            _target = target;
            _condition = condition;
            _percentageDiscount = percentageDiscount;
        }

        public decimal Calculate(List<IProduct> products)
        {
            var conditionProductMatching = products.Where(x => x.Name == _condition.Name).ToList();
            var conditionProductMatchingCount = conditionProductMatching.Sum(x => x.Quantity);

            var targetProductMatching = products.Where(x => x.Name == _target.Name).ToList();
            var targetProductMatchingCount = targetProductMatching.Sum(x => x.Quantity);

            if (conditionProductMatchingCount == 0 || conditionProductMatchingCount < _condition.Quantity)
                return 0;

            //how many times the condition is met
            var discountQuantity = conditionProductMatchingCount / _condition.Quantity;

            //how many times the target meets the condition; 
            //4 butters and 1 bread = 1 discount; 6 butters, 2 breads = 2 discounts;
            if (targetProductMatchingCount <= discountQuantity)
                discountQuantity = discountQuantity - (discountQuantity - targetProductMatchingCount);

            var discountAmount = (_percentageDiscount / 100) * _target.Price;

            return discountQuantity * discountAmount;
        }
    }
}
