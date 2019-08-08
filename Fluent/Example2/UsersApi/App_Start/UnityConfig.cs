using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Users.DependencyInjection;
using Users.DependencyInjection.Moduls;
using Users.Domain.Interfaces;

namespace UsersApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            Register<InfrastructureModule>(container);
            Register<DomainModule>(container);

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //using (var scope = container.CreateChildContainer())
            //{
            //    var service = scope.Resolve<IDomainInitializationService>();

            //    service.Initialize();
            //}

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T : IModule, new()
        {
            new T().Register(container);
        }
    }
}