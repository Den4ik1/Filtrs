using Users.InfrastructureServices.Contexts;
using Users.Infrastructure.Models;
using Users.Infrastructure.Intrefaces;

namespace Users.InfrastructureServices.Repositories
{
    public class Logrepository : ILogrepository
    {
        private readonly MyContext _context;

        public Logrepository(MyContext context)
        {
            _context = context;
        }

        public void RequestInformation(ReqestLogEntry entry)
        {
            _context.ReqestLog.Add(entry);
        }
    }
}
