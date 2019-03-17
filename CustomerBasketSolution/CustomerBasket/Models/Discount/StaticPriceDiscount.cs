using CustomerBasket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models.Discount
{
    public class StaticPriceDiscount : IDiscount
    {
        private IProduct _condition;
        private decimal _discountAmount;

        public StaticPriceDiscount(IProduct quantityNeeded, decimal discountAmount)
        {
            _condition = quantityNeeded;
            _discountAmount = discountAmount;
        }

        public decimal Calculate(List<IProduct> products)
        {
            //find out how many milks are there in the list
            var conditionQuantity = products.Where(x => x.Name == _condition.Name).Sum(x => x.Quantity);

            if (conditionQuantity == 0 || conditionQuantity < _condition.Quantity)
                return 0;

            //every n-th number deducts one discount price
            return (conditionQuantity / _condition.Quantity) * _discountAmount;
        }
    }
}
