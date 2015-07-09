using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Default plugin service that is used for deserializing settings.
    /// </summary>
    public class SettingsDeserializationService : ISettingsDeserializationService
    {
        /// <summary>
        /// Gets or sets the type that is used when deserialize the client settings. If left
        /// empty, the plugin's Settings.GetClientSettings() will return an ExpandoObject.
        /// </summary>
        public Type ClientSettingsType
        {
            get;
            set;
        }
    }
}
