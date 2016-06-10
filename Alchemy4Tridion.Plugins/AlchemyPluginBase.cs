using Alchemy4Tridion.Plugins.GUI.Configuration;
using Alchemy4Tridion.Plugins.Info;
using Alchemy4Tridion.Plugins.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Xml.Serialization;

namespace Alchemy4Tridion.Plugins
{
    /// <summary>
    /// Abstract base class to inherit your Alchemy Plugins from. All plugins are required to inherit
    /// from this base class.
    /// </summary>
    public abstract class AlchemyPluginBase : IAlchemyPlugin
    {
        /// <summary>
        /// The directory where Alchemy Plugins is installed;
        /// </summary>
        public static string AlchemyPluginsDirectory = null;

        /// <summary>
        /// The editor sections that this plugin contains.
        /// </summary>
        private IEnumerable<IEditorSection> editorSections;

        /// <summary>
        /// The url to the plugin's icon.
        /// </summary>
        private string iconUrl;

        /// <summary>
        /// The underlying plugin info xml.
        /// </summary>
        private IPluginInfo pluginInfo;

        /// <summary>
        /// The path to where the plugin is installed.
        /// </summary>
        private string pluginPath;

        /// <summary>
        /// Gets a reference to the actual plugin type.
        /// </summary>
        private Type pluginType;

        /// <summary>
        /// The services that this plugin contains.
        /// </summary>
        private IPluginServiceLocator services;

        /// <summary>
        /// The cached summary of the plugin.
        /// </summary>
        private string summary;

        /// <summary>
        /// Gets the Alchemy application url to the plugin. (ie '/Alchemy/Plugins/PluginName/').
        /// </summary>
        /// <remarks>
        /// The AppUrl is used when calling to alchemy services directly. For GUI related items the EditorUrl should be used.
        /// </remarks>
        public string AppUrl
        {
            get
            {
                return String.Format("/Alchemy/Plugins/{0}/", Name);
            }
        }

        /// <summary>
        /// Gets the Tridion Editor url to the plugin. (ie '/WebUI/Editors/Alchemy/Plugins/PluginName/').
        /// </summary>
        /// /// <remarks>
        /// The EditorUrl is for using context under the Tridion editor. For accessing your webapi controllers, the
        /// AppUrl should be used.
        /// </remarks>
        public string EditorUrl
        {
            get
            {
                return String.Format("/WebUI/Editors/Alchemy/Plugins/{0}/", Name);
            }
        }

        /// <summary>
        /// Gets the GUI editor sections that are contained in this plugin. (Set by Core framework.)
        /// </summary>
        public IEnumerable<IEditorSection> EditorSections
        {
            get
            {
                return this.editorSections;
            }
            internal set
            {
                this.editorSections = value;
            }
        }

        /// <summary>
        /// Gets the url to the plugin's icon.
        /// </summary>
        public string IconUrl
        {
            get
            {
                if (this.iconUrl == null)
                {
                    string filename = Directory.GetFiles(this.pluginPath)
                        .FirstOrDefault(file => file.StartsWith("icon."));
                    if (filename != null)
                    {
                        this.iconUrl = AppUrl + filename;
                    }
                    else
                    {
                        this.iconUrl = "/Alchemy/assets/css/img/icons/default-plugin-icon.jpg";
                    }
                }
                return this.iconUrl;
            }
        }

        /// <summary>
        /// Gets the unique web store identifier of the plugin from plugin info.. Returns null if there is 
        /// no id (plugin was never uploaded).
        /// </summary>
        public string Id
        {
            get
            {
                return PluginInfo.Id;
            }
        }

        /// <summary>
        /// Gets the unique name of the plugin from plugin info.
        /// </summary>
        public string Name
        {
            get
            {
                return PluginInfo.Name;
            }
        }

        /// <summary>
        /// Gets the plugin information (represented by the plugin's xml file).
        /// </summary>
        public IPluginInfo PluginInfo
        {
            get
            {
                return this.pluginInfo;
            }
        }

        /// <summary>
        /// Gets the absolute path to the plugin including the plugin folder. ie (C:\Tridion\Alchemy\Plugins\PluginName\)
        /// </summary>
        public string PluginPath
        {
            get
            {
                return this.pluginPath;
            }
        }

        /// <summary>
        /// Gets the plugin services/utilities that are consumed by this plugin.
        /// </summary>
        public IPluginServiceLocator Services
        {
            get
            {
                if (this.services == null)
                {
                    this.services = new PluginServiceLocator();
                }
                return this.services;
            }
            internal set
            {
                this.services = value;
            }
        }

        /// <summary>
        /// Gets the plugin settings. Note that this property is not cached and every time it is accessed
        /// a new PluginSettings instance is created.
        /// </summary>
        public IPluginSettings Settings
        {
            get
            {
                return new PluginSettings(Path.Combine(this.pluginPath, "a4t.xml"), this);
            }
        }

        /// <summary>
        /// Gets the summary of the plugin (from plugin info, uses summary if available, else the beginning of description).
        /// </summary>
        public string Summary
        {
            get
            {
                if (this.summary == null)
                {
                    this.summary = PluginInfo.Summary;
                    if (String.IsNullOrEmpty(this.summary) && !String.IsNullOrEmpty(PluginInfo.Description))
                    {
                        this.summary = PluginInfo.Description.Substring(0, PluginInfo.Description.Length > 100 ? 100 : PluginInfo.Description.Length);
                    }
                    else
                    {
                        this.summary = String.Empty;
                    }
                }
                return summary;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <exception cref="System.IO.FileNotFoundException">Throws FileNotFound if the plugin package is missing a4t.xml.</exception>
        /// <exception cref="System.FormatException">Throws FormatException if the a4t.xml is not expected format.</exception>
        public AlchemyPluginBase()
        {
            string fileLocation = GetType().Assembly.CodeBase;
            string searchFor = "/alchemy/plugins/";
            int index = fileLocation.ToLower().IndexOf(searchFor);
            if (index == -1)
            {
                throw new Exception(fileLocation + " was not loaded from correct plugin location.");
            }
            index = index + searchFor.Length;
            fileLocation = fileLocation.Substring(index);
            
            string pluginName = fileLocation.Split('/')[0];

            if (String.IsNullOrEmpty(AlchemyPluginsDirectory))
            {
                this.pluginPath = HostingEnvironment.MapPath(String.Format("/Alchemy/Plugins/{0}/", pluginName));
            }
            else
            {
                this.pluginPath = String.Format("{0}{1}{2}\\", AlchemyPluginsDirectory, AlchemyPluginsDirectory.EndsWith("\\") ? String.Empty : "\\", pluginName);
            }
            LoadInfo();
        }

        /// <summary>
        /// Constructor that takes a path to the plugin (root folder where a4t.xml lives). This constructor
        /// is typically used for testing purposes only.
        /// </summary>
        /// <param name="pluginPath">The path to the plugin.</param>
        public AlchemyPluginBase(string pluginPath)
        {
            this.pluginPath = pluginPath;
            LoadInfo();
        }

        /// <summary>
        /// Configures the services that will be used by this plugin.
        /// </summary>
        /// <param name="services">The default services that are used by this plugin.</param>
        public virtual void Configure(IPluginServiceLocator services)
        {
            
        }

        /// <summary>
        /// Gets a logger that is named to the instance of the plugin. Shortcut for Plugin.Services.LogManager.GetLogger.
        /// </summary>
        public ILogger GetLogger()
        {
            return Services.LogManager.GetLogger();
        }

        /// <summary>
        /// Maps a url relative to the editor url.
        /// </summary>
        /// <param name="url">The url to map</param>
        /// <returns>A url like '/WebUI/Editors/Alchemy/Plugins/PluginName/Mapped/Portion/'</returns>
        public string MapEditorUrl(string url)
        {
            url = url.TrimStart('/');

            return EditorUrl + url;
        }

        /// <summary>
        /// Maps a path based on the plugin's folder path.
        /// </summary>
        /// <param name="path">The path relative to the plugin's folder path.</param>
        /// <returns></returns>
        public string MapPath(string path)
        {
            return Path.Combine(PluginPath, path);
        }

        #region Private Methods

        /// <summary>
        /// Loads the a4t.xml file and sets the info properties.
        /// </summary>
        private void LoadInfo()
        {
            string infoPath = Path.Combine(this.pluginPath, "a4t.xml");

            FileStream fs = null;

            try
            {
                if (!File.Exists(infoPath))
                {
                    throw new FileNotFoundException("a4t.xml is not found at " + this.pluginPath);
                }
                fs = File.OpenRead(infoPath);

                this.pluginInfo = new XmlSerializer(typeof(PluginInfo)).Deserialize(fs) as PluginInfo;
                if (pluginInfo == null)
                {
                    throw new FormatException("a4t.xml was not the expected format at " + infoPath);
                }
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        #endregion
    }
}
