using System;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Interface that represents plugin info.
    /// </summary>
    public interface IPluginInfo
    {
        /// <summary>
        /// Gets the name of the author.
        /// </summary>
        string Author { get; }

        /// <summary>
        /// Gets the time that this plugin was built.
        /// </summary>
        DateTime BuildTime { get; }

        /// <summary>
        /// Gets the description of the plugin.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the A4T plugin framework version that the plugin was built with.
        /// </summary>
        string FrameworkVersion { get; }

        /// <summary>
        /// Gets the unique identifier of this plugin used in the web store.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets the unique plugin's name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the references that the plugin contains.
        /// </summary>
        List<PluginReference> References { get; }

        /// <summary>
        /// Gets the summary of the plugin.
        /// </summary>
        string Summary { get; }

        /// <summary>
        /// Gets the version number of the plugin.
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Gets the unique version identifier of the plugin used by the web store.
        /// </summary>
        string VersionId { get; }
    }
}
