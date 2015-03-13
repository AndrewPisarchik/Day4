using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ShopModel.BuisnessFacade
{
    [Serializable]
   public  class NoProductException:Exception
    {
        public NoProductException()
        {
        }

        public NoProductException(string message)
            : base(message)
        {
        }

        public NoProductException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected NoProductException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }



    }
}
