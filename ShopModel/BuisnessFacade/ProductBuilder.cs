using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopModel.Domain;

namespace ShopModel.BuisnessFacade
{
   public class ProductBuilder:IProductBuilder
    {
        public ProductBuilder()
        { 
            
        }

        public IList<Product> AddProducts()
        {
            return new List<Product>
                       {
                           new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                           new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                       };    
        }
    }
}
