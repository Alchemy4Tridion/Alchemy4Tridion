using System;

namespace Alchemy4Tridion.Plugins.Logging
{
    /// <summary>
    /// Represents a manager for retrieving new instances of loggers.
    /// </summary>
    public interface ILogManager
    {
        /// <summary>
        /// Gets a new instance of a logger using a given logger name.
        /// </summary>
        /// <param name="loggerName">The name of the logger</param>
        /// <returns></returns>
        ILogger GetLogger(string loggerName);

        /// <summary>
        /// Gets a new instnace of a logger using the type's name as 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        ILogger GetLogger(Type type);
    }
}
