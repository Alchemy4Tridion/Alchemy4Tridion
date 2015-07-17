using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Extensions
{
    /// <summary>
    /// Abstract class for extension config section within the <editorextensions /> element.
    /// </summary>
    public abstract class ExtensionConfigBase : IEditorSection
    {
        /// <summary>
        /// Gets the name of the extension.
        /// </summary>
        private string name;

        /// <summary>
        /// Gets or sets the apply instance that allows the extension to be applied to particular views, controllers, or containers.
        /// </summary>
        public Apply Apply
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets required identifier to assign to this extension. This value typically becomes
        /// the id of the html element created for the extension.
        /// </summary>
        public string AssignId
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
        /// Gets or sets whether this extension is disabled.
        /// </summary>
        public bool Disabled
        {
            get;
            set;
        }

        /// <summary>
        /// The editor extension target of this extension.
        /// </summary>
        private string _editorExtensionTarget = "CME";

        /// <summary>
        /// Gets or sets the editorextension target of this extension.
        /// </summary>
        public string EditorExtensionTarget
        {
            get
            {
                return _editorExtensionTarget;
            }
            set
            {
                _editorExtensionTarget = value;
            }
        }

        /// <summary>
        /// Gets or sets group identifier that this extension should be assigned to.
        /// </summary>
        public string GroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the target to insert this extension before.  Leave blank to insert at the end.
        /// </summary>
        public string InsertBefore
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the target group to insert this extension before.
        /// </summary>
        public string InsertBeforeGroup
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets the required name of the extension. This often becomes the label of
        /// the extension depending on its type.
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
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the identifier of the page to assign the extension to.
        /// </summary>
        public string PageId
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
        public ExtensionConfigBase()
        {
            Apply = new Apply();
            Dependencies = new Dependencies();
        }
    }
}
