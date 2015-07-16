using System;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Custom route prefix for Alchemy WebAPI controllers to supply service names.  Service names
    /// are used by both the js proxy and the generated url's to your controller's actions.  This is optional,
    /// and if not supplied then the action's routes and js proxies will be added to "Api".
    /// </summary>
    /// <example>
    /// <code>
    /// [AlchemyRoutePrefix("Hello")]
    /// public class HelloController()
    /// {
    ///     [HttpGet]
    ///     [HttpRoute("greet")]
    ///     public string Greet()
    ///     {
    ///         return "Hello World!";
    ///     }
    /// }
    /// </code>
    /// Generated URL:
    /// <c>/Alchemy/Plugins/YourPlugin/api/Hello/greet</c>
    /// Generated JS Proxy:
    /// <c>Alchemy.Plugins.YourPlugin.Api.Hello.greet();</c>
    /// 
    /// Without the attribute, the url would be the following:
    /// Generated URL:
    /// <c>Alchemy/Plugins/YourPlugin/api/greet</c>
    /// Generated JS Proxy:
    /// <c>Alchemy.Plugins.YourPlugin.Api.greet();</c>
    /// </example>
    public class AlchemyRoutePrefixAttribute : System.Web.Http.RoutePrefixAttribute
    {
        /// <summary>
        /// The name of the service that the controller represents.
        /// </summary>
        private string serviceName;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pluginType">The plugin type (the one that extends AlchemyPluginBase).</param>
        /// <param name="serviceName">
        /// The name of the service (used for the routes to your api controllers). For example, if you used
        /// 'MyService' as a service name, then the route to all of the actions on the controller would be
        /// /Alchemy/Plugins/PluginName/api/MyService/action.  Also the service name is what will be used
        /// as the object that the proxy methods get attached to when the JavaScript proxy is generated.
        /// </param>
        [Obsolete("Please use the constructer with no Type parameter. This will be removed for 1.0.")]
        public AlchemyRoutePrefixAttribute(Type pluginType, string serviceName) : base()
        {
            this.serviceName = serviceName.Trim('/');
        }

        /// <summary>
        /// Constructor for supplying a service name to your api controller.  The service name
        /// is what gets used for the URL as well as the object name of the JS proxy.
        /// </summary>
        /// <param name="serviceName">
        /// The name of the service (used for the routes to your api controllers). For example, if you used
        /// 'MyService' as a service name, then the route to all of the actions on the controller would be
        /// /Alchemy/Plugins/PluginName/api/MyService/action.  Also the service name is what will be used
        /// as the object that the proxy methods get attached to when the JavaScript proxy is generated.
        /// If now service name is used, then routes just get added to /Alchemy/Plugins/PluginName/api/action.
        /// </param>
        public AlchemyRoutePrefixAttribute(string serviceName = null)
        {
            this.serviceName = serviceName.Trim();
        }

        /// <summary>
        /// Gets the prefix for the route (alias for ServiceName property).
        /// </summary>
        public override string Prefix
        {
            get
            {
                return this.serviceName;
            }
        }

        /// <summary>
        /// Gets the name of the service.  This is used to generate the routes to your api controllers.
        /// </summary>
        public string ServiceName
        {
            get
            {
                return this.serviceName;
            }
        }

    }
}
