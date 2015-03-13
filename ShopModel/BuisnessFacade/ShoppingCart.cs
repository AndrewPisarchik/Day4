using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopModel.Domain;
using ShopModel.BuisnessFacade;

namespace ShopModel
{
    public class ShoppingCart:IShoppingCart
    {
        
        private readonly IValueCalculator valueCalc;
        private readonly IProductBuilder prodBuild;

        
      //  public IValueCalculator valueCalc { get; set; }
        public IList<Product> Products { get; set; }

        public ShoppingCart(IValueCalculator valueCalc, IProductBuilder prodBuild)
        {
            this.valueCalc = valueCalc;
            this.prodBuild = prodBuild;
            
        }

    

        public decimal CalculateProductTotal()
        {
            Products = prodBuild.AddProducts();
            if (Products.Count == 0)
                throw new NoProductException();
            return valueCalc.ValueProducts(Products);
        }
    }
}
