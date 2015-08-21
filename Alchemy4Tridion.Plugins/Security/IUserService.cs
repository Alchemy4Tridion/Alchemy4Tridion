using Alchemy4Tridion.Plugins.Clients;
using System.Collections;
using Tridion.ContentManager.CoreService.Client;

namespace Alchemy4Tridion.Plugins.Security
{
    /// <summary>
    /// Interface for getting information on the currently logged in Tridion user's session (the user actually logged
    /// into the UI and not what the client may be impersonated as).
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Gets a core service user data instance representing the currently logged in user. This object
        /// is cached so that subsequent calls to GetUser will not fetch from the core services (unless the
        /// reload parameter is set to true).
        /// </summary>
        /// <param name="reload">Whether or not to get the user directly from core services or use the cached object if available.</param>
        /// <returns>The core service user data.</returns>
        UserData GetData(bool reload = false);

        /// <summary>
        /// Gets the current logged in user's username (does not use core service).
        /// </summary>
        /// <returns>The username of the user, ie "DOMAIN\MyName".</returns>
        string GetName();

        /// <summary>
        /// Gets whether or not the currently logged in user is a Tridion system administrator (uses core service).
        /// </summary>
        /// <returns></returns>
        bool IsSystemAdministrator();
    }
}
