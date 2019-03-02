using CustomerBasket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.Models.Discount
{
    public class FreeMilkDiscount : IDiscount
    {
        private Product _condition;

        public FreeMilkDiscount(Product quantityNeeded)
        {
            _condition = quantityNeeded;
        }

        public decimal Calculate(List<Product> products)
        {
            //find out how many milks are there in the list
            var milkQuantity = products.Where(x => x.GetType() == _condition.GetType()).Sum(x => x.Quantity);

            if (milkQuantity == 0 || milkQuantity < _condition.Quantity)
                return 0;

            //every n-th milk deducts one full price
            return (milkQuantity / _condition.Quantity) * new Milk().Price;
        }
    }
}
