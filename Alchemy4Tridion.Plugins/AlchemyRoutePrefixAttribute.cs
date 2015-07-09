using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Custom route prefix for Alchemy WebAPI controllers. This is required to be put on
    /// all WebAPI controllers included in plugins.
    /// </summary>
    public class AlchemyRoutePrefixAttribute : System.Web.Http.RoutePrefixAttribute
    {
        /// <summary>
        /// Reference to the plugin.
        /// </summary>
        private IAlchemyPlugin plugin;

        /// <summary>
        /// The type of the plugin.
        /// </summary>
        private Type pluginType;

        /// <summary>
        /// The prefix that the plugin will use.
        /// </summary>
        private string prefix;

        /// <summary>
        /// The name of the service that the controller represents.
        /// </summary>
        private string serviceName;

        /// <summary>
        /// Gets a reference to the Plugin that this attribute is attached to.
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get
            {
                if (this.plugin == null)
                {
                    if (this.pluginType == null)
                    {
                        throw new Exception("pluginType in AlchemyRoutePrefix was null.");
                    }
                    if (!typeof(IAlchemyPlugin).IsAssignableFrom(this.pluginType))
                    {
                        throw new Exception(this.pluginType.FullName + " is not of IAclhemyPlugin in AlchemyRoutePrefix");
                    }
                    this.plugin = Activator.CreateInstance(this.pluginType) as IAlchemyPlugin;
                    if (this.plugin == null)
                    {
                        throw new Exception("Error trying to activate instance of " + this.pluginType.FullName);
                    }
                }
                return this.plugin;
            }
        }

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
        public AlchemyRoutePrefixAttribute(Type pluginType, string serviceName) : base()
        {
            this.pluginType = pluginType;
            this.prefix = "Plugins/" + Plugin.Name + "/api/";

            if (String.IsNullOrEmpty(serviceName))
            {
                throw new Exception("ServiceName is required to be passed to the AlchemyRoutePrefixAttribute");
            }
            this.serviceName = serviceName.Trim('/');
            this.prefix += serviceName;
        }

        /// <summary>
        /// Gets the prefix for the route.
        /// </summary>
        public override string Prefix
        {
            get
            {
                return this.prefix;
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
