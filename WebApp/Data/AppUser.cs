using Microsoft.AspNetCore.Identity;

namespace WebApp.Data
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public string ProfileUrl { get; set; }
    }
}
