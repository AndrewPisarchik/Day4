using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopModel.Domain;

namespace ShopModel
{
    public class ValueCalculator:IValueCalculator
    {
        private readonly IDiscountCalculator discounter;
        public ValueCalculator(IDiscountCalculator discounter)
        {
            this.discounter = discounter;    
        }

        public decimal ValueProducts(IList<Product> products)
        {
           
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
          //  return sumOfProduct;
            return discounter.CalculateDiscount(sumOfProduct);
        }
    }
}
