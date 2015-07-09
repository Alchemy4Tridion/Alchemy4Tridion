using System.Linq;
using System.Xml.Linq;

namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Represents a plugin setting within the a4t.xml's settings element.
    /// </summary>
    public class PluginSetting
    {
        /// <summary>
        /// Whether or not this setting represents an array.
        /// </summary>
        private bool? isArray = null;

        /// <summary>
        /// Whether or not this setting can be read by the client api.
        /// </summary>
        private bool? isClientSetting = null;

        /// <summary>
        /// Whether or not this setting is to be encrypted.
        /// </summary>
        private bool? isEncryptedSetting = null;

        /// <summary>
        /// The a4t.xm's namespace.
        /// </summary>
        private XNamespace ns = "http://www.alchemywebstore.com/";

        /// <summary>
        /// The add setting element within the plugin's settings element that this represents.
        /// </summary>
        private XElement element;

        /// <summary>
        /// The parent settings object that this setting belongs to.
        /// </summary>
        private IPluginSettings settings;

        /// <summary>
        /// Whether or not this setting has nested settings.
        /// </summary>
        public bool HasNestedSettings
        {
            get
            {
                return this.element.HasElements;
            }
        }

        /// <summary>
        /// Gets whether or not the element represents an array of items.
        /// </summary>
        public bool IsArray
        {
            get
            {
                if (this.isArray == null)
                {
                    var attribute = this.element.Attribute("array");
                    if (attribute != null && attribute.Value.ToLower().Equals("true"))
                    {
                        this.isArray = true;
                    }
                    else if (this.element.HasElements)
                    {
                        var elements = this.element.Elements();

                        if (elements.Count() > 1 && elements
                            .Select(el => el.Name.LocalName)
                            .Distinct()
                            .Count() == 1)
                        {
                            this.isArray = true;
                        }
                    }
                    if (this.isArray == null)
                    {
                        this.isArray = false;
                    }
                }
                return isArray.Value;
            }
        }

        /// <summary>
        /// Gets whether or not the element has children that only has simple values.
        /// Does not check to see if the element itself is an array (should do IsArray check first).
        /// </summary>
        public bool IsArrayOfValues
        {
            get
            {
                return !(this.element.HasElements &&
                    this.element.Elements().Any(e => e.HasElements));
            }
        }

        /// <summary>
        /// Gets or sets whether or not this setting can be read by the client api. Settng this value
        /// does not modify the underlying xml.
        /// </summary>
        public bool IsClientSetting
        {
            get
            {
                if (this.isClientSetting == null)
                {
                    this.IsClientSetting = this.element.Attributes()
                        .Any(a => a.Name == "client" && a.Value.ToLower().Equals("true"));
                }
                return this.isClientSetting.Value;
            }
            set
            {
                this.isClientSetting = value;
            }
        }

        /// <summary>
        /// Gets or sets whether or not the setting's value should be encrypted. Settng this value
        /// does not modify the underlying xml.
        /// </summary>
        public bool IsEncryptedSetting
        {
            get
            {
                if (this.isEncryptedSetting == null)
                {
                    this.isEncryptedSetting = this.element.Attributes()
                        .Any(a => a.Name == "encrypt" && a.Value.ToLower().Equals("true"));
                }
                return this.isEncryptedSetting.Value;
            }
            set
            {
                this.isEncryptedSetting = value;
            }
        }

        /// <summary>
        /// Gets whether or not the element's value has been encrypted.
        /// </summary>
        public bool IsValueEncrypted
        {
            get
            {
                return this.settings.Plugin.Services.SettingsEncryptor.IsValueEncrypted(this.element.Value);
            }
        }

        /// <summary>
        /// Gets the key of the setting.
        /// </summary>
        public string Key
        {
            get
            {
                return this.element.Name.LocalName;
            }
        }

        /// <summary>
        /// Gets or sets the value of the setting. If the setting is suppose to be encrypted, will
        /// encrypt the value if set or decrypt when got.
        /// </summary>
        public string Value
        {
            get
            {
                if (this.settings.DecryptValues && IsEncryptedSetting && IsValueEncrypted)
                {
                    return this.settings.Plugin.Services.SettingsEncryptor.Decrypt(this.element.Value, this.settings.EncryptionKey);
                }
                return this.element.Value;
            }
            set
            {
                string val = value;

                // if its an encrypted setting and the value being passed in isn't already encrypted, encrypt it.
                if (IsEncryptedSetting && !this.settings.Plugin.Services.SettingsEncryptor.IsValueEncrypted(value))
                {
                    val = this.settings.Plugin.Services.SettingsEncryptor.Encrypt(val);
                }
                this.element.SetValue(val);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="element"></param>
        internal PluginSetting(IPluginSettings settings, XElement element)
        {
            this.element = element;
            this.settings = settings;
        }

        /// <summary>
        /// Gets the underlying xml element.
        /// </summary>
        /// <returns></returns>
        public XElement GetElement()
        {
            return this.element;
        }
    }
}
