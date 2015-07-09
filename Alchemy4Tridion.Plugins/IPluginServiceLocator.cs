using Alchemy4Tridion.Plugins.Info;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Interface for class that represents a strongly typed service locator that each plugin contains.
    /// </summary>
    public interface IPluginServiceLocator
    {
        /// <summary>
        /// Gets or sets the utility that will be used to deserialize the plugin's settings.
        /// </summary>
        ISettingsDeserializationService SettingsDeserialization
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the utility used for encrypting and decrypting custom configuration settings.
        /// </summary>
        ISettingsEncryptorService SettingsEncryptor
        {
            get;
            set;
        }
    }
}
