using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAppWithIdentity.Models.DAO
{
    public class WebAppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {

        }
    }
}
