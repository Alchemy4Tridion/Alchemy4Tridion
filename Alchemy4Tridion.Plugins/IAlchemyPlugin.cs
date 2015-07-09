using Alchemy4Tridion.Plugins.GUI.Configuration;
using Alchemy4Tridion.Plugins.Info;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Interface for an alchemy plugin that will automatically get exported.
    /// </summary>
    [InheritedExport(typeof(IAlchemyPlugin))]
    public interface IAlchemyPlugin
    {
        /// <summary>
        /// Gets the Alchemy application url to the plugin. (ie '/Alchemy/Plugins/PluginName/').
        /// </summary>
        /// <remarks>
        /// The AppUrl is used when calling to alchemy services directly. For GUI related items the EditorUrl should be used.
        /// </remarks>
        string AppUrl
        {
            get;
        }

        /// <summary>
        /// Gets the Tridion Editor url to the plugin. (ie '/WebUI/Editors/Alchemy/Plugins/PluginName/').
        /// </summary>
        string EditorUrl
        {
            get;
        }

        /// <summary>
        /// Gets the GUI editor sections that are contained in this plugin. (Set by Core framework.)
        /// </summary>
        IEnumerable<IEditorSection> EditorSections
        {
            get;
        }

        /// <summary>
        /// Gets the plugin information.
        /// </summary>
        IPluginInfo PluginInfo
        {
            get;
        }

        /// <summary>
        /// Gets the url to the plugin's icon.
        /// </summary>
        string IconUrl
        {
            get;
        }

        /// <summary>
        /// Gets the unique web store identifier of the plugin. Returns null if there is 
        /// no id (plugin was never uploaded).
        /// </summary>
        string Id
        {
            get;
        }

        /// <summary>
        /// Gets the unique name of the plugin.
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Gets the absolute path to the plugin including the plugin folder. ie (C:\Tridion\Alchemy\Plugins\PluginName\)
        /// </summary>
        string PluginPath
        {
            get;
        }

        /// <summary>
        /// Gets the services that are used by this plugin.
        /// </summary>
        IPluginServiceLocator Services
        {
            get;
        }

        /// <summary>
        /// Gets the plugin settings. Note that this property is not cached and every time it is accessed
        /// a new PluginSettings instance is created.
        /// </summary>
        IPluginSettings Settings
        {
            get;
        }

        /// <summary>
        /// Gets the summary of the plugin.
        /// </summary>
        string Summary
        {
            get;
        }

        /// <summary>
        /// Configures the services that will be used by this plugin.
        /// </summary>
        /// <param name="services">The default services that are used by this plugin.</param>
        void Configure(IPluginServiceLocator services);

        /// <summary>
        /// Maps a url relative to the editor url.
        /// </summary>
        /// <param name="url">The url to map</param>
        /// <returns>A url like '/WebUI/Editors/Alchemy/Plugins/PluginName/Mapped/Portion/'</returns>
        string MapEditorUrl(string url);

        /// <summary>
        /// Maps a path based on the plugin's folder path.
        /// </summary>
        /// <param name="path">The path relative to the plugin's folder path.</param>
        /// <returns></returns>
        string MapPath(string path);
    }
}
