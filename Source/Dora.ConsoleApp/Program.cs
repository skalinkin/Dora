using System;
using Avtec.DevMorningFix.Dora.Autofac;

namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            var applicationConstructor = new Bootstrapper();
            applicationConstructor.BuildComposition();
            var start = applicationConstructor.GetStart();
            start.Execute(args);
        }

        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}