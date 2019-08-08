
using Users.Infrastructure.Models;

namespace Users.Infrastructure.Intrefaces
{
    public interface ILogrepository
    {
        void RequestInformation(ReqestLogEntry entry);
    }
}
