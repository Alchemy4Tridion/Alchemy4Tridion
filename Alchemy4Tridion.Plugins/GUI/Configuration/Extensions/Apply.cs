using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration.Extensions
{
    /// <summary>
    /// Represents the apply section of extension configuration sections.
    /// </summary>
    public class Apply
    {
        /// <summary>
        /// The views that this extension is applied to.
        /// </summary>
        private List<ApplyView> _views = new List<ApplyView>();

        /// <summary>
        /// Gets the views that this extesnion should be applied to.
        /// </summary>
        public List<ApplyView> Views
        {
            get
            {
                return _views;
            }
        }

        /// <summary>
        /// Adds the extension to a given view.
        /// </summary>
        /// <param name="viewName">The name of the view to add to.</param>
        /// <returns>This Apply instance</returns>
        public Apply ToView(string viewName)
        {
            _views.Add(new ApplyView
            {
                Name = viewName
            });

            return this;
        }

        /// <summary>
        /// Adds the extension to a given view.
        /// </summary>
        /// <param name="viewName">The name of the view to add to.</param>
        /// <param name="controlId">The identifier of the control to add to.</param>
        /// <returns>This Apply instance</returns>
        public Apply ToView(string viewName, string controlId = null)
        {
            _views.Add(new ApplyView
            {
                Name = viewName,
                ControlId = controlId
            });

            return this;
        }
    }
}
