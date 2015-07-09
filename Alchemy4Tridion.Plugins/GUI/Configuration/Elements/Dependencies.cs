using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Elements
{
    /// <summary>
    /// Represents a dependencies element within the editor configuration.
    /// </summary>
    public class Dependencies
    {
        /// <summary>
        /// The dependencies that have been added.
        /// </summary>
        private List<Dependency> _dependencies = new List<Dependency>();

        /// <summary>
        /// Gets the total number of dependencies contained.
        /// </summary>
        public int Count
        {
            get
            {
                return _dependencies.Count;
            }
        }

        /// <summary>
        /// Gets the read only list of dependencies.
        /// </summary>
        public IEnumerable<Dependency> Items
        { 
            get
            {
                return _dependencies.AsReadOnly();
            }
        }

        /// <summary>
        /// Adds one or more dependencies.
        /// </summary>
        /// <param name="files">The dependencies to add.</param>
        /// <returns></returns>
        public Dependencies Add(params string[] dependencies)
        {
            for (int i = 0; i < dependencies.Length; i++)
            {
                Add(dependencies[i]);
            }

            return this;
        }

        /// <summary>
        /// Adds a dependency.
        /// </summary>
        /// <param name="dependency"></param>
        /// <returns></returns>
        public Dependencies Add(string dependency)
        {
            _dependencies.Add(new Dependency { Value = dependency });

            return this;
        }

        /// <summary>
        /// Adds a dependency, where the type is a type reference to the dependency to add.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Dependencies Add<T>() where T: ResourceGroup
        {
            _dependencies.Add(new Dependency { DependencyType = typeof(T) });

            return this;
        }

        /// <summary>
        /// Adds the core Alchemy resource group as a dependency.
        /// </summary>
        /// <returns></returns>
        public Dependencies AddAlchemyCore()
        {
            Add("Alchemy.Resources.Core");

            return this;
        }

        /// <summary>
        /// Adds the angular javascript library as a dependency.  The angular library has a dependency on Alchemy Core (automatically added if you add this).
        /// </summary>
        /// <returns></returns>
        public Dependencies AddLibAngular()
        {
            Add("Alchemy.Resources.Libs.Angular");

            return this;
        }

        /// <summary>
        /// Adds the doT JavaScript Templating library as a dependency.  The doT library has a dependency on Alchemy Core (automatically added if you add this).
        /// </summary>
        /// <returns></returns>
        public Dependencies AddLibraryDot()
        {
            Add("Alchemy.Resources.Libs.doT");

            return this;
        }

        /// <summary>
        /// Adds the jquery library as a dependency.  The jQuery library has a dependency on Alchemy Core (no need to add that if adding this).
        /// </summary>
        /// <returns></returns>
        public Dependencies AddLibraryJQuery()
        {
            Add("Alchemy.Resources.Libs.JQuery");

            return this;
        }

        /// <summary>
        /// Adds the qwest library as a dependency. The jQuery library has a dependency on Alchemy Core (no need to add that if you are adding this).
        /// </summary>
        /// <returns></returns>
        public Dependencies AddLibraryQwest()
        {
            Add("Alchemy.Resources.Libs.Qwest");

            return this;
        }

        /// <summary>
        /// Adds the ZeroClipboard library as a dependency.  The ZeroClipboard library has a dependency on Alchemy Core (no need to add that if adding this).
        /// </summary>
        /// <returns></returns>
        public Dependencies AddLibraryZeroClipboard()
        {
            Add("Alchemy.Resources.Libs.ZeroClipboard");

            return this;
        }
    }
}
