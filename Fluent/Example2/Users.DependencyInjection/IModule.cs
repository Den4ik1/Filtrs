using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Users.DependencyInjection
{
    public interface IModule
    {
        void Register(IUnityContainer container);
    }
}
