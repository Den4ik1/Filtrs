using Users.Domain.Interfaces;
using Users.Infrastructure.Intrefaces;

namespace Users.DomainService.Services
{
    public class DomainInitializationService : IDomainInitializationService
    {
        private readonly IMyContextInitializationService _myContextInitializationService;

        public DomainInitializationService(IMyContextInitializationService myContextInitializationService)
        {
            _myContextInitializationService = myContextInitializationService;
        }

        public void Initialize()
        {
            _myContextInitializationService.Initialize();
        }
    }
}
