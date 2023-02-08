using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.D
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public CustomerModel GetCustomer => customerRepository.GetCustomer();

        public void Save(CustomerModel customerModel)
        {
            customerRepository.Save(customerModel);
        }
    }
}
