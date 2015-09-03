using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using System;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents a context menu declaration (items within the &lt;contextmenus /&gt;).  This is used to declare new
    /// context menus that can be used in custom views and not to extend existing context menus (see ContextMenuExtension
    /// for ability to extend exisiting).
    /// </summary>
    public class ContextMenuDeclaration : IEditorSection
    {
        /// <summary>
        /// The context menu items contained within this extension.
        /// </summary>
        private List<ContextMenuItem> items = new List<ContextMenuItem>();

        /// <summary>
        /// The uniquely defined name of the context menu.
        /// </summary>
        private string name;

        /// <summary>
        /// Gets the read only collection of context menu items that are contained within this extension.
        /// </summary>
        public IEnumerable<ContextMenuItem> Items
        {
            get
            {
                return items.AsReadOnly();
            }
        }

        /// <summary>
        /// Gets or sets the defined name of the context menu. This should be a unique name to recognize it from other
        /// context menus.
        /// </summary>
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    this.name =  (Plugin != null ? Plugin.Name.Replace(" ", "_") : String.Empty) + GetType().Name;
                }
                return this.name;
            }
        }

        /// <summary>
        /// Gets or sets the plugin that this context menu belongs to.
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get;
            set;
        }

        /// <summary>
        /// Adds a context menu item to the context menu.
        /// </summary>
        /// <param name="id">The unique identifier of this menu item. Becomes the id attribute of the html element.</param>
        /// <param name="name">The name to display for this menu item.</param>
        /// <param name="command">The command to execute when this menu item is clicked.</param>
        public void AddItem(string id, string name, string command)
        {
            items.Add(new ContextMenuItem { Id = id, Name = name, Command = command });
        }

        /// <summary>
        /// Adds a separator to the context menu.
        /// </summary>
        /// <param name="id">The unique identifier of this separator.  Becomes the id attribute of the html element.</param>
        public void AddSeparator(string id)
        {
            items.Add(new ContextMenuItem { Id = id, Type = "separator" });
        }

        /// <summary>
        /// Adds a submenu section to the context menu. The submenu can contain its own items, separators, and submenus.
        /// </summary>
        /// <param name="id">The unique identifier of this submenu. Becomes the id attribute of the html element.</param>
        /// <param name="name">The name to display for this submenu item.</param>
        /// <returns></returns>
        public ContextMenuItem AddSubMenu(string id, string name)
        {
            ContextMenuItem submenu = new ContextMenuItem { Id = id, Name = name, Type = "submenu" };
            items.Add(submenu);

            return submenu;
        }

        /// <summary>
        /// Creates a new context menu declaration using the optional unique defined name for the context menu. If
        /// no name is provided, will use an auto generated name based off of the plugin's name plus the type.
        /// </summary>
        /// <param name="definedName"></param>
        public ContextMenuDeclaration(string definedName = null)
        {
            this.name = definedName;
        }
    }
}
