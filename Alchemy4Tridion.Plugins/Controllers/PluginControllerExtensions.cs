using System;
using System.Collections.Generic;
using System.Linq;

namespace Alchemy4Tridion.Plugins.Controllers
{
    /// <summary>
    /// Extenion methods for working with WebAPI Controllers specific for Alchemy.
    /// </summary>
    public static class PluginControllerExtensions
    {
        /// <summary>
        /// Gets all of the Alchemy service webapi controller types stored in the plugin.
        /// </summary>
        /// <param name="plugin">The plugin to get the types for.</param>
        /// <returns>A collection of web api types.</returns>
        public static IEnumerable<Type> GetApiControllerTypes(this IAlchemyPlugin plugin)
        {
            return plugin.GetType()
                .Assembly
                .ExportedTypes
                .Where(type => typeof(IAlchemyApiController)
                    .IsAssignableFrom(type));
        }
    }
}
