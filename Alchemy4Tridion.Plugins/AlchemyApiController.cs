using Alchemy4Tridion.Plugins.Clients;
using Alchemy4Tridion.Plugins.Security;
using System;
using System.Diagnostics;
using System.Web.Http;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// The Alchemy WebAPI Controller. Alchemy controllers should inherit from this base class to automatically get
    /// picked up. An AlchemyRoutePrefixAttribute must also be added to the controller.
    /// </summary>
    /// <example>
    /// <code>
    /// [AlchemyRoutePrefix(typeof(MyPluginType), "Example")]
    /// public class ExampleController : AlchemyApiController
    /// {
    ///     [HttpGet]
    ///     [Route("hello")]
    ///     public string GetExample()
    ///     {
    ///         return "Hello Example";
    ///     }
    /// }
    /// </code>
    /// <para>
    /// The above would produce a route to /Alchemy/Plugins/YourPlugin/api/Example/hello, which when called
    /// would return a response containing the string "Hello Example".
    /// </para>
    /// </example>
    /// <remarks>
    /// An automatically created JavaScript proxy can be created for you that will allow you to call your
    /// controller's actions w/o including any other library.  To add this proxy to a resource group, add
    /// a call to the method <c>AddWebApiProxy();</c>.  After doing this, in your JavaScript files you'll
    /// be able to then make a call to <c>Alchemy.Plugins.YourPlugin.Api.Example.hello();</c>, which will
    /// return a promise.
    /// </remarks>
    public abstract class AlchemyApiController : ApiController, IAlchemyApiController
    {
        /// <summary>
        /// The session aware core service client.
        /// </summary>
        private AlchemySessionAwareCoreServiceClient client;

        private AlchemyClients clients;

        /// <summary>
        /// Gets or sets the session aware core service client. Will automatically create one impersonating the currently
        /// logged in user using the default end point (netTcp_2013) if not previously set. This client is dispose safe (and will automatically be
        /// disposed of by the ApiController at the end of the request if not already done so, so calling Client.Dispose() is not required).
        /// </summary>
        /// <remarks>
        /// This property is lazily loaded so no core service client is created if the property is never called. Also note that this property
        /// is used by the IUserService property.
        /// </remarks>
        [Obsolete]
        public AlchemySessionAwareCoreServiceClient Client
        {
            get
            {
                if (this.client == null)
                {
                    this.client = new AlchemySessionAwareCoreServiceClient();
                    this.client.Impersonate(User.GetName());
                }
                return this.client;
            }
            set
            {
                this.client = value;
            }
        }

        /// <summary>
        /// Gets a helper to client service contracts.
        /// </summary>
        public AlchemyClients Clients
        {
            get
            {
                if (this.clients == null)
                {
                    this.clients = new AlchemyClients(User.GetName());
                }
                return this.clients;
            }
        }

        /// <summary>
        /// Gets the plugin that is associated with this api controller (use Plugin.Services to get different
        /// services available to the context of this plugin).
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the service used to get information about the currently logged in user (user making the http request
        /// to this web service).
        /// </summary>
        public new IUserService User
        {
            get;
            internal set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public AlchemyApiController()
        {
            //var attribute = GetType().GetCustomAttributes(typeof(AlchemyRoutePrefixAttribute), true).FirstOrDefault() as AlchemyRoutePrefixAttribute;
        }

        /// <summary>
        /// Disposes any resources. This is automatically called at the end of a request.
        /// </summary>
        /// <param name="disposing"></param>
        [NonAction]
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.client != null)
                {
                    client.Dispose();
                }
                if (Clients != null)
                {
                    Clients.Dispose();
                }
            }

            base.Dispose(disposing);
        }
    }
   
}
