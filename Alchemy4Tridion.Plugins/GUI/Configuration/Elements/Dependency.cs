using System;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Elements
{
    /// <summary>
    /// Represents a dependency within a dependencies element. Either the Value OR the DependencyType should be filled out.
    /// </summary>
    public class Dependency
    {
        /// <summary>
        /// Gets or sets the dependency type reference.
        /// </summary>
        public Type DependencyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the dependency.
        /// </summary>
        public string Value
        {
            get;
            set;
        }
    }
}
