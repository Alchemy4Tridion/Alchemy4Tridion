using System;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Interface for getting custom configuration settings from a plugin.
    /// </summary>
    public interface IPluginSettings
    {
        /// <summary>
        /// Gets whether or not the values will be decrypted by the Get methods.
        /// </summary>
        bool DecryptValues { get; }

        /// <summary>
        /// Gets the encryption key that was used with the Decrypt method.
        /// </summary>
        string EncryptionKey { get; }

        /// <summary>
        /// Gets the keys of the root level that this instance represents.
        /// </summary>
        IEnumerable<string> Keys { get; }

        /// <summary>
        /// Reference to the plugin that these settings belong to.
        /// </summary>
        IAlchemyPlugin Plugin { get; }

        /// <summary>
        /// If the given encryption key matches the ISettingsEncryptorService's key of the plugin, will decypt values
        /// that are retrieved via the Get methods.
        /// </summary>
        /// <param name="encryptionKey">The encryption key used by the plugin.</param>
        /// <returns>True if the key matched and values will not be decrypted, else false.</returns>
        bool Decrypt(string encryptionKey = null);

        /// <summary>
        /// Gets all of the settings at this level deserialized into a strongly typed object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        T Get<T>();

        /// <summary>
        /// Gets all of the client only settings at this level deserialized into a strongly typed object.
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="clientOnly">Whether or not to include only client settings.</param>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        T Get<T>(bool clientOnly);

        /// <summary>
        /// Gets all of the client only settings at this level deserialized into a strongly typed object.
        /// </summary>
        /// <param name="type">The type to return the value as.</param>
        /// <param name="clientOnly">Whether or not to include only client settings.</param>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        object Get(Type type, bool clientOnly);

        /// <summary>
        /// Gets a value from the plugin settings.
        /// </summary>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <param name="defaultValue">The default value to return (defaults as null).</param>
        /// <returns>The value, or the default value if not found.</returns>
        string Get(string key, string defaultValue = null);

        /// <summary>
        /// Gets a value from the plugin settings as a specific type.
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        T Get<T>(string key);

        /// <summary>
        /// Gets a value from the plugin settings as a specific type. 
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <param name="defaultValue">The default value to return if the setting couldn't be found.</param>
        /// <returns>The value as the specified type, or the defualt value if not found.</returns>
        T Get<T>(string key, T defaultValue);

        /// <summary>
        /// Gets a deserialized object based off of client only settings
        /// at the root level of the settings element.
        /// </summary>
        /// <returns>
        /// The value as the specified type defined by the 'clientType'.
        /// </returns>
        object GetAsClientType();

        /// <summary>
        /// Gets a setting's value as a list of string values.
        /// </summary>
        /// <param name="key">The key of the setting to lookup</param>
        /// <returns>Null if the key was not found, or a list of string values that are trimmed of whitespace.</returns>
        IEnumerable<string> GetList(string key);

        /// <summary>
        /// Gets a value as a nested PluginSettings instance (for non 'add' elements, the key will be the element's
        /// name and the value will be the element's value.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        IPluginSettings GetNestedSettings(string key);

        /// <summary>
        /// Gets a plugin setting value as an underyling PluginSetting instance.
        /// </summary>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <returns>The PluginSetting, or null if the key was not found.</returns>
        PluginSetting GetSetting(string key);

        /// <summary>
        /// Saves the a4t.xml file with any changes that have been made.
        /// </summary>
        void Save();
    }
}
