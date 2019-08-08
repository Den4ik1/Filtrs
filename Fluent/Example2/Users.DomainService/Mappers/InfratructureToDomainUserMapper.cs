using Users.Domain.Models;
using Users.Infrastructure.Models;

namespace Users.DomainService.Mappers
{
    public static class InfratructureToDomainUserMapper
    {
        public static DomainUser ToDomain(this InfrastructureUser @this)
        {
            return new DomainUser()
            {
                Name = @this.Name,
                Role = @this.Role,
                Sex = @this.Sex,
                Age = @this.Age
            };
        }
    }
}
