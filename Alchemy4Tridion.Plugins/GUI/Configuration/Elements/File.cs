using System;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Elements
{
    /// <summary>
    /// Represents a file within the fileset element of a resource group.
    /// </summary>
    public class File
    {
        /// <summary>
        /// Gets or sets the location of the file.
        /// </summary>
        public string Location
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type reference of this file.
        /// </summary>
        public Type Reference
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the file's type.
        /// </summary>
        public FileTypes Type
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public File()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type">The type of file</param>
        /// <param name="location">The location of the file</param>
        public File(FileTypes type, string location)
        {
            Type = type;
            Location = location;
        }
    }

    /// <summary>
    /// The types of files available.
    /// </summary>
    public enum FileTypes
    {
        /// <summary>
        /// Represents a script type.
        /// </summary>
        Script,

        /// <summary>
        /// Represents a stylesheet type.
        /// </summary>
        Style,

        /// <summary>
        /// Represents a reference type.
        /// </summary>
        Reference
    }
}
