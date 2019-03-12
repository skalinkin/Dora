using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Autofac;
using Autofac.Core;

namespace Avtec.DevMorningFix.Dora.Autofac
{
    public class Bootstrapper
    {
        private CompositionContainer _compositionContainer;
        private IContainer _container;

        [ImportMany(typeof(IModule))] private IEnumerable<IModule> Modules { get; set; }

        public void BuildComposition()
        {
            Debug.Print("Starting build the composition.");
            var catalog = new AggregateCatalog();
            var entryAssembly = Assembly.GetEntryAssembly();
            var assemblyCatalog = new AssemblyCatalog(entryAssembly);
            catalog.Catalogs.Add(assemblyCatalog);
            Debug.Print($"Added assebly composition catalog for assembly: {entryAssembly.Location}");
            var location = Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);
            var directoryCatalog = new DirectoryCatalog(path);
            catalog.Catalogs.Add(directoryCatalog);
            Debug.Print($"Added directory composition catalog for path: {path}");
            _compositionContainer = new CompositionContainer(catalog);
            _compositionContainer.ComposeParts(this);
            var builder = new ContainerBuilder();
            foreach (var module in Modules)
            {
                Debug.Print($"Registering module ${module.GetType().Name}");
                builder.RegisterModule(module);
            }

            _container = builder.Build();
            Debug.Print("Container has been built");
        }

        public IStart GetStart()
        {
            var start = _container.Resolve<IStart>();
            return start;
        }
    }
}