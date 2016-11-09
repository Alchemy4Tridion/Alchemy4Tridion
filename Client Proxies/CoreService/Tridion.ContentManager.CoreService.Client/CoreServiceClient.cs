using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.Xml.Linq;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class CoreServiceClient : ClientBase<ICoreService>, ICoreService, IDisposable
	{
		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetVirtualFolderTypeSchemaDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetVirtualFolderTypeSchemaDelegate;

		private SendOrPostCallback onGetVirtualFolderTypeSchemaCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetEnumValuesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetEnumValuesDelegate;

		private SendOrPostCallback onGetEnumValuesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginResolveBundleTypesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndResolveBundleTypesDelegate;

		private SendOrPostCallback onResolveBundleTypesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginCopyToKeywordDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndCopyToKeywordDelegate;

		private SendOrPostCallback onCopyToKeywordCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginMoveToKeywordDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndMoveToKeywordDelegate;

		private SendOrPostCallback onMoveToKeywordCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetTridionLanguagesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetTridionLanguagesDelegate;

		private SendOrPostCallback onGetTridionLanguagesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListWorkflowScriptTypesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListWorkflowScriptTypesDelegate;

		private SendOrPostCallback onGetListWorkflowScriptTypesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginAddToWorkflowDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndAddToWorkflowDelegate;

		private SendOrPostCallback onAddToWorkflowCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginRemoveFromWorkflowDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndRemoveFromWorkflowDelegate;

		private SendOrPostCallback onRemoveFromWorkflowCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginLockDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndLockDelegate;

		private SendOrPostCallback onLockCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginUnlockDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndUnlockDelegate;

		private SendOrPostCallback onUnlockCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginStartWorkflowDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndStartWorkflowDelegate;

		private SendOrPostCallback onStartWorkflowCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginUndoPublishTransactionDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndUndoPublishTransactionDelegate;

		private SendOrPostCallback onUndoPublishTransactionCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetProcessDefinitionsForItemsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetProcessDefinitionsForItemsDelegate;

		private SendOrPostCallback onGetProcessDefinitionsForItemsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSystemXsdDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSystemXsdDelegate;

		private SendOrPostCallback onGetSystemXsdCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSchemasByNamespaceUriDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSchemasByNamespaceUriDelegate;

		private SendOrPostCallback onGetSchemasByNamespaceUriCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginValidateDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndValidateDelegate;

		private SendOrPostCallback onValidateCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetExternalBinaryContentDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetExternalBinaryContentDataDelegate;

		private SendOrPostCallback onGetExternalBinaryContentDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginSynchronizeWithSchemaDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndSynchronizeWithSchemaDelegate;

		private SendOrPostCallback onSynchronizeWithSchemaCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginSynchronizeWithSchemaAndUpdateDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndSynchronizeWithSchemaAndUpdateDelegate;

		private SendOrPostCallback onSynchronizeWithSchemaAndUpdateCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginDecommissionPublicationTargetDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndDecommissionPublicationTargetDelegate;

		private SendOrPostCallback onDecommissionPublicationTargetCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginConvertXsdToSchemaFieldsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndConvertXsdToSchemaFieldsDelegate;

		private SendOrPostCallback onConvertXsdToSchemaFieldsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetPublishUrlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetPublishUrlDelegate;

		private SendOrPostCallback onGetPublishUrlCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetBusinessProcessTypesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetBusinessProcessTypesDelegate;

		private SendOrPostCallback onGetBusinessProcessTypesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetPublishSourceByUrlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetPublishSourceByUrlDelegate;

		private SendOrPostCallback onGetPublishSourceByUrlCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginRemovePublishStatesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndRemovePublishStatesDelegate;

		private SendOrPostCallback onRemovePublishStatesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginResolveContainingPagesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndResolveContainingPagesDelegate;

		private SendOrPostCallback onResolveContainingPagesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginPurgeWorkflowHistoryDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndPurgeWorkflowHistoryDelegate;

		private SendOrPostCallback onPurgeWorkflowHistoryCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetApiVersionDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetApiVersionDelegate;

		private SendOrPostCallback onGetApiVersionCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetCurrentUserDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetCurrentUserDelegate;

		private SendOrPostCallback onGetCurrentUserCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginIsExistingObjectDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndIsExistingObjectDelegate;

		private SendOrPostCallback onIsExistingObjectCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetTcmUriDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetTcmUriDelegate;

		private SendOrPostCallback onGetTcmUriCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginTryGetTcmUriDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndTryGetTcmUriDelegate;

		private SendOrPostCallback onTryGetTcmUriCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReadDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReadDelegate;

		private SendOrPostCallback onReadCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginTryReadDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndTryReadDelegate;

		private SendOrPostCallback onTryReadCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginBulkReadDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndBulkReadDelegate;

		private SendOrPostCallback onBulkReadCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReadSchemaFieldsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReadSchemaFieldsDelegate;

		private SendOrPostCallback onReadSchemaFieldsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginConvertSchemaFieldsToXsdDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndConvertSchemaFieldsToXsdDelegate;

		private SendOrPostCallback onConvertSchemaFieldsToXsdCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginSaveDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndSaveDelegate;

		private SendOrPostCallback onSaveCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginDeleteDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndDeleteDelegate;

		private SendOrPostCallback onDeleteCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginDeleteTaxonomyNodeDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndDeleteTaxonomyNodeDelegate;

		private SendOrPostCallback onDeleteTaxonomyNodeCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetDefaultDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetDefaultDataDelegate;

		private SendOrPostCallback onGetDefaultDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginMoveDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndMoveDelegate;

		private SendOrPostCallback onMoveCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginCopyDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndCopyDelegate;

		private SendOrPostCallback onCopyCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetInstanceDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetInstanceDataDelegate;

		private SendOrPostCallback onGetInstanceDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginTryCheckOutDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndTryCheckOutDelegate;

		private SendOrPostCallback onTryCheckOutCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginCheckOutDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndCheckOutDelegate;

		private SendOrPostCallback onCheckOutCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginCheckInDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndCheckInDelegate;

		private SendOrPostCallback onCheckInCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginUpdateDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndUpdateDelegate;

		private SendOrPostCallback onUpdateCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginCreateDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndCreateDelegate;

		private SendOrPostCallback onCreateCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginUndoCheckOutDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndUndoCheckOutDelegate;

		private SendOrPostCallback onUndoCheckOutCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginRollbackDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndRollbackDelegate;

		private SendOrPostCallback onRollbackCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginLocalizeDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndLocalizeDelegate;

		private SendOrPostCallback onLocalizeCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginUnLocalizeDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndUnLocalizeDelegate;

		private SendOrPostCallback onUnLocalizeCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginPromoteDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndPromoteDelegate;

		private SendOrPostCallback onPromoteCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginDemoteDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndDemoteDelegate;

		private SendOrPostCallback onDemoteCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListTemplateTypesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListTemplateTypesDelegate;

		private SendOrPostCallback onGetListTemplateTypesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListPublicationTypesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListPublicationTypesDelegate;

		private SendOrPostCallback onGetListPublicationTypesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSystemWideListXmlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSystemWideListXmlDelegate;

		private SendOrPostCallback onGetSystemWideListXmlCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSystemWideListDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSystemWideListDelegate;

		private SendOrPostCallback onGetSystemWideListCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListXmlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListXmlDelegate;

		private SendOrPostCallback onGetListXmlCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListDelegate;

		private SendOrPostCallback onGetListCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceNamesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListDirectoryServiceNamesDelegate;

		private SendOrPostCallback onGetListDirectoryServiceNamesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListWindowsDomainUsersDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListWindowsDomainUsersDelegate;

		private SendOrPostCallback onGetListWindowsDomainUsersCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceAllUsersDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListDirectoryServiceAllUsersDelegate;

		private SendOrPostCallback onGetListDirectoryServiceAllUsersCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceGroupMembersDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListDirectoryServiceGroupMembersDelegate;

		private SendOrPostCallback onGetListDirectoryServiceGroupMembersCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListDirectoryServiceUsersDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListDirectoryServiceUsersDelegate;

		private SendOrPostCallback onGetListDirectoryServiceUsersCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginClassifyDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndClassifyDelegate;

		private SendOrPostCallback onClassifyCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginUnClassifyDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndUnClassifyDelegate;

		private SendOrPostCallback onUnClassifyCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReClassifyDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReClassifyDelegate;

		private SendOrPostCallback onReClassifyCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginStartActivityDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndStartActivityDelegate;

		private SendOrPostCallback onStartActivityCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginSuspendActivityDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndSuspendActivityDelegate;

		private SendOrPostCallback onSuspendActivityCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginRestartActivityDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndRestartActivityDelegate;

		private SendOrPostCallback onRestartActivityCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReAssignActivityDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReAssignActivityDelegate;

		private SendOrPostCallback onReAssignActivityCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginFinishActivityDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndFinishActivityDelegate;

		private SendOrPostCallback onFinishActivityCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginForceFinishProcessDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndForceFinishProcessDelegate;

		private SendOrPostCallback onForceFinishProcessCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginResumeActivityDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndResumeActivityDelegate;

		private SendOrPostCallback onResumeActivityCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListQueueMessagesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListQueueMessagesDelegate;

		private SendOrPostCallback onGetListQueueMessagesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginPurgeQueueDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndPurgeQueueDelegate;

		private SendOrPostCallback onPurgeQueueCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListQueuesDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListQueuesDelegate;

		private SendOrPostCallback onGetListQueuesCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReadApplicationDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReadApplicationDataDelegate;

		private SendOrPostCallback onReadApplicationDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReadAllApplicationDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReadAllApplicationDataDelegate;

		private SendOrPostCallback onReadAllApplicationDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginSaveApplicationDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndSaveApplicationDataDelegate;

		private SendOrPostCallback onSaveApplicationDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginDeleteApplicationDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndDeleteApplicationDataDelegate;

		private SendOrPostCallback onDeleteApplicationDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetApplicationIdsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetApplicationIdsDelegate;

		private SendOrPostCallback onGetApplicationIdsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginPurgeApplicationDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndPurgeApplicationDataDelegate;

		private SendOrPostCallback onPurgeApplicationDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginParsePredefinedBatchOperationDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndParsePredefinedBatchOperationDelegate;

		private SendOrPostCallback onParsePredefinedBatchOperationCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetPredefinedBatchOperationNameDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetPredefinedBatchOperationNameDelegate;

		private SendOrPostCallback onGetPredefinedBatchOperationNameCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginResolveItemsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndResolveItemsDelegate;

		private SendOrPostCallback onResolveItemsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSearchResultsXmlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSearchResultsXmlDelegate;

		private SendOrPostCallback onGetSearchResultsXmlCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSearchResultsXmlPagedDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSearchResultsXmlPagedDelegate;

		private SendOrPostCallback onGetSearchResultsXmlPagedCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSearchResultsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSearchResultsDelegate;

		private SendOrPostCallback onGetSearchResultsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSearchResultsPagedDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSearchResultsPagedDelegate;

		private SendOrPostCallback onGetSearchResultsPagedCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginRenderItemDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndRenderItemDelegate;

		private SendOrPostCallback onRenderItemCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginPreviewItemDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndPreviewItemDelegate;

		private SendOrPostCallback onPreviewItemCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginPublishDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndPublishDelegate;

		private SendOrPostCallback onPublishCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginUnPublishDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndUnPublishDelegate;

		private SendOrPostCallback onUnPublishCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginIsPublishedDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndIsPublishedDelegate;

		private SendOrPostCallback onIsPublishedCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetWorkItemSnapshotDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetWorkItemSnapshotDelegate;

		private SendOrPostCallback onGetWorkItemSnapshotCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListPublishInfoDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListPublishInfoDelegate;

		private SendOrPostCallback onGetListPublishInfoCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginCastActionsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndCastActionsDelegate;

		private SendOrPostCallback onCastActionsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginValidateXmlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndValidateXmlDelegate;

		private SendOrPostCallback onValidateXmlCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginIsValidTridionWebSchemaXmlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndIsValidTridionWebSchemaXmlDelegate;

		private SendOrPostCallback onIsValidTridionWebSchemaXmlCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSubjectIdsWithApplicationDataDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSubjectIdsWithApplicationDataDelegate;

		private SendOrPostCallback onGetSubjectIdsWithApplicationDataCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReadApplicationDataForSubjectsIdsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReadApplicationDataForSubjectsIdsDelegate;

		private SendOrPostCallback onReadApplicationDataForSubjectsIdsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetSecurityDescriptorsForSubjectsIdsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetSecurityDescriptorsForSubjectsIdsDelegate;

		private SendOrPostCallback onGetSecurityDescriptorsForSubjectsIdsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetContentSecurityDescriptorsForOrgItemIdsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetContentSecurityDescriptorsForOrgItemIdsDelegate;

		private SendOrPostCallback onGetContentSecurityDescriptorsForOrgItemIdsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginReIndexDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndReIndexDelegate;

		private SendOrPostCallback onReIndexCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginCastPredefinedQueueDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndCastPredefinedQueueDelegate;

		private SendOrPostCallback onCastPredefinedQueueCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginPurgeOldVersionsDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndPurgeOldVersionsDelegate;

		private SendOrPostCallback onPurgeOldVersionsCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginGetListExternalLinksDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndGetListExternalLinksDelegate;

		private SendOrPostCallback onGetListExternalLinksCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginConvertXmlToSearchQueryDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndConvertXmlToSearchQueryDelegate;

		private SendOrPostCallback onConvertXmlToSearchQueryCompletedDelegate;

		private ClientBase<ICoreService>.BeginOperationDelegate onBeginConvertSearchQueryToXmlDelegate;

		private ClientBase<ICoreService>.EndOperationDelegate onEndConvertSearchQueryToXmlDelegate;

		private SendOrPostCallback onConvertSearchQueryToXmlCompletedDelegate;

		public event EventHandler<GetVirtualFolderTypeSchemaCompletedEventArgs1> GetVirtualFolderTypeSchemaCompleted;

		public event EventHandler<GetEnumValuesCompletedEventArgs1> GetEnumValuesCompleted;

		public event EventHandler<ResolveBundleTypesCompletedEventArgs1> ResolveBundleTypesCompleted;

		public event EventHandler<CopyToKeywordCompletedEventArgs1> CopyToKeywordCompleted;

		public event EventHandler<MoveToKeywordCompletedEventArgs1> MoveToKeywordCompleted;

		public event EventHandler<GetTridionLanguagesCompletedEventArgs1> GetTridionLanguagesCompleted;

		public event EventHandler<GetListWorkflowScriptTypesCompletedEventArgs1> GetListWorkflowScriptTypesCompleted;

		public event EventHandler<AddToWorkflowCompletedEventArgs1> AddToWorkflowCompleted;

		public event EventHandler<RemoveFromWorkflowCompletedEventArgs1> RemoveFromWorkflowCompleted;

		public event EventHandler<LockCompletedEventArgs1> LockCompleted;

		public event EventHandler<UnlockCompletedEventArgs1> UnlockCompleted;

		public event EventHandler<StartWorkflowCompletedEventArgs1> StartWorkflowCompleted;

		public event EventHandler<UndoPublishTransactionCompletedEventArgs1> UndoPublishTransactionCompleted;

		public event EventHandler<GetProcessDefinitionsForItemsCompletedEventArgs1> GetProcessDefinitionsForItemsCompleted;

		public event EventHandler<GetSystemXsdCompletedEventArgs1> GetSystemXsdCompleted;

		public event EventHandler<GetSchemasByNamespaceUriCompletedEventArgs1> GetSchemasByNamespaceUriCompleted;

		public event EventHandler<ValidateCompletedEventArgs1> ValidateCompleted;

		public event EventHandler<GetExternalBinaryContentDataCompletedEventArgs1> GetExternalBinaryContentDataCompleted;

		public event EventHandler<SynchronizeWithSchemaCompletedEventArgs1> SynchronizeWithSchemaCompleted;

		public event EventHandler<SynchronizeWithSchemaAndUpdateCompletedEventArgs1> SynchronizeWithSchemaAndUpdateCompleted;

		public event EventHandler<AsyncCompletedEventArgs> DecommissionPublicationTargetCompleted;

		public event EventHandler<ConvertXsdToSchemaFieldsCompletedEventArgs1> ConvertXsdToSchemaFieldsCompleted;

		public event EventHandler<GetPublishUrlCompletedEventArgs1> GetPublishUrlCompleted;

		public event EventHandler<GetBusinessProcessTypesCompletedEventArgs1> GetBusinessProcessTypesCompleted;

		public event EventHandler<GetPublishSourceByUrlCompletedEventArgs1> GetPublishSourceByUrlCompleted;

		public event EventHandler<AsyncCompletedEventArgs> RemovePublishStatesCompleted;

		public event EventHandler<ResolveContainingPagesCompletedEventArgs1> ResolveContainingPagesCompleted;

		public event EventHandler<AsyncCompletedEventArgs> PurgeWorkflowHistoryCompleted;

		public event EventHandler<GetApiVersionCompletedEventArgs1> GetApiVersionCompleted;

		public event EventHandler<GetCurrentUserCompletedEventArgs1> GetCurrentUserCompleted;

		public event EventHandler<IsExistingObjectCompletedEventArgs1> IsExistingObjectCompleted;

		public event EventHandler<GetTcmUriCompletedEventArgs1> GetTcmUriCompleted;

		public event EventHandler<TryGetTcmUriCompletedEventArgs1> TryGetTcmUriCompleted;

		public event EventHandler<ReadCompletedEventArgs1> ReadCompleted;

		public event EventHandler<TryReadCompletedEventArgs1> TryReadCompleted;

		public event EventHandler<BulkReadCompletedEventArgs1> BulkReadCompleted;

		public event EventHandler<ReadSchemaFieldsCompletedEventArgs1> ReadSchemaFieldsCompleted;

		public event EventHandler<ConvertSchemaFieldsToXsdCompletedEventArgs1> ConvertSchemaFieldsToXsdCompleted;

		public event EventHandler<SaveCompletedEventArgs1> SaveCompleted;

		public event EventHandler<AsyncCompletedEventArgs> DeleteCompleted;

		public event EventHandler<AsyncCompletedEventArgs> DeleteTaxonomyNodeCompleted;

		public event EventHandler<GetDefaultDataCompletedEventArgs1> GetDefaultDataCompleted;

		public event EventHandler<MoveCompletedEventArgs1> MoveCompleted;

		public event EventHandler<CopyCompletedEventArgs1> CopyCompleted;

		public event EventHandler<GetInstanceDataCompletedEventArgs1> GetInstanceDataCompleted;

		public event EventHandler<TryCheckOutCompletedEventArgs1> TryCheckOutCompleted;

		public event EventHandler<CheckOutCompletedEventArgs1> CheckOutCompleted;

		public event EventHandler<CheckInCompletedEventArgs1> CheckInCompleted;

		public event EventHandler<UpdateCompletedEventArgs1> UpdateCompleted;

		public event EventHandler<CreateCompletedEventArgs1> CreateCompleted;

		public event EventHandler<UndoCheckOutCompletedEventArgs1> UndoCheckOutCompleted;

		public event EventHandler<RollbackCompletedEventArgs1> RollbackCompleted;

		public event EventHandler<LocalizeCompletedEventArgs1> LocalizeCompleted;

		public event EventHandler<UnLocalizeCompletedEventArgs1> UnLocalizeCompleted;

		public event EventHandler<PromoteCompletedEventArgs1> PromoteCompleted;

		public event EventHandler<DemoteCompletedEventArgs1> DemoteCompleted;

		public event EventHandler<GetListTemplateTypesCompletedEventArgs1> GetListTemplateTypesCompleted;

		public event EventHandler<GetListPublicationTypesCompletedEventArgs1> GetListPublicationTypesCompleted;

		public event EventHandler<GetSystemWideListXmlCompletedEventArgs1> GetSystemWideListXmlCompleted;

		public event EventHandler<GetSystemWideListCompletedEventArgs1> GetSystemWideListCompleted;

		public event EventHandler<GetListXmlCompletedEventArgs1> GetListXmlCompleted;

		public event EventHandler<GetListCompletedEventArgs1> GetListCompleted;

		public event EventHandler<GetListDirectoryServiceNamesCompletedEventArgs1> GetListDirectoryServiceNamesCompleted;

		public event EventHandler<GetListWindowsDomainUsersCompletedEventArgs1> GetListWindowsDomainUsersCompleted;

		public event EventHandler<GetListDirectoryServiceAllUsersCompletedEventArgs1> GetListDirectoryServiceAllUsersCompleted;

		public event EventHandler<GetListDirectoryServiceGroupMembersCompletedEventArgs1> GetListDirectoryServiceGroupMembersCompleted;

		public event EventHandler<GetListDirectoryServiceUsersCompletedEventArgs1> GetListDirectoryServiceUsersCompleted;

		public event EventHandler<ClassifyCompletedEventArgs1> ClassifyCompleted;

		public event EventHandler<UnClassifyCompletedEventArgs1> UnClassifyCompleted;

		public event EventHandler<ReClassifyCompletedEventArgs1> ReClassifyCompleted;

		public event EventHandler<StartActivityCompletedEventArgs1> StartActivityCompleted;

		public event EventHandler<SuspendActivityCompletedEventArgs1> SuspendActivityCompleted;

		public event EventHandler<RestartActivityCompletedEventArgs1> RestartActivityCompleted;

		public event EventHandler<ReAssignActivityCompletedEventArgs1> ReAssignActivityCompleted;

		public event EventHandler<FinishActivityCompletedEventArgs1> FinishActivityCompleted;

		public event EventHandler<ForceFinishProcessCompletedEventArgs1> ForceFinishProcessCompleted;

		public event EventHandler<ResumeActivityCompletedEventArgs1> ResumeActivityCompleted;

		public event EventHandler<GetListQueueMessagesCompletedEventArgs1> GetListQueueMessagesCompleted;

		public event EventHandler<AsyncCompletedEventArgs> PurgeQueueCompleted;

		public event EventHandler<GetListQueuesCompletedEventArgs1> GetListQueuesCompleted;

		public event EventHandler<ReadApplicationDataCompletedEventArgs1> ReadApplicationDataCompleted;

		public event EventHandler<ReadAllApplicationDataCompletedEventArgs1> ReadAllApplicationDataCompleted;

		public event EventHandler<AsyncCompletedEventArgs> SaveApplicationDataCompleted;

		public event EventHandler<AsyncCompletedEventArgs> DeleteApplicationDataCompleted;

		public event EventHandler<GetApplicationIdsCompletedEventArgs1> GetApplicationIdsCompleted;

		public event EventHandler<AsyncCompletedEventArgs> PurgeApplicationDataCompleted;

		public event EventHandler<ParsePredefinedBatchOperationCompletedEventArgs1> ParsePredefinedBatchOperationCompleted;

		public event EventHandler<GetPredefinedBatchOperationNameCompletedEventArgs1> GetPredefinedBatchOperationNameCompleted;

		public event EventHandler<ResolveItemsCompletedEventArgs1> ResolveItemsCompleted;

		public event EventHandler<GetSearchResultsXmlCompletedEventArgs1> GetSearchResultsXmlCompleted;

		public event EventHandler<GetSearchResultsXmlPagedCompletedEventArgs1> GetSearchResultsXmlPagedCompleted;

		public event EventHandler<GetSearchResultsCompletedEventArgs1> GetSearchResultsCompleted;

		public event EventHandler<GetSearchResultsPagedCompletedEventArgs1> GetSearchResultsPagedCompleted;

		public event EventHandler<RenderItemCompletedEventArgs1> RenderItemCompleted;

		public event EventHandler<PreviewItemCompletedEventArgs1> PreviewItemCompleted;

		public event EventHandler<PublishCompletedEventArgs1> PublishCompleted;

		public event EventHandler<UnPublishCompletedEventArgs1> UnPublishCompleted;

		public event EventHandler<IsPublishedCompletedEventArgs1> IsPublishedCompleted;

		public event EventHandler<GetWorkItemSnapshotCompletedEventArgs1> GetWorkItemSnapshotCompleted;

		public event EventHandler<GetListPublishInfoCompletedEventArgs1> GetListPublishInfoCompleted;

		public event EventHandler<CastActionsCompletedEventArgs1> CastActionsCompleted;

		public event EventHandler<AsyncCompletedEventArgs> ValidateXmlCompleted;

		public event EventHandler<IsValidTridionWebSchemaXmlCompletedEventArgs1> IsValidTridionWebSchemaXmlCompleted;

		public event EventHandler<GetSubjectIdsWithApplicationDataCompletedEventArgs1> GetSubjectIdsWithApplicationDataCompleted;

		public event EventHandler<ReadApplicationDataForSubjectsIdsCompletedEventArgs1> ReadApplicationDataForSubjectsIdsCompleted;

		public event EventHandler<GetSecurityDescriptorsForSubjectsIdsCompletedEventArgs1> GetSecurityDescriptorsForSubjectsIdsCompleted;

		public event EventHandler<GetContentSecurityDescriptorsForOrgItemIdsCompletedEventArgs1> GetContentSecurityDescriptorsForOrgItemIdsCompleted;

		public event EventHandler<AsyncCompletedEventArgs> ReIndexCompleted;

		public event EventHandler<CastPredefinedQueueCompletedEventArgs1> CastPredefinedQueueCompleted;

		public event EventHandler<PurgeOldVersionsCompletedEventArgs1> PurgeOldVersionsCompleted;

		public event EventHandler<GetListExternalLinksCompletedEventArgs1> GetListExternalLinksCompleted;

		public event EventHandler<ConvertXmlToSearchQueryCompletedEventArgs1> ConvertXmlToSearchQueryCompleted;

		public event EventHandler<ConvertSearchQueryToXmlCompletedEventArgs1> ConvertSearchQueryToXmlCompleted;

		public CoreServiceClient()
		{
		}

		public CoreServiceClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public CoreServiceClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public CoreServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public CoreServiceClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetVirtualFolderTypeSchemaCompleted(this, new GetVirtualFolderTypeSchemaCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetVirtualFolderTypeSchemaDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetVirtualFolderTypeSchema);
			}
			if (this.onEndGetVirtualFolderTypeSchemaDelegate == null)
			{
				this.onEndGetVirtualFolderTypeSchemaDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetVirtualFolderTypeSchema);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetEnumValuesCompleted(this, new GetEnumValuesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetEnumValuesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetEnumValues);
			}
			if (this.onEndGetEnumValuesDelegate == null)
			{
				this.onEndGetEnumValuesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetEnumValues);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResolveBundleTypesCompleted(this, new ResolveBundleTypesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginResolveBundleTypesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginResolveBundleTypes);
			}
			if (this.onEndResolveBundleTypesDelegate == null)
			{
				this.onEndResolveBundleTypesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndResolveBundleTypes);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CopyToKeywordCompleted(this, new CopyToKeywordCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginCopyToKeywordDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginCopyToKeyword);
			}
			if (this.onEndCopyToKeywordDelegate == null)
			{
				this.onEndCopyToKeywordDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndCopyToKeyword);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.MoveToKeywordCompleted(this, new MoveToKeywordCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginMoveToKeywordDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginMoveToKeyword);
			}
			if (this.onEndMoveToKeywordDelegate == null)
			{
				this.onEndMoveToKeywordDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndMoveToKeyword);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetTridionLanguagesCompleted(this, new GetTridionLanguagesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetTridionLanguagesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetTridionLanguages);
			}
			if (this.onEndGetTridionLanguagesDelegate == null)
			{
				this.onEndGetTridionLanguagesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetTridionLanguages);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListWorkflowScriptTypesCompleted(this, new GetListWorkflowScriptTypesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListWorkflowScriptTypesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListWorkflowScriptTypes);
			}
			if (this.onEndGetListWorkflowScriptTypesDelegate == null)
			{
				this.onEndGetListWorkflowScriptTypesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListWorkflowScriptTypes);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.AddToWorkflowCompleted(this, new AddToWorkflowCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginAddToWorkflowDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginAddToWorkflow);
			}
			if (this.onEndAddToWorkflowDelegate == null)
			{
				this.onEndAddToWorkflowDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndAddToWorkflow);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RemoveFromWorkflowCompleted(this, new RemoveFromWorkflowCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginRemoveFromWorkflowDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginRemoveFromWorkflow);
			}
			if (this.onEndRemoveFromWorkflowDelegate == null)
			{
				this.onEndRemoveFromWorkflowDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndRemoveFromWorkflow);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.LockCompleted(this, new LockCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginLockDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginLock);
			}
			if (this.onEndLockDelegate == null)
			{
				this.onEndLockDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndLock);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnlockCompleted(this, new UnlockCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginUnlockDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginUnlock);
			}
			if (this.onEndUnlockDelegate == null)
			{
				this.onEndUnlockDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndUnlock);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.StartWorkflowCompleted(this, new StartWorkflowCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginStartWorkflowDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginStartWorkflow);
			}
			if (this.onEndStartWorkflowDelegate == null)
			{
				this.onEndStartWorkflowDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndStartWorkflow);
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

		public PublishTransactionData UndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions)
		{
			return base.Channel.UndoPublishTransaction(publishTransactionId, priority, readBackOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUndoPublishTransaction(publishTransactionId, priority, readBackOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PublishTransactionData EndUndoPublishTransaction(IAsyncResult result)
		{
			return base.Channel.EndUndoPublishTransaction(result);
		}

		private IAsyncResult OnBeginUndoPublishTransaction(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string publishTransactionId = (string)inValues[0];
			QueueMessagePriority? priority = (QueueMessagePriority?)inValues[1];
			ReadOptions readBackOptions = (ReadOptions)inValues[2];
			return this.BeginUndoPublishTransaction(publishTransactionId, priority, readBackOptions, callback, asyncState);
		}

		private object[] OnEndUndoPublishTransaction(IAsyncResult result)
		{
			PublishTransactionData publishTransactionData = this.EndUndoPublishTransaction(result);
			return new object[]
			{
				publishTransactionData
			};
		}

		private void OnUndoPublishTransactionCompleted(object state)
		{
			if (this.UndoPublishTransactionCompleted != null)
			{
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UndoPublishTransactionCompleted(this, new UndoPublishTransactionCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UndoPublishTransactionAsync(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions)
		{
			this.UndoPublishTransactionAsync(publishTransactionId, priority, readBackOptions, null);
		}

		public void UndoPublishTransactionAsync(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions, object userState)
		{
			if (this.onBeginUndoPublishTransactionDelegate == null)
			{
				this.onBeginUndoPublishTransactionDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginUndoPublishTransaction);
			}
			if (this.onEndUndoPublishTransactionDelegate == null)
			{
				this.onEndUndoPublishTransactionDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndUndoPublishTransaction);
			}
			if (this.onUndoPublishTransactionCompletedDelegate == null)
			{
				this.onUndoPublishTransactionCompletedDelegate = new SendOrPostCallback(this.OnUndoPublishTransactionCompleted);
			}
			base.InvokeAsync(this.onBeginUndoPublishTransactionDelegate, new object[]
			{
				publishTransactionId,
				priority,
				readBackOptions
			}, this.onEndUndoPublishTransactionDelegate, this.onUndoPublishTransactionCompletedDelegate, userState);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetProcessDefinitionsForItemsCompleted(this, new GetProcessDefinitionsForItemsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetProcessDefinitionsForItemsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetProcessDefinitionsForItems);
			}
			if (this.onEndGetProcessDefinitionsForItemsDelegate == null)
			{
				this.onEndGetProcessDefinitionsForItemsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetProcessDefinitionsForItems);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSystemXsdCompleted(this, new GetSystemXsdCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSystemXsdDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSystemXsd);
			}
			if (this.onEndGetSystemXsdDelegate == null)
			{
				this.onEndGetSystemXsdDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSystemXsd);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSchemasByNamespaceUriCompleted(this, new GetSchemasByNamespaceUriCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSchemasByNamespaceUriDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSchemasByNamespaceUri);
			}
			if (this.onEndGetSchemasByNamespaceUriDelegate == null)
			{
				this.onEndGetSchemasByNamespaceUriDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSchemasByNamespaceUri);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ValidateCompleted(this, new ValidateCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginValidateDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginValidate);
			}
			if (this.onEndValidateDelegate == null)
			{
				this.onEndValidateDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndValidate);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetExternalBinaryContentDataCompleted(this, new GetExternalBinaryContentDataCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetExternalBinaryContentDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetExternalBinaryContentData);
			}
			if (this.onEndGetExternalBinaryContentDataDelegate == null)
			{
				this.onEndGetExternalBinaryContentDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetExternalBinaryContentData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SynchronizeWithSchemaCompleted(this, new SynchronizeWithSchemaCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginSynchronizeWithSchemaDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginSynchronizeWithSchema);
			}
			if (this.onEndSynchronizeWithSchemaDelegate == null)
			{
				this.onEndSynchronizeWithSchemaDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndSynchronizeWithSchema);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SynchronizeWithSchemaAndUpdateCompleted(this, new SynchronizeWithSchemaAndUpdateCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginSynchronizeWithSchemaAndUpdateDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginSynchronizeWithSchemaAndUpdate);
			}
			if (this.onEndSynchronizeWithSchemaAndUpdateDelegate == null)
			{
				this.onEndSynchronizeWithSchemaAndUpdateDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndSynchronizeWithSchemaAndUpdate);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginDecommissionPublicationTargetDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginDecommissionPublicationTarget);
			}
			if (this.onEndDecommissionPublicationTargetDelegate == null)
			{
				this.onEndDecommissionPublicationTargetDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndDecommissionPublicationTarget);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertXsdToSchemaFieldsCompleted(this, new ConvertXsdToSchemaFieldsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginConvertXsdToSchemaFieldsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginConvertXsdToSchemaFields);
			}
			if (this.onEndConvertXsdToSchemaFieldsDelegate == null)
			{
				this.onEndConvertXsdToSchemaFieldsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndConvertXsdToSchemaFields);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetPublishUrlCompleted(this, new GetPublishUrlCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetPublishUrlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetPublishUrl);
			}
			if (this.onEndGetPublishUrlDelegate == null)
			{
				this.onEndGetPublishUrlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetPublishUrl);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetBusinessProcessTypesCompleted(this, new GetBusinessProcessTypesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetBusinessProcessTypesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetBusinessProcessTypes);
			}
			if (this.onEndGetBusinessProcessTypesDelegate == null)
			{
				this.onEndGetBusinessProcessTypesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetBusinessProcessTypes);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetPublishSourceByUrlCompleted(this, new GetPublishSourceByUrlCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetPublishSourceByUrlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetPublishSourceByUrl);
			}
			if (this.onEndGetPublishSourceByUrlDelegate == null)
			{
				this.onEndGetPublishSourceByUrlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetPublishSourceByUrl);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginRemovePublishStatesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginRemovePublishStates);
			}
			if (this.onEndRemovePublishStatesDelegate == null)
			{
				this.onEndRemovePublishStatesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndRemovePublishStates);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResolveContainingPagesCompleted(this, new ResolveContainingPagesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginResolveContainingPagesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginResolveContainingPages);
			}
			if (this.onEndResolveContainingPagesDelegate == null)
			{
				this.onEndResolveContainingPagesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndResolveContainingPages);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginPurgeWorkflowHistoryDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginPurgeWorkflowHistory);
			}
			if (this.onEndPurgeWorkflowHistoryDelegate == null)
			{
				this.onEndPurgeWorkflowHistoryDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndPurgeWorkflowHistory);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetApiVersionCompleted(this, new GetApiVersionCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetApiVersionDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetApiVersion);
			}
			if (this.onEndGetApiVersionDelegate == null)
			{
				this.onEndGetApiVersionDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetApiVersion);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetCurrentUserCompleted(this, new GetCurrentUserCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetCurrentUserDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetCurrentUser);
			}
			if (this.onEndGetCurrentUserDelegate == null)
			{
				this.onEndGetCurrentUserDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetCurrentUser);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.IsExistingObjectCompleted(this, new IsExistingObjectCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginIsExistingObjectDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginIsExistingObject);
			}
			if (this.onEndIsExistingObjectDelegate == null)
			{
				this.onEndIsExistingObjectDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndIsExistingObject);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetTcmUriCompleted(this, new GetTcmUriCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetTcmUriDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetTcmUri);
			}
			if (this.onEndGetTcmUriDelegate == null)
			{
				this.onEndGetTcmUriDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetTcmUri);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.TryGetTcmUriCompleted(this, new TryGetTcmUriCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginTryGetTcmUriDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginTryGetTcmUri);
			}
			if (this.onEndTryGetTcmUriDelegate == null)
			{
				this.onEndTryGetTcmUriDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndTryGetTcmUri);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadCompleted(this, new ReadCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginReadDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginRead);
			}
			if (this.onEndReadDelegate == null)
			{
				this.onEndReadDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndRead);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.TryReadCompleted(this, new TryReadCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginTryReadDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginTryRead);
			}
			if (this.onEndTryReadDelegate == null)
			{
				this.onEndTryReadDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndTryRead);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.BulkReadCompleted(this, new BulkReadCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginBulkReadDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginBulkRead);
			}
			if (this.onEndBulkReadDelegate == null)
			{
				this.onEndBulkReadDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndBulkRead);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadSchemaFieldsCompleted(this, new ReadSchemaFieldsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginReadSchemaFieldsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginReadSchemaFields);
			}
			if (this.onEndReadSchemaFieldsDelegate == null)
			{
				this.onEndReadSchemaFieldsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndReadSchemaFields);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertSchemaFieldsToXsdCompleted(this, new ConvertSchemaFieldsToXsdCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginConvertSchemaFieldsToXsdDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginConvertSchemaFieldsToXsd);
			}
			if (this.onEndConvertSchemaFieldsToXsdDelegate == null)
			{
				this.onEndConvertSchemaFieldsToXsdDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndConvertSchemaFieldsToXsd);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SaveCompleted(this, new SaveCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginSaveDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginSave);
			}
			if (this.onEndSaveDelegate == null)
			{
				this.onEndSaveDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndSave);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginDeleteDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginDelete);
			}
			if (this.onEndDeleteDelegate == null)
			{
				this.onEndDeleteDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndDelete);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginDeleteTaxonomyNodeDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginDeleteTaxonomyNode);
			}
			if (this.onEndDeleteTaxonomyNodeDelegate == null)
			{
				this.onEndDeleteTaxonomyNodeDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndDeleteTaxonomyNode);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetDefaultDataCompleted(this, new GetDefaultDataCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetDefaultDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetDefaultData);
			}
			if (this.onEndGetDefaultDataDelegate == null)
			{
				this.onEndGetDefaultDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetDefaultData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.MoveCompleted(this, new MoveCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginMoveDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginMove);
			}
			if (this.onEndMoveDelegate == null)
			{
				this.onEndMoveDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndMove);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CopyCompleted(this, new CopyCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginCopyDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginCopy);
			}
			if (this.onEndCopyDelegate == null)
			{
				this.onEndCopyDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndCopy);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetInstanceDataCompleted(this, new GetInstanceDataCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetInstanceDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetInstanceData);
			}
			if (this.onEndGetInstanceDataDelegate == null)
			{
				this.onEndGetInstanceDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetInstanceData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.TryCheckOutCompleted(this, new TryCheckOutCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginTryCheckOutDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginTryCheckOut);
			}
			if (this.onEndTryCheckOutDelegate == null)
			{
				this.onEndTryCheckOutDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndTryCheckOut);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CheckOutCompleted(this, new CheckOutCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginCheckOutDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginCheckOut);
			}
			if (this.onEndCheckOutDelegate == null)
			{
				this.onEndCheckOutDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndCheckOut);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CheckInCompleted(this, new CheckInCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginCheckInDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginCheckIn);
			}
			if (this.onEndCheckInDelegate == null)
			{
				this.onEndCheckInDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndCheckIn);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UpdateCompleted(this, new UpdateCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginUpdateDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginUpdate);
			}
			if (this.onEndUpdateDelegate == null)
			{
				this.onEndUpdateDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndUpdate);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CreateCompleted(this, new CreateCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginCreateDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginCreate);
			}
			if (this.onEndCreateDelegate == null)
			{
				this.onEndCreateDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndCreate);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UndoCheckOutCompleted(this, new UndoCheckOutCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginUndoCheckOutDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginUndoCheckOut);
			}
			if (this.onEndUndoCheckOutDelegate == null)
			{
				this.onEndUndoCheckOutDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndUndoCheckOut);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RollbackCompleted(this, new RollbackCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginRollbackDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginRollback);
			}
			if (this.onEndRollbackDelegate == null)
			{
				this.onEndRollbackDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndRollback);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.LocalizeCompleted(this, new LocalizeCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginLocalizeDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginLocalize);
			}
			if (this.onEndLocalizeDelegate == null)
			{
				this.onEndLocalizeDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndLocalize);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnLocalizeCompleted(this, new UnLocalizeCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginUnLocalizeDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginUnLocalize);
			}
			if (this.onEndUnLocalizeDelegate == null)
			{
				this.onEndUnLocalizeDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndUnLocalize);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PromoteCompleted(this, new PromoteCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginPromoteDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginPromote);
			}
			if (this.onEndPromoteDelegate == null)
			{
				this.onEndPromoteDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndPromote);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.DemoteCompleted(this, new DemoteCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginDemoteDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginDemote);
			}
			if (this.onEndDemoteDelegate == null)
			{
				this.onEndDemoteDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndDemote);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListTemplateTypesCompleted(this, new GetListTemplateTypesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListTemplateTypesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListTemplateTypes);
			}
			if (this.onEndGetListTemplateTypesDelegate == null)
			{
				this.onEndGetListTemplateTypesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListTemplateTypes);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListPublicationTypesCompleted(this, new GetListPublicationTypesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListPublicationTypesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListPublicationTypes);
			}
			if (this.onEndGetListPublicationTypesDelegate == null)
			{
				this.onEndGetListPublicationTypesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListPublicationTypes);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSystemWideListXmlCompleted(this, new GetSystemWideListXmlCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSystemWideListXmlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSystemWideListXml);
			}
			if (this.onEndGetSystemWideListXmlDelegate == null)
			{
				this.onEndGetSystemWideListXmlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSystemWideListXml);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSystemWideListCompleted(this, new GetSystemWideListCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSystemWideListDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSystemWideList);
			}
			if (this.onEndGetSystemWideListDelegate == null)
			{
				this.onEndGetSystemWideListDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSystemWideList);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListXmlCompleted(this, new GetListXmlCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListXmlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListXml);
			}
			if (this.onEndGetListXmlDelegate == null)
			{
				this.onEndGetListXmlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListXml);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListCompleted(this, new GetListCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetList);
			}
			if (this.onEndGetListDelegate == null)
			{
				this.onEndGetListDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetList);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceNamesCompleted(this, new GetListDirectoryServiceNamesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListDirectoryServiceNamesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceNames);
			}
			if (this.onEndGetListDirectoryServiceNamesDelegate == null)
			{
				this.onEndGetListDirectoryServiceNamesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceNames);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListWindowsDomainUsersCompleted(this, new GetListWindowsDomainUsersCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListWindowsDomainUsersDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListWindowsDomainUsers);
			}
			if (this.onEndGetListWindowsDomainUsersDelegate == null)
			{
				this.onEndGetListWindowsDomainUsersDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListWindowsDomainUsers);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceAllUsersCompleted(this, new GetListDirectoryServiceAllUsersCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListDirectoryServiceAllUsersDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceAllUsers);
			}
			if (this.onEndGetListDirectoryServiceAllUsersDelegate == null)
			{
				this.onEndGetListDirectoryServiceAllUsersDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceAllUsers);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceGroupMembersCompleted(this, new GetListDirectoryServiceGroupMembersCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListDirectoryServiceGroupMembersDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceGroupMembers);
			}
			if (this.onEndGetListDirectoryServiceGroupMembersDelegate == null)
			{
				this.onEndGetListDirectoryServiceGroupMembersDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceGroupMembers);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListDirectoryServiceUsersCompleted(this, new GetListDirectoryServiceUsersCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListDirectoryServiceUsersDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListDirectoryServiceUsers);
			}
			if (this.onEndGetListDirectoryServiceUsersDelegate == null)
			{
				this.onEndGetListDirectoryServiceUsersDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListDirectoryServiceUsers);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ClassifyCompleted(this, new ClassifyCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginClassifyDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginClassify);
			}
			if (this.onEndClassifyDelegate == null)
			{
				this.onEndClassifyDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndClassify);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnClassifyCompleted(this, new UnClassifyCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginUnClassifyDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginUnClassify);
			}
			if (this.onEndUnClassifyDelegate == null)
			{
				this.onEndUnClassifyDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndUnClassify);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReClassifyCompleted(this, new ReClassifyCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginReClassifyDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginReClassify);
			}
			if (this.onEndReClassifyDelegate == null)
			{
				this.onEndReClassifyDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndReClassify);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.StartActivityCompleted(this, new StartActivityCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginStartActivityDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginStartActivity);
			}
			if (this.onEndStartActivityDelegate == null)
			{
				this.onEndStartActivityDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndStartActivity);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.SuspendActivityCompleted(this, new SuspendActivityCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginSuspendActivityDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginSuspendActivity);
			}
			if (this.onEndSuspendActivityDelegate == null)
			{
				this.onEndSuspendActivityDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndSuspendActivity);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RestartActivityCompleted(this, new RestartActivityCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginRestartActivityDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginRestartActivity);
			}
			if (this.onEndRestartActivityDelegate == null)
			{
				this.onEndRestartActivityDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndRestartActivity);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReAssignActivityCompleted(this, new ReAssignActivityCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginReAssignActivityDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginReAssignActivity);
			}
			if (this.onEndReAssignActivityDelegate == null)
			{
				this.onEndReAssignActivityDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndReAssignActivity);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.FinishActivityCompleted(this, new FinishActivityCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginFinishActivityDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginFinishActivity);
			}
			if (this.onEndFinishActivityDelegate == null)
			{
				this.onEndFinishActivityDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndFinishActivity);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ForceFinishProcessCompleted(this, new ForceFinishProcessCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginForceFinishProcessDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginForceFinishProcess);
			}
			if (this.onEndForceFinishProcessDelegate == null)
			{
				this.onEndForceFinishProcessDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndForceFinishProcess);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResumeActivityCompleted(this, new ResumeActivityCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginResumeActivityDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginResumeActivity);
			}
			if (this.onEndResumeActivityDelegate == null)
			{
				this.onEndResumeActivityDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndResumeActivity);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListQueueMessagesCompleted(this, new GetListQueueMessagesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListQueueMessagesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListQueueMessages);
			}
			if (this.onEndGetListQueueMessagesDelegate == null)
			{
				this.onEndGetListQueueMessagesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListQueueMessages);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginPurgeQueueDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginPurgeQueue);
			}
			if (this.onEndPurgeQueueDelegate == null)
			{
				this.onEndPurgeQueueDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndPurgeQueue);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListQueuesCompleted(this, new GetListQueuesCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListQueuesDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListQueues);
			}
			if (this.onEndGetListQueuesDelegate == null)
			{
				this.onEndGetListQueuesDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListQueues);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadApplicationDataCompleted(this, new ReadApplicationDataCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginReadApplicationDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginReadApplicationData);
			}
			if (this.onEndReadApplicationDataDelegate == null)
			{
				this.onEndReadApplicationDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndReadApplicationData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadAllApplicationDataCompleted(this, new ReadAllApplicationDataCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginReadAllApplicationDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginReadAllApplicationData);
			}
			if (this.onEndReadAllApplicationDataDelegate == null)
			{
				this.onEndReadAllApplicationDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndReadAllApplicationData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginSaveApplicationDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginSaveApplicationData);
			}
			if (this.onEndSaveApplicationDataDelegate == null)
			{
				this.onEndSaveApplicationDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndSaveApplicationData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginDeleteApplicationDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginDeleteApplicationData);
			}
			if (this.onEndDeleteApplicationDataDelegate == null)
			{
				this.onEndDeleteApplicationDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndDeleteApplicationData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetApplicationIdsCompleted(this, new GetApplicationIdsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetApplicationIdsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetApplicationIds);
			}
			if (this.onEndGetApplicationIdsDelegate == null)
			{
				this.onEndGetApplicationIdsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetApplicationIds);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginPurgeApplicationDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginPurgeApplicationData);
			}
			if (this.onEndPurgeApplicationDataDelegate == null)
			{
				this.onEndPurgeApplicationDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndPurgeApplicationData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ParsePredefinedBatchOperationCompleted(this, new ParsePredefinedBatchOperationCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginParsePredefinedBatchOperationDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginParsePredefinedBatchOperation);
			}
			if (this.onEndParsePredefinedBatchOperationDelegate == null)
			{
				this.onEndParsePredefinedBatchOperationDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndParsePredefinedBatchOperation);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetPredefinedBatchOperationNameCompleted(this, new GetPredefinedBatchOperationNameCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetPredefinedBatchOperationNameDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetPredefinedBatchOperationName);
			}
			if (this.onEndGetPredefinedBatchOperationNameDelegate == null)
			{
				this.onEndGetPredefinedBatchOperationNameDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetPredefinedBatchOperationName);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ResolveItemsCompleted(this, new ResolveItemsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginResolveItemsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginResolveItems);
			}
			if (this.onEndResolveItemsDelegate == null)
			{
				this.onEndResolveItemsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndResolveItems);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsXmlCompleted(this, new GetSearchResultsXmlCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSearchResultsXmlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSearchResultsXml);
			}
			if (this.onEndGetSearchResultsXmlDelegate == null)
			{
				this.onEndGetSearchResultsXmlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSearchResultsXml);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsXmlPagedCompleted(this, new GetSearchResultsXmlPagedCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSearchResultsXmlPagedDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSearchResultsXmlPaged);
			}
			if (this.onEndGetSearchResultsXmlPagedDelegate == null)
			{
				this.onEndGetSearchResultsXmlPagedDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSearchResultsXmlPaged);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsCompleted(this, new GetSearchResultsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSearchResultsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSearchResults);
			}
			if (this.onEndGetSearchResultsDelegate == null)
			{
				this.onEndGetSearchResultsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSearchResults);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSearchResultsPagedCompleted(this, new GetSearchResultsPagedCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSearchResultsPagedDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSearchResultsPaged);
			}
			if (this.onEndGetSearchResultsPagedDelegate == null)
			{
				this.onEndGetSearchResultsPagedDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSearchResultsPaged);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.RenderItemCompleted(this, new RenderItemCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginRenderItemDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginRenderItem);
			}
			if (this.onEndRenderItemDelegate == null)
			{
				this.onEndRenderItemDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndRenderItem);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PreviewItemCompleted(this, new PreviewItemCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginPreviewItemDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginPreviewItem);
			}
			if (this.onEndPreviewItemDelegate == null)
			{
				this.onEndPreviewItemDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndPreviewItem);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PublishCompleted(this, new PublishCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginPublishDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginPublish);
			}
			if (this.onEndPublishDelegate == null)
			{
				this.onEndPublishDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndPublish);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.UnPublishCompleted(this, new UnPublishCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginUnPublishDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginUnPublish);
			}
			if (this.onEndUnPublishDelegate == null)
			{
				this.onEndUnPublishDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndUnPublish);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.IsPublishedCompleted(this, new IsPublishedCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginIsPublishedDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginIsPublished);
			}
			if (this.onEndIsPublishedDelegate == null)
			{
				this.onEndIsPublishedDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndIsPublished);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetWorkItemSnapshotCompleted(this, new GetWorkItemSnapshotCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetWorkItemSnapshotDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetWorkItemSnapshot);
			}
			if (this.onEndGetWorkItemSnapshotDelegate == null)
			{
				this.onEndGetWorkItemSnapshotDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetWorkItemSnapshot);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListPublishInfoCompleted(this, new GetListPublishInfoCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListPublishInfoDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListPublishInfo);
			}
			if (this.onEndGetListPublishInfoDelegate == null)
			{
				this.onEndGetListPublishInfoDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListPublishInfo);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CastActionsCompleted(this, new CastActionsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginCastActionsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginCastActions);
			}
			if (this.onEndCastActionsDelegate == null)
			{
				this.onEndCastActionsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndCastActions);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginValidateXmlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginValidateXml);
			}
			if (this.onEndValidateXmlDelegate == null)
			{
				this.onEndValidateXmlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndValidateXml);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.IsValidTridionWebSchemaXmlCompleted(this, new IsValidTridionWebSchemaXmlCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginIsValidTridionWebSchemaXmlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginIsValidTridionWebSchemaXml);
			}
			if (this.onEndIsValidTridionWebSchemaXmlDelegate == null)
			{
				this.onEndIsValidTridionWebSchemaXmlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndIsValidTridionWebSchemaXml);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSubjectIdsWithApplicationDataCompleted(this, new GetSubjectIdsWithApplicationDataCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSubjectIdsWithApplicationDataDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSubjectIdsWithApplicationData);
			}
			if (this.onEndGetSubjectIdsWithApplicationDataDelegate == null)
			{
				this.onEndGetSubjectIdsWithApplicationDataDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSubjectIdsWithApplicationData);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ReadApplicationDataForSubjectsIdsCompleted(this, new ReadApplicationDataForSubjectsIdsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginReadApplicationDataForSubjectsIdsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginReadApplicationDataForSubjectsIds);
			}
			if (this.onEndReadApplicationDataForSubjectsIdsDelegate == null)
			{
				this.onEndReadApplicationDataForSubjectsIdsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndReadApplicationDataForSubjectsIds);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetSecurityDescriptorsForSubjectsIdsCompleted(this, new GetSecurityDescriptorsForSubjectsIdsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetSecurityDescriptorsForSubjectsIdsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetSecurityDescriptorsForSubjectsIds);
			}
			if (this.onEndGetSecurityDescriptorsForSubjectsIdsDelegate == null)
			{
				this.onEndGetSecurityDescriptorsForSubjectsIdsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetSecurityDescriptorsForSubjectsIds);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetContentSecurityDescriptorsForOrgItemIdsCompleted(this, new GetContentSecurityDescriptorsForOrgItemIdsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetContentSecurityDescriptorsForOrgItemIdsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetContentSecurityDescriptorsForOrgItemIds);
			}
			if (this.onEndGetContentSecurityDescriptorsForOrgItemIdsDelegate == null)
			{
				this.onEndGetContentSecurityDescriptorsForOrgItemIdsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetContentSecurityDescriptorsForOrgItemIds);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
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
				this.onBeginReIndexDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginReIndex);
			}
			if (this.onEndReIndexDelegate == null)
			{
				this.onEndReIndexDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndReIndex);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.CastPredefinedQueueCompleted(this, new CastPredefinedQueueCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginCastPredefinedQueueDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginCastPredefinedQueue);
			}
			if (this.onEndCastPredefinedQueueDelegate == null)
			{
				this.onEndCastPredefinedQueueDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndCastPredefinedQueue);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.PurgeOldVersionsCompleted(this, new PurgeOldVersionsCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginPurgeOldVersionsDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginPurgeOldVersions);
			}
			if (this.onEndPurgeOldVersionsDelegate == null)
			{
				this.onEndPurgeOldVersionsDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndPurgeOldVersions);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.GetListExternalLinksCompleted(this, new GetListExternalLinksCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginGetListExternalLinksDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginGetListExternalLinks);
			}
			if (this.onEndGetListExternalLinksDelegate == null)
			{
				this.onEndGetListExternalLinksDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndGetListExternalLinks);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertXmlToSearchQueryCompleted(this, new ConvertXmlToSearchQueryCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginConvertXmlToSearchQueryDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginConvertXmlToSearchQuery);
			}
			if (this.onEndConvertXmlToSearchQueryDelegate == null)
			{
				this.onEndConvertXmlToSearchQueryDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndConvertXmlToSearchQuery);
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
				ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreService>.InvokeAsyncCompletedEventArgs)state;
				this.ConvertSearchQueryToXmlCompleted(this, new ConvertSearchQueryToXmlCompletedEventArgs1(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
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
				this.onBeginConvertSearchQueryToXmlDelegate = new ClientBase<ICoreService>.BeginOperationDelegate(this.OnBeginConvertSearchQueryToXml);
			}
			if (this.onEndConvertSearchQueryToXmlDelegate == null)
			{
				this.onEndConvertSearchQueryToXmlDelegate = new ClientBase<ICoreService>.EndOperationDelegate(this.OnEndConvertSearchQueryToXml);
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
