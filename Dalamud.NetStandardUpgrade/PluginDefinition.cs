﻿namespace Dalamud.NetStandardUpgrade
{
    public class PluginDefinition
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string InternalName { get; set; }
        public string AssemblyVersion { get; set; }
        public string Description { get; set; }
        public string ApplicableVersion { get; set; }
        public bool IsHide { get; set; }
    }
}
