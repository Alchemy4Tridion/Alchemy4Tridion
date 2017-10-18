
namespace Alchemy4Tridion.Plugins.GUI.Configuration
{
    /// <summary>
    /// Represents constants for string values contains within the Tridion GUI, like PageIds, GroupIds
    /// View names, context menu items, etc.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Represents context menu items that you can target with the InsertBefore property.
        /// </summary>
        public static class ContextMenuIds
        {
            /// <summary>
            /// Represents the main context menu's items (the one seen on the dashboard view for example).
            /// </summary>
            public static class MainContextMenu
            {
                public static string AddItemsToBundle = "cm_add_to_bundle";
                public static string AddSelectedItemsToBundle = "cm_add_selected_to_bundle";
                public static string AssignActivity = "cm_assignactivity";
                public static string Blueprinting = "cm_blue";
                public static string Classification = "cm_classification";
                /// <summary>
                /// The first (out of the box) separator within the clipboard commands, between Paste and Delete
                /// </summary>
                public static string ClipboardSeparator0 = "cm_clipboard_sep_0";
                public static string Copy = "cm_clipboard_copy";
                public static string Cut = "cm_clipboard_cut";
                public static string Delete = "cm_clipboard_delete";
                public static string DisableUser = "cm_disableuser";
                public static string EnableUser = "cm_enableuser";
                public static string ExploreCustomPage = "cm_expl";
                public static string FinishActivity = "cm_finishactivity";
                public static string ForceFinishProcess = "cm_forcefinishprocess";
                public static string GotoLocation = "ctxGotoLocation";
                public static string MoveDownListItems = "cm_moveDownListItems";
                public static string MoveUpListItems = "cm_moveUpListItems";
                public static string New = "cm_new";
                public static string Open = "cm_open";
                public static string OpenWithWebdav = "cm_open_webdav";
                public static string Paste = "cm_clipboard_paste";
                public static string Properties = "cm_properties";
                public static string Publishing = "cm_pub";
                public static string Refresh = "cm_refresh";
                public static string RemoveSelectedItemsFromBundle = "cm_remove_selected_from_bundle";
                public static string RestartActivity = "cm_restartactivity";
                public static string RevertProcess = "cm_revertprocess";
                public static string SendItemLink = "cm_share";

                /// <summary>
                /// The first (out of the box) separator, between OpenWithWebDav and Versioning
                /// </summary>
                public static string Separator1 = "cm_sep_1";
                /// <summary>
                /// The second (out of the box) separator, between StartLocation and Preview
                /// </summary>
                public static string Separator2 = "cm_sep_2";
                /// <summary>
                /// The third (out of the box) separator, between Preview and EnableUser
                /// </summary>
                public static string Separator3 = "cm_sep_3";
                /// <summary>
                /// The fourth (out of the box) separator, between DisableUser and Cut.
                /// </summary>
                public static string Separator4 = "cm_sep_4";
                /// <summary>
                /// The fifth (out of the box) separator, between Delete and AddItemsToBundle
                /// </summary>
                public static string Separator5 = "cm_sep_5";
                /// <summary>
                /// The sixth (out of the box) separator, between RemoveSelectedItemsFromBundle and Properties
                /// </summary>
                public static string Separator6 = "cm_sep_6";
                /// <summary>
                /// The seventh (out of the box) separator, between WhereUsed and ForceFinishProcess
                /// </summary>
                public static string Separator7 = "cm_sep_7";
                /// <summary>
                /// The eighth (out of the box) separator, between RevertProcess and MoveUpListItems
                /// </summary>
                public static string Separator8 = "cm_sep_8";
                /// <summary>
                /// The ninth (out of the box) separator, between MoveDownListItems and New
                /// </summary>
                public static string Separator9 = "cm_sep_9";
                public static string StartActivity = "cm_startactivity";
                public static string StartLocation = "cm_start";
                public static string SuspendActivity = "cm_syspendactivity";
                public static string Versioning = "cm_ver";
                public static string WhereUsed = "cm_whereused";
            }
        }

        /// <summary>
        /// represents button id's in the ribbon toolbar
        /// </summary>
        public static class RibbonToolbarButtonIds
        {
            public static class HomePage
            {
                public static class ManageGroup
                {
                    public static string Open = "OpenBtn";
                    public static string BlueprintHierarchy = "BlueprintHierarchyBtn";
                    public static string WhereUsed = "WhereUsedBtn";
                    public static string ManageItemsGroup = "ManageItemsGroup2";
                }
            }
        }

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
            /// Represents group id's found on the Format tab.
            /// </summary>
            public static class FormatPage
            {
                /// <summary>
                /// The group id for the "Clipboard" group found on the Format tab.
                /// </summary>
                public const string FormatClipboardGroup = "FormatClipboardGroup";

                /// <summary>
                /// The group id for the "Font" group found on the Format tab.
                /// </summary>
                public const string FormatFontGroup = "FormatFontGroup";

                /// <summary>
                /// The group id for the "General" group found on the Format tab.
                /// </summary>
                public const string FormatGeneralGroup = "FormatGeneralGroup";

                /// <summary>
                /// The group id for the "Insert" group found on the Format tab.
                /// </summary>
                public const string FormatInsertGroup = "FormatInsertGroup";

                /// <summary>
                /// The group id for the "Manage" group found on the Format tab.
                /// </summary>
                public const string FormatManageGroup = "FormatManageGroup";

                /// <summary>
                /// The groupid for the "Paragraph" group found on the Format tab.
                /// </summary>
                public const string FormatParagraphGroup = "FormatParagraphGroup";

                /// <summary>
                /// The group id for the "Style" group found on the Format tab.
                /// </summary>
                public const string FormatStyleGroup = "FormatStyleGroup";
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
            public const string FormatPage = "FormatPage";
        }

        /// <summary>
        /// Repesents Views that you can target when applying extensions.
        /// </summary>
        public static class Views
        {
            public const string ActivityInstanceView = "ActivityInstanceView";
            public const string BusinessProcessTypeView = "BusinessProcessTypeView";
            public const string CategoryView = "CategoryView";
            public const string ComponentView = "ComponentView";
            public const string ControlRoomView = "ControlRoomView";
            public const string CustomPageView = "CustomPageView";
            public const string FolderView = "FolderView";
            public const string HelpView = "HelpView";
            public const string KeywordView = "KeywordView";
            public const string ListFiltersView = "ListFiltersView";
            public const string MultimediaTypeView = "MultimediaTypeView";
            public const string PopupsView = "PopupsView";
            public const string ProcessHistoryView = "ProcessHistoryView";
            public const string ProcessInstanceView = "ProcessInstanceView";
            public const string SitesView = "SitesView";
            public const string SiteWizardView = "SiteWizardView";
            public const string SplashScreenView = "SplashScreenView";
            public const string StructureGroupView = "StructureGroupView";
            public const string TargetGroupView = "TargetGroupView";
            public const string TargetTypeView = "TargetTypeView";
            public const string TemplateBuildingBlockView = "TemplateBuildingBlockView";
            public const string UserAccountsView = "UserAccountsView";
            public const string VirtualFolderView = "VirtualFolderView";
            public const string WelcomeView = "WelcomeView";
            public const string WorkflowActivitiesView = "WorkflowActivitiesView";
            public const string ComponentTemplateView = "ComponentTemplateView";
            public const string DashboardView = "DashboardView";
            public const string PageTemplateView = "PageTemplateView";
            public const string PageView = "PageView";
            public const string ProxyView = "ProxyView";
            public const string PublicationTargetView = "PublicationTargetView";
            public const string PublicationView = "PublicationView";
            public const string SchemaView = "SchemaView";
            public const string Settings = "Settings";
            public const string Welcome = "Welcome";
        }
    }
}
