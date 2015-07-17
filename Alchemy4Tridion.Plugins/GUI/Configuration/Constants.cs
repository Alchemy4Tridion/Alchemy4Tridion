
namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents constants for string values contains within the Tridion GUI, like PageIds, GroupIds
    /// View names, context menu items, etc.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Represents group id's used for targetting the groupid attribute of gui extensions.
        /// </summary>
        public static class GroupIds
        {
            /// <summary>
            /// Represents group id's found on the Administration tab.
            /// </summary>
            public static class AdministrationPage
            {
                public const string AccessManagementGroup = "AccessManagementGroup";
                public const string PublishingManagementGroup = "PublishingManagementGroup";
                public const string ContentConfigurationGroup = "ContentConfigurationGroup";
            }

            /// <summary>
            /// Represents group id's found on the Bundle tab.
            /// </summary>
            public static class BundlePage
            {
                public const string BundleContentGroup = "BundleContentGroup";
            }

            /// <summary>
            /// Represents group id's found on the Create tab.
            /// </summary>
            public static class CreatePage
            {
                public const string ContentGroup = "ContentGroup";
                public const string OrganizationalItemsGroup = "OrganizationalItemsGroup";
                public const string TemplatesGroup = "TemplatesGroup";
                public const string TaxonomyGroup = "TaxonomyGroup";
                public const string TargetingGroup = "TargetingGroup";
            }

            /// <summary>
            /// Represents group id's found on the Home tab.
            /// </summary>
            public static class HomePage
            {
                public const string ClipboardGroup = "ClipboardGroup";
                public const string ManageGroup = "ManageGroup";
                public const string EditGroup = "EditGroup";
                public const string PublishGroup = "PublishGroup";
                public const string ShareGroup = "ShareGroup";
            }

            /// <summary>
            /// Represents group id's found on the Organize tab.
            /// </summary>
            public static class OrganizePage
            {
                public const string BlueprintingGroup = "BlueprintingGroup";
                public const string TaxonomyGroup = "TaxonomyGroup1";
                public const string DetailsGroup = "DetailsGroup";
            }

            /// <summary>
            /// Represents group id's found on the Workflow tab.
            /// </summary>
            public static class WorkflowPage
            {
                public const string WorkflowActivityGroup = "WorkflowActivityGroup";
                public const string WorkflowProcessGroup = "WorkflowProcessGroup";
                public const string WorkflowManagementGroup = "WorkflowManagementGroup";
            }
        }

        /// <summary>
        /// Represents pages (tabs) that gui extensions can be placed on. Targets the pageid attribute of gui extensions.
        /// </summary>
        public static class PageIds
        {
            public const string HomePage = "HomePage";
            public const string CreatePage = "CreatePage";
            public const string OrganizePage = "OrganizePage";
            public const string WorkflowPage = "WorkflowPage";
            public const string AdministrationPage = "AdministrationPage";
            public const string BundlePage = "BundlePage";
            public const string ToolsPage = "ToolsPage";
        }

        /// <summary>
        /// Repesents Views that you can target when applying extensions.
        /// </summary>
        public static class Views
        {
            public const string ComponentView = "ComponentView";
            public const string DashboardView = "DashboardView";
            public const string PageView = "PageView";
        }
    }
}
