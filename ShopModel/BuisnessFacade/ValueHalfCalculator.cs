using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopModel.Domain;

namespace ShopModel.BuisnessFacade
{
    class ValueHalfCalculator:IValueCalculator
    {
       public ValueHalfCalculator()
        { 
        
        }

       public decimal ValueProducts(IList<Product> products)
       {
           decimal sumOfProduct = 0;
           foreach (var product in products)
           {
               sumOfProduct += product.Price/2;
           }
           return sumOfProduct;
       }
    }
}
