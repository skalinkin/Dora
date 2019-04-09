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

            builder.RegisterType<DotTransmitBehavior>().AsSelf();
            builder.RegisterType<RGBTransmitBehavior>().AsSelf();
            builder.RegisterType<DefaultTransmitBehavior>().As<ITransmitBehavior>();
            builder.RegisterType<AnalogRadio>().As<Radio>();
            builder.RegisterType<ConventionalRadio>().As<Radio>();
            builder.RegisterType<PeaseRadio>().As<Radio>();

            builder.RegisterType<IrmoRadio>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ITransmitBehavior),
                    (pi, ctx) => ctx.Resolve<RGBTransmitBehavior>())).As<Radio>();

            builder.RegisterType<OruamKcinRadio>().As<Radio>();
            builder.RegisterType<RussianRadio>().As<Radio>();
            builder.RegisterType<BrokenLspRadio>().As<Radio>();
            builder.RegisterType<MoscowRadio>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ITransmitBehavior),
                    (pi, ctx) => ctx.Resolve<DotTransmitBehavior>())).As<Radio>();
        }
    }
}