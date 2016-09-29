using System;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tridion.ContentManager.CoreService.Client;

namespace Alchemy4Tridion.Plugins.Clients
{
    /// <summary>
    /// Represents possible end points for a core service client.
    /// </summary>
    public enum SessionAwareCoreServiceEndPoint
    {
        NetTcp2011,
        NetTcp2012,
        NetTcp2013,
        /**
         * SDL Web 8 end point
         */
        NetTcp201501
    }

    [ServiceContract(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201501", ConfigurationName = "Tridion.ContentManager.CoreService.Client.ISessionAwareCoreService", SessionMode = SessionMode.Required)]
    public interface ISessionAwareCoreService201501 : ISessionAwareCoreService
    {

    }

    public class SessionAwareCoreService201501 : SessionAwareCoreServiceClient, ISessionAwareCoreService201501
    {
        public SessionAwareCoreService201501(string endpointConfigName)
            : base(endpointConfigName)
        {

        }
    }

    /// <summary>
    /// Provides a wrapper of the Tridion SessionAwareCoreServiceClient using a safe implementation of IDisposable.
    /// You can use this client inside of a using statement, and calling its Close or Dispose method will safely
    /// close out the 
    /// </summary>
    /// <remarks>
    /// Shoutout to Eric Huiza (http://erichuiza.blogspot.com/2013/12/how-to-correctly-dispose-coreservice.html)
    /// </remarks>
    public class AlchemySessionAwareCoreServiceClient : IDisposable
    {
        /// <summary>
        /// Whether or not the dispose method has already been called.
        /// </summary>
        private bool isDisposed = false;

        /// <summary>
        /// Gets which entpoint was used to create this core service client.
        /// </summary>
        public SessionAwareCoreServiceEndPoint? ClientEndpoint
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the name of the user that the client was last impersonated with using the Impersonate method.
        /// </summary>
        public string ImpersonatedUsername
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the underlying core service client.
        /// </summary>
        public SessionAwareCoreServiceClient Client
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new SessionAwareCoreServiceClient using a default endpoint config name of netTcp_2013
        /// </summary>
        public AlchemySessionAwareCoreServiceClient()
            : this(SessionAwareCoreServiceEndPoint.NetTcp201501)
        {
            
        }

        /// <summary>
        /// Creates a new SessionAwareCoreServiceClient using the supplied endpoint.
        /// </summary>
        /// <param name="endPoint"></param>
        public AlchemySessionAwareCoreServiceClient(SessionAwareCoreServiceEndPoint endPoint)
        {
            ClientEndpoint = endPoint;
            string endPointConfigName = GetEnpointConfigurationName(endPoint);
            Client = new SessionAwareCoreService201501(endPointConfigName);
            //throw new Exception(Client.GetApiVersion() + " " + endPointConfigName);
        }

        /// <summary>
        /// Creates a new SessionAwareCoreServiceClient using the supplied end point configuration name (ie "netTcp_2013").
        /// </summary>
        /// <param name="endPointConfigurationName"></param>
        public AlchemySessionAwareCoreServiceClient(string endPointConfigurationName)
            : this(GetSessionAwareCoreServiceEndPoint(endPointConfigurationName))
        {

        }

        /// <summary>
        /// Gets the endpoint configuration name, defaulting to "netTcp_2013".
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public static string GetEnpointConfigurationName(SessionAwareCoreServiceEndPoint endPoint)
        {
            switch (endPoint)
            {
                case SessionAwareCoreServiceEndPoint.NetTcp2011:
                    return "netTcp_2011";
                case SessionAwareCoreServiceEndPoint.NetTcp2012:
                    return "netTcp_2012";
                case SessionAwareCoreServiceEndPoint.NetTcp201501:
                    return "netTcp_201501";
                default:
                    return "netTcp_2013";
            }
        }

        public static SessionAwareCoreServiceEndPoint GetSessionAwareCoreServiceEndPoint(string endpointConfigurationName)
        {
            switch (endpointConfigurationName)
            {
                case "netTcp_2011":
                    return SessionAwareCoreServiceEndPoint.NetTcp2011;
                case "netTcp_2012":
                    return SessionAwareCoreServiceEndPoint.NetTcp2012;
                case "netTcp_201501":
                    return SessionAwareCoreServiceEndPoint.NetTcp201501;
                default:
                    return SessionAwareCoreServiceEndPoint.NetTcp2013;
            }
        }

        /// <summary>
        /// Calls the dispose method.
        /// </summary>
        public void Close()
        {
            Dispose(true);
        }

        /// <summary>
        /// Implements IDisposable and disposes of the WCF client in a safe manner.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Disposes the client in a safe manner.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (Client != null)
            {
                if (!this.isDisposed && disposing)
                {
                    this.isDisposed = true;

                    try
                    {
                        if (Client.State != CommunicationState.Closed)
                        {
                            Client.Close();
                        }
                    }
                    catch (CommunicationException ex)
                    {
                        Client.Abort(); //The channel is aborted and the resources released.
                    }
                    catch (TimeoutException ex)
                    {
                        Client.Abort(); //The channel is aborted and the resources released.
                    }
                    catch (Exception ex)
                    {
                        Client.Abort(); // The channel is aborted and the resources released.
                    }
                }
            }
        }

        /// <summary>
        /// Impersonates the client as the given account username. Sets the ImpersonatedUsername as a reference
        /// to the last username that was impersonated.
        /// </summary>
        /// <param name="username">The account username.</param>
        /// <returns></returns>
        public UserData Impersonate(string username)
        {
            ImpersonatedUsername = username;

            return Client.Impersonate(username);
        }

        public async Task<UserData> ImpersonateAsync(string username)
        {
            ImpersonatedUsername = username;
            return await Task<UserData>.Factory.FromAsync(Client.BeginImpersonate, Client.EndImpersonate, username, null);
        }

        public KeywordData CopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions = null)
        {
            return Client.CopyToKeyword(sourceKeywordId, destinationId, readBackOptions);
        }

        public async Task<KeywordData> CopyToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions = null)
        {
            return await Task<KeywordData>.Factory.FromAsync(Client.BeginCopyToKeyword, Client.EndCopyToKeyword, sourceKeywordId, destinationId, readBackOptions, null);
        }

        public KeywordData MoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions = null)
        {
            return Client.MoveToKeyword(sourceKeywordId, destinationId, readBackOptions);
        }

        public async Task<KeywordData> MoveToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions = null)
        {
            return await Task<KeywordData>.Factory.FromAsync(Client.BeginMoveToKeyword, Client.EndMoveToKeyword, sourceKeywordId, destinationId, readBackOptions, null);
        }

        public TridionLanguageInfo[] GetTridionLanguages()
        {
            return Client.GetTridionLanguages();
        }

        public async Task<TridionLanguageInfo[]> GetTridionLanguagesAsync()
        {
            return await Task<TridionLanguageInfo[]>.Factory.FromAsync(Client.BeginGetTridionLanguages, Client.EndGetTridionLanguages, null);
        }

        public WorkflowScriptType[] GetListWorkflowScriptTypes()
        {
            return Client.GetListWorkflowScriptTypes();
        }

        public async Task<WorkflowScriptType[]> GetListWorkflowScriptTypesAsync()
        {
            return await Task<WorkflowScriptType[]>.Factory.FromAsync(Client.BeginGetListWorkflowScriptTypes, Client.EndGetListWorkflowScriptTypes, null);
        }

        public WorkItemData[] AddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions = null)
        {
            return Client.AddToWorkflow(subjectIds, activityInstanceId, readBackOptions);
        }

        public async Task<WorkItemData[]> AddToWorkflowAsync(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions = null)
        {
            return await Task<WorkItemData[]>.Factory.FromAsync(Client.BeginAddToWorkflow, Client.EndAddToWorkflow, subjectIds, activityInstanceId, readBackOptions, null);
        }

        public WorkItemData[] RemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions = null)
        {
            return Client.RemoveFromWorkflow(subjectIds, readBackOptions);
        }

        public async Task<WorkItemData[]> RemoveFromWorkflowAsync(string[] subjectIds, ReadOptions readBackOptions = null)
        {
            return await Task<WorkItemData[]>.Factory.FromAsync(Client.BeginRemoveFromWorkflow, Client.EndRemoveFromWorkflow, subjectIds, readBackOptions, null);
        }

        public OrganizationalItemData Lock(string organizationalItemId, ReadOptions readBackOptions = null)
        {
            return Client.Lock(organizationalItemId, readBackOptions);
        }

        public async Task<OrganizationalItemData> LockAsync(string organizationalItemId, ReadOptions readBackOptions = null)
        {
            return await Task<OrganizationalItemData>.Factory.FromAsync(Client.BeginLock, Client.EndLock, organizationalItemId, readBackOptions, null);
        }

        public OrganizationalItemData Unlock(string organizationalItemId, ReadOptions readBackOptions = null)
        {
            return Client.Unlock(organizationalItemId, readBackOptions);
        }

        public async Task<OrganizationalItemData> UnlockAsync(string organizationalItemId, ReadOptions readBackOptions = null)
        {
            return await Task<OrganizationalItemData>.Factory.FromAsync(Client.BeginUnlock, Client.EndUnlock, organizationalItemId, readBackOptions, null);
        }

        public ProcessInstanceData StartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions = null)
        {
            return Client.StartWorkflow(repositoryId, instruction, readBackOptions);
        }

        public async Task<ProcessInstanceData> StartWorkflowAsync(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions = null)
        {
            return await Task<ProcessInstanceData>.Factory.FromAsync(Client.BeginStartWorkflow, Client.EndStartWorkflow, repositoryId, instruction, readBackOptions, null);
        }

        public PublishTransactionData UndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority = null, ReadOptions readBackOptions = null)
        {
            return Client.UndoPublishTransaction(publishTransactionId, priority, readBackOptions);
        }

        public async Task<PublishTransactionData> UndoPublishTransactionAsync(string publishTransactionId, QueueMessagePriority? priority = null, ReadOptions readBackOptions = null)
        {
            return await Task<PublishTransactionData>.Factory.FromAsync(Client.BeginUndoPublishTransaction, Client.EndUndoPublishTransaction, publishTransactionId, priority, readBackOptions, null);
        }

        public ProcessDefinitionAssociationDictionary GetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType)
        {
            return Client.GetProcessDefinitionsForItems(itemIds, processDefinitionType);
        }

        public async Task<ProcessDefinitionAssociationDictionary> GetProcessDefinitionsForItemsAsync(string[] itemIds, ProcessDefinitionType processDefinitionType)
        {
            return await Task<ProcessDefinitionAssociationDictionary>.Factory.FromAsync(Client.BeginGetProcessDefinitionsForItems, Client.EndGetProcessDefinitionsForItems, itemIds, processDefinitionType, null);
        }

        public string GetSystemXsd(string filename)
        {
            return Client.GetSystemXsd(filename);
        }

        public async Task<string> GetSystemXsdAsync(string filename)
        {
            return await Task<string>.Factory.FromAsync(Client.BeginGetSystemXsd, Client.EndGetSystemXsd, filename, null);
        }

        public LinkToSchemaData[] GetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName)
        {
            return Client.GetSchemasByNamespaceUri(repositoryId, namespaceUri, rootElementName);
        }

        public async Task<LinkToSchemaData[]> GetSchemasByNamespaceUriAsync(string repositoryId, string namespaceUri, string rootElementName)
        {
            return await Task<LinkToSchemaData[]>.Factory.FromAsync(Client.BeginGetSchemasByNamespaceUri, Client.EndGetSchemasByNamespaceUri, repositoryId, namespaceUri, rootElementName, null);
        }

        public ValidationErrorData[] Validate(IdentifiableObjectData deltaData)
        {
            return Client.Validate(deltaData);
        }

        public async Task<ValidationErrorData[]> ValidateAsync(IdentifiableObjectData deltaData)
        {
            return await Task<ValidationErrorData[]>.Factory.FromAsync(Client.BeginValidate, Client.EndValidate, deltaData, null);
        }

        public BinaryContentData GetExternalBinaryContentData(string uri)
        {
            return Client.GetExternalBinaryContentData(uri);
        }

        public async Task<BinaryContentData> GetExternalBinaryContentDataAsync(string uri)
        {
            return await Task<BinaryContentData>.Factory.FromAsync(Client.BeginGetExternalBinaryContentData, Client.EndGetExternalBinaryContentData, uri, null);
        }

        public SynchronizationResult SynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions)
        {
            return Client.SynchronizeWithSchema(dataObject, synchronizeOptions);
        }

        public async Task<SynchronizationResult> SynchronizeWithSchemaAsync(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions)
        {
            return await Task<SynchronizationResult>.Factory.FromAsync(Client.BeginSynchronizeWithSchema, Client.EndSynchronizeWithSchema, dataObject, synchronizeOptions, null);
        }

        public SynchronizationResult SynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions)
        {
            return Client.SynchronizeWithSchemaAndUpdate(itemId, synchronizeOptions);
        }

        public async Task<SynchronizationResult> SynchronizeWithSchemaAndUpdateAsync(string itemId, SynchronizeOptions synchronizeOptions)
        {
            return await Task<SynchronizationResult>.Factory.FromAsync(Client.BeginSynchronizeWithSchemaAndUpdate, Client.EndSynchronizeWithSchemaAndUpdate, itemId, synchronizeOptions, null);
        }

        public void DecommissionPublicationTarget(string publicationTargetId)
        {
            Client.DecommissionPublicationTarget(publicationTargetId);
        }

        public async Task DecommissionPublicationTargetAsync(string publicationTargetId)
        {
            await Task.Factory.FromAsync(Client.BeginDecommissionPublicationTarget, Client.EndDecommissionPublicationTarget, publicationTargetId, null);
        }

        public string GetApiVersion()
        {
            return Client.GetApiVersion();
        }

        public async Task<string> GetApiVersionAsync()
        {
            return await Task<string>.Factory.FromAsync(Client.BeginGetApiVersion, Client.EndGetApiVersion, null);
        }

        public UserData GetCurrentUser()
        {
            return Client.GetCurrentUser();
        }

        public async Task<UserData> GetCurrentUserAsync()
        {
            return await Task<UserData>.Factory.FromAsync(Client.BeginGetCurrentUser, Client.EndGetCurrentUser, null);
        }

        public bool IsExistingObject(string id)
        {
            return Client.IsExistingObject(id);
        }

        public async Task<bool> IsExistingObjectAsync(string id)
        {
            return await Task<bool>.Factory.FromAsync(Client.BeginIsExistingObject, Client.EndIsExistingObject, id, null);
        }

        public string GetTcmUri(string baseUri, string contextRepositoryUri, uint? version = null)
        {
            return Client.GetTcmUri(baseUri, contextRepositoryUri, version);
        }

        public async Task<string> GetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version = null)
        {
            return await Task<string>.Factory.FromAsync(Client.BeginGetTcmUri, Client.EndGetTcmUri, baseUri, contextRepositoryUri, version, null);
        }

        public string TryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version = null)
        {
            return Client.TryGetTcmUri(baseUri, contextRepositoryUri, version);
        }

        public async Task<string> TryGetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version = null)
        {
            return await Task<string>.Factory.FromAsync(Client.BeginTryGetTcmUri, Client.EndTryGetTcmUri, baseUri, contextRepositoryUri, version, null);
        }

        public IdentifiableObjectData Read(string id)
        {
            return Client.Read(id, null);
        }

        public IdentifiableObjectData Read(string id, ReadOptions readOptions)
        {
            return Client.Read(id, readOptions);
        }

        public async Task<IdentifiableObjectData> ReadAsync(string id, ReadOptions readOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Client.BeginRead, Client.EndRead, id, readOptions, null);
        }

        public IdentifiableObjectData TryRead(string id, ReadOptions readOptions = null)
        {
            return Client.TryRead(id, readOptions);
        }

        public async Task<IdentifiableObjectData> TryReadAsync(string id, ReadOptions readOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Client.BeginTryRead, Client.EndTryRead, id, readOptions, null);
        }

        public SchemaFieldsData ReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions = null)
        {
            return Client.ReadSchemaFields(schemaId, expandEmbeddedFields, readOptions);
        }

        public async Task<SchemaFieldsData> ReadSchemaFieldsAsync(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions = null)
        {
            return await Task<SchemaFieldsData>.Factory.FromAsync(Client.BeginReadSchemaFields, Client.EndReadSchemaFields, schemaId, expandEmbeddedFields, readOptions, null);
        }

        public XElement ConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData)
        {
            return Client.ConvertSchemaFieldsToXsd(schemaFieldsData);
        }

        public async Task<XElement> ConvertSchemaFieldsToXsdAsync(SchemaFieldsData schemaFieldsData)
        {
            return await Task<XElement>.Factory.FromAsync(Client.BeginConvertSchemaFieldsToXsd, Client.EndConvertSchemaFieldsToXsd, schemaFieldsData, null);
        }

        public IdentifiableObjectData Save(IdentifiableObjectData deltaData, ReadOptions readBackOptions = null)
        {
            return Client.Save(deltaData, readBackOptions);
        }

        public async Task<IdentifiableObjectData> SaveAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Client.BeginSave, Client.EndSave, deltaData, readBackOptions, null);
        }

        public void Delete(string id)
        {
            Client.Delete(id);
        }

        public async Task DeleteAsync(string id)
        {
            await Task.Factory.FromAsync(Client.BeginDelete, Client.EndDelete, id, null);
        }

        public void DeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
        {
            Client.DeleteTaxonomyNode(id, deleteTaxonomyNodeMode);
        }

        public async Task DeleteTaxonomyNodeAsync(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
        {
            await Task.Factory.FromAsync(Client.BeginDeleteTaxonomyNode, Client.EndDeleteTaxonomyNode, id, deleteTaxonomyNodeMode, null);
        }

        public IdentifiableObjectData GetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions = null)
        {
            return Client.GetDefaultData(itemType, containerId, readOptions);
        }

        public async Task<IdentifiableObjectData> GetDefaultDataAsync(ItemType itemType, string containerId, ReadOptions readOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Client.BeginGetDefaultData, Client.EndGetDefaultData, itemType, containerId, readOptions, null);
        }

        public RepositoryLocalObjectData Move(string id, string destinationId, ReadOptions readBackOptions = null)
        {
            return Client.Move(id, destinationId, readBackOptions);
        }

        public async Task<RepositoryLocalObjectData> MoveAsync(string id, string destinationId, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Client.BeginMove, Client.EndMove, id, destinationId, readBackOptions, null);
        }

        public RepositoryLocalObjectData Copy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions = null)
        {
            return Client.Copy(id, destinationId, makeUnique, readBackOptions);
        }

        public async Task<RepositoryLocalObjectData> CopyAsync(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Client.BeginCopy(id, destinationId, makeUnique, readBackOptions, null, null), Client.EndCopy);
        }

        public InstanceData GetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions = null)
        {
            return Client.GetInstanceData(schemaId, containerItemId, readOptions);
        }

        public async Task<InstanceData> GetInstanceDataAsync(string schemaId, string containerItemId, ReadOptions readOptions = null)
        {
            return await Task<InstanceData>.Factory.FromAsync(Client.BeginGetInstanceData, Client.EndGetInstanceData, schemaId, containerItemId, readOptions, null);
        }

        public IdentifiableObjectData TryCheckOut(string id, ReadOptions readBackOptions = null)
        {
            return Client.TryCheckOut(id, readBackOptions);
        }

        public async Task<IdentifiableObjectData> TryCheckOutAsync(string id, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Client.BeginTryCheckOut, Client.EndTryCheckOut, id, readBackOptions, null);
        }

        public VersionedItemData CheckOut(string id, bool permanentLock = false, ReadOptions readBackOptions = null)
        {
            return Client.CheckOut(id, permanentLock, readBackOptions);
        }

        public async Task<VersionedItemData> CheckOutAsync(string id, bool permanentLock = false, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Client.BeginCheckOut, Client.EndCheckOut, id, permanentLock, readBackOptions, null);
        }

        public VersionedItemData CheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions = null)
        {
            return Client.CheckIn(id, removePermanentLock, userComment, readBackOptions);
        }

        public async Task<VersionedItemData> CheckInAsync(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Client.BeginCheckIn(id, removePermanentLock, userComment, readBackOptions, null, null), Client.EndCheckIn);
        }

        public IdentifiableObjectData Update(IdentifiableObjectData deltaData, ReadOptions readBackOptions = null)
        {
            return Client.Update(deltaData, readBackOptions);
        }

        public async Task<IdentifiableObjectData> UpdateAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Client.BeginUpdate, Client.EndUpdate, deltaData, readBackOptions, null);
        }

        public IdentifiableObjectData Create(IdentifiableObjectData data, ReadOptions readBackOptions = null)
        {
            return Client.Create(data, readBackOptions);
        }

        public async Task<IdentifiableObjectData> CreateAsync(IdentifiableObjectData data, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Client.BeginCreate, Client.EndCreate, data, readBackOptions, null);
        }

        public VersionedItemData UndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions = null)
        {
            return Client.UndoCheckOut(id, permanentLock, readBackOptions);
        }

        public async Task<VersionedItemData> UndoCheckOutAsync(string id, bool permanentLock, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Client.BeginUndoCheckOut, Client.EndUndoCheckOut, id, permanentLock, readBackOptions, null);
        }

        public VersionedItemData Rollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions = null)
        {
            return Client.Rollback(id, deleteVersions, comment, readBackOptions);
        }

        public async Task<VersionedItemData> RollbackAsync(string id, bool deleteVersions, string comment, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Client.BeginRollback(id, deleteVersions, comment, readBackOptions, null, null), Client.EndRollback);
        }

        public RepositoryLocalObjectData Localize(string id, ReadOptions readBackOptions = null)
        {
            return Client.Localize(id, readBackOptions);
        }

        public async Task<RepositoryLocalObjectData> LocalizeAsync(string id, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Client.BeginLocalize, Client.EndLocalize, id, readBackOptions, null);
        }

        public RepositoryLocalObjectData UnLocalize(string id, ReadOptions readBackOptions = null)
        {
            return Client.UnLocalize(id, readBackOptions);
        }

        public async Task<RepositoryLocalObjectData> UnLocalizeAsync(string id, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Client.BeginUnLocalize, Client.EndUnLocalize, id, readBackOptions, null);
        }

        public TemplateType[] GetListTemplateTypes(ItemType? itemType = null)
        {
            return Client.GetListTemplateTypes(itemType);
        }

        public async Task<TemplateType[]> GetListTemplateTypesAsync(ItemType? itemType = null)
        {
            return await Task<TemplateType[]>.Factory.FromAsync(Client.BeginGetListTemplateTypes, Client.EndGetListTemplateTypes, itemType, null);
        }

        public PublicationType[] GetListPublicationTypes()
        {
            return Client.GetListPublicationTypes();
        }
        
        public async Task<PublicationType[]> GetListPublicationTypesAsync()
        {
            return await Task<PublicationType[]>.Factory.FromAsync(Client.BeginGetListPublicationTypes, Client.EndGetListPublicationTypes, null);
        }

        public XElement GetSystemWideListXml(SystemWideListFilterData filter)
        {
            return Client.GetSystemWideListXml(filter);
        }

        public async Task<XElement> GetSystemWideListXmlAsync(SystemWideListFilterData filter)
        {
            return await Task<XElement>.Factory.FromAsync(Client.BeginGetSystemWideListXml, Client.EndGetSystemWideListXml, filter, null);
        }

        public IdentifiableObjectData[] GetSystemWideList(SystemWideListFilterData filter)
        {
            return Client.GetSystemWideList(filter);
        }

        public async Task<IdentifiableObjectData[]> GetSystemWideListAsync(SystemWideListFilterData filter)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Client.BeginGetSystemWideList, Client.EndGetSystemWideList, filter, null);
        }

        public XElement GetListXml(string id, SubjectRelatedListFilterData filter)
        {
            return Client.GetListXml(id, filter);
        }

        public async Task<XElement> GetListXmlAsync(string id, SubjectRelatedListFilterData filter)
        {
            return await Task<XElement>.Factory.FromAsync(Client.BeginGetListXml, Client.EndGetListXml, id, filter, null);
        }

        public IdentifiableObjectData[] GetList(string id, SubjectRelatedListFilterData filter)
        {
            return Client.GetList(id, filter);
        }

        public async Task<IdentifiableObjectData[]> GetListAsync(string id, SubjectRelatedListFilterData filter)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Client.BeginGetList, Client.EndGetList, id, filter, null);
        }

        public string[] GetListDirectoryServiceNames()
        {
            return Client.GetListDirectoryServiceNames();
        }

        public async Task<string[]> GetListDirectoryServiceNamesAsync()
        {
            return await Task<string[]>.Factory.FromAsync(Client.BeginGetListDirectoryServiceNames, Client.EndGetListDirectoryServiceNames, null);
        }

        public WindowsUser[] GetListWindowsDomainUsers(string domainName)
        {
            return Client.GetListWindowsDomainUsers(domainName);
        }

        public async Task<WindowsUser[]> GetListWindowsDomainUsersAsync(string domainName)
        {
            return await Task<WindowsUser[]>.Factory.FromAsync(Client.BeginGetListWindowsDomainUsers, Client.EndGetListWindowsDomainUsers, domainName, null);
        }

        public DirectoryServiceUser[] GetListDirectoryServiceAllUsers(string directoryServiceName)
        {
            return Client.GetListDirectoryServiceAllUsers(directoryServiceName);
        }

        public async Task<DirectoryServiceUser[]> GetListDirectoryServiceAllUsersAsync(string directoryServiceName)
        {
            return await Task<DirectoryServiceUser[]>.Factory.FromAsync(Client.BeginGetListDirectoryServiceAllUsers, Client.EndGetListDirectoryServiceAllUsers, directoryServiceName, null);
        }

        public DirectoryServiceUser[] GetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN)
        {
            return Client.GetListDirectoryServiceGroupMembers(directoryServiceName, groupDN);
        }

        public async Task<DirectoryServiceUser[]> GetListDirectoryServiceGroupMembersAsync(string directoryServiceName, string groupDN)
        {
            return await Task<DirectoryServiceUser[]>.Factory.FromAsync(Client.BeginGetListDirectoryServiceGroupMembers, Client.EndGetListDirectoryServiceGroupMembers, directoryServiceName, groupDN, null);
        }

        public DirectoryServiceUser[] GetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter)
        {
            return Client.GetListDirectoryServiceUsers(directoryServiceName, filter);
        }

        public async Task<DirectoryServiceUser[]> GetListDirectoryServiceUsersAsync(string directoryServiceName, DirectoryUsersFilter filter)
        {
            return await Task<DirectoryServiceUser[]>.Factory.FromAsync(Client.BeginGetListDirectoryServiceUsers, Client.EndGetListDirectoryServiceUsers, directoryServiceName, filter, null);
        }

        public ClassificationInfoData Classify(string id, string[] keywordIds, ReadOptions readOptions = null)
        {
            return Client.Classify(id, keywordIds, readOptions);
        }

        public async Task<ClassificationInfoData> ClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions = null)
        {
            return await Task<ClassificationInfoData>.Factory.FromAsync(Client.BeginClassify, Client.EndClassify, id, keywordIds, readOptions, null);
        }

        public ClassificationInfoData UnClassify(string id, string[] keywordIds, ReadOptions readOptions = null)
        {
            return Client.UnClassify(id, keywordIds, readOptions);
        }

        public async Task<ClassificationInfoData> UnClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions = null)
        {
            return await Task<ClassificationInfoData>.Factory.FromAsync(Client.BeginUnClassify, Client.EndUnClassify, id, keywordIds, readOptions, null);
        }

        public ClassificationInfoData ReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions = null)
        {
            return Client.ReClassify(id, keywordIdsToRemove, keywordIdsToAdd, readOptions);
        }

        public async Task<ClassificationInfoData> ReClassifyAsync(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions = null)
        {
            return await Task<ClassificationInfoData>.Factory.FromAsync(Client.BeginReClassify(id, keywordIdsToRemove, keywordIdsToAdd, readOptions, null, null), Client.EndReClassify);
        }

        public ActivityInstanceData StartActivity(string activityInstanceId, ReadOptions readBackOptions = null)
        {
            return Client.StartActivity(activityInstanceId, readBackOptions);
        }

        public async Task<ActivityInstanceData> StartActivityAsync(string activityInstanceId, ReadOptions readBackOptions = null)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Client.BeginStartActivity, Client.EndStartActivity, activityInstanceId, readBackOptions, null);
        }

        public ActivityInstanceData SuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions = null)
        {
            return Client.SuspendActivity(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions);
        }

        public async Task<ActivityInstanceData> SuspendActivityAsync(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions = null)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Client.BeginSuspendActivity(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions, null, null), Client.EndSuspendActivity);
        }

        public ActivityInstanceData RestartActivity(string activityInstanceId, ReadOptions readBackOptions = null)
        {
            return Client.RestartActivity(activityInstanceId, readBackOptions);
        }

        public async  Task<ActivityInstanceData> RestartActivityAsync(string activityInstanceId, ReadOptions readBackOptions = null)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Client.BeginRestartActivity, Client.EndRestartActivity, activityInstanceId, readBackOptions, null);
        }

        public ActivityInstanceData ReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions = null)
        {
            return Client.ReAssignActivity(activityInstanceId, newAssigneeId, readBackOptions);
        }

        public async Task<ActivityInstanceData> ReAssignActivityAsync(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions = null)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Client.BeginReAssignActivity, Client.EndReAssignActivity, activityInstanceId, newAssigneeId, readBackOptions, null);
        }

        public ActivityInstanceData FinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions = null)
        {
            return Client.FinishActivity(activityInstanceId, activityFinishData, readOptions);
        }

        public async Task<ActivityInstanceData> FinishActivityAsync(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions = null)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Client.BeginFinishActivity, Client.EndFinishActivity, activityInstanceId, activityFinishData, readOptions, null);
        }

        public ProcessHistoryData ForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions = null)
        {
            return Client.ForceFinishProcess(processInstanceId, approvalStatusId, readOptions);
        }

        public async Task<ProcessHistoryData> ForceFinishProcessAsync(string processInstanceId, string approvalStatusId, ReadOptions readOptions = null)
        {
            return await Task<ProcessHistoryData>.Factory.FromAsync( Client.BeginForceFinishProcess, Client.EndForceFinishProcess, processInstanceId, approvalStatusId, readOptions, null);
        }
        
        public ActivityInstanceData ResumeActivity(string activityInstanceId, ReadOptions readOptions = null)
        {
            return Client.ResumeActivity(activityInstanceId, readOptions);
        }

        public async Task<ActivityInstanceData> ResumeActivityActivity(string activityInstanceId, ReadOptions readOptions = null)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Client.BeginResumeActivity, Client.EndResumeActivity, activityInstanceId, readOptions, null);
        }

        public QueueMessageData[] GetListQueueMessages(int queueId)
        {
            return Client.GetListQueueMessages(queueId);
        }

        public async Task<QueueMessageData[]> GetListQueueMessagesAsync(int queueId)
        {
            return await Task<QueueMessageData[]>.Factory.FromAsync(Client.BeginGetListQueueMessages, Client.EndGetListQueueMessages, queueId, null);
        }

        public void PurgeQueue(int queueId)
        {
            Client.PurgeQueue(queueId);
        }

        public async Task PurgeQueueAsync(int queueId)
        {
            await Task.Factory.FromAsync(Client.BeginPurgeQueue, Client.EndPurgeQueue, queueId, null);
        }

        public QueueData[] GetListQueues()
        {
            return Client.GetListQueues();
        }

        public async Task<QueueData[]> GetListQueuesAsync()
        {
            return await Task<QueueData[]>.Factory.FromAsync(Client.BeginGetListQueues, Client.EndGetListQueues, null);
        }

        public ApplicationData ReadApplicationData(string subjectId, string applicationId)
        {
            return Client.ReadApplicationData(subjectId, applicationId);
        }

        public async Task<ApplicationData> ReadApplicationDataAsync(string subjectId, string applicationId)
        {
            return await Task<ApplicationData>.Factory.FromAsync(Client.BeginReadApplicationData, Client.EndReadApplicationData, subjectId, applicationId, null);
        }

        public ApplicationData[] ReadAllApplicationData(string subjectId)
        {
            return Client.ReadAllApplicationData(subjectId);
        }

        public async Task<ApplicationData[]> ReadAllApplicationDataAsync(string subjectId)
        {
            return await Task<ApplicationData[]>.Factory.FromAsync(Client.BeginReadAllApplicationData, Client.EndReadAllApplicationData, subjectId, null);
        }

        public void SaveApplicationData(string subjectId, ApplicationData[] applicationData)
        {
            Client.SaveApplicationData(subjectId, applicationData);
        }

        public async Task SaveApplicationDataAsync(string subjectId, ApplicationData[] applicationData)
        {
            await Task.Factory.FromAsync(Client.BeginSaveApplicationData, Client.EndSaveApplicationData, subjectId, applicationData, null);
        }

        public void DeleteApplicationData(string subjectId, string applicationId)
        {
            Client.DeleteApplicationData(subjectId, applicationId);
        }

        public async Task DeleteApplicationDataAsync(string subjectId, string applicationId)
        {
            await Task.Factory.FromAsync(Client.BeginDeleteApplicationData, Client.EndDeleteApplicationData, subjectId, applicationId, null);
        }

        public string[] GetApplicationIds()
        {
            return Client.GetApplicationIds();
        }

        public async Task<string[]> GetApplicationIdsAsync()
        {
            return await Task<string[]>.Factory.FromAsync(Client.BeginGetApplicationIds, Client.EndGetApplicationIds, null);
        }

        public void PurgeApplicationData(string applicationId)
        {
            Client.PurgeApplicationData(applicationId);
        }

        public async Task PurgeApplicationDataAsync(string applicationId)
        {
           await Task.Factory.FromAsync(Client.BeginPurgeApplicationData, Client.EndPurgeApplicationData, applicationId, null);
        }

        public PredefinedBatchOperation? ParsePredefinedBatchOperation(string operation)
        {
            return Client.ParsePredefinedBatchOperation(operation);
        }

        public async Task<PredefinedBatchOperation?> ParsePredefinedBatchOperationAsync(string operation)
        {
            return await Task<PredefinedBatchOperation?>.Factory.FromAsync(Client.BeginParsePredefinedBatchOperation, Client.EndParsePredefinedBatchOperation, operation, null);
        }

        public string GetPredefinedBatchOperationName(PredefinedBatchOperation operation)
        {
            return Client.GetPredefinedBatchOperationName(operation);
        }

        public async Task<string> GetPredefinedBatchOperationNameAsync(PredefinedBatchOperation operation)
        {
            return await Task<string>.Factory.FromAsync(Client.BeginGetPredefinedBatchOperationName, Client.EndGetPredefinedBatchOperationName, operation, null);
        }

        public PublishContextData[] ResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targets, ReadOptions readOptions = null)
        {
            return Client.ResolveItems(ids, resolveInstruction, targets, readOptions);
        }

        public async Task<PublishContextData[]> ResolveItemsAsync(string[] ids, ResolveInstructionData resolveInstruction, string[] targets, ReadOptions readOptions = null)
        {
            return await Task<PublishContextData[]>.Factory.FromAsync(Client.BeginResolveItems(ids, resolveInstruction, targets, readOptions, null, null), Client.EndResolveItems);
        }

        public XElement GetSearchResultsXml(SearchQueryData filter)
        {
            return Client.GetSearchResultsXml(filter);
        }

        public async Task<XElement> GetSearchResultsXmlAsync(SearchQueryData filter)
        {
            return await Task<XElement>.Factory.FromAsync(Client.BeginGetSearchResultsXml, Client.EndGetSearchResultsXml, filter, null);
        }

        public XElement GetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return Client.GetSearchResultsXmlPaged(filter, startRowIndex, maxRows);
        }

        public async Task<XElement> GetSearchResultsXmlPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return await Task<XElement>.Factory.FromAsync(Client.BeginGetSearchResultsXmlPaged, Client.EndGetSearchResultsXmlPaged, filter, startRowIndex, maxRows, null);
        }

        public IdentifiableObjectData[] GetSearchResults(SearchQueryData filter)
        {
            return Client.GetSearchResults(filter);
        }

        public async Task<IdentifiableObjectData[]> GetSearchResultsAsync(SearchQueryData filter)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Client.BeginGetSearchResults, Client.EndGetSearchResults, filter, null);
        }

        public IdentifiableObjectData[] GetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return Client.GetSearchResultsPaged(filter, startRowIndex, maxRows);
        }

        public async Task<IdentifiableObjectData[]> GetSearchResultsPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Client.BeginGetSearchResultsPaged, Client.EndGetSearchResultsPaged, filter, startRowIndex, maxRows, null);
        }

        public RenderedItemData RenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetId)
        {
            return Client.RenderItem(itemId, templateId, publishInstruction, publicationTargetId);
        }

        public async Task<RenderedItemData> RenderItemAsync(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetId)
        {
            return await Task<RenderedItemData>.Factory.FromAsync(Client.BeginRenderItem(itemId, templateId, publishInstruction, publicationTargetId, null, null), Client.EndRenderItem);
        }

        public RenderedItemData PreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId)
        {
            return Client.PreviewItem(itemData, templateData, publishInstruction, publicationTargetId);
        }

        public async Task<RenderedItemData> PreviewItemAsync(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId)
        {
            return await Task<RenderedItemData>.Factory.FromAsync(Client.BeginPreviewItem(itemData, templateData, publishInstruction, publicationTargetId, null, null), Client.EndPreviewItem);
        }

        public PublishTransactionData[] Publish(string[] ids, PublishInstructionData publishInstruction, string[] targets, PublishPriority? priority = null, ReadOptions readOptions = null)
        {
            return Client.Publish(ids, publishInstruction, targets, priority, readOptions);
        }

        public async Task<PublishTransactionData[]> PublishAsync(string[] ids, PublishInstructionData publishInstruction, string[] targets, PublishPriority? priority = null, ReadOptions readOptions = null)
        {
            return await Task<PublishTransactionData[]>.Factory.FromAsync(Client.BeginPublish(ids, publishInstruction, targets, priority, readOptions, null, null), Client.EndPublish);
        }

        public PublishTransactionData[] UnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targets, PublishPriority? priority = null, ReadOptions readOptions = null)
        {
            return Client.UnPublish(ids, unPublishInstruction, targets, priority, readOptions);
        }

        public async Task<PublishTransactionData[]> UnPublishAsync(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targets, PublishPriority? priority = null, ReadOptions readOptions = null)
        {
            return await Task<PublishTransactionData[]>.Factory.FromAsync(Client.BeginUnPublish(ids, unPublishInstruction, targets, priority, readOptions, null, null), Client.EndUnPublish);
        }

        public bool IsPublished(string itemId, string publicationTargetId, bool isPublishedInContext)
        {
            return Client.IsPublished(itemId, publicationTargetId, isPublishedInContext);
        }

        public async Task<bool> IsPublishedAsync(string itemId, string publicationTargetId, bool isPublishedInContext)
        {
            return await Task<bool>.Factory.FromAsync(Client.BeginIsPublished, Client.EndIsPublished, itemId, publicationTargetId, isPublishedInContext, null);
        }

        public RenderedItemData GetWorkItemSnapshot(string workItemId)
        {
            return Client.GetWorkItemSnapshot(workItemId);
        }

        public async Task<RenderedItemData> GetWorkItemSnapshotAsync(string workItemId)
        {
            return await Task<RenderedItemData>.Factory.FromAsync(Client.BeginGetWorkItemSnapshot, Client.EndGetWorkItemSnapshot, workItemId, null);
        }

        public PublishInfoData[] GetListPublishInfo(string itemId)
        {
            return Client.GetListPublishInfo(itemId);
        }

        public async Task<PublishInfoData[]> GetListPublishInfoAsync(string itemId)
        {
            return await Task<PublishInfoData[]>.Factory.FromAsync(Client.BeginGetListPublishInfo, Client.EndGetListPublishInfo, itemId, null);
        }

        public ActionFlags CastActions(int numericActions)
        {
            return Client.CastActions(numericActions);
        }

        public async Task<ActionFlags> CastActionsAsync(int numericActions)
        {
            return await Task<ActionFlags>.Factory.FromAsync(Client.BeginCastActions, Client.EndCastActions, numericActions, null);
        }

        public void ValidateXml(IdentifiableObjectData data)
        {
            Client.ValidateXml(data);
        }

        public async Task ValidateXmlAsync(IdentifiableObjectData data)
        {
            await Task.Factory.FromAsync(Client.BeginValidateXml, Client.EndValidateXml, data, null);
        }

        public bool IsValidTridionWebSchemaXml(SchemaData data)
        {
            return Client.IsValidTridionWebSchemaXml(data);
        }

        public async Task<bool> IsValidTridionWebSchemaXmlAsync(SchemaData data)
        {
            return await Task<bool>.Factory.FromAsync(Client.BeginIsValidTridionWebSchemaXml, Client.EndIsValidTridionWebSchemaXml, data, null);
        }

        public ArrayOfTcmUri GetSubjectIdsWithApplicationData(string applicationId)
        {
            return Client.GetSubjectIdsWithApplicationData(applicationId);
        }

        public async Task<ArrayOfTcmUri> GetSubjectIdsWithApplicationDataAsync(string applicationId)
        {
            return await Task<ArrayOfTcmUri>.Factory.FromAsync(Client.BeginGetSubjectIdsWithApplicationData, Client.EndGetSubjectIdsWithApplicationData, applicationId, null);
        }

        public ApplicationDataDictionary ReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds)
        {
            return Client.ReadApplicationDataForSubjectsIds(subjectIds, applicationIds);
        }

        public async Task<ApplicationDataDictionary> ReadApplicationDataForSubjectsIdsAsync(string[] subjectIds, string[] applicationIds)
        {
            return await Task<ApplicationDataDictionary>.Factory.FromAsync(Client.BeginReadApplicationDataForSubjectsIds, Client.EndReadApplicationDataForSubjectsIds, subjectIds, applicationIds, null);
        }

        public SecurityDescriptorDataDictionary GetSecurityDescriptorsForSubjectsIds(string[] subjectIds)
        {
            return Client.GetSecurityDescriptorsForSubjectsIds(subjectIds);
        }

        public async Task<SecurityDescriptorDataDictionary> GetSecurityDescriptorsForSubjectsIdsAsync(string[] subjectIds)
        {
            return await Task<SecurityDescriptorDataDictionary>.Factory.FromAsync(Client.BeginGetSecurityDescriptorsForSubjectsIds, Client.EndGetSecurityDescriptorsForSubjectsIds, subjectIds, null);
        }

        public SecurityDescriptorDataDictionary GetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds)
        {
            return Client.GetContentSecurityDescriptorsForOrgItemIds(organizationalItemIds);
        }

        public async Task<SecurityDescriptorDataDictionary> GetContentSecurityDescriptorsForOrgItemIdsAsync(string[] organizationalItemIds)
        {
            return await Task<SecurityDescriptorDataDictionary>.Factory.FromAsync(Client.BeginGetContentSecurityDescriptorsForOrgItemIds, Client.EndGetContentSecurityDescriptorsForOrgItemIds, organizationalItemIds, null);
        }

        public void ReIndex(string id)
        {
            Client.ReIndex(id);
        }

        public async Task ReIndexAsync(string id)
        {
            await Task.Factory.FromAsync(Client.BeginReIndex, Client.EndReIndex, id, null);
        }

        public PredefinedQueue? CastPredefinedQueue(int queueId)
        {
            return Client.CastPredefinedQueue(queueId);
        }

        public async Task<PredefinedQueue?> CastPredefinedQueueAsync(int queueId)
        {
            return await Task<PredefinedQueue?>.Factory.FromAsync(Client.BeginCastPredefinedQueue, Client.EndCastPredefinedQueue, queueId, null);
        }

        public int PurgeOldVersions(PurgeOldVersionsInstructionData instruction)
        {
            return Client.PurgeOldVersions(instruction);
        }

        public async Task<int> PurgeOldVersionsAsync(PurgeOldVersionsInstructionData instruction)
        {
            return await Task<int>.Factory.FromAsync(Client.BeginPurgeOldVersions, Client.EndPurgeOldVersions, instruction, null);
        }

        public XElement GetListExternalLinks(string id)
        {
            return Client.GetListExternalLinks(id);
        }

        public async Task<XElement> GetListExternalLinksAsync(string id)
        {
            return await Task<XElement>.Factory.FromAsync(Client.BeginGetListExternalLinks, Client.EndGetListExternalLinks, id, null);
        }

        public SearchQueryData ConvertXmlToSearchQuery(XElement searchQueryXml)
        {
            return Client.ConvertXmlToSearchQuery(searchQueryXml);
        }

        public async Task<SearchQueryData> ConvertXmlToSearchQueryAsync(XElement searchQueryXml)
        {
            return await Task<SearchQueryData>.Factory.FromAsync(Client.BeginConvertXmlToSearchQuery, Client.EndConvertXmlToSearchQuery, searchQueryXml, null);
        }

        public XElement ConvertSearchQueryToXml(SearchQueryData searchQueryData)
        {
            return Client.ConvertSearchQueryToXml(searchQueryData);
        }

        public async Task<XElement> ConvertSearchQueryToXmlAsync(SearchQueryData searchQueryData)
        {
            return await Task<XElement>.Factory.FromAsync(Client.BeginConvertSearchQueryToXml, Client.EndConvertSearchQueryToXml, searchQueryData, null);
        }

        public SchemaData GetVirtualFolderTypeSchema(string namespaceUri)
        {
            return Client.GetVirtualFolderTypeSchema(namespaceUri);
        }

        public async Task<SchemaData> GetVirtualFolderTypeSchemaAsync(string namespaceUri)
        {
            return await Task<SchemaData>.Factory.FromAsync(Client.BeginGetVirtualFolderTypeSchema, Client.EndGetVirtualFolderTypeSchema, namespaceUri, null);
        }

        public TridionEnumValue[] GetEnumValues(string type)
        {
            return Client.GetEnumValues(type);
        }

        public async Task<TridionEnumValue[]> GetEnumValuesAsync(string type)
        {
            return await Task<TridionEnumValue[]>.Factory.FromAsync(Client.BeginGetEnumValues, Client.EndGetEnumValues, type, null);
        }

        public BundleTypeData[] ResolveBundleTypes(string[] itemIds, bool pruneTree)
        {
            return Client.ResolveBundleTypes(itemIds, pruneTree);
        }

        public async Task<BundleTypeData[]> ResolveBundleTypesAsync(string[] itemIds, bool pruneTree)
        {
            return await Task<BundleTypeData[]>.Factory.FromAsync(Client.BeginResolveBundleTypes, Client.EndResolveBundleTypes, itemIds, pruneTree, null);
        }

        public void TerminateSession()
        {
            Client.TerminateSession();
        }

        public async Task TerminateSessionAsync()
        {
            await Task.Factory.FromAsync(Client.BeginTerminateSession, Client.EndTerminateSession, null);
        }

        public string GetSessionId()
        {
            return Client.GetSessionId();
        }

        public async Task<string> GetSessionIdAsync()
        {
            return await Task<string>.Factory.FromAsync(Client.BeginGetSessionId, Client.EndGetSessionId, null);
        }

        public void SetSessionContextData(ApplicationData appData)
        {
            Client.SetSessionContextData(appData);
        }

        public async Task SetSessionContextDataAsync(ApplicationData appData)
        {
            await Task.Factory.FromAsync(Client.BeginSetSessionContextData, Client.EndSetSessionContextData, appData, null);
        }

        public void SetSessionTransactionTimeout(int transactionTimeout)
        {
            Client.SetSessionTransactionTimeout(transactionTimeout);
        }

        public async Task SetSessionTransactionTimeoutAsync(int transactionTimeout)
        {
            await Task.Factory.FromAsync(Client.BeginSetSessionTransactionTimeout, Client.EndSetSessionTransactionTimeout, transactionTimeout, null);
        }

        public int GetSessionTransactionTimeout()
        {
            return Client.GetSessionTransactionTimeout();
        }

        public async Task<int> GetSessionTransactionTimeoutAsync()
        {
            return await Task<int>.Factory.FromAsync(Client.BeginGetSessionTransactionTimeout, Client.EndGetSessionTransactionTimeout, null);
        }

        public bool StartCaching()
        {
            return Client.StartCaching();
        }

        public async Task<bool> StartCachingAsync()
        {
            return await Task<bool>.Factory.FromAsync(Client.BeginStartCaching, Client.EndStartCaching, null);
        }

        public void StopCaching()
        {
            Client.StopCaching();
        }

        public async Task StopCachingAsync()
        {
            await Task.Factory.FromAsync(Client.BeginStopCaching, Client.EndStopCaching, null);
        }

        public void SetWebDavUrlPrefix(string prefix)
        {
            Client.SetWebDavUrlPrefix(prefix);
        }

        public async Task SetWebDavUrlPrefixAsync(string prefix)
        {
            await Task.Factory.FromAsync(Client.BeginSetWebDavUrlPrefix, Client.EndSetWebDavUrlPrefix, prefix, null);
        }

        public void EnlistInTransaction()
        {
            Client.EnlistInTransaction();
        }

        public async Task EnlistInTransactionAsync()
        {
            await Task.Factory.FromAsync(Client.BeginEnlistInTransaction, Client.EndEnlistInTransaction, null);
        }

        /// <summary>
        /// Finalizer
        /// </summary>
        ~AlchemySessionAwareCoreServiceClient()
        {
            Dispose(false);
        }
    }
}
