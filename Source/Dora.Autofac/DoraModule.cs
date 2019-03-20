using System.ComponentModel.Composition;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Avtec.DevMorningFix.Dora.StrategyPatternDemo;
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

            builder.RegisterType<AnalogRadio>().As<Radio>();
            builder.RegisterType<ConventionalRadio>().As<Radio>();
        }
    }
}