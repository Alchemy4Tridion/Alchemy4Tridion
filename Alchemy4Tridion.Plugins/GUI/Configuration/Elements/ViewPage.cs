using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Elements
{
    public class ViewPage
    {
        internal Type ContextMenuType
        {
            get;
            set;
        }

        public string Filename
        {
            get;
            set;
        }

        public string Inherits
        {
            get;
            set;
        }

        public ResourceGroup ResourceGroup
        {
            get;
            private set;
        }

        public ViewPage(ResourceGroup group)
        {
            ResourceGroup = group;
        }

        public ViewPage SetContextMenu<TCMenuDeclaration>() where TCMenuDeclaration : ContextMenuDeclaration
        {
            this.ContextMenuType = typeof(TCMenuDeclaration);

            return this;
        }
    }
}
