using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Elements
{
    /// <summary>
    /// Represents an item in the context menu.
    /// </summary>
    public class ContextMenuItem
    {
        /// <summary>
        /// The child context menu items if any.
        /// </summary>
        private List<ContextMenuItem> _items = new List<ContextMenuItem>();

        /// <summary>
        /// Gets or sets the name of the command that this menu item calls when clicked.
        /// </summary>
        public string Command
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the read only list of child context menu items if any.
        /// </summary>
        public IEnumerable<ContextMenuItem> Items
        {
            get
            {
                return _items;
            }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the menu item.  This will become the id attribute of the html element created.
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name that is displayed for this context menu item.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of context menu item this is.
        /// </summary>
        public string Type
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
        public ContextMenuItem AddItem(string id, string name, string command)
        {
            _items.Add(new ContextMenuItem { Id = id, Name = name, Command = command });

            return this;
        }

        /// <summary>
        /// Adds a separator to the context menu.
        /// </summary>
        /// <param name="id">The unique identifier of this separator.  Becomes the id attribute of the html element.</param>
        public ContextMenuItem AddSeperator(string id)
        {
            _items.Add(new ContextMenuItem { Id = id, Type = "seperator" });

            return this;
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
