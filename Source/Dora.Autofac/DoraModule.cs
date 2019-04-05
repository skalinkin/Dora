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

            builder.RegisterType<DefaultTransmitBehavior>().As<ITransmitBehavior>();
            builder.RegisterType<DotTransmitBehavior>().As<ITransmitBehavior>();
            builder.RegisterType<AnalogRadio>().As<Radio>();
            builder.RegisterType<ConventionalRadio>().As<Radio>();
            builder.RegisterType<PeaseRadio>().As<Radio>();
            builder.RegisterType<SimplexRadio>().As<Radio>();
            builder.RegisterType<OruamKcinRadio>().As<Radio>();
            builder.RegisterType<RussianRadio>().As<Radio>();
            builder.RegisterType<BrokenLspRadio>().As<Radio>();
            builder.RegisterType<MoscowRadio>().As<Radio>();

        }
    }
}