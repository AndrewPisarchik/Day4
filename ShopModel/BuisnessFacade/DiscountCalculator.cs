using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopModel.Domain;

namespace ShopModel.BuisnessFacade
{
    class DiscountCalculator:IDiscountCalculator
    {

        public decimal discountSize { get; set; }
        public DiscountCalculator()
        {
            
        }

        public decimal CalculateDiscount(decimal total)
        {
            return (total - (discountSize / 100m * total));
        
        }
    }
}
