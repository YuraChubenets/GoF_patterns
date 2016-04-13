using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public   class CustomerManager
    {

        public Customer CreateCustomer()
        {
            Customer c = new Customer();
            Storage.Instance.Subscribe(c);
            return c;
        }

        public Owner CreateOwner()
        {
            Owner o = new Owner();
            Storage.Instance.Subscribe(o);
            return o;
        }

    }
}
