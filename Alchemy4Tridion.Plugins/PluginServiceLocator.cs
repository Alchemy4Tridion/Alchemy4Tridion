using Alchemy4Tridion.Plugins.Info;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Represents a strongly typed service locator that each plugin will maintain its own version of so that they
    /// can override services without affecting others.
    /// </summary>
    public class PluginServiceLocator : IPluginServiceLocator
    {
        /// <summary>
        /// Gets or sets the utility that will be used to deserialize the plugin's settings.
        /// </summary>
        public ISettingsDeserializationService SettingsDeserialization
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service that is used for encrypting custom configuration settings.
        /// </summary>
        public ISettingsEncryptorService SettingsEncryptor
        {
            get;
            set;
        }
    }
}
