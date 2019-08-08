using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Users.Domain.Interfaces;

namespace UsersApi
{
    public static class AppInit
    {
        public static void Initialize()
        {
            using (var scope = GlobalConfiguration.Configuration.DependencyResolver.BeginScope())
            {
                var service = (IDomainInitializationService)scope.GetService(typeof(IDomainInitializationService));

                service.Initialize();
            }
        }
    }
}