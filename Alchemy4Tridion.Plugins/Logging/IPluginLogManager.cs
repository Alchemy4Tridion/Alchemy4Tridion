using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins.Logging
{
    /// <summary>
    /// Interface for a log manager that is configurable per plugin.
    /// </summary>
    public interface IPluginLogManager : ILogManager
    {
        /// <summary>
        /// Gets a logger with the Plugin as its type.
        /// </summary>
        /// <returns></returns>
        ILogger GetLogger();
    }
}
