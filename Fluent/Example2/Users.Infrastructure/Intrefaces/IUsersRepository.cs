using System.Collections.Generic;
using Users.Infrastructure.Models;

namespace Users.Infrastructure.Intrefaces
{
    public interface IUsersRepository
    {
        List<InfrastructureUser> GetUsers(int limit, int offset);

        InfrastructureUser GetUser(int userId);
    }
}
