using System.ComponentModel.Composition;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Module = Autofac.Module;

namespace Avtec.DevMorningFix.Dora.Autofac
{
    [Export(typeof(IModule))]
    internal class DoraModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetAssembly(typeof(IStart));
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces();
        }
    }
}