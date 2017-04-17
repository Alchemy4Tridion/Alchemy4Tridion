using System;
using System.Xml.Linq;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public interface ISessionAwareCoreServiceBase
	{
		SchemaData GetVirtualFolderTypeSchema(string namespaceUri);

		IAsyncResult BeginGetVirtualFolderTypeSchema(string namespaceUri, AsyncCallback callback, object asyncState);

		SchemaData EndGetVirtualFolderTypeSchema(IAsyncResult result);

		TridionEnumValue[] GetEnumValues(string type);

		IAsyncResult BeginGetEnumValues(string type, AsyncCallback callback, object asyncState);

		TridionEnumValue[] EndGetEnumValues(IAsyncResult result);

		BundleTypeData[] ResolveBundleTypes(string[] itemIds, bool pruneTree);

		IAsyncResult BeginResolveBundleTypes(string[] itemIds, bool pruneTree, AsyncCallback callback, object asyncState);

		BundleTypeData[] EndResolveBundleTypes(IAsyncResult result);

		KeywordData CopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions);

		IAsyncResult BeginCopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		KeywordData EndCopyToKeyword(IAsyncResult result);

		KeywordData MoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions);

		IAsyncResult BeginMoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		KeywordData EndMoveToKeyword(IAsyncResult result);

		TridionLanguageInfo[] GetTridionLanguages();

		IAsyncResult BeginGetTridionLanguages(AsyncCallback callback, object asyncState);

		TridionLanguageInfo[] EndGetTridionLanguages(IAsyncResult result);

		WorkflowScriptType[] GetListWorkflowScriptTypes();

		IAsyncResult BeginGetListWorkflowScriptTypes(AsyncCallback callback, object asyncState);

		WorkflowScriptType[] EndGetListWorkflowScriptTypes(IAsyncResult result);

		WorkItemData[] AddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions);

		IAsyncResult BeginAddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		WorkItemData[] EndAddToWorkflow(IAsyncResult result);

		WorkItemData[] RemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions);

		IAsyncResult BeginRemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		WorkItemData[] EndRemoveFromWorkflow(IAsyncResult result);

		OrganizationalItemData Lock(string organizationalItemId, ReadOptions readBackOptions);

		IAsyncResult BeginLock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OrganizationalItemData EndLock(IAsyncResult result);

		OrganizationalItemData Unlock(string organizationalItemId, ReadOptions readBackOptions);

		IAsyncResult BeginUnlock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OrganizationalItemData EndUnlock(IAsyncResult result);

		ProcessInstanceData StartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions);

		IAsyncResult BeginStartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ProcessInstanceData EndStartWorkflow(IAsyncResult result);

		PublishTransactionData UndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions);

		IAsyncResult BeginUndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		PublishTransactionData EndUndoPublishTransaction(IAsyncResult result);

		ProcessDefinitionAssociationDictionary GetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType);

		IAsyncResult BeginGetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType, AsyncCallback callback, object asyncState);

		ProcessDefinitionAssociationDictionary EndGetProcessDefinitionsForItems(IAsyncResult result);

		string GetSystemXsd(string filename);

		IAsyncResult BeginGetSystemXsd(string filename, AsyncCallback callback, object asyncState);

		string EndGetSystemXsd(IAsyncResult result);

		LinkToSchemaData[] GetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName);

		IAsyncResult BeginGetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName, AsyncCallback callback, object asyncState);

		LinkToSchemaData[] EndGetSchemasByNamespaceUri(IAsyncResult result);

		ValidationErrorData[] Validate(IdentifiableObjectData deltaData);

		IAsyncResult BeginValidate(IdentifiableObjectData deltaData, AsyncCallback callback, object asyncState);

		ValidationErrorData[] EndValidate(IAsyncResult result);

		BinaryContentData GetExternalBinaryContentData(string uri);

		IAsyncResult BeginGetExternalBinaryContentData(string uri, AsyncCallback callback, object asyncState);

		BinaryContentData EndGetExternalBinaryContentData(IAsyncResult result);

		SynchronizationResult SynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions);

		IAsyncResult BeginSynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState);

		SynchronizationResult EndSynchronizeWithSchema(IAsyncResult result);

		SynchronizationResult SynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions);

		IAsyncResult BeginSynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState);

		SynchronizationResult EndSynchronizeWithSchemaAndUpdate(IAsyncResult result);

		void DecommissionPublicationTarget(string publicationTargetId);

		IAsyncResult BeginDecommissionPublicationTarget(string publicationTargetId, AsyncCallback callback, object asyncState);

		void EndDecommissionPublicationTarget(IAsyncResult result);

		SchemaFieldsData ConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions);

		IAsyncResult BeginConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		SchemaFieldsData EndConvertXsdToSchemaFields(IAsyncResult result);

		string GetPublishUrl(string id, string targetTypeIdOrPurpose);

		IAsyncResult BeginGetPublishUrl(string id, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState);

		string EndGetPublishUrl(IAsyncResult result);

		LinkToBusinessProcessTypeData[] GetBusinessProcessTypes(string cdTopologyTypeId);

		IAsyncResult BeginGetBusinessProcessTypes(string cdTopologyTypeId, AsyncCallback callback, object asyncState);

		LinkToBusinessProcessTypeData[] EndGetBusinessProcessTypes(IAsyncResult result);

		PublishSourceData GetPublishSourceByUrl(string url);

		IAsyncResult BeginGetPublishSourceByUrl(string url, AsyncCallback callback, object asyncState);

		PublishSourceData EndGetPublishSourceByUrl(IAsyncResult result);

		void RemovePublishStates(string publicationId, string targetTypeIdOrPurpose);

		IAsyncResult BeginRemovePublishStates(string publicationId, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState);

		void EndRemovePublishStates(IAsyncResult result);

		ContainingPagesDictionary ResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction);

		IAsyncResult BeginResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction, AsyncCallback callback, object asyncState);

		ContainingPagesDictionary EndResolveContainingPages(IAsyncResult result);

		void PurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction);

		IAsyncResult BeginPurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction, AsyncCallback callback, object asyncState);

		void EndPurgeWorkflowHistory(IAsyncResult result);

		string GetApiVersion();

		IAsyncResult BeginGetApiVersion(AsyncCallback callback, object asyncState);

		string EndGetApiVersion(IAsyncResult result);

		AccessTokenData GetCurrentUser();

		IAsyncResult BeginGetCurrentUser(AsyncCallback callback, object asyncState);

		AccessTokenData EndGetCurrentUser(IAsyncResult result);

		bool IsExistingObject(string id);

		IAsyncResult BeginIsExistingObject(string id, AsyncCallback callback, object asyncState);

		bool EndIsExistingObject(IAsyncResult result);

		string GetTcmUri(string baseUri, string contextRepositoryUri, uint? version);

		IAsyncResult BeginGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState);

		string EndGetTcmUri(IAsyncResult result);

		string TryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version);

		IAsyncResult BeginTryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState);

		string EndTryGetTcmUri(IAsyncResult result);

		IdentifiableObjectData Read(string id, ReadOptions readOptions);

		IAsyncResult BeginRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndRead(IAsyncResult result);

		IdentifiableObjectData TryRead(string id, ReadOptions readOptions);

		IAsyncResult BeginTryRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndTryRead(IAsyncResult result);

		ItemReadResultDictionary BulkRead(string[] ids, ReadOptions readOptions);

		IAsyncResult BeginBulkRead(string[] ids, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ItemReadResultDictionary EndBulkRead(IAsyncResult result);

		SchemaFieldsData ReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions);

		IAsyncResult BeginReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		SchemaFieldsData EndReadSchemaFields(IAsyncResult result);

		XElement ConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData);

		IAsyncResult BeginConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData, AsyncCallback callback, object asyncState);

		XElement EndConvertSchemaFieldsToXsd(IAsyncResult result);

		IdentifiableObjectData Save(IdentifiableObjectData deltaData, ReadOptions readBackOptions);

		IAsyncResult BeginSave(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndSave(IAsyncResult result);

		void Delete(string id);

		IAsyncResult BeginDelete(string id, AsyncCallback callback, object asyncState);

		void EndDelete(IAsyncResult result);

		void DeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode);

		IAsyncResult BeginDeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, AsyncCallback callback, object asyncState);

		void EndDeleteTaxonomyNode(IAsyncResult result);

		IdentifiableObjectData GetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions);

		IAsyncResult BeginGetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndGetDefaultData(IAsyncResult result);

		RepositoryLocalObjectData Move(string id, string destinationId, ReadOptions readBackOptions);

		IAsyncResult BeginMove(string id, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndMove(IAsyncResult result);

		RepositoryLocalObjectData Copy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions);

		IAsyncResult BeginCopy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndCopy(IAsyncResult result);

		InstanceData GetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions);

		IAsyncResult BeginGetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		InstanceData EndGetInstanceData(IAsyncResult result);

		IdentifiableObjectData TryCheckOut(string id, ReadOptions readBackOptions);

		IAsyncResult BeginTryCheckOut(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndTryCheckOut(IAsyncResult result);

		VersionedItemData CheckOut(string id, bool permanentLock, ReadOptions readBackOptions);

		IAsyncResult BeginCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndCheckOut(IAsyncResult result);

		VersionedItemData CheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions);

		IAsyncResult BeginCheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndCheckIn(IAsyncResult result);

		IdentifiableObjectData Update(IdentifiableObjectData deltaData, ReadOptions readBackOptions);

		IAsyncResult BeginUpdate(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndUpdate(IAsyncResult result);

		IdentifiableObjectData Create(IdentifiableObjectData data, ReadOptions readBackOptions);

		IAsyncResult BeginCreate(IdentifiableObjectData data, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndCreate(IAsyncResult result);

		VersionedItemData UndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions);

		IAsyncResult BeginUndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndUndoCheckOut(IAsyncResult result);

		VersionedItemData Rollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions);

		IAsyncResult BeginRollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndRollback(IAsyncResult result);

		RepositoryLocalObjectData Localize(string id, ReadOptions readBackOptions);

		IAsyncResult BeginLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndLocalize(IAsyncResult result);

		RepositoryLocalObjectData UnLocalize(string id, ReadOptions readBackOptions);

		IAsyncResult BeginUnLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndUnLocalize(IAsyncResult result);

		OperationResultDataOfRepositoryLocalObjectData Promote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions);

		IAsyncResult BeginPromote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OperationResultDataOfRepositoryLocalObjectData EndPromote(IAsyncResult result);

		OperationResultDataOfRepositoryLocalObjectData Demote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions);

		IAsyncResult BeginDemote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OperationResultDataOfRepositoryLocalObjectData EndDemote(IAsyncResult result);

		TemplateType[] GetListTemplateTypes(ItemType? itemType);

		IAsyncResult BeginGetListTemplateTypes(ItemType? itemType, AsyncCallback callback, object asyncState);

		TemplateType[] EndGetListTemplateTypes(IAsyncResult result);

		PublicationType[] GetListPublicationTypes();

		IAsyncResult BeginGetListPublicationTypes(AsyncCallback callback, object asyncState);

		PublicationType[] EndGetListPublicationTypes(IAsyncResult result);

		XElement GetSystemWideListXml(SystemWideListFilterData filter);

		IAsyncResult BeginGetSystemWideListXml(SystemWideListFilterData filter, AsyncCallback callback, object asyncState);

		XElement EndGetSystemWideListXml(IAsyncResult result);

		IdentifiableObjectData[] GetSystemWideList(SystemWideListFilterData filter);

		IAsyncResult BeginGetSystemWideList(SystemWideListFilterData filter, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetSystemWideList(IAsyncResult result);

		XElement GetListXml(string id, SubjectRelatedListFilterData filter);

		IAsyncResult BeginGetListXml(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState);

		XElement EndGetListXml(IAsyncResult result);

		IdentifiableObjectData[] GetList(string id, SubjectRelatedListFilterData filter);

		IAsyncResult BeginGetList(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetList(IAsyncResult result);

		string[] GetListDirectoryServiceNames();

		IAsyncResult BeginGetListDirectoryServiceNames(AsyncCallback callback, object asyncState);

		string[] EndGetListDirectoryServiceNames(IAsyncResult result);

		WindowsUser[] GetListWindowsDomainUsers(string domainName);

		IAsyncResult BeginGetListWindowsDomainUsers(string domainName, AsyncCallback callback, object asyncState);

		WindowsUser[] EndGetListWindowsDomainUsers(IAsyncResult result);

		DirectoryServiceUser[] GetListDirectoryServiceAllUsers(string directoryServiceName);

		IAsyncResult BeginGetListDirectoryServiceAllUsers(string directoryServiceName, AsyncCallback callback, object asyncState);

		DirectoryServiceUser[] EndGetListDirectoryServiceAllUsers(IAsyncResult result);

		DirectoryServiceUser[] GetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN);

		IAsyncResult BeginGetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN, AsyncCallback callback, object asyncState);

		DirectoryServiceUser[] EndGetListDirectoryServiceGroupMembers(IAsyncResult result);

		DirectoryServiceUser[] GetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter);

		IAsyncResult BeginGetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter, AsyncCallback callback, object asyncState);

		DirectoryServiceUser[] EndGetListDirectoryServiceUsers(IAsyncResult result);

		ClassificationInfoData Classify(string id, string[] keywordIds, ReadOptions readOptions);

		IAsyncResult BeginClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ClassificationInfoData EndClassify(IAsyncResult result);

		ClassificationInfoData UnClassify(string id, string[] keywordIds, ReadOptions readOptions);

		IAsyncResult BeginUnClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ClassificationInfoData EndUnClassify(IAsyncResult result);

		ClassificationInfoData ReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions);

		IAsyncResult BeginReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ClassificationInfoData EndReClassify(IAsyncResult result);

		ActivityInstanceData StartActivity(string activityInstanceId, ReadOptions readBackOptions);

		IAsyncResult BeginStartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndStartActivity(IAsyncResult result);

		ActivityInstanceData SuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions);

		IAsyncResult BeginSuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndSuspendActivity(IAsyncResult result);

		ActivityInstanceData RestartActivity(string activityInstanceId, ReadOptions readBackOptions);

		IAsyncResult BeginRestartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndRestartActivity(IAsyncResult result);

		ActivityInstanceData ReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions);

		IAsyncResult BeginReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndReAssignActivity(IAsyncResult result);

		ActivityInstanceData FinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions);

		IAsyncResult BeginFinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndFinishActivity(IAsyncResult result);

		ProcessHistoryData ForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions);

		IAsyncResult BeginForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ProcessHistoryData EndForceFinishProcess(IAsyncResult result);

		ActivityInstanceData ResumeActivity(string activityInstanceId, ReadOptions readOptions);

		IAsyncResult BeginResumeActivity(string activityInstanceId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndResumeActivity(IAsyncResult result);

		QueueMessageData[] GetListQueueMessages(int queueId);

		IAsyncResult BeginGetListQueueMessages(int queueId, AsyncCallback callback, object asyncState);

		QueueMessageData[] EndGetListQueueMessages(IAsyncResult result);

		void PurgeQueue(int queueId);

		IAsyncResult BeginPurgeQueue(int queueId, AsyncCallback callback, object asyncState);

		void EndPurgeQueue(IAsyncResult result);

		QueueData[] GetListQueues();

		IAsyncResult BeginGetListQueues(AsyncCallback callback, object asyncState);

		QueueData[] EndGetListQueues(IAsyncResult result);

		ApplicationData ReadApplicationData(string subjectId, string applicationId);

		IAsyncResult BeginReadApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState);

		ApplicationData EndReadApplicationData(IAsyncResult result);

		ApplicationData[] ReadAllApplicationData(string subjectId);

		IAsyncResult BeginReadAllApplicationData(string subjectId, AsyncCallback callback, object asyncState);

		ApplicationData[] EndReadAllApplicationData(IAsyncResult result);

		void SaveApplicationData(string subjectId, ApplicationData[] applicationData);

		IAsyncResult BeginSaveApplicationData(string subjectId, ApplicationData[] applicationData, AsyncCallback callback, object asyncState);

		void EndSaveApplicationData(IAsyncResult result);

		void DeleteApplicationData(string subjectId, string applicationId);

		IAsyncResult BeginDeleteApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState);

		void EndDeleteApplicationData(IAsyncResult result);

		string[] GetApplicationIds();

		IAsyncResult BeginGetApplicationIds(AsyncCallback callback, object asyncState);

		string[] EndGetApplicationIds(IAsyncResult result);

		void PurgeApplicationData(string applicationId);

		IAsyncResult BeginPurgeApplicationData(string applicationId, AsyncCallback callback, object asyncState);

		void EndPurgeApplicationData(IAsyncResult result);

		PredefinedBatchOperation? ParsePredefinedBatchOperation(string operation);

		IAsyncResult BeginParsePredefinedBatchOperation(string operation, AsyncCallback callback, object asyncState);

		PredefinedBatchOperation? EndParsePredefinedBatchOperation(IAsyncResult result);

		string GetPredefinedBatchOperationName(PredefinedBatchOperation operation);

		IAsyncResult BeginGetPredefinedBatchOperationName(PredefinedBatchOperation operation, AsyncCallback callback, object asyncState);

		string EndGetPredefinedBatchOperationName(IAsyncResult result);

		PublishContextData[] ResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions);

		IAsyncResult BeginResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		PublishContextData[] EndResolveItems(IAsyncResult result);

		XElement GetSearchResultsXml(SearchQueryData filter);

		IAsyncResult BeginGetSearchResultsXml(SearchQueryData filter, AsyncCallback callback, object asyncState);

		XElement EndGetSearchResultsXml(IAsyncResult result);

		XElement GetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows);

		IAsyncResult BeginGetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState);

		XElement EndGetSearchResultsXmlPaged(IAsyncResult result);

		IdentifiableObjectData[] GetSearchResults(SearchQueryData filter);

		IAsyncResult BeginGetSearchResults(SearchQueryData filter, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetSearchResults(IAsyncResult result);

		IdentifiableObjectData[] GetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows);

		IAsyncResult BeginGetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetSearchResultsPaged(IAsyncResult result);

		RenderedItemData RenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose);

		IAsyncResult BeginRenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose, AsyncCallback callback, object asyncState);

		RenderedItemData EndRenderItem(IAsyncResult result);

		RenderedItemData PreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId);

		IAsyncResult BeginPreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId, AsyncCallback callback, object asyncState);

		RenderedItemData EndPreviewItem(IAsyncResult result);

		PublishTransactionData[] Publish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions);

		IAsyncResult BeginPublish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		PublishTransactionData[] EndPublish(IAsyncResult result);

		PublishTransactionData[] UnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions);

		IAsyncResult BeginUnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		PublishTransactionData[] EndUnPublish(IAsyncResult result);

		bool IsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext);

		IAsyncResult BeginIsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext, AsyncCallback callback, object asyncState);

		bool EndIsPublished(IAsyncResult result);

		RenderedItemData GetWorkItemSnapshot(string workItemId);

		IAsyncResult BeginGetWorkItemSnapshot(string workItemId, AsyncCallback callback, object asyncState);

		RenderedItemData EndGetWorkItemSnapshot(IAsyncResult result);

		PublishInfoData[] GetListPublishInfo(string itemId);

		IAsyncResult BeginGetListPublishInfo(string itemId, AsyncCallback callback, object asyncState);

		PublishInfoData[] EndGetListPublishInfo(IAsyncResult result);

		ActionFlags CastActions(int numericActions);

		IAsyncResult BeginCastActions(int numericActions, AsyncCallback callback, object asyncState);

		ActionFlags EndCastActions(IAsyncResult result);

		void ValidateXml(IdentifiableObjectData data);

		IAsyncResult BeginValidateXml(IdentifiableObjectData data, AsyncCallback callback, object asyncState);

		void EndValidateXml(IAsyncResult result);

		bool IsValidTridionWebSchemaXml(SchemaData data);

		IAsyncResult BeginIsValidTridionWebSchemaXml(SchemaData data, AsyncCallback callback, object asyncState);

		bool EndIsValidTridionWebSchemaXml(IAsyncResult result);

		ArrayOfTcmUri GetSubjectIdsWithApplicationData(string applicationId);

		IAsyncResult BeginGetSubjectIdsWithApplicationData(string applicationId, AsyncCallback callback, object asyncState);

		ArrayOfTcmUri EndGetSubjectIdsWithApplicationData(IAsyncResult result);

		ApplicationDataDictionary ReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds);

		IAsyncResult BeginReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds, AsyncCallback callback, object asyncState);

		ApplicationDataDictionary EndReadApplicationDataForSubjectsIds(IAsyncResult result);

		SecurityDescriptorDataDictionary GetSecurityDescriptorsForSubjectsIds(string[] subjectIds);

		IAsyncResult BeginGetSecurityDescriptorsForSubjectsIds(string[] subjectIds, AsyncCallback callback, object asyncState);

		SecurityDescriptorDataDictionary EndGetSecurityDescriptorsForSubjectsIds(IAsyncResult result);

		SecurityDescriptorDataDictionary GetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds);

		IAsyncResult BeginGetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds, AsyncCallback callback, object asyncState);

		SecurityDescriptorDataDictionary EndGetContentSecurityDescriptorsForOrgItemIds(IAsyncResult result);

		void ReIndex(string id);

		IAsyncResult BeginReIndex(string id, AsyncCallback callback, object asyncState);

		void EndReIndex(IAsyncResult result);

		PredefinedQueue? CastPredefinedQueue(int queueId);

		IAsyncResult BeginCastPredefinedQueue(int queueId, AsyncCallback callback, object asyncState);

		PredefinedQueue? EndCastPredefinedQueue(IAsyncResult result);

		int PurgeOldVersions(PurgeOldVersionsInstructionData instruction);

		IAsyncResult BeginPurgeOldVersions(PurgeOldVersionsInstructionData instruction, AsyncCallback callback, object asyncState);

		int EndPurgeOldVersions(IAsyncResult result);

		XElement GetListExternalLinks(string id);

		IAsyncResult BeginGetListExternalLinks(string id, AsyncCallback callback, object asyncState);

		XElement EndGetListExternalLinks(IAsyncResult result);

		SearchQueryData ConvertXmlToSearchQuery(XElement searchQueryXml);

		IAsyncResult BeginConvertXmlToSearchQuery(XElement searchQueryXml, AsyncCallback callback, object asyncState);

		SearchQueryData EndConvertXmlToSearchQuery(IAsyncResult result);

		XElement ConvertSearchQueryToXml(SearchQueryData searchQueryData);

		IAsyncResult BeginConvertSearchQueryToXml(SearchQueryData searchQueryData, AsyncCallback callback, object asyncState);

		XElement EndConvertSearchQueryToXml(IAsyncResult result);

		AccessTokenData Impersonate(string userName);

		IAsyncResult BeginImpersonate(string userName, AsyncCallback callback, object asyncState);

		AccessTokenData EndImpersonate(IAsyncResult result);

		void ImpersonateWithToken(AccessTokenData accessToken);

		IAsyncResult BeginImpersonateWithToken(AccessTokenData accessToken, AsyncCallback callback, object asyncState);

		void EndImpersonateWithToken(IAsyncResult result);

		AccessTokenData ImpersonateWithClaims(ClaimData[] claims);

		IAsyncResult BeginImpersonateWithClaims(ClaimData[] claims, AsyncCallback callback, object asyncState);

		AccessTokenData EndImpersonateWithClaims(IAsyncResult result);

		void TerminateSession();

		IAsyncResult BeginTerminateSession(AsyncCallback callback, object asyncState);

		void EndTerminateSession(IAsyncResult result);

		string GetSessionId();

		IAsyncResult BeginGetSessionId(AsyncCallback callback, object asyncState);

		string EndGetSessionId(IAsyncResult result);

		void SetSessionContextData(ApplicationData appData);

		IAsyncResult BeginSetSessionContextData(ApplicationData appData, AsyncCallback callback, object asyncState);

		void EndSetSessionContextData(IAsyncResult result);

		void SetSessionTransactionTimeout(int transactionTimeout);

		IAsyncResult BeginSetSessionTransactionTimeout(int transactionTimeout, AsyncCallback callback, object asyncState);

		void EndSetSessionTransactionTimeout(IAsyncResult result);

		int GetSessionTransactionTimeout();

		IAsyncResult BeginGetSessionTransactionTimeout(AsyncCallback callback, object asyncState);

		int EndGetSessionTransactionTimeout(IAsyncResult result);

		bool StartCaching();

		IAsyncResult BeginStartCaching(AsyncCallback callback, object asyncState);

		bool EndStartCaching(IAsyncResult result);

		void StopCaching();

		IAsyncResult BeginStopCaching(AsyncCallback callback, object asyncState);

		void EndStopCaching(IAsyncResult result);

		void SetWebDavUrlPrefix(string prefix);

		IAsyncResult BeginSetWebDavUrlPrefix(string prefix, AsyncCallback callback, object asyncState);

		void EndSetWebDavUrlPrefix(IAsyncResult result);

		void EnlistInTransaction();

		IAsyncResult BeginEnlistInTransaction(AsyncCallback callback, object asyncState);

		void EndEnlistInTransaction(IAsyncResult result);

		UserData ElevatePrivileges(Privileges privileges);

		IAsyncResult BeginElevatePrivileges(Privileges privileges, AsyncCallback callback, object asyncState);

		UserData EndElevatePrivileges(IAsyncResult result);

		UserData RestorePrivileges();

		IAsyncResult BeginRestorePrivileges(AsyncCallback callback, object asyncState);

		UserData EndRestorePrivileges(IAsyncResult result);
	}
}
