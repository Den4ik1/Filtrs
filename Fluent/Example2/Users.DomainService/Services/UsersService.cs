using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Domain.Interfaces;
using Users.Domain.Models;
using Users.DomainService.Mappers;
using Users.Infrastructure.Intrefaces;

namespace Users.DomainService.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public IList<DomainUser> SearchUsers(SearchingUsersFilter filter)
        {
            if (filter == null)
                throw new ArgumentNullException("Filter");

            var users = _usersRepository.GetUsers(filter.Limit, filter.Offset);

            return users.Select(_ => _.ToDomain()).ToList();
        }

        public DomainUser SearchUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
