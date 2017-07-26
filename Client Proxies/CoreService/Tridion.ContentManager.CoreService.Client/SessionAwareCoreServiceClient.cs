using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.Xml.Linq;


namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class SessionAwareCoreServiceClient : ClientBase<ISessionAwareCoreService>, ISessionAwareCoreService, IDisposable
	{
		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetVirtualFolderTypeSchemaDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetVirtualFolderTypeSchemaDelegate;

		private SendOrPostCallback onGetVirtualFolderTypeSchemaCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetEnumValuesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetEnumValuesDelegate;

		private SendOrPostCallback onGetEnumValuesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginResolveBundleTypesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndResolveBundleTypesDelegate;

		private SendOrPostCallback onResolveBundleTypesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginCopyToKeywordDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndCopyToKeywordDelegate;

		private SendOrPostCallback onCopyToKeywordCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginMoveToKeywordDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndMoveToKeywordDelegate;

		private SendOrPostCallback onMoveToKeywordCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetTridionLanguagesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetTridionLanguagesDelegate;

		private SendOrPostCallback onGetTridionLanguagesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListWorkflowScriptTypesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListWorkflowScriptTypesDelegate;

		private SendOrPostCallback onGetListWorkflowScriptTypesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginAddToWorkflowDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndAddToWorkflowDelegate;

		private SendOrPostCallback onAddToWorkflowCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginRemoveFromWorkflowDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndRemoveFromWorkflowDelegate;

		private SendOrPostCallback onRemoveFromWorkflowCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginLockDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndLockDelegate;

		private SendOrPostCallback onLockCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginUnlockDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndUnlockDelegate;

		private SendOrPostCallback onUnlockCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginStartWorkflowDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndStartWorkflowDelegate;

		private SendOrPostCallback onStartWorkflowCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetProcessDefinitionsForItemsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetProcessDefinitionsForItemsDelegate;

		private SendOrPostCallback onGetProcessDefinitionsForItemsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSystemXsdDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSystemXsdDelegate;

		private SendOrPostCallback onGetSystemXsdCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSchemasByNamespaceUriDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSchemasByNamespaceUriDelegate;

		private SendOrPostCallback onGetSchemasByNamespaceUriCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginValidateDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndValidateDelegate;

		private SendOrPostCallback onValidateCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetExternalBinaryContentDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetExternalBinaryContentDataDelegate;

		private SendOrPostCallback onGetExternalBinaryContentDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSynchronizeWithSchemaDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSynchronizeWithSchemaDelegate;

		private SendOrPostCallback onSynchronizeWithSchemaCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSynchronizeWithSchemaAndUpdateDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSynchronizeWithSchemaAndUpdateDelegate;

		private SendOrPostCallback onSynchronizeWithSchemaAndUpdateCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginDecommissionPublicationTargetDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndDecommissionPublicationTargetDelegate;

		private SendOrPostCallback onDecommissionPublicationTargetCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginConvertXsdToSchemaFieldsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndConvertXsdToSchemaFieldsDelegate;

		private SendOrPostCallback onConvertXsdToSchemaFieldsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetPublishUrlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetPublishUrlDelegate;

		private SendOrPostCallback onGetPublishUrlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetBusinessProcessTypesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetBusinessProcessTypesDelegate;

		private SendOrPostCallback onGetBusinessProcessTypesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetPublishSourceByUrlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetPublishSourceByUrlDelegate;

		private SendOrPostCallback onGetPublishSourceByUrlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginRemovePublishStatesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndRemovePublishStatesDelegate;

		private SendOrPostCallback onRemovePublishStatesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginResolveContainingPagesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndResolveContainingPagesDelegate;

		private SendOrPostCallback onResolveContainingPagesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginPurgeWorkflowHistoryDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndPurgeWorkflowHistoryDelegate;

		private SendOrPostCallback onPurgeWorkflowHistoryCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginBroadcastNotificationDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndBroadcastNotificationDelegate;

		private SendOrPostCallback onBroadcastNotificationCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSystemPrivilegesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSystemPrivilegesDelegate;

		private SendOrPostCallback onGetSystemPrivilegesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetApiVersionDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetApiVersionDelegate;

		private SendOrPostCallback onGetApiVersionCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetCurrentUserDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetCurrentUserDelegate;

		private SendOrPostCallback onGetCurrentUserCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginIsExistingObjectDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndIsExistingObjectDelegate;

		private SendOrPostCallback onIsExistingObjectCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetTcmUriDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetTcmUriDelegate;

		private SendOrPostCallback onGetTcmUriCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginTryGetTcmUriDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndTryGetTcmUriDelegate;

		private SendOrPostCallback onTryGetTcmUriCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReadDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReadDelegate;

		private SendOrPostCallback onReadCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginTryReadDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndTryReadDelegate;

		private SendOrPostCallback onTryReadCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginBulkReadDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndBulkReadDelegate;

		private SendOrPostCallback onBulkReadCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReadSchemaFieldsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReadSchemaFieldsDelegate;

		private SendOrPostCallback onReadSchemaFieldsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginConvertSchemaFieldsToXsdDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndConvertSchemaFieldsToXsdDelegate;

		private SendOrPostCallback onConvertSchemaFieldsToXsdCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSaveDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSaveDelegate;

		private SendOrPostCallback onSaveCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginDeleteDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndDeleteDelegate;

		private SendOrPostCallback onDeleteCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginDeleteTaxonomyNodeDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndDeleteTaxonomyNodeDelegate;

		private SendOrPostCallback onDeleteTaxonomyNodeCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetDefaultDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetDefaultDataDelegate;

		private SendOrPostCallback onGetDefaultDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginMoveDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndMoveDelegate;

		private SendOrPostCallback onMoveCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginCopyDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndCopyDelegate;

		private SendOrPostCallback onCopyCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetInstanceDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetInstanceDataDelegate;

		private SendOrPostCallback onGetInstanceDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginTryCheckOutDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndTryCheckOutDelegate;

		private SendOrPostCallback onTryCheckOutCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginCheckOutDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndCheckOutDelegate;

		private SendOrPostCallback onCheckOutCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginCheckInDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndCheckInDelegate;

		private SendOrPostCallback onCheckInCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginUpdateDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndUpdateDelegate;

		private SendOrPostCallback onUpdateCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginCreateDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndCreateDelegate;

		private SendOrPostCallback onCreateCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginUndoCheckOutDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndUndoCheckOutDelegate;

		private SendOrPostCallback onUndoCheckOutCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginRollbackDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndRollbackDelegate;

		private SendOrPostCallback onRollbackCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginLocalizeDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndLocalizeDelegate;

		private SendOrPostCallback onLocalizeCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginUnLocalizeDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndUnLocalizeDelegate;

		private SendOrPostCallback onUnLocalizeCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginPromoteDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndPromoteDelegate;

		private SendOrPostCallback onPromoteCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginDemoteDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndDemoteDelegate;

		private SendOrPostCallback onDemoteCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListTemplateTypesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListTemplateTypesDelegate;

		private SendOrPostCallback onGetListTemplateTypesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListPublicationTypesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListPublicationTypesDelegate;

		private SendOrPostCallback onGetListPublicationTypesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSystemWideListXmlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSystemWideListXmlDelegate;

		private SendOrPostCallback onGetSystemWideListXmlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSystemWideListDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSystemWideListDelegate;

		private SendOrPostCallback onGetSystemWideListCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListXmlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListXmlDelegate;

		private SendOrPostCallback onGetListXmlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListDelegate;

		private SendOrPostCallback onGetListCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceNamesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListDirectoryServiceNamesDelegate;

		private SendOrPostCallback onGetListDirectoryServiceNamesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListWindowsDomainUsersDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListWindowsDomainUsersDelegate;

		private SendOrPostCallback onGetListWindowsDomainUsersCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceAllUsersDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListDirectoryServiceAllUsersDelegate;

		private SendOrPostCallback onGetListDirectoryServiceAllUsersCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceGroupMembersDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListDirectoryServiceGroupMembersDelegate;

		private SendOrPostCallback onGetListDirectoryServiceGroupMembersCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceUsersDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListDirectoryServiceUsersDelegate;

		private SendOrPostCallback onGetListDirectoryServiceUsersCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginClassifyDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndClassifyDelegate;

		private SendOrPostCallback onClassifyCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginUnClassifyDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndUnClassifyDelegate;

		private SendOrPostCallback onUnClassifyCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReClassifyDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReClassifyDelegate;

		private SendOrPostCallback onReClassifyCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginStartActivityDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndStartActivityDelegate;

		private SendOrPostCallback onStartActivityCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSuspendActivityDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSuspendActivityDelegate;

		private SendOrPostCallback onSuspendActivityCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginRestartActivityDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndRestartActivityDelegate;

		private SendOrPostCallback onRestartActivityCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReAssignActivityDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReAssignActivityDelegate;

		private SendOrPostCallback onReAssignActivityCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginFinishActivityDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndFinishActivityDelegate;

		private SendOrPostCallback onFinishActivityCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginForceFinishProcessDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndForceFinishProcessDelegate;

		private SendOrPostCallback onForceFinishProcessCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginResumeActivityDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndResumeActivityDelegate;

		private SendOrPostCallback onResumeActivityCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListQueueMessagesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListQueueMessagesDelegate;

		private SendOrPostCallback onGetListQueueMessagesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginPurgeQueueDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndPurgeQueueDelegate;

		private SendOrPostCallback onPurgeQueueCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListQueuesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListQueuesDelegate;

		private SendOrPostCallback onGetListQueuesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReadApplicationDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReadApplicationDataDelegate;

		private SendOrPostCallback onReadApplicationDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReadAllApplicationDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReadAllApplicationDataDelegate;

		private SendOrPostCallback onReadAllApplicationDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSaveApplicationDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSaveApplicationDataDelegate;

		private SendOrPostCallback onSaveApplicationDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginDeleteApplicationDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndDeleteApplicationDataDelegate;

		private SendOrPostCallback onDeleteApplicationDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetApplicationIdsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetApplicationIdsDelegate;

		private SendOrPostCallback onGetApplicationIdsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginPurgeApplicationDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndPurgeApplicationDataDelegate;

		private SendOrPostCallback onPurgeApplicationDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginParsePredefinedBatchOperationDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndParsePredefinedBatchOperationDelegate;

		private SendOrPostCallback onParsePredefinedBatchOperationCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetPredefinedBatchOperationNameDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetPredefinedBatchOperationNameDelegate;

		private SendOrPostCallback onGetPredefinedBatchOperationNameCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginResolveItemsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndResolveItemsDelegate;

		private SendOrPostCallback onResolveItemsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSearchResultsXmlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSearchResultsXmlDelegate;

		private SendOrPostCallback onGetSearchResultsXmlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSearchResultsXmlPagedDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSearchResultsXmlPagedDelegate;

		private SendOrPostCallback onGetSearchResultsXmlPagedCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSearchResultsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSearchResultsDelegate;

		private SendOrPostCallback onGetSearchResultsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSearchResultsPagedDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSearchResultsPagedDelegate;

		private SendOrPostCallback onGetSearchResultsPagedCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginRenderItemDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndRenderItemDelegate;

		private SendOrPostCallback onRenderItemCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginPreviewItemDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndPreviewItemDelegate;

		private SendOrPostCallback onPreviewItemCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginPublishDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndPublishDelegate;

		private SendOrPostCallback onPublishCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginUnPublishDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndUnPublishDelegate;

		private SendOrPostCallback onUnPublishCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginIsPublishedDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndIsPublishedDelegate;

		private SendOrPostCallback onIsPublishedCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetWorkItemSnapshotDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetWorkItemSnapshotDelegate;

		private SendOrPostCallback onGetWorkItemSnapshotCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListPublishInfoDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListPublishInfoDelegate;

		private SendOrPostCallback onGetListPublishInfoCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginCastActionsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndCastActionsDelegate;

		private SendOrPostCallback onCastActionsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginValidateXmlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndValidateXmlDelegate;

		private SendOrPostCallback onValidateXmlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginIsValidTridionWebSchemaXmlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndIsValidTridionWebSchemaXmlDelegate;

		private SendOrPostCallback onIsValidTridionWebSchemaXmlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSubjectIdsWithApplicationDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSubjectIdsWithApplicationDataDelegate;

		private SendOrPostCallback onGetSubjectIdsWithApplicationDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReadApplicationDataForSubjectsIdsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReadApplicationDataForSubjectsIdsDelegate;

		private SendOrPostCallback onReadApplicationDataForSubjectsIdsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSecurityDescriptorsForSubjectsIdsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSecurityDescriptorsForSubjectsIdsDelegate;

		private SendOrPostCallback onGetSecurityDescriptorsForSubjectsIdsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetContentSecurityDescriptorsForOrgItemIdsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetContentSecurityDescriptorsForOrgItemIdsDelegate;

		private SendOrPostCallback onGetContentSecurityDescriptorsForOrgItemIdsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginReIndexDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndReIndexDelegate;

		private SendOrPostCallback onReIndexCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginCastPredefinedQueueDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndCastPredefinedQueueDelegate;

		private SendOrPostCallback onCastPredefinedQueueCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginPurgeOldVersionsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndPurgeOldVersionsDelegate;

		private SendOrPostCallback onPurgeOldVersionsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetListExternalLinksDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetListExternalLinksDelegate;

		private SendOrPostCallback onGetListExternalLinksCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginConvertXmlToSearchQueryDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndConvertXmlToSearchQueryDelegate;

		private SendOrPostCallback onConvertXmlToSearchQueryCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginConvertSearchQueryToXmlDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndConvertSearchQueryToXmlDelegate;

		private SendOrPostCallback onConvertSearchQueryToXmlCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginImpersonateDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndImpersonateDelegate;

		private SendOrPostCallback onImpersonateCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginImpersonateWithTokenDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndImpersonateWithTokenDelegate;

		private SendOrPostCallback onImpersonateWithTokenCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginImpersonateWithClaimsDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndImpersonateWithClaimsDelegate;

		private SendOrPostCallback onImpersonateWithClaimsCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginTerminateSessionDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndTerminateSessionDelegate;

		private SendOrPostCallback onTerminateSessionCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSessionIdDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSessionIdDelegate;

		private SendOrPostCallback onGetSessionIdCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSetSessionContextDataDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSetSessionContextDataDelegate;

		private SendOrPostCallback onSetSessionContextDataCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSetSessionTransactionTimeoutDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSetSessionTransactionTimeoutDelegate;

		private SendOrPostCallback onSetSessionTransactionTimeoutCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginGetSessionTransactionTimeoutDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndGetSessionTransactionTimeoutDelegate;

		private SendOrPostCallback onGetSessionTransactionTimeoutCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginStartCachingDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndStartCachingDelegate;

		private SendOrPostCallback onStartCachingCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginStopCachingDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndStopCachingDelegate;

		private SendOrPostCallback onStopCachingCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginSetWebDavUrlPrefixDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndSetWebDavUrlPrefixDelegate;

		private SendOrPostCallback onSetWebDavUrlPrefixCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginEnlistInTransactionDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndEnlistInTransactionDelegate;

		private SendOrPostCallback onEnlistInTransactionCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginElevatePrivilegesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndElevatePrivilegesDelegate;

		private SendOrPostCallback onElevatePrivilegesCompletedDelegate;

		private ClientBase<ISessionAwareCoreService>.BeginOperationDelegate onBeginRestorePrivilegesDelegate;

		private ClientBase<ISessionAwareCoreService>.EndOperationDelegate onEndRestorePrivilegesDelegate;

		private SendOrPostCallback onRestorePrivilegesCompletedDelegate;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetVirtualFolderTypeSchemaCompletedEventArgs> GetVirtualFolderTypeSchemaCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetEnumValuesCompletedEventArgs> GetEnumValuesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ResolveBundleTypesCompletedEventArgs> ResolveBundleTypesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<CopyToKeywordCompletedEventArgs> CopyToKeywordCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<MoveToKeywordCompletedEventArgs> MoveToKeywordCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetTridionLanguagesCompletedEventArgs> GetTridionLanguagesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListWorkflowScriptTypesCompletedEventArgs> GetListWorkflowScriptTypesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AddToWorkflowCompletedEventArgs> AddToWorkflowCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<RemoveFromWorkflowCompletedEventArgs> RemoveFromWorkflowCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<LockCompletedEventArgs> LockCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UnlockCompletedEventArgs> UnlockCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<StartWorkflowCompletedEventArgs> StartWorkflowCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetProcessDefinitionsForItemsCompletedEventArgs> GetProcessDefinitionsForItemsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSystemXsdCompletedEventArgs> GetSystemXsdCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSchemasByNamespaceUriCompletedEventArgs> GetSchemasByNamespaceUriCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ValidateCompletedEventArgs> ValidateCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetExternalBinaryContentDataCompletedEventArgs> GetExternalBinaryContentDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<SynchronizeWithSchemaCompletedEventArgs> SynchronizeWithSchemaCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<SynchronizeWithSchemaAndUpdateCompletedEventArgs> SynchronizeWithSchemaAndUpdateCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> DecommissionPublicationTargetCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ConvertXsdToSchemaFieldsCompletedEventArgs> ConvertXsdToSchemaFieldsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetPublishUrlCompletedEventArgs> GetPublishUrlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetBusinessProcessTypesCompletedEventArgs> GetBusinessProcessTypesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetPublishSourceByUrlCompletedEventArgs> GetPublishSourceByUrlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> RemovePublishStatesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ResolveContainingPagesCompletedEventArgs> ResolveContainingPagesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> PurgeWorkflowHistoryCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> BroadcastNotificationCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSystemPrivilegesCompletedEventArgs> GetSystemPrivilegesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetApiVersionCompletedEventArgs> GetApiVersionCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetCurrentUserCompletedEventArgs> GetCurrentUserCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<IsExistingObjectCompletedEventArgs> IsExistingObjectCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetTcmUriCompletedEventArgs> GetTcmUriCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<TryGetTcmUriCompletedEventArgs> TryGetTcmUriCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ReadCompletedEventArgs> ReadCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<TryReadCompletedEventArgs> TryReadCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<BulkReadCompletedEventArgs> BulkReadCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ReadSchemaFieldsCompletedEventArgs> ReadSchemaFieldsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ConvertSchemaFieldsToXsdCompletedEventArgs> ConvertSchemaFieldsToXsdCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<SaveCompletedEventArgs> SaveCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> DeleteCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> DeleteTaxonomyNodeCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetDefaultDataCompletedEventArgs> GetDefaultDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<MoveCompletedEventArgs> MoveCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<CopyCompletedEventArgs> CopyCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetInstanceDataCompletedEventArgs> GetInstanceDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<TryCheckOutCompletedEventArgs> TryCheckOutCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<CheckOutCompletedEventArgs> CheckOutCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<CheckInCompletedEventArgs> CheckInCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UpdateCompletedEventArgs> UpdateCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<CreateCompletedEventArgs> CreateCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UndoCheckOutCompletedEventArgs> UndoCheckOutCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<RollbackCompletedEventArgs> RollbackCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<LocalizeCompletedEventArgs> LocalizeCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UnLocalizeCompletedEventArgs> UnLocalizeCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<PromoteCompletedEventArgs> PromoteCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<DemoteCompletedEventArgs> DemoteCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListTemplateTypesCompletedEventArgs> GetListTemplateTypesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListPublicationTypesCompletedEventArgs> GetListPublicationTypesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSystemWideListXmlCompletedEventArgs> GetSystemWideListXmlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSystemWideListCompletedEventArgs> GetSystemWideListCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListXmlCompletedEventArgs> GetListXmlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListCompletedEventArgs> GetListCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListDirectoryServiceNamesCompletedEventArgs> GetListDirectoryServiceNamesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListWindowsDomainUsersCompletedEventArgs> GetListWindowsDomainUsersCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListDirectoryServiceAllUsersCompletedEventArgs> GetListDirectoryServiceAllUsersCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListDirectoryServiceGroupMembersCompletedEventArgs> GetListDirectoryServiceGroupMembersCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListDirectoryServiceUsersCompletedEventArgs> GetListDirectoryServiceUsersCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ClassifyCompletedEventArgs> ClassifyCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UnClassifyCompletedEventArgs> UnClassifyCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ReClassifyCompletedEventArgs> ReClassifyCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<StartActivityCompletedEventArgs> StartActivityCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<SuspendActivityCompletedEventArgs> SuspendActivityCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<RestartActivityCompletedEventArgs> RestartActivityCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ReAssignActivityCompletedEventArgs> ReAssignActivityCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<FinishActivityCompletedEventArgs> FinishActivityCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ForceFinishProcessCompletedEventArgs> ForceFinishProcessCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ResumeActivityCompletedEventArgs> ResumeActivityCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListQueueMessagesCompletedEventArgs> GetListQueueMessagesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> PurgeQueueCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListQueuesCompletedEventArgs> GetListQueuesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ReadApplicationDataCompletedEventArgs> ReadApplicationDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ReadAllApplicationDataCompletedEventArgs> ReadAllApplicationDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> SaveApplicationDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> DeleteApplicationDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetApplicationIdsCompletedEventArgs> GetApplicationIdsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> PurgeApplicationDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ParsePredefinedBatchOperationCompletedEventArgs> ParsePredefinedBatchOperationCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetPredefinedBatchOperationNameCompletedEventArgs> GetPredefinedBatchOperationNameCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ResolveItemsCompletedEventArgs> ResolveItemsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSearchResultsXmlCompletedEventArgs> GetSearchResultsXmlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSearchResultsXmlPagedCompletedEventArgs> GetSearchResultsXmlPagedCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSearchResultsCompletedEventArgs> GetSearchResultsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSearchResultsPagedCompletedEventArgs> GetSearchResultsPagedCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<RenderItemCompletedEventArgs> RenderItemCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<PreviewItemCompletedEventArgs> PreviewItemCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<PublishCompletedEventArgs> PublishCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UnPublishCompletedEventArgs> UnPublishCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<IsPublishedCompletedEventArgs> IsPublishedCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetWorkItemSnapshotCompletedEventArgs> GetWorkItemSnapshotCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListPublishInfoCompletedEventArgs> GetListPublishInfoCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<CastActionsCompletedEventArgs> CastActionsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> ValidateXmlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<IsValidTridionWebSchemaXmlCompletedEventArgs> IsValidTridionWebSchemaXmlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSubjectIdsWithApplicationDataCompletedEventArgs> GetSubjectIdsWithApplicationDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ReadApplicationDataForSubjectsIdsCompletedEventArgs> ReadApplicationDataForSubjectsIdsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSecurityDescriptorsForSubjectsIdsCompletedEventArgs> GetSecurityDescriptorsForSubjectsIdsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetContentSecurityDescriptorsForOrgItemIdsCompletedEventArgs> GetContentSecurityDescriptorsForOrgItemIdsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> ReIndexCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<CastPredefinedQueueCompletedEventArgs> CastPredefinedQueueCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<PurgeOldVersionsCompletedEventArgs> PurgeOldVersionsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetListExternalLinksCompletedEventArgs> GetListExternalLinksCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ConvertXmlToSearchQueryCompletedEventArgs> ConvertXmlToSearchQueryCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ConvertSearchQueryToXmlCompletedEventArgs> ConvertSearchQueryToXmlCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ImpersonateCompletedEventArgs> ImpersonateCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> ImpersonateWithTokenCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ImpersonateWithClaimsCompletedEventArgs> ImpersonateWithClaimsCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> TerminateSessionCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSessionIdCompletedEventArgs> GetSessionIdCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> SetSessionContextDataCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> SetSessionTransactionTimeoutCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<GetSessionTransactionTimeoutCompletedEventArgs> GetSessionTransactionTimeoutCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<StartCachingCompletedEventArgs> StartCachingCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> StopCachingCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> SetWebDavUrlPrefixCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<AsyncCompletedEventArgs> EnlistInTransactionCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<ElevatePrivilegesCompletedEventArgs> ElevatePrivilegesCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<RestorePrivilegesCompletedEventArgs> RestorePrivilegesCompleted;

		public SessionAwareCoreServiceClient()
		{
		}

		public SessionAwareCoreServiceClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public SessionAwareCoreServiceClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public SessionAwareCoreServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public SessionAwareCoreServiceClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		public SchemaData GetVirtualFolderTypeSchema(string namespaceUri)
		{
			return base.Channel.GetVirtualFolderTypeSchema(namespaceUri);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetVirtualFolderTypeSchema(string namespaceUri, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetVirtualFolderTypeSchema(namespaceUri, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SchemaData EndGetVirtualFolderTypeSchema(IAsyncResult result)
		{
			return base.Channel.EndGetVirtualFolderTypeSchema(result);
		}

		private IAsyncResult OnBeginGetVirtualFolderTypeSchema(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string namespaceUri = (string)inValues[0];
			return this.BeginGetVirtualFolderTypeSchema(namespaceUri, callback, asyncState);
		}

		private object[] OnEndGetVirtualFolderTypeSchema(IAsyncResult result)
		{
			SchemaData schemaData = this.EndGetVirtualFolderTypeSchema(result);
			return new object[]
			{
				schemaData
			};
		}

		private void OnGetVirtualFolderTypeSchemaCompleted(object state)
		{
			if (this.GetVirtualFolderTypeSchemaCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetVirtualFolderTypeSchemaCompleted(this, new GetVirtualFolderTypeSchemaCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetVirtualFolderTypeSchemaAsync(string namespaceUri)
		{
			this.GetVirtualFolderTypeSchemaAsync(namespaceUri, null);
		}

		public void GetVirtualFolderTypeSchemaAsync(string namespaceUri, object userState)
		{
			if (this.onBeginGetVirtualFolderTypeSchemaDelegate == null)
			{
				this.onBeginGetVirtualFolderTypeSchemaDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetVirtualFolderTypeSchema);
			}
			if (this.onEndGetVirtualFolderTypeSchemaDelegate == null)
			{
				this.onEndGetVirtualFolderTypeSchemaDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetVirtualFolderTypeSchema);
			}
			if (this.onGetVirtualFolderTypeSchemaCompletedDelegate == null)
			{
				this.onGetVirtualFolderTypeSchemaCompletedDelegate = new SendOrPostCallback(this.OnGetVirtualFolderTypeSchemaCompleted);
			}
			base.InvokeAsync(this.onBeginGetVirtualFolderTypeSchemaDelegate, new object[]
			{
				namespaceUri
			}, this.onEndGetVirtualFolderTypeSchemaDelegate, this.onGetVirtualFolderTypeSchemaCompletedDelegate, userState);
		}

		public TridionEnumValue[] GetEnumValues(string type)
		{
			return base.Channel.GetEnumValues(type);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetEnumValues(string type, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetEnumValues(type, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public TridionEnumValue[] EndGetEnumValues(IAsyncResult result)
		{
			return base.Channel.EndGetEnumValues(result);
		}

		private IAsyncResult OnBeginGetEnumValues(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string type = (string)inValues[0];
			return this.BeginGetEnumValues(type, callback, asyncState);
		}

		private object[] OnEndGetEnumValues(IAsyncResult result)
		{
			TridionEnumValue[] array = this.EndGetEnumValues(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetEnumValuesCompleted(object state)
		{
			if (this.GetEnumValuesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetEnumValuesCompleted(this, new GetEnumValuesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetEnumValuesAsync(string type)
		{
			this.GetEnumValuesAsync(type, null);
		}

		public void GetEnumValuesAsync(string type, object userState)
		{
			if (this.onBeginGetEnumValuesDelegate == null)
			{
				this.onBeginGetEnumValuesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetEnumValues);
			}
			if (this.onEndGetEnumValuesDelegate == null)
			{
				this.onEndGetEnumValuesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetEnumValues);
			}
			if (this.onGetEnumValuesCompletedDelegate == null)
			{
				this.onGetEnumValuesCompletedDelegate = new SendOrPostCallback(this.OnGetEnumValuesCompleted);
			}
			base.InvokeAsync(this.onBeginGetEnumValuesDelegate, new object[]
			{
				type
			}, this.onEndGetEnumValuesDelegate, this.onGetEnumValuesCompletedDelegate, userState);
		}

		public BundleTypeData[] ResolveBundleTypes(string[] itemIds, bool pruneTree)
		{
			return base.Channel.ResolveBundleTypes(itemIds, pruneTree);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginResolveBundleTypes(string[] itemIds, bool pruneTree, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginResolveBundleTypes(itemIds, pruneTree, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public BundleTypeData[] EndResolveBundleTypes(IAsyncResult result)
		{
			return base.Channel.EndResolveBundleTypes(result);
		}

		private IAsyncResult OnBeginResolveBundleTypes(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] itemIds = (string[])inValues[0];
			bool pruneTree = (bool)inValues[1];
			return this.BeginResolveBundleTypes(itemIds, pruneTree, callback, asyncState);
		}

		private object[] OnEndResolveBundleTypes(IAsyncResult result)
		{
			BundleTypeData[] array = this.EndResolveBundleTypes(result);
			return new object[]
			{
				array
			};
		}

		private void OnResolveBundleTypesCompleted(object state)
		{
			if (this.ResolveBundleTypesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResolveBundleTypesCompleted(this, new ResolveBundleTypesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ResolveBundleTypesAsync(string[] itemIds, bool pruneTree)
		{
			this.ResolveBundleTypesAsync(itemIds, pruneTree, null);
		}

		public void ResolveBundleTypesAsync(string[] itemIds, bool pruneTree, object userState)
		{
			if (this.onBeginResolveBundleTypesDelegate == null)
			{
				this.onBeginResolveBundleTypesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginResolveBundleTypes);
			}
			if (this.onEndResolveBundleTypesDelegate == null)
			{
				this.onEndResolveBundleTypesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndResolveBundleTypes);
			}
			if (this.onResolveBundleTypesCompletedDelegate == null)
			{
				this.onResolveBundleTypesCompletedDelegate = new SendOrPostCallback(this.OnResolveBundleTypesCompleted);
			}
			base.InvokeAsync(this.onBeginResolveBundleTypesDelegate, new object[]
			{
				itemIds,
				pruneTree
			}, this.onEndResolveBundleTypesDelegate, this.onResolveBundleTypesCompletedDelegate, userState);
		}

		public KeywordData CopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
		{
			return base.Channel.CopyToKeyword(sourceKeywordId, destinationId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginCopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginCopyToKeyword(sourceKeywordId, destinationId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public KeywordData EndCopyToKeyword(IAsyncResult result)
		{
			return base.Channel.EndCopyToKeyword(result);
		}

		private IAsyncResult OnBeginCopyToKeyword(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string sourceKeywordId = (string)inValues[0];
			string destinationId = (string)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginCopyToKeyword(sourceKeywordId, destinationId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndCopyToKeyword(IAsyncResult result)
		{
			KeywordData keywordData = this.EndCopyToKeyword(result);
			return new object[]
			{
				keywordData
			};
		}

		private void OnCopyToKeywordCompleted(object state)
		{
			if (this.CopyToKeywordCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CopyToKeywordCompleted(this, new CopyToKeywordCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void CopyToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
		{
			this.CopyToKeywordAsync(sourceKeywordId, destinationId, readBackOptions, null);
		}

		public void CopyToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginCopyToKeywordDelegate == null)
			{
				this.onBeginCopyToKeywordDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginCopyToKeyword);
			}
			if (this.onEndCopyToKeywordDelegate == null)
			{
				this.onEndCopyToKeywordDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndCopyToKeyword);
			}
			if (this.onCopyToKeywordCompletedDelegate == null)
			{
				this.onCopyToKeywordCompletedDelegate = new SendOrPostCallback(this.OnCopyToKeywordCompleted);
			}
			base.InvokeAsync(this.onBeginCopyToKeywordDelegate, new object[]
			{
				sourceKeywordId,
				destinationId,
				readBackOptions
			}, this.onEndCopyToKeywordDelegate, this.onCopyToKeywordCompletedDelegate, userState);
		}

		public KeywordData MoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
		{
			return base.Channel.MoveToKeyword(sourceKeywordId, destinationId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginMoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginMoveToKeyword(sourceKeywordId, destinationId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public KeywordData EndMoveToKeyword(IAsyncResult result)
		{
			return base.Channel.EndMoveToKeyword(result);
		}

		private IAsyncResult OnBeginMoveToKeyword(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string sourceKeywordId = (string)inValues[0];
			string destinationId = (string)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginMoveToKeyword(sourceKeywordId, destinationId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndMoveToKeyword(IAsyncResult result)
		{
			KeywordData keywordData = this.EndMoveToKeyword(result);
			return new object[]
			{
				keywordData
			};
		}

		private void OnMoveToKeywordCompleted(object state)
		{
			if (this.MoveToKeywordCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.MoveToKeywordCompleted(this, new MoveToKeywordCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void MoveToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
		{
			this.MoveToKeywordAsync(sourceKeywordId, destinationId, readBackOptions, null);
		}

		public void MoveToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginMoveToKeywordDelegate == null)
			{
				this.onBeginMoveToKeywordDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginMoveToKeyword);
			}
			if (this.onEndMoveToKeywordDelegate == null)
			{
				this.onEndMoveToKeywordDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndMoveToKeyword);
			}
			if (this.onMoveToKeywordCompletedDelegate == null)
			{
				this.onMoveToKeywordCompletedDelegate = new SendOrPostCallback(this.OnMoveToKeywordCompleted);
			}
			base.InvokeAsync(this.onBeginMoveToKeywordDelegate, new object[]
			{
				sourceKeywordId,
				destinationId,
				readBackOptions
			}, this.onEndMoveToKeywordDelegate, this.onMoveToKeywordCompletedDelegate, userState);
		}

		public TridionLanguageInfo[] GetTridionLanguages()
		{
			return base.Channel.GetTridionLanguages();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetTridionLanguages(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetTridionLanguages(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public TridionLanguageInfo[] EndGetTridionLanguages(IAsyncResult result)
		{
			return base.Channel.EndGetTridionLanguages(result);
		}

		private IAsyncResult OnBeginGetTridionLanguages(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetTridionLanguages(callback, asyncState);
		}

		private object[] OnEndGetTridionLanguages(IAsyncResult result)
		{
			TridionLanguageInfo[] array = this.EndGetTridionLanguages(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetTridionLanguagesCompleted(object state)
		{
			if (this.GetTridionLanguagesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetTridionLanguagesCompleted(this, new GetTridionLanguagesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetTridionLanguagesAsync()
		{
			this.GetTridionLanguagesAsync(null);
		}

		public void GetTridionLanguagesAsync(object userState)
		{
			if (this.onBeginGetTridionLanguagesDelegate == null)
			{
				this.onBeginGetTridionLanguagesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetTridionLanguages);
			}
			if (this.onEndGetTridionLanguagesDelegate == null)
			{
				this.onEndGetTridionLanguagesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetTridionLanguages);
			}
			if (this.onGetTridionLanguagesCompletedDelegate == null)
			{
				this.onGetTridionLanguagesCompletedDelegate = new SendOrPostCallback(this.OnGetTridionLanguagesCompleted);
			}
			base.InvokeAsync(this.onBeginGetTridionLanguagesDelegate, null, this.onEndGetTridionLanguagesDelegate, this.onGetTridionLanguagesCompletedDelegate, userState);
		}

		public WorkflowScriptType[] GetListWorkflowScriptTypes()
		{
			return base.Channel.GetListWorkflowScriptTypes();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListWorkflowScriptTypes(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListWorkflowScriptTypes(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public WorkflowScriptType[] EndGetListWorkflowScriptTypes(IAsyncResult result)
		{
			return base.Channel.EndGetListWorkflowScriptTypes(result);
		}

		private IAsyncResult OnBeginGetListWorkflowScriptTypes(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetListWorkflowScriptTypes(callback, asyncState);
		}

		private object[] OnEndGetListWorkflowScriptTypes(IAsyncResult result)
		{
			WorkflowScriptType[] array = this.EndGetListWorkflowScriptTypes(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListWorkflowScriptTypesCompleted(object state)
		{
			if (this.GetListWorkflowScriptTypesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListWorkflowScriptTypesCompleted(this, new GetListWorkflowScriptTypesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListWorkflowScriptTypesAsync()
		{
			this.GetListWorkflowScriptTypesAsync(null);
		}

		public void GetListWorkflowScriptTypesAsync(object userState)
		{
			if (this.onBeginGetListWorkflowScriptTypesDelegate == null)
			{
				this.onBeginGetListWorkflowScriptTypesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListWorkflowScriptTypes);
			}
			if (this.onEndGetListWorkflowScriptTypesDelegate == null)
			{
				this.onEndGetListWorkflowScriptTypesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListWorkflowScriptTypes);
			}
			if (this.onGetListWorkflowScriptTypesCompletedDelegate == null)
			{
				this.onGetListWorkflowScriptTypesCompletedDelegate = new SendOrPostCallback(this.OnGetListWorkflowScriptTypesCompleted);
			}
			base.InvokeAsync(this.onBeginGetListWorkflowScriptTypesDelegate, null, this.onEndGetListWorkflowScriptTypesDelegate, this.onGetListWorkflowScriptTypesCompletedDelegate, userState);
		}

		public WorkItemData[] AddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions)
		{
			return base.Channel.AddToWorkflow(subjectIds, activityInstanceId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginAddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginAddToWorkflow(subjectIds, activityInstanceId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public WorkItemData[] EndAddToWorkflow(IAsyncResult result)
		{
			return base.Channel.EndAddToWorkflow(result);
		}

		private IAsyncResult OnBeginAddToWorkflow(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] subjectIds = (string[])inValues[0];
			string activityInstanceId = (string)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginAddToWorkflow(subjectIds, activityInstanceId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndAddToWorkflow(IAsyncResult result)
		{
			WorkItemData[] array = this.EndAddToWorkflow(result);
			return new object[]
			{
				array
			};
		}

		private void OnAddToWorkflowCompleted(object state)
		{
			if (this.AddToWorkflowCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.AddToWorkflowCompleted(this, new AddToWorkflowCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void AddToWorkflowAsync(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions)
		{
			this.AddToWorkflowAsync(subjectIds, activityInstanceId, readBackOptions, null);
		}

		public void AddToWorkflowAsync(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginAddToWorkflowDelegate == null)
			{
				this.onBeginAddToWorkflowDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginAddToWorkflow);
			}
			if (this.onEndAddToWorkflowDelegate == null)
			{
				this.onEndAddToWorkflowDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndAddToWorkflow);
			}
			if (this.onAddToWorkflowCompletedDelegate == null)
			{
				this.onAddToWorkflowCompletedDelegate = new SendOrPostCallback(this.OnAddToWorkflowCompleted);
			}
			base.InvokeAsync(this.onBeginAddToWorkflowDelegate, new object[]
			{
				subjectIds,
				activityInstanceId,
				readBackOptions
			}, this.onEndAddToWorkflowDelegate, this.onAddToWorkflowCompletedDelegate, userState);
		}

		public WorkItemData[] RemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions)
		{
			return base.Channel.RemoveFromWorkflow(subjectIds, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginRemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginRemoveFromWorkflow(subjectIds, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public WorkItemData[] EndRemoveFromWorkflow(IAsyncResult result)
		{
			return base.Channel.EndRemoveFromWorkflow(result);
		}

		private IAsyncResult OnBeginRemoveFromWorkflow(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] subjectIds = (string[])inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginRemoveFromWorkflow(subjectIds, readBackOptions, callback, asyncState);
		}

		private object[] OnEndRemoveFromWorkflow(IAsyncResult result)
		{
			WorkItemData[] array = this.EndRemoveFromWorkflow(result);
			return new object[]
			{
				array
			};
		}

		private void OnRemoveFromWorkflowCompleted(object state)
		{
			if (this.RemoveFromWorkflowCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RemoveFromWorkflowCompleted(this, new RemoveFromWorkflowCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void RemoveFromWorkflowAsync(string[] subjectIds, ReadOptions readBackOptions)
		{
			this.RemoveFromWorkflowAsync(subjectIds, readBackOptions, null);
		}

		public void RemoveFromWorkflowAsync(string[] subjectIds, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginRemoveFromWorkflowDelegate == null)
			{
				this.onBeginRemoveFromWorkflowDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginRemoveFromWorkflow);
			}
			if (this.onEndRemoveFromWorkflowDelegate == null)
			{
				this.onEndRemoveFromWorkflowDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndRemoveFromWorkflow);
			}
			if (this.onRemoveFromWorkflowCompletedDelegate == null)
			{
				this.onRemoveFromWorkflowCompletedDelegate = new SendOrPostCallback(this.OnRemoveFromWorkflowCompleted);
			}
			base.InvokeAsync(this.onBeginRemoveFromWorkflowDelegate, new object[]
			{
				subjectIds,
				readBackOptions
			}, this.onEndRemoveFromWorkflowDelegate, this.onRemoveFromWorkflowCompletedDelegate, userState);
		}

		public OrganizationalItemData Lock(string organizationalItemId, ReadOptions readBackOptions)
		{
			return base.Channel.Lock(organizationalItemId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginLock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginLock(organizationalItemId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public OrganizationalItemData EndLock(IAsyncResult result)
		{
			return base.Channel.EndLock(result);
		}

		private IAsyncResult OnBeginLock(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string organizationalItemId = (string)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginLock(organizationalItemId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndLock(IAsyncResult result)
		{
			OrganizationalItemData organizationalItemData = this.EndLock(result);
			return new object[]
			{
				organizationalItemData
			};
		}

		private void OnLockCompleted(object state)
		{
			if (this.LockCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.LockCompleted(this, new LockCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void LockAsync(string organizationalItemId, ReadOptions readBackOptions)
		{
			this.LockAsync(organizationalItemId, readBackOptions, null);
		}

		public void LockAsync(string organizationalItemId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginLockDelegate == null)
			{
				this.onBeginLockDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginLock);
			}
			if (this.onEndLockDelegate == null)
			{
				this.onEndLockDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndLock);
			}
			if (this.onLockCompletedDelegate == null)
			{
				this.onLockCompletedDelegate = new SendOrPostCallback(this.OnLockCompleted);
			}
			base.InvokeAsync(this.onBeginLockDelegate, new object[]
			{
				organizationalItemId,
				readBackOptions
			}, this.onEndLockDelegate, this.onLockCompletedDelegate, userState);
		}

		public OrganizationalItemData Unlock(string organizationalItemId, ReadOptions readBackOptions)
		{
			return base.Channel.Unlock(organizationalItemId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUnlock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUnlock(organizationalItemId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public OrganizationalItemData EndUnlock(IAsyncResult result)
		{
			return base.Channel.EndUnlock(result);
		}

		private IAsyncResult OnBeginUnlock(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string organizationalItemId = (string)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginUnlock(organizationalItemId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndUnlock(IAsyncResult result)
		{
			OrganizationalItemData organizationalItemData = this.EndUnlock(result);
			return new object[]
			{
				organizationalItemData
			};
		}

		private void OnUnlockCompleted(object state)
		{
			if (this.UnlockCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnlockCompleted(this, new UnlockCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UnlockAsync(string organizationalItemId, ReadOptions readBackOptions)
		{
			this.UnlockAsync(organizationalItemId, readBackOptions, null);
		}

		public void UnlockAsync(string organizationalItemId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginUnlockDelegate == null)
			{
				this.onBeginUnlockDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginUnlock);
			}
			if (this.onEndUnlockDelegate == null)
			{
				this.onEndUnlockDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndUnlock);
			}
			if (this.onUnlockCompletedDelegate == null)
			{
				this.onUnlockCompletedDelegate = new SendOrPostCallback(this.OnUnlockCompleted);
			}
			base.InvokeAsync(this.onBeginUnlockDelegate, new object[]
			{
				organizationalItemId,
				readBackOptions
			}, this.onEndUnlockDelegate, this.onUnlockCompletedDelegate, userState);
		}

		public ProcessInstanceData StartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions)
		{
			return base.Channel.StartWorkflow(repositoryId, instruction, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginStartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginStartWorkflow(repositoryId, instruction, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ProcessInstanceData EndStartWorkflow(IAsyncResult result)
		{
			return base.Channel.EndStartWorkflow(result);
		}

		private IAsyncResult OnBeginStartWorkflow(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string repositoryId = (string)inValues[0];
			StartWorkflowInstructionData instruction = (StartWorkflowInstructionData)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginStartWorkflow(repositoryId, instruction, readBackOptions, callback, asyncState);
		}

		private object[] OnEndStartWorkflow(IAsyncResult result)
		{
			ProcessInstanceData processInstanceData = this.EndStartWorkflow(result);
			return new object[]
			{
				processInstanceData
			};
		}

		private void OnStartWorkflowCompleted(object state)
		{
			if (this.StartWorkflowCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.StartWorkflowCompleted(this, new StartWorkflowCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void StartWorkflowAsync(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions)
		{
			this.StartWorkflowAsync(repositoryId, instruction, readBackOptions, null);
		}

		public void StartWorkflowAsync(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginStartWorkflowDelegate == null)
			{
				this.onBeginStartWorkflowDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginStartWorkflow);
			}
			if (this.onEndStartWorkflowDelegate == null)
			{
				this.onEndStartWorkflowDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndStartWorkflow);
			}
			if (this.onStartWorkflowCompletedDelegate == null)
			{
				this.onStartWorkflowCompletedDelegate = new SendOrPostCallback(this.OnStartWorkflowCompleted);
			}
			base.InvokeAsync(this.onBeginStartWorkflowDelegate, new object[]
			{
				repositoryId,
				instruction,
				readBackOptions
			}, this.onEndStartWorkflowDelegate, this.onStartWorkflowCompletedDelegate, userState);
		}

		public ProcessDefinitionAssociationDictionary GetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType)
		{
			return base.Channel.GetProcessDefinitionsForItems(itemIds, processDefinitionType);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetProcessDefinitionsForItems(itemIds, processDefinitionType, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ProcessDefinitionAssociationDictionary EndGetProcessDefinitionsForItems(IAsyncResult result)
		{
			return base.Channel.EndGetProcessDefinitionsForItems(result);
		}

		private IAsyncResult OnBeginGetProcessDefinitionsForItems(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] itemIds = (string[])inValues[0];
			ProcessDefinitionType processDefinitionType = (ProcessDefinitionType)inValues[1];
			return this.BeginGetProcessDefinitionsForItems(itemIds, processDefinitionType, callback, asyncState);
		}

		private object[] OnEndGetProcessDefinitionsForItems(IAsyncResult result)
		{
			ProcessDefinitionAssociationDictionary processDefinitionAssociationDictionary = this.EndGetProcessDefinitionsForItems(result);
			return new object[]
			{
				processDefinitionAssociationDictionary
			};
		}

		private void OnGetProcessDefinitionsForItemsCompleted(object state)
		{
			if (this.GetProcessDefinitionsForItemsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetProcessDefinitionsForItemsCompleted(this, new GetProcessDefinitionsForItemsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetProcessDefinitionsForItemsAsync(string[] itemIds, ProcessDefinitionType processDefinitionType)
		{
			this.GetProcessDefinitionsForItemsAsync(itemIds, processDefinitionType, null);
		}

		public void GetProcessDefinitionsForItemsAsync(string[] itemIds, ProcessDefinitionType processDefinitionType, object userState)
		{
			if (this.onBeginGetProcessDefinitionsForItemsDelegate == null)
			{
				this.onBeginGetProcessDefinitionsForItemsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetProcessDefinitionsForItems);
			}
			if (this.onEndGetProcessDefinitionsForItemsDelegate == null)
			{
				this.onEndGetProcessDefinitionsForItemsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetProcessDefinitionsForItems);
			}
			if (this.onGetProcessDefinitionsForItemsCompletedDelegate == null)
			{
				this.onGetProcessDefinitionsForItemsCompletedDelegate = new SendOrPostCallback(this.OnGetProcessDefinitionsForItemsCompleted);
			}
			base.InvokeAsync(this.onBeginGetProcessDefinitionsForItemsDelegate, new object[]
			{
				itemIds,
				processDefinitionType
			}, this.onEndGetProcessDefinitionsForItemsDelegate, this.onGetProcessDefinitionsForItemsCompletedDelegate, userState);
		}

		public string GetSystemXsd(string filename)
		{
			return base.Channel.GetSystemXsd(filename);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSystemXsd(string filename, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSystemXsd(filename, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndGetSystemXsd(IAsyncResult result)
		{
			return base.Channel.EndGetSystemXsd(result);
		}

		private IAsyncResult OnBeginGetSystemXsd(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string filename = (string)inValues[0];
			return this.BeginGetSystemXsd(filename, callback, asyncState);
		}

		private object[] OnEndGetSystemXsd(IAsyncResult result)
		{
			string text = this.EndGetSystemXsd(result);
			return new object[]
			{
				text
			};
		}

		private void OnGetSystemXsdCompleted(object state)
		{
			if (this.GetSystemXsdCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSystemXsdCompleted(this, new GetSystemXsdCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSystemXsdAsync(string filename)
		{
			this.GetSystemXsdAsync(filename, null);
		}

		public void GetSystemXsdAsync(string filename, object userState)
		{
			if (this.onBeginGetSystemXsdDelegate == null)
			{
				this.onBeginGetSystemXsdDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSystemXsd);
			}
			if (this.onEndGetSystemXsdDelegate == null)
			{
				this.onEndGetSystemXsdDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSystemXsd);
			}
			if (this.onGetSystemXsdCompletedDelegate == null)
			{
				this.onGetSystemXsdCompletedDelegate = new SendOrPostCallback(this.OnGetSystemXsdCompleted);
			}
			base.InvokeAsync(this.onBeginGetSystemXsdDelegate, new object[]
			{
				filename
			}, this.onEndGetSystemXsdDelegate, this.onGetSystemXsdCompletedDelegate, userState);
		}

		public LinkToSchemaData[] GetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName)
		{
			return base.Channel.GetSchemasByNamespaceUri(repositoryId, namespaceUri, rootElementName);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSchemasByNamespaceUri(repositoryId, namespaceUri, rootElementName, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public LinkToSchemaData[] EndGetSchemasByNamespaceUri(IAsyncResult result)
		{
			return base.Channel.EndGetSchemasByNamespaceUri(result);
		}

		private IAsyncResult OnBeginGetSchemasByNamespaceUri(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string repositoryId = (string)inValues[0];
			string namespaceUri = (string)inValues[1];
			string rootElementName = (string)inValues[2];
			return this.BeginGetSchemasByNamespaceUri(repositoryId, namespaceUri, rootElementName, callback, asyncState);
		}

		private object[] OnEndGetSchemasByNamespaceUri(IAsyncResult result)
		{
			LinkToSchemaData[] array = this.EndGetSchemasByNamespaceUri(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetSchemasByNamespaceUriCompleted(object state)
		{
			if (this.GetSchemasByNamespaceUriCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSchemasByNamespaceUriCompleted(this, new GetSchemasByNamespaceUriCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSchemasByNamespaceUriAsync(string repositoryId, string namespaceUri, string rootElementName)
		{
			this.GetSchemasByNamespaceUriAsync(repositoryId, namespaceUri, rootElementName, null);
		}

		public void GetSchemasByNamespaceUriAsync(string repositoryId, string namespaceUri, string rootElementName, object userState)
		{
			if (this.onBeginGetSchemasByNamespaceUriDelegate == null)
			{
				this.onBeginGetSchemasByNamespaceUriDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSchemasByNamespaceUri);
			}
			if (this.onEndGetSchemasByNamespaceUriDelegate == null)
			{
				this.onEndGetSchemasByNamespaceUriDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSchemasByNamespaceUri);
			}
			if (this.onGetSchemasByNamespaceUriCompletedDelegate == null)
			{
				this.onGetSchemasByNamespaceUriCompletedDelegate = new SendOrPostCallback(this.OnGetSchemasByNamespaceUriCompleted);
			}
			base.InvokeAsync(this.onBeginGetSchemasByNamespaceUriDelegate, new object[]
			{
				repositoryId,
				namespaceUri,
				rootElementName
			}, this.onEndGetSchemasByNamespaceUriDelegate, this.onGetSchemasByNamespaceUriCompletedDelegate, userState);
		}

		public ValidationErrorData[] Validate(IdentifiableObjectData deltaData)
		{
			return base.Channel.Validate(deltaData);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginValidate(IdentifiableObjectData deltaData, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginValidate(deltaData, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ValidationErrorData[] EndValidate(IAsyncResult result)
		{
			return base.Channel.EndValidate(result);
		}

		private IAsyncResult OnBeginValidate(object[] inValues, AsyncCallback callback, object asyncState)
		{
			IdentifiableObjectData deltaData = (IdentifiableObjectData)inValues[0];
			return this.BeginValidate(deltaData, callback, asyncState);
		}

		private object[] OnEndValidate(IAsyncResult result)
		{
			ValidationErrorData[] array = this.EndValidate(result);
			return new object[]
			{
				array
			};
		}

		private void OnValidateCompleted(object state)
		{
			if (this.ValidateCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ValidateCompleted(this, new ValidateCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ValidateAsync(IdentifiableObjectData deltaData)
		{
			this.ValidateAsync(deltaData, null);
		}

		public void ValidateAsync(IdentifiableObjectData deltaData, object userState)
		{
			if (this.onBeginValidateDelegate == null)
			{
				this.onBeginValidateDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginValidate);
			}
			if (this.onEndValidateDelegate == null)
			{
				this.onEndValidateDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndValidate);
			}
			if (this.onValidateCompletedDelegate == null)
			{
				this.onValidateCompletedDelegate = new SendOrPostCallback(this.OnValidateCompleted);
			}
			base.InvokeAsync(this.onBeginValidateDelegate, new object[]
			{
				deltaData
			}, this.onEndValidateDelegate, this.onValidateCompletedDelegate, userState);
		}

		public BinaryContentData GetExternalBinaryContentData(string uri)
		{
			return base.Channel.GetExternalBinaryContentData(uri);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetExternalBinaryContentData(string uri, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetExternalBinaryContentData(uri, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public BinaryContentData EndGetExternalBinaryContentData(IAsyncResult result)
		{
			return base.Channel.EndGetExternalBinaryContentData(result);
		}

		private IAsyncResult OnBeginGetExternalBinaryContentData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string uri = (string)inValues[0];
			return this.BeginGetExternalBinaryContentData(uri, callback, asyncState);
		}

		private object[] OnEndGetExternalBinaryContentData(IAsyncResult result)
		{
			BinaryContentData binaryContentData = this.EndGetExternalBinaryContentData(result);
			return new object[]
			{
				binaryContentData
			};
		}

		private void OnGetExternalBinaryContentDataCompleted(object state)
		{
			if (this.GetExternalBinaryContentDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetExternalBinaryContentDataCompleted(this, new GetExternalBinaryContentDataCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetExternalBinaryContentDataAsync(string uri)
		{
			this.GetExternalBinaryContentDataAsync(uri, null);
		}

		public void GetExternalBinaryContentDataAsync(string uri, object userState)
		{
			if (this.onBeginGetExternalBinaryContentDataDelegate == null)
			{
				this.onBeginGetExternalBinaryContentDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetExternalBinaryContentData);
			}
			if (this.onEndGetExternalBinaryContentDataDelegate == null)
			{
				this.onEndGetExternalBinaryContentDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetExternalBinaryContentData);
			}
			if (this.onGetExternalBinaryContentDataCompletedDelegate == null)
			{
				this.onGetExternalBinaryContentDataCompletedDelegate = new SendOrPostCallback(this.OnGetExternalBinaryContentDataCompleted);
			}
			base.InvokeAsync(this.onBeginGetExternalBinaryContentDataDelegate, new object[]
			{
				uri
			}, this.onEndGetExternalBinaryContentDataDelegate, this.onGetExternalBinaryContentDataCompletedDelegate, userState);
		}

		public SynchronizationResult SynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions)
		{
			return base.Channel.SynchronizeWithSchema(dataObject, synchronizeOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSynchronizeWithSchema(dataObject, synchronizeOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SynchronizationResult EndSynchronizeWithSchema(IAsyncResult result)
		{
			return base.Channel.EndSynchronizeWithSchema(result);
		}

		private IAsyncResult OnBeginSynchronizeWithSchema(object[] inValues, AsyncCallback callback, object asyncState)
		{
			IdentifiableObjectData dataObject = (IdentifiableObjectData)inValues[0];
			SynchronizeOptions synchronizeOptions = (SynchronizeOptions)inValues[1];
			return this.BeginSynchronizeWithSchema(dataObject, synchronizeOptions, callback, asyncState);
		}

		private object[] OnEndSynchronizeWithSchema(IAsyncResult result)
		{
			SynchronizationResult synchronizationResult = this.EndSynchronizeWithSchema(result);
			return new object[]
			{
				synchronizationResult
			};
		}

		private void OnSynchronizeWithSchemaCompleted(object state)
		{
			if (this.SynchronizeWithSchemaCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SynchronizeWithSchemaCompleted(this, new SynchronizeWithSchemaCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SynchronizeWithSchemaAsync(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions)
		{
			this.SynchronizeWithSchemaAsync(dataObject, synchronizeOptions, null);
		}

		public void SynchronizeWithSchemaAsync(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions, object userState)
		{
			if (this.onBeginSynchronizeWithSchemaDelegate == null)
			{
				this.onBeginSynchronizeWithSchemaDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSynchronizeWithSchema);
			}
			if (this.onEndSynchronizeWithSchemaDelegate == null)
			{
				this.onEndSynchronizeWithSchemaDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSynchronizeWithSchema);
			}
			if (this.onSynchronizeWithSchemaCompletedDelegate == null)
			{
				this.onSynchronizeWithSchemaCompletedDelegate = new SendOrPostCallback(this.OnSynchronizeWithSchemaCompleted);
			}
			base.InvokeAsync(this.onBeginSynchronizeWithSchemaDelegate, new object[]
			{
				dataObject,
				synchronizeOptions
			}, this.onEndSynchronizeWithSchemaDelegate, this.onSynchronizeWithSchemaCompletedDelegate, userState);
		}

		public SynchronizationResult SynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions)
		{
			return base.Channel.SynchronizeWithSchemaAndUpdate(itemId, synchronizeOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSynchronizeWithSchemaAndUpdate(itemId, synchronizeOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SynchronizationResult EndSynchronizeWithSchemaAndUpdate(IAsyncResult result)
		{
			return base.Channel.EndSynchronizeWithSchemaAndUpdate(result);
		}

		private IAsyncResult OnBeginSynchronizeWithSchemaAndUpdate(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string itemId = (string)inValues[0];
			SynchronizeOptions synchronizeOptions = (SynchronizeOptions)inValues[1];
			return this.BeginSynchronizeWithSchemaAndUpdate(itemId, synchronizeOptions, callback, asyncState);
		}

		private object[] OnEndSynchronizeWithSchemaAndUpdate(IAsyncResult result)
		{
			SynchronizationResult synchronizationResult = this.EndSynchronizeWithSchemaAndUpdate(result);
			return new object[]
			{
				synchronizationResult
			};
		}

		private void OnSynchronizeWithSchemaAndUpdateCompleted(object state)
		{
			if (this.SynchronizeWithSchemaAndUpdateCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SynchronizeWithSchemaAndUpdateCompleted(this, new SynchronizeWithSchemaAndUpdateCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SynchronizeWithSchemaAndUpdateAsync(string itemId, SynchronizeOptions synchronizeOptions)
		{
			this.SynchronizeWithSchemaAndUpdateAsync(itemId, synchronizeOptions, null);
		}

		public void SynchronizeWithSchemaAndUpdateAsync(string itemId, SynchronizeOptions synchronizeOptions, object userState)
		{
			if (this.onBeginSynchronizeWithSchemaAndUpdateDelegate == null)
			{
				this.onBeginSynchronizeWithSchemaAndUpdateDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSynchronizeWithSchemaAndUpdate);
			}
			if (this.onEndSynchronizeWithSchemaAndUpdateDelegate == null)
			{
				this.onEndSynchronizeWithSchemaAndUpdateDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSynchronizeWithSchemaAndUpdate);
			}
			if (this.onSynchronizeWithSchemaAndUpdateCompletedDelegate == null)
			{
				this.onSynchronizeWithSchemaAndUpdateCompletedDelegate = new SendOrPostCallback(this.OnSynchronizeWithSchemaAndUpdateCompleted);
			}
			base.InvokeAsync(this.onBeginSynchronizeWithSchemaAndUpdateDelegate, new object[]
			{
				itemId,
				synchronizeOptions
			}, this.onEndSynchronizeWithSchemaAndUpdateDelegate, this.onSynchronizeWithSchemaAndUpdateCompletedDelegate, userState);
		}

		public void DecommissionPublicationTarget(string publicationTargetId)
		{
			base.Channel.DecommissionPublicationTarget(publicationTargetId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDecommissionPublicationTarget(string publicationTargetId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDecommissionPublicationTarget(publicationTargetId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndDecommissionPublicationTarget(IAsyncResult result)
		{
			base.Channel.EndDecommissionPublicationTarget(result);
		}

		private IAsyncResult OnBeginDecommissionPublicationTarget(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string publicationTargetId = (string)inValues[0];
			return this.BeginDecommissionPublicationTarget(publicationTargetId, callback, asyncState);
		}

		private object[] OnEndDecommissionPublicationTarget(IAsyncResult result)
		{
			this.EndDecommissionPublicationTarget(result);
			return null;
		}

		private void OnDecommissionPublicationTargetCompleted(object state)
		{
			if (this.DecommissionPublicationTargetCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.DecommissionPublicationTargetCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DecommissionPublicationTargetAsync(string publicationTargetId)
		{
			this.DecommissionPublicationTargetAsync(publicationTargetId, null);
		}

		public void DecommissionPublicationTargetAsync(string publicationTargetId, object userState)
		{
			if (this.onBeginDecommissionPublicationTargetDelegate == null)
			{
				this.onBeginDecommissionPublicationTargetDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginDecommissionPublicationTarget);
			}
			if (this.onEndDecommissionPublicationTargetDelegate == null)
			{
				this.onEndDecommissionPublicationTargetDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndDecommissionPublicationTarget);
			}
			if (this.onDecommissionPublicationTargetCompletedDelegate == null)
			{
				this.onDecommissionPublicationTargetCompletedDelegate = new SendOrPostCallback(this.OnDecommissionPublicationTargetCompleted);
			}
			base.InvokeAsync(this.onBeginDecommissionPublicationTargetDelegate, new object[]
			{
				publicationTargetId
			}, this.onEndDecommissionPublicationTargetDelegate, this.onDecommissionPublicationTargetCompletedDelegate, userState);
		}

		public SchemaFieldsData ConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions)
		{
			return base.Channel.ConvertXsdToSchemaFields(xsd, purpose, rootElementName, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginConvertXsdToSchemaFields(xsd, purpose, rootElementName, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SchemaFieldsData EndConvertXsdToSchemaFields(IAsyncResult result)
		{
			return base.Channel.EndConvertXsdToSchemaFields(result);
		}

		private IAsyncResult OnBeginConvertXsdToSchemaFields(object[] inValues, AsyncCallback callback, object asyncState)
		{
			XElement xsd = (XElement)inValues[0];
			SchemaPurpose purpose = (SchemaPurpose)inValues[1];
			string rootElementName = (string)inValues[2];
			ReadOptions readOptions = (ReadOptions)inValues[3];
			return this.BeginConvertXsdToSchemaFields(xsd, purpose, rootElementName, readOptions, callback, asyncState);
		}

		private object[] OnEndConvertXsdToSchemaFields(IAsyncResult result)
		{
			SchemaFieldsData schemaFieldsData = this.EndConvertXsdToSchemaFields(result);
			return new object[]
			{
				schemaFieldsData
			};
		}

		private void OnConvertXsdToSchemaFieldsCompleted(object state)
		{
			if (this.ConvertXsdToSchemaFieldsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertXsdToSchemaFieldsCompleted(this, new ConvertXsdToSchemaFieldsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ConvertXsdToSchemaFieldsAsync(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions)
		{
			this.ConvertXsdToSchemaFieldsAsync(xsd, purpose, rootElementName, readOptions, null);
		}

		public void ConvertXsdToSchemaFieldsAsync(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions, object userState)
		{
			if (this.onBeginConvertXsdToSchemaFieldsDelegate == null)
			{
				this.onBeginConvertXsdToSchemaFieldsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginConvertXsdToSchemaFields);
			}
			if (this.onEndConvertXsdToSchemaFieldsDelegate == null)
			{
				this.onEndConvertXsdToSchemaFieldsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndConvertXsdToSchemaFields);
			}
			if (this.onConvertXsdToSchemaFieldsCompletedDelegate == null)
			{
				this.onConvertXsdToSchemaFieldsCompletedDelegate = new SendOrPostCallback(this.OnConvertXsdToSchemaFieldsCompleted);
			}
			base.InvokeAsync(this.onBeginConvertXsdToSchemaFieldsDelegate, new object[]
			{
				xsd,
				purpose,
				rootElementName,
				readOptions
			}, this.onEndConvertXsdToSchemaFieldsDelegate, this.onConvertXsdToSchemaFieldsCompletedDelegate, userState);
		}

		public string GetPublishUrl(string id, string targetTypeIdOrPurpose)
		{
			return base.Channel.GetPublishUrl(id, targetTypeIdOrPurpose);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetPublishUrl(string id, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetPublishUrl(id, targetTypeIdOrPurpose, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndGetPublishUrl(IAsyncResult result)
		{
			return base.Channel.EndGetPublishUrl(result);
		}

		private IAsyncResult OnBeginGetPublishUrl(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string targetTypeIdOrPurpose = (string)inValues[1];
			return this.BeginGetPublishUrl(id, targetTypeIdOrPurpose, callback, asyncState);
		}

		private object[] OnEndGetPublishUrl(IAsyncResult result)
		{
			string text = this.EndGetPublishUrl(result);
			return new object[]
			{
				text
			};
		}

		private void OnGetPublishUrlCompleted(object state)
		{
			if (this.GetPublishUrlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetPublishUrlCompleted(this, new GetPublishUrlCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetPublishUrlAsync(string id, string targetTypeIdOrPurpose)
		{
			this.GetPublishUrlAsync(id, targetTypeIdOrPurpose, null);
		}

		public void GetPublishUrlAsync(string id, string targetTypeIdOrPurpose, object userState)
		{
			if (this.onBeginGetPublishUrlDelegate == null)
			{
				this.onBeginGetPublishUrlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetPublishUrl);
			}
			if (this.onEndGetPublishUrlDelegate == null)
			{
				this.onEndGetPublishUrlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetPublishUrl);
			}
			if (this.onGetPublishUrlCompletedDelegate == null)
			{
				this.onGetPublishUrlCompletedDelegate = new SendOrPostCallback(this.OnGetPublishUrlCompleted);
			}
			base.InvokeAsync(this.onBeginGetPublishUrlDelegate, new object[]
			{
				id,
				targetTypeIdOrPurpose
			}, this.onEndGetPublishUrlDelegate, this.onGetPublishUrlCompletedDelegate, userState);
		}

		public LinkToBusinessProcessTypeData[] GetBusinessProcessTypes(string cdTopologyTypeId)
		{
			return base.Channel.GetBusinessProcessTypes(cdTopologyTypeId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetBusinessProcessTypes(string cdTopologyTypeId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetBusinessProcessTypes(cdTopologyTypeId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public LinkToBusinessProcessTypeData[] EndGetBusinessProcessTypes(IAsyncResult result)
		{
			return base.Channel.EndGetBusinessProcessTypes(result);
		}

		private IAsyncResult OnBeginGetBusinessProcessTypes(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string cdTopologyTypeId = (string)inValues[0];
			return this.BeginGetBusinessProcessTypes(cdTopologyTypeId, callback, asyncState);
		}

		private object[] OnEndGetBusinessProcessTypes(IAsyncResult result)
		{
			LinkToBusinessProcessTypeData[] array = this.EndGetBusinessProcessTypes(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetBusinessProcessTypesCompleted(object state)
		{
			if (this.GetBusinessProcessTypesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetBusinessProcessTypesCompleted(this, new GetBusinessProcessTypesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetBusinessProcessTypesAsync(string cdTopologyTypeId)
		{
			this.GetBusinessProcessTypesAsync(cdTopologyTypeId, null);
		}

		public void GetBusinessProcessTypesAsync(string cdTopologyTypeId, object userState)
		{
			if (this.onBeginGetBusinessProcessTypesDelegate == null)
			{
				this.onBeginGetBusinessProcessTypesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetBusinessProcessTypes);
			}
			if (this.onEndGetBusinessProcessTypesDelegate == null)
			{
				this.onEndGetBusinessProcessTypesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetBusinessProcessTypes);
			}
			if (this.onGetBusinessProcessTypesCompletedDelegate == null)
			{
				this.onGetBusinessProcessTypesCompletedDelegate = new SendOrPostCallback(this.OnGetBusinessProcessTypesCompleted);
			}
			base.InvokeAsync(this.onBeginGetBusinessProcessTypesDelegate, new object[]
			{
				cdTopologyTypeId
			}, this.onEndGetBusinessProcessTypesDelegate, this.onGetBusinessProcessTypesCompletedDelegate, userState);
		}

		public PublishSourceData GetPublishSourceByUrl(string url)
		{
			return base.Channel.GetPublishSourceByUrl(url);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetPublishSourceByUrl(string url, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetPublishSourceByUrl(url, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PublishSourceData EndGetPublishSourceByUrl(IAsyncResult result)
		{
			return base.Channel.EndGetPublishSourceByUrl(result);
		}

		private IAsyncResult OnBeginGetPublishSourceByUrl(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string url = (string)inValues[0];
			return this.BeginGetPublishSourceByUrl(url, callback, asyncState);
		}

		private object[] OnEndGetPublishSourceByUrl(IAsyncResult result)
		{
			PublishSourceData publishSourceData = this.EndGetPublishSourceByUrl(result);
			return new object[]
			{
				publishSourceData
			};
		}

		private void OnGetPublishSourceByUrlCompleted(object state)
		{
			if (this.GetPublishSourceByUrlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetPublishSourceByUrlCompleted(this, new GetPublishSourceByUrlCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetPublishSourceByUrlAsync(string url)
		{
			this.GetPublishSourceByUrlAsync(url, null);
		}

		public void GetPublishSourceByUrlAsync(string url, object userState)
		{
			if (this.onBeginGetPublishSourceByUrlDelegate == null)
			{
				this.onBeginGetPublishSourceByUrlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetPublishSourceByUrl);
			}
			if (this.onEndGetPublishSourceByUrlDelegate == null)
			{
				this.onEndGetPublishSourceByUrlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetPublishSourceByUrl);
			}
			if (this.onGetPublishSourceByUrlCompletedDelegate == null)
			{
				this.onGetPublishSourceByUrlCompletedDelegate = new SendOrPostCallback(this.OnGetPublishSourceByUrlCompleted);
			}
			base.InvokeAsync(this.onBeginGetPublishSourceByUrlDelegate, new object[]
			{
				url
			}, this.onEndGetPublishSourceByUrlDelegate, this.onGetPublishSourceByUrlCompletedDelegate, userState);
		}

		public void RemovePublishStates(string publicationId, string targetTypeIdOrPurpose)
		{
			base.Channel.RemovePublishStates(publicationId, targetTypeIdOrPurpose);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginRemovePublishStates(string publicationId, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginRemovePublishStates(publicationId, targetTypeIdOrPurpose, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndRemovePublishStates(IAsyncResult result)
		{
			base.Channel.EndRemovePublishStates(result);
		}

		private IAsyncResult OnBeginRemovePublishStates(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string publicationId = (string)inValues[0];
			string targetTypeIdOrPurpose = (string)inValues[1];
			return this.BeginRemovePublishStates(publicationId, targetTypeIdOrPurpose, callback, asyncState);
		}

		private object[] OnEndRemovePublishStates(IAsyncResult result)
		{
			this.EndRemovePublishStates(result);
			return null;
		}

		private void OnRemovePublishStatesCompleted(object state)
		{
			if (this.RemovePublishStatesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RemovePublishStatesCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void RemovePublishStatesAsync(string publicationId, string targetTypeIdOrPurpose)
		{
			this.RemovePublishStatesAsync(publicationId, targetTypeIdOrPurpose, null);
		}

		public void RemovePublishStatesAsync(string publicationId, string targetTypeIdOrPurpose, object userState)
		{
			if (this.onBeginRemovePublishStatesDelegate == null)
			{
				this.onBeginRemovePublishStatesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginRemovePublishStates);
			}
			if (this.onEndRemovePublishStatesDelegate == null)
			{
				this.onEndRemovePublishStatesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndRemovePublishStates);
			}
			if (this.onRemovePublishStatesCompletedDelegate == null)
			{
				this.onRemovePublishStatesCompletedDelegate = new SendOrPostCallback(this.OnRemovePublishStatesCompleted);
			}
			base.InvokeAsync(this.onBeginRemovePublishStatesDelegate, new object[]
			{
				publicationId,
				targetTypeIdOrPurpose
			}, this.onEndRemovePublishStatesDelegate, this.onRemovePublishStatesCompletedDelegate, userState);
		}

		public ContainingPagesDictionary ResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction)
		{
			return base.Channel.ResolveContainingPages(componentId, instruction);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginResolveContainingPages(componentId, instruction, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ContainingPagesDictionary EndResolveContainingPages(IAsyncResult result)
		{
			return base.Channel.EndResolveContainingPages(result);
		}

		private IAsyncResult OnBeginResolveContainingPages(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string componentId = (string)inValues[0];
			ResolveContainingPagesInstructionData instruction = (ResolveContainingPagesInstructionData)inValues[1];
			return this.BeginResolveContainingPages(componentId, instruction, callback, asyncState);
		}

		private object[] OnEndResolveContainingPages(IAsyncResult result)
		{
			ContainingPagesDictionary containingPagesDictionary = this.EndResolveContainingPages(result);
			return new object[]
			{
				containingPagesDictionary
			};
		}

		private void OnResolveContainingPagesCompleted(object state)
		{
			if (this.ResolveContainingPagesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResolveContainingPagesCompleted(this, new ResolveContainingPagesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ResolveContainingPagesAsync(string componentId, ResolveContainingPagesInstructionData instruction)
		{
			this.ResolveContainingPagesAsync(componentId, instruction, null);
		}

		public void ResolveContainingPagesAsync(string componentId, ResolveContainingPagesInstructionData instruction, object userState)
		{
			if (this.onBeginResolveContainingPagesDelegate == null)
			{
				this.onBeginResolveContainingPagesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginResolveContainingPages);
			}
			if (this.onEndResolveContainingPagesDelegate == null)
			{
				this.onEndResolveContainingPagesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndResolveContainingPages);
			}
			if (this.onResolveContainingPagesCompletedDelegate == null)
			{
				this.onResolveContainingPagesCompletedDelegate = new SendOrPostCallback(this.OnResolveContainingPagesCompleted);
			}
			base.InvokeAsync(this.onBeginResolveContainingPagesDelegate, new object[]
			{
				componentId,
				instruction
			}, this.onEndResolveContainingPagesDelegate, this.onResolveContainingPagesCompletedDelegate, userState);
		}

		public void PurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction)
		{
			base.Channel.PurgeWorkflowHistory(instruction);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginPurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginPurgeWorkflowHistory(instruction, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndPurgeWorkflowHistory(IAsyncResult result)
		{
			base.Channel.EndPurgeWorkflowHistory(result);
		}

		private IAsyncResult OnBeginPurgeWorkflowHistory(object[] inValues, AsyncCallback callback, object asyncState)
		{
			PurgeWorkflowHistoryInstructionData instruction = (PurgeWorkflowHistoryInstructionData)inValues[0];
			return this.BeginPurgeWorkflowHistory(instruction, callback, asyncState);
		}

		private object[] OnEndPurgeWorkflowHistory(IAsyncResult result)
		{
			this.EndPurgeWorkflowHistory(result);
			return null;
		}

		private void OnPurgeWorkflowHistoryCompleted(object state)
		{
			if (this.PurgeWorkflowHistoryCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PurgeWorkflowHistoryCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void PurgeWorkflowHistoryAsync(PurgeWorkflowHistoryInstructionData instruction)
		{
			this.PurgeWorkflowHistoryAsync(instruction, null);
		}

		public void PurgeWorkflowHistoryAsync(PurgeWorkflowHistoryInstructionData instruction, object userState)
		{
			if (this.onBeginPurgeWorkflowHistoryDelegate == null)
			{
				this.onBeginPurgeWorkflowHistoryDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginPurgeWorkflowHistory);
			}
			if (this.onEndPurgeWorkflowHistoryDelegate == null)
			{
				this.onEndPurgeWorkflowHistoryDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndPurgeWorkflowHistory);
			}
			if (this.onPurgeWorkflowHistoryCompletedDelegate == null)
			{
				this.onPurgeWorkflowHistoryCompletedDelegate = new SendOrPostCallback(this.OnPurgeWorkflowHistoryCompleted);
			}
			base.InvokeAsync(this.onBeginPurgeWorkflowHistoryDelegate, new object[]
			{
				instruction
			}, this.onEndPurgeWorkflowHistoryDelegate, this.onPurgeWorkflowHistoryCompletedDelegate, userState);
		}

		public void BroadcastNotification(NotificationMessage notification)
		{
			base.Channel.BroadcastNotification(notification);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBroadcastNotification(NotificationMessage notification, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBroadcastNotification(notification, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndBroadcastNotification(IAsyncResult result)
		{
			base.Channel.EndBroadcastNotification(result);
		}

		private IAsyncResult OnBeginBroadcastNotification(object[] inValues, AsyncCallback callback, object asyncState)
		{
			NotificationMessage notification = (NotificationMessage)inValues[0];
			return this.BeginBroadcastNotification(notification, callback, asyncState);
		}

		private object[] OnEndBroadcastNotification(IAsyncResult result)
		{
			this.EndBroadcastNotification(result);
			return null;
		}

		private void OnBroadcastNotificationCompleted(object state)
		{
			if (this.BroadcastNotificationCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.BroadcastNotificationCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BroadcastNotificationAsync(NotificationMessage notification)
		{
			this.BroadcastNotificationAsync(notification, null);
		}

		public void BroadcastNotificationAsync(NotificationMessage notification, object userState)
		{
			if (this.onBeginBroadcastNotificationDelegate == null)
			{
				this.onBeginBroadcastNotificationDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginBroadcastNotification);
			}
			if (this.onEndBroadcastNotificationDelegate == null)
			{
				this.onEndBroadcastNotificationDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndBroadcastNotification);
			}
			if (this.onBroadcastNotificationCompletedDelegate == null)
			{
				this.onBroadcastNotificationCompletedDelegate = new SendOrPostCallback(this.OnBroadcastNotificationCompleted);
			}
			base.InvokeAsync(this.onBeginBroadcastNotificationDelegate, new object[]
			{
				notification
			}, this.onEndBroadcastNotificationDelegate, this.onBroadcastNotificationCompletedDelegate, userState);
		}

		public SystemPrivilege[] GetSystemPrivileges()
		{
			return base.Channel.GetSystemPrivileges();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSystemPrivileges(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSystemPrivileges(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SystemPrivilege[] EndGetSystemPrivileges(IAsyncResult result)
		{
			return base.Channel.EndGetSystemPrivileges(result);
		}

		private IAsyncResult OnBeginGetSystemPrivileges(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetSystemPrivileges(callback, asyncState);
		}

		private object[] OnEndGetSystemPrivileges(IAsyncResult result)
		{
			SystemPrivilege[] array = this.EndGetSystemPrivileges(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetSystemPrivilegesCompleted(object state)
		{
			if (this.GetSystemPrivilegesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSystemPrivilegesCompleted(this, new GetSystemPrivilegesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSystemPrivilegesAsync()
		{
			this.GetSystemPrivilegesAsync(null);
		}

		public void GetSystemPrivilegesAsync(object userState)
		{
			if (this.onBeginGetSystemPrivilegesDelegate == null)
			{
				this.onBeginGetSystemPrivilegesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSystemPrivileges);
			}
			if (this.onEndGetSystemPrivilegesDelegate == null)
			{
				this.onEndGetSystemPrivilegesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSystemPrivileges);
			}
			if (this.onGetSystemPrivilegesCompletedDelegate == null)
			{
				this.onGetSystemPrivilegesCompletedDelegate = new SendOrPostCallback(this.OnGetSystemPrivilegesCompleted);
			}
			base.InvokeAsync(this.onBeginGetSystemPrivilegesDelegate, null, this.onEndGetSystemPrivilegesDelegate, this.onGetSystemPrivilegesCompletedDelegate, userState);
		}

		public string GetApiVersion()
		{
			return base.Channel.GetApiVersion();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetApiVersion(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetApiVersion(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndGetApiVersion(IAsyncResult result)
		{
			return base.Channel.EndGetApiVersion(result);
		}

		private IAsyncResult OnBeginGetApiVersion(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetApiVersion(callback, asyncState);
		}

		private object[] OnEndGetApiVersion(IAsyncResult result)
		{
			string text = this.EndGetApiVersion(result);
			return new object[]
			{
				text
			};
		}

		private void OnGetApiVersionCompleted(object state)
		{
			if (this.GetApiVersionCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetApiVersionCompleted(this, new GetApiVersionCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetApiVersionAsync()
		{
			this.GetApiVersionAsync(null);
		}

		public void GetApiVersionAsync(object userState)
		{
			if (this.onBeginGetApiVersionDelegate == null)
			{
				this.onBeginGetApiVersionDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetApiVersion);
			}
			if (this.onEndGetApiVersionDelegate == null)
			{
				this.onEndGetApiVersionDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetApiVersion);
			}
			if (this.onGetApiVersionCompletedDelegate == null)
			{
				this.onGetApiVersionCompletedDelegate = new SendOrPostCallback(this.OnGetApiVersionCompleted);
			}
			base.InvokeAsync(this.onBeginGetApiVersionDelegate, null, this.onEndGetApiVersionDelegate, this.onGetApiVersionCompletedDelegate, userState);
		}

		public AccessTokenData GetCurrentUser()
		{
			return base.Channel.GetCurrentUser();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetCurrentUser(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetCurrentUser(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public AccessTokenData EndGetCurrentUser(IAsyncResult result)
		{
			return base.Channel.EndGetCurrentUser(result);
		}

		private IAsyncResult OnBeginGetCurrentUser(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetCurrentUser(callback, asyncState);
		}

		private object[] OnEndGetCurrentUser(IAsyncResult result)
		{
			AccessTokenData accessTokenData = this.EndGetCurrentUser(result);
			return new object[]
			{
				accessTokenData
			};
		}

		private void OnGetCurrentUserCompleted(object state)
		{
			if (this.GetCurrentUserCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetCurrentUserCompleted(this, new GetCurrentUserCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetCurrentUserAsync()
		{
			this.GetCurrentUserAsync(null);
		}

		public void GetCurrentUserAsync(object userState)
		{
			if (this.onBeginGetCurrentUserDelegate == null)
			{
				this.onBeginGetCurrentUserDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetCurrentUser);
			}
			if (this.onEndGetCurrentUserDelegate == null)
			{
				this.onEndGetCurrentUserDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetCurrentUser);
			}
			if (this.onGetCurrentUserCompletedDelegate == null)
			{
				this.onGetCurrentUserCompletedDelegate = new SendOrPostCallback(this.OnGetCurrentUserCompleted);
			}
			base.InvokeAsync(this.onBeginGetCurrentUserDelegate, null, this.onEndGetCurrentUserDelegate, this.onGetCurrentUserCompletedDelegate, userState);
		}

		public bool IsExistingObject(string id)
		{
			return base.Channel.IsExistingObject(id);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginIsExistingObject(string id, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginIsExistingObject(id, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public bool EndIsExistingObject(IAsyncResult result)
		{
			return base.Channel.EndIsExistingObject(result);
		}

		private IAsyncResult OnBeginIsExistingObject(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			return this.BeginIsExistingObject(id, callback, asyncState);
		}

		private object[] OnEndIsExistingObject(IAsyncResult result)
		{
			bool flag = this.EndIsExistingObject(result);
			return new object[]
			{
				flag
			};
		}

		private void OnIsExistingObjectCompleted(object state)
		{
			if (this.IsExistingObjectCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.IsExistingObjectCompleted(this, new IsExistingObjectCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void IsExistingObjectAsync(string id)
		{
			this.IsExistingObjectAsync(id, null);
		}

		public void IsExistingObjectAsync(string id, object userState)
		{
			if (this.onBeginIsExistingObjectDelegate == null)
			{
				this.onBeginIsExistingObjectDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginIsExistingObject);
			}
			if (this.onEndIsExistingObjectDelegate == null)
			{
				this.onEndIsExistingObjectDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndIsExistingObject);
			}
			if (this.onIsExistingObjectCompletedDelegate == null)
			{
				this.onIsExistingObjectCompletedDelegate = new SendOrPostCallback(this.OnIsExistingObjectCompleted);
			}
			base.InvokeAsync(this.onBeginIsExistingObjectDelegate, new object[]
			{
				id
			}, this.onEndIsExistingObjectDelegate, this.onIsExistingObjectCompletedDelegate, userState);
		}

		public string GetTcmUri(string baseUri, string contextRepositoryUri, uint? version)
		{
			return base.Channel.GetTcmUri(baseUri, contextRepositoryUri, version);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetTcmUri(baseUri, contextRepositoryUri, version, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndGetTcmUri(IAsyncResult result)
		{
			return base.Channel.EndGetTcmUri(result);
		}

		private IAsyncResult OnBeginGetTcmUri(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string baseUri = (string)inValues[0];
			string contextRepositoryUri = (string)inValues[1];
			uint? version = (uint?)inValues[2];
			return this.BeginGetTcmUri(baseUri, contextRepositoryUri, version, callback, asyncState);
		}

		private object[] OnEndGetTcmUri(IAsyncResult result)
		{
			string text = this.EndGetTcmUri(result);
			return new object[]
			{
				text
			};
		}

		private void OnGetTcmUriCompleted(object state)
		{
			if (this.GetTcmUriCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetTcmUriCompleted(this, new GetTcmUriCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version)
		{
			this.GetTcmUriAsync(baseUri, contextRepositoryUri, version, null);
		}

		public void GetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version, object userState)
		{
			if (this.onBeginGetTcmUriDelegate == null)
			{
				this.onBeginGetTcmUriDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetTcmUri);
			}
			if (this.onEndGetTcmUriDelegate == null)
			{
				this.onEndGetTcmUriDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetTcmUri);
			}
			if (this.onGetTcmUriCompletedDelegate == null)
			{
				this.onGetTcmUriCompletedDelegate = new SendOrPostCallback(this.OnGetTcmUriCompleted);
			}
			base.InvokeAsync(this.onBeginGetTcmUriDelegate, new object[]
			{
				baseUri,
				contextRepositoryUri,
				version
			}, this.onEndGetTcmUriDelegate, this.onGetTcmUriCompletedDelegate, userState);
		}

		public string TryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version)
		{
			return base.Channel.TryGetTcmUri(baseUri, contextRepositoryUri, version);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginTryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginTryGetTcmUri(baseUri, contextRepositoryUri, version, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndTryGetTcmUri(IAsyncResult result)
		{
			return base.Channel.EndTryGetTcmUri(result);
		}

		private IAsyncResult OnBeginTryGetTcmUri(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string baseUri = (string)inValues[0];
			string contextRepositoryUri = (string)inValues[1];
			uint? version = (uint?)inValues[2];
			return this.BeginTryGetTcmUri(baseUri, contextRepositoryUri, version, callback, asyncState);
		}

		private object[] OnEndTryGetTcmUri(IAsyncResult result)
		{
			string text = this.EndTryGetTcmUri(result);
			return new object[]
			{
				text
			};
		}

		private void OnTryGetTcmUriCompleted(object state)
		{
			if (this.TryGetTcmUriCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.TryGetTcmUriCompleted(this, new TryGetTcmUriCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void TryGetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version)
		{
			this.TryGetTcmUriAsync(baseUri, contextRepositoryUri, version, null);
		}

		public void TryGetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version, object userState)
		{
			if (this.onBeginTryGetTcmUriDelegate == null)
			{
				this.onBeginTryGetTcmUriDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginTryGetTcmUri);
			}
			if (this.onEndTryGetTcmUriDelegate == null)
			{
				this.onEndTryGetTcmUriDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndTryGetTcmUri);
			}
			if (this.onTryGetTcmUriCompletedDelegate == null)
			{
				this.onTryGetTcmUriCompletedDelegate = new SendOrPostCallback(this.OnTryGetTcmUriCompleted);
			}
			base.InvokeAsync(this.onBeginTryGetTcmUriDelegate, new object[]
			{
				baseUri,
				contextRepositoryUri,
				version
			}, this.onEndTryGetTcmUriDelegate, this.onTryGetTcmUriCompletedDelegate, userState);
		}

		public IdentifiableObjectData Read(string id, ReadOptions readOptions)
		{
			return base.Channel.Read(id, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginRead(id, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData EndRead(IAsyncResult result)
		{
			return base.Channel.EndRead(result);
		}

		private IAsyncResult OnBeginRead(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			ReadOptions readOptions = (ReadOptions)inValues[1];
			return this.BeginRead(id, readOptions, callback, asyncState);
		}

		private object[] OnEndRead(IAsyncResult result)
		{
			IdentifiableObjectData identifiableObjectData = this.EndRead(result);
			return new object[]
			{
				identifiableObjectData
			};
		}

		private void OnReadCompleted(object state)
		{
			if (this.ReadCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadCompleted(this, new ReadCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReadAsync(string id, ReadOptions readOptions)
		{
			this.ReadAsync(id, readOptions, null);
		}

		public void ReadAsync(string id, ReadOptions readOptions, object userState)
		{
			if (this.onBeginReadDelegate == null)
			{
				this.onBeginReadDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginRead);
			}
			if (this.onEndReadDelegate == null)
			{
				this.onEndReadDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndRead);
			}
			if (this.onReadCompletedDelegate == null)
			{
				this.onReadCompletedDelegate = new SendOrPostCallback(this.OnReadCompleted);
			}
			base.InvokeAsync(this.onBeginReadDelegate, new object[]
			{
				id,
				readOptions
			}, this.onEndReadDelegate, this.onReadCompletedDelegate, userState);
		}

		public IdentifiableObjectData TryRead(string id, ReadOptions readOptions)
		{
			return base.Channel.TryRead(id, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginTryRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginTryRead(id, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData EndTryRead(IAsyncResult result)
		{
			return base.Channel.EndTryRead(result);
		}

		private IAsyncResult OnBeginTryRead(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			ReadOptions readOptions = (ReadOptions)inValues[1];
			return this.BeginTryRead(id, readOptions, callback, asyncState);
		}

		private object[] OnEndTryRead(IAsyncResult result)
		{
			IdentifiableObjectData identifiableObjectData = this.EndTryRead(result);
			return new object[]
			{
				identifiableObjectData
			};
		}

		private void OnTryReadCompleted(object state)
		{
			if (this.TryReadCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.TryReadCompleted(this, new TryReadCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void TryReadAsync(string id, ReadOptions readOptions)
		{
			this.TryReadAsync(id, readOptions, null);
		}

		public void TryReadAsync(string id, ReadOptions readOptions, object userState)
		{
			if (this.onBeginTryReadDelegate == null)
			{
				this.onBeginTryReadDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginTryRead);
			}
			if (this.onEndTryReadDelegate == null)
			{
				this.onEndTryReadDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndTryRead);
			}
			if (this.onTryReadCompletedDelegate == null)
			{
				this.onTryReadCompletedDelegate = new SendOrPostCallback(this.OnTryReadCompleted);
			}
			base.InvokeAsync(this.onBeginTryReadDelegate, new object[]
			{
				id,
				readOptions
			}, this.onEndTryReadDelegate, this.onTryReadCompletedDelegate, userState);
		}

		public ItemReadResultDictionary BulkRead(string[] ids, ReadOptions readOptions)
		{
			return base.Channel.BulkRead(ids, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBulkRead(string[] ids, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBulkRead(ids, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ItemReadResultDictionary EndBulkRead(IAsyncResult result)
		{
			return base.Channel.EndBulkRead(result);
		}

		private IAsyncResult OnBeginBulkRead(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] ids = (string[])inValues[0];
			ReadOptions readOptions = (ReadOptions)inValues[1];
			return this.BeginBulkRead(ids, readOptions, callback, asyncState);
		}

		private object[] OnEndBulkRead(IAsyncResult result)
		{
			ItemReadResultDictionary itemReadResultDictionary = this.EndBulkRead(result);
			return new object[]
			{
				itemReadResultDictionary
			};
		}

		private void OnBulkReadCompleted(object state)
		{
			if (this.BulkReadCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.BulkReadCompleted(this, new BulkReadCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BulkReadAsync(string[] ids, ReadOptions readOptions)
		{
			this.BulkReadAsync(ids, readOptions, null);
		}

		public void BulkReadAsync(string[] ids, ReadOptions readOptions, object userState)
		{
			if (this.onBeginBulkReadDelegate == null)
			{
				this.onBeginBulkReadDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginBulkRead);
			}
			if (this.onEndBulkReadDelegate == null)
			{
				this.onEndBulkReadDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndBulkRead);
			}
			if (this.onBulkReadCompletedDelegate == null)
			{
				this.onBulkReadCompletedDelegate = new SendOrPostCallback(this.OnBulkReadCompleted);
			}
			base.InvokeAsync(this.onBeginBulkReadDelegate, new object[]
			{
				ids,
				readOptions
			}, this.onEndBulkReadDelegate, this.onBulkReadCompletedDelegate, userState);
		}

		public SchemaFieldsData ReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions)
		{
			return base.Channel.ReadSchemaFields(schemaId, expandEmbeddedFields, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginReadSchemaFields(schemaId, expandEmbeddedFields, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SchemaFieldsData EndReadSchemaFields(IAsyncResult result)
		{
			return base.Channel.EndReadSchemaFields(result);
		}

		private IAsyncResult OnBeginReadSchemaFields(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string schemaId = (string)inValues[0];
			bool expandEmbeddedFields = (bool)inValues[1];
			ReadOptions readOptions = (ReadOptions)inValues[2];
			return this.BeginReadSchemaFields(schemaId, expandEmbeddedFields, readOptions, callback, asyncState);
		}

		private object[] OnEndReadSchemaFields(IAsyncResult result)
		{
			SchemaFieldsData schemaFieldsData = this.EndReadSchemaFields(result);
			return new object[]
			{
				schemaFieldsData
			};
		}

		private void OnReadSchemaFieldsCompleted(object state)
		{
			if (this.ReadSchemaFieldsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadSchemaFieldsCompleted(this, new ReadSchemaFieldsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReadSchemaFieldsAsync(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions)
		{
			this.ReadSchemaFieldsAsync(schemaId, expandEmbeddedFields, readOptions, null);
		}

		public void ReadSchemaFieldsAsync(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions, object userState)
		{
			if (this.onBeginReadSchemaFieldsDelegate == null)
			{
				this.onBeginReadSchemaFieldsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginReadSchemaFields);
			}
			if (this.onEndReadSchemaFieldsDelegate == null)
			{
				this.onEndReadSchemaFieldsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndReadSchemaFields);
			}
			if (this.onReadSchemaFieldsCompletedDelegate == null)
			{
				this.onReadSchemaFieldsCompletedDelegate = new SendOrPostCallback(this.OnReadSchemaFieldsCompleted);
			}
			base.InvokeAsync(this.onBeginReadSchemaFieldsDelegate, new object[]
			{
				schemaId,
				expandEmbeddedFields,
				readOptions
			}, this.onEndReadSchemaFieldsDelegate, this.onReadSchemaFieldsCompletedDelegate, userState);
		}

		public XElement ConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData)
		{
			return base.Channel.ConvertSchemaFieldsToXsd(schemaFieldsData);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginConvertSchemaFieldsToXsd(schemaFieldsData, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public XElement EndConvertSchemaFieldsToXsd(IAsyncResult result)
		{
			return base.Channel.EndConvertSchemaFieldsToXsd(result);
		}

		private IAsyncResult OnBeginConvertSchemaFieldsToXsd(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SchemaFieldsData schemaFieldsData = (SchemaFieldsData)inValues[0];
			return this.BeginConvertSchemaFieldsToXsd(schemaFieldsData, callback, asyncState);
		}

		private object[] OnEndConvertSchemaFieldsToXsd(IAsyncResult result)
		{
			XElement xElement = this.EndConvertSchemaFieldsToXsd(result);
			return new object[]
			{
				xElement
			};
		}

		private void OnConvertSchemaFieldsToXsdCompleted(object state)
		{
			if (this.ConvertSchemaFieldsToXsdCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertSchemaFieldsToXsdCompleted(this, new ConvertSchemaFieldsToXsdCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ConvertSchemaFieldsToXsdAsync(SchemaFieldsData schemaFieldsData)
		{
			this.ConvertSchemaFieldsToXsdAsync(schemaFieldsData, null);
		}

		public void ConvertSchemaFieldsToXsdAsync(SchemaFieldsData schemaFieldsData, object userState)
		{
			if (this.onBeginConvertSchemaFieldsToXsdDelegate == null)
			{
				this.onBeginConvertSchemaFieldsToXsdDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginConvertSchemaFieldsToXsd);
			}
			if (this.onEndConvertSchemaFieldsToXsdDelegate == null)
			{
				this.onEndConvertSchemaFieldsToXsdDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndConvertSchemaFieldsToXsd);
			}
			if (this.onConvertSchemaFieldsToXsdCompletedDelegate == null)
			{
				this.onConvertSchemaFieldsToXsdCompletedDelegate = new SendOrPostCallback(this.OnConvertSchemaFieldsToXsdCompleted);
			}
			base.InvokeAsync(this.onBeginConvertSchemaFieldsToXsdDelegate, new object[]
			{
				schemaFieldsData
			}, this.onEndConvertSchemaFieldsToXsdDelegate, this.onConvertSchemaFieldsToXsdCompletedDelegate, userState);
		}

		public IdentifiableObjectData Save(IdentifiableObjectData deltaData, ReadOptions readBackOptions)
		{
			return base.Channel.Save(deltaData, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSave(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSave(deltaData, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData EndSave(IAsyncResult result)
		{
			return base.Channel.EndSave(result);
		}

		private IAsyncResult OnBeginSave(object[] inValues, AsyncCallback callback, object asyncState)
		{
			IdentifiableObjectData deltaData = (IdentifiableObjectData)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginSave(deltaData, readBackOptions, callback, asyncState);
		}

		private object[] OnEndSave(IAsyncResult result)
		{
			IdentifiableObjectData identifiableObjectData = this.EndSave(result);
			return new object[]
			{
				identifiableObjectData
			};
		}

		private void OnSaveCompleted(object state)
		{
			if (this.SaveCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SaveCompleted(this, new SaveCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SaveAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions)
		{
			this.SaveAsync(deltaData, readBackOptions, null);
		}

		public void SaveAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginSaveDelegate == null)
			{
				this.onBeginSaveDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSave);
			}
			if (this.onEndSaveDelegate == null)
			{
				this.onEndSaveDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSave);
			}
			if (this.onSaveCompletedDelegate == null)
			{
				this.onSaveCompletedDelegate = new SendOrPostCallback(this.OnSaveCompleted);
			}
			base.InvokeAsync(this.onBeginSaveDelegate, new object[]
			{
				deltaData,
				readBackOptions
			}, this.onEndSaveDelegate, this.onSaveCompletedDelegate, userState);
		}

		public void Delete(string id)
		{
			base.Channel.Delete(id);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDelete(string id, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDelete(id, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndDelete(IAsyncResult result)
		{
			base.Channel.EndDelete(result);
		}

		private IAsyncResult OnBeginDelete(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			return this.BeginDelete(id, callback, asyncState);
		}

		private object[] OnEndDelete(IAsyncResult result)
		{
			this.EndDelete(result);
			return null;
		}

		private void OnDeleteCompleted(object state)
		{
			if (this.DeleteCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.DeleteCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DeleteAsync(string id)
		{
			this.DeleteAsync(id, null);
		}

		public void DeleteAsync(string id, object userState)
		{
			if (this.onBeginDeleteDelegate == null)
			{
				this.onBeginDeleteDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginDelete);
			}
			if (this.onEndDeleteDelegate == null)
			{
				this.onEndDeleteDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndDelete);
			}
			if (this.onDeleteCompletedDelegate == null)
			{
				this.onDeleteCompletedDelegate = new SendOrPostCallback(this.OnDeleteCompleted);
			}
			base.InvokeAsync(this.onBeginDeleteDelegate, new object[]
			{
				id
			}, this.onEndDeleteDelegate, this.onDeleteCompletedDelegate, userState);
		}

		public void DeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
		{
			base.Channel.DeleteTaxonomyNode(id, deleteTaxonomyNodeMode);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDeleteTaxonomyNode(id, deleteTaxonomyNodeMode, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndDeleteTaxonomyNode(IAsyncResult result)
		{
			base.Channel.EndDeleteTaxonomyNode(result);
		}

		private IAsyncResult OnBeginDeleteTaxonomyNode(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			DeleteTaxonomyNodeMode deleteTaxonomyNodeMode = (DeleteTaxonomyNodeMode)inValues[1];
			return this.BeginDeleteTaxonomyNode(id, deleteTaxonomyNodeMode, callback, asyncState);
		}

		private object[] OnEndDeleteTaxonomyNode(IAsyncResult result)
		{
			this.EndDeleteTaxonomyNode(result);
			return null;
		}

		private void OnDeleteTaxonomyNodeCompleted(object state)
		{
			if (this.DeleteTaxonomyNodeCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.DeleteTaxonomyNodeCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DeleteTaxonomyNodeAsync(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
		{
			this.DeleteTaxonomyNodeAsync(id, deleteTaxonomyNodeMode, null);
		}

		public void DeleteTaxonomyNodeAsync(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, object userState)
		{
			if (this.onBeginDeleteTaxonomyNodeDelegate == null)
			{
				this.onBeginDeleteTaxonomyNodeDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginDeleteTaxonomyNode);
			}
			if (this.onEndDeleteTaxonomyNodeDelegate == null)
			{
				this.onEndDeleteTaxonomyNodeDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndDeleteTaxonomyNode);
			}
			if (this.onDeleteTaxonomyNodeCompletedDelegate == null)
			{
				this.onDeleteTaxonomyNodeCompletedDelegate = new SendOrPostCallback(this.OnDeleteTaxonomyNodeCompleted);
			}
			base.InvokeAsync(this.onBeginDeleteTaxonomyNodeDelegate, new object[]
			{
				id,
				deleteTaxonomyNodeMode
			}, this.onEndDeleteTaxonomyNodeDelegate, this.onDeleteTaxonomyNodeCompletedDelegate, userState);
		}

		public IdentifiableObjectData GetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions)
		{
			return base.Channel.GetDefaultData(itemType, containerId, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetDefaultData(itemType, containerId, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData EndGetDefaultData(IAsyncResult result)
		{
			return base.Channel.EndGetDefaultData(result);
		}

		private IAsyncResult OnBeginGetDefaultData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			ItemType itemType = (ItemType)inValues[0];
			string containerId = (string)inValues[1];
			ReadOptions readOptions = (ReadOptions)inValues[2];
			return this.BeginGetDefaultData(itemType, containerId, readOptions, callback, asyncState);
		}

		private object[] OnEndGetDefaultData(IAsyncResult result)
		{
			IdentifiableObjectData identifiableObjectData = this.EndGetDefaultData(result);
			return new object[]
			{
				identifiableObjectData
			};
		}

		private void OnGetDefaultDataCompleted(object state)
		{
			if (this.GetDefaultDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetDefaultDataCompleted(this, new GetDefaultDataCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetDefaultDataAsync(ItemType itemType, string containerId, ReadOptions readOptions)
		{
			this.GetDefaultDataAsync(itemType, containerId, readOptions, null);
		}

		public void GetDefaultDataAsync(ItemType itemType, string containerId, ReadOptions readOptions, object userState)
		{
			if (this.onBeginGetDefaultDataDelegate == null)
			{
				this.onBeginGetDefaultDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetDefaultData);
			}
			if (this.onEndGetDefaultDataDelegate == null)
			{
				this.onEndGetDefaultDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetDefaultData);
			}
			if (this.onGetDefaultDataCompletedDelegate == null)
			{
				this.onGetDefaultDataCompletedDelegate = new SendOrPostCallback(this.OnGetDefaultDataCompleted);
			}
			base.InvokeAsync(this.onBeginGetDefaultDataDelegate, new object[]
			{
				itemType,
				containerId,
				readOptions
			}, this.onEndGetDefaultDataDelegate, this.onGetDefaultDataCompletedDelegate, userState);
		}

		public RepositoryLocalObjectData Move(string id, string destinationId, ReadOptions readBackOptions)
		{
			return base.Channel.Move(id, destinationId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginMove(string id, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginMove(id, destinationId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public RepositoryLocalObjectData EndMove(IAsyncResult result)
		{
			return base.Channel.EndMove(result);
		}

		private IAsyncResult OnBeginMove(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string destinationId = (string)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginMove(id, destinationId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndMove(IAsyncResult result)
		{
			RepositoryLocalObjectData repositoryLocalObjectData = this.EndMove(result);
			return new object[]
			{
				repositoryLocalObjectData
			};
		}

		private void OnMoveCompleted(object state)
		{
			if (this.MoveCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.MoveCompleted(this, new MoveCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void MoveAsync(string id, string destinationId, ReadOptions readBackOptions)
		{
			this.MoveAsync(id, destinationId, readBackOptions, null);
		}

		public void MoveAsync(string id, string destinationId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginMoveDelegate == null)
			{
				this.onBeginMoveDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginMove);
			}
			if (this.onEndMoveDelegate == null)
			{
				this.onEndMoveDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndMove);
			}
			if (this.onMoveCompletedDelegate == null)
			{
				this.onMoveCompletedDelegate = new SendOrPostCallback(this.OnMoveCompleted);
			}
			base.InvokeAsync(this.onBeginMoveDelegate, new object[]
			{
				id,
				destinationId,
				readBackOptions
			}, this.onEndMoveDelegate, this.onMoveCompletedDelegate, userState);
		}

		public RepositoryLocalObjectData Copy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions)
		{
			return base.Channel.Copy(id, destinationId, makeUnique, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginCopy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginCopy(id, destinationId, makeUnique, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public RepositoryLocalObjectData EndCopy(IAsyncResult result)
		{
			return base.Channel.EndCopy(result);
		}

		private IAsyncResult OnBeginCopy(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string destinationId = (string)inValues[1];
			bool makeUnique = (bool)inValues[2];
			ReadOptions readBackOptions = (ReadOptions)inValues[3];
			return this.BeginCopy(id, destinationId, makeUnique, readBackOptions, callback, asyncState);
		}

		private object[] OnEndCopy(IAsyncResult result)
		{
			RepositoryLocalObjectData repositoryLocalObjectData = this.EndCopy(result);
			return new object[]
			{
				repositoryLocalObjectData
			};
		}

		private void OnCopyCompleted(object state)
		{
			if (this.CopyCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CopyCompleted(this, new CopyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void CopyAsync(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions)
		{
			this.CopyAsync(id, destinationId, makeUnique, readBackOptions, null);
		}

		public void CopyAsync(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginCopyDelegate == null)
			{
				this.onBeginCopyDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginCopy);
			}
			if (this.onEndCopyDelegate == null)
			{
				this.onEndCopyDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndCopy);
			}
			if (this.onCopyCompletedDelegate == null)
			{
				this.onCopyCompletedDelegate = new SendOrPostCallback(this.OnCopyCompleted);
			}
			base.InvokeAsync(this.onBeginCopyDelegate, new object[]
			{
				id,
				destinationId,
				makeUnique,
				readBackOptions
			}, this.onEndCopyDelegate, this.onCopyCompletedDelegate, userState);
		}

		public InstanceData GetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions)
		{
			return base.Channel.GetInstanceData(schemaId, containerItemId, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetInstanceData(schemaId, containerItemId, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public InstanceData EndGetInstanceData(IAsyncResult result)
		{
			return base.Channel.EndGetInstanceData(result);
		}

		private IAsyncResult OnBeginGetInstanceData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string schemaId = (string)inValues[0];
			string containerItemId = (string)inValues[1];
			ReadOptions readOptions = (ReadOptions)inValues[2];
			return this.BeginGetInstanceData(schemaId, containerItemId, readOptions, callback, asyncState);
		}

		private object[] OnEndGetInstanceData(IAsyncResult result)
		{
			InstanceData instanceData = this.EndGetInstanceData(result);
			return new object[]
			{
				instanceData
			};
		}

		private void OnGetInstanceDataCompleted(object state)
		{
			if (this.GetInstanceDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetInstanceDataCompleted(this, new GetInstanceDataCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetInstanceDataAsync(string schemaId, string containerItemId, ReadOptions readOptions)
		{
			this.GetInstanceDataAsync(schemaId, containerItemId, readOptions, null);
		}

		public void GetInstanceDataAsync(string schemaId, string containerItemId, ReadOptions readOptions, object userState)
		{
			if (this.onBeginGetInstanceDataDelegate == null)
			{
				this.onBeginGetInstanceDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetInstanceData);
			}
			if (this.onEndGetInstanceDataDelegate == null)
			{
				this.onEndGetInstanceDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetInstanceData);
			}
			if (this.onGetInstanceDataCompletedDelegate == null)
			{
				this.onGetInstanceDataCompletedDelegate = new SendOrPostCallback(this.OnGetInstanceDataCompleted);
			}
			base.InvokeAsync(this.onBeginGetInstanceDataDelegate, new object[]
			{
				schemaId,
				containerItemId,
				readOptions
			}, this.onEndGetInstanceDataDelegate, this.onGetInstanceDataCompletedDelegate, userState);
		}

		public IdentifiableObjectData TryCheckOut(string id, ReadOptions readBackOptions)
		{
			return base.Channel.TryCheckOut(id, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginTryCheckOut(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginTryCheckOut(id, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData EndTryCheckOut(IAsyncResult result)
		{
			return base.Channel.EndTryCheckOut(result);
		}

		private IAsyncResult OnBeginTryCheckOut(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginTryCheckOut(id, readBackOptions, callback, asyncState);
		}

		private object[] OnEndTryCheckOut(IAsyncResult result)
		{
			IdentifiableObjectData identifiableObjectData = this.EndTryCheckOut(result);
			return new object[]
			{
				identifiableObjectData
			};
		}

		private void OnTryCheckOutCompleted(object state)
		{
			if (this.TryCheckOutCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.TryCheckOutCompleted(this, new TryCheckOutCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void TryCheckOutAsync(string id, ReadOptions readBackOptions)
		{
			this.TryCheckOutAsync(id, readBackOptions, null);
		}

		public void TryCheckOutAsync(string id, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginTryCheckOutDelegate == null)
			{
				this.onBeginTryCheckOutDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginTryCheckOut);
			}
			if (this.onEndTryCheckOutDelegate == null)
			{
				this.onEndTryCheckOutDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndTryCheckOut);
			}
			if (this.onTryCheckOutCompletedDelegate == null)
			{
				this.onTryCheckOutCompletedDelegate = new SendOrPostCallback(this.OnTryCheckOutCompleted);
			}
			base.InvokeAsync(this.onBeginTryCheckOutDelegate, new object[]
			{
				id,
				readBackOptions
			}, this.onEndTryCheckOutDelegate, this.onTryCheckOutCompletedDelegate, userState);
		}

		public VersionedItemData CheckOut(string id, bool permanentLock, ReadOptions readBackOptions)
		{
			return base.Channel.CheckOut(id, permanentLock, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginCheckOut(id, permanentLock, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public VersionedItemData EndCheckOut(IAsyncResult result)
		{
			return base.Channel.EndCheckOut(result);
		}

		private IAsyncResult OnBeginCheckOut(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			bool permanentLock = (bool)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginCheckOut(id, permanentLock, readBackOptions, callback, asyncState);
		}

		private object[] OnEndCheckOut(IAsyncResult result)
		{
			VersionedItemData versionedItemData = this.EndCheckOut(result);
			return new object[]
			{
				versionedItemData
			};
		}

		private void OnCheckOutCompleted(object state)
		{
			if (this.CheckOutCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CheckOutCompleted(this, new CheckOutCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void CheckOutAsync(string id, bool permanentLock, ReadOptions readBackOptions)
		{
			this.CheckOutAsync(id, permanentLock, readBackOptions, null);
		}

		public void CheckOutAsync(string id, bool permanentLock, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginCheckOutDelegate == null)
			{
				this.onBeginCheckOutDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginCheckOut);
			}
			if (this.onEndCheckOutDelegate == null)
			{
				this.onEndCheckOutDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndCheckOut);
			}
			if (this.onCheckOutCompletedDelegate == null)
			{
				this.onCheckOutCompletedDelegate = new SendOrPostCallback(this.OnCheckOutCompleted);
			}
			base.InvokeAsync(this.onBeginCheckOutDelegate, new object[]
			{
				id,
				permanentLock,
				readBackOptions
			}, this.onEndCheckOutDelegate, this.onCheckOutCompletedDelegate, userState);
		}

		public VersionedItemData CheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions)
		{
			return base.Channel.CheckIn(id, removePermanentLock, userComment, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginCheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginCheckIn(id, removePermanentLock, userComment, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public VersionedItemData EndCheckIn(IAsyncResult result)
		{
			return base.Channel.EndCheckIn(result);
		}

		private IAsyncResult OnBeginCheckIn(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			bool removePermanentLock = (bool)inValues[1];
			string userComment = (string)inValues[2];
			ReadOptions readBackOptions = (ReadOptions)inValues[3];
			return this.BeginCheckIn(id, removePermanentLock, userComment, readBackOptions, callback, asyncState);
		}

		private object[] OnEndCheckIn(IAsyncResult result)
		{
			VersionedItemData versionedItemData = this.EndCheckIn(result);
			return new object[]
			{
				versionedItemData
			};
		}

		private void OnCheckInCompleted(object state)
		{
			if (this.CheckInCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CheckInCompleted(this, new CheckInCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void CheckInAsync(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions)
		{
			this.CheckInAsync(id, removePermanentLock, userComment, readBackOptions, null);
		}

		public void CheckInAsync(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginCheckInDelegate == null)
			{
				this.onBeginCheckInDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginCheckIn);
			}
			if (this.onEndCheckInDelegate == null)
			{
				this.onEndCheckInDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndCheckIn);
			}
			if (this.onCheckInCompletedDelegate == null)
			{
				this.onCheckInCompletedDelegate = new SendOrPostCallback(this.OnCheckInCompleted);
			}
			base.InvokeAsync(this.onBeginCheckInDelegate, new object[]
			{
				id,
				removePermanentLock,
				userComment,
				readBackOptions
			}, this.onEndCheckInDelegate, this.onCheckInCompletedDelegate, userState);
		}

		public IdentifiableObjectData Update(IdentifiableObjectData deltaData, ReadOptions readBackOptions)
		{
			return base.Channel.Update(deltaData, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUpdate(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUpdate(deltaData, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData EndUpdate(IAsyncResult result)
		{
			return base.Channel.EndUpdate(result);
		}

		private IAsyncResult OnBeginUpdate(object[] inValues, AsyncCallback callback, object asyncState)
		{
			IdentifiableObjectData deltaData = (IdentifiableObjectData)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginUpdate(deltaData, readBackOptions, callback, asyncState);
		}

		private object[] OnEndUpdate(IAsyncResult result)
		{
			IdentifiableObjectData identifiableObjectData = this.EndUpdate(result);
			return new object[]
			{
				identifiableObjectData
			};
		}

		private void OnUpdateCompleted(object state)
		{
			if (this.UpdateCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UpdateCompleted(this, new UpdateCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UpdateAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions)
		{
			this.UpdateAsync(deltaData, readBackOptions, null);
		}

		public void UpdateAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginUpdateDelegate == null)
			{
				this.onBeginUpdateDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginUpdate);
			}
			if (this.onEndUpdateDelegate == null)
			{
				this.onEndUpdateDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndUpdate);
			}
			if (this.onUpdateCompletedDelegate == null)
			{
				this.onUpdateCompletedDelegate = new SendOrPostCallback(this.OnUpdateCompleted);
			}
			base.InvokeAsync(this.onBeginUpdateDelegate, new object[]
			{
				deltaData,
				readBackOptions
			}, this.onEndUpdateDelegate, this.onUpdateCompletedDelegate, userState);
		}

		public IdentifiableObjectData Create(IdentifiableObjectData data, ReadOptions readBackOptions)
		{
			return base.Channel.Create(data, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginCreate(IdentifiableObjectData data, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginCreate(data, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData EndCreate(IAsyncResult result)
		{
			return base.Channel.EndCreate(result);
		}

		private IAsyncResult OnBeginCreate(object[] inValues, AsyncCallback callback, object asyncState)
		{
			IdentifiableObjectData data = (IdentifiableObjectData)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginCreate(data, readBackOptions, callback, asyncState);
		}

		private object[] OnEndCreate(IAsyncResult result)
		{
			IdentifiableObjectData identifiableObjectData = this.EndCreate(result);
			return new object[]
			{
				identifiableObjectData
			};
		}

		private void OnCreateCompleted(object state)
		{
			if (this.CreateCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CreateCompleted(this, new CreateCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void CreateAsync(IdentifiableObjectData data, ReadOptions readBackOptions)
		{
			this.CreateAsync(data, readBackOptions, null);
		}

		public void CreateAsync(IdentifiableObjectData data, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginCreateDelegate == null)
			{
				this.onBeginCreateDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginCreate);
			}
			if (this.onEndCreateDelegate == null)
			{
				this.onEndCreateDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndCreate);
			}
			if (this.onCreateCompletedDelegate == null)
			{
				this.onCreateCompletedDelegate = new SendOrPostCallback(this.OnCreateCompleted);
			}
			base.InvokeAsync(this.onBeginCreateDelegate, new object[]
			{
				data,
				readBackOptions
			}, this.onEndCreateDelegate, this.onCreateCompletedDelegate, userState);
		}

		public VersionedItemData UndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions)
		{
			return base.Channel.UndoCheckOut(id, permanentLock, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUndoCheckOut(id, permanentLock, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public VersionedItemData EndUndoCheckOut(IAsyncResult result)
		{
			return base.Channel.EndUndoCheckOut(result);
		}

		private IAsyncResult OnBeginUndoCheckOut(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			bool permanentLock = (bool)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginUndoCheckOut(id, permanentLock, readBackOptions, callback, asyncState);
		}

		private object[] OnEndUndoCheckOut(IAsyncResult result)
		{
			VersionedItemData versionedItemData = this.EndUndoCheckOut(result);
			return new object[]
			{
				versionedItemData
			};
		}

		private void OnUndoCheckOutCompleted(object state)
		{
			if (this.UndoCheckOutCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UndoCheckOutCompleted(this, new UndoCheckOutCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UndoCheckOutAsync(string id, bool permanentLock, ReadOptions readBackOptions)
		{
			this.UndoCheckOutAsync(id, permanentLock, readBackOptions, null);
		}

		public void UndoCheckOutAsync(string id, bool permanentLock, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginUndoCheckOutDelegate == null)
			{
				this.onBeginUndoCheckOutDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginUndoCheckOut);
			}
			if (this.onEndUndoCheckOutDelegate == null)
			{
				this.onEndUndoCheckOutDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndUndoCheckOut);
			}
			if (this.onUndoCheckOutCompletedDelegate == null)
			{
				this.onUndoCheckOutCompletedDelegate = new SendOrPostCallback(this.OnUndoCheckOutCompleted);
			}
			base.InvokeAsync(this.onBeginUndoCheckOutDelegate, new object[]
			{
				id,
				permanentLock,
				readBackOptions
			}, this.onEndUndoCheckOutDelegate, this.onUndoCheckOutCompletedDelegate, userState);
		}

		public VersionedItemData Rollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions)
		{
			return base.Channel.Rollback(id, deleteVersions, comment, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginRollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginRollback(id, deleteVersions, comment, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public VersionedItemData EndRollback(IAsyncResult result)
		{
			return base.Channel.EndRollback(result);
		}

		private IAsyncResult OnBeginRollback(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			bool deleteVersions = (bool)inValues[1];
			string comment = (string)inValues[2];
			ReadOptions readBackOptions = (ReadOptions)inValues[3];
			return this.BeginRollback(id, deleteVersions, comment, readBackOptions, callback, asyncState);
		}

		private object[] OnEndRollback(IAsyncResult result)
		{
			VersionedItemData versionedItemData = this.EndRollback(result);
			return new object[]
			{
				versionedItemData
			};
		}

		private void OnRollbackCompleted(object state)
		{
			if (this.RollbackCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RollbackCompleted(this, new RollbackCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void RollbackAsync(string id, bool deleteVersions, string comment, ReadOptions readBackOptions)
		{
			this.RollbackAsync(id, deleteVersions, comment, readBackOptions, null);
		}

		public void RollbackAsync(string id, bool deleteVersions, string comment, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginRollbackDelegate == null)
			{
				this.onBeginRollbackDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginRollback);
			}
			if (this.onEndRollbackDelegate == null)
			{
				this.onEndRollbackDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndRollback);
			}
			if (this.onRollbackCompletedDelegate == null)
			{
				this.onRollbackCompletedDelegate = new SendOrPostCallback(this.OnRollbackCompleted);
			}
			base.InvokeAsync(this.onBeginRollbackDelegate, new object[]
			{
				id,
				deleteVersions,
				comment,
				readBackOptions
			}, this.onEndRollbackDelegate, this.onRollbackCompletedDelegate, userState);
		}

		public RepositoryLocalObjectData Localize(string id, ReadOptions readBackOptions)
		{
			return base.Channel.Localize(id, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginLocalize(id, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public RepositoryLocalObjectData EndLocalize(IAsyncResult result)
		{
			return base.Channel.EndLocalize(result);
		}

		private IAsyncResult OnBeginLocalize(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginLocalize(id, readBackOptions, callback, asyncState);
		}

		private object[] OnEndLocalize(IAsyncResult result)
		{
			RepositoryLocalObjectData repositoryLocalObjectData = this.EndLocalize(result);
			return new object[]
			{
				repositoryLocalObjectData
			};
		}

		private void OnLocalizeCompleted(object state)
		{
			if (this.LocalizeCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.LocalizeCompleted(this, new LocalizeCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void LocalizeAsync(string id, ReadOptions readBackOptions)
		{
			this.LocalizeAsync(id, readBackOptions, null);
		}

		public void LocalizeAsync(string id, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginLocalizeDelegate == null)
			{
				this.onBeginLocalizeDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginLocalize);
			}
			if (this.onEndLocalizeDelegate == null)
			{
				this.onEndLocalizeDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndLocalize);
			}
			if (this.onLocalizeCompletedDelegate == null)
			{
				this.onLocalizeCompletedDelegate = new SendOrPostCallback(this.OnLocalizeCompleted);
			}
			base.InvokeAsync(this.onBeginLocalizeDelegate, new object[]
			{
				id,
				readBackOptions
			}, this.onEndLocalizeDelegate, this.onLocalizeCompletedDelegate, userState);
		}

		public RepositoryLocalObjectData UnLocalize(string id, ReadOptions readBackOptions)
		{
			return base.Channel.UnLocalize(id, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUnLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUnLocalize(id, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public RepositoryLocalObjectData EndUnLocalize(IAsyncResult result)
		{
			return base.Channel.EndUnLocalize(result);
		}

		private IAsyncResult OnBeginUnLocalize(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginUnLocalize(id, readBackOptions, callback, asyncState);
		}

		private object[] OnEndUnLocalize(IAsyncResult result)
		{
			RepositoryLocalObjectData repositoryLocalObjectData = this.EndUnLocalize(result);
			return new object[]
			{
				repositoryLocalObjectData
			};
		}

		private void OnUnLocalizeCompleted(object state)
		{
			if (this.UnLocalizeCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnLocalizeCompleted(this, new UnLocalizeCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UnLocalizeAsync(string id, ReadOptions readBackOptions)
		{
			this.UnLocalizeAsync(id, readBackOptions, null);
		}

		public void UnLocalizeAsync(string id, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginUnLocalizeDelegate == null)
			{
				this.onBeginUnLocalizeDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginUnLocalize);
			}
			if (this.onEndUnLocalizeDelegate == null)
			{
				this.onEndUnLocalizeDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndUnLocalize);
			}
			if (this.onUnLocalizeCompletedDelegate == null)
			{
				this.onUnLocalizeCompletedDelegate = new SendOrPostCallback(this.OnUnLocalizeCompleted);
			}
			base.InvokeAsync(this.onBeginUnLocalizeDelegate, new object[]
			{
				id,
				readBackOptions
			}, this.onEndUnLocalizeDelegate, this.onUnLocalizeCompletedDelegate, userState);
		}

		public OperationResultDataOfRepositoryLocalObjectData Promote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
		{
			return base.Channel.Promote(id, destinationRepositoryId, instruction, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginPromote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginPromote(id, destinationRepositoryId, instruction, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public OperationResultDataOfRepositoryLocalObjectData EndPromote(IAsyncResult result)
		{
			return base.Channel.EndPromote(result);
		}

		private IAsyncResult OnBeginPromote(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string destinationRepositoryId = (string)inValues[1];
			OperationInstruction instruction = (OperationInstruction)inValues[2];
			ReadOptions readBackOptions = (ReadOptions)inValues[3];
			return this.BeginPromote(id, destinationRepositoryId, instruction, readBackOptions, callback, asyncState);
		}

		private object[] OnEndPromote(IAsyncResult result)
		{
			OperationResultDataOfRepositoryLocalObjectData operationResultDataOfRepositoryLocalObjectData = this.EndPromote(result);
			return new object[]
			{
				operationResultDataOfRepositoryLocalObjectData
			};
		}

		private void OnPromoteCompleted(object state)
		{
			if (this.PromoteCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PromoteCompleted(this, new PromoteCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void PromoteAsync(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
		{
			this.PromoteAsync(id, destinationRepositoryId, instruction, readBackOptions, null);
		}

		public void PromoteAsync(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginPromoteDelegate == null)
			{
				this.onBeginPromoteDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginPromote);
			}
			if (this.onEndPromoteDelegate == null)
			{
				this.onEndPromoteDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndPromote);
			}
			if (this.onPromoteCompletedDelegate == null)
			{
				this.onPromoteCompletedDelegate = new SendOrPostCallback(this.OnPromoteCompleted);
			}
			base.InvokeAsync(this.onBeginPromoteDelegate, new object[]
			{
				id,
				destinationRepositoryId,
				instruction,
				readBackOptions
			}, this.onEndPromoteDelegate, this.onPromoteCompletedDelegate, userState);
		}

		public OperationResultDataOfRepositoryLocalObjectData Demote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
		{
			return base.Channel.Demote(id, destinationRepositoryId, instruction, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDemote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDemote(id, destinationRepositoryId, instruction, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public OperationResultDataOfRepositoryLocalObjectData EndDemote(IAsyncResult result)
		{
			return base.Channel.EndDemote(result);
		}

		private IAsyncResult OnBeginDemote(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string destinationRepositoryId = (string)inValues[1];
			OperationInstruction instruction = (OperationInstruction)inValues[2];
			ReadOptions readBackOptions = (ReadOptions)inValues[3];
			return this.BeginDemote(id, destinationRepositoryId, instruction, readBackOptions, callback, asyncState);
		}

		private object[] OnEndDemote(IAsyncResult result)
		{
			OperationResultDataOfRepositoryLocalObjectData operationResultDataOfRepositoryLocalObjectData = this.EndDemote(result);
			return new object[]
			{
				operationResultDataOfRepositoryLocalObjectData
			};
		}

		private void OnDemoteCompleted(object state)
		{
			if (this.DemoteCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.DemoteCompleted(this, new DemoteCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DemoteAsync(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
		{
			this.DemoteAsync(id, destinationRepositoryId, instruction, readBackOptions, null);
		}

		public void DemoteAsync(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginDemoteDelegate == null)
			{
				this.onBeginDemoteDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginDemote);
			}
			if (this.onEndDemoteDelegate == null)
			{
				this.onEndDemoteDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndDemote);
			}
			if (this.onDemoteCompletedDelegate == null)
			{
				this.onDemoteCompletedDelegate = new SendOrPostCallback(this.OnDemoteCompleted);
			}
			base.InvokeAsync(this.onBeginDemoteDelegate, new object[]
			{
				id,
				destinationRepositoryId,
				instruction,
				readBackOptions
			}, this.onEndDemoteDelegate, this.onDemoteCompletedDelegate, userState);
		}

		public TemplateType[] GetListTemplateTypes(ItemType? itemType)
		{
			return base.Channel.GetListTemplateTypes(itemType);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListTemplateTypes(ItemType? itemType, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListTemplateTypes(itemType, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public TemplateType[] EndGetListTemplateTypes(IAsyncResult result)
		{
			return base.Channel.EndGetListTemplateTypes(result);
		}

		private IAsyncResult OnBeginGetListTemplateTypes(object[] inValues, AsyncCallback callback, object asyncState)
		{
			ItemType? itemType = (ItemType?)inValues[0];
			return this.BeginGetListTemplateTypes(itemType, callback, asyncState);
		}

		private object[] OnEndGetListTemplateTypes(IAsyncResult result)
		{
			TemplateType[] array = this.EndGetListTemplateTypes(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListTemplateTypesCompleted(object state)
		{
			if (this.GetListTemplateTypesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListTemplateTypesCompleted(this, new GetListTemplateTypesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListTemplateTypesAsync(ItemType? itemType)
		{
			this.GetListTemplateTypesAsync(itemType, null);
		}

		public void GetListTemplateTypesAsync(ItemType? itemType, object userState)
		{
			if (this.onBeginGetListTemplateTypesDelegate == null)
			{
				this.onBeginGetListTemplateTypesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListTemplateTypes);
			}
			if (this.onEndGetListTemplateTypesDelegate == null)
			{
				this.onEndGetListTemplateTypesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListTemplateTypes);
			}
			if (this.onGetListTemplateTypesCompletedDelegate == null)
			{
				this.onGetListTemplateTypesCompletedDelegate = new SendOrPostCallback(this.OnGetListTemplateTypesCompleted);
			}
			base.InvokeAsync(this.onBeginGetListTemplateTypesDelegate, new object[]
			{
				itemType
			}, this.onEndGetListTemplateTypesDelegate, this.onGetListTemplateTypesCompletedDelegate, userState);
		}

		public PublicationType[] GetListPublicationTypes()
		{
			return base.Channel.GetListPublicationTypes();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListPublicationTypes(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListPublicationTypes(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PublicationType[] EndGetListPublicationTypes(IAsyncResult result)
		{
			return base.Channel.EndGetListPublicationTypes(result);
		}

		private IAsyncResult OnBeginGetListPublicationTypes(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetListPublicationTypes(callback, asyncState);
		}

		private object[] OnEndGetListPublicationTypes(IAsyncResult result)
		{
			PublicationType[] array = this.EndGetListPublicationTypes(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListPublicationTypesCompleted(object state)
		{
			if (this.GetListPublicationTypesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListPublicationTypesCompleted(this, new GetListPublicationTypesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListPublicationTypesAsync()
		{
			this.GetListPublicationTypesAsync(null);
		}

		public void GetListPublicationTypesAsync(object userState)
		{
			if (this.onBeginGetListPublicationTypesDelegate == null)
			{
				this.onBeginGetListPublicationTypesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListPublicationTypes);
			}
			if (this.onEndGetListPublicationTypesDelegate == null)
			{
				this.onEndGetListPublicationTypesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListPublicationTypes);
			}
			if (this.onGetListPublicationTypesCompletedDelegate == null)
			{
				this.onGetListPublicationTypesCompletedDelegate = new SendOrPostCallback(this.OnGetListPublicationTypesCompleted);
			}
			base.InvokeAsync(this.onBeginGetListPublicationTypesDelegate, null, this.onEndGetListPublicationTypesDelegate, this.onGetListPublicationTypesCompletedDelegate, userState);
		}

		public XElement GetSystemWideListXml(SystemWideListFilterData filter)
		{
			return base.Channel.GetSystemWideListXml(filter);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSystemWideListXml(SystemWideListFilterData filter, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSystemWideListXml(filter, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public XElement EndGetSystemWideListXml(IAsyncResult result)
		{
			return base.Channel.EndGetSystemWideListXml(result);
		}

		private IAsyncResult OnBeginGetSystemWideListXml(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SystemWideListFilterData filter = (SystemWideListFilterData)inValues[0];
			return this.BeginGetSystemWideListXml(filter, callback, asyncState);
		}

		private object[] OnEndGetSystemWideListXml(IAsyncResult result)
		{
			XElement xElement = this.EndGetSystemWideListXml(result);
			return new object[]
			{
				xElement
			};
		}

		private void OnGetSystemWideListXmlCompleted(object state)
		{
			if (this.GetSystemWideListXmlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSystemWideListXmlCompleted(this, new GetSystemWideListXmlCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSystemWideListXmlAsync(SystemWideListFilterData filter)
		{
			this.GetSystemWideListXmlAsync(filter, null);
		}

		public void GetSystemWideListXmlAsync(SystemWideListFilterData filter, object userState)
		{
			if (this.onBeginGetSystemWideListXmlDelegate == null)
			{
				this.onBeginGetSystemWideListXmlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSystemWideListXml);
			}
			if (this.onEndGetSystemWideListXmlDelegate == null)
			{
				this.onEndGetSystemWideListXmlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSystemWideListXml);
			}
			if (this.onGetSystemWideListXmlCompletedDelegate == null)
			{
				this.onGetSystemWideListXmlCompletedDelegate = new SendOrPostCallback(this.OnGetSystemWideListXmlCompleted);
			}
			base.InvokeAsync(this.onBeginGetSystemWideListXmlDelegate, new object[]
			{
				filter
			}, this.onEndGetSystemWideListXmlDelegate, this.onGetSystemWideListXmlCompletedDelegate, userState);
		}

		public IdentifiableObjectData[] GetSystemWideList(SystemWideListFilterData filter)
		{
			return base.Channel.GetSystemWideList(filter);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSystemWideList(SystemWideListFilterData filter, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSystemWideList(filter, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData[] EndGetSystemWideList(IAsyncResult result)
		{
			return base.Channel.EndGetSystemWideList(result);
		}

		private IAsyncResult OnBeginGetSystemWideList(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SystemWideListFilterData filter = (SystemWideListFilterData)inValues[0];
			return this.BeginGetSystemWideList(filter, callback, asyncState);
		}

		private object[] OnEndGetSystemWideList(IAsyncResult result)
		{
			IdentifiableObjectData[] array = this.EndGetSystemWideList(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetSystemWideListCompleted(object state)
		{
			if (this.GetSystemWideListCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSystemWideListCompleted(this, new GetSystemWideListCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSystemWideListAsync(SystemWideListFilterData filter)
		{
			this.GetSystemWideListAsync(filter, null);
		}

		public void GetSystemWideListAsync(SystemWideListFilterData filter, object userState)
		{
			if (this.onBeginGetSystemWideListDelegate == null)
			{
				this.onBeginGetSystemWideListDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSystemWideList);
			}
			if (this.onEndGetSystemWideListDelegate == null)
			{
				this.onEndGetSystemWideListDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSystemWideList);
			}
			if (this.onGetSystemWideListCompletedDelegate == null)
			{
				this.onGetSystemWideListCompletedDelegate = new SendOrPostCallback(this.OnGetSystemWideListCompleted);
			}
			base.InvokeAsync(this.onBeginGetSystemWideListDelegate, new object[]
			{
				filter
			}, this.onEndGetSystemWideListDelegate, this.onGetSystemWideListCompletedDelegate, userState);
		}

		public XElement GetListXml(string id, SubjectRelatedListFilterData filter)
		{
			return base.Channel.GetListXml(id, filter);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListXml(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListXml(id, filter, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public XElement EndGetListXml(IAsyncResult result)
		{
			return base.Channel.EndGetListXml(result);
		}

		private IAsyncResult OnBeginGetListXml(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			SubjectRelatedListFilterData filter = (SubjectRelatedListFilterData)inValues[1];
			return this.BeginGetListXml(id, filter, callback, asyncState);
		}

		private object[] OnEndGetListXml(IAsyncResult result)
		{
			XElement xElement = this.EndGetListXml(result);
			return new object[]
			{
				xElement
			};
		}

		private void OnGetListXmlCompleted(object state)
		{
			if (this.GetListXmlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListXmlCompleted(this, new GetListXmlCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListXmlAsync(string id, SubjectRelatedListFilterData filter)
		{
			this.GetListXmlAsync(id, filter, null);
		}

		public void GetListXmlAsync(string id, SubjectRelatedListFilterData filter, object userState)
		{
			if (this.onBeginGetListXmlDelegate == null)
			{
				this.onBeginGetListXmlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListXml);
			}
			if (this.onEndGetListXmlDelegate == null)
			{
				this.onEndGetListXmlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListXml);
			}
			if (this.onGetListXmlCompletedDelegate == null)
			{
				this.onGetListXmlCompletedDelegate = new SendOrPostCallback(this.OnGetListXmlCompleted);
			}
			base.InvokeAsync(this.onBeginGetListXmlDelegate, new object[]
			{
				id,
				filter
			}, this.onEndGetListXmlDelegate, this.onGetListXmlCompletedDelegate, userState);
		}

		public IdentifiableObjectData[] GetList(string id, SubjectRelatedListFilterData filter)
		{
			return base.Channel.GetList(id, filter);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetList(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetList(id, filter, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData[] EndGetList(IAsyncResult result)
		{
			return base.Channel.EndGetList(result);
		}

		private IAsyncResult OnBeginGetList(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			SubjectRelatedListFilterData filter = (SubjectRelatedListFilterData)inValues[1];
			return this.BeginGetList(id, filter, callback, asyncState);
		}

		private object[] OnEndGetList(IAsyncResult result)
		{
			IdentifiableObjectData[] array = this.EndGetList(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListCompleted(object state)
		{
			if (this.GetListCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListCompleted(this, new GetListCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListAsync(string id, SubjectRelatedListFilterData filter)
		{
			this.GetListAsync(id, filter, null);
		}

		public void GetListAsync(string id, SubjectRelatedListFilterData filter, object userState)
		{
			if (this.onBeginGetListDelegate == null)
			{
				this.onBeginGetListDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetList);
			}
			if (this.onEndGetListDelegate == null)
			{
				this.onEndGetListDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetList);
			}
			if (this.onGetListCompletedDelegate == null)
			{
				this.onGetListCompletedDelegate = new SendOrPostCallback(this.OnGetListCompleted);
			}
			base.InvokeAsync(this.onBeginGetListDelegate, new object[]
			{
				id,
				filter
			}, this.onEndGetListDelegate, this.onGetListCompletedDelegate, userState);
		}

		public string[] GetListDirectoryServiceNames()
		{
			return base.Channel.GetListDirectoryServiceNames();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListDirectoryServiceNames(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListDirectoryServiceNames(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string[] EndGetListDirectoryServiceNames(IAsyncResult result)
		{
			return base.Channel.EndGetListDirectoryServiceNames(result);
		}

		private IAsyncResult OnBeginGetListDirectoryServiceNames(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetListDirectoryServiceNames(callback, asyncState);
		}

		private object[] OnEndGetListDirectoryServiceNames(IAsyncResult result)
		{
			string[] array = this.EndGetListDirectoryServiceNames(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListDirectoryServiceNamesCompleted(object state)
		{
			if (this.GetListDirectoryServiceNamesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceNamesCompleted(this, new GetListDirectoryServiceNamesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListDirectoryServiceNamesAsync()
		{
			this.GetListDirectoryServiceNamesAsync(null);
		}

		public void GetListDirectoryServiceNamesAsync(object userState)
		{
			if (this.onBeginGetListDirectoryServiceNamesDelegate == null)
			{
				this.onBeginGetListDirectoryServiceNamesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceNames);
			}
			if (this.onEndGetListDirectoryServiceNamesDelegate == null)
			{
				this.onEndGetListDirectoryServiceNamesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceNames);
			}
			if (this.onGetListDirectoryServiceNamesCompletedDelegate == null)
			{
				this.onGetListDirectoryServiceNamesCompletedDelegate = new SendOrPostCallback(this.OnGetListDirectoryServiceNamesCompleted);
			}
			base.InvokeAsync(this.onBeginGetListDirectoryServiceNamesDelegate, null, this.onEndGetListDirectoryServiceNamesDelegate, this.onGetListDirectoryServiceNamesCompletedDelegate, userState);
		}

		public WindowsUser[] GetListWindowsDomainUsers(string domainName)
		{
			return base.Channel.GetListWindowsDomainUsers(domainName);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListWindowsDomainUsers(string domainName, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListWindowsDomainUsers(domainName, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public WindowsUser[] EndGetListWindowsDomainUsers(IAsyncResult result)
		{
			return base.Channel.EndGetListWindowsDomainUsers(result);
		}

		private IAsyncResult OnBeginGetListWindowsDomainUsers(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string domainName = (string)inValues[0];
			return this.BeginGetListWindowsDomainUsers(domainName, callback, asyncState);
		}

		private object[] OnEndGetListWindowsDomainUsers(IAsyncResult result)
		{
			WindowsUser[] array = this.EndGetListWindowsDomainUsers(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListWindowsDomainUsersCompleted(object state)
		{
			if (this.GetListWindowsDomainUsersCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListWindowsDomainUsersCompleted(this, new GetListWindowsDomainUsersCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListWindowsDomainUsersAsync(string domainName)
		{
			this.GetListWindowsDomainUsersAsync(domainName, null);
		}

		public void GetListWindowsDomainUsersAsync(string domainName, object userState)
		{
			if (this.onBeginGetListWindowsDomainUsersDelegate == null)
			{
				this.onBeginGetListWindowsDomainUsersDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListWindowsDomainUsers);
			}
			if (this.onEndGetListWindowsDomainUsersDelegate == null)
			{
				this.onEndGetListWindowsDomainUsersDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListWindowsDomainUsers);
			}
			if (this.onGetListWindowsDomainUsersCompletedDelegate == null)
			{
				this.onGetListWindowsDomainUsersCompletedDelegate = new SendOrPostCallback(this.OnGetListWindowsDomainUsersCompleted);
			}
			base.InvokeAsync(this.onBeginGetListWindowsDomainUsersDelegate, new object[]
			{
				domainName
			}, this.onEndGetListWindowsDomainUsersDelegate, this.onGetListWindowsDomainUsersCompletedDelegate, userState);
		}

		public DirectoryServiceUser[] GetListDirectoryServiceAllUsers(string directoryServiceName)
		{
			return base.Channel.GetListDirectoryServiceAllUsers(directoryServiceName);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListDirectoryServiceAllUsers(string directoryServiceName, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListDirectoryServiceAllUsers(directoryServiceName, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public DirectoryServiceUser[] EndGetListDirectoryServiceAllUsers(IAsyncResult result)
		{
			return base.Channel.EndGetListDirectoryServiceAllUsers(result);
		}

		private IAsyncResult OnBeginGetListDirectoryServiceAllUsers(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string directoryServiceName = (string)inValues[0];
			return this.BeginGetListDirectoryServiceAllUsers(directoryServiceName, callback, asyncState);
		}

		private object[] OnEndGetListDirectoryServiceAllUsers(IAsyncResult result)
		{
			DirectoryServiceUser[] array = this.EndGetListDirectoryServiceAllUsers(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListDirectoryServiceAllUsersCompleted(object state)
		{
			if (this.GetListDirectoryServiceAllUsersCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceAllUsersCompleted(this, new GetListDirectoryServiceAllUsersCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListDirectoryServiceAllUsersAsync(string directoryServiceName)
		{
			this.GetListDirectoryServiceAllUsersAsync(directoryServiceName, null);
		}

		public void GetListDirectoryServiceAllUsersAsync(string directoryServiceName, object userState)
		{
			if (this.onBeginGetListDirectoryServiceAllUsersDelegate == null)
			{
				this.onBeginGetListDirectoryServiceAllUsersDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceAllUsers);
			}
			if (this.onEndGetListDirectoryServiceAllUsersDelegate == null)
			{
				this.onEndGetListDirectoryServiceAllUsersDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceAllUsers);
			}
			if (this.onGetListDirectoryServiceAllUsersCompletedDelegate == null)
			{
				this.onGetListDirectoryServiceAllUsersCompletedDelegate = new SendOrPostCallback(this.OnGetListDirectoryServiceAllUsersCompleted);
			}
			base.InvokeAsync(this.onBeginGetListDirectoryServiceAllUsersDelegate, new object[]
			{
				directoryServiceName
			}, this.onEndGetListDirectoryServiceAllUsersDelegate, this.onGetListDirectoryServiceAllUsersCompletedDelegate, userState);
		}

		public DirectoryServiceUser[] GetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN)
		{
			return base.Channel.GetListDirectoryServiceGroupMembers(directoryServiceName, groupDN);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListDirectoryServiceGroupMembers(directoryServiceName, groupDN, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public DirectoryServiceUser[] EndGetListDirectoryServiceGroupMembers(IAsyncResult result)
		{
			return base.Channel.EndGetListDirectoryServiceGroupMembers(result);
		}

		private IAsyncResult OnBeginGetListDirectoryServiceGroupMembers(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string directoryServiceName = (string)inValues[0];
			string groupDN = (string)inValues[1];
			return this.BeginGetListDirectoryServiceGroupMembers(directoryServiceName, groupDN, callback, asyncState);
		}

		private object[] OnEndGetListDirectoryServiceGroupMembers(IAsyncResult result)
		{
			DirectoryServiceUser[] array = this.EndGetListDirectoryServiceGroupMembers(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListDirectoryServiceGroupMembersCompleted(object state)
		{
			if (this.GetListDirectoryServiceGroupMembersCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceGroupMembersCompleted(this, new GetListDirectoryServiceGroupMembersCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListDirectoryServiceGroupMembersAsync(string directoryServiceName, string groupDN)
		{
			this.GetListDirectoryServiceGroupMembersAsync(directoryServiceName, groupDN, null);
		}

		public void GetListDirectoryServiceGroupMembersAsync(string directoryServiceName, string groupDN, object userState)
		{
			if (this.onBeginGetListDirectoryServiceGroupMembersDelegate == null)
			{
				this.onBeginGetListDirectoryServiceGroupMembersDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceGroupMembers);
			}
			if (this.onEndGetListDirectoryServiceGroupMembersDelegate == null)
			{
				this.onEndGetListDirectoryServiceGroupMembersDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceGroupMembers);
			}
			if (this.onGetListDirectoryServiceGroupMembersCompletedDelegate == null)
			{
				this.onGetListDirectoryServiceGroupMembersCompletedDelegate = new SendOrPostCallback(this.OnGetListDirectoryServiceGroupMembersCompleted);
			}
			base.InvokeAsync(this.onBeginGetListDirectoryServiceGroupMembersDelegate, new object[]
			{
				directoryServiceName,
				groupDN
			}, this.onEndGetListDirectoryServiceGroupMembersDelegate, this.onGetListDirectoryServiceGroupMembersCompletedDelegate, userState);
		}

		public DirectoryServiceUser[] GetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter)
		{
			return base.Channel.GetListDirectoryServiceUsers(directoryServiceName, filter);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListDirectoryServiceUsers(directoryServiceName, filter, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public DirectoryServiceUser[] EndGetListDirectoryServiceUsers(IAsyncResult result)
		{
			return base.Channel.EndGetListDirectoryServiceUsers(result);
		}

		private IAsyncResult OnBeginGetListDirectoryServiceUsers(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string directoryServiceName = (string)inValues[0];
			DirectoryUsersFilter filter = (DirectoryUsersFilter)inValues[1];
			return this.BeginGetListDirectoryServiceUsers(directoryServiceName, filter, callback, asyncState);
		}

		private object[] OnEndGetListDirectoryServiceUsers(IAsyncResult result)
		{
			DirectoryServiceUser[] array = this.EndGetListDirectoryServiceUsers(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListDirectoryServiceUsersCompleted(object state)
		{
			if (this.GetListDirectoryServiceUsersCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceUsersCompleted(this, new GetListDirectoryServiceUsersCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListDirectoryServiceUsersAsync(string directoryServiceName, DirectoryUsersFilter filter)
		{
			this.GetListDirectoryServiceUsersAsync(directoryServiceName, filter, null);
		}

		public void GetListDirectoryServiceUsersAsync(string directoryServiceName, DirectoryUsersFilter filter, object userState)
		{
			if (this.onBeginGetListDirectoryServiceUsersDelegate == null)
			{
				this.onBeginGetListDirectoryServiceUsersDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceUsers);
			}
			if (this.onEndGetListDirectoryServiceUsersDelegate == null)
			{
				this.onEndGetListDirectoryServiceUsersDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceUsers);
			}
			if (this.onGetListDirectoryServiceUsersCompletedDelegate == null)
			{
				this.onGetListDirectoryServiceUsersCompletedDelegate = new SendOrPostCallback(this.OnGetListDirectoryServiceUsersCompleted);
			}
			base.InvokeAsync(this.onBeginGetListDirectoryServiceUsersDelegate, new object[]
			{
				directoryServiceName,
				filter
			}, this.onEndGetListDirectoryServiceUsersDelegate, this.onGetListDirectoryServiceUsersCompletedDelegate, userState);
		}

		public ClassificationInfoData Classify(string id, string[] keywordIds, ReadOptions readOptions)
		{
			return base.Channel.Classify(id, keywordIds, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginClassify(id, keywordIds, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ClassificationInfoData EndClassify(IAsyncResult result)
		{
			return base.Channel.EndClassify(result);
		}

		private IAsyncResult OnBeginClassify(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string[] keywordIds = (string[])inValues[1];
			ReadOptions readOptions = (ReadOptions)inValues[2];
			return this.BeginClassify(id, keywordIds, readOptions, callback, asyncState);
		}

		private object[] OnEndClassify(IAsyncResult result)
		{
			ClassificationInfoData classificationInfoData = this.EndClassify(result);
			return new object[]
			{
				classificationInfoData
			};
		}

		private void OnClassifyCompleted(object state)
		{
			if (this.ClassifyCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ClassifyCompleted(this, new ClassifyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions)
		{
			this.ClassifyAsync(id, keywordIds, readOptions, null);
		}

		public void ClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions, object userState)
		{
			if (this.onBeginClassifyDelegate == null)
			{
				this.onBeginClassifyDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginClassify);
			}
			if (this.onEndClassifyDelegate == null)
			{
				this.onEndClassifyDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndClassify);
			}
			if (this.onClassifyCompletedDelegate == null)
			{
				this.onClassifyCompletedDelegate = new SendOrPostCallback(this.OnClassifyCompleted);
			}
			base.InvokeAsync(this.onBeginClassifyDelegate, new object[]
			{
				id,
				keywordIds,
				readOptions
			}, this.onEndClassifyDelegate, this.onClassifyCompletedDelegate, userState);
		}

		public ClassificationInfoData UnClassify(string id, string[] keywordIds, ReadOptions readOptions)
		{
			return base.Channel.UnClassify(id, keywordIds, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUnClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUnClassify(id, keywordIds, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ClassificationInfoData EndUnClassify(IAsyncResult result)
		{
			return base.Channel.EndUnClassify(result);
		}

		private IAsyncResult OnBeginUnClassify(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string[] keywordIds = (string[])inValues[1];
			ReadOptions readOptions = (ReadOptions)inValues[2];
			return this.BeginUnClassify(id, keywordIds, readOptions, callback, asyncState);
		}

		private object[] OnEndUnClassify(IAsyncResult result)
		{
			ClassificationInfoData classificationInfoData = this.EndUnClassify(result);
			return new object[]
			{
				classificationInfoData
			};
		}

		private void OnUnClassifyCompleted(object state)
		{
			if (this.UnClassifyCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnClassifyCompleted(this, new UnClassifyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UnClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions)
		{
			this.UnClassifyAsync(id, keywordIds, readOptions, null);
		}

		public void UnClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions, object userState)
		{
			if (this.onBeginUnClassifyDelegate == null)
			{
				this.onBeginUnClassifyDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginUnClassify);
			}
			if (this.onEndUnClassifyDelegate == null)
			{
				this.onEndUnClassifyDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndUnClassify);
			}
			if (this.onUnClassifyCompletedDelegate == null)
			{
				this.onUnClassifyCompletedDelegate = new SendOrPostCallback(this.OnUnClassifyCompleted);
			}
			base.InvokeAsync(this.onBeginUnClassifyDelegate, new object[]
			{
				id,
				keywordIds,
				readOptions
			}, this.onEndUnClassifyDelegate, this.onUnClassifyCompletedDelegate, userState);
		}

		public ClassificationInfoData ReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions)
		{
			return base.Channel.ReClassify(id, keywordIdsToRemove, keywordIdsToAdd, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginReClassify(id, keywordIdsToRemove, keywordIdsToAdd, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ClassificationInfoData EndReClassify(IAsyncResult result)
		{
			return base.Channel.EndReClassify(result);
		}

		private IAsyncResult OnBeginReClassify(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			string[] keywordIdsToRemove = (string[])inValues[1];
			string[] keywordIdsToAdd = (string[])inValues[2];
			ReadOptions readOptions = (ReadOptions)inValues[3];
			return this.BeginReClassify(id, keywordIdsToRemove, keywordIdsToAdd, readOptions, callback, asyncState);
		}

		private object[] OnEndReClassify(IAsyncResult result)
		{
			ClassificationInfoData classificationInfoData = this.EndReClassify(result);
			return new object[]
			{
				classificationInfoData
			};
		}

		private void OnReClassifyCompleted(object state)
		{
			if (this.ReClassifyCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReClassifyCompleted(this, new ReClassifyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReClassifyAsync(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions)
		{
			this.ReClassifyAsync(id, keywordIdsToRemove, keywordIdsToAdd, readOptions, null);
		}

		public void ReClassifyAsync(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions, object userState)
		{
			if (this.onBeginReClassifyDelegate == null)
			{
				this.onBeginReClassifyDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginReClassify);
			}
			if (this.onEndReClassifyDelegate == null)
			{
				this.onEndReClassifyDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndReClassify);
			}
			if (this.onReClassifyCompletedDelegate == null)
			{
				this.onReClassifyCompletedDelegate = new SendOrPostCallback(this.OnReClassifyCompleted);
			}
			base.InvokeAsync(this.onBeginReClassifyDelegate, new object[]
			{
				id,
				keywordIdsToRemove,
				keywordIdsToAdd,
				readOptions
			}, this.onEndReClassifyDelegate, this.onReClassifyCompletedDelegate, userState);
		}

		public ActivityInstanceData StartActivity(string activityInstanceId, ReadOptions readBackOptions)
		{
			return base.Channel.StartActivity(activityInstanceId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginStartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginStartActivity(activityInstanceId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ActivityInstanceData EndStartActivity(IAsyncResult result)
		{
			return base.Channel.EndStartActivity(result);
		}

		private IAsyncResult OnBeginStartActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string activityInstanceId = (string)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginStartActivity(activityInstanceId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndStartActivity(IAsyncResult result)
		{
			ActivityInstanceData activityInstanceData = this.EndStartActivity(result);
			return new object[]
			{
				activityInstanceData
			};
		}

		private void OnStartActivityCompleted(object state)
		{
			if (this.StartActivityCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.StartActivityCompleted(this, new StartActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void StartActivityAsync(string activityInstanceId, ReadOptions readBackOptions)
		{
			this.StartActivityAsync(activityInstanceId, readBackOptions, null);
		}

		public void StartActivityAsync(string activityInstanceId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginStartActivityDelegate == null)
			{
				this.onBeginStartActivityDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginStartActivity);
			}
			if (this.onEndStartActivityDelegate == null)
			{
				this.onEndStartActivityDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndStartActivity);
			}
			if (this.onStartActivityCompletedDelegate == null)
			{
				this.onStartActivityCompletedDelegate = new SendOrPostCallback(this.OnStartActivityCompleted);
			}
			base.InvokeAsync(this.onBeginStartActivityDelegate, new object[]
			{
				activityInstanceId,
				readBackOptions
			}, this.onEndStartActivityDelegate, this.onStartActivityCompletedDelegate, userState);
		}

		public ActivityInstanceData SuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions)
		{
			return base.Channel.SuspendActivity(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSuspendActivity(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ActivityInstanceData EndSuspendActivity(IAsyncResult result)
		{
			return base.Channel.EndSuspendActivity(result);
		}

		private IAsyncResult OnBeginSuspendActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string activityInstanceId = (string)inValues[0];
			string reason = (string)inValues[1];
			DateTime? resumeAt = (DateTime?)inValues[2];
			string resumeBookmark = (string)inValues[3];
			ReadOptions readBackOptions = (ReadOptions)inValues[4];
			return this.BeginSuspendActivity(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions, callback, asyncState);
		}

		private object[] OnEndSuspendActivity(IAsyncResult result)
		{
			ActivityInstanceData activityInstanceData = this.EndSuspendActivity(result);
			return new object[]
			{
				activityInstanceData
			};
		}

		private void OnSuspendActivityCompleted(object state)
		{
			if (this.SuspendActivityCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SuspendActivityCompleted(this, new SuspendActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SuspendActivityAsync(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions)
		{
			this.SuspendActivityAsync(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions, null);
		}

		public void SuspendActivityAsync(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginSuspendActivityDelegate == null)
			{
				this.onBeginSuspendActivityDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSuspendActivity);
			}
			if (this.onEndSuspendActivityDelegate == null)
			{
				this.onEndSuspendActivityDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSuspendActivity);
			}
			if (this.onSuspendActivityCompletedDelegate == null)
			{
				this.onSuspendActivityCompletedDelegate = new SendOrPostCallback(this.OnSuspendActivityCompleted);
			}
			base.InvokeAsync(this.onBeginSuspendActivityDelegate, new object[]
			{
				activityInstanceId,
				reason,
				resumeAt,
				resumeBookmark,
				readBackOptions
			}, this.onEndSuspendActivityDelegate, this.onSuspendActivityCompletedDelegate, userState);
		}

		public ActivityInstanceData RestartActivity(string activityInstanceId, ReadOptions readBackOptions)
		{
			return base.Channel.RestartActivity(activityInstanceId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginRestartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginRestartActivity(activityInstanceId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ActivityInstanceData EndRestartActivity(IAsyncResult result)
		{
			return base.Channel.EndRestartActivity(result);
		}

		private IAsyncResult OnBeginRestartActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string activityInstanceId = (string)inValues[0];
			ReadOptions readBackOptions = (ReadOptions)inValues[1];
			return this.BeginRestartActivity(activityInstanceId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndRestartActivity(IAsyncResult result)
		{
			ActivityInstanceData activityInstanceData = this.EndRestartActivity(result);
			return new object[]
			{
				activityInstanceData
			};
		}

		private void OnRestartActivityCompleted(object state)
		{
			if (this.RestartActivityCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RestartActivityCompleted(this, new RestartActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void RestartActivityAsync(string activityInstanceId, ReadOptions readBackOptions)
		{
			this.RestartActivityAsync(activityInstanceId, readBackOptions, null);
		}

		public void RestartActivityAsync(string activityInstanceId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginRestartActivityDelegate == null)
			{
				this.onBeginRestartActivityDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginRestartActivity);
			}
			if (this.onEndRestartActivityDelegate == null)
			{
				this.onEndRestartActivityDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndRestartActivity);
			}
			if (this.onRestartActivityCompletedDelegate == null)
			{
				this.onRestartActivityCompletedDelegate = new SendOrPostCallback(this.OnRestartActivityCompleted);
			}
			base.InvokeAsync(this.onBeginRestartActivityDelegate, new object[]
			{
				activityInstanceId,
				readBackOptions
			}, this.onEndRestartActivityDelegate, this.onRestartActivityCompletedDelegate, userState);
		}

		public ActivityInstanceData ReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions)
		{
			return base.Channel.ReAssignActivity(activityInstanceId, newAssigneeId, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginReAssignActivity(activityInstanceId, newAssigneeId, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ActivityInstanceData EndReAssignActivity(IAsyncResult result)
		{
			return base.Channel.EndReAssignActivity(result);
		}

		private IAsyncResult OnBeginReAssignActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string activityInstanceId = (string)inValues[0];
			string newAssigneeId = (string)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginReAssignActivity(activityInstanceId, newAssigneeId, readBackOptions, callback, asyncState);
		}

		private object[] OnEndReAssignActivity(IAsyncResult result)
		{
			ActivityInstanceData activityInstanceData = this.EndReAssignActivity(result);
			return new object[]
			{
				activityInstanceData
			};
		}

		private void OnReAssignActivityCompleted(object state)
		{
			if (this.ReAssignActivityCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReAssignActivityCompleted(this, new ReAssignActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReAssignActivityAsync(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions)
		{
			this.ReAssignActivityAsync(activityInstanceId, newAssigneeId, readBackOptions, null);
		}

		public void ReAssignActivityAsync(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginReAssignActivityDelegate == null)
			{
				this.onBeginReAssignActivityDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginReAssignActivity);
			}
			if (this.onEndReAssignActivityDelegate == null)
			{
				this.onEndReAssignActivityDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndReAssignActivity);
			}
			if (this.onReAssignActivityCompletedDelegate == null)
			{
				this.onReAssignActivityCompletedDelegate = new SendOrPostCallback(this.OnReAssignActivityCompleted);
			}
			base.InvokeAsync(this.onBeginReAssignActivityDelegate, new object[]
			{
				activityInstanceId,
				newAssigneeId,
				readBackOptions
			}, this.onEndReAssignActivityDelegate, this.onReAssignActivityCompletedDelegate, userState);
		}

		public ActivityInstanceData FinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions)
		{
			return base.Channel.FinishActivity(activityInstanceId, activityFinishData, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginFinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginFinishActivity(activityInstanceId, activityFinishData, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ActivityInstanceData EndFinishActivity(IAsyncResult result)
		{
			return base.Channel.EndFinishActivity(result);
		}

		private IAsyncResult OnBeginFinishActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string activityInstanceId = (string)inValues[0];
			ActivityFinishData activityFinishData = (ActivityFinishData)inValues[1];
			ReadOptions readOptions = (ReadOptions)inValues[2];
			return this.BeginFinishActivity(activityInstanceId, activityFinishData, readOptions, callback, asyncState);
		}

		private object[] OnEndFinishActivity(IAsyncResult result)
		{
			ActivityInstanceData activityInstanceData = this.EndFinishActivity(result);
			return new object[]
			{
				activityInstanceData
			};
		}

		private void OnFinishActivityCompleted(object state)
		{
			if (this.FinishActivityCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.FinishActivityCompleted(this, new FinishActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void FinishActivityAsync(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions)
		{
			this.FinishActivityAsync(activityInstanceId, activityFinishData, readOptions, null);
		}

		public void FinishActivityAsync(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions, object userState)
		{
			if (this.onBeginFinishActivityDelegate == null)
			{
				this.onBeginFinishActivityDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginFinishActivity);
			}
			if (this.onEndFinishActivityDelegate == null)
			{
				this.onEndFinishActivityDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndFinishActivity);
			}
			if (this.onFinishActivityCompletedDelegate == null)
			{
				this.onFinishActivityCompletedDelegate = new SendOrPostCallback(this.OnFinishActivityCompleted);
			}
			base.InvokeAsync(this.onBeginFinishActivityDelegate, new object[]
			{
				activityInstanceId,
				activityFinishData,
				readOptions
			}, this.onEndFinishActivityDelegate, this.onFinishActivityCompletedDelegate, userState);
		}

		public ProcessHistoryData ForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions)
		{
			return base.Channel.ForceFinishProcess(processInstanceId, approvalStatusId, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginForceFinishProcess(processInstanceId, approvalStatusId, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ProcessHistoryData EndForceFinishProcess(IAsyncResult result)
		{
			return base.Channel.EndForceFinishProcess(result);
		}

		private IAsyncResult OnBeginForceFinishProcess(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string processInstanceId = (string)inValues[0];
			string approvalStatusId = (string)inValues[1];
			ReadOptions readOptions = (ReadOptions)inValues[2];
			return this.BeginForceFinishProcess(processInstanceId, approvalStatusId, readOptions, callback, asyncState);
		}

		private object[] OnEndForceFinishProcess(IAsyncResult result)
		{
			ProcessHistoryData processHistoryData = this.EndForceFinishProcess(result);
			return new object[]
			{
				processHistoryData
			};
		}

		private void OnForceFinishProcessCompleted(object state)
		{
			if (this.ForceFinishProcessCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ForceFinishProcessCompleted(this, new ForceFinishProcessCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ForceFinishProcessAsync(string processInstanceId, string approvalStatusId, ReadOptions readOptions)
		{
			this.ForceFinishProcessAsync(processInstanceId, approvalStatusId, readOptions, null);
		}

		public void ForceFinishProcessAsync(string processInstanceId, string approvalStatusId, ReadOptions readOptions, object userState)
		{
			if (this.onBeginForceFinishProcessDelegate == null)
			{
				this.onBeginForceFinishProcessDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginForceFinishProcess);
			}
			if (this.onEndForceFinishProcessDelegate == null)
			{
				this.onEndForceFinishProcessDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndForceFinishProcess);
			}
			if (this.onForceFinishProcessCompletedDelegate == null)
			{
				this.onForceFinishProcessCompletedDelegate = new SendOrPostCallback(this.OnForceFinishProcessCompleted);
			}
			base.InvokeAsync(this.onBeginForceFinishProcessDelegate, new object[]
			{
				processInstanceId,
				approvalStatusId,
				readOptions
			}, this.onEndForceFinishProcessDelegate, this.onForceFinishProcessCompletedDelegate, userState);
		}

		public ActivityInstanceData ResumeActivity(string activityInstanceId, ReadOptions readOptions)
		{
			return base.Channel.ResumeActivity(activityInstanceId, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginResumeActivity(string activityInstanceId, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginResumeActivity(activityInstanceId, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ActivityInstanceData EndResumeActivity(IAsyncResult result)
		{
			return base.Channel.EndResumeActivity(result);
		}

		private IAsyncResult OnBeginResumeActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string activityInstanceId = (string)inValues[0];
			ReadOptions readOptions = (ReadOptions)inValues[1];
			return this.BeginResumeActivity(activityInstanceId, readOptions, callback, asyncState);
		}

		private object[] OnEndResumeActivity(IAsyncResult result)
		{
			ActivityInstanceData activityInstanceData = this.EndResumeActivity(result);
			return new object[]
			{
				activityInstanceData
			};
		}

		private void OnResumeActivityCompleted(object state)
		{
			if (this.ResumeActivityCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResumeActivityCompleted(this, new ResumeActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ResumeActivityAsync(string activityInstanceId, ReadOptions readOptions)
		{
			this.ResumeActivityAsync(activityInstanceId, readOptions, null);
		}

		public void ResumeActivityAsync(string activityInstanceId, ReadOptions readOptions, object userState)
		{
			if (this.onBeginResumeActivityDelegate == null)
			{
				this.onBeginResumeActivityDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginResumeActivity);
			}
			if (this.onEndResumeActivityDelegate == null)
			{
				this.onEndResumeActivityDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndResumeActivity);
			}
			if (this.onResumeActivityCompletedDelegate == null)
			{
				this.onResumeActivityCompletedDelegate = new SendOrPostCallback(this.OnResumeActivityCompleted);
			}
			base.InvokeAsync(this.onBeginResumeActivityDelegate, new object[]
			{
				activityInstanceId,
				readOptions
			}, this.onEndResumeActivityDelegate, this.onResumeActivityCompletedDelegate, userState);
		}

		public QueueMessageData[] GetListQueueMessages(int queueId)
		{
			return base.Channel.GetListQueueMessages(queueId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListQueueMessages(int queueId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListQueueMessages(queueId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public QueueMessageData[] EndGetListQueueMessages(IAsyncResult result)
		{
			return base.Channel.EndGetListQueueMessages(result);
		}

		private IAsyncResult OnBeginGetListQueueMessages(object[] inValues, AsyncCallback callback, object asyncState)
		{
			int queueId = (int)inValues[0];
			return this.BeginGetListQueueMessages(queueId, callback, asyncState);
		}

		private object[] OnEndGetListQueueMessages(IAsyncResult result)
		{
			QueueMessageData[] array = this.EndGetListQueueMessages(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListQueueMessagesCompleted(object state)
		{
			if (this.GetListQueueMessagesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListQueueMessagesCompleted(this, new GetListQueueMessagesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListQueueMessagesAsync(int queueId)
		{
			this.GetListQueueMessagesAsync(queueId, null);
		}

		public void GetListQueueMessagesAsync(int queueId, object userState)
		{
			if (this.onBeginGetListQueueMessagesDelegate == null)
			{
				this.onBeginGetListQueueMessagesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListQueueMessages);
			}
			if (this.onEndGetListQueueMessagesDelegate == null)
			{
				this.onEndGetListQueueMessagesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListQueueMessages);
			}
			if (this.onGetListQueueMessagesCompletedDelegate == null)
			{
				this.onGetListQueueMessagesCompletedDelegate = new SendOrPostCallback(this.OnGetListQueueMessagesCompleted);
			}
			base.InvokeAsync(this.onBeginGetListQueueMessagesDelegate, new object[]
			{
				queueId
			}, this.onEndGetListQueueMessagesDelegate, this.onGetListQueueMessagesCompletedDelegate, userState);
		}

		public void PurgeQueue(int queueId)
		{
			base.Channel.PurgeQueue(queueId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginPurgeQueue(int queueId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginPurgeQueue(queueId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndPurgeQueue(IAsyncResult result)
		{
			base.Channel.EndPurgeQueue(result);
		}

		private IAsyncResult OnBeginPurgeQueue(object[] inValues, AsyncCallback callback, object asyncState)
		{
			int queueId = (int)inValues[0];
			return this.BeginPurgeQueue(queueId, callback, asyncState);
		}

		private object[] OnEndPurgeQueue(IAsyncResult result)
		{
			this.EndPurgeQueue(result);
			return null;
		}

		private void OnPurgeQueueCompleted(object state)
		{
			if (this.PurgeQueueCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PurgeQueueCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void PurgeQueueAsync(int queueId)
		{
			this.PurgeQueueAsync(queueId, null);
		}

		public void PurgeQueueAsync(int queueId, object userState)
		{
			if (this.onBeginPurgeQueueDelegate == null)
			{
				this.onBeginPurgeQueueDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginPurgeQueue);
			}
			if (this.onEndPurgeQueueDelegate == null)
			{
				this.onEndPurgeQueueDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndPurgeQueue);
			}
			if (this.onPurgeQueueCompletedDelegate == null)
			{
				this.onPurgeQueueCompletedDelegate = new SendOrPostCallback(this.OnPurgeQueueCompleted);
			}
			base.InvokeAsync(this.onBeginPurgeQueueDelegate, new object[]
			{
				queueId
			}, this.onEndPurgeQueueDelegate, this.onPurgeQueueCompletedDelegate, userState);
		}

		public QueueData[] GetListQueues()
		{
			return base.Channel.GetListQueues();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListQueues(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListQueues(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public QueueData[] EndGetListQueues(IAsyncResult result)
		{
			return base.Channel.EndGetListQueues(result);
		}

		private IAsyncResult OnBeginGetListQueues(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetListQueues(callback, asyncState);
		}

		private object[] OnEndGetListQueues(IAsyncResult result)
		{
			QueueData[] array = this.EndGetListQueues(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListQueuesCompleted(object state)
		{
			if (this.GetListQueuesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListQueuesCompleted(this, new GetListQueuesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListQueuesAsync()
		{
			this.GetListQueuesAsync(null);
		}

		public void GetListQueuesAsync(object userState)
		{
			if (this.onBeginGetListQueuesDelegate == null)
			{
				this.onBeginGetListQueuesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListQueues);
			}
			if (this.onEndGetListQueuesDelegate == null)
			{
				this.onEndGetListQueuesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListQueues);
			}
			if (this.onGetListQueuesCompletedDelegate == null)
			{
				this.onGetListQueuesCompletedDelegate = new SendOrPostCallback(this.OnGetListQueuesCompleted);
			}
			base.InvokeAsync(this.onBeginGetListQueuesDelegate, null, this.onEndGetListQueuesDelegate, this.onGetListQueuesCompletedDelegate, userState);
		}

		public ApplicationData ReadApplicationData(string subjectId, string applicationId)
		{
			return base.Channel.ReadApplicationData(subjectId, applicationId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginReadApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginReadApplicationData(subjectId, applicationId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ApplicationData EndReadApplicationData(IAsyncResult result)
		{
			return base.Channel.EndReadApplicationData(result);
		}

		private IAsyncResult OnBeginReadApplicationData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string subjectId = (string)inValues[0];
			string applicationId = (string)inValues[1];
			return this.BeginReadApplicationData(subjectId, applicationId, callback, asyncState);
		}

		private object[] OnEndReadApplicationData(IAsyncResult result)
		{
			ApplicationData applicationData = this.EndReadApplicationData(result);
			return new object[]
			{
				applicationData
			};
		}

		private void OnReadApplicationDataCompleted(object state)
		{
			if (this.ReadApplicationDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadApplicationDataCompleted(this, new ReadApplicationDataCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReadApplicationDataAsync(string subjectId, string applicationId)
		{
			this.ReadApplicationDataAsync(subjectId, applicationId, null);
		}

		public void ReadApplicationDataAsync(string subjectId, string applicationId, object userState)
		{
			if (this.onBeginReadApplicationDataDelegate == null)
			{
				this.onBeginReadApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginReadApplicationData);
			}
			if (this.onEndReadApplicationDataDelegate == null)
			{
				this.onEndReadApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndReadApplicationData);
			}
			if (this.onReadApplicationDataCompletedDelegate == null)
			{
				this.onReadApplicationDataCompletedDelegate = new SendOrPostCallback(this.OnReadApplicationDataCompleted);
			}
			base.InvokeAsync(this.onBeginReadApplicationDataDelegate, new object[]
			{
				subjectId,
				applicationId
			}, this.onEndReadApplicationDataDelegate, this.onReadApplicationDataCompletedDelegate, userState);
		}

		public ApplicationData[] ReadAllApplicationData(string subjectId)
		{
			return base.Channel.ReadAllApplicationData(subjectId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginReadAllApplicationData(string subjectId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginReadAllApplicationData(subjectId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ApplicationData[] EndReadAllApplicationData(IAsyncResult result)
		{
			return base.Channel.EndReadAllApplicationData(result);
		}

		private IAsyncResult OnBeginReadAllApplicationData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string subjectId = (string)inValues[0];
			return this.BeginReadAllApplicationData(subjectId, callback, asyncState);
		}

		private object[] OnEndReadAllApplicationData(IAsyncResult result)
		{
			ApplicationData[] array = this.EndReadAllApplicationData(result);
			return new object[]
			{
				array
			};
		}

		private void OnReadAllApplicationDataCompleted(object state)
		{
			if (this.ReadAllApplicationDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadAllApplicationDataCompleted(this, new ReadAllApplicationDataCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReadAllApplicationDataAsync(string subjectId)
		{
			this.ReadAllApplicationDataAsync(subjectId, null);
		}

		public void ReadAllApplicationDataAsync(string subjectId, object userState)
		{
			if (this.onBeginReadAllApplicationDataDelegate == null)
			{
				this.onBeginReadAllApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginReadAllApplicationData);
			}
			if (this.onEndReadAllApplicationDataDelegate == null)
			{
				this.onEndReadAllApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndReadAllApplicationData);
			}
			if (this.onReadAllApplicationDataCompletedDelegate == null)
			{
				this.onReadAllApplicationDataCompletedDelegate = new SendOrPostCallback(this.OnReadAllApplicationDataCompleted);
			}
			base.InvokeAsync(this.onBeginReadAllApplicationDataDelegate, new object[]
			{
				subjectId
			}, this.onEndReadAllApplicationDataDelegate, this.onReadAllApplicationDataCompletedDelegate, userState);
		}

		public void SaveApplicationData(string subjectId, ApplicationData[] applicationData)
		{
			base.Channel.SaveApplicationData(subjectId, applicationData);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSaveApplicationData(string subjectId, ApplicationData[] applicationData, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSaveApplicationData(subjectId, applicationData, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndSaveApplicationData(IAsyncResult result)
		{
			base.Channel.EndSaveApplicationData(result);
		}

		private IAsyncResult OnBeginSaveApplicationData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string subjectId = (string)inValues[0];
			ApplicationData[] applicationData = (ApplicationData[])inValues[1];
			return this.BeginSaveApplicationData(subjectId, applicationData, callback, asyncState);
		}

		private object[] OnEndSaveApplicationData(IAsyncResult result)
		{
			this.EndSaveApplicationData(result);
			return null;
		}

		private void OnSaveApplicationDataCompleted(object state)
		{
			if (this.SaveApplicationDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SaveApplicationDataCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SaveApplicationDataAsync(string subjectId, ApplicationData[] applicationData)
		{
			this.SaveApplicationDataAsync(subjectId, applicationData, null);
		}

		public void SaveApplicationDataAsync(string subjectId, ApplicationData[] applicationData, object userState)
		{
			if (this.onBeginSaveApplicationDataDelegate == null)
			{
				this.onBeginSaveApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSaveApplicationData);
			}
			if (this.onEndSaveApplicationDataDelegate == null)
			{
				this.onEndSaveApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSaveApplicationData);
			}
			if (this.onSaveApplicationDataCompletedDelegate == null)
			{
				this.onSaveApplicationDataCompletedDelegate = new SendOrPostCallback(this.OnSaveApplicationDataCompleted);
			}
			base.InvokeAsync(this.onBeginSaveApplicationDataDelegate, new object[]
			{
				subjectId,
				applicationData
			}, this.onEndSaveApplicationDataDelegate, this.onSaveApplicationDataCompletedDelegate, userState);
		}

		public void DeleteApplicationData(string subjectId, string applicationId)
		{
			base.Channel.DeleteApplicationData(subjectId, applicationId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDeleteApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDeleteApplicationData(subjectId, applicationId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndDeleteApplicationData(IAsyncResult result)
		{
			base.Channel.EndDeleteApplicationData(result);
		}

		private IAsyncResult OnBeginDeleteApplicationData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string subjectId = (string)inValues[0];
			string applicationId = (string)inValues[1];
			return this.BeginDeleteApplicationData(subjectId, applicationId, callback, asyncState);
		}

		private object[] OnEndDeleteApplicationData(IAsyncResult result)
		{
			this.EndDeleteApplicationData(result);
			return null;
		}

		private void OnDeleteApplicationDataCompleted(object state)
		{
			if (this.DeleteApplicationDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.DeleteApplicationDataCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DeleteApplicationDataAsync(string subjectId, string applicationId)
		{
			this.DeleteApplicationDataAsync(subjectId, applicationId, null);
		}

		public void DeleteApplicationDataAsync(string subjectId, string applicationId, object userState)
		{
			if (this.onBeginDeleteApplicationDataDelegate == null)
			{
				this.onBeginDeleteApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginDeleteApplicationData);
			}
			if (this.onEndDeleteApplicationDataDelegate == null)
			{
				this.onEndDeleteApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndDeleteApplicationData);
			}
			if (this.onDeleteApplicationDataCompletedDelegate == null)
			{
				this.onDeleteApplicationDataCompletedDelegate = new SendOrPostCallback(this.OnDeleteApplicationDataCompleted);
			}
			base.InvokeAsync(this.onBeginDeleteApplicationDataDelegate, new object[]
			{
				subjectId,
				applicationId
			}, this.onEndDeleteApplicationDataDelegate, this.onDeleteApplicationDataCompletedDelegate, userState);
		}

		public string[] GetApplicationIds()
		{
			return base.Channel.GetApplicationIds();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetApplicationIds(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetApplicationIds(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string[] EndGetApplicationIds(IAsyncResult result)
		{
			return base.Channel.EndGetApplicationIds(result);
		}

		private IAsyncResult OnBeginGetApplicationIds(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetApplicationIds(callback, asyncState);
		}

		private object[] OnEndGetApplicationIds(IAsyncResult result)
		{
			string[] array = this.EndGetApplicationIds(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetApplicationIdsCompleted(object state)
		{
			if (this.GetApplicationIdsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetApplicationIdsCompleted(this, new GetApplicationIdsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetApplicationIdsAsync()
		{
			this.GetApplicationIdsAsync(null);
		}

		public void GetApplicationIdsAsync(object userState)
		{
			if (this.onBeginGetApplicationIdsDelegate == null)
			{
				this.onBeginGetApplicationIdsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetApplicationIds);
			}
			if (this.onEndGetApplicationIdsDelegate == null)
			{
				this.onEndGetApplicationIdsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetApplicationIds);
			}
			if (this.onGetApplicationIdsCompletedDelegate == null)
			{
				this.onGetApplicationIdsCompletedDelegate = new SendOrPostCallback(this.OnGetApplicationIdsCompleted);
			}
			base.InvokeAsync(this.onBeginGetApplicationIdsDelegate, null, this.onEndGetApplicationIdsDelegate, this.onGetApplicationIdsCompletedDelegate, userState);
		}

		public void PurgeApplicationData(string applicationId)
		{
			base.Channel.PurgeApplicationData(applicationId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginPurgeApplicationData(string applicationId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginPurgeApplicationData(applicationId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndPurgeApplicationData(IAsyncResult result)
		{
			base.Channel.EndPurgeApplicationData(result);
		}

		private IAsyncResult OnBeginPurgeApplicationData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string applicationId = (string)inValues[0];
			return this.BeginPurgeApplicationData(applicationId, callback, asyncState);
		}

		private object[] OnEndPurgeApplicationData(IAsyncResult result)
		{
			this.EndPurgeApplicationData(result);
			return null;
		}

		private void OnPurgeApplicationDataCompleted(object state)
		{
			if (this.PurgeApplicationDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PurgeApplicationDataCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void PurgeApplicationDataAsync(string applicationId)
		{
			this.PurgeApplicationDataAsync(applicationId, null);
		}

		public void PurgeApplicationDataAsync(string applicationId, object userState)
		{
			if (this.onBeginPurgeApplicationDataDelegate == null)
			{
				this.onBeginPurgeApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginPurgeApplicationData);
			}
			if (this.onEndPurgeApplicationDataDelegate == null)
			{
				this.onEndPurgeApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndPurgeApplicationData);
			}
			if (this.onPurgeApplicationDataCompletedDelegate == null)
			{
				this.onPurgeApplicationDataCompletedDelegate = new SendOrPostCallback(this.OnPurgeApplicationDataCompleted);
			}
			base.InvokeAsync(this.onBeginPurgeApplicationDataDelegate, new object[]
			{
				applicationId
			}, this.onEndPurgeApplicationDataDelegate, this.onPurgeApplicationDataCompletedDelegate, userState);
		}

		public PredefinedBatchOperation? ParsePredefinedBatchOperation(string operation)
		{
			return base.Channel.ParsePredefinedBatchOperation(operation);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginParsePredefinedBatchOperation(string operation, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginParsePredefinedBatchOperation(operation, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PredefinedBatchOperation? EndParsePredefinedBatchOperation(IAsyncResult result)
		{
			return base.Channel.EndParsePredefinedBatchOperation(result);
		}

		private IAsyncResult OnBeginParsePredefinedBatchOperation(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string operation = (string)inValues[0];
			return this.BeginParsePredefinedBatchOperation(operation, callback, asyncState);
		}

		private object[] OnEndParsePredefinedBatchOperation(IAsyncResult result)
		{
			PredefinedBatchOperation? predefinedBatchOperation = this.EndParsePredefinedBatchOperation(result);
			return new object[]
			{
				predefinedBatchOperation
			};
		}

		private void OnParsePredefinedBatchOperationCompleted(object state)
		{
			if (this.ParsePredefinedBatchOperationCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ParsePredefinedBatchOperationCompleted(this, new ParsePredefinedBatchOperationCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ParsePredefinedBatchOperationAsync(string operation)
		{
			this.ParsePredefinedBatchOperationAsync(operation, null);
		}

		public void ParsePredefinedBatchOperationAsync(string operation, object userState)
		{
			if (this.onBeginParsePredefinedBatchOperationDelegate == null)
			{
				this.onBeginParsePredefinedBatchOperationDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginParsePredefinedBatchOperation);
			}
			if (this.onEndParsePredefinedBatchOperationDelegate == null)
			{
				this.onEndParsePredefinedBatchOperationDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndParsePredefinedBatchOperation);
			}
			if (this.onParsePredefinedBatchOperationCompletedDelegate == null)
			{
				this.onParsePredefinedBatchOperationCompletedDelegate = new SendOrPostCallback(this.OnParsePredefinedBatchOperationCompleted);
			}
			base.InvokeAsync(this.onBeginParsePredefinedBatchOperationDelegate, new object[]
			{
				operation
			}, this.onEndParsePredefinedBatchOperationDelegate, this.onParsePredefinedBatchOperationCompletedDelegate, userState);
		}

		public string GetPredefinedBatchOperationName(PredefinedBatchOperation operation)
		{
			return base.Channel.GetPredefinedBatchOperationName(operation);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetPredefinedBatchOperationName(PredefinedBatchOperation operation, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetPredefinedBatchOperationName(operation, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndGetPredefinedBatchOperationName(IAsyncResult result)
		{
			return base.Channel.EndGetPredefinedBatchOperationName(result);
		}

		private IAsyncResult OnBeginGetPredefinedBatchOperationName(object[] inValues, AsyncCallback callback, object asyncState)
		{
			PredefinedBatchOperation operation = (PredefinedBatchOperation)inValues[0];
			return this.BeginGetPredefinedBatchOperationName(operation, callback, asyncState);
		}

		private object[] OnEndGetPredefinedBatchOperationName(IAsyncResult result)
		{
			string text = this.EndGetPredefinedBatchOperationName(result);
			return new object[]
			{
				text
			};
		}

		private void OnGetPredefinedBatchOperationNameCompleted(object state)
		{
			if (this.GetPredefinedBatchOperationNameCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetPredefinedBatchOperationNameCompleted(this, new GetPredefinedBatchOperationNameCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetPredefinedBatchOperationNameAsync(PredefinedBatchOperation operation)
		{
			this.GetPredefinedBatchOperationNameAsync(operation, null);
		}

		public void GetPredefinedBatchOperationNameAsync(PredefinedBatchOperation operation, object userState)
		{
			if (this.onBeginGetPredefinedBatchOperationNameDelegate == null)
			{
				this.onBeginGetPredefinedBatchOperationNameDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetPredefinedBatchOperationName);
			}
			if (this.onEndGetPredefinedBatchOperationNameDelegate == null)
			{
				this.onEndGetPredefinedBatchOperationNameDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetPredefinedBatchOperationName);
			}
			if (this.onGetPredefinedBatchOperationNameCompletedDelegate == null)
			{
				this.onGetPredefinedBatchOperationNameCompletedDelegate = new SendOrPostCallback(this.OnGetPredefinedBatchOperationNameCompleted);
			}
			base.InvokeAsync(this.onBeginGetPredefinedBatchOperationNameDelegate, new object[]
			{
				operation
			}, this.onEndGetPredefinedBatchOperationNameDelegate, this.onGetPredefinedBatchOperationNameCompletedDelegate, userState);
		}

		public PublishContextData[] ResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions)
		{
			return base.Channel.ResolveItems(ids, resolveInstruction, targetIdsOrPurposes, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginResolveItems(ids, resolveInstruction, targetIdsOrPurposes, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PublishContextData[] EndResolveItems(IAsyncResult result)
		{
			return base.Channel.EndResolveItems(result);
		}

		private IAsyncResult OnBeginResolveItems(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] ids = (string[])inValues[0];
			ResolveInstructionData resolveInstruction = (ResolveInstructionData)inValues[1];
			string[] targetIdsOrPurposes = (string[])inValues[2];
			ReadOptions readOptions = (ReadOptions)inValues[3];
			return this.BeginResolveItems(ids, resolveInstruction, targetIdsOrPurposes, readOptions, callback, asyncState);
		}

		private object[] OnEndResolveItems(IAsyncResult result)
		{
			PublishContextData[] array = this.EndResolveItems(result);
			return new object[]
			{
				array
			};
		}

		private void OnResolveItemsCompleted(object state)
		{
			if (this.ResolveItemsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResolveItemsCompleted(this, new ResolveItemsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ResolveItemsAsync(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions)
		{
			this.ResolveItemsAsync(ids, resolveInstruction, targetIdsOrPurposes, readOptions, null);
		}

		public void ResolveItemsAsync(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions, object userState)
		{
			if (this.onBeginResolveItemsDelegate == null)
			{
				this.onBeginResolveItemsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginResolveItems);
			}
			if (this.onEndResolveItemsDelegate == null)
			{
				this.onEndResolveItemsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndResolveItems);
			}
			if (this.onResolveItemsCompletedDelegate == null)
			{
				this.onResolveItemsCompletedDelegate = new SendOrPostCallback(this.OnResolveItemsCompleted);
			}
			base.InvokeAsync(this.onBeginResolveItemsDelegate, new object[]
			{
				ids,
				resolveInstruction,
				targetIdsOrPurposes,
				readOptions
			}, this.onEndResolveItemsDelegate, this.onResolveItemsCompletedDelegate, userState);
		}

		public XElement GetSearchResultsXml(SearchQueryData filter)
		{
			return base.Channel.GetSearchResultsXml(filter);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSearchResultsXml(SearchQueryData filter, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSearchResultsXml(filter, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public XElement EndGetSearchResultsXml(IAsyncResult result)
		{
			return base.Channel.EndGetSearchResultsXml(result);
		}

		private IAsyncResult OnBeginGetSearchResultsXml(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SearchQueryData filter = (SearchQueryData)inValues[0];
			return this.BeginGetSearchResultsXml(filter, callback, asyncState);
		}

		private object[] OnEndGetSearchResultsXml(IAsyncResult result)
		{
			XElement xElement = this.EndGetSearchResultsXml(result);
			return new object[]
			{
				xElement
			};
		}

		private void OnGetSearchResultsXmlCompleted(object state)
		{
			if (this.GetSearchResultsXmlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsXmlCompleted(this, new GetSearchResultsXmlCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSearchResultsXmlAsync(SearchQueryData filter)
		{
			this.GetSearchResultsXmlAsync(filter, null);
		}

		public void GetSearchResultsXmlAsync(SearchQueryData filter, object userState)
		{
			if (this.onBeginGetSearchResultsXmlDelegate == null)
			{
				this.onBeginGetSearchResultsXmlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSearchResultsXml);
			}
			if (this.onEndGetSearchResultsXmlDelegate == null)
			{
				this.onEndGetSearchResultsXmlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSearchResultsXml);
			}
			if (this.onGetSearchResultsXmlCompletedDelegate == null)
			{
				this.onGetSearchResultsXmlCompletedDelegate = new SendOrPostCallback(this.OnGetSearchResultsXmlCompleted);
			}
			base.InvokeAsync(this.onBeginGetSearchResultsXmlDelegate, new object[]
			{
				filter
			}, this.onEndGetSearchResultsXmlDelegate, this.onGetSearchResultsXmlCompletedDelegate, userState);
		}

		public XElement GetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows)
		{
			return base.Channel.GetSearchResultsXmlPaged(filter, startRowIndex, maxRows);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSearchResultsXmlPaged(filter, startRowIndex, maxRows, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public XElement EndGetSearchResultsXmlPaged(IAsyncResult result)
		{
			return base.Channel.EndGetSearchResultsXmlPaged(result);
		}

		private IAsyncResult OnBeginGetSearchResultsXmlPaged(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SearchQueryData filter = (SearchQueryData)inValues[0];
			int startRowIndex = (int)inValues[1];
			int maxRows = (int)inValues[2];
			return this.BeginGetSearchResultsXmlPaged(filter, startRowIndex, maxRows, callback, asyncState);
		}

		private object[] OnEndGetSearchResultsXmlPaged(IAsyncResult result)
		{
			XElement xElement = this.EndGetSearchResultsXmlPaged(result);
			return new object[]
			{
				xElement
			};
		}

		private void OnGetSearchResultsXmlPagedCompleted(object state)
		{
			if (this.GetSearchResultsXmlPagedCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsXmlPagedCompleted(this, new GetSearchResultsXmlPagedCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSearchResultsXmlPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows)
		{
			this.GetSearchResultsXmlPagedAsync(filter, startRowIndex, maxRows, null);
		}

		public void GetSearchResultsXmlPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows, object userState)
		{
			if (this.onBeginGetSearchResultsXmlPagedDelegate == null)
			{
				this.onBeginGetSearchResultsXmlPagedDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSearchResultsXmlPaged);
			}
			if (this.onEndGetSearchResultsXmlPagedDelegate == null)
			{
				this.onEndGetSearchResultsXmlPagedDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSearchResultsXmlPaged);
			}
			if (this.onGetSearchResultsXmlPagedCompletedDelegate == null)
			{
				this.onGetSearchResultsXmlPagedCompletedDelegate = new SendOrPostCallback(this.OnGetSearchResultsXmlPagedCompleted);
			}
			base.InvokeAsync(this.onBeginGetSearchResultsXmlPagedDelegate, new object[]
			{
				filter,
				startRowIndex,
				maxRows
			}, this.onEndGetSearchResultsXmlPagedDelegate, this.onGetSearchResultsXmlPagedCompletedDelegate, userState);
		}

		public IdentifiableObjectData[] GetSearchResults(SearchQueryData filter)
		{
			return base.Channel.GetSearchResults(filter);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSearchResults(SearchQueryData filter, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSearchResults(filter, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData[] EndGetSearchResults(IAsyncResult result)
		{
			return base.Channel.EndGetSearchResults(result);
		}

		private IAsyncResult OnBeginGetSearchResults(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SearchQueryData filter = (SearchQueryData)inValues[0];
			return this.BeginGetSearchResults(filter, callback, asyncState);
		}

		private object[] OnEndGetSearchResults(IAsyncResult result)
		{
			IdentifiableObjectData[] array = this.EndGetSearchResults(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetSearchResultsCompleted(object state)
		{
			if (this.GetSearchResultsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsCompleted(this, new GetSearchResultsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSearchResultsAsync(SearchQueryData filter)
		{
			this.GetSearchResultsAsync(filter, null);
		}

		public void GetSearchResultsAsync(SearchQueryData filter, object userState)
		{
			if (this.onBeginGetSearchResultsDelegate == null)
			{
				this.onBeginGetSearchResultsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSearchResults);
			}
			if (this.onEndGetSearchResultsDelegate == null)
			{
				this.onEndGetSearchResultsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSearchResults);
			}
			if (this.onGetSearchResultsCompletedDelegate == null)
			{
				this.onGetSearchResultsCompletedDelegate = new SendOrPostCallback(this.OnGetSearchResultsCompleted);
			}
			base.InvokeAsync(this.onBeginGetSearchResultsDelegate, new object[]
			{
				filter
			}, this.onEndGetSearchResultsDelegate, this.onGetSearchResultsCompletedDelegate, userState);
		}

		public IdentifiableObjectData[] GetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows)
		{
			return base.Channel.GetSearchResultsPaged(filter, startRowIndex, maxRows);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSearchResultsPaged(filter, startRowIndex, maxRows, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IdentifiableObjectData[] EndGetSearchResultsPaged(IAsyncResult result)
		{
			return base.Channel.EndGetSearchResultsPaged(result);
		}

		private IAsyncResult OnBeginGetSearchResultsPaged(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SearchQueryData filter = (SearchQueryData)inValues[0];
			int startRowIndex = (int)inValues[1];
			int maxRows = (int)inValues[2];
			return this.BeginGetSearchResultsPaged(filter, startRowIndex, maxRows, callback, asyncState);
		}

		private object[] OnEndGetSearchResultsPaged(IAsyncResult result)
		{
			IdentifiableObjectData[] array = this.EndGetSearchResultsPaged(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetSearchResultsPagedCompleted(object state)
		{
			if (this.GetSearchResultsPagedCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsPagedCompleted(this, new GetSearchResultsPagedCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSearchResultsPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows)
		{
			this.GetSearchResultsPagedAsync(filter, startRowIndex, maxRows, null);
		}

		public void GetSearchResultsPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows, object userState)
		{
			if (this.onBeginGetSearchResultsPagedDelegate == null)
			{
				this.onBeginGetSearchResultsPagedDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSearchResultsPaged);
			}
			if (this.onEndGetSearchResultsPagedDelegate == null)
			{
				this.onEndGetSearchResultsPagedDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSearchResultsPaged);
			}
			if (this.onGetSearchResultsPagedCompletedDelegate == null)
			{
				this.onGetSearchResultsPagedCompletedDelegate = new SendOrPostCallback(this.OnGetSearchResultsPagedCompleted);
			}
			base.InvokeAsync(this.onBeginGetSearchResultsPagedDelegate, new object[]
			{
				filter,
				startRowIndex,
				maxRows
			}, this.onEndGetSearchResultsPagedDelegate, this.onGetSearchResultsPagedCompletedDelegate, userState);
		}

		public RenderedItemData RenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose)
		{
			return base.Channel.RenderItem(itemId, templateId, publishInstruction, publicationTargetIdOrPurpose);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginRenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginRenderItem(itemId, templateId, publishInstruction, publicationTargetIdOrPurpose, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public RenderedItemData EndRenderItem(IAsyncResult result)
		{
			return base.Channel.EndRenderItem(result);
		}

		private IAsyncResult OnBeginRenderItem(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string itemId = (string)inValues[0];
			string templateId = (string)inValues[1];
			PublishInstructionData publishInstruction = (PublishInstructionData)inValues[2];
			string publicationTargetIdOrPurpose = (string)inValues[3];
			return this.BeginRenderItem(itemId, templateId, publishInstruction, publicationTargetIdOrPurpose, callback, asyncState);
		}

		private object[] OnEndRenderItem(IAsyncResult result)
		{
			RenderedItemData renderedItemData = this.EndRenderItem(result);
			return new object[]
			{
				renderedItemData
			};
		}

		private void OnRenderItemCompleted(object state)
		{
			if (this.RenderItemCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RenderItemCompleted(this, new RenderItemCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void RenderItemAsync(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose)
		{
			this.RenderItemAsync(itemId, templateId, publishInstruction, publicationTargetIdOrPurpose, null);
		}

		public void RenderItemAsync(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose, object userState)
		{
			if (this.onBeginRenderItemDelegate == null)
			{
				this.onBeginRenderItemDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginRenderItem);
			}
			if (this.onEndRenderItemDelegate == null)
			{
				this.onEndRenderItemDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndRenderItem);
			}
			if (this.onRenderItemCompletedDelegate == null)
			{
				this.onRenderItemCompletedDelegate = new SendOrPostCallback(this.OnRenderItemCompleted);
			}
			base.InvokeAsync(this.onBeginRenderItemDelegate, new object[]
			{
				itemId,
				templateId,
				publishInstruction,
				publicationTargetIdOrPurpose
			}, this.onEndRenderItemDelegate, this.onRenderItemCompletedDelegate, userState);
		}

		public RenderedItemData PreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId)
		{
			return base.Channel.PreviewItem(itemData, templateData, publishInstruction, publicationTargetId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginPreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginPreviewItem(itemData, templateData, publishInstruction, publicationTargetId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public RenderedItemData EndPreviewItem(IAsyncResult result)
		{
			return base.Channel.EndPreviewItem(result);
		}

		private IAsyncResult OnBeginPreviewItem(object[] inValues, AsyncCallback callback, object asyncState)
		{
			RepositoryLocalObjectData itemData = (RepositoryLocalObjectData)inValues[0];
			TemplateData templateData = (TemplateData)inValues[1];
			PublishInstructionData publishInstruction = (PublishInstructionData)inValues[2];
			string publicationTargetId = (string)inValues[3];
			return this.BeginPreviewItem(itemData, templateData, publishInstruction, publicationTargetId, callback, asyncState);
		}

		private object[] OnEndPreviewItem(IAsyncResult result)
		{
			RenderedItemData renderedItemData = this.EndPreviewItem(result);
			return new object[]
			{
				renderedItemData
			};
		}

		private void OnPreviewItemCompleted(object state)
		{
			if (this.PreviewItemCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PreviewItemCompleted(this, new PreviewItemCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void PreviewItemAsync(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId)
		{
			this.PreviewItemAsync(itemData, templateData, publishInstruction, publicationTargetId, null);
		}

		public void PreviewItemAsync(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId, object userState)
		{
			if (this.onBeginPreviewItemDelegate == null)
			{
				this.onBeginPreviewItemDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginPreviewItem);
			}
			if (this.onEndPreviewItemDelegate == null)
			{
				this.onEndPreviewItemDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndPreviewItem);
			}
			if (this.onPreviewItemCompletedDelegate == null)
			{
				this.onPreviewItemCompletedDelegate = new SendOrPostCallback(this.OnPreviewItemCompleted);
			}
			base.InvokeAsync(this.onBeginPreviewItemDelegate, new object[]
			{
				itemData,
				templateData,
				publishInstruction,
				publicationTargetId
			}, this.onEndPreviewItemDelegate, this.onPreviewItemCompletedDelegate, userState);
		}

		public PublishTransactionData[] Publish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
		{
			return base.Channel.Publish(ids, publishInstruction, targetIdsOrPurposes, priority, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginPublish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginPublish(ids, publishInstruction, targetIdsOrPurposes, priority, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PublishTransactionData[] EndPublish(IAsyncResult result)
		{
			return base.Channel.EndPublish(result);
		}

		private IAsyncResult OnBeginPublish(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] ids = (string[])inValues[0];
			PublishInstructionData publishInstruction = (PublishInstructionData)inValues[1];
			string[] targetIdsOrPurposes = (string[])inValues[2];
			PublishPriority? priority = (PublishPriority?)inValues[3];
			ReadOptions readOptions = (ReadOptions)inValues[4];
			return this.BeginPublish(ids, publishInstruction, targetIdsOrPurposes, priority, readOptions, callback, asyncState);
		}

		private object[] OnEndPublish(IAsyncResult result)
		{
			PublishTransactionData[] array = this.EndPublish(result);
			return new object[]
			{
				array
			};
		}

		private void OnPublishCompleted(object state)
		{
			if (this.PublishCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PublishCompleted(this, new PublishCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void PublishAsync(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
		{
			this.PublishAsync(ids, publishInstruction, targetIdsOrPurposes, priority, readOptions, null);
		}

		public void PublishAsync(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, object userState)
		{
			if (this.onBeginPublishDelegate == null)
			{
				this.onBeginPublishDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginPublish);
			}
			if (this.onEndPublishDelegate == null)
			{
				this.onEndPublishDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndPublish);
			}
			if (this.onPublishCompletedDelegate == null)
			{
				this.onPublishCompletedDelegate = new SendOrPostCallback(this.OnPublishCompleted);
			}
			base.InvokeAsync(this.onBeginPublishDelegate, new object[]
			{
				ids,
				publishInstruction,
				targetIdsOrPurposes,
				priority,
				readOptions
			}, this.onEndPublishDelegate, this.onPublishCompletedDelegate, userState);
		}

		public PublishTransactionData[] UnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
		{
			return base.Channel.UnPublish(ids, unPublishInstruction, targetIdsOrPurposes, priority, readOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUnPublish(ids, unPublishInstruction, targetIdsOrPurposes, priority, readOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PublishTransactionData[] EndUnPublish(IAsyncResult result)
		{
			return base.Channel.EndUnPublish(result);
		}

		private IAsyncResult OnBeginUnPublish(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] ids = (string[])inValues[0];
			UnPublishInstructionData unPublishInstruction = (UnPublishInstructionData)inValues[1];
			string[] targetIdsOrPurposes = (string[])inValues[2];
			PublishPriority? priority = (PublishPriority?)inValues[3];
			ReadOptions readOptions = (ReadOptions)inValues[4];
			return this.BeginUnPublish(ids, unPublishInstruction, targetIdsOrPurposes, priority, readOptions, callback, asyncState);
		}

		private object[] OnEndUnPublish(IAsyncResult result)
		{
			PublishTransactionData[] array = this.EndUnPublish(result);
			return new object[]
			{
				array
			};
		}

		private void OnUnPublishCompleted(object state)
		{
			if (this.UnPublishCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnPublishCompleted(this, new UnPublishCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UnPublishAsync(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
		{
			this.UnPublishAsync(ids, unPublishInstruction, targetIdsOrPurposes, priority, readOptions, null);
		}

		public void UnPublishAsync(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, object userState)
		{
			if (this.onBeginUnPublishDelegate == null)
			{
				this.onBeginUnPublishDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginUnPublish);
			}
			if (this.onEndUnPublishDelegate == null)
			{
				this.onEndUnPublishDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndUnPublish);
			}
			if (this.onUnPublishCompletedDelegate == null)
			{
				this.onUnPublishCompletedDelegate = new SendOrPostCallback(this.OnUnPublishCompleted);
			}
			base.InvokeAsync(this.onBeginUnPublishDelegate, new object[]
			{
				ids,
				unPublishInstruction,
				targetIdsOrPurposes,
				priority,
				readOptions
			}, this.onEndUnPublishDelegate, this.onUnPublishCompletedDelegate, userState);
		}

		public bool IsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext)
		{
			return base.Channel.IsPublished(itemId, publishingTargetIdOrPurpose, isPublishedInContext);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginIsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginIsPublished(itemId, publishingTargetIdOrPurpose, isPublishedInContext, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public bool EndIsPublished(IAsyncResult result)
		{
			return base.Channel.EndIsPublished(result);
		}

		private IAsyncResult OnBeginIsPublished(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string itemId = (string)inValues[0];
			string publishingTargetIdOrPurpose = (string)inValues[1];
			bool isPublishedInContext = (bool)inValues[2];
			return this.BeginIsPublished(itemId, publishingTargetIdOrPurpose, isPublishedInContext, callback, asyncState);
		}

		private object[] OnEndIsPublished(IAsyncResult result)
		{
			bool flag = this.EndIsPublished(result);
			return new object[]
			{
				flag
			};
		}

		private void OnIsPublishedCompleted(object state)
		{
			if (this.IsPublishedCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.IsPublishedCompleted(this, new IsPublishedCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void IsPublishedAsync(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext)
		{
			this.IsPublishedAsync(itemId, publishingTargetIdOrPurpose, isPublishedInContext, null);
		}

		public void IsPublishedAsync(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext, object userState)
		{
			if (this.onBeginIsPublishedDelegate == null)
			{
				this.onBeginIsPublishedDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginIsPublished);
			}
			if (this.onEndIsPublishedDelegate == null)
			{
				this.onEndIsPublishedDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndIsPublished);
			}
			if (this.onIsPublishedCompletedDelegate == null)
			{
				this.onIsPublishedCompletedDelegate = new SendOrPostCallback(this.OnIsPublishedCompleted);
			}
			base.InvokeAsync(this.onBeginIsPublishedDelegate, new object[]
			{
				itemId,
				publishingTargetIdOrPurpose,
				isPublishedInContext
			}, this.onEndIsPublishedDelegate, this.onIsPublishedCompletedDelegate, userState);
		}

		public RenderedItemData GetWorkItemSnapshot(string workItemId)
		{
			return base.Channel.GetWorkItemSnapshot(workItemId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetWorkItemSnapshot(string workItemId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetWorkItemSnapshot(workItemId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public RenderedItemData EndGetWorkItemSnapshot(IAsyncResult result)
		{
			return base.Channel.EndGetWorkItemSnapshot(result);
		}

		private IAsyncResult OnBeginGetWorkItemSnapshot(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string workItemId = (string)inValues[0];
			return this.BeginGetWorkItemSnapshot(workItemId, callback, asyncState);
		}

		private object[] OnEndGetWorkItemSnapshot(IAsyncResult result)
		{
			RenderedItemData renderedItemData = this.EndGetWorkItemSnapshot(result);
			return new object[]
			{
				renderedItemData
			};
		}

		private void OnGetWorkItemSnapshotCompleted(object state)
		{
			if (this.GetWorkItemSnapshotCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetWorkItemSnapshotCompleted(this, new GetWorkItemSnapshotCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetWorkItemSnapshotAsync(string workItemId)
		{
			this.GetWorkItemSnapshotAsync(workItemId, null);
		}

		public void GetWorkItemSnapshotAsync(string workItemId, object userState)
		{
			if (this.onBeginGetWorkItemSnapshotDelegate == null)
			{
				this.onBeginGetWorkItemSnapshotDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetWorkItemSnapshot);
			}
			if (this.onEndGetWorkItemSnapshotDelegate == null)
			{
				this.onEndGetWorkItemSnapshotDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetWorkItemSnapshot);
			}
			if (this.onGetWorkItemSnapshotCompletedDelegate == null)
			{
				this.onGetWorkItemSnapshotCompletedDelegate = new SendOrPostCallback(this.OnGetWorkItemSnapshotCompleted);
			}
			base.InvokeAsync(this.onBeginGetWorkItemSnapshotDelegate, new object[]
			{
				workItemId
			}, this.onEndGetWorkItemSnapshotDelegate, this.onGetWorkItemSnapshotCompletedDelegate, userState);
		}

		public PublishInfoData[] GetListPublishInfo(string itemId)
		{
			return base.Channel.GetListPublishInfo(itemId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListPublishInfo(string itemId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListPublishInfo(itemId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PublishInfoData[] EndGetListPublishInfo(IAsyncResult result)
		{
			return base.Channel.EndGetListPublishInfo(result);
		}

		private IAsyncResult OnBeginGetListPublishInfo(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string itemId = (string)inValues[0];
			return this.BeginGetListPublishInfo(itemId, callback, asyncState);
		}

		private object[] OnEndGetListPublishInfo(IAsyncResult result)
		{
			PublishInfoData[] array = this.EndGetListPublishInfo(result);
			return new object[]
			{
				array
			};
		}

		private void OnGetListPublishInfoCompleted(object state)
		{
			if (this.GetListPublishInfoCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListPublishInfoCompleted(this, new GetListPublishInfoCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListPublishInfoAsync(string itemId)
		{
			this.GetListPublishInfoAsync(itemId, null);
		}

		public void GetListPublishInfoAsync(string itemId, object userState)
		{
			if (this.onBeginGetListPublishInfoDelegate == null)
			{
				this.onBeginGetListPublishInfoDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListPublishInfo);
			}
			if (this.onEndGetListPublishInfoDelegate == null)
			{
				this.onEndGetListPublishInfoDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListPublishInfo);
			}
			if (this.onGetListPublishInfoCompletedDelegate == null)
			{
				this.onGetListPublishInfoCompletedDelegate = new SendOrPostCallback(this.OnGetListPublishInfoCompleted);
			}
			base.InvokeAsync(this.onBeginGetListPublishInfoDelegate, new object[]
			{
				itemId
			}, this.onEndGetListPublishInfoDelegate, this.onGetListPublishInfoCompletedDelegate, userState);
		}

		public ActionFlags CastActions(int numericActions)
		{
			return base.Channel.CastActions(numericActions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginCastActions(int numericActions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginCastActions(numericActions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ActionFlags EndCastActions(IAsyncResult result)
		{
			return base.Channel.EndCastActions(result);
		}

		private IAsyncResult OnBeginCastActions(object[] inValues, AsyncCallback callback, object asyncState)
		{
			int numericActions = (int)inValues[0];
			return this.BeginCastActions(numericActions, callback, asyncState);
		}

		private object[] OnEndCastActions(IAsyncResult result)
		{
			ActionFlags actionFlags = this.EndCastActions(result);
			return new object[]
			{
				actionFlags
			};
		}

		private void OnCastActionsCompleted(object state)
		{
			if (this.CastActionsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CastActionsCompleted(this, new CastActionsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void CastActionsAsync(int numericActions)
		{
			this.CastActionsAsync(numericActions, null);
		}

		public void CastActionsAsync(int numericActions, object userState)
		{
			if (this.onBeginCastActionsDelegate == null)
			{
				this.onBeginCastActionsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginCastActions);
			}
			if (this.onEndCastActionsDelegate == null)
			{
				this.onEndCastActionsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndCastActions);
			}
			if (this.onCastActionsCompletedDelegate == null)
			{
				this.onCastActionsCompletedDelegate = new SendOrPostCallback(this.OnCastActionsCompleted);
			}
			base.InvokeAsync(this.onBeginCastActionsDelegate, new object[]
			{
				numericActions
			}, this.onEndCastActionsDelegate, this.onCastActionsCompletedDelegate, userState);
		}

		public void ValidateXml(IdentifiableObjectData data)
		{
			base.Channel.ValidateXml(data);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginValidateXml(IdentifiableObjectData data, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginValidateXml(data, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndValidateXml(IAsyncResult result)
		{
			base.Channel.EndValidateXml(result);
		}

		private IAsyncResult OnBeginValidateXml(object[] inValues, AsyncCallback callback, object asyncState)
		{
			IdentifiableObjectData data = (IdentifiableObjectData)inValues[0];
			return this.BeginValidateXml(data, callback, asyncState);
		}

		private object[] OnEndValidateXml(IAsyncResult result)
		{
			this.EndValidateXml(result);
			return null;
		}

		private void OnValidateXmlCompleted(object state)
		{
			if (this.ValidateXmlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ValidateXmlCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ValidateXmlAsync(IdentifiableObjectData data)
		{
			this.ValidateXmlAsync(data, null);
		}

		public void ValidateXmlAsync(IdentifiableObjectData data, object userState)
		{
			if (this.onBeginValidateXmlDelegate == null)
			{
				this.onBeginValidateXmlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginValidateXml);
			}
			if (this.onEndValidateXmlDelegate == null)
			{
				this.onEndValidateXmlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndValidateXml);
			}
			if (this.onValidateXmlCompletedDelegate == null)
			{
				this.onValidateXmlCompletedDelegate = new SendOrPostCallback(this.OnValidateXmlCompleted);
			}
			base.InvokeAsync(this.onBeginValidateXmlDelegate, new object[]
			{
				data
			}, this.onEndValidateXmlDelegate, this.onValidateXmlCompletedDelegate, userState);
		}

		public bool IsValidTridionWebSchemaXml(SchemaData data)
		{
			return base.Channel.IsValidTridionWebSchemaXml(data);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginIsValidTridionWebSchemaXml(SchemaData data, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginIsValidTridionWebSchemaXml(data, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public bool EndIsValidTridionWebSchemaXml(IAsyncResult result)
		{
			return base.Channel.EndIsValidTridionWebSchemaXml(result);
		}

		private IAsyncResult OnBeginIsValidTridionWebSchemaXml(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SchemaData data = (SchemaData)inValues[0];
			return this.BeginIsValidTridionWebSchemaXml(data, callback, asyncState);
		}

		private object[] OnEndIsValidTridionWebSchemaXml(IAsyncResult result)
		{
			bool flag = this.EndIsValidTridionWebSchemaXml(result);
			return new object[]
			{
				flag
			};
		}

		private void OnIsValidTridionWebSchemaXmlCompleted(object state)
		{
			if (this.IsValidTridionWebSchemaXmlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.IsValidTridionWebSchemaXmlCompleted(this, new IsValidTridionWebSchemaXmlCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void IsValidTridionWebSchemaXmlAsync(SchemaData data)
		{
			this.IsValidTridionWebSchemaXmlAsync(data, null);
		}

		public void IsValidTridionWebSchemaXmlAsync(SchemaData data, object userState)
		{
			if (this.onBeginIsValidTridionWebSchemaXmlDelegate == null)
			{
				this.onBeginIsValidTridionWebSchemaXmlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginIsValidTridionWebSchemaXml);
			}
			if (this.onEndIsValidTridionWebSchemaXmlDelegate == null)
			{
				this.onEndIsValidTridionWebSchemaXmlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndIsValidTridionWebSchemaXml);
			}
			if (this.onIsValidTridionWebSchemaXmlCompletedDelegate == null)
			{
				this.onIsValidTridionWebSchemaXmlCompletedDelegate = new SendOrPostCallback(this.OnIsValidTridionWebSchemaXmlCompleted);
			}
			base.InvokeAsync(this.onBeginIsValidTridionWebSchemaXmlDelegate, new object[]
			{
				data
			}, this.onEndIsValidTridionWebSchemaXmlDelegate, this.onIsValidTridionWebSchemaXmlCompletedDelegate, userState);
		}

		public ArrayOfTcmUri GetSubjectIdsWithApplicationData(string applicationId)
		{
			return base.Channel.GetSubjectIdsWithApplicationData(applicationId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSubjectIdsWithApplicationData(string applicationId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSubjectIdsWithApplicationData(applicationId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ArrayOfTcmUri EndGetSubjectIdsWithApplicationData(IAsyncResult result)
		{
			return base.Channel.EndGetSubjectIdsWithApplicationData(result);
		}

		private IAsyncResult OnBeginGetSubjectIdsWithApplicationData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string applicationId = (string)inValues[0];
			return this.BeginGetSubjectIdsWithApplicationData(applicationId, callback, asyncState);
		}

		private object[] OnEndGetSubjectIdsWithApplicationData(IAsyncResult result)
		{
			ArrayOfTcmUri arrayOfTcmUri = this.EndGetSubjectIdsWithApplicationData(result);
			return new object[]
			{
				arrayOfTcmUri
			};
		}

		private void OnGetSubjectIdsWithApplicationDataCompleted(object state)
		{
			if (this.GetSubjectIdsWithApplicationDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSubjectIdsWithApplicationDataCompleted(this, new GetSubjectIdsWithApplicationDataCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSubjectIdsWithApplicationDataAsync(string applicationId)
		{
			this.GetSubjectIdsWithApplicationDataAsync(applicationId, null);
		}

		public void GetSubjectIdsWithApplicationDataAsync(string applicationId, object userState)
		{
			if (this.onBeginGetSubjectIdsWithApplicationDataDelegate == null)
			{
				this.onBeginGetSubjectIdsWithApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSubjectIdsWithApplicationData);
			}
			if (this.onEndGetSubjectIdsWithApplicationDataDelegate == null)
			{
				this.onEndGetSubjectIdsWithApplicationDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSubjectIdsWithApplicationData);
			}
			if (this.onGetSubjectIdsWithApplicationDataCompletedDelegate == null)
			{
				this.onGetSubjectIdsWithApplicationDataCompletedDelegate = new SendOrPostCallback(this.OnGetSubjectIdsWithApplicationDataCompleted);
			}
			base.InvokeAsync(this.onBeginGetSubjectIdsWithApplicationDataDelegate, new object[]
			{
				applicationId
			}, this.onEndGetSubjectIdsWithApplicationDataDelegate, this.onGetSubjectIdsWithApplicationDataCompletedDelegate, userState);
		}

		public ApplicationDataDictionary ReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds)
		{
			return base.Channel.ReadApplicationDataForSubjectsIds(subjectIds, applicationIds);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginReadApplicationDataForSubjectsIds(subjectIds, applicationIds, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public ApplicationDataDictionary EndReadApplicationDataForSubjectsIds(IAsyncResult result)
		{
			return base.Channel.EndReadApplicationDataForSubjectsIds(result);
		}

		private IAsyncResult OnBeginReadApplicationDataForSubjectsIds(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] subjectIds = (string[])inValues[0];
			string[] applicationIds = (string[])inValues[1];
			return this.BeginReadApplicationDataForSubjectsIds(subjectIds, applicationIds, callback, asyncState);
		}

		private object[] OnEndReadApplicationDataForSubjectsIds(IAsyncResult result)
		{
			ApplicationDataDictionary applicationDataDictionary = this.EndReadApplicationDataForSubjectsIds(result);
			return new object[]
			{
				applicationDataDictionary
			};
		}

		private void OnReadApplicationDataForSubjectsIdsCompleted(object state)
		{
			if (this.ReadApplicationDataForSubjectsIdsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadApplicationDataForSubjectsIdsCompleted(this, new ReadApplicationDataForSubjectsIdsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReadApplicationDataForSubjectsIdsAsync(string[] subjectIds, string[] applicationIds)
		{
			this.ReadApplicationDataForSubjectsIdsAsync(subjectIds, applicationIds, null);
		}

		public void ReadApplicationDataForSubjectsIdsAsync(string[] subjectIds, string[] applicationIds, object userState)
		{
			if (this.onBeginReadApplicationDataForSubjectsIdsDelegate == null)
			{
				this.onBeginReadApplicationDataForSubjectsIdsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginReadApplicationDataForSubjectsIds);
			}
			if (this.onEndReadApplicationDataForSubjectsIdsDelegate == null)
			{
				this.onEndReadApplicationDataForSubjectsIdsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndReadApplicationDataForSubjectsIds);
			}
			if (this.onReadApplicationDataForSubjectsIdsCompletedDelegate == null)
			{
				this.onReadApplicationDataForSubjectsIdsCompletedDelegate = new SendOrPostCallback(this.OnReadApplicationDataForSubjectsIdsCompleted);
			}
			base.InvokeAsync(this.onBeginReadApplicationDataForSubjectsIdsDelegate, new object[]
			{
				subjectIds,
				applicationIds
			}, this.onEndReadApplicationDataForSubjectsIdsDelegate, this.onReadApplicationDataForSubjectsIdsCompletedDelegate, userState);
		}

		public SecurityDescriptorDataDictionary GetSecurityDescriptorsForSubjectsIds(string[] subjectIds)
		{
			return base.Channel.GetSecurityDescriptorsForSubjectsIds(subjectIds);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSecurityDescriptorsForSubjectsIds(string[] subjectIds, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSecurityDescriptorsForSubjectsIds(subjectIds, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SecurityDescriptorDataDictionary EndGetSecurityDescriptorsForSubjectsIds(IAsyncResult result)
		{
			return base.Channel.EndGetSecurityDescriptorsForSubjectsIds(result);
		}

		private IAsyncResult OnBeginGetSecurityDescriptorsForSubjectsIds(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] subjectIds = (string[])inValues[0];
			return this.BeginGetSecurityDescriptorsForSubjectsIds(subjectIds, callback, asyncState);
		}

		private object[] OnEndGetSecurityDescriptorsForSubjectsIds(IAsyncResult result)
		{
			SecurityDescriptorDataDictionary securityDescriptorDataDictionary = this.EndGetSecurityDescriptorsForSubjectsIds(result);
			return new object[]
			{
				securityDescriptorDataDictionary
			};
		}

		private void OnGetSecurityDescriptorsForSubjectsIdsCompleted(object state)
		{
			if (this.GetSecurityDescriptorsForSubjectsIdsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSecurityDescriptorsForSubjectsIdsCompleted(this, new GetSecurityDescriptorsForSubjectsIdsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSecurityDescriptorsForSubjectsIdsAsync(string[] subjectIds)
		{
			this.GetSecurityDescriptorsForSubjectsIdsAsync(subjectIds, null);
		}

		public void GetSecurityDescriptorsForSubjectsIdsAsync(string[] subjectIds, object userState)
		{
			if (this.onBeginGetSecurityDescriptorsForSubjectsIdsDelegate == null)
			{
				this.onBeginGetSecurityDescriptorsForSubjectsIdsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSecurityDescriptorsForSubjectsIds);
			}
			if (this.onEndGetSecurityDescriptorsForSubjectsIdsDelegate == null)
			{
				this.onEndGetSecurityDescriptorsForSubjectsIdsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSecurityDescriptorsForSubjectsIds);
			}
			if (this.onGetSecurityDescriptorsForSubjectsIdsCompletedDelegate == null)
			{
				this.onGetSecurityDescriptorsForSubjectsIdsCompletedDelegate = new SendOrPostCallback(this.OnGetSecurityDescriptorsForSubjectsIdsCompleted);
			}
			base.InvokeAsync(this.onBeginGetSecurityDescriptorsForSubjectsIdsDelegate, new object[]
			{
				subjectIds
			}, this.onEndGetSecurityDescriptorsForSubjectsIdsDelegate, this.onGetSecurityDescriptorsForSubjectsIdsCompletedDelegate, userState);
		}

		public SecurityDescriptorDataDictionary GetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds)
		{
			return base.Channel.GetContentSecurityDescriptorsForOrgItemIds(organizationalItemIds);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetContentSecurityDescriptorsForOrgItemIds(organizationalItemIds, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SecurityDescriptorDataDictionary EndGetContentSecurityDescriptorsForOrgItemIds(IAsyncResult result)
		{
			return base.Channel.EndGetContentSecurityDescriptorsForOrgItemIds(result);
		}

		private IAsyncResult OnBeginGetContentSecurityDescriptorsForOrgItemIds(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string[] organizationalItemIds = (string[])inValues[0];
			return this.BeginGetContentSecurityDescriptorsForOrgItemIds(organizationalItemIds, callback, asyncState);
		}

		private object[] OnEndGetContentSecurityDescriptorsForOrgItemIds(IAsyncResult result)
		{
			SecurityDescriptorDataDictionary securityDescriptorDataDictionary = this.EndGetContentSecurityDescriptorsForOrgItemIds(result);
			return new object[]
			{
				securityDescriptorDataDictionary
			};
		}

		private void OnGetContentSecurityDescriptorsForOrgItemIdsCompleted(object state)
		{
			if (this.GetContentSecurityDescriptorsForOrgItemIdsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetContentSecurityDescriptorsForOrgItemIdsCompleted(this, new GetContentSecurityDescriptorsForOrgItemIdsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetContentSecurityDescriptorsForOrgItemIdsAsync(string[] organizationalItemIds)
		{
			this.GetContentSecurityDescriptorsForOrgItemIdsAsync(organizationalItemIds, null);
		}

		public void GetContentSecurityDescriptorsForOrgItemIdsAsync(string[] organizationalItemIds, object userState)
		{
			if (this.onBeginGetContentSecurityDescriptorsForOrgItemIdsDelegate == null)
			{
				this.onBeginGetContentSecurityDescriptorsForOrgItemIdsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetContentSecurityDescriptorsForOrgItemIds);
			}
			if (this.onEndGetContentSecurityDescriptorsForOrgItemIdsDelegate == null)
			{
				this.onEndGetContentSecurityDescriptorsForOrgItemIdsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetContentSecurityDescriptorsForOrgItemIds);
			}
			if (this.onGetContentSecurityDescriptorsForOrgItemIdsCompletedDelegate == null)
			{
				this.onGetContentSecurityDescriptorsForOrgItemIdsCompletedDelegate = new SendOrPostCallback(this.OnGetContentSecurityDescriptorsForOrgItemIdsCompleted);
			}
			base.InvokeAsync(this.onBeginGetContentSecurityDescriptorsForOrgItemIdsDelegate, new object[]
			{
				organizationalItemIds
			}, this.onEndGetContentSecurityDescriptorsForOrgItemIdsDelegate, this.onGetContentSecurityDescriptorsForOrgItemIdsCompletedDelegate, userState);
		}

		public void ReIndex(string id)
		{
			base.Channel.ReIndex(id);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginReIndex(string id, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginReIndex(id, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndReIndex(IAsyncResult result)
		{
			base.Channel.EndReIndex(result);
		}

		private IAsyncResult OnBeginReIndex(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			return this.BeginReIndex(id, callback, asyncState);
		}

		private object[] OnEndReIndex(IAsyncResult result)
		{
			this.EndReIndex(result);
			return null;
		}

		private void OnReIndexCompleted(object state)
		{
			if (this.ReIndexCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReIndexCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ReIndexAsync(string id)
		{
			this.ReIndexAsync(id, null);
		}

		public void ReIndexAsync(string id, object userState)
		{
			if (this.onBeginReIndexDelegate == null)
			{
				this.onBeginReIndexDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginReIndex);
			}
			if (this.onEndReIndexDelegate == null)
			{
				this.onEndReIndexDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndReIndex);
			}
			if (this.onReIndexCompletedDelegate == null)
			{
				this.onReIndexCompletedDelegate = new SendOrPostCallback(this.OnReIndexCompleted);
			}
			base.InvokeAsync(this.onBeginReIndexDelegate, new object[]
			{
				id
			}, this.onEndReIndexDelegate, this.onReIndexCompletedDelegate, userState);
		}

		public PredefinedQueue? CastPredefinedQueue(int queueId)
		{
			return base.Channel.CastPredefinedQueue(queueId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginCastPredefinedQueue(int queueId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginCastPredefinedQueue(queueId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PredefinedQueue? EndCastPredefinedQueue(IAsyncResult result)
		{
			return base.Channel.EndCastPredefinedQueue(result);
		}

		private IAsyncResult OnBeginCastPredefinedQueue(object[] inValues, AsyncCallback callback, object asyncState)
		{
			int queueId = (int)inValues[0];
			return this.BeginCastPredefinedQueue(queueId, callback, asyncState);
		}

		private object[] OnEndCastPredefinedQueue(IAsyncResult result)
		{
			PredefinedQueue? predefinedQueue = this.EndCastPredefinedQueue(result);
			return new object[]
			{
				predefinedQueue
			};
		}

		private void OnCastPredefinedQueueCompleted(object state)
		{
			if (this.CastPredefinedQueueCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CastPredefinedQueueCompleted(this, new CastPredefinedQueueCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void CastPredefinedQueueAsync(int queueId)
		{
			this.CastPredefinedQueueAsync(queueId, null);
		}

		public void CastPredefinedQueueAsync(int queueId, object userState)
		{
			if (this.onBeginCastPredefinedQueueDelegate == null)
			{
				this.onBeginCastPredefinedQueueDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginCastPredefinedQueue);
			}
			if (this.onEndCastPredefinedQueueDelegate == null)
			{
				this.onEndCastPredefinedQueueDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndCastPredefinedQueue);
			}
			if (this.onCastPredefinedQueueCompletedDelegate == null)
			{
				this.onCastPredefinedQueueCompletedDelegate = new SendOrPostCallback(this.OnCastPredefinedQueueCompleted);
			}
			base.InvokeAsync(this.onBeginCastPredefinedQueueDelegate, new object[]
			{
				queueId
			}, this.onEndCastPredefinedQueueDelegate, this.onCastPredefinedQueueCompletedDelegate, userState);
		}

		public int PurgeOldVersions(PurgeOldVersionsInstructionData instruction)
		{
			return base.Channel.PurgeOldVersions(instruction);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginPurgeOldVersions(PurgeOldVersionsInstructionData instruction, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginPurgeOldVersions(instruction, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public int EndPurgeOldVersions(IAsyncResult result)
		{
			return base.Channel.EndPurgeOldVersions(result);
		}

		private IAsyncResult OnBeginPurgeOldVersions(object[] inValues, AsyncCallback callback, object asyncState)
		{
			PurgeOldVersionsInstructionData instruction = (PurgeOldVersionsInstructionData)inValues[0];
			return this.BeginPurgeOldVersions(instruction, callback, asyncState);
		}

		private object[] OnEndPurgeOldVersions(IAsyncResult result)
		{
			int num = this.EndPurgeOldVersions(result);
			return new object[]
			{
				num
			};
		}

		private void OnPurgeOldVersionsCompleted(object state)
		{
			if (this.PurgeOldVersionsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PurgeOldVersionsCompleted(this, new PurgeOldVersionsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void PurgeOldVersionsAsync(PurgeOldVersionsInstructionData instruction)
		{
			this.PurgeOldVersionsAsync(instruction, null);
		}

		public void PurgeOldVersionsAsync(PurgeOldVersionsInstructionData instruction, object userState)
		{
			if (this.onBeginPurgeOldVersionsDelegate == null)
			{
				this.onBeginPurgeOldVersionsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginPurgeOldVersions);
			}
			if (this.onEndPurgeOldVersionsDelegate == null)
			{
				this.onEndPurgeOldVersionsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndPurgeOldVersions);
			}
			if (this.onPurgeOldVersionsCompletedDelegate == null)
			{
				this.onPurgeOldVersionsCompletedDelegate = new SendOrPostCallback(this.OnPurgeOldVersionsCompleted);
			}
			base.InvokeAsync(this.onBeginPurgeOldVersionsDelegate, new object[]
			{
				instruction
			}, this.onEndPurgeOldVersionsDelegate, this.onPurgeOldVersionsCompletedDelegate, userState);
		}

		public XElement GetListExternalLinks(string id)
		{
			return base.Channel.GetListExternalLinks(id);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetListExternalLinks(string id, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetListExternalLinks(id, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public XElement EndGetListExternalLinks(IAsyncResult result)
		{
			return base.Channel.EndGetListExternalLinks(result);
		}

		private IAsyncResult OnBeginGetListExternalLinks(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string id = (string)inValues[0];
			return this.BeginGetListExternalLinks(id, callback, asyncState);
		}

		private object[] OnEndGetListExternalLinks(IAsyncResult result)
		{
			XElement xElement = this.EndGetListExternalLinks(result);
			return new object[]
			{
				xElement
			};
		}

		private void OnGetListExternalLinksCompleted(object state)
		{
			if (this.GetListExternalLinksCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListExternalLinksCompleted(this, new GetListExternalLinksCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetListExternalLinksAsync(string id)
		{
			this.GetListExternalLinksAsync(id, null);
		}

		public void GetListExternalLinksAsync(string id, object userState)
		{
			if (this.onBeginGetListExternalLinksDelegate == null)
			{
				this.onBeginGetListExternalLinksDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetListExternalLinks);
			}
			if (this.onEndGetListExternalLinksDelegate == null)
			{
				this.onEndGetListExternalLinksDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetListExternalLinks);
			}
			if (this.onGetListExternalLinksCompletedDelegate == null)
			{
				this.onGetListExternalLinksCompletedDelegate = new SendOrPostCallback(this.OnGetListExternalLinksCompleted);
			}
			base.InvokeAsync(this.onBeginGetListExternalLinksDelegate, new object[]
			{
				id
			}, this.onEndGetListExternalLinksDelegate, this.onGetListExternalLinksCompletedDelegate, userState);
		}

		public SearchQueryData ConvertXmlToSearchQuery(XElement searchQueryXml)
		{
			return base.Channel.ConvertXmlToSearchQuery(searchQueryXml);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginConvertXmlToSearchQuery(XElement searchQueryXml, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginConvertXmlToSearchQuery(searchQueryXml, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SearchQueryData EndConvertXmlToSearchQuery(IAsyncResult result)
		{
			return base.Channel.EndConvertXmlToSearchQuery(result);
		}

		private IAsyncResult OnBeginConvertXmlToSearchQuery(object[] inValues, AsyncCallback callback, object asyncState)
		{
			XElement searchQueryXml = (XElement)inValues[0];
			return this.BeginConvertXmlToSearchQuery(searchQueryXml, callback, asyncState);
		}

		private object[] OnEndConvertXmlToSearchQuery(IAsyncResult result)
		{
			SearchQueryData searchQueryData = this.EndConvertXmlToSearchQuery(result);
			return new object[]
			{
				searchQueryData
			};
		}

		private void OnConvertXmlToSearchQueryCompleted(object state)
		{
			if (this.ConvertXmlToSearchQueryCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertXmlToSearchQueryCompleted(this, new ConvertXmlToSearchQueryCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ConvertXmlToSearchQueryAsync(XElement searchQueryXml)
		{
			this.ConvertXmlToSearchQueryAsync(searchQueryXml, null);
		}

		public void ConvertXmlToSearchQueryAsync(XElement searchQueryXml, object userState)
		{
			if (this.onBeginConvertXmlToSearchQueryDelegate == null)
			{
				this.onBeginConvertXmlToSearchQueryDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginConvertXmlToSearchQuery);
			}
			if (this.onEndConvertXmlToSearchQueryDelegate == null)
			{
				this.onEndConvertXmlToSearchQueryDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndConvertXmlToSearchQuery);
			}
			if (this.onConvertXmlToSearchQueryCompletedDelegate == null)
			{
				this.onConvertXmlToSearchQueryCompletedDelegate = new SendOrPostCallback(this.OnConvertXmlToSearchQueryCompleted);
			}
			base.InvokeAsync(this.onBeginConvertXmlToSearchQueryDelegate, new object[]
			{
				searchQueryXml
			}, this.onEndConvertXmlToSearchQueryDelegate, this.onConvertXmlToSearchQueryCompletedDelegate, userState);
		}

		public XElement ConvertSearchQueryToXml(SearchQueryData searchQueryData)
		{
			return base.Channel.ConvertSearchQueryToXml(searchQueryData);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginConvertSearchQueryToXml(SearchQueryData searchQueryData, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginConvertSearchQueryToXml(searchQueryData, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public XElement EndConvertSearchQueryToXml(IAsyncResult result)
		{
			return base.Channel.EndConvertSearchQueryToXml(result);
		}

		private IAsyncResult OnBeginConvertSearchQueryToXml(object[] inValues, AsyncCallback callback, object asyncState)
		{
			SearchQueryData searchQueryData = (SearchQueryData)inValues[0];
			return this.BeginConvertSearchQueryToXml(searchQueryData, callback, asyncState);
		}

		private object[] OnEndConvertSearchQueryToXml(IAsyncResult result)
		{
			XElement xElement = this.EndConvertSearchQueryToXml(result);
			return new object[]
			{
				xElement
			};
		}

		private void OnConvertSearchQueryToXmlCompleted(object state)
		{
			if (this.ConvertSearchQueryToXmlCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertSearchQueryToXmlCompleted(this, new ConvertSearchQueryToXmlCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ConvertSearchQueryToXmlAsync(SearchQueryData searchQueryData)
		{
			this.ConvertSearchQueryToXmlAsync(searchQueryData, null);
		}

		public void ConvertSearchQueryToXmlAsync(SearchQueryData searchQueryData, object userState)
		{
			if (this.onBeginConvertSearchQueryToXmlDelegate == null)
			{
				this.onBeginConvertSearchQueryToXmlDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginConvertSearchQueryToXml);
			}
			if (this.onEndConvertSearchQueryToXmlDelegate == null)
			{
				this.onEndConvertSearchQueryToXmlDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndConvertSearchQueryToXml);
			}
			if (this.onConvertSearchQueryToXmlCompletedDelegate == null)
			{
				this.onConvertSearchQueryToXmlCompletedDelegate = new SendOrPostCallback(this.OnConvertSearchQueryToXmlCompleted);
			}
			base.InvokeAsync(this.onBeginConvertSearchQueryToXmlDelegate, new object[]
			{
				searchQueryData
			}, this.onEndConvertSearchQueryToXmlDelegate, this.onConvertSearchQueryToXmlCompletedDelegate, userState);
		}

		public AccessTokenData Impersonate(string userName)
		{
			return base.Channel.Impersonate(userName);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginImpersonate(string userName, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginImpersonate(userName, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public AccessTokenData EndImpersonate(IAsyncResult result)
		{
			return base.Channel.EndImpersonate(result);
		}

		private IAsyncResult OnBeginImpersonate(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string userName = (string)inValues[0];
			return this.BeginImpersonate(userName, callback, asyncState);
		}

		private object[] OnEndImpersonate(IAsyncResult result)
		{
			AccessTokenData accessTokenData = this.EndImpersonate(result);
			return new object[]
			{
				accessTokenData
			};
		}

		private void OnImpersonateCompleted(object state)
		{
			if (this.ImpersonateCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ImpersonateCompleted(this, new ImpersonateCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ImpersonateAsync(string userName)
		{
			this.ImpersonateAsync(userName, null);
		}

		public void ImpersonateAsync(string userName, object userState)
		{
			if (this.onBeginImpersonateDelegate == null)
			{
				this.onBeginImpersonateDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginImpersonate);
			}
			if (this.onEndImpersonateDelegate == null)
			{
				this.onEndImpersonateDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndImpersonate);
			}
			if (this.onImpersonateCompletedDelegate == null)
			{
				this.onImpersonateCompletedDelegate = new SendOrPostCallback(this.OnImpersonateCompleted);
			}
			base.InvokeAsync(this.onBeginImpersonateDelegate, new object[]
			{
				userName
			}, this.onEndImpersonateDelegate, this.onImpersonateCompletedDelegate, userState);
		}

		public void ImpersonateWithToken(AccessTokenData accessToken)
		{
			base.Channel.ImpersonateWithToken(accessToken);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginImpersonateWithToken(AccessTokenData accessToken, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginImpersonateWithToken(accessToken, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndImpersonateWithToken(IAsyncResult result)
		{
			base.Channel.EndImpersonateWithToken(result);
		}

		private IAsyncResult OnBeginImpersonateWithToken(object[] inValues, AsyncCallback callback, object asyncState)
		{
			AccessTokenData accessToken = (AccessTokenData)inValues[0];
			return this.BeginImpersonateWithToken(accessToken, callback, asyncState);
		}

		private object[] OnEndImpersonateWithToken(IAsyncResult result)
		{
			this.EndImpersonateWithToken(result);
			return null;
		}

		private void OnImpersonateWithTokenCompleted(object state)
		{
			if (this.ImpersonateWithTokenCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ImpersonateWithTokenCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ImpersonateWithTokenAsync(AccessTokenData accessToken)
		{
			this.ImpersonateWithTokenAsync(accessToken, null);
		}

		public void ImpersonateWithTokenAsync(AccessTokenData accessToken, object userState)
		{
			if (this.onBeginImpersonateWithTokenDelegate == null)
			{
				this.onBeginImpersonateWithTokenDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginImpersonateWithToken);
			}
			if (this.onEndImpersonateWithTokenDelegate == null)
			{
				this.onEndImpersonateWithTokenDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndImpersonateWithToken);
			}
			if (this.onImpersonateWithTokenCompletedDelegate == null)
			{
				this.onImpersonateWithTokenCompletedDelegate = new SendOrPostCallback(this.OnImpersonateWithTokenCompleted);
			}
			base.InvokeAsync(this.onBeginImpersonateWithTokenDelegate, new object[]
			{
				accessToken
			}, this.onEndImpersonateWithTokenDelegate, this.onImpersonateWithTokenCompletedDelegate, userState);
		}

		public AccessTokenData ImpersonateWithClaims(ClaimData[] claims)
		{
			return base.Channel.ImpersonateWithClaims(claims);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginImpersonateWithClaims(ClaimData[] claims, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginImpersonateWithClaims(claims, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public AccessTokenData EndImpersonateWithClaims(IAsyncResult result)
		{
			return base.Channel.EndImpersonateWithClaims(result);
		}

		private IAsyncResult OnBeginImpersonateWithClaims(object[] inValues, AsyncCallback callback, object asyncState)
		{
			ClaimData[] claims = (ClaimData[])inValues[0];
			return this.BeginImpersonateWithClaims(claims, callback, asyncState);
		}

		private object[] OnEndImpersonateWithClaims(IAsyncResult result)
		{
			AccessTokenData accessTokenData = this.EndImpersonateWithClaims(result);
			return new object[]
			{
				accessTokenData
			};
		}

		private void OnImpersonateWithClaimsCompleted(object state)
		{
			if (this.ImpersonateWithClaimsCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ImpersonateWithClaimsCompleted(this, new ImpersonateWithClaimsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ImpersonateWithClaimsAsync(ClaimData[] claims)
		{
			this.ImpersonateWithClaimsAsync(claims, null);
		}

		public void ImpersonateWithClaimsAsync(ClaimData[] claims, object userState)
		{
			if (this.onBeginImpersonateWithClaimsDelegate == null)
			{
				this.onBeginImpersonateWithClaimsDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginImpersonateWithClaims);
			}
			if (this.onEndImpersonateWithClaimsDelegate == null)
			{
				this.onEndImpersonateWithClaimsDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndImpersonateWithClaims);
			}
			if (this.onImpersonateWithClaimsCompletedDelegate == null)
			{
				this.onImpersonateWithClaimsCompletedDelegate = new SendOrPostCallback(this.OnImpersonateWithClaimsCompleted);
			}
			base.InvokeAsync(this.onBeginImpersonateWithClaimsDelegate, new object[]
			{
				claims
			}, this.onEndImpersonateWithClaimsDelegate, this.onImpersonateWithClaimsCompletedDelegate, userState);
		}

		public void TerminateSession()
		{
			base.Channel.TerminateSession();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginTerminateSession(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginTerminateSession(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndTerminateSession(IAsyncResult result)
		{
			base.Channel.EndTerminateSession(result);
		}

		private IAsyncResult OnBeginTerminateSession(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginTerminateSession(callback, asyncState);
		}

		private object[] OnEndTerminateSession(IAsyncResult result)
		{
			this.EndTerminateSession(result);
			return null;
		}

		private void OnTerminateSessionCompleted(object state)
		{
			if (this.TerminateSessionCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.TerminateSessionCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void TerminateSessionAsync()
		{
			this.TerminateSessionAsync(null);
		}

		public void TerminateSessionAsync(object userState)
		{
			if (this.onBeginTerminateSessionDelegate == null)
			{
				this.onBeginTerminateSessionDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginTerminateSession);
			}
			if (this.onEndTerminateSessionDelegate == null)
			{
				this.onEndTerminateSessionDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndTerminateSession);
			}
			if (this.onTerminateSessionCompletedDelegate == null)
			{
				this.onTerminateSessionCompletedDelegate = new SendOrPostCallback(this.OnTerminateSessionCompleted);
			}
			base.InvokeAsync(this.onBeginTerminateSessionDelegate, null, this.onEndTerminateSessionDelegate, this.onTerminateSessionCompletedDelegate, userState);
		}

		public string GetSessionId()
		{
			return base.Channel.GetSessionId();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSessionId(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSessionId(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndGetSessionId(IAsyncResult result)
		{
			return base.Channel.EndGetSessionId(result);
		}

		private IAsyncResult OnBeginGetSessionId(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetSessionId(callback, asyncState);
		}

		private object[] OnEndGetSessionId(IAsyncResult result)
		{
			string text = this.EndGetSessionId(result);
			return new object[]
			{
				text
			};
		}

		private void OnGetSessionIdCompleted(object state)
		{
			if (this.GetSessionIdCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSessionIdCompleted(this, new GetSessionIdCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSessionIdAsync()
		{
			this.GetSessionIdAsync(null);
		}

		public void GetSessionIdAsync(object userState)
		{
			if (this.onBeginGetSessionIdDelegate == null)
			{
				this.onBeginGetSessionIdDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSessionId);
			}
			if (this.onEndGetSessionIdDelegate == null)
			{
				this.onEndGetSessionIdDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSessionId);
			}
			if (this.onGetSessionIdCompletedDelegate == null)
			{
				this.onGetSessionIdCompletedDelegate = new SendOrPostCallback(this.OnGetSessionIdCompleted);
			}
			base.InvokeAsync(this.onBeginGetSessionIdDelegate, null, this.onEndGetSessionIdDelegate, this.onGetSessionIdCompletedDelegate, userState);
		}

		public void SetSessionContextData(ApplicationData appData)
		{
			base.Channel.SetSessionContextData(appData);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSetSessionContextData(ApplicationData appData, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSetSessionContextData(appData, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndSetSessionContextData(IAsyncResult result)
		{
			base.Channel.EndSetSessionContextData(result);
		}

		private IAsyncResult OnBeginSetSessionContextData(object[] inValues, AsyncCallback callback, object asyncState)
		{
			ApplicationData appData = (ApplicationData)inValues[0];
			return this.BeginSetSessionContextData(appData, callback, asyncState);
		}

		private object[] OnEndSetSessionContextData(IAsyncResult result)
		{
			this.EndSetSessionContextData(result);
			return null;
		}

		private void OnSetSessionContextDataCompleted(object state)
		{
			if (this.SetSessionContextDataCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SetSessionContextDataCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SetSessionContextDataAsync(ApplicationData appData)
		{
			this.SetSessionContextDataAsync(appData, null);
		}

		public void SetSessionContextDataAsync(ApplicationData appData, object userState)
		{
			if (this.onBeginSetSessionContextDataDelegate == null)
			{
				this.onBeginSetSessionContextDataDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSetSessionContextData);
			}
			if (this.onEndSetSessionContextDataDelegate == null)
			{
				this.onEndSetSessionContextDataDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSetSessionContextData);
			}
			if (this.onSetSessionContextDataCompletedDelegate == null)
			{
				this.onSetSessionContextDataCompletedDelegate = new SendOrPostCallback(this.OnSetSessionContextDataCompleted);
			}
			base.InvokeAsync(this.onBeginSetSessionContextDataDelegate, new object[]
			{
				appData
			}, this.onEndSetSessionContextDataDelegate, this.onSetSessionContextDataCompletedDelegate, userState);
		}

		public void SetSessionTransactionTimeout(int transactionTimeout)
		{
			base.Channel.SetSessionTransactionTimeout(transactionTimeout);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSetSessionTransactionTimeout(int transactionTimeout, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSetSessionTransactionTimeout(transactionTimeout, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndSetSessionTransactionTimeout(IAsyncResult result)
		{
			base.Channel.EndSetSessionTransactionTimeout(result);
		}

		private IAsyncResult OnBeginSetSessionTransactionTimeout(object[] inValues, AsyncCallback callback, object asyncState)
		{
			int transactionTimeout = (int)inValues[0];
			return this.BeginSetSessionTransactionTimeout(transactionTimeout, callback, asyncState);
		}

		private object[] OnEndSetSessionTransactionTimeout(IAsyncResult result)
		{
			this.EndSetSessionTransactionTimeout(result);
			return null;
		}

		private void OnSetSessionTransactionTimeoutCompleted(object state)
		{
			if (this.SetSessionTransactionTimeoutCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SetSessionTransactionTimeoutCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SetSessionTransactionTimeoutAsync(int transactionTimeout)
		{
			this.SetSessionTransactionTimeoutAsync(transactionTimeout, null);
		}

		public void SetSessionTransactionTimeoutAsync(int transactionTimeout, object userState)
		{
			if (this.onBeginSetSessionTransactionTimeoutDelegate == null)
			{
				this.onBeginSetSessionTransactionTimeoutDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSetSessionTransactionTimeout);
			}
			if (this.onEndSetSessionTransactionTimeoutDelegate == null)
			{
				this.onEndSetSessionTransactionTimeoutDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSetSessionTransactionTimeout);
			}
			if (this.onSetSessionTransactionTimeoutCompletedDelegate == null)
			{
				this.onSetSessionTransactionTimeoutCompletedDelegate = new SendOrPostCallback(this.OnSetSessionTransactionTimeoutCompleted);
			}
			base.InvokeAsync(this.onBeginSetSessionTransactionTimeoutDelegate, new object[]
			{
				transactionTimeout
			}, this.onEndSetSessionTransactionTimeoutDelegate, this.onSetSessionTransactionTimeoutCompletedDelegate, userState);
		}

		public int GetSessionTransactionTimeout()
		{
			return base.Channel.GetSessionTransactionTimeout();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginGetSessionTransactionTimeout(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginGetSessionTransactionTimeout(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public int EndGetSessionTransactionTimeout(IAsyncResult result)
		{
			return base.Channel.EndGetSessionTransactionTimeout(result);
		}

		private IAsyncResult OnBeginGetSessionTransactionTimeout(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginGetSessionTransactionTimeout(callback, asyncState);
		}

		private object[] OnEndGetSessionTransactionTimeout(IAsyncResult result)
		{
			int num = this.EndGetSessionTransactionTimeout(result);
			return new object[]
			{
				num
			};
		}

		private void OnGetSessionTransactionTimeoutCompleted(object state)
		{
			if (this.GetSessionTransactionTimeoutCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSessionTransactionTimeoutCompleted(this, new GetSessionTransactionTimeoutCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void GetSessionTransactionTimeoutAsync()
		{
			this.GetSessionTransactionTimeoutAsync(null);
		}

		public void GetSessionTransactionTimeoutAsync(object userState)
		{
			if (this.onBeginGetSessionTransactionTimeoutDelegate == null)
			{
				this.onBeginGetSessionTransactionTimeoutDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginGetSessionTransactionTimeout);
			}
			if (this.onEndGetSessionTransactionTimeoutDelegate == null)
			{
				this.onEndGetSessionTransactionTimeoutDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndGetSessionTransactionTimeout);
			}
			if (this.onGetSessionTransactionTimeoutCompletedDelegate == null)
			{
				this.onGetSessionTransactionTimeoutCompletedDelegate = new SendOrPostCallback(this.OnGetSessionTransactionTimeoutCompleted);
			}
			base.InvokeAsync(this.onBeginGetSessionTransactionTimeoutDelegate, null, this.onEndGetSessionTransactionTimeoutDelegate, this.onGetSessionTransactionTimeoutCompletedDelegate, userState);
		}

		public bool StartCaching()
		{
			return base.Channel.StartCaching();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginStartCaching(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginStartCaching(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public bool EndStartCaching(IAsyncResult result)
		{
			return base.Channel.EndStartCaching(result);
		}

		private IAsyncResult OnBeginStartCaching(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginStartCaching(callback, asyncState);
		}

		private object[] OnEndStartCaching(IAsyncResult result)
		{
			bool flag = this.EndStartCaching(result);
			return new object[]
			{
				flag
			};
		}

		private void OnStartCachingCompleted(object state)
		{
			if (this.StartCachingCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.StartCachingCompleted(this, new StartCachingCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void StartCachingAsync()
		{
			this.StartCachingAsync(null);
		}

		public void StartCachingAsync(object userState)
		{
			if (this.onBeginStartCachingDelegate == null)
			{
				this.onBeginStartCachingDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginStartCaching);
			}
			if (this.onEndStartCachingDelegate == null)
			{
				this.onEndStartCachingDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndStartCaching);
			}
			if (this.onStartCachingCompletedDelegate == null)
			{
				this.onStartCachingCompletedDelegate = new SendOrPostCallback(this.OnStartCachingCompleted);
			}
			base.InvokeAsync(this.onBeginStartCachingDelegate, null, this.onEndStartCachingDelegate, this.onStartCachingCompletedDelegate, userState);
		}

		public void StopCaching()
		{
			base.Channel.StopCaching();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginStopCaching(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginStopCaching(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndStopCaching(IAsyncResult result)
		{
			base.Channel.EndStopCaching(result);
		}

		private IAsyncResult OnBeginStopCaching(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginStopCaching(callback, asyncState);
		}

		private object[] OnEndStopCaching(IAsyncResult result)
		{
			this.EndStopCaching(result);
			return null;
		}

		private void OnStopCachingCompleted(object state)
		{
			if (this.StopCachingCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.StopCachingCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void StopCachingAsync()
		{
			this.StopCachingAsync(null);
		}

		public void StopCachingAsync(object userState)
		{
			if (this.onBeginStopCachingDelegate == null)
			{
				this.onBeginStopCachingDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginStopCaching);
			}
			if (this.onEndStopCachingDelegate == null)
			{
				this.onEndStopCachingDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndStopCaching);
			}
			if (this.onStopCachingCompletedDelegate == null)
			{
				this.onStopCachingCompletedDelegate = new SendOrPostCallback(this.OnStopCachingCompleted);
			}
			base.InvokeAsync(this.onBeginStopCachingDelegate, null, this.onEndStopCachingDelegate, this.onStopCachingCompletedDelegate, userState);
		}

		public void SetWebDavUrlPrefix(string prefix)
		{
			base.Channel.SetWebDavUrlPrefix(prefix);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginSetWebDavUrlPrefix(string prefix, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginSetWebDavUrlPrefix(prefix, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndSetWebDavUrlPrefix(IAsyncResult result)
		{
			base.Channel.EndSetWebDavUrlPrefix(result);
		}

		private IAsyncResult OnBeginSetWebDavUrlPrefix(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string prefix = (string)inValues[0];
			return this.BeginSetWebDavUrlPrefix(prefix, callback, asyncState);
		}

		private object[] OnEndSetWebDavUrlPrefix(IAsyncResult result)
		{
			this.EndSetWebDavUrlPrefix(result);
			return null;
		}

		private void OnSetWebDavUrlPrefixCompleted(object state)
		{
			if (this.SetWebDavUrlPrefixCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SetWebDavUrlPrefixCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void SetWebDavUrlPrefixAsync(string prefix)
		{
			this.SetWebDavUrlPrefixAsync(prefix, null);
		}

		public void SetWebDavUrlPrefixAsync(string prefix, object userState)
		{
			if (this.onBeginSetWebDavUrlPrefixDelegate == null)
			{
				this.onBeginSetWebDavUrlPrefixDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginSetWebDavUrlPrefix);
			}
			if (this.onEndSetWebDavUrlPrefixDelegate == null)
			{
				this.onEndSetWebDavUrlPrefixDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndSetWebDavUrlPrefix);
			}
			if (this.onSetWebDavUrlPrefixCompletedDelegate == null)
			{
				this.onSetWebDavUrlPrefixCompletedDelegate = new SendOrPostCallback(this.OnSetWebDavUrlPrefixCompleted);
			}
			base.InvokeAsync(this.onBeginSetWebDavUrlPrefixDelegate, new object[]
			{
				prefix
			}, this.onEndSetWebDavUrlPrefixDelegate, this.onSetWebDavUrlPrefixCompletedDelegate, userState);
		}

		public void EnlistInTransaction()
		{
			base.Channel.EnlistInTransaction();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginEnlistInTransaction(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginEnlistInTransaction(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndEnlistInTransaction(IAsyncResult result)
		{
			base.Channel.EndEnlistInTransaction(result);
		}

		private IAsyncResult OnBeginEnlistInTransaction(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginEnlistInTransaction(callback, asyncState);
		}

		private object[] OnEndEnlistInTransaction(IAsyncResult result)
		{
			this.EndEnlistInTransaction(result);
			return null;
		}

		private void OnEnlistInTransactionCompleted(object state)
		{
			if (this.EnlistInTransactionCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.EnlistInTransactionCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void EnlistInTransactionAsync()
		{
			this.EnlistInTransactionAsync(null);
		}

		public void EnlistInTransactionAsync(object userState)
		{
			if (this.onBeginEnlistInTransactionDelegate == null)
			{
				this.onBeginEnlistInTransactionDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginEnlistInTransaction);
			}
			if (this.onEndEnlistInTransactionDelegate == null)
			{
				this.onEndEnlistInTransactionDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndEnlistInTransaction);
			}
			if (this.onEnlistInTransactionCompletedDelegate == null)
			{
				this.onEnlistInTransactionCompletedDelegate = new SendOrPostCallback(this.OnEnlistInTransactionCompleted);
			}
			base.InvokeAsync(this.onBeginEnlistInTransactionDelegate, null, this.onEndEnlistInTransactionDelegate, this.onEnlistInTransactionCompletedDelegate, userState);
		}

		public UserData ElevatePrivileges(Privileges privileges)
		{
			return base.Channel.ElevatePrivileges(privileges);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginElevatePrivileges(Privileges privileges, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginElevatePrivileges(privileges, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public UserData EndElevatePrivileges(IAsyncResult result)
		{
			return base.Channel.EndElevatePrivileges(result);
		}

		private IAsyncResult OnBeginElevatePrivileges(object[] inValues, AsyncCallback callback, object asyncState)
		{
			Privileges privileges = (Privileges)inValues[0];
			return this.BeginElevatePrivileges(privileges, callback, asyncState);
		}

		private object[] OnEndElevatePrivileges(IAsyncResult result)
		{
			UserData userData = this.EndElevatePrivileges(result);
			return new object[]
			{
				userData
			};
		}

		private void OnElevatePrivilegesCompleted(object state)
		{
			if (this.ElevatePrivilegesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ElevatePrivilegesCompleted(this, new ElevatePrivilegesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ElevatePrivilegesAsync(Privileges privileges)
		{
			this.ElevatePrivilegesAsync(privileges, null);
		}

		public void ElevatePrivilegesAsync(Privileges privileges, object userState)
		{
			if (this.onBeginElevatePrivilegesDelegate == null)
			{
				this.onBeginElevatePrivilegesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginElevatePrivileges);
			}
			if (this.onEndElevatePrivilegesDelegate == null)
			{
				this.onEndElevatePrivilegesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndElevatePrivileges);
			}
			if (this.onElevatePrivilegesCompletedDelegate == null)
			{
				this.onElevatePrivilegesCompletedDelegate = new SendOrPostCallback(this.OnElevatePrivilegesCompleted);
			}
			base.InvokeAsync(this.onBeginElevatePrivilegesDelegate, new object[]
			{
				privileges
			}, this.onEndElevatePrivilegesDelegate, this.onElevatePrivilegesCompletedDelegate, userState);
		}

		public UserData RestorePrivileges()
		{
			return base.Channel.RestorePrivileges();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginRestorePrivileges(AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginRestorePrivileges(callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public UserData EndRestorePrivileges(IAsyncResult result)
		{
			return base.Channel.EndRestorePrivileges(result);
		}

		private IAsyncResult OnBeginRestorePrivileges(object[] inValues, AsyncCallback callback, object asyncState)
		{
			return this.BeginRestorePrivileges(callback, asyncState);
		}

		private object[] OnEndRestorePrivileges(IAsyncResult result)
		{
			UserData userData = this.EndRestorePrivileges(result);
			return new object[]
			{
				userData
			};
		}

		private void OnRestorePrivilegesCompleted(object state)
		{
			if (this.RestorePrivilegesCompleted != null)
			{
				ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ISessionAwareCoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RestorePrivilegesCompleted(this, new RestorePrivilegesCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void RestorePrivilegesAsync()
		{
			this.RestorePrivilegesAsync(null);
		}

		public void RestorePrivilegesAsync(object userState)
		{
			if (this.onBeginRestorePrivilegesDelegate == null)
			{
				this.onBeginRestorePrivilegesDelegate = new ClientBase<ISessionAwareCoreService>.BeginOperationDelegate(this.OnBeginRestorePrivileges);
			}
			if (this.onEndRestorePrivilegesDelegate == null)
			{
				this.onEndRestorePrivilegesDelegate = new ClientBase<ISessionAwareCoreService>.EndOperationDelegate(this.OnEndRestorePrivileges);
			}
			if (this.onRestorePrivilegesCompletedDelegate == null)
			{
				this.onRestorePrivilegesCompletedDelegate = new SendOrPostCallback(this.OnRestorePrivilegesCompleted);
			}
			base.InvokeAsync(this.onBeginRestorePrivilegesDelegate, null, this.onEndRestorePrivilegesDelegate, this.onRestorePrivilegesCompletedDelegate, userState);
		}

		public VersionedItemData CheckIn(string id, ReadOptions readBackOptions)
		{
			return this.CheckIn(id, true, null, readBackOptions);
		}

		public SchemaFieldsData ConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, ReadOptions readOptions)
		{
			return this.ConvertXsdToSchemaFields(xsd, purpose, null, readOptions);
		}

		public void Dispose()
		{
			ClientHelper.DisposeClient(this);
		}
	}
}
