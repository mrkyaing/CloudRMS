using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloudRMS.Models
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
             new User
             {
                 FirstName = "Mg",
                 LastName = "Kyaing",
                 PasswordHash="admin"
             },
             new User
             {
                 FirstName = "Saw ",
                 LastName = "Yu Nandar"
             });
        }
    }
}
