using System;
using System.Xml.Serialization;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Represents the data from the info.xml at root of package.
    /// </summary>
    [XmlRoot(ElementName = "plugin", Namespace = "http://www.alchemywebstore.com/")]
    public class PluginInfo : IPluginInfo
    {
        /// <summary>
        /// Gets or sets the name of the author.
        /// </summary>
        [XmlElement("author")]
        public string Author
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the time that this plugin was built.
        /// </summary>
        [XmlElement("buildTime")]
        public DateTime BuildTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description of the plugin.
        /// </summary>
        [XmlElement("description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the Alchemy4Tridion Plugin framework version that this plugin was built with.
        /// </summary>
        [XmlElement("frameworkVersion")]
        public string FrameworkVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the unique identifier of this plugin used in the web store.
        /// </summary>
        [XmlElement("id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the unique plugin's name.
        /// </summary>
        [XmlElement("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description of the plugin.
        /// </summary>
        [XmlElement("summary")]
        public string Summary
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version number of the plugin.
        /// </summary>
        [XmlElement("version")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the unique version identifier of the plugin used by the web store.
        /// </summary>
        [XmlElement("versionId")]
        public string VersionId
        {
            get;
            set;
        }
    }
}
