using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Domain.Models;

namespace Users.Domain.Interfaces
{
    public interface IUsersService
    {
        IList<DomainUser> SearchUsers(SearchingUsersFilter filter);

        DomainUser SearchUser(int userId);
    }
}
