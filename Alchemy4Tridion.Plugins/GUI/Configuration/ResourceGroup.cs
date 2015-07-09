using Alchemy4Tridion.Plugins.GUI.Configuration.Elements;
using System;
using System.Collections.Generic;

namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents a resource group in the editor configuration at /Configuration/resources/cfg:groups.
    /// </summary>
    public abstract class ResourceGroup : IEditorSection
    {
        /// <summary>
        /// Whether or not to add the webapi proxy file and dependencies to this resource group.
        /// </summary>
        private bool addWebApiProxy;

        /// <summary>
        /// The short name of the resource group.
        /// </summary>
        private string name;

        /// <summary>
        /// Gets or sets the list of dependencies that this group depends on.
        /// </summary>
        public Dependencies Dependencies
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the list of files in the resource group.
        /// </summary>
        public List<File> Fileset
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the full resource name (ie Alchemy.Plugins.PluginName.Resources.GroupName).
        /// </summary>
        public string FullName
        {
            get
            {
                // hack here... set webapi dependencies and files if it was added...
                // at constructor time the Plugin property isn't set yet.
                if (this.addWebApiProxy)
                {
                    // need the proxy to be at top so it can be used by any other script in the resource group
                    Fileset.Insert(0, new File { Location = Plugin.Name + "ApiProxy.js", Type = FileTypes.Script });
                    Dependencies.AddLibraryQwest();
                    this.addWebApiProxy = false;
                }

                return String.Format("Alchemy.Plugins.{0}.Resources.{1}",
                    Plugin.Name,
                    Name);
            }
        }

        /// <summary>
        /// Gets or sets the name of this resource group.  This is the short name at the end of the full name.
        /// </summary>
        public string Name
        {
            get
            {
                if (String.IsNullOrEmpty(this.name))
                {
                    this.name = GetType().Name;
                }
                return this.name;
            }
        }

        /// <summary>
        /// The plugin that this resource group belongs to.  Set automatically by core framework.
        /// </summary>
        public IAlchemyPlugin Plugin
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The optional name of the resource group. Uses the type name by default.</param>
        public ResourceGroup(string name = null)
        {
            Dependencies = new Dependencies();
            Fileset = new List<File>();

            this.name = name;
        }

        /// <summary>
        /// Adds the web api JavaScript proxy file to the file of this resource group and attaches necessary dependencies.
        /// The proxy is an automatically built JavaScript API that allows you to call your plugin's WebAPI controllers
        /// as well as some other server side utilities like getting your custom configuration client settings.
        /// <note type="note">
        ///   You do not have to add a dependency to the Alchemy Core resource group via <c>Dependencies.AddAlchemyCore()</c> as the proxy 
        ///   already has a dependency on it.
        /// </note>
        /// </summary>
        /// <remarks>
        /// You can call AddWebApiProxy anywhere within your ResourceGroup's constructor.  It will always be
        /// placed at the top of your dependencies.
        /// </remarks>
        public void AddWebApiProxy()
        {
            this.addWebApiProxy = true;
        }

        /// <summary>
        /// Adds a file to the group's fileset. The file type is determined by the file's extension.
        /// </summary>
        /// <param name="file"></param>
        public void AddFile(string file)
        {
            string extension = System.IO.Path.GetExtension(file).ToLower();

            if (extension == ".css")
            {
                AddFile(FileTypes.Style, file);
            }
            else if (extension == ".js")
            {
                AddFile(FileTypes.Script, file);
            }
            else
            {
                AddFile(FileTypes.Reference, file);
            }
        }

        /// <summary>
        /// Adds a file reference that will point to the name of the reference using it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void AddFile<T>() where T: CommandSet
        {
            Fileset.Add(new File { Reference = typeof(T), Type = FileTypes.Reference });
        }

        /// <summary>
        /// Adds a file to the group's fileset.
        /// </summary>
        /// <param name="type">The type of file to add.</param>
        /// <param name="file">The location of the file to add.</param>
        public void AddFile(FileTypes type, string file)
        {
            Fileset.Add(new File(type, file));
        }

        /// <summary>
        /// Adds files to the group's fileset. The types are determined by each file's extension.
        /// </summary>
        /// <param name="files">The files to add.</param>
        /// <returns></returns>
        public void AddFiles(params string[] files)
        {
            for (int i = 0; i < files.Length; i++)
            {
                AddFile(files[i]);
            }
        }
    }
}
