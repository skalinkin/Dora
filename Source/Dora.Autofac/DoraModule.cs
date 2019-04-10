using Autofac;
using Autofac.Core;
using Avtec.DevMorningFix.Dora.StrategyPatternDemo;
using System.ComponentModel.Composition;
using System.Reflection;
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
            builder.RegisterType<SgnirtsSdrawkcabBehavior>().AsSelf();
            builder.RegisterType<MeepMeep>().AsSelf();
            builder.RegisterType<MorseCodeTransmitBehavior>().AsSelf();
            builder.RegisterType<DefaultTransmitBehavior>().As<ITransmitBehavior>();
            builder.RegisterType<AnalogRadio>().As<Radio>();
            builder.RegisterType<ConventionalRadio>().As<Radio>();
            builder.RegisterType<PeaseRadio>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ITransmitBehavior),
                    (pi, ctx) => ctx.Resolve<MeepMeep>())).As<Radio>();
            
            builder.RegisterType<IrmoRadio>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ITransmitBehavior),
                    (pi, ctx) => ctx.Resolve<RGBTransmitBehavior>())).As<Radio>();

            builder.RegisterType<OruamKcinRadio>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ITransmitBehavior),
                    (pi, ctx) => ctx.Resolve<SgnirtsSdrawkcabBehavior>())).As<Radio>();

            builder.RegisterType<RussianRadio>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ITransmitBehavior),
                    (pi, ctx) => ctx.Resolve<MorseCodeTransmitBehavior>())).As<Radio>();
            builder.RegisterType<BrokenLspRadio>().As<Radio>();
            builder.RegisterType<MoscowRadio>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ITransmitBehavior),
                    (pi, ctx) => ctx.Resolve<DotTransmitBehavior>())).As<Radio>();
        }
    }
}