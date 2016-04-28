using System;
using System.Xml.Serialization;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Represents an assembly that the plugin references and uses.
    /// </summary>
    public class PluginReference
    {
        /// <summary>
        /// The assembly version for comaparison.
        /// </summary>
        private Version assemblyVersion;

        /// <summary>
        /// Gets the Version of based off of the string (for comparisons).
        /// </summary>
        [XmlIgnore]
        public Version AssemblyVersion
        {
            get
            {
                if (this.assemblyVersion == null)
                {
                    this.assemblyVersion = new Version(Version);
                }
                return this.assemblyVersion;
            }
        }

        /// <summary>
        /// Gets or sets the filename of the assembly.
        /// </summary>
        [XmlAttribute("file")]
        public string Filename { get; set; }

        /// <summary>
        /// Gets the full filepath to where the reference is located.
        /// </summary>
        [XmlIgnore]
        public string Location { get; internal set; }

        /// <summary>
        /// Gets or sets the aseembly simple name of the reference.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the version number of the reference.
        /// </summary>
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}
