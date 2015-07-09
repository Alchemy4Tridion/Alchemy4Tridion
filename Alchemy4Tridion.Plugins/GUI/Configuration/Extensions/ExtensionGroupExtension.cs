using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Extensions
{
    /// <summary>
    /// Represents an extension within an extension group.
    /// </summary>
    public class ExtensionGroupExtension
    {
        /// <summary>
        /// Gets or sets the specified group name(s) to be inserted after the group being extended.
        /// </summary>
        public List<ExtensionGroupInsertAfter> InsertAfter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the target resource group name that this extension is targeting (the existing group that's being extended).
        /// </summary>
        public string Target
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ExtensionGroupExtension()
        {
            InsertAfter = new List<ExtensionGroupInsertAfter>();
        }
    }
}