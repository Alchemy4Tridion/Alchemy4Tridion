using System;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Elements
{
    /// <summary>
    /// Represents an insertafter value within an extension of an extensiongroup.
    /// </summary>
    public class ExtensionGroupInsertAfter
    {
        /// <summary>
        /// Gets or sets the string value of insert after.
        /// </summary>
        public string InsertAfter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type reference of insert after
        /// </summary>
        public Type Reference
        {
            get;
            set;
        }
    }
}