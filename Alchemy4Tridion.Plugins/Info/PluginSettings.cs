using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Represents the settings element of an a4t.xml document with helpers for retrieving
    /// the various settings.
    /// </summary>
    /// <example>
    ///     string setting = settings.Get("SomeKey");
    /// </example>
    /// <remarks>
    /// See unit tests for more examples of basic and advanced usage.
    /// </remarks>
    public class PluginSettings : IPluginSettings
    {
        /// <summary>
        /// Whether or not to decrypt the values returned via the Get methods.
        /// </summary>
        private bool decryptValues = false;

        /// <summary>
        /// The encryption key used to decrypt the values.
        /// </summary>
        private string encryptionKey = null;

        /// <summary>
        /// The a4t.xml's namespace.
        /// </summary>
        private XNamespace ns = "http://www.alchemywebstore.com/";

        /// <summary>
        /// The plugin's a4t.xml document.
        /// </summary>
        private XDocument pluginConfiguration;

        /// <summary>
        /// Represents the root element that these settings represent.
        /// </summary>
        private XElement rootElement;

        /// <summary>
        /// The underlying dictionary containing the different settings.
        /// </summary>
        private Dictionary<string, PluginSetting> settings;

        /// <summary>
        /// Gets or sets the type that the client settings should be deserialized to with the GetClientSettings method.
        /// </summary>
        Type ClientSettingsType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets whether or not the values will be decrypted by the Get methods.
        /// </summary>
        public bool DecryptValues
        {
            get
            {
                return this.decryptValues;
            }
        }

        /// <summary>
        /// Gets the encryption key that was used with the Decrypt method.
        /// </summary>
        public string EncryptionKey
        {
            get
            {
                return this.encryptionKey;
            }
        }

        /// <summary>
        /// Gets the keys of the root level that this instance represents.
        /// </summary>
        public IEnumerable<string> Keys
        {
            get
            {
                return this.settings.Keys
                    .ToArray();
            }
        }

        /// <summary>
        /// Reference to the plugin that these settings belong to. Can be null if the settings
        /// were not created by the plugin itself.
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructor for extracting the settings from a a4t.xml file within a plugin's plugin path.
        /// </summary>
        /// <param name="plugin">The plugin to get the a4t file from.</param>
        public PluginSettings(IAlchemyPlugin plugin)
            : this(Path.Combine(plugin.PluginPath, "a4t.xml"), plugin)
        {

        }

        /// <summary>
        /// Constructor for extracting th esettings from a given a4t.xml document.
        /// </summary>
        /// <param name="fullPathToXml">The full path to a plugin's a4t.xml file.</param>
        /// <param name="plugin">Reference to the plugin that contains these settings.</param>
        public PluginSettings(string fullPathToXml, IAlchemyPlugin plugin = null)
            : this(XDocument.Load(fullPathToXml), plugin)
        {

        }

        /// <summary>
        /// Constructor for extracting the settings from a given a4t.xml document.
        /// </summary>
        /// <param name="pluginConfiguration">The doc that represents the a4t.xml file.</param>
        public PluginSettings(XDocument pluginConfiguration, IAlchemyPlugin plugin = null)
        {
            Plugin = plugin;
            this.pluginConfiguration = pluginConfiguration;
            this.settings = new Dictionary<string, PluginSetting>();
            
            var settingsElement = this.rootElement = this.pluginConfiguration.Root.Element(this.ns + "settings");
            if (settingsElement != null)
            {
                DeserializeSettings(settingsElement);

                // read all settings from the <client> element and apply client=true as default attribute
                DeserializeSettings(
                    settingsElement.Element(this.ns + "client"),
                    new DeserializeDefaultOptions { IsClientSetting = true });
                DeserializeSettings(
                    settingsElement.Element(this.ns + "encrypt"),
                    new DeserializeDefaultOptions { IsEncryptedValue = true });
            }
        }

        /// <summary>
        /// Private constructor for nested dictionaries.
        /// </summary>
        /// <param name="pluginConfiguration"></param>
        /// <param name="element"></param>
        private PluginSettings(XDocument pluginConfiguration, XElement element, PluginSettings parentSettings)
        {
            Plugin = parentSettings.Plugin;
            this.pluginConfiguration = pluginConfiguration;
            this.rootElement = element;
            this.settings = new Dictionary<string, PluginSetting>();

            DeserializeSettings(element);

            if (parentSettings.DecryptValues)
            {
                this.decryptValues = true;
                this.encryptionKey = parentSettings.encryptionKey;
            }
        }

        /// <summary>
        /// If the given encryption key matches the ISettingsEncryptorService's key of the plugin, will decypt values
        /// that are retrieved via the Get methods.
        /// </summary>
        /// <param name="encryptionKey">The encryption key used by the plugin.</param>
        /// <returns>True if the key matched and values will not be decrypted, else false.</returns>
        public bool Decrypt(string encryptionKey = null)
        {
            if (Plugin != null && Plugin.Services.SettingsEncryptor.MatchesEncryptionKey(encryptionKey))
            {
                this.decryptValues = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets all of the settings at this level deserialized into a strongly typed object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        public T Get<T>()
        {
            return Get<T>(false);
        }

        /// <summary>
        /// Gets all of the client only settings at this level deserialized into a strongly typed object.
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="clientOnly">Whether or not to include only client settings.</param>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        public T Get<T>(bool clientOnly)
        {
            return (T)Get(typeof(T), clientOnly);
        }

        /// <summary>
        /// Gets all of the client only settings at this level deserialized into a strongly typed object.
        /// </summary>
        /// <param name="type">The type to return the value as.</param>
        /// <param name="clientOnly">Whether or not to include only client settings.</param>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        public object Get(Type type, bool clientOnly)
        {
            if (clientOnly)
            {
                return DeserializeElements(type, this.settings
                    .Where(s => s.Value.IsClientSetting)
                    .Select(s => s.Value.GetElement()));
            }

            return DeserializeElements(type, this.settings
                .Select(s => s.Value.GetElement()));
        }

        /// <summary>
        /// Gets a value from the plugin settings.
        /// </summary>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <param name="defaultValue">The default value to return (defaults as null).</param>
        /// <returns>The value, or the default value if not found.</returns>
        public string Get(string key, string defaultValue = null)
        {
            if (!this.settings.ContainsKey(key))
            {
                return defaultValue;
            }
            return this.settings[key].Value;
        }

        /// <summary>
        /// Gets a value from the plugin settings as a specific type.
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <returns>The value as the specified type, or the default of that Type if not found.</returns>
        public T Get<T>(string key)
        {
            return Get(key, default(T));
        }

        /// <summary>
        /// Gets a value from the plugin settings as a specific type. 
        /// </summary>
        /// <typeparam name="T">The type to return the value as.</typeparam>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <param name="defaultValue">The default value to return if the setting couldn't be found.</param>
        /// <returns>The value as the specified type, or the defualt value if not found.</returns>
        public T Get<T>(string key, T defaultValue)
        {
            if (!this.settings.ContainsKey(key))
            {
                return defaultValue;
            }

            var value = this.settings[key];

            if (value.HasNestedSettings)
            {
                return DeserializeElement<T>(value.GetElement());
            }

            return (T)Convert.ChangeType(value.Value, typeof(T));
        }

        /// <summary>
        /// Gets a deserialized object based off of client only settings
        /// at the root level of the settings element.
        /// </summary>
        /// <returns>
        /// The value as the specified type defined by the 'ClientSettingsType' ExpandoObject.
        /// </returns>
        public object GetAsClientType()
        {
            if (Plugin != null)
            {
                if (Plugin.Services.SettingsDeserialization != null && Plugin.Services.SettingsDeserialization.ClientSettingsType != null)
                {
                    return Get(Plugin.Services.SettingsDeserialization.ClientSettingsType, true);
                }
            }

            ExpandoObject config = new ExpandoObject();
            AddPropertiesToDynamicClientType(config, this, false);

            return config;
        }

        /// <summary>
        /// Gets a setting's value as a list of string values.
        /// </summary>
        /// <param name="key">The key of the setting to lookup</param>
        /// <returns>Null if the key was not found, or a list of string values that are trimmed of whitespace.</returns>
        public IEnumerable<string> GetList(string key)
        {
            string value = Get(key);
            if (value == null)
            {
                return null;
            }
            string[] parts = value.Split(',');
            List<string> list = new List<string>();
            foreach(string part in parts)
            {
                list.Add(part.Trim());
            }
            return list;
        }

        /// <summary>
        /// Gets a plugin setting value as an underyling PluginSetting instance.
        /// </summary>
        /// <param name="key">The key of the setting to lookup.</param>
        /// <returns>The PluginSetting, or null if the key was not found.</returns>
        public PluginSetting GetSetting(string key)
        {
            if (!this.settings.ContainsKey(key))
            {
                return null;
            }
            return this.settings[key];
        }

        /// <summary>
        /// Gets a value as a nested PluginSettings instance (for non 'add' elements, the key will be the element's
        /// name and the value will be the element's value.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IPluginSettings GetNestedSettings(string key)
        {
            if (!this.settings.ContainsKey(key))
            {
                return null;
            }
            var setting = this.settings[key];

            var nested = new PluginSettings(this.pluginConfiguration, setting.GetElement(), this);
            
            return nested;
        }

        /// <summary>
        /// Saves the a4t.xml file with any changes that have been made.
        /// </summary>
        public void Save()
        {
            if (Plugin != null)
            {
                this.pluginConfiguration.Save(Path.Combine(Plugin.PluginPath, "a4t.xml"));
            }
        }

        /// <summary>
        /// Adds setting values to a level of the returned json object.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="settings"></param>
        /// <param name="ignoreHasChildElementsAttribute"></param>
        private void AddPropertiesToDynamicClientType(IDictionary<string, object> config, IPluginSettings settings, bool ignoreHasChildElementsAttribute)
        {
            foreach (string key in settings.Keys)
            {
                var setting = settings.GetSetting(key);
                if (ignoreHasChildElementsAttribute || setting.IsClientSetting)
                {
                    if (setting.HasNestedSettings || setting.IsArray)
                    {
                        List<object> arrayItems = new List<object>();
                        config[key] = arrayItems;
                        XElement element = setting.GetElement();
                        var elements = element.Elements();

                        // check for an array...
                        if (setting.IsArray)
                        {
                            if (setting.IsArrayOfValues)
                            {
                                foreach (var el in elements)
                                {
                                    arrayItems.Add(el.Value);
                                }
                            }
                            else
                            {
                                foreach (var el in elements)
                                {
                                    IDictionary<string, object> complex = new ExpandoObject();
                                    PluginSettings complexSettings = new PluginSettings(this.pluginConfiguration, el, this);
                                    AddPropertiesToDynamicClientType(complex, complexSettings, true);

                                    arrayItems.Add(complex);
                                }
                            }
                        }
                        else
                        {
                            IDictionary<string, object> nested = new ExpandoObject();
                            config[key] = nested;
                            AddPropertiesToDynamicClientType(nested, settings.GetNestedSettings(key), true);
                        }
                    }
                    else
                    {
                        config[key] = setting.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets a deserialized value based on a setting's child elements.
        /// </summary>
        /// <typeparam name="T">The type to deserialize as.</typeparam>
        /// <param name="element">The root element to be deserialized.</param>
        /// <returns>The deserialized object</returns>
        private T DeserializeElement<T>(XElement element)
        {
            return DeserializeElements<T>(element.Elements());
        }

        /// <summary>
        /// Gets a deserialized value based on a setting's child elements.
        /// </summary>
        /// <param name="type">The type to deserialize as.</param>
        /// <param name="element">The root element to be deserialized.</param>
        /// <returns>The deserialized object</returns>
        private object DeserializeElement(Type type, XElement element)
        {
            return DeserializeElements(type, element.Elements());
        }

        /// <summary>
        /// Gets a deserialized value based on a setting's child elements.
        /// </summary>
        /// <typeparam name="T">The type to deserialize as.</typeparam>
        /// <param name="elements">The elements to be serserialized into the root item.</param>
        /// <returns>The deserialized object.</returns>
        private T DeserializeElements<T>(IEnumerable<XElement> elements)
        {
            return (T)DeserializeElements(typeof(T), elements);
        }

        /// <summary>
        /// Gets a deserialized value based on a setting's child elements.
        /// </summary>
        /// <param name="type">The type to deserialize as.</param>
        /// <param name="elements">The elements to be serserialized into the root item.</param>
        /// <returns>The deserialized object.</returns>
        private object DeserializeElements(Type type, IEnumerable<XElement> elements)
        {
            XElement root = new XElement(this.ns + type.Name);

            foreach (var child in elements)
            {
                root.Add(child);
            }

            var xmlSerializer = new XmlSerializer(type, this.ns.ToString());

            return xmlSerializer.Deserialize(root.CreateReader());
        }

        /// <summary>
        /// Deserialize the xml elements to PluginSettings put into the private settings dictionary.
        /// </summary>
        /// <param name="parentElement"></param>
        private void DeserializeSettings(XElement parentElement, DeserializeDefaultOptions options = null)
        {
            if (parentElement == null)
            {
                return;
            }

            var elements = parentElement.Elements()
                .Where(el => el.Name.LocalName != "client" &&
                             el.Name.LocalName != "encrypt");

            foreach (var element in elements)
            {
                PluginSetting setting = new PluginSetting(this, element);

                if (!String.IsNullOrEmpty(setting.Key))
                {
                    if (this.settings.ContainsKey(setting.Key))
                    {
                        throw new ArgumentException("Key already exists in settings.", setting.Key);
                    }
                    SetDefaultAttributes(setting, element, options);
                    this.settings.Add(setting.Key, setting);
                }
            }
        }

        /// <summary>
        /// Sets default attributes on the given setting. If the given element contains the attribute, then it is not overridden.
        /// </summary>
        /// <param name="setting">The setting to set the values for.</param>
        /// <param name="element">The xml element (used to check if the attribute exists).</param>
        /// <param name="options">The default options.</param>
        private void SetDefaultAttributes(PluginSetting setting, XElement element, DeserializeDefaultOptions options)
        {
            if (options == null)
            {
                return;
            }

            if (options.IsClientSetting)
            {
                var attribute = element.Attribute("client");
                if (attribute == null)
                {
                    setting.IsClientSetting = true;
                }
            }
            if (options.IsEncryptedValue)
            {
                var attribute = element.Attribute("encrypt");
                if (attribute == null)
                {
                    setting.IsEncryptedSetting = true;
                }
            }
        }

        /// <summary>
        /// Settings to default child settings to.
        /// </summary>
        internal class DeserializeDefaultOptions
        {
            /// <summary>
            /// Gets or sets whether or not the client api can read this value.
            /// </summary>
            public bool IsClientSetting
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets whether or not the values are to be encrypted by the engine.
            /// </summary>
            public bool IsEncryptedValue
            {
                get;
                set;
            }
        }
    }
}
