using PluginBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace PluginWithPlugin
{
    public class PluginWithPluginCommand : ICommand
    {
        public string Name { get => "pinp"; }
        public string Description { get => "Plugin with plugin."; }

        public int Execute()
        {
            string[] pluginPaths = new string[]
            {
                @"ChildPlugin\bin\Debug\netcoreapp3.0\ChildPlugin.dll",
            };

            IEnumerable<ChildBase.ChildBase> childPlugins = pluginPaths.Select(pluginPath =>
            {
                Assembly pluginAssembly = LoadPlugin(pluginPath);
                return CreateChild(pluginAssembly);
            }).ToList();

            foreach (ChildBase.ChildBase child in childPlugins)
            {
                Console.WriteLine($"-- PluginWithPlugin -- {child.GetType().Name} --");
                Console.WriteLine($"-- PluginWithPlugin {child.GetDescription()}");
                Console.WriteLine();
            }

            return 0;
        }

        static Assembly LoadPlugin(string relativePath)
        {
            // Navigate up to the solution root
            string root = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(PluginWithPluginCommand).Assembly.Location)))))));

            string pluginLocation = Path.GetFullPath(Path.Combine(root, relativePath.Replace('\\', Path.DirectorySeparatorChar)));
            Console.WriteLine($"Loading child plugin from: {pluginLocation}");
            ChildLoadContext loadContext = new ChildLoadContext(
                AssemblyLoadContext.GetLoadContext(typeof(PluginWithPluginCommand).Assembly),
                pluginLocation);
            return loadContext.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(pluginLocation)));
        }

        static ChildBase.ChildBase CreateChild(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(ChildBase.ChildBase).IsAssignableFrom(type))
                {
                    ChildBase.ChildBase result = Activator.CreateInstance(type) as ChildBase.ChildBase;
                    if (result != null)
                    {
                        return result;
                    }
                }
            }

            return null;
        }
    }
}
