using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using Users.Infrastructure.Intrefaces;
using Users.InfrastructureServices.Contexts;
using Users.InfrastructureServices.Repositories;
using Users.InfrastructureServices.Services;

namespace Users.DependencyInjection.Moduls
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);

            using (var context = new MyContext(optionsBuilder.Options)) context.Database.EnsureCreated();

            container.RegisterType<MyContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));

            container.RegisterType<IMyContextInitializationService, MyContextInitializationService>(
                new HierarchicalLifetimeManager());

            container.RegisterType<IUsersProvider, FakeUsersRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsersRepository, UsersRepository>(new HierarchicalLifetimeManager());
        }
    }
}
