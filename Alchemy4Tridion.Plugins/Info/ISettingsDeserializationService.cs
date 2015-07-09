using System;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Interface for service that is used for deserializing settings.
    /// </summary>
    public interface ISettingsDeserializationService
    {
        /// <summary>
        /// Gets or sets the type that is used when deserialize the client settings. If left
        /// empty, the plugin's Settings.GetClientSettings() will return an ExpandoObject.
        /// </summary>
        Type ClientSettingsType
        {
            get;
            set;
        }
    }
}
