using Dalamud.NetStandardUpgrade.Interop;
using SharedMemory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Dalamud.NetStandardUpgrade
{
    static class Program
    {
        static string UpgradedPluginPath { get => Path.Combine(Environment.CurrentDirectory, "upgradedPlugins"); }
        
        static readonly Type interfaceType = typeof(IDalamudCorePlugin);
        static List<IDalamudCorePlugin> plugins;

        static void Main(string[] _)
        {
            plugins = new List<IDalamudCorePlugin>();
            foreach (string dll in Directory.GetFiles(UpgradedPluginPath))
            {
                var assembly = Assembly.LoadFile(dll);
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsInterface || type.IsAbstract)
                        continue;
                    if (type.GetInterface(interfaceType.FullName) != null) {
                        IDalamudCorePlugin plugin;
                        try
                        {
                            plugin = (IDalamudCorePlugin)Activator.CreateInstance(type);
                        }
                        catch
                        {
                            continue;
                        }
                        var dalamudInterface = new DalamudInteropPluginInterface();
                        plugin.Initialize(dalamudInterface);
                        plugins.Add(plugin);
                    }
                }
            }

            InteropManager.Memory = new BufferReadWrite("DalamudNetStandardUpgrade", InteropManager.RequestBufferSize * InteropManager.BuffersPerPlugin * plugins.Count);
        }
    }
}
