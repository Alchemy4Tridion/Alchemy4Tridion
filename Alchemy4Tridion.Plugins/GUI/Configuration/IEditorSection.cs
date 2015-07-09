using System.ComponentModel.Composition;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Interface for an editor configuration section that will be automatically merged with the main editor config.
    /// </summary>
    [InheritedExport]
    public interface IEditorSection
    {
        /// <summary>
        /// Gets the plugin that this config section is a part of. Should be set automatically by core.
        /// </summary>
        IAlchemyPlugin Plugin
        {
            get;
            set;
        }
    }
}