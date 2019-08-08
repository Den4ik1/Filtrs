using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Users.Infrastructure.Models;

namespace Users.InfrastructureServices.Configurations
{
    public class ReqestLogEntryConfiguration : IEntityTypeConfiguration<ReqestLogEntry>
    {
        public void Configure(EntityTypeBuilder<ReqestLogEntry> builder)
        {
            builder.ToTable("logs");
            builder.HasKey(_ => _.Id);
        }
    }
}
