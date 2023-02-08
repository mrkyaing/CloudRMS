using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.D
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerModel GetCustomer()=>  new CustomerModel() { Id = "c101", Name = "susu", DeliveryAddress = "yng" };
        
        public void Save(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }
    }
}
