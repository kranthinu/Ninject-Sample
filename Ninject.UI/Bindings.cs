using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject.Extensions.Conventions;
using Ninject.BLL;

namespace Ninject.UI
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x => x.FromAssembliesMatching("Ninject.*")
                .SelectAllClasses()
                .BindAllInterfaces()
                );
        }
    }
}
