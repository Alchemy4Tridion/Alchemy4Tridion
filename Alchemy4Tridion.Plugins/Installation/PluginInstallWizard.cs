
using Alchemy4Tridion.Plugins.Installation.Wizard;
using System.Collections.Generic;
namespace Alchemy4Tridion.Plugins.Installation
{
    public class PluginInstallWizard
    {
        public bool RequiresWindowsImpersonation
        {
            get;
            set;
        }

        public List<InstallWizardScreen> Screens
        {
            get;
            set;
        }
    }
}
