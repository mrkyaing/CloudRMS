using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.S
{
    public class UserRepository : IUserRepository
    {
        public void save()
        {
            Console.WriteLine("saving user info");
        }
    }
}
