using System.ComponentModel.Composition;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Avtec.DevMorningFix.Dora.BusinessCases;
using Avtec.DevMorningFix.Dora.BusinessCases.Impl;
using Avtec.DevMorningFix.Dora.ConsoleApp.Demo;
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
            builder.RegisterType<ConsoleMonitorOutput>().As<IMonitorOutput>();
            builder.RegisterType<ObserverDemoPatternHandler>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(IDemoPattern),
                    (pi, ctx) => ctx.Resolve<DemoObserverPattern>())).As<DemoPatternHandler>();
            builder.RegisterType<StrategyDemoPatternHandler>().WithParameter(
                new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(IDemoPattern),
                    (pi, ctx) => ctx.Resolve<DemoStrategyPattern>())).As<DemoPatternHandler>();
        }
    }
}