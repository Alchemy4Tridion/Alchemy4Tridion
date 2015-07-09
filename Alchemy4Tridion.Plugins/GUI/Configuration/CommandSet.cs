using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using System;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents a command set within the editor's configuration.
    /// </summary>
    public class CommandSet : IEditorSection
    {
        /// <summary>
        /// The unique identifier of this command set.
        /// </summary>
        private string name;

        /// <summary>
        /// The list of commands within this command set.
        /// </summary>
        private List<CommandSetCommand> _commands = new List<CommandSetCommand>();

        /// <summary>
        /// Gets the unique short identifier of the commandset.
        /// </summary>
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    this.name = GetType().Name;
                }
                return this.name;
            }
        }
        /// <summary>
        /// The Alchemy plugin
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the full unique identifier of this command set (ie Alchemy.Plugins.PluginName.Commands.SetName).
        /// </summary>
        public string FullName
        {
            get
            {
                return string.Format("Alchemy.Plugins.{0}.Commands.{1}", Plugin.Name, Name);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CommandSet()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">the optional unique identifier of the command set (defaults to the Type name)</param>
        public CommandSet(string id)
        {
            this.name = id;
        }

        /// <summary>
        /// Adds a command to the command set.
        /// </summary>
        /// <param name="commandName">The name of the command.</param>
        /// <param name="commandImplementation">The optional implementation, leave null to use the default namespace for implementations.</param>
        /// <returns></returns>
        public CommandSet AddCommand(string commandName, string commandImplementation = null)
        {
            _commands.Add(new CommandSetCommand { Name = commandName, Implementation = commandImplementation });

            return this;
        }

        /// <summary>
        /// Gets the commands that this command set contains.
        /// </summary>
        /// <returns>A read only list of commands.</returns>
        public IEnumerable<CommandSetCommand> Commands()
        {
            return _commands.AsReadOnly();
        }
    }
}
