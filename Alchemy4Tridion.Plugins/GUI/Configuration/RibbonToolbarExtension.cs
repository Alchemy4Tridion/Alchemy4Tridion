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
        /// Gets or sets the name of the JavaScript command to be executed.
        /// </summary>
        public string Command
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the filename of the group user control, ie 'MyRibbnGroup.ascx'.  Only the 
        /// filename is needed if using a default Alchemy plugin location for controls.
        /// <note type="note">
        /// When using this property, the attributes and properties set in the user control's markup
        /// override other properties set here like Command, Title, and IsSmallButton.
        /// </note>
        /// </summary>
        public string Group
        {
            get
            {
                if (this.group == null)
                {
                    return null;
                }
                if (!this.group.Contains("/"))
                {
                    return string.Format("~/Plugins/{0}/assets/controls/{1}", Plugin.Name, this.group);
                }

                return "~" + this.group;
            }
            set
            {
                this.group = value.Replace("~", String.Empty);
                if (!this.group.ToLower().EndsWith(".ascx"))
                {
                    this.group += ".ascx";
                }
            }
        }

        /// <summary>
        /// Gets whether or not to apply the ribbon toolbar button as a small button.
        /// </summary>
        public bool IsSmallButton
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Title of ribbon toolbar button and becomes the tooltip label.
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public RibbonToolbarExtension() : base()
        {
            
        }
    }
}
