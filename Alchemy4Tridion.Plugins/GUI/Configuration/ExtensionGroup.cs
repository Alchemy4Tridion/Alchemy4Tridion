using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using Alchemy4Tridion.Plugins.GUI.Configuration.Extensions;
using System;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents an ExtensionGroup within the editor config.
    /// </summary>
    public abstract class ExtensionGroup : IEditorSection
    {
        /// <summary>
        /// The name of the extension group.
        /// </summary>
        private string name;

        /// <summary>
        /// Gets or sets the extensions that this extension group extends.
        /// </summary>
        public List<ExtensionGroupExtension> Extensions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the full resource name (ie Alchemy.Plugins.PluginName.ExtensionGroups.GroupName).
        /// </summary>
        public string FullName
        {
            get
            {
                return String.Format("Alchemy.Plugins.{0}.Resources.{1}",
                    Plugin.Name,
                    String.IsNullOrEmpty(Name) ? "Group" : Name);
            }
        }
        /// <summary>
        /// Gets or sets the name of the extension group.
        /// </summary>
        public string Name
        {
            get
            {
                if (String.IsNullOrEmpty(this.name))
                {
                    this.name = this.GetType().Name;
                }
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// The plugin that this resource group belongs to.  Set automatically by core framework.
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ExtensionGroup()
        {
            Extensions = new List<ExtensionGroupExtension>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The optional name of the plugin. Defaults to the type name of the extension group class.</param>
        public ExtensionGroup(string name)
            : this()
        {
            Name = name;
        }

        /// <summary>
        /// Adds an extension to be extended by the extension group.
        /// </summary>
        /// <param name="target">The name of the resource group to be extended by this extension.</param>
        /// <param name="insertAfter">One or more group names that will be extending the target (groups will be included AFTER target is loaded).</param>
        /// <returns></returns>
        public ExtensionGroup AddExtension(string target, params string[] insertAfter)
        {
            ExtensionGroupExtension extension = new ExtensionGroupExtension();
            extension.Target = target;

            foreach (string insert in insertAfter)
            {
                extension.InsertAfter.Add(new ExtensionGroupInsertAfter
                {
                    InsertAfter = insert
                });
            }

            Extensions.Add(extension);

            return this;
        }

        /// <summary>
        /// Adds an extension to be extended by the extension group.
        /// </summary>
        /// <param name="target">The name of the resource group to be extended by this extension.</param>
        /// <param name="insertAfter">One or more group types that will be extending the target (groups will be included AFTER target is loaded).</param>
        /// <returns></returns>
        public ExtensionGroup AddExtension(string target, params Type[] insertAfter)
        {
            ExtensionGroupExtension extension = new ExtensionGroupExtension();
            extension.Target = target;

            foreach (Type insert in insertAfter)
            {
                extension.InsertAfter.Add(new ExtensionGroupInsertAfter
                {
                    Reference = insert
                });
            }

            Extensions.Add(extension);

            return this;
        }

        /// <summary>
        /// Adds an extension to be extended by the extension group.
        /// </summary>
        /// <typeparam name="T">The resource group that will be extending the target group.</typeparam>
        /// <param name="target">The name of the group being targeted.</param>
        /// <returns></returns>
        public ExtensionGroup AddExtension<T>(string target) where T : ResourceGroup
        {
            ExtensionGroupExtension extension = new ExtensionGroupExtension();
            extension.Target = target;

            extension.InsertAfter.Add(new ExtensionGroupInsertAfter
            {
                Reference = typeof(T)
            });

            Extensions.Add(extension);

            return this;
        }
    }
}