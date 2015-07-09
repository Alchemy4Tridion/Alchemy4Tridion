using System;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Elements
{
    /// <summary>
    /// Represents a command within a command set.
    /// </summary>
    public class CommandSetCommand
    {

        /// <summary>
        /// Gets or sets the JavaScript command that this implements.
        /// </summary>
        public string Implementation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the command.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}
