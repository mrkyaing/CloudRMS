using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.D
{
    public interface ICustomerRepository
    {
        void Save(CustomerModel customerModel);
        public CustomerModel GetCustomer();
    }
}
