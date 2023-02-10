using SOLIDPrinciple.S;
using Xunit;
namespace CloudRMS.Test
{
    public class UnitTestS
    {
        [Fact]
        public void SendEmail_ReturnSuccess()
        {
            // Arrange  
            string email = "akog02@gmail.com";
            IEmailService emailService = new EmailService();
            // Act  
            string actualEmail = emailService.SendEmail(email);
            //Assert  
            Assert.True(email.Equals(actualEmail));

        }
    }
}
