using System.Collections.Generic;
using System.Linq;
using Users.Infrastructure.Intrefaces;
using Users.Infrastructure.Models;

namespace Users.InfrastructureServices.Repositories
{
    public class FakeUsersRepository : IUsersRepository, IUsersProvider
    {
        public List<InfrastructureUser> data = new List<InfrastructureUser>()
        {
            new InfrastructureUser() { Id = 1, Name = "Денис", Role = "Admin", Sex = "М", Age = 20},
            new InfrastructureUser() { Id = 2, Name = "Александр", Role = "Admin", Sex = "М", Age = 21},
            new InfrastructureUser() { Id = 3, Name = "Арсений", Role = "Admin", Sex = "М", Age = 22},
            new InfrastructureUser() { Id = 4, Name = "Виктория", Role = "Admin", Sex = "Ж", Age = 25},
            new InfrastructureUser() { Id = 5, Name = "Андрей", Role = "Admin", Sex = "М", Age = 20},
            new InfrastructureUser() { Id = 6, Name = "Дмитрий", Role = "Admin", Sex = "М", Age = 40},
            new InfrastructureUser() { Id = 7, Name = "Евгений", Role = "Admin", Sex = "М", Age = 33},
            new InfrastructureUser() { Id = 8, Name = "Юрий", Role = "Admin", Sex = "М", Age = 21}
        };

        public List<InfrastructureUser> GetUsers(int limit, int offset)
        {
            IEnumerable<InfrastructureUser> users;

            if (offset < data.Count)
            {
                users = data.Skip(offset).Take(limit);
            }
            else
            {
                users = Enumerable.Empty<InfrastructureUser>();
            }

            return users.ToList();
        }

        public InfrastructureUser GetUser(int userId)
        {
            return data.FirstOrDefault(_ => _.Id == userId);
        }

        public IList<InfrastructureUser> GetUsers()
        {
            return data.ToList();
        }
    }
}
