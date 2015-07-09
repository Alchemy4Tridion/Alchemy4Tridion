using Alchemy4Tridion.Plugins.GUI.Configuration.Extensions;
using System;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents a ribbon toolbar extension configuration piece.
    /// </summary>
    public class RibbonToolbarExtension :  ExtensionConfigBase
    {
        /// <summary>
        /// The filename of the group user control.
        /// </summary>
        private string group;

        /// <summary>
        /// Gets or sets the filename of the group user control, ie 'MyRibbnGroup.ascx'.  Only the filename is needed if using a default Alchemy plugin location for controls.
        /// </summary>
        public string Group
        {
            get
            {
                if (!group.Contains("/"))
                {
                    return string.Format("~/Plugins/{0}/assets/controls/{1}", Plugin.Name, group);
                }

                return "~" + group;
            }
            set
            {
                this.group = value.Replace("~", String.Empty);
                if (!group.ToLower().EndsWith(".ascx"))
                {
                    group += ".ascx";
                }
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public RibbonToolbarExtension() : base()
        {
            
        }
    }
}
