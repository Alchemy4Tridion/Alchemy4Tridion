using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Alchemy4Tridion.Plugins.Controllers
{
    /// <summary>
    /// Adding this attribute to a controller's action will attempt to impersonate as a windows user (vs running
    /// as what's configured in IIS).  Windows Impersonation must be configured and the Tridion user must have
    /// been granted permission in the Alchemy configuration to use this feature.  If the user does not
    /// have permission, a popup should appear allowing the user to provide credentials to use (unless this
    /// feature has been disabled completely).
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class RequiresWindowsImpersonationAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Gets the service that controls the impersonation
        /// </summary>
        public IWindowsImpersonator WindowsImpersonator
        {
            get;
            set;
        }

        /// <summary>
        /// On action executing, checks if the windows impersonation is configured and if the user has 
        /// permission to use the impersonation. If so, will impersonate and perform the rest of the action
        /// under the context of the windows impersonated user.  If not, will return an exception in the
        /// response.
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (WindowsImpersonator.AllowImpersonation(actionContext))
            {
                actionContext.Request.RegisterForDispose(WindowsImpersonator.Impersonate(actionContext));
                base.OnActionExecuting(actionContext);
            }
            else
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "This action requires permissions to impersonate as a windows administrator. You either do not have permission or this feature is disabled.");
            }
        }
    }
}
