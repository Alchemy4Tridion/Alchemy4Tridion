using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Xml.Linq;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(ConfigurationName = "Alchemy4Tridion.Plugins.Clients.CoreService.ISessionAwareCoreService2013", Namespace = "http://www.sdltridion.com/ContentManager/CoreService/2013", SessionMode = SessionMode.Required)]
	public interface ISessionAwareCoreService2013
	{
		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetVirtualFolderTypeSchemaCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetVirtualFolderTypeSchema", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetVirtualFolderTypeSchemaResponse")]
		SchemaData GetVirtualFolderTypeSchema(string namespaceUri);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetVirtualFolderTypeSchema", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetVirtualFolderTypeSchemaResponse")]
		IAsyncResult BeginGetVirtualFolderTypeSchema(string namespaceUri, AsyncCallback callback, object asyncState);

		SchemaData EndGetVirtualFolderTypeSchema(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetEnumValuesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetEnumValues", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetEnumValuesResponse")]
		TridionEnumValue[] GetEnumValues(string type);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetEnumValues", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetEnumValuesResponse")]
		IAsyncResult BeginGetEnumValues(string type, AsyncCallback callback, object asyncState);

		TridionEnumValue[] EndGetEnumValues(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveBundleTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveBundleTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveBundleTypesResponse")]
		BundleTypeData[] ResolveBundleTypes(string[] itemIds, bool pruneTree);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveBundleTypes", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveBundleTypesResponse")]
		IAsyncResult BeginResolveBundleTypes(string[] itemIds, bool pruneTree, AsyncCallback callback, object asyncState);

		BundleTypeData[] EndResolveBundleTypes(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyToKeywordCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyToKeywordResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		KeywordData CopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyToKeyword", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyToKeywordResponse")]
		IAsyncResult BeginCopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		KeywordData EndCopyToKeyword(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveToKeywordCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveToKeywordResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		KeywordData MoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveToKeyword", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveToKeywordResponse")]
		IAsyncResult BeginMoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		KeywordData EndMoveToKeyword(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTridionLanguagesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTridionLanguages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTridionLanguagesResponse")]
		TridionLanguageInfo[] GetTridionLanguages();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTridionLanguages", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTridionLanguagesResponse")]
		IAsyncResult BeginGetTridionLanguages(AsyncCallback callback, object asyncState);

		TridionLanguageInfo[] EndGetTridionLanguages(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWorkflowScriptTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWorkflowScriptTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWorkflowScriptTypesResponse")]
		WorkflowScriptType[] GetListWorkflowScriptTypes();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWorkflowScriptTypes", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWorkflowScriptTypesResponse")]
		IAsyncResult BeginGetListWorkflowScriptTypes(AsyncCallback callback, object asyncState);

		WorkflowScriptType[] EndGetListWorkflowScriptTypes(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/AddToWorkflowCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/AddToWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/AddToWorkflowResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		WorkItemData[] AddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/AddToWorkflow", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/AddToWorkflowResponse")]
		IAsyncResult BeginAddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		WorkItemData[] EndAddToWorkflow(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemoveFromWorkflowCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemoveFromWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemoveFromWorkflowResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		WorkItemData[] RemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemoveFromWorkflow", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemoveFromWorkflowResponse")]
		IAsyncResult BeginRemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		WorkItemData[] EndRemoveFromWorkflow(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/LockCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Lock", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/LockResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		OrganizationalItemData Lock(string organizationalItemId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Lock", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/LockResponse")]
		IAsyncResult BeginLock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OrganizationalItemData EndLock(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnlockCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Unlock", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnlockResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		OrganizationalItemData Unlock(string organizationalItemId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Unlock", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnlockResponse")]
		IAsyncResult BeginUnlock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OrganizationalItemData EndUnlock(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartWorkflowCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartWorkflowResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ProcessInstanceData StartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartWorkflow", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartWorkflowResponse")]
		IAsyncResult BeginStartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ProcessInstanceData EndStartWorkflow(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoPublishTransactionCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoPublishTransaction", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoPublishTransactionResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		PublishTransactionData UndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoPublishTransaction", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoPublishTransactionResponse")]
		IAsyncResult BeginUndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		PublishTransactionData EndUndoPublishTransaction(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetProcessDefinitionsForItemsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetProcessDefinitionsForItems", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetProcessDefinitionsForItemsResponse")]
		ProcessDefinitionAssociationDictionary GetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetProcessDefinitionsForItems", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetProcessDefinitionsForItemsResponse")]
		IAsyncResult BeginGetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType, AsyncCallback callback, object asyncState);

		ProcessDefinitionAssociationDictionary EndGetProcessDefinitionsForItems(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemXsdCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemXsd", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemXsdResponse")]
		string GetSystemXsd(string filename);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemXsd", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemXsdResponse")]
		IAsyncResult BeginGetSystemXsd(string filename, AsyncCallback callback, object asyncState);

		string EndGetSystemXsd(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSchemasByNamespaceUriCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSchemasByNamespaceUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSchemasByNamespaceUriResponse")]
		LinkToSchemaData[] GetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSchemasByNamespaceUri", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSchemasByNamespaceUriResponse")]
		IAsyncResult BeginGetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName, AsyncCallback callback, object asyncState);

		LinkToSchemaData[] EndGetSchemasByNamespaceUri(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Validate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateResponse")]
		ValidationErrorData[] Validate(IdentifiableObjectData deltaData);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Validate", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateResponse")]
		IAsyncResult BeginValidate(IdentifiableObjectData deltaData, AsyncCallback callback, object asyncState);

		ValidationErrorData[] EndValidate(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetExternalBinaryContentDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetExternalBinaryContentData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetExternalBinaryContentDataResponse")]
		BinaryContentData GetExternalBinaryContentData(string uri);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetExternalBinaryContentData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetExternalBinaryContentDataResponse")]
		IAsyncResult BeginGetExternalBinaryContentData(string uri, AsyncCallback callback, object asyncState);

		BinaryContentData EndGetExternalBinaryContentData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchema", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaResponse")]
		SynchronizationResult SynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchema", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaResponse")]
		IAsyncResult BeginSynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState);

		SynchronizationResult EndSynchronizeWithSchema(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaAndUpdateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaAndUpdate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaAndUpdateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		SynchronizationResult SynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaAndUpdate", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SynchronizeWithSchemaAndUpdateResponse")]
		IAsyncResult BeginSynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState);

		SynchronizationResult EndSynchronizeWithSchemaAndUpdate(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DecommissionPublicationTargetCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DecommissionPublicationTarget", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DecommissionPublicationTargetResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void DecommissionPublicationTarget(string publicationTargetId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DecommissionPublicationTarget", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DecommissionPublicationTargetResponse")]
		IAsyncResult BeginDecommissionPublicationTarget(string publicationTargetId, AsyncCallback callback, object asyncState);

		void EndDecommissionPublicationTarget(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXsdToSchemaFieldsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXsdToSchemaFields", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXsdToSchemaFieldsResponse")]
		SchemaFieldsData ConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXsdToSchemaFields", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXsdToSchemaFieldsResponse")]
		IAsyncResult BeginConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		SchemaFieldsData EndConvertXsdToSchemaFields(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishUrlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishUrl", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishUrlResponse")]
		string GetPublishUrl(string id, string targetTypeIdOrPurpose);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishUrl", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishUrlResponse")]
		IAsyncResult BeginGetPublishUrl(string id, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState);

		string EndGetPublishUrl(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetBusinessProcessTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetBusinessProcessTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetBusinessProcessTypesResponse")]
		LinkToBusinessProcessTypeData[] GetBusinessProcessTypes(string cdTopologyTypeId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetBusinessProcessTypes", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetBusinessProcessTypesResponse")]
		IAsyncResult BeginGetBusinessProcessTypes(string cdTopologyTypeId, AsyncCallback callback, object asyncState);

		LinkToBusinessProcessTypeData[] EndGetBusinessProcessTypes(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishSourceByUrlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishSourceByUrl", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishSourceByUrlResponse")]
		PublishSourceData GetPublishSourceByUrl(string url);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishSourceByUrl", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPublishSourceByUrlResponse")]
		IAsyncResult BeginGetPublishSourceByUrl(string url, AsyncCallback callback, object asyncState);

		PublishSourceData EndGetPublishSourceByUrl(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemovePublishStatesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemovePublishStates", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemovePublishStatesResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void RemovePublishStates(string publicationId, string targetTypeIdOrPurpose);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemovePublishStates", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RemovePublishStatesResponse")]
		IAsyncResult BeginRemovePublishStates(string publicationId, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState);

		void EndRemovePublishStates(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveContainingPagesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveContainingPages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveContainingPagesResponse")]
		ContainingPagesDictionary ResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveContainingPages", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveContainingPagesResponse")]
		IAsyncResult BeginResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction, AsyncCallback callback, object asyncState);

		ContainingPagesDictionary EndResolveContainingPages(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeWorkflowHistoryCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeWorkflowHistory", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeWorkflowHistoryResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void PurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeWorkflowHistory", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeWorkflowHistoryResponse")]
		IAsyncResult BeginPurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction, AsyncCallback callback, object asyncState);

		void EndPurgeWorkflowHistory(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApiVersionCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApiVersion", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApiVersionResponse")]
		string GetApiVersion();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApiVersion", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApiVersionResponse")]
		IAsyncResult BeginGetApiVersion(AsyncCallback callback, object asyncState);

		string EndGetApiVersion(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetCurrentUserCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetCurrentUser", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetCurrentUserResponse")]
		AccessTokenData GetCurrentUser();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetCurrentUser", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetCurrentUserResponse")]
		IAsyncResult BeginGetCurrentUser(AsyncCallback callback, object asyncState);

		AccessTokenData EndGetCurrentUser(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsExistingObjectCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsExistingObject", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsExistingObjectResponse")]
		bool IsExistingObject(string id);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsExistingObject", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsExistingObjectResponse")]
		IAsyncResult BeginIsExistingObject(string id, AsyncCallback callback, object asyncState);

		bool EndIsExistingObject(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTcmUriCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTcmUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTcmUriResponse")]
		string GetTcmUri(string baseUri, string contextRepositoryUri, uint? version);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTcmUri", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetTcmUriResponse")]
		IAsyncResult BeginGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState);

		string EndGetTcmUri(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryGetTcmUriCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryGetTcmUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryGetTcmUriResponse")]
		string TryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryGetTcmUri", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryGetTcmUriResponse")]
		IAsyncResult BeginTryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState);

		string EndTryGetTcmUri(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Read", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadResponse")]
		IdentifiableObjectData Read(string id, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Read", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadResponse")]
		IAsyncResult BeginRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndRead(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryReadCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryRead", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryReadResponse")]
		IdentifiableObjectData TryRead(string id, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryRead", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryReadResponse")]
		IAsyncResult BeginTryRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndTryRead(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/BulkReadCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/BulkRead", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/BulkReadResponse")]
		ItemReadResultDictionary BulkRead(string[] ids, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/BulkRead", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/BulkReadResponse")]
		IAsyncResult BeginBulkRead(string[] ids, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ItemReadResultDictionary EndBulkRead(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadSchemaFieldsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadSchemaFields", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadSchemaFieldsResponse")]
		SchemaFieldsData ReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadSchemaFields", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadSchemaFieldsResponse")]
		IAsyncResult BeginReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		SchemaFieldsData EndReadSchemaFields(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSchemaFieldsToXsdCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSchemaFieldsToXsd", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSchemaFieldsToXsdResponse")]
		XElement ConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSchemaFieldsToXsd", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSchemaFieldsToXsdResponse")]
		IAsyncResult BeginConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData, AsyncCallback callback, object asyncState);

		XElement EndConvertSchemaFieldsToXsd(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Save", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		IdentifiableObjectData Save(IdentifiableObjectData deltaData, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Save", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveResponse")]
		IAsyncResult BeginSave(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndSave(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Delete", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void Delete(string id);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Delete", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteResponse")]
		IAsyncResult BeginDelete(string id, AsyncCallback callback, object asyncState);

		void EndDelete(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteTaxonomyNodeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteTaxonomyNode", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteTaxonomyNodeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void DeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteTaxonomyNode", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteTaxonomyNodeResponse")]
		IAsyncResult BeginDeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, AsyncCallback callback, object asyncState);

		void EndDeleteTaxonomyNode(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetDefaultDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetDefaultData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetDefaultDataResponse")]
		IdentifiableObjectData GetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetDefaultData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetDefaultDataResponse")]
		IAsyncResult BeginGetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndGetDefaultData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Move", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		RepositoryLocalObjectData Move(string id, string destinationId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Move", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/MoveResponse")]
		IAsyncResult BeginMove(string id, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndMove(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Copy", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		RepositoryLocalObjectData Copy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Copy", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CopyResponse")]
		IAsyncResult BeginCopy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndCopy(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetInstanceDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetInstanceData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetInstanceDataResponse")]
		InstanceData GetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetInstanceData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetInstanceDataResponse")]
		IAsyncResult BeginGetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		InstanceData EndGetInstanceData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryCheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryCheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		IdentifiableObjectData TryCheckOut(string id, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryCheckOut", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/TryCheckOutResponse")]
		IAsyncResult BeginTryCheckOut(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndTryCheckOut(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		VersionedItemData CheckOut(string id, bool permanentLock, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckOut", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckOutResponse")]
		IAsyncResult BeginCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndCheckOut(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckInCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckIn", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckInResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		VersionedItemData CheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckIn", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CheckInResponse")]
		IAsyncResult BeginCheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndCheckIn(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UpdateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Update", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UpdateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		IdentifiableObjectData Update(IdentifiableObjectData deltaData, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Update", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UpdateResponse")]
		IAsyncResult BeginUpdate(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndUpdate(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CreateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Create", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CreateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		IdentifiableObjectData Create(IdentifiableObjectData data, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Create", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CreateResponse")]
		IAsyncResult BeginCreate(IdentifiableObjectData data, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		IdentifiableObjectData EndCreate(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoCheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoCheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		VersionedItemData UndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoCheckOut", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UndoCheckOutResponse")]
		IAsyncResult BeginUndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndUndoCheckOut(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RollbackCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Rollback", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RollbackResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		VersionedItemData Rollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Rollback", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RollbackResponse")]
		IAsyncResult BeginRollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		VersionedItemData EndRollback(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/LocalizeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Localize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/LocalizeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		RepositoryLocalObjectData Localize(string id, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Localize", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/LocalizeResponse")]
		IAsyncResult BeginLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndLocalize(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnLocalizeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnLocalize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnLocalizeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		RepositoryLocalObjectData UnLocalize(string id, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnLocalize", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnLocalizeResponse")]
		IAsyncResult BeginUnLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		RepositoryLocalObjectData EndUnLocalize(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PromoteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Promote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PromoteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		OperationResultDataOfRepositoryLocalObjectData Promote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Promote", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PromoteResponse")]
		IAsyncResult BeginPromote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OperationResultDataOfRepositoryLocalObjectData EndPromote(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DemoteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Demote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DemoteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		OperationResultDataOfRepositoryLocalObjectData Demote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Demote", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DemoteResponse")]
		IAsyncResult BeginDemote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		OperationResultDataOfRepositoryLocalObjectData EndDemote(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListTemplateTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListTemplateTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListTemplateTypesResponse")]
		TemplateType[] GetListTemplateTypes(ItemType? itemType);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListTemplateTypes", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListTemplateTypesResponse")]
		IAsyncResult BeginGetListTemplateTypes(ItemType? itemType, AsyncCallback callback, object asyncState);

		TemplateType[] EndGetListTemplateTypes(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublicationTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublicationTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublicationTypesResponse")]
		PublicationType[] GetListPublicationTypes();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublicationTypes", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublicationTypesResponse")]
		IAsyncResult BeginGetListPublicationTypes(AsyncCallback callback, object asyncState);

		PublicationType[] EndGetListPublicationTypes(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListXmlResponse")]
		XElement GetSystemWideListXml(SystemWideListFilterData filter);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListXml", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListXmlResponse")]
		IAsyncResult BeginGetSystemWideListXml(SystemWideListFilterData filter, AsyncCallback callback, object asyncState);

		XElement EndGetSystemWideListXml(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideList", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListResponse")]
		IdentifiableObjectData[] GetSystemWideList(SystemWideListFilterData filter);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideList", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSystemWideListResponse")]
		IAsyncResult BeginGetSystemWideList(SystemWideListFilterData filter, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetSystemWideList(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListXmlResponse")]
		XElement GetListXml(string id, SubjectRelatedListFilterData filter);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListXml", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListXmlResponse")]
		IAsyncResult BeginGetListXml(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState);

		XElement EndGetListXml(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetList", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListResponse")]
		IdentifiableObjectData[] GetList(string id, SubjectRelatedListFilterData filter);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetList", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListResponse")]
		IAsyncResult BeginGetList(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetList(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceNamesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceNames", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceNamesResponse")]
		string[] GetListDirectoryServiceNames();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceNames", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceNamesResponse")]
		IAsyncResult BeginGetListDirectoryServiceNames(AsyncCallback callback, object asyncState);

		string[] EndGetListDirectoryServiceNames(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWindowsDomainUsersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWindowsDomainUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWindowsDomainUsersResponse")]
		WindowsUser[] GetListWindowsDomainUsers(string domainName);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWindowsDomainUsers", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListWindowsDomainUsersResponse")]
		IAsyncResult BeginGetListWindowsDomainUsers(string domainName, AsyncCallback callback, object asyncState);

		WindowsUser[] EndGetListWindowsDomainUsers(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceAllUsersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceAllUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceAllUsersResponse")]
		DirectoryServiceUser[] GetListDirectoryServiceAllUsers(string directoryServiceName);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceAllUsers", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceAllUsersResponse")]
		IAsyncResult BeginGetListDirectoryServiceAllUsers(string directoryServiceName, AsyncCallback callback, object asyncState);

		DirectoryServiceUser[] EndGetListDirectoryServiceAllUsers(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceGroupMembersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceGroupMembers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceGroupMembersResponse")]
		DirectoryServiceUser[] GetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceGroupMembers", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceGroupMembersResponse")]
		IAsyncResult BeginGetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN, AsyncCallback callback, object asyncState);

		DirectoryServiceUser[] EndGetListDirectoryServiceGroupMembers(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceUsersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceUsersResponse")]
		DirectoryServiceUser[] GetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceUsers", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListDirectoryServiceUsersResponse")]
		IAsyncResult BeginGetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter, AsyncCallback callback, object asyncState);

		DirectoryServiceUser[] EndGetListDirectoryServiceUsers(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Classify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ClassificationInfoData Classify(string id, string[] keywordIds, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Classify", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ClassifyResponse")]
		IAsyncResult BeginClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ClassificationInfoData EndClassify(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ClassificationInfoData UnClassify(string id, string[] keywordIds, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnClassify", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnClassifyResponse")]
		IAsyncResult BeginUnClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ClassificationInfoData EndUnClassify(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ClassificationInfoData ReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReClassify", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReClassifyResponse")]
		IAsyncResult BeginReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ClassificationInfoData EndReClassify(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ActivityInstanceData StartActivity(string activityInstanceId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartActivity", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/StartActivityResponse")]
		IAsyncResult BeginStartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndStartActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SuspendActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SuspendActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SuspendActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ActivityInstanceData SuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SuspendActivity", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SuspendActivityResponse")]
		IAsyncResult BeginSuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndSuspendActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RestartActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RestartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RestartActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ActivityInstanceData RestartActivity(string activityInstanceId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RestartActivity", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RestartActivityResponse")]
		IAsyncResult BeginRestartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndRestartActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReAssignActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReAssignActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReAssignActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ActivityInstanceData ReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReAssignActivity", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReAssignActivityResponse")]
		IAsyncResult BeginReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndReAssignActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/FinishActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/FinishActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/FinishActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ActivityInstanceData FinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/FinishActivity", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/FinishActivityResponse")]
		IAsyncResult BeginFinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndFinishActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ForceFinishProcessCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ForceFinishProcess", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ForceFinishProcessResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ProcessHistoryData ForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ForceFinishProcess", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ForceFinishProcessResponse")]
		IAsyncResult BeginForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ProcessHistoryData EndForceFinishProcess(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResumeActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResumeActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResumeActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		ActivityInstanceData ResumeActivity(string activityInstanceId, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResumeActivity", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResumeActivityResponse")]
		IAsyncResult BeginResumeActivity(string activityInstanceId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		ActivityInstanceData EndResumeActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueueMessagesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueueMessages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueueMessagesResponse")]
		QueueMessageData[] GetListQueueMessages(int queueId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueueMessages", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueueMessagesResponse")]
		IAsyncResult BeginGetListQueueMessages(int queueId, AsyncCallback callback, object asyncState);

		QueueMessageData[] EndGetListQueueMessages(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeQueueCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeQueue", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeQueueResponse")]
		void PurgeQueue(int queueId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeQueue", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeQueueResponse")]
		IAsyncResult BeginPurgeQueue(int queueId, AsyncCallback callback, object asyncState);

		void EndPurgeQueue(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueuesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueues", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueuesResponse")]
		QueueData[] GetListQueues();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueues", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListQueuesResponse")]
		IAsyncResult BeginGetListQueues(AsyncCallback callback, object asyncState);

		QueueData[] EndGetListQueues(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataResponse")]
		ApplicationData ReadApplicationData(string subjectId, string applicationId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataResponse")]
		IAsyncResult BeginReadApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState);

		ApplicationData EndReadApplicationData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadAllApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadAllApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadAllApplicationDataResponse")]
		ApplicationData[] ReadAllApplicationData(string subjectId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadAllApplicationData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadAllApplicationDataResponse")]
		IAsyncResult BeginReadAllApplicationData(string subjectId, AsyncCallback callback, object asyncState);

		ApplicationData[] EndReadAllApplicationData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveApplicationDataResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void SaveApplicationData(string subjectId, ApplicationData[] applicationData);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveApplicationData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/SaveApplicationDataResponse")]
		IAsyncResult BeginSaveApplicationData(string subjectId, ApplicationData[] applicationData, AsyncCallback callback, object asyncState);

		void EndSaveApplicationData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteApplicationDataResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void DeleteApplicationData(string subjectId, string applicationId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteApplicationData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/DeleteApplicationDataResponse")]
		IAsyncResult BeginDeleteApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState);

		void EndDeleteApplicationData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApplicationIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApplicationIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApplicationIdsResponse")]
		string[] GetApplicationIds();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApplicationIds", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetApplicationIdsResponse")]
		IAsyncResult BeginGetApplicationIds(AsyncCallback callback, object asyncState);

		string[] EndGetApplicationIds(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeApplicationDataResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void PurgeApplicationData(string applicationId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeApplicationData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeApplicationDataResponse")]
		IAsyncResult BeginPurgeApplicationData(string applicationId, AsyncCallback callback, object asyncState);

		void EndPurgeApplicationData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ParsePredefinedBatchOperationCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ParsePredefinedBatchOperation", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ParsePredefinedBatchOperationResponse")]
		PredefinedBatchOperation? ParsePredefinedBatchOperation(string operation);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ParsePredefinedBatchOperation", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ParsePredefinedBatchOperationResponse")]
		IAsyncResult BeginParsePredefinedBatchOperation(string operation, AsyncCallback callback, object asyncState);

		PredefinedBatchOperation? EndParsePredefinedBatchOperation(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPredefinedBatchOperationNameCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPredefinedBatchOperationName", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPredefinedBatchOperationNameResponse")]
		string GetPredefinedBatchOperationName(PredefinedBatchOperation operation);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPredefinedBatchOperationName", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetPredefinedBatchOperationNameResponse")]
		IAsyncResult BeginGetPredefinedBatchOperationName(PredefinedBatchOperation operation, AsyncCallback callback, object asyncState);

		string EndGetPredefinedBatchOperationName(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveItemsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveItems", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveItemsResponse")]
		PublishContextData[] ResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveItems", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ResolveItemsResponse")]
		IAsyncResult BeginResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		PublishContextData[] EndResolveItems(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlResponse")]
		XElement GetSearchResultsXml(SearchQueryData filter);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXml", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlResponse")]
		IAsyncResult BeginGetSearchResultsXml(SearchQueryData filter, AsyncCallback callback, object asyncState);

		XElement EndGetSearchResultsXml(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlPagedCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlPaged", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlPagedResponse")]
		XElement GetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlPaged", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsXmlPagedResponse")]
		IAsyncResult BeginGetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState);

		XElement EndGetSearchResultsXmlPaged(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResults", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsResponse")]
		IdentifiableObjectData[] GetSearchResults(SearchQueryData filter);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResults", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsResponse")]
		IAsyncResult BeginGetSearchResults(SearchQueryData filter, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetSearchResults(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsPagedCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsPaged", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsPagedResponse")]
		IdentifiableObjectData[] GetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsPaged", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSearchResultsPagedResponse")]
		IAsyncResult BeginGetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState);

		IdentifiableObjectData[] EndGetSearchResultsPaged(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RenderItemCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RenderItem", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RenderItemResponse")]
		RenderedItemData RenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RenderItem", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/RenderItemResponse")]
		IAsyncResult BeginRenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose, AsyncCallback callback, object asyncState);

		RenderedItemData EndRenderItem(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PreviewItemCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PreviewItem", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PreviewItemResponse")]
		RenderedItemData PreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PreviewItem", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PreviewItemResponse")]
		IAsyncResult BeginPreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId, AsyncCallback callback, object asyncState);

		RenderedItemData EndPreviewItem(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PublishCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Publish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PublishResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		PublishTransactionData[] Publish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/Publish", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PublishResponse")]
		IAsyncResult BeginPublish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		PublishTransactionData[] EndPublish(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnPublishCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnPublish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnPublishResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		PublishTransactionData[] UnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnPublish", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/UnPublishResponse")]
		IAsyncResult BeginUnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState);

		PublishTransactionData[] EndUnPublish(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsPublishedCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsPublished", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsPublishedResponse")]
		bool IsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsPublished", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsPublishedResponse")]
		IAsyncResult BeginIsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext, AsyncCallback callback, object asyncState);

		bool EndIsPublished(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetWorkItemSnapshotCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetWorkItemSnapshot", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetWorkItemSnapshotResponse")]
		RenderedItemData GetWorkItemSnapshot(string workItemId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetWorkItemSnapshot", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetWorkItemSnapshotResponse")]
		IAsyncResult BeginGetWorkItemSnapshot(string workItemId, AsyncCallback callback, object asyncState);

		RenderedItemData EndGetWorkItemSnapshot(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublishInfoCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublishInfo", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublishInfoResponse")]
		PublishInfoData[] GetListPublishInfo(string itemId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublishInfo", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListPublishInfoResponse")]
		IAsyncResult BeginGetListPublishInfo(string itemId, AsyncCallback callback, object asyncState);

		PublishInfoData[] EndGetListPublishInfo(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastActionsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastActions", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastActionsResponse")]
		ActionFlags CastActions(int numericActions);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastActions", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastActionsResponse")]
		IAsyncResult BeginCastActions(int numericActions, AsyncCallback callback, object asyncState);

		ActionFlags EndCastActions(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateXmlResponse")]
		void ValidateXml(IdentifiableObjectData data);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateXml", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ValidateXmlResponse")]
		IAsyncResult BeginValidateXml(IdentifiableObjectData data, AsyncCallback callback, object asyncState);

		void EndValidateXml(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsValidTridionWebSchemaXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsValidTridionWebSchemaXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsValidTridionWebSchemaXmlResponse")]
		bool IsValidTridionWebSchemaXml(SchemaData data);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsValidTridionWebSchemaXml", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/IsValidTridionWebSchemaXmlResponse")]
		IAsyncResult BeginIsValidTridionWebSchemaXml(SchemaData data, AsyncCallback callback, object asyncState);

		bool EndIsValidTridionWebSchemaXml(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSubjectIdsWithApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSubjectIdsWithApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSubjectIdsWithApplicationDataResponse")]
		ArrayOfTcmUri GetSubjectIdsWithApplicationData(string applicationId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSubjectIdsWithApplicationData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSubjectIdsWithApplicationDataResponse")]
		IAsyncResult BeginGetSubjectIdsWithApplicationData(string applicationId, AsyncCallback callback, object asyncState);

		ArrayOfTcmUri EndGetSubjectIdsWithApplicationData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataForSubjectsIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataForSubjectsIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataForSubjectsIdsResponse")]
		ApplicationDataDictionary ReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataForSubjectsIds", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReadApplicationDataForSubjectsIdsResponse")]
		IAsyncResult BeginReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds, AsyncCallback callback, object asyncState);

		ApplicationDataDictionary EndReadApplicationDataForSubjectsIds(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSecurityDescriptorsForSubjectsIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSecurityDescriptorsForSubjectsIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSecurityDescriptorsForSubjectsIdsResponse")]
		SecurityDescriptorDataDictionary GetSecurityDescriptorsForSubjectsIds(string[] subjectIds);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSecurityDescriptorsForSubjectsIds", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetSecurityDescriptorsForSubjectsIdsResponse")]
		IAsyncResult BeginGetSecurityDescriptorsForSubjectsIds(string[] subjectIds, AsyncCallback callback, object asyncState);

		SecurityDescriptorDataDictionary EndGetSecurityDescriptorsForSubjectsIds(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetContentSecurityDescriptorsForOrgItemIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetContentSecurityDescriptorsForOrgItemIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetContentSecurityDescriptorsForOrgItemIdsResponse")]
		SecurityDescriptorDataDictionary GetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetContentSecurityDescriptorsForOrgItemIds", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetContentSecurityDescriptorsForOrgItemIdsResponse")]
		IAsyncResult BeginGetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds, AsyncCallback callback, object asyncState);

		SecurityDescriptorDataDictionary EndGetContentSecurityDescriptorsForOrgItemIds(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReIndexCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReIndex", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReIndexResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void ReIndex(string id);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReIndex", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ReIndexResponse")]
		IAsyncResult BeginReIndex(string id, AsyncCallback callback, object asyncState);

		void EndReIndex(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastPredefinedQueueCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastPredefinedQueue", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastPredefinedQueueResponse")]
		PredefinedQueue? CastPredefinedQueue(int queueId);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastPredefinedQueue", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/CastPredefinedQueueResponse")]
		IAsyncResult BeginCastPredefinedQueue(int queueId, AsyncCallback callback, object asyncState);

		PredefinedQueue? EndCastPredefinedQueue(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeOldVersionsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeOldVersions", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeOldVersionsResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		int PurgeOldVersions(PurgeOldVersionsInstructionData instruction);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeOldVersions", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/PurgeOldVersionsResponse")]
		IAsyncResult BeginPurgeOldVersions(PurgeOldVersionsInstructionData instruction, AsyncCallback callback, object asyncState);

		int EndPurgeOldVersions(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListExternalLinksCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListExternalLinks", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListExternalLinksResponse")]
		XElement GetListExternalLinks(string id);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListExternalLinks", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/GetListExternalLinksResponse")]
		IAsyncResult BeginGetListExternalLinks(string id, AsyncCallback callback, object asyncState);

		XElement EndGetListExternalLinks(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXmlToSearchQueryCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXmlToSearchQuery", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXmlToSearchQueryResponse")]
		SearchQueryData ConvertXmlToSearchQuery(XElement searchQueryXml);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXmlToSearchQuery", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertXmlToSearchQueryResponse")]
		IAsyncResult BeginConvertXmlToSearchQuery(XElement searchQueryXml, AsyncCallback callback, object asyncState);

		SearchQueryData EndConvertXmlToSearchQuery(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSearchQueryToXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSearchQueryToXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSearchQueryToXmlResponse")]
		XElement ConvertSearchQueryToXml(SearchQueryData searchQueryData);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSearchQueryToXml", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ICoreService/ConvertSearchQueryToXmlResponse")]
		IAsyncResult BeginConvertSearchQueryToXml(SearchQueryData searchQueryData, AsyncCallback callback, object asyncState);

		XElement EndConvertSearchQueryToXml(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/Impersonate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateResponse")]
		AccessTokenData Impersonate(string userName);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/Impersonate", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateResponse")]
		IAsyncResult BeginImpersonate(string userName, AsyncCallback callback, object asyncState);

		AccessTokenData EndImpersonate(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithTokenCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithToken", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithTokenResponse")]
		void ImpersonateWithToken(AccessTokenData accessToken);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithToken", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithTokenResponse")]
		IAsyncResult BeginImpersonateWithToken(AccessTokenData accessToken, AsyncCallback callback, object asyncState);

		void EndImpersonateWithToken(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithClaimsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithClaims", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithClaimsResponse")]
		AccessTokenData ImpersonateWithClaims(ClaimData[] claims);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithClaims", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ImpersonateWithClaimsResponse")]
		IAsyncResult BeginImpersonateWithClaims(ClaimData[] claims, AsyncCallback callback, object asyncState);

		AccessTokenData EndImpersonateWithClaims(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/TerminateSessionCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/TerminateSession", IsInitiating = false, IsTerminating = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/TerminateSessionResponse")]
		void TerminateSession();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/TerminateSession", AsyncPattern = true, IsInitiating = false, IsTerminating = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/TerminateSessionResponse")]
		IAsyncResult BeginTerminateSession(AsyncCallback callback, object asyncState);

		void EndTerminateSession(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionIdCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionId", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionIdResponse")]
		string GetSessionId();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionId", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionIdResponse")]
		IAsyncResult BeginGetSessionId(AsyncCallback callback, object asyncState);

		string EndGetSessionId(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionContextDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionContextData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionContextDataResponse")]
		void SetSessionContextData(ApplicationData appData);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionContextData", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionContextDataResponse")]
		IAsyncResult BeginSetSessionContextData(ApplicationData appData, AsyncCallback callback, object asyncState);

		void EndSetSessionContextData(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionTransactionTimeoutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionTransactionTimeout", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionTransactionTimeoutResponse")]
		void SetSessionTransactionTimeout(int transactionTimeout);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionTransactionTimeout", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetSessionTransactionTimeoutResponse")]
		IAsyncResult BeginSetSessionTransactionTimeout(int transactionTimeout, AsyncCallback callback, object asyncState);

		void EndSetSessionTransactionTimeout(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionTransactionTimeoutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionTransactionTimeout", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionTransactionTimeoutResponse")]
		int GetSessionTransactionTimeout();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionTransactionTimeout", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/GetSessionTransactionTimeoutResponse")]
		IAsyncResult BeginGetSessionTransactionTimeout(AsyncCallback callback, object asyncState);

		int EndGetSessionTransactionTimeout(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StartCachingCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StartCaching", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StartCachingResponse")]
		bool StartCaching();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StartCaching", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StartCachingResponse")]
		IAsyncResult BeginStartCaching(AsyncCallback callback, object asyncState);

		bool EndStartCaching(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StopCachingCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StopCaching", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StopCachingResponse")]
		void StopCaching();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StopCaching", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/StopCachingResponse")]
		IAsyncResult BeginStopCaching(AsyncCallback callback, object asyncState);

		void EndStopCaching(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetWebDavUrlPrefixCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetWebDavUrlPrefix", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetWebDavUrlPrefixResponse")]
		void SetWebDavUrlPrefix(string prefix);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetWebDavUrlPrefix", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/SetWebDavUrlPrefixResponse")]
		IAsyncResult BeginSetWebDavUrlPrefix(string prefix, AsyncCallback callback, object asyncState);

		void EndSetWebDavUrlPrefix(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/EnlistInTransactionCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/EnlistInTransaction", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/EnlistInTransactionResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		void EnlistInTransaction();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/EnlistInTransaction", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/EnlistInTransactionResponse")]
		IAsyncResult BeginEnlistInTransaction(AsyncCallback callback, object asyncState);

		void EndEnlistInTransaction(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ElevatePrivilegesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ElevatePrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ElevatePrivilegesResponse")]
		UserData ElevatePrivileges(Privileges privileges);

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ElevatePrivileges", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/ElevatePrivilegesResponse")]
		IAsyncResult BeginElevatePrivileges(Privileges privileges, AsyncCallback callback, object asyncState);

		UserData EndElevatePrivileges(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/RestorePrivilegesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/RestorePrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/RestorePrivilegesResponse")]
		UserData RestorePrivileges();

		[OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/RestorePrivileges", AsyncPattern = true, ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/2013/ISessionAwareCoreService/RestorePrivilegesResponse")]
		IAsyncResult BeginRestorePrivileges(AsyncCallback callback, object asyncState);

		UserData EndRestorePrivileges(IAsyncResult result);
	}
}
