using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents a command extension extension type.
    /// </summary>
    public abstract class CommandExtension : IEditorSection
    {
        /// <summary>
        /// The target extension.
        /// </summary>
        private string editorExtensionTarget = "CME";

        /// <summary>
        /// Gets or sets the editorextension target of this extension.
        /// </summary>
        public string EditorExtensionTarget
        {
            get
            {
                return this.editorExtensionTarget;
            }
            set
            {
                this.editorExtensionTarget = value;
            }
        }


        /// <summary>
        /// The name of the command that extends the existing command.
        /// </summary>
        public string ExtendingCommand
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of dependencies that this group depends on.
        /// </summary>
        public Dependencies Dependencies
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the name of the existing command that you are extending. ie "Delete".
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The plugin that this config extension belongs to.  Set automatically by the core framework.
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CommandExtension()
        {
            Dependencies = new Dependencies();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the existing command that's being extended.</param>
        /// <param name="extendingCommand">The name of the command to extend</param>
        public CommandExtension(string name, string extendingCommand)
            : this()
        {
            Name = name;
            ExtendingCommand = extendingCommand;
        }
    }
}
