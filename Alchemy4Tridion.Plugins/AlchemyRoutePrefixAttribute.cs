using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Custom route prefix for Alchemy WebAPI controllers.
    /// </summary>
    public class AlchemyRoutePrefixAttribute : System.Web.Http.RoutePrefixAttribute
    {
        private IAlchemyPlugin plugin;

        private Type pluginType;

        private string prefix;

        private string serviceName;

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
        /// <param name="prefix">The prefix</param>
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

        public string ServiceName
        {
            get
            {
                return this.serviceName;
            }
        }

    }
}
