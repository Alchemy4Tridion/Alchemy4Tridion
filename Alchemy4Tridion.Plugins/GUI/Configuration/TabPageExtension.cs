using Alchemy4Tridion.Plugins.GUI.Configuration.Extensions;
using System;
using System.IO;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents a Tab Page extension configuration piece. ie: <ext:tabpages />
    /// </summary>
    public class TabPageExtension : ExtensionConfigBase
    {
        /// <summary>
        /// The ascx user control that represents the page.
        /// </summary>
        private string control;

        /// <summary>
        /// Gets or sets the ASCX user control file that presents the page. Required for tab pages.
        /// </summary>
        public string Control
        {
            get
            {
                if (!this.control.Contains("/"))
                {
                    return String.Format("~/Plugins/{0}/assets/controls/{1}", Plugin.Name, control);
                }
                return "~" + control;
            }
            set
            {
                control = value.Replace("~", String.Empty);
                if (!control.ToLower().EndsWith(".ascx"))
                {
                    control += ".ascx";
                }
            }
        }

        /// <summary>
        /// Gets or sets the page's definition of the client side name.
        /// </summary>
        public string PageType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether or not the tab page is rendered in block.
        /// </summary>
        public Nullable<bool> RenderInBlock
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the width property of the Page. It doesn't affect the actual width of the Page.
        /// </summary>
        public string Width
        {
            get;
            set;
        }
    }
}