using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel.Domain
{
   public interface IValueCalculator
    {
         decimal ValueProducts(IList<Product> products);
    }
}
