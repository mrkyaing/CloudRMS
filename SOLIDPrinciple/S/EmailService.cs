using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.S
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("seding email to "+email);
        }
    }
}
