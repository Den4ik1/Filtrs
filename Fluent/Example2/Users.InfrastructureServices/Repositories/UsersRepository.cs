using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Infrastructure.Intrefaces;
using Users.Infrastructure.Models;
using Users.InfrastructureServices.Contexts;

namespace Users.InfrastructureServices.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly MyContext _context;

        public UsersRepository(MyContext context)
        {
            _context = context;
        }

        public List<InfrastructureUser> GetUsers(int limit, int offset)
        {
            return _context.Users.Skip(offset).Take(limit).ToList();
        }

        public InfrastructureUser GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(_ => _.Id == userId);
        }
    }
}
