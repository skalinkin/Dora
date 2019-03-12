using System.ComponentModel.Composition;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Module = Autofac.Module;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    [Export(typeof(IModule))]
    internal class ConsoleAppModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
        }
    }
}