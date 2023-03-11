using Microsoft.AspNetCore.Identity;

namespace WebAppWithIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
