using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using Alchemy4Tridion.Plugins.GUI.Configuration.Extensions;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents a context menu configuration piece within the editorextensions element.
    /// </summary>
    public class ContextMenuExtension : ExtensionConfigBase
    {
        /// <summary>
        /// The context menu items contained within this extension.
        /// </summary>
        private List<ContextMenuItem> _items = new List<ContextMenuItem>();

        /// <summary>
        /// Gets the read only collection of context menu items that are contained within this extension.
        /// </summary>
        public IEnumerable<ContextMenuItem> Items
        {
            get
            {
                return _items.AsReadOnly();
            }
        }

        /// <summary>
        /// Adds a context menu item to the context menu.
        /// </summary>
        /// <param name="id">The unique identifier of this menu item. Becomes the id attribute of the html element.</param>
        /// <param name="name">The name to display for this menu item.</param>
        /// <param name="command">The command to execute when this menu item is clicked.</param>
        public void AddItem(string id, string name, string command)
        {
            _items.Add(new ContextMenuItem { Id = id, Name = name, Command = command });
        }

        /// <summary>
        /// Adds a separator to the context menu.
        /// </summary>
        /// <param name="id">The unique identifier of this separator.  Becomes the id attribute of the html element.</param>
        public void AddSeparator(string id)
        {
            _items.Add(new ContextMenuItem { Id = id, Type = "separator" });
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
            _items.Add(submenu);
            
            return submenu;
        }
    }
}

