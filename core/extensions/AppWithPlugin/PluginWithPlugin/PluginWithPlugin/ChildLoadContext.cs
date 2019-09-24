using System;
using System.Reflection;
using System.Runtime.Loader;

namespace PluginWithPlugin
{
    class ChildLoadContext : AssemblyLoadContext
    {
        private AssemblyLoadContext _parent;
        private AssemblyDependencyResolver _resolver;

        public ChildLoadContext(AssemblyLoadContext parent, string pluginPath)
        {
            _parent = parent;
            _resolver = new AssemblyDependencyResolver(pluginPath);
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            string assemblyPath = _resolver.ResolveAssemblyToPath(assemblyName);
            if (assemblyPath != null)
            {
                return LoadFromAssemblyPath(assemblyPath);
            }

            return _parent.LoadFromAssemblyName(assemblyName);
        }

        protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
        {
            string libraryPath = _resolver.ResolveUnmanagedDllToPath(unmanagedDllName);
            if (libraryPath != null)
            {
                return LoadUnmanagedDllFromPath(libraryPath);
            }

            return IntPtr.Zero;
        }
    }
}
