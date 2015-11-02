using System;
using System.Web.Http.Controllers;

namespace Alchemy4Tridion.Plugins.Controllers
{
    /// <summary>
    /// Interface for a utility to impersonate as a window's user.
    /// </summary>
    public interface IWindowsImpersonator
    {
        /// <summary>
        /// Impersonates the request under the impersonated windows user.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        IDisposable Impersonate(HttpActionContext context);

        /// <summary>
        /// Gets whether or not the impersonation is allowed.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        bool AllowImpersonation(HttpActionContext context);
    }
}
