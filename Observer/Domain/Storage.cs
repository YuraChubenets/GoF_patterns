using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public sealed  class Storage
    {
       
        static Storage init = null;

       
        public static Storage Instance
        {
            get {   if (init == null)
                    init = new Storage();
                return init;
            }
        }

        List<INotify> subscribes = new List<INotify>();

        public void Subscribe(INotify notify)
        {
            subscribes.Add(notify);
        }


        public void AddProduct()
        {
            Console.WriteLine("add product--"+ this.GetHashCode());
            //-business logic
            subscribes.ForEach(c => c.Notify());
        }

    }
}
