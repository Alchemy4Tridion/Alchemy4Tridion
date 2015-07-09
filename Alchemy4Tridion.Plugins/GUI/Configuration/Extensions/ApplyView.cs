
namespace Alchemy4Tridion.Plugins.GUI.Configuration.Extensions
{
    /// <summary>
    /// Represents an applied to view in the configuration.
    /// </summary>
    public class ApplyView
    {
        /// <summary>
        /// Gets or sets the control id the extension is applied to.
        /// </summary>
        public string ControlId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the view to apply the extension to.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}
