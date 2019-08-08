using Microsoft.Practices.Unity;
using Users.Domain.Interfaces;
using Users.DomainService.Services;

namespace Users.DependencyInjection.Moduls
{
    public class DomainModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IDomainInitializationService, DomainInitializationService>(
                new HierarchicalLifetimeManager());
            container.RegisterType<IUsersService, UsersService>(new HierarchicalLifetimeManager());
        }
    }
}
