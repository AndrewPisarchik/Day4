using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopModel.Domain;
using ShopModel.BuisnessFacade;
using Ninject;

namespace ShopModel
{
    public static class Program
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<IDiscountCalculator>().To<DiscountCalculator>().WithPropertyValue("discountSize",5m);
            kernel.Bind<IValueCalculator>().To<ValueCalculator>().InTransientScope();
            kernel.Bind<IProductBuilder>().To<ProductBuilder>().InSingletonScope();
            IShoppingCart cart = kernel.Get<ShoppingCart>();
            Console.WriteLine("Total price = {0}$", cart.CalculateProductTotal());
            Console.ReadLine();

            
        }
    }
}