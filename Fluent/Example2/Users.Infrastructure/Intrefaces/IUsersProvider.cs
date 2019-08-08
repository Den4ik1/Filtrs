using System.Collections.Generic;
using Users.Infrastructure.Models;

namespace Users.Infrastructure.Intrefaces
{
    public interface IUsersProvider
    {
        IList<InfrastructureUser> GetUsers();
    }
}
