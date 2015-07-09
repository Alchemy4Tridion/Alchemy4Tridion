using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Contains extension methods for working with collections of gui extension configuration objects.
    /// </summary>
    public static class EditorExtensionMethods
    {
        /// <summary>
        /// Gets the name of a dependency.
        /// </summary>
        /// <param name="dependency">The dependency instance to get the name for.</param>
        /// <returns></returns>
        public static string GetDependencyName(this IEnumerable<IEditorSection> collection, Dependency dependency)
        {
            if (dependency.DependencyType != null)
            {
                return collection.GetReferenceName(dependency.DependencyType);
            }
            return dependency.Value;
        }

        /// <summary>
        /// Gets an instance of an editor section based on the type passed in.
        /// </summary>
        /// <param name="type">The type of the reference to get.</param>
        /// <returns>The registered reference, or null if none was found.</returns>
        public static IEditorSection GetReference(this IEnumerable<IEditorSection> collection, Type type)
        {
            return collection.Where(e => e.GetType() == type)
                .FirstOrDefault();
        }

        /// <summary>
        /// Gets an instance of an editor section based on the type passed in and casts it by the passed in generic.
        /// </summary>
        /// <typeparam name="T">A type that inherits from IEditorSection.</typeparam>
        /// <param name="type">The type of the reference to get.</param>
        /// <returns>The registered reference, or null if none was found.</returns>
        public static T GetReference<T>(this IEnumerable<IEditorSection> collection, Type type) where T : class, IEditorSection
        {
            return collection.Where(e => e.GetType() == type)
                .FirstOrDefault() as T;
        }

        /// <summary>
        /// Gets a reference's name based on its type.
        /// </summary>
        /// <param name="type">The type to get the reference for.</param>
        /// <returns>Null if no reference could be found, else the full name of the reference.</returns>
        public static string GetReferenceName(this IEnumerable<IEditorSection> collection, Type type)
        {
            var reference = collection.GetReference(type);

            if (reference == null)
            {
                return null;
            }
            
            if (reference is ResourceGroup)
            {
                return ((ResourceGroup)reference).FullName;
            }
            else if (reference is CommandSet)
            {
                return ((CommandSet)reference).FullName;
            }
            return type.Name;
        }
    }
}
