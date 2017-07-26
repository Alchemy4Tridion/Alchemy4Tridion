using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Xml.Linq;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201603", ConfigurationName = "Tridion.ContentManager.CoreService.Client.ISessionAwareCoreService", SessionMode = SessionMode.Required)]
    public interface ISessionAwareCoreService201603
    {
        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetVirtualFolderTypeSchemaCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetVirtualFolderTypeSchema", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetVirtualFolderTypeSchemaResponse")]
        SchemaData GetVirtualFolderTypeSchema(string namespaceUri);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetVirtualFolderTypeSchema", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetVirtualFolderTypeSchemaResponse")]
        IAsyncResult BeginGetVirtualFolderTypeSchema(string namespaceUri, AsyncCallback callback, object asyncState);

        SchemaData EndGetVirtualFolderTypeSchema(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetEnumValuesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetEnumValues", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetEnumValuesResponse")]
        TridionEnumValue[] GetEnumValues(string type);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetEnumValues", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetEnumValuesResponse")]
        IAsyncResult BeginGetEnumValues(string type, AsyncCallback callback, object asyncState);

        TridionEnumValue[] EndGetEnumValues(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveBundleTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveBundleTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveBundleTypesResponse")]
        BundleTypeData[] ResolveBundleTypes(string[] itemIds, bool pruneTree);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveBundleTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveBundleTypesResponse")]
        IAsyncResult BeginResolveBundleTypes(string[] itemIds, bool pruneTree, AsyncCallback callback, object asyncState);

        BundleTypeData[] EndResolveBundleTypes(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyToKeywordCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyToKeywordResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        KeywordData CopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyToKeywordResponse")]
        IAsyncResult BeginCopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        KeywordData EndCopyToKeyword(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveToKeywordCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveToKeywordResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        KeywordData MoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveToKeywordResponse")]
        IAsyncResult BeginMoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        KeywordData EndMoveToKeyword(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTridionLanguagesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTridionLanguages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTridionLanguagesResponse")]
        TridionLanguageInfo[] GetTridionLanguages();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTridionLanguages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTridionLanguagesResponse")]
        IAsyncResult BeginGetTridionLanguages(AsyncCallback callback, object asyncState);

        TridionLanguageInfo[] EndGetTridionLanguages(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWorkflowScriptTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWorkflowScriptTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWorkflowScriptTypesResponse")]
        WorkflowScriptType[] GetListWorkflowScriptTypes();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWorkflowScriptTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWorkflowScriptTypesResponse")]
        IAsyncResult BeginGetListWorkflowScriptTypes(AsyncCallback callback, object asyncState);

        WorkflowScriptType[] EndGetListWorkflowScriptTypes(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/AddToWorkflowCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/AddToWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/AddToWorkflowResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        WorkItemData[] AddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/AddToWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/AddToWorkflowResponse")]
        IAsyncResult BeginAddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        WorkItemData[] EndAddToWorkflow(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemoveFromWorkflowCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemoveFromWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemoveFromWorkflowResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        WorkItemData[] RemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemoveFromWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemoveFromWorkflowResponse")]
        IAsyncResult BeginRemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        WorkItemData[] EndRemoveFromWorkflow(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/LockCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Lock", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/LockResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        OrganizationalItemData Lock(string organizationalItemId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Lock", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/LockResponse")]
        IAsyncResult BeginLock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        OrganizationalItemData EndLock(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnlockCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Unlock", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnlockResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        OrganizationalItemData Unlock(string organizationalItemId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Unlock", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnlockResponse")]
        IAsyncResult BeginUnlock(string organizationalItemId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        OrganizationalItemData EndUnlock(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartWorkflowCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartWorkflowResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ProcessInstanceData StartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartWorkflow", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartWorkflowResponse")]
        IAsyncResult BeginStartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        ProcessInstanceData EndStartWorkflow(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetProcessDefinitionsForItemsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetProcessDefinitionsForItems", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetProcessDefinitionsForItemsResponse")]
        ProcessDefinitionAssociationDictionary GetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetProcessDefinitionsForItems", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetProcessDefinitionsForItemsResponse")]
        IAsyncResult BeginGetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType, AsyncCallback callback, object asyncState);

        ProcessDefinitionAssociationDictionary EndGetProcessDefinitionsForItems(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemXsdCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemXsd", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemXsdResponse")]
        string GetSystemXsd(string filename);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemXsd", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemXsdResponse")]
        IAsyncResult BeginGetSystemXsd(string filename, AsyncCallback callback, object asyncState);

        string EndGetSystemXsd(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSchemasByNamespaceUriCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSchemasByNamespaceUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSchemasByNamespaceUriResponse")]
        LinkToSchemaData[] GetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSchemasByNamespaceUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSchemasByNamespaceUriResponse")]
        IAsyncResult BeginGetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName, AsyncCallback callback, object asyncState);

        LinkToSchemaData[] EndGetSchemasByNamespaceUri(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Validate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateResponse")]
        ValidationErrorData[] Validate(IdentifiableObjectData deltaData);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Validate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateResponse")]
        IAsyncResult BeginValidate(IdentifiableObjectData deltaData, AsyncCallback callback, object asyncState);

        ValidationErrorData[] EndValidate(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetExternalBinaryContentDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetExternalBinaryContentData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetExternalBinaryContentDataResponse")]
        BinaryContentData GetExternalBinaryContentData(string uri);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetExternalBinaryContentData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetExternalBinaryContentDataResponse")]
        IAsyncResult BeginGetExternalBinaryContentData(string uri, AsyncCallback callback, object asyncState);

        BinaryContentData EndGetExternalBinaryContentData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchema", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaResponse")]
        SynchronizationResult SynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchema", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaResponse")]
        IAsyncResult BeginSynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState);

        SynchronizationResult EndSynchronizeWithSchema(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaAndUpdateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaAndUpdate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaAndUpdateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        SynchronizationResult SynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaAndUpdate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SynchronizeWithSchemaAndUpdateResponse")]
        IAsyncResult BeginSynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions, AsyncCallback callback, object asyncState);

        SynchronizationResult EndSynchronizeWithSchemaAndUpdate(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DecommissionPublicationTargetCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DecommissionPublicationTarget", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DecommissionPublicationTargetResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void DecommissionPublicationTarget(string publicationTargetId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DecommissionPublicationTarget", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DecommissionPublicationTargetResponse")]
        IAsyncResult BeginDecommissionPublicationTarget(string publicationTargetId, AsyncCallback callback, object asyncState);

        void EndDecommissionPublicationTarget(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXsdToSchemaFieldsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXsdToSchemaFields", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXsdToSchemaFieldsResponse")]
        SchemaFieldsData ConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXsdToSchemaFields", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXsdToSchemaFieldsResponse")]
        IAsyncResult BeginConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        SchemaFieldsData EndConvertXsdToSchemaFields(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishUrlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishUrl", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishUrlResponse")]
        string GetPublishUrl(string id, string targetTypeIdOrPurpose);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishUrl", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishUrlResponse")]
        IAsyncResult BeginGetPublishUrl(string id, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState);

        string EndGetPublishUrl(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetBusinessProcessTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetBusinessProcessTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetBusinessProcessTypesResponse")]
        LinkToBusinessProcessTypeData[] GetBusinessProcessTypes(string cdTopologyTypeId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetBusinessProcessTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetBusinessProcessTypesResponse")]
        IAsyncResult BeginGetBusinessProcessTypes(string cdTopologyTypeId, AsyncCallback callback, object asyncState);

        LinkToBusinessProcessTypeData[] EndGetBusinessProcessTypes(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishSourceByUrlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishSourceByUrl", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishSourceByUrlResponse")]
        PublishSourceData GetPublishSourceByUrl(string url);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishSourceByUrl", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPublishSourceByUrlResponse")]
        IAsyncResult BeginGetPublishSourceByUrl(string url, AsyncCallback callback, object asyncState);

        PublishSourceData EndGetPublishSourceByUrl(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemovePublishStatesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemovePublishStates", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemovePublishStatesResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void RemovePublishStates(string publicationId, string targetTypeIdOrPurpose);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemovePublishStates", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RemovePublishStatesResponse")]
        IAsyncResult BeginRemovePublishStates(string publicationId, string targetTypeIdOrPurpose, AsyncCallback callback, object asyncState);

        void EndRemovePublishStates(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveContainingPagesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveContainingPages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveContainingPagesResponse")]
        ContainingPagesDictionary ResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveContainingPages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveContainingPagesResponse")]
        IAsyncResult BeginResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction, AsyncCallback callback, object asyncState);

        ContainingPagesDictionary EndResolveContainingPages(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeWorkflowHistoryCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeWorkflowHistory", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeWorkflowHistoryResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void PurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeWorkflowHistory", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeWorkflowHistoryResponse")]
        IAsyncResult BeginPurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction, AsyncCallback callback, object asyncState);

        void EndPurgeWorkflowHistory(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BroadcastNotificationCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BroadcastNotification", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BroadcastNotificationResponse")]
        void BroadcastNotification(NotificationMessage notification);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BroadcastNotification", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BroadcastNotificationResponse")]
        IAsyncResult BeginBroadcastNotification(NotificationMessage notification, AsyncCallback callback, object asyncState);

        void EndBroadcastNotification(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemPrivilegesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemPrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemPrivilegesResponse")]
        SystemPrivilege[] GetSystemPrivileges();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemPrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemPrivilegesResponse")]
        IAsyncResult BeginGetSystemPrivileges(AsyncCallback callback, object asyncState);

        SystemPrivilege[] EndGetSystemPrivileges(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApiVersionCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApiVersion", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApiVersionResponse")]
        string GetApiVersion();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApiVersion", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApiVersionResponse")]
        IAsyncResult BeginGetApiVersion(AsyncCallback callback, object asyncState);

        string EndGetApiVersion(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetCurrentUserCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetCurrentUser", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetCurrentUserResponse")]
        AccessTokenData GetCurrentUser();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetCurrentUser", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetCurrentUserResponse")]
        IAsyncResult BeginGetCurrentUser(AsyncCallback callback, object asyncState);

        AccessTokenData EndGetCurrentUser(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsExistingObjectCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsExistingObject", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsExistingObjectResponse")]
        bool IsExistingObject(string id);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsExistingObject", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsExistingObjectResponse")]
        IAsyncResult BeginIsExistingObject(string id, AsyncCallback callback, object asyncState);

        bool EndIsExistingObject(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTcmUriCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTcmUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTcmUriResponse")]
        string GetTcmUri(string baseUri, string contextRepositoryUri, uint? version);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTcmUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetTcmUriResponse")]
        IAsyncResult BeginGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState);

        string EndGetTcmUri(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryGetTcmUriCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryGetTcmUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryGetTcmUriResponse")]
        string TryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryGetTcmUri", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryGetTcmUriResponse")]
        IAsyncResult BeginTryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version, AsyncCallback callback, object asyncState);

        string EndTryGetTcmUri(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Read", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadResponse")]
        IdentifiableObjectData Read(string id, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Read", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadResponse")]
        IAsyncResult BeginRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        IdentifiableObjectData EndRead(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryReadCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryRead", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryReadResponse")]
        IdentifiableObjectData TryRead(string id, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryRead", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryReadResponse")]
        IAsyncResult BeginTryRead(string id, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        IdentifiableObjectData EndTryRead(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BulkReadCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BulkRead", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BulkReadResponse")]
        ItemReadResultDictionary BulkRead(string[] ids, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BulkRead", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/BulkReadResponse")]
        IAsyncResult BeginBulkRead(string[] ids, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        ItemReadResultDictionary EndBulkRead(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadSchemaFieldsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadSchemaFields", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadSchemaFieldsResponse")]
        SchemaFieldsData ReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadSchemaFields", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadSchemaFieldsResponse")]
        IAsyncResult BeginReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        SchemaFieldsData EndReadSchemaFields(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSchemaFieldsToXsdCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSchemaFieldsToXsd", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSchemaFieldsToXsdResponse")]
        XElement ConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSchemaFieldsToXsd", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSchemaFieldsToXsdResponse")]
        IAsyncResult BeginConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData, AsyncCallback callback, object asyncState);

        XElement EndConvertSchemaFieldsToXsd(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Save", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        IdentifiableObjectData Save(IdentifiableObjectData deltaData, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Save", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveResponse")]
        IAsyncResult BeginSave(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        IdentifiableObjectData EndSave(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Delete", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void Delete(string id);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Delete", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteResponse")]
        IAsyncResult BeginDelete(string id, AsyncCallback callback, object asyncState);

        void EndDelete(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteTaxonomyNodeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteTaxonomyNode", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteTaxonomyNodeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void DeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteTaxonomyNode", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteTaxonomyNodeResponse")]
        IAsyncResult BeginDeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, AsyncCallback callback, object asyncState);

        void EndDeleteTaxonomyNode(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetDefaultDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetDefaultData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetDefaultDataResponse")]
        IdentifiableObjectData GetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetDefaultData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetDefaultDataResponse")]
        IAsyncResult BeginGetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        IdentifiableObjectData EndGetDefaultData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Move", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        RepositoryLocalObjectData Move(string id, string destinationId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Move", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/MoveResponse")]
        IAsyncResult BeginMove(string id, string destinationId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        RepositoryLocalObjectData EndMove(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Copy", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        RepositoryLocalObjectData Copy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Copy", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CopyResponse")]
        IAsyncResult BeginCopy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        RepositoryLocalObjectData EndCopy(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetInstanceDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetInstanceData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetInstanceDataResponse")]
        InstanceData GetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetInstanceData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetInstanceDataResponse")]
        IAsyncResult BeginGetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        InstanceData EndGetInstanceData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryCheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryCheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        IdentifiableObjectData TryCheckOut(string id, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/TryCheckOutResponse")]
        IAsyncResult BeginTryCheckOut(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        IdentifiableObjectData EndTryCheckOut(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        VersionedItemData CheckOut(string id, bool permanentLock, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckOutResponse")]
        IAsyncResult BeginCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        VersionedItemData EndCheckOut(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckInCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckIn", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckInResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        VersionedItemData CheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckIn", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CheckInResponse")]
        IAsyncResult BeginCheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        VersionedItemData EndCheckIn(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UpdateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Update", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UpdateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        IdentifiableObjectData Update(IdentifiableObjectData deltaData, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Update", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UpdateResponse")]
        IAsyncResult BeginUpdate(IdentifiableObjectData deltaData, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        IdentifiableObjectData EndUpdate(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CreateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Create", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CreateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        IdentifiableObjectData Create(IdentifiableObjectData data, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Create", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CreateResponse")]
        IAsyncResult BeginCreate(IdentifiableObjectData data, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        IdentifiableObjectData EndCreate(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UndoCheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UndoCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UndoCheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        VersionedItemData UndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UndoCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UndoCheckOutResponse")]
        IAsyncResult BeginUndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        VersionedItemData EndUndoCheckOut(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RollbackCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Rollback", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RollbackResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        VersionedItemData Rollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Rollback", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RollbackResponse")]
        IAsyncResult BeginRollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        VersionedItemData EndRollback(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/LocalizeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Localize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/LocalizeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        RepositoryLocalObjectData Localize(string id, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Localize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/LocalizeResponse")]
        IAsyncResult BeginLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        RepositoryLocalObjectData EndLocalize(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnLocalizeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnLocalize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnLocalizeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        RepositoryLocalObjectData UnLocalize(string id, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnLocalize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnLocalizeResponse")]
        IAsyncResult BeginUnLocalize(string id, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        RepositoryLocalObjectData EndUnLocalize(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PromoteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Promote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PromoteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        OperationResultDataOfRepositoryLocalObjectData Promote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Promote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PromoteResponse")]
        IAsyncResult BeginPromote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        OperationResultDataOfRepositoryLocalObjectData EndPromote(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DemoteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Demote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DemoteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        OperationResultDataOfRepositoryLocalObjectData Demote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Demote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DemoteResponse")]
        IAsyncResult BeginDemote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        OperationResultDataOfRepositoryLocalObjectData EndDemote(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListTemplateTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListTemplateTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListTemplateTypesResponse")]
        TemplateType[] GetListTemplateTypes(ItemType? itemType);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListTemplateTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListTemplateTypesResponse")]
        IAsyncResult BeginGetListTemplateTypes(ItemType? itemType, AsyncCallback callback, object asyncState);

        TemplateType[] EndGetListTemplateTypes(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublicationTypesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublicationTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublicationTypesResponse")]
        PublicationType[] GetListPublicationTypes();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublicationTypes", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublicationTypesResponse")]
        IAsyncResult BeginGetListPublicationTypes(AsyncCallback callback, object asyncState);

        PublicationType[] EndGetListPublicationTypes(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListXmlResponse")]
        XElement GetSystemWideListXml(SystemWideListFilterData filter);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListXmlResponse")]
        IAsyncResult BeginGetSystemWideListXml(SystemWideListFilterData filter, AsyncCallback callback, object asyncState);

        XElement EndGetSystemWideListXml(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideList", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListResponse")]
        IdentifiableObjectData[] GetSystemWideList(SystemWideListFilterData filter);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideList", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSystemWideListResponse")]
        IAsyncResult BeginGetSystemWideList(SystemWideListFilterData filter, AsyncCallback callback, object asyncState);

        IdentifiableObjectData[] EndGetSystemWideList(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListXmlResponse")]
        XElement GetListXml(string id, SubjectRelatedListFilterData filter);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListXmlResponse")]
        IAsyncResult BeginGetListXml(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState);

        XElement EndGetListXml(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetList", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListResponse")]
        IdentifiableObjectData[] GetList(string id, SubjectRelatedListFilterData filter);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetList", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListResponse")]
        IAsyncResult BeginGetList(string id, SubjectRelatedListFilterData filter, AsyncCallback callback, object asyncState);

        IdentifiableObjectData[] EndGetList(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceNamesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceNames", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceNamesResponse")]
        string[] GetListDirectoryServiceNames();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceNames", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceNamesResponse")]
        IAsyncResult BeginGetListDirectoryServiceNames(AsyncCallback callback, object asyncState);

        string[] EndGetListDirectoryServiceNames(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWindowsDomainUsersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWindowsDomainUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWindowsDomainUsersResponse")]
        WindowsUser[] GetListWindowsDomainUsers(string domainName);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWindowsDomainUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListWindowsDomainUsersResponse")]
        IAsyncResult BeginGetListWindowsDomainUsers(string domainName, AsyncCallback callback, object asyncState);

        WindowsUser[] EndGetListWindowsDomainUsers(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceAllUsersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceAllUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceAllUsersResponse")]
        DirectoryServiceUser[] GetListDirectoryServiceAllUsers(string directoryServiceName);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceAllUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceAllUsersResponse")]
        IAsyncResult BeginGetListDirectoryServiceAllUsers(string directoryServiceName, AsyncCallback callback, object asyncState);

        DirectoryServiceUser[] EndGetListDirectoryServiceAllUsers(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceGroupMembersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceGroupMembers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceGroupMembersResponse")]
        DirectoryServiceUser[] GetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceGroupMembers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceGroupMembersResponse")]
        IAsyncResult BeginGetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN, AsyncCallback callback, object asyncState);

        DirectoryServiceUser[] EndGetListDirectoryServiceGroupMembers(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceUsersCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceUsersResponse")]
        DirectoryServiceUser[] GetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceUsers", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListDirectoryServiceUsersResponse")]
        IAsyncResult BeginGetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter, AsyncCallback callback, object asyncState);

        DirectoryServiceUser[] EndGetListDirectoryServiceUsers(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Classify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ClassificationInfoData Classify(string id, string[] keywordIds, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Classify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ClassifyResponse")]
        IAsyncResult BeginClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        ClassificationInfoData EndClassify(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ClassificationInfoData UnClassify(string id, string[] keywordIds, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnClassifyResponse")]
        IAsyncResult BeginUnClassify(string id, string[] keywordIds, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        ClassificationInfoData EndUnClassify(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ClassificationInfoData ReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReClassifyResponse")]
        IAsyncResult BeginReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        ClassificationInfoData EndReClassify(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ActivityInstanceData StartActivity(string activityInstanceId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/StartActivityResponse")]
        IAsyncResult BeginStartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        ActivityInstanceData EndStartActivity(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SuspendActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SuspendActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SuspendActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ActivityInstanceData SuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SuspendActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SuspendActivityResponse")]
        IAsyncResult BeginSuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        ActivityInstanceData EndSuspendActivity(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RestartActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RestartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RestartActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ActivityInstanceData RestartActivity(string activityInstanceId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RestartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RestartActivityResponse")]
        IAsyncResult BeginRestartActivity(string activityInstanceId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        ActivityInstanceData EndRestartActivity(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReAssignActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReAssignActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReAssignActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ActivityInstanceData ReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReAssignActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReAssignActivityResponse")]
        IAsyncResult BeginReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions, AsyncCallback callback, object asyncState);

        ActivityInstanceData EndReAssignActivity(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/FinishActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/FinishActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/FinishActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ActivityInstanceData FinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/FinishActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/FinishActivityResponse")]
        IAsyncResult BeginFinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        ActivityInstanceData EndFinishActivity(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ForceFinishProcessCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ForceFinishProcess", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ForceFinishProcessResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ProcessHistoryData ForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ForceFinishProcess", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ForceFinishProcessResponse")]
        IAsyncResult BeginForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        ProcessHistoryData EndForceFinishProcess(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResumeActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResumeActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResumeActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        ActivityInstanceData ResumeActivity(string activityInstanceId, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResumeActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResumeActivityResponse")]
        IAsyncResult BeginResumeActivity(string activityInstanceId, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        ActivityInstanceData EndResumeActivity(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueueMessagesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueueMessages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueueMessagesResponse")]
        QueueMessageData[] GetListQueueMessages(int queueId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueueMessages", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueueMessagesResponse")]
        IAsyncResult BeginGetListQueueMessages(int queueId, AsyncCallback callback, object asyncState);

        QueueMessageData[] EndGetListQueueMessages(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeQueueCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeQueue", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeQueueResponse")]
        void PurgeQueue(int queueId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeQueue", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeQueueResponse")]
        IAsyncResult BeginPurgeQueue(int queueId, AsyncCallback callback, object asyncState);

        void EndPurgeQueue(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueuesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueues", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueuesResponse")]
        QueueData[] GetListQueues();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueues", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListQueuesResponse")]
        IAsyncResult BeginGetListQueues(AsyncCallback callback, object asyncState);

        QueueData[] EndGetListQueues(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataResponse")]
        ApplicationData ReadApplicationData(string subjectId, string applicationId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataResponse")]
        IAsyncResult BeginReadApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState);

        ApplicationData EndReadApplicationData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadAllApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadAllApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadAllApplicationDataResponse")]
        ApplicationData[] ReadAllApplicationData(string subjectId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadAllApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadAllApplicationDataResponse")]
        IAsyncResult BeginReadAllApplicationData(string subjectId, AsyncCallback callback, object asyncState);

        ApplicationData[] EndReadAllApplicationData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveApplicationDataResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void SaveApplicationData(string subjectId, ApplicationData[] applicationData);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/SaveApplicationDataResponse")]
        IAsyncResult BeginSaveApplicationData(string subjectId, ApplicationData[] applicationData, AsyncCallback callback, object asyncState);

        void EndSaveApplicationData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteApplicationDataResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void DeleteApplicationData(string subjectId, string applicationId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/DeleteApplicationDataResponse")]
        IAsyncResult BeginDeleteApplicationData(string subjectId, string applicationId, AsyncCallback callback, object asyncState);

        void EndDeleteApplicationData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApplicationIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApplicationIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApplicationIdsResponse")]
        string[] GetApplicationIds();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApplicationIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetApplicationIdsResponse")]
        IAsyncResult BeginGetApplicationIds(AsyncCallback callback, object asyncState);

        string[] EndGetApplicationIds(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeApplicationDataResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void PurgeApplicationData(string applicationId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeApplicationDataResponse")]
        IAsyncResult BeginPurgeApplicationData(string applicationId, AsyncCallback callback, object asyncState);

        void EndPurgeApplicationData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ParsePredefinedBatchOperationCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ParsePredefinedBatchOperation", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ParsePredefinedBatchOperationResponse")]
        PredefinedBatchOperation? ParsePredefinedBatchOperation(string operation);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ParsePredefinedBatchOperation", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ParsePredefinedBatchOperationResponse")]
        IAsyncResult BeginParsePredefinedBatchOperation(string operation, AsyncCallback callback, object asyncState);

        PredefinedBatchOperation? EndParsePredefinedBatchOperation(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPredefinedBatchOperationNameCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPredefinedBatchOperationName", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPredefinedBatchOperationNameResponse")]
        string GetPredefinedBatchOperationName(PredefinedBatchOperation operation);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPredefinedBatchOperationName", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetPredefinedBatchOperationNameResponse")]
        IAsyncResult BeginGetPredefinedBatchOperationName(PredefinedBatchOperation operation, AsyncCallback callback, object asyncState);

        string EndGetPredefinedBatchOperationName(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveItemsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveItems", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveItemsResponse")]
        PublishContextData[] ResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveItems", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ResolveItemsResponse")]
        IAsyncResult BeginResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        PublishContextData[] EndResolveItems(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlResponse")]
        XElement GetSearchResultsXml(SearchQueryData filter);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlResponse")]
        IAsyncResult BeginGetSearchResultsXml(SearchQueryData filter, AsyncCallback callback, object asyncState);

        XElement EndGetSearchResultsXml(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlPagedCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlPaged", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlPagedResponse")]
        XElement GetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlPaged", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsXmlPagedResponse")]
        IAsyncResult BeginGetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState);

        XElement EndGetSearchResultsXmlPaged(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResults", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsResponse")]
        IdentifiableObjectData[] GetSearchResults(SearchQueryData filter);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResults", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsResponse")]
        IAsyncResult BeginGetSearchResults(SearchQueryData filter, AsyncCallback callback, object asyncState);

        IdentifiableObjectData[] EndGetSearchResults(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsPagedCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsPaged", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsPagedResponse")]
        IdentifiableObjectData[] GetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsPaged", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSearchResultsPagedResponse")]
        IAsyncResult BeginGetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows, AsyncCallback callback, object asyncState);

        IdentifiableObjectData[] EndGetSearchResultsPaged(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RenderItemCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RenderItem", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RenderItemResponse")]
        RenderedItemData RenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RenderItem", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/RenderItemResponse")]
        IAsyncResult BeginRenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose, AsyncCallback callback, object asyncState);

        RenderedItemData EndRenderItem(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PreviewItemCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PreviewItem", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PreviewItemResponse")]
        RenderedItemData PreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PreviewItem", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PreviewItemResponse")]
        IAsyncResult BeginPreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId, AsyncCallback callback, object asyncState);

        RenderedItemData EndPreviewItem(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PublishCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Publish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PublishResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        PublishTransactionData[] Publish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/Publish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PublishResponse")]
        IAsyncResult BeginPublish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        PublishTransactionData[] EndPublish(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnPublishCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnPublish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnPublishResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        PublishTransactionData[] UnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnPublish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/UnPublishResponse")]
        IAsyncResult BeginUnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions, AsyncCallback callback, object asyncState);

        PublishTransactionData[] EndUnPublish(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsPublishedCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsPublished", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsPublishedResponse")]
        bool IsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsPublished", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsPublishedResponse")]
        IAsyncResult BeginIsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext, AsyncCallback callback, object asyncState);

        bool EndIsPublished(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetWorkItemSnapshotCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetWorkItemSnapshot", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetWorkItemSnapshotResponse")]
        RenderedItemData GetWorkItemSnapshot(string workItemId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetWorkItemSnapshot", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetWorkItemSnapshotResponse")]
        IAsyncResult BeginGetWorkItemSnapshot(string workItemId, AsyncCallback callback, object asyncState);

        RenderedItemData EndGetWorkItemSnapshot(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublishInfoCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublishInfo", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublishInfoResponse")]
        PublishInfoData[] GetListPublishInfo(string itemId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublishInfo", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListPublishInfoResponse")]
        IAsyncResult BeginGetListPublishInfo(string itemId, AsyncCallback callback, object asyncState);

        PublishInfoData[] EndGetListPublishInfo(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastActionsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastActions", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastActionsResponse")]
        ActionFlags CastActions(int numericActions);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastActions", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastActionsResponse")]
        IAsyncResult BeginCastActions(int numericActions, AsyncCallback callback, object asyncState);

        ActionFlags EndCastActions(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateXmlResponse")]
        void ValidateXml(IdentifiableObjectData data);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ValidateXmlResponse")]
        IAsyncResult BeginValidateXml(IdentifiableObjectData data, AsyncCallback callback, object asyncState);

        void EndValidateXml(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsValidTridionWebSchemaXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsValidTridionWebSchemaXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsValidTridionWebSchemaXmlResponse")]
        bool IsValidTridionWebSchemaXml(SchemaData data);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsValidTridionWebSchemaXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/IsValidTridionWebSchemaXmlResponse")]
        IAsyncResult BeginIsValidTridionWebSchemaXml(SchemaData data, AsyncCallback callback, object asyncState);

        bool EndIsValidTridionWebSchemaXml(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSubjectIdsWithApplicationDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSubjectIdsWithApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSubjectIdsWithApplicationDataResponse")]
        ArrayOfTcmUri GetSubjectIdsWithApplicationData(string applicationId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSubjectIdsWithApplicationData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSubjectIdsWithApplicationDataResponse")]
        IAsyncResult BeginGetSubjectIdsWithApplicationData(string applicationId, AsyncCallback callback, object asyncState);

        ArrayOfTcmUri EndGetSubjectIdsWithApplicationData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataForSubjectsIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataForSubjectsIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataForSubjectsIdsResponse")]
        ApplicationDataDictionary ReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataForSubjectsIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReadApplicationDataForSubjectsIdsResponse")]
        IAsyncResult BeginReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds, AsyncCallback callback, object asyncState);

        ApplicationDataDictionary EndReadApplicationDataForSubjectsIds(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSecurityDescriptorsForSubjectsIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSecurityDescriptorsForSubjectsIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSecurityDescriptorsForSubjectsIdsResponse")]
        SecurityDescriptorDataDictionary GetSecurityDescriptorsForSubjectsIds(string[] subjectIds);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSecurityDescriptorsForSubjectsIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetSecurityDescriptorsForSubjectsIdsResponse")]
        IAsyncResult BeginGetSecurityDescriptorsForSubjectsIds(string[] subjectIds, AsyncCallback callback, object asyncState);

        SecurityDescriptorDataDictionary EndGetSecurityDescriptorsForSubjectsIds(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetContentSecurityDescriptorsForOrgItemIdsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetContentSecurityDescriptorsForOrgItemIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetContentSecurityDescriptorsForOrgItemIdsResponse")]
        SecurityDescriptorDataDictionary GetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetContentSecurityDescriptorsForOrgItemIds", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetContentSecurityDescriptorsForOrgItemIdsResponse")]
        IAsyncResult BeginGetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds, AsyncCallback callback, object asyncState);

        SecurityDescriptorDataDictionary EndGetContentSecurityDescriptorsForOrgItemIds(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReIndexCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReIndex", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReIndexResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void ReIndex(string id);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReIndex", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ReIndexResponse")]
        IAsyncResult BeginReIndex(string id, AsyncCallback callback, object asyncState);

        void EndReIndex(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastPredefinedQueueCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastPredefinedQueue", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastPredefinedQueueResponse")]
        PredefinedQueue? CastPredefinedQueue(int queueId);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastPredefinedQueue", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/CastPredefinedQueueResponse")]
        IAsyncResult BeginCastPredefinedQueue(int queueId, AsyncCallback callback, object asyncState);

        PredefinedQueue? EndCastPredefinedQueue(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeOldVersionsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeOldVersions", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeOldVersionsResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        int PurgeOldVersions(PurgeOldVersionsInstructionData instruction);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeOldVersions", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/PurgeOldVersionsResponse")]
        IAsyncResult BeginPurgeOldVersions(PurgeOldVersionsInstructionData instruction, AsyncCallback callback, object asyncState);

        int EndPurgeOldVersions(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListExternalLinksCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListExternalLinks", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListExternalLinksResponse")]
        XElement GetListExternalLinks(string id);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListExternalLinks", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/GetListExternalLinksResponse")]
        IAsyncResult BeginGetListExternalLinks(string id, AsyncCallback callback, object asyncState);

        XElement EndGetListExternalLinks(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXmlToSearchQueryCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXmlToSearchQuery", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXmlToSearchQueryResponse")]
        SearchQueryData ConvertXmlToSearchQuery(XElement searchQueryXml);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXmlToSearchQuery", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertXmlToSearchQueryResponse")]
        IAsyncResult BeginConvertXmlToSearchQuery(XElement searchQueryXml, AsyncCallback callback, object asyncState);

        SearchQueryData EndConvertXmlToSearchQuery(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSearchQueryToXmlCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSearchQueryToXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSearchQueryToXmlResponse")]
        XElement ConvertSearchQueryToXml(SearchQueryData searchQueryData);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSearchQueryToXml", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ICoreService/ConvertSearchQueryToXmlResponse")]
        IAsyncResult BeginConvertSearchQueryToXml(SearchQueryData searchQueryData, AsyncCallback callback, object asyncState);

        XElement EndConvertSearchQueryToXml(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/Impersonate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateResponse")]
        AccessTokenData Impersonate(string userName);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/Impersonate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateResponse")]
        IAsyncResult BeginImpersonate(string userName, AsyncCallback callback, object asyncState);

        AccessTokenData EndImpersonate(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithTokenCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithToken", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithTokenResponse")]
        void ImpersonateWithToken(AccessTokenData accessToken);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithToken", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithTokenResponse")]
        IAsyncResult BeginImpersonateWithToken(AccessTokenData accessToken, AsyncCallback callback, object asyncState);

        void EndImpersonateWithToken(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithClaimsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithClaims", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithClaimsResponse")]
        AccessTokenData ImpersonateWithClaims(ClaimData[] claims);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithClaims", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ImpersonateWithClaimsResponse")]
        IAsyncResult BeginImpersonateWithClaims(ClaimData[] claims, AsyncCallback callback, object asyncState);

        AccessTokenData EndImpersonateWithClaims(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/TerminateSessionCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(IsTerminating = true, IsInitiating = false, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/TerminateSession", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/TerminateSessionResponse")]
        void TerminateSession();

        [OperationContract(IsTerminating = true, IsInitiating = false, AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/TerminateSession", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/TerminateSessionResponse")]
        IAsyncResult BeginTerminateSession(AsyncCallback callback, object asyncState);

        void EndTerminateSession(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionIdCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionId", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionIdResponse")]
        string GetSessionId();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionId", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionIdResponse")]
        IAsyncResult BeginGetSessionId(AsyncCallback callback, object asyncState);

        string EndGetSessionId(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionContextDataCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionContextData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionContextDataResponse")]
        void SetSessionContextData(ApplicationData appData);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionContextData", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionContextDataResponse")]
        IAsyncResult BeginSetSessionContextData(ApplicationData appData, AsyncCallback callback, object asyncState);

        void EndSetSessionContextData(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionTransactionTimeoutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionTransactionTimeout", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionTransactionTimeoutResponse")]
        void SetSessionTransactionTimeout(int transactionTimeout);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionTransactionTimeout", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetSessionTransactionTimeoutResponse")]
        IAsyncResult BeginSetSessionTransactionTimeout(int transactionTimeout, AsyncCallback callback, object asyncState);

        void EndSetSessionTransactionTimeout(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionTransactionTimeoutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionTransactionTimeout", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionTransactionTimeoutResponse")]
        int GetSessionTransactionTimeout();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionTransactionTimeout", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/GetSessionTransactionTimeoutResponse")]
        IAsyncResult BeginGetSessionTransactionTimeout(AsyncCallback callback, object asyncState);

        int EndGetSessionTransactionTimeout(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StartCachingCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StartCaching", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StartCachingResponse")]
        bool StartCaching();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StartCaching", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StartCachingResponse")]
        IAsyncResult BeginStartCaching(AsyncCallback callback, object asyncState);

        bool EndStartCaching(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StopCachingCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StopCaching", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StopCachingResponse")]
        void StopCaching();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StopCaching", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/StopCachingResponse")]
        IAsyncResult BeginStopCaching(AsyncCallback callback, object asyncState);

        void EndStopCaching(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetWebDavUrlPrefixCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetWebDavUrlPrefix", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetWebDavUrlPrefixResponse")]
        void SetWebDavUrlPrefix(string prefix);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetWebDavUrlPrefix", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/SetWebDavUrlPrefixResponse")]
        IAsyncResult BeginSetWebDavUrlPrefix(string prefix, AsyncCallback callback, object asyncState);

        void EndSetWebDavUrlPrefix(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/EnlistInTransactionCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/EnlistInTransaction", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/EnlistInTransactionResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
        void EnlistInTransaction();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/EnlistInTransaction", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/EnlistInTransactionResponse")]
        IAsyncResult BeginEnlistInTransaction(AsyncCallback callback, object asyncState);

        void EndEnlistInTransaction(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ElevatePrivilegesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ElevatePrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ElevatePrivilegesResponse")]
        UserData ElevatePrivileges(Privileges privileges);

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ElevatePrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/ElevatePrivilegesResponse")]
        IAsyncResult BeginElevatePrivileges(Privileges privileges, AsyncCallback callback, object asyncState);

        UserData EndElevatePrivileges(IAsyncResult result);

        [FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/RestorePrivilegesCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/RestorePrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/RestorePrivilegesResponse")]
        UserData RestorePrivileges();

        [OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/RestorePrivileges", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201603/ISessionAwareCoreService/RestorePrivilegesResponse")]
        IAsyncResult BeginRestorePrivileges(AsyncCallback callback, object asyncState);

        UserData EndRestorePrivileges(IAsyncResult result);
    }
}
