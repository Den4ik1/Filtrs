using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Users.Infrastructure.Models;

namespace Users.InfrastructureServices.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<InfrastructureUser>
    {
        public void Configure(EntityTypeBuilder<InfrastructureUser> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(_ => _.Id);
        }
    }
}
