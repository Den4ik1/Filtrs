using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Users.Infrastructure.Intrefaces;
using Users.InfrastructureServices.Contexts;

namespace Users.InfrastructureServices.Services
{
    public class MyContextInitializationService : IMyContextInitializationService
    {
        private readonly MyContext _context;
        private readonly IUsersProvider _usersProvider;

        public MyContextInitializationService(MyContext context, IUsersProvider usersProvider)
        {
            _context = context;
            _usersProvider = usersProvider;
        }

        public void Initialize()
        {
            _context.Database.EnsureCreated();

            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] ON");

                _context.Users.RemoveRange(_context.Users);
                _context.Users.AddRange(_usersProvider.GetUsers());
                _context.SaveChanges();

                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] OFF");

                transaction.Commit();
            }
        }
    }
}
