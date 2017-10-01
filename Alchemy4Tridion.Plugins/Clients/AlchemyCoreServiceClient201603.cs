using Alchemy4Tridion.Plugins.Clients.CoreService;
using System;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml.Linq;
using Alchemy4Tridion.Plugins.Utilities;

namespace Alchemy4Tridion.Plugins.Clients
{
    /// <summary>
    /// Provides a wrapper of the Tridion SessionAwareCoreServiceClient using a safe implementation of IDisposable.
    /// You can use this client inside of a using statement, and calling its Close or Dispose method will safely
    /// close out the 
    /// </summary>
    /// <remarks>
    /// Shoutout to Eric Huiza (http://erichuiza.blogspot.com/2013/12/how-to-correctly-dispose-coreservice.html)
    /// </remarks>
    public class AlchemyCoreServiceClient201603 : IDisposable, IAlchemyCoreServiceClient
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
        /// Gets or sets the underlying core service client channel.
        /// </summary>
        public ISessionAwareCoreService201603 Channel { get; set; }

        /// <summary>
        /// Creates a new SessionAwareCoreServiceClient using the supplied endpoint.
        /// </summary>
        /// <param name="endPoint"></param>
        public AlchemyCoreServiceClient201603()
        {
            ClientEndpoint = SessionAwareCoreServiceEndPoint.NetTcp201603;
            string endPointConfigName = CoreServiceUtils.GetEndpointConfigurationName(ClientEndpoint ?? SessionAwareCoreServiceEndPoint.NetTcp201603);

            var factory = new ChannelFactory<ISessionAwareCoreService201603>(endPointConfigName);
            Channel = factory.CreateChannel();
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
            if (Channel != null)
            {
                IClientChannel channel = (IClientChannel)Channel;
                if (!this.isDisposed && disposing)
                {
                    this.isDisposed = true;


                    try
                    {
                        if (channel.State != CommunicationState.Closed)
                        {
                            channel.Close();
                        }
                    }
                    catch (CommunicationException ex)
                    {
                        channel.Abort(); //The channel is aborted and the resources released.
                    }
                    catch (TimeoutException ex)
                    {
                        channel.Abort(); //The channel is aborted and the resources released.
                    }
                    catch (Exception ex)
                    {
                        channel.Abort(); // The channel is aborted and the resources released.
                    }
                }
            }
        }


        public UserData Impersonate(string username)
        {
            ImpersonatedUsername = username;

            return Channel.Impersonate(username);
        }

        public async Task<UserData> ImpersonateAsync(string username)
        {
            ImpersonatedUsername = username;
            return await Task<UserData>.Factory.FromAsync(Channel.BeginImpersonate, Channel.EndImpersonate, username, null);
        }


        
        public TridionEnumValue[] GetEnumValues(string type)
        {
            return this.Channel.GetEnumValues(type);
        }

        

        public async Task<TridionEnumValue[]> GetEnumValuesAsync(string type)
        {
            return await Task<TridionEnumValue[]>.Factory.FromAsync(Channel.BeginGetEnumValues, Channel.EndGetEnumValues, type, null);
        }

       

        public BundleTypeData[] ResolveBundleTypes(string[] itemIds, bool pruneTree)
        {
            return this.Channel.ResolveBundleTypes(itemIds, pruneTree);
        }

        

        public async Task<BundleTypeData[]> ResolveBundleTypesAsync(string[] itemIds, bool pruneTree)
        {
            return await Task<BundleTypeData[]>.Factory.FromAsync(Channel.BeginResolveBundleTypes, Channel.EndResolveBundleTypes, itemIds, pruneTree, null);
        }

       

        public KeywordData CopyToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
        {
            return this.Channel.CopyToKeyword(sourceKeywordId, destinationId, readBackOptions);
        }

        
        public async Task<KeywordData> CopyToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
        {
            return await Task<KeywordData>.Factory.FromAsync(Channel.BeginCopyToKeyword, Channel.EndCopyToKeyword, sourceKeywordId, destinationId, readBackOptions, null);
        }

       

        public KeywordData MoveToKeyword(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
        {
            return this.Channel.MoveToKeyword(sourceKeywordId, destinationId, readBackOptions);
        }

       

        public async Task<KeywordData> MoveToKeywordAsync(string sourceKeywordId, string destinationId, ReadOptions readBackOptions)
        {
            return await Task<KeywordData>.Factory.FromAsync(Channel.BeginMoveToKeyword, Channel.EndMoveToKeyword, sourceKeywordId, destinationId, readBackOptions, null);
        }

        

        public TridionLanguageInfo[] GetTridionLanguages()
        {
            return this.Channel.GetTridionLanguages();
        }

       

        public async Task<TridionLanguageInfo[]> GetTridionLanguagesAsync()
        {
            return await Task<TridionLanguageInfo[]>.Factory.FromAsync(Channel.BeginGetTridionLanguages, Channel.EndGetTridionLanguages, null);
        }

      

        public WorkflowScriptType[] GetListWorkflowScriptTypes()
        {
            return this.Channel.GetListWorkflowScriptTypes();
        }

        

        public async Task<WorkflowScriptType[]> GetListWorkflowScriptTypesAsync()
        {
            return await Task<WorkflowScriptType[]>.Factory.FromAsync(Channel.BeginGetListWorkflowScriptTypes, Channel.EndGetListWorkflowScriptTypes, null);
        }

       

        public WorkItemData[] AddToWorkflow(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions)
        {
            return this.Channel.AddToWorkflow(subjectIds, activityInstanceId, readBackOptions);
        }

       
        public async Task<WorkItemData[]> AddToWorkflowAsync(string[] subjectIds, string activityInstanceId, ReadOptions readBackOptions)
        {
            return await Task<WorkItemData[]>.Factory.FromAsync(Channel.BeginAddToWorkflow, Channel.EndAddToWorkflow, subjectIds, activityInstanceId, readBackOptions, null);
        }
        

        public WorkItemData[] RemoveFromWorkflow(string[] subjectIds, ReadOptions readBackOptions)
        {
            return this.Channel.RemoveFromWorkflow(subjectIds, readBackOptions);
        }

       

        public async Task<WorkItemData[]> RemoveFromWorkflowAsync(string[] subjectIds, ReadOptions readBackOptions)
        {
            return await Task<WorkItemData[]>.Factory.FromAsync(Channel.BeginRemoveFromWorkflow, Channel.EndRemoveFromWorkflow, subjectIds, readBackOptions, null);
        }

        
        public OrganizationalItemData Lock(string organizationalItemId, ReadOptions readBackOptions)
        {
            return this.Channel.Lock(organizationalItemId, readBackOptions);
        }

        

        public async Task<OrganizationalItemData> LockAsync(string organizationalItemId, ReadOptions readBackOptions)
        {
            return await Task<OrganizationalItemData>.Factory.FromAsync(Channel.BeginLock, Channel.EndLock, organizationalItemId, readBackOptions, null);
        }

        

        public OrganizationalItemData Unlock(string organizationalItemId, ReadOptions readBackOptions)
        {
            return this.Channel.Unlock(organizationalItemId, readBackOptions);
        }

       

        public async Task<OrganizationalItemData> UnlockAsync(string organizationalItemId, ReadOptions readBackOptions)
        {
            return await Task<OrganizationalItemData>.Factory.FromAsync(Channel.BeginUnlock, Channel.EndLock, organizationalItemId, readBackOptions, null);
        }

       

        public ProcessInstanceData StartWorkflow(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions)
        {
            return this.Channel.StartWorkflow(repositoryId, instruction, readBackOptions);
        }

      

        public async Task<ProcessInstanceData> StartWorkflowAsync(string repositoryId, StartWorkflowInstructionData instruction, ReadOptions readBackOptions)
        {
            return await Task<ProcessInstanceData>.Factory.FromAsync(Channel.BeginStartWorkflow, Channel.EndStartWorkflow, repositoryId, instruction, readBackOptions, null);
        }

       

        public ProcessDefinitionAssociationDictionary GetProcessDefinitionsForItems(string[] itemIds, ProcessDefinitionType processDefinitionType)
        {
            return this.Channel.GetProcessDefinitionsForItems(itemIds, processDefinitionType);
        }

        
        public async Task<ProcessDefinitionAssociationDictionary> GetProcessDefinitionsForItemsAsync(string[] itemIds, ProcessDefinitionType processDefinitionType)
        {
            return await Task<ProcessDefinitionAssociationDictionary>.Factory.FromAsync(Channel.BeginGetProcessDefinitionsForItems, Channel.EndGetProcessDefinitionsForItems, itemIds, processDefinitionType, null);
        }

       

        public string GetSystemXsd(string filename)
        {
            return this.Channel.GetSystemXsd(filename);
        }

        

        public async Task<string> GetSystemXsdAsync(string filename)
        {
            return await Task<string>.Factory.FromAsync(Channel.BeginGetSystemXsd, Channel.EndGetSystemXsd, filename, null);
        }

      

        public LinkToSchemaData[] GetSchemasByNamespaceUri(string repositoryId, string namespaceUri, string rootElementName)
        {
            return this.Channel.GetSchemasByNamespaceUri(repositoryId, namespaceUri, rootElementName);
        }

       

        public async Task<LinkToSchemaData[]> GetSchemasByNamespaceUriAsync(string repositoryId, string namespaceUri, string rootElementName)
        {
            return await Task<LinkToSchemaData[]>.Factory.FromAsync(Channel.BeginGetSchemasByNamespaceUri, Channel.EndGetSchemasByNamespaceUri, repositoryId, namespaceUri, rootElementName, null);
        }

        
        public ValidationErrorData[] Validate(IdentifiableObjectData deltaData)
        {
            return this.Channel.Validate(deltaData);
        }

      

        public async Task<ValidationErrorData[]> ValidateAsync(IdentifiableObjectData deltaData)
        {
            return await Task<ValidationErrorData[]>.Factory.FromAsync(Channel.BeginValidate, Channel.EndValidate, deltaData, null);
        }

        

        public BinaryContentData GetExternalBinaryContentData(string uri)
        {
            return this.Channel.GetExternalBinaryContentData(uri);
        }

       

        public async Task<BinaryContentData> GetExternalBinaryContentDataAsync(string uri)
        {
            return await Task<BinaryContentData>.Factory.FromAsync(Channel.BeginGetExternalBinaryContentData, Channel.EndGetExternalBinaryContentData, uri, null);
        }


        public SynchronizationResult SynchronizeWithSchema(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions)
        {
            return this.Channel.SynchronizeWithSchema(dataObject, synchronizeOptions);
        }

      

        public async Task<SynchronizationResult> SynchronizeWithSchemaAsync(IdentifiableObjectData dataObject, SynchronizeOptions synchronizeOptions)
        {
            return await Task<SynchronizationResult>.Factory.FromAsync(Channel.BeginSynchronizeWithSchema, Channel.EndSynchronizeWithSchema, dataObject, synchronizeOptions, null);
        }

     

        public SynchronizationResult SynchronizeWithSchemaAndUpdate(string itemId, SynchronizeOptions synchronizeOptions)
        {
            return this.Channel.SynchronizeWithSchemaAndUpdate(itemId, synchronizeOptions);
        }

      

        public async Task<SynchronizationResult> SynchronizeWithSchemaAndUpdateAsync(string itemId, SynchronizeOptions synchronizeOptions)
        {
            return await Task<SynchronizationResult>.Factory.FromAsync(Channel.BeginSynchronizeWithSchemaAndUpdate, Channel.EndSynchronizeWithSchemaAndUpdate, itemId, synchronizeOptions, null);
        }

      

        public void DecommissionPublicationTarget(string publicationTargetId)
        {
            this.Channel.DecommissionPublicationTarget(publicationTargetId);
        }

     

        public async Task DecommissionPublicationTargetAsync(string publicationTargetId)
        {
            await Task.Factory.FromAsync(Channel.BeginDecommissionPublicationTarget(publicationTargetId, null, null), Channel.EndDecommissionPublicationTarget);
        }

      
        public SchemaFieldsData ConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions)
        {
            return this.Channel.ConvertXsdToSchemaFields(xsd, purpose, rootElementName, readOptions);
        }

      

        public async Task<SchemaFieldsData> ConvertXsdToSchemaFieldsAsync(XElement xsd, SchemaPurpose purpose, string rootElementName, ReadOptions readOptions)
        {
            return await Task<SchemaFieldsData>.Factory.FromAsync(Channel.BeginConvertXsdToSchemaFields(xsd, purpose, rootElementName, readOptions, null, null), Channel.EndConvertXsdToSchemaFields);
        }

     

        public string GetPublishUrl(string id, string targetTypeIdOrPurpose)
        {
            return this.Channel.GetPublishUrl(id, targetTypeIdOrPurpose);
        }

      

        public async Task<string> GetPublishUrlAsync(string id, string targetTypeIdOrPurpose)
        {
            return await Task<string>.Factory.FromAsync(Channel.BeginGetPublishUrl, Channel.EndGetPublishUrl, id, targetTypeIdOrPurpose, null);
        }

        public LinkToBusinessProcessTypeData[] GetBusinessProcessTypes(string cdTopologyTypeId)
        {
            return this.Channel.GetBusinessProcessTypes(cdTopologyTypeId);
        }

      

        public async Task<LinkToBusinessProcessTypeData[]> GetBusinessProcessTypesAsync(string cdTopologyTypeId)
        {
            return await Task<LinkToBusinessProcessTypeData[]>.Factory.FromAsync(Channel.BeginGetBusinessProcessTypes, Channel.EndGetBusinessProcessTypes, cdTopologyTypeId, null);
        }

        public PublishSourceData GetPublishSourceByUrl(string url)
        {
            return this.Channel.GetPublishSourceByUrl(url);
        }

     

        public async Task<PublishSourceData> GetPublishSourceByUrlAsync(string url)
        {
            return await Task<PublishSourceData>.Factory.FromAsync(Channel.BeginGetPublishSourceByUrl, Channel.EndGetPublishSourceByUrl, url, null);
        }

     

        public void RemovePublishStates(string publicationId, string targetTypeIdOrPurpose)
        {
            this.Channel.RemovePublishStates(publicationId, targetTypeIdOrPurpose);
        }

      

        public async Task RemovePublishStatesAsync(string publicationId, string targetTypeIdOrPurpose)
        {
            await Task.Factory.FromAsync(Channel.BeginRemovePublishStates, Channel.EndRemovePublishStates, publicationId, targetTypeIdOrPurpose, null);
        }

       
        public ContainingPagesDictionary ResolveContainingPages(string componentId, ResolveContainingPagesInstructionData instruction)
        {
            return this.Channel.ResolveContainingPages(componentId, instruction);
        }

      

        public async Task<ContainingPagesDictionary> ResolveContainingPagesAsync(string componentId, ResolveContainingPagesInstructionData instruction)
        {
            return await Task<ContainingPagesDictionary>.Factory.FromAsync(Channel.BeginResolveContainingPages, Channel.EndResolveContainingPages, componentId, instruction, null);
        }

       

        public void PurgeWorkflowHistory(PurgeWorkflowHistoryInstructionData instruction)
        {
            this.Channel.PurgeWorkflowHistory(instruction);
        }

        public async Task PurgeWorkflowHistoryAsync(PurgeWorkflowHistoryInstructionData instruction)
        {
            await Task.Factory.FromAsync(Channel.BeginPurgeWorkflowHistory, Channel.EndPurgeWorkflowHistory, instruction, null);
        }













        public void BroadcastNotification(NotificationMessage notification)
        {
            this.Channel.BroadcastNotification(notification);
        }

        public async Task BroadcastNotificationAsync(NotificationMessage notification)
        {
            await Task.Factory.FromAsync(Channel.BeginBroadcastNotification, Channel.EndBroadcastNotification, notification, null);
        }

       
        public SystemPrivilege[] GetSystemPrivileges()
        {
            return this.Channel.GetSystemPrivileges();
        }

   

        public async Task<SystemPrivilege[]> GetSystemPrivilegesAsync()
        {
            return await Task.Factory.FromAsync(Channel.BeginGetSystemPrivileges, Channel.EndGetSystemPrivileges, null);
        }

       

        public string GetApiVersion()
        {
            return this.Channel.GetApiVersion();
        }



        public async Task<string> GetApiVersionAsync()
        {
            return await Task<string>.Factory.FromAsync(Channel.BeginGetApiVersion, Channel.EndGetApiVersion, null);
        }


        public AccessTokenData GetCurrentUserWithToken()
        {
            return this.Channel.GetCurrentUser();
        }

       

        public async Task<AccessTokenData> GetCurrentUserWithTokenAsync()
        {
            return await Task<AccessTokenData>.Factory.FromAsync(Channel.BeginGetCurrentUser, Channel.EndGetCurrentUser, null);
        }


        public bool IsExistingObject(string id)
        {
            return this.Channel.IsExistingObject(id);
        }



        public async Task<bool> IsExistingObjectAsync(string id)
        {
            return await Task<bool>.Factory.FromAsync(Channel.BeginIsExistingObject, Channel.EndIsExistingObject, id, null);
        }


        public string GetTcmUri(string baseUri, string contextRepositoryUri, uint? version)
        {
            return this.Channel.GetTcmUri(baseUri, contextRepositoryUri, version);
        }



        public async Task<string> GetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version = null)
        {
            return await Task<string>.Factory.FromAsync(Channel.BeginGetTcmUri, Channel.EndGetTcmUri, baseUri, contextRepositoryUri, version, null);
        }



        public string TryGetTcmUri(string baseUri, string contextRepositoryUri, uint? version)
        {
            return this.Channel.TryGetTcmUri(baseUri, contextRepositoryUri, version);
        }



        public async Task<string> TryGetTcmUriAsync(string baseUri, string contextRepositoryUri, uint? version = null)
        {
            return await Task<string>.Factory.FromAsync(Channel.BeginTryGetTcmUri, Channel.EndTryGetTcmUri, baseUri, contextRepositoryUri, version, null);
        }



        public IdentifiableObjectData Read(string id)
        {
            return Channel.Read(id, null);
        }

        public IdentifiableObjectData Read(string id, ReadOptions readOptions)
        {
            return Channel.Read(id, readOptions);
        }

        public async Task<IdentifiableObjectData> ReadAsync(string id, ReadOptions readOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Channel.BeginRead, Channel.EndRead, id, readOptions, null);
        }

        public IdentifiableObjectData TryRead(string id, ReadOptions readOptions = null)
        {
            return Channel.TryRead(id, readOptions);
        }

        public async Task<IdentifiableObjectData> TryReadAsync(string id, ReadOptions readOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Channel.BeginTryRead, Channel.EndTryRead, id, readOptions, null);
        }



        public ItemReadResultDictionary BulkRead(string[] ids, ReadOptions readOptions)
        {
            return this.Channel.BulkRead(ids, readOptions);
        }

       

        public async Task<ItemReadResultDictionary> BulkReadAsync(string[] ids, ReadOptions readOptions)
        {
            return await Task<ItemReadResultDictionary>.Factory.FromAsync(Channel.BeginBulkRead, Channel.EndBulkRead, ids, readOptions, null);
        }


        public SchemaFieldsData ReadSchemaFields(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions)
        {
            return this.Channel.ReadSchemaFields(schemaId, expandEmbeddedFields, readOptions);
        }

        public async Task<SchemaFieldsData> ReadSchemaFieldsAsync(string schemaId, bool expandEmbeddedFields, ReadOptions readOptions = null)
        {
            return await Task<SchemaFieldsData>.Factory.FromAsync(Channel.BeginReadSchemaFields, Channel.EndReadSchemaFields, schemaId, expandEmbeddedFields, readOptions, null);
        }


        public XElement ConvertSchemaFieldsToXsd(SchemaFieldsData schemaFieldsData)
        {
            return this.Channel.ConvertSchemaFieldsToXsd(schemaFieldsData);
        }



        public async Task<XElement> ConvertSchemaFieldsToXsdAsync(SchemaFieldsData schemaFieldsData)
        {
            return await Task<XElement>.Factory.FromAsync(Channel.BeginConvertSchemaFieldsToXsd, Channel.EndConvertSchemaFieldsToXsd, schemaFieldsData, null);
        }



        public IdentifiableObjectData Save(IdentifiableObjectData deltaData, ReadOptions readBackOptions)
        {
            return this.Channel.Save(deltaData, readBackOptions);
        }


        public async Task<IdentifiableObjectData> SaveAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Channel.BeginSave, Channel.EndSave, deltaData, readBackOptions, null);
        }



        public void Delete(string id)
        {
            this.Channel.Delete(id);
        }



        public async Task DeleteAsync(string id)
        {
            await Task.Factory.FromAsync(Channel.BeginDelete, Channel.EndDelete, id, null);
        }



        public void DeleteTaxonomyNode(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
        {
            this.Channel.DeleteTaxonomyNode(id, deleteTaxonomyNodeMode);
        }



        public async Task DeleteTaxonomyNodeAsync(string id, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
        {
            await Task.Factory.FromAsync(Channel.BeginDeleteTaxonomyNode, Channel.EndDeleteTaxonomyNode, id, deleteTaxonomyNodeMode, null);
        }


        public IdentifiableObjectData GetDefaultData(ItemType itemType, string containerId, ReadOptions readOptions)
        {
            return this.Channel.GetDefaultData(itemType, containerId, readOptions);
        }



        public async Task<IdentifiableObjectData> GetDefaultDataAsync(ItemType itemType, string containerId, ReadOptions readOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Channel.BeginGetDefaultData, Channel.EndGetDefaultData, itemType, containerId, readOptions, null);
        }

        public RepositoryLocalObjectData Move(string id, string destinationId, ReadOptions readBackOptions)
        {
            return this.Channel.Move(id, destinationId, readBackOptions);
        }



        public async Task<RepositoryLocalObjectData> MoveAsync(string id, string destinationId, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Channel.BeginMove, Channel.EndMove, id, destinationId, readBackOptions, null);
        }



        public RepositoryLocalObjectData Copy(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions)
        {
            return this.Channel.Copy(id, destinationId, makeUnique, readBackOptions);
        }



        public async Task<RepositoryLocalObjectData> CopyAsync(string id, string destinationId, bool makeUnique, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Channel.BeginCopy(id, destinationId, makeUnique, readBackOptions, null, null), Channel.EndCopy);
        }


        public InstanceData GetInstanceData(string schemaId, string containerItemId, ReadOptions readOptions)
        {
            return this.Channel.GetInstanceData(schemaId, containerItemId, readOptions);
        }


        public async Task<InstanceData> GetInstanceDataAsync(string schemaId, string containerItemId, ReadOptions readOptions = null)
        {
            return await Task<InstanceData>.Factory.FromAsync(Channel.BeginGetInstanceData, Channel.EndGetInstanceData, schemaId, containerItemId, readOptions, null);
        }


        public IdentifiableObjectData TryCheckOut(string id, ReadOptions readBackOptions)
        {
            return this.Channel.TryCheckOut(id, readBackOptions);
        }



        public async Task<IdentifiableObjectData> TryCheckOutAsync(string id, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Channel.BeginTryCheckOut, Channel.EndTryCheckOut, id, readBackOptions, null);
        }



        public VersionedItemData CheckOut(string id, bool permanentLock, ReadOptions readBackOptions)
        {
            return this.Channel.CheckOut(id, permanentLock, readBackOptions);
        }



        public async Task<VersionedItemData> CheckOutAsync(string id, bool permanentLock = false, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Channel.BeginCheckOut, Channel.EndCheckOut, id, permanentLock, readBackOptions, null);
        }



        public VersionedItemData CheckIn(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions)
        {
            return this.Channel.CheckIn(id, removePermanentLock, userComment, readBackOptions);
        }



        public async Task<VersionedItemData> CheckInAsync(string id, bool removePermanentLock, string userComment, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Channel.BeginCheckIn(id, removePermanentLock, userComment, readBackOptions, null, null), Channel.EndCheckIn);
        }



        public IdentifiableObjectData Update(IdentifiableObjectData deltaData, ReadOptions readBackOptions)
        {
            return this.Channel.Update(deltaData, readBackOptions);
        }



        public async Task<IdentifiableObjectData> UpdateAsync(IdentifiableObjectData deltaData, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Channel.BeginUpdate, Channel.EndUpdate, deltaData, readBackOptions, null);
        }



        public IdentifiableObjectData Create(IdentifiableObjectData data, ReadOptions readBackOptions)
        {
            return this.Channel.Create(data, readBackOptions);
        }



        public async Task<IdentifiableObjectData> CreateAsync(IdentifiableObjectData data, ReadOptions readBackOptions = null)
        {
            return await Task<IdentifiableObjectData>.Factory.FromAsync(Channel.BeginCreate, Channel.EndCreate, data, readBackOptions, null);
        }



        public VersionedItemData UndoCheckOut(string id, bool permanentLock, ReadOptions readBackOptions)
        {
            return this.Channel.UndoCheckOut(id, permanentLock, readBackOptions);
        }



        public async Task<VersionedItemData> UndoCheckOutAsync(string id, bool permanentLock, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Channel.BeginUndoCheckOut, Channel.EndUndoCheckOut, id, permanentLock, readBackOptions, null);
        }


        public VersionedItemData Rollback(string id, bool deleteVersions, string comment, ReadOptions readBackOptions)
        {
            return this.Channel.Rollback(id, deleteVersions, comment, readBackOptions);
        }



        public async Task<VersionedItemData> RollbackAsync(string id, bool deleteVersions, string comment, ReadOptions readBackOptions = null)
        {
            return await Task<VersionedItemData>.Factory.FromAsync(Channel.BeginRollback(id, deleteVersions, comment, readBackOptions, null, null), Channel.EndRollback);
        }



        public RepositoryLocalObjectData Localize(string id, ReadOptions readBackOptions)
        {
            return this.Channel.Localize(id, readBackOptions);
        }



        public async Task<RepositoryLocalObjectData> LocalizeAsync(string id, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Channel.BeginLocalize, Channel.EndLocalize, id, readBackOptions, null);
        }


        public RepositoryLocalObjectData UnLocalize(string id, ReadOptions readBackOptions)
        {
            return this.Channel.UnLocalize(id, readBackOptions);
        }



        public async Task<RepositoryLocalObjectData> UnLocalizeAsync(string id, ReadOptions readBackOptions = null)
        {
            return await Task<RepositoryLocalObjectData>.Factory.FromAsync(Channel.BeginUnLocalize, Channel.EndUnLocalize, id, readBackOptions, null);
        }



        public OperationResultDataOfRepositoryLocalObjectData Promote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
        {
            return this.Channel.Promote(id, destinationRepositoryId, instruction, readBackOptions);
        }

      
        public async Task<OperationResultDataOfRepositoryLocalObjectData> PromoteAsync(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
        {
            return await Task<OperationResultDataOfRepositoryLocalObjectData>.Factory.FromAsync(Channel.BeginPromote(id, destinationRepositoryId, instruction, readBackOptions, null, null), Channel.EndPromote);
        }

      
        public OperationResultDataOfRepositoryLocalObjectData Demote(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
        {
            return this.Channel.Demote(id, destinationRepositoryId, instruction, readBackOptions);
        }

       

        public async Task<OperationResultDataOfRepositoryLocalObjectData> DemoteAsync(string id, string destinationRepositoryId, OperationInstruction instruction, ReadOptions readBackOptions)
        {
            return await Task<OperationResultDataOfRepositoryLocalObjectData>.Factory.FromAsync(Channel.BeginDemote(id, destinationRepositoryId, instruction, readBackOptions, null, null), Channel.EndDemote);
        }

       

        public TemplateType[] GetListTemplateTypes(ItemType? itemType)
        {
            return this.Channel.GetListTemplateTypes(itemType);
        }



        public async Task<TemplateType[]> GetListTemplateTypesAsync(ItemType? itemType = null)
        {
            return await Task<TemplateType[]>.Factory.FromAsync(Channel.BeginGetListTemplateTypes, Channel.EndGetListTemplateTypes, itemType, null);
        }


        public PublicationType[] GetListPublicationTypes()
        {
            return this.Channel.GetListPublicationTypes();
        }



        public async Task<PublicationType[]> GetListPublicationTypesAsync()
        {
            return await Task<PublicationType[]>.Factory.FromAsync(Channel.BeginGetListPublicationTypes, Channel.EndGetListPublicationTypes, null);
        }



        public XElement GetSystemWideListXml(SystemWideListFilterData filter)
        {
            return this.Channel.GetSystemWideListXml(filter);
        }



        public async Task<XElement> GetSystemWideListXmlAsync(SystemWideListFilterData filter)
        {
            return await Task<XElement>.Factory.FromAsync(Channel.BeginGetSystemWideListXml, Channel.EndGetSystemWideListXml, filter, null);
        }


        public IdentifiableObjectData[] GetSystemWideList(SystemWideListFilterData filter)
        {
            return this.Channel.GetSystemWideList(filter);
        }



        public async Task<IdentifiableObjectData[]> GetSystemWideListAsync(SystemWideListFilterData filter)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Channel.BeginGetSystemWideList, Channel.EndGetSystemWideList, filter, null);
        }



        public XElement GetListXml(string id, SubjectRelatedListFilterData filter)
        {
            return this.Channel.GetListXml(id, filter);
        }



        public async Task<XElement> GetListXmlAsync(string id, SubjectRelatedListFilterData filter)
        {
            return await Task<XElement>.Factory.FromAsync(Channel.BeginGetListXml, Channel.EndGetListXml, id, filter, null);
        }



        public IdentifiableObjectData[] GetList(string id, SubjectRelatedListFilterData filter)
        {
            return this.Channel.GetList(id, filter);
        }



        public async Task<IdentifiableObjectData[]> GetListAsync(string id, SubjectRelatedListFilterData filter)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Channel.BeginGetList, Channel.EndGetList, id, filter, null);
        }


        public string[] GetListDirectoryServiceNames()
        {
            return this.Channel.GetListDirectoryServiceNames();
        }



        public async Task<string[]> GetListDirectoryServiceNamesAsync()
        {
            return await Task<string[]>.Factory.FromAsync(Channel.BeginGetListDirectoryServiceNames, Channel.EndGetListDirectoryServiceNames, null);
        }



        public WindowsUser[] GetListWindowsDomainUsers(string domainName)
        {
            return this.Channel.GetListWindowsDomainUsers(domainName);
        }



        public async Task<WindowsUser[]> GetListWindowsDomainUsersAsync(string domainName)
        {
            return await Task<WindowsUser[]>.Factory.FromAsync(Channel.BeginGetListWindowsDomainUsers, Channel.EndGetListWindowsDomainUsers, domainName, null);
        }



        public DirectoryServiceUser[] GetListDirectoryServiceAllUsers(string directoryServiceName)
        {
            return this.Channel.GetListDirectoryServiceAllUsers(directoryServiceName);
        }



        public async Task<DirectoryServiceUser[]> GetListDirectoryServiceAllUsersAsync(string directoryServiceName)
        {
            return await Task<DirectoryServiceUser[]>.Factory.FromAsync(Channel.BeginGetListDirectoryServiceAllUsers, Channel.EndGetListDirectoryServiceAllUsers, directoryServiceName, null);
        }



        public DirectoryServiceUser[] GetListDirectoryServiceGroupMembers(string directoryServiceName, string groupDN)
        {
            return this.Channel.GetListDirectoryServiceGroupMembers(directoryServiceName, groupDN);
        }

       

        public async Task<DirectoryServiceUser[]> GetListDirectoryServiceGroupMembersAsync(string directoryServiceName, string groupDN)
        {
            return await Task<DirectoryServiceUser[]>.Factory.FromAsync(Channel.BeginGetListDirectoryServiceGroupMembers, Channel.EndGetListDirectoryServiceGroupMembers, directoryServiceName, groupDN, null);
        }



        public DirectoryServiceUser[] GetListDirectoryServiceUsers(string directoryServiceName, DirectoryUsersFilter filter)
        {
            return this.Channel.GetListDirectoryServiceUsers(directoryServiceName, filter);
        }



        public async Task<DirectoryServiceUser[]> GetListDirectoryServiceUsersAsync(string directoryServiceName, DirectoryUsersFilter filter)
        {
            return await Task<DirectoryServiceUser[]>.Factory.FromAsync(Channel.BeginGetListDirectoryServiceUsers, Channel.EndGetListDirectoryServiceUsers, directoryServiceName, filter, null);
        }



        public ClassificationInfoData Classify(string id, string[] keywordIds, ReadOptions readOptions)
        {
            return this.Channel.Classify(id, keywordIds, readOptions);
        }

       

        public async Task<ClassificationInfoData> ClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions = null)
        {
            return await Task<ClassificationInfoData>.Factory.FromAsync(Channel.BeginClassify, Channel.EndClassify, id, keywordIds, readOptions, null);
        }


        public ClassificationInfoData UnClassify(string id, string[] keywordIds, ReadOptions readOptions)
        {
            return this.Channel.UnClassify(id, keywordIds, readOptions);
        }



        public async Task<ClassificationInfoData> UnClassifyAsync(string id, string[] keywordIds, ReadOptions readOptions = null)
        {
            return await Task<ClassificationInfoData>.Factory.FromAsync(Channel.BeginUnClassify, Channel.EndUnClassify, id, keywordIds, readOptions, null);
        }



        public ClassificationInfoData ReClassify(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions)
        {
            return this.Channel.ReClassify(id, keywordIdsToRemove, keywordIdsToAdd, readOptions);
        }

       
        public async Task<ClassificationInfoData> ReClassifyAsync(string id, string[] keywordIdsToRemove, string[] keywordIdsToAdd, ReadOptions readOptions)
        {
            return await Task<ClassificationInfoData>.Factory.FromAsync(Channel.BeginReClassify(id, keywordIdsToRemove, keywordIdsToAdd, readOptions, null, null), Channel.EndReClassify);
        }


        public ActivityInstanceData StartActivity(string activityInstanceId, ReadOptions readBackOptions)
        {
            return this.Channel.StartActivity(activityInstanceId, readBackOptions);
        }



        public async Task<ActivityInstanceData> StartActivityAsync(string activityInstanceId, ReadOptions readBackOptions = null)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Channel.BeginStartActivity, Channel.EndStartActivity, activityInstanceId, readBackOptions, null);
        }



        public ActivityInstanceData SuspendActivity(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions)
        {
            return this.Channel.SuspendActivity(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions);
        }

       
        public async Task<ActivityInstanceData> SuspendActivityAsync(string activityInstanceId, string reason, DateTime? resumeAt, string resumeBookmark, ReadOptions readBackOptions)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Channel.BeginSuspendActivity(activityInstanceId, reason, resumeAt, resumeBookmark, readBackOptions, null, null), Channel.EndSuspendActivity);
        }

       

        public ActivityInstanceData RestartActivity(string activityInstanceId, ReadOptions readBackOptions)
        {
            return this.Channel.RestartActivity(activityInstanceId, readBackOptions);
        }

       

        public async Task<ActivityInstanceData> RestartActivityAsync(string activityInstanceId, ReadOptions readBackOptions)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Channel.BeginRestartActivity, Channel.EndRestartActivity, activityInstanceId, readBackOptions, null);
        }


        public ActivityInstanceData ReAssignActivity(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions)
        {
            return this.Channel.ReAssignActivity(activityInstanceId, newAssigneeId, readBackOptions);
        }


        public async Task<ActivityInstanceData> ReAssignActivityAsync(string activityInstanceId, string newAssigneeId, ReadOptions readBackOptions)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Channel.BeginReAssignActivity, Channel.EndReAssignActivity, activityInstanceId, newAssigneeId, readBackOptions, null);
        }

        public ActivityInstanceData FinishActivity(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions)
        {
            return this.Channel.FinishActivity(activityInstanceId, activityFinishData, readOptions);
        }

   

        public async Task<ActivityInstanceData> FinishActivityAsync(string activityInstanceId, ActivityFinishData activityFinishData, ReadOptions readOptions)
        {
            return await Task<ActivityInstanceData>.Factory.FromAsync(Channel.BeginFinishActivity, Channel.EndFinishActivity, activityInstanceId, activityFinishData, readOptions, null);
        }


        public ProcessHistoryData ForceFinishProcess(string processInstanceId, string approvalStatusId, ReadOptions readOptions)
        {
            return this.Channel.ForceFinishProcess(processInstanceId, approvalStatusId, readOptions);
        }

      

        public async Task<ProcessHistoryData> ForceFinishProcessAsync(string processInstanceId, string approvalStatusId, ReadOptions readOptions)
        {
            return await Task<ProcessHistoryData>.Factory.FromAsync(Channel.BeginForceFinishProcess, Channel.EndForceFinishProcess, processInstanceId, approvalStatusId, readOptions, null);
        }


        public ActivityInstanceData ResumeActivity(string activityInstanceId, ReadOptions readOptions)
        {
            return this.Channel.ResumeActivity(activityInstanceId, readOptions);
        }

      

        public async Task<ActivityInstanceData> ResumeActivityAsync(string activityInstanceId, ReadOptions readOptions)
        {
            return await Task.Factory.FromAsync(Channel.BeginResumeActivity, Channel.EndResumeActivity, activityInstanceId, readOptions, null);
        }

       

        public QueueMessageData[] GetListQueueMessages(int queueId)
        {
            return this.Channel.GetListQueueMessages(queueId);
        }

        

        public async Task<QueueMessageData[]> GetListQueueMessagesAsync(int queueId)
        {
            return await Task<QueueMessageData[]>.Factory.FromAsync(Channel.BeginGetListQueueMessages, Channel.EndGetListQueueMessages, queueId, null);
        }

       

        public void PurgeQueue(int queueId)
        {
            this.Channel.PurgeQueue(queueId);
        }

        

        public async Task PurgeQueueAsync(int queueId)
        {
            await Task.Factory.FromAsync(Channel.BeginPurgeQueue, Channel.EndPurgeQueue, queueId, null);
        }



        public QueueData[] GetListQueues()
        {
            return this.Channel.GetListQueues();
        }

       

        public async Task<QueueData[]> GetListQueuesAsync()
        {
            return await Task<QueueData[]>.Factory.FromAsync(Channel.BeginGetListQueues, Channel.EndGetListQueues, null);
        }

        

        public ApplicationData ReadApplicationData(string subjectId, string applicationId)
        {
            return this.Channel.ReadApplicationData(subjectId, applicationId);
        }

       

        public async Task<ApplicationData> ReadApplicationDataAsync(string subjectId, string applicationId)
        {
            return await Task<ApplicationData>.Factory.FromAsync(Channel.BeginReadApplicationData, Channel.EndReadApplicationData, subjectId, applicationId, null);
        }

       

        public ApplicationData[] ReadAllApplicationData(string subjectId)
        {
            return this.Channel.ReadAllApplicationData(subjectId);
        }

        

        public async Task<ApplicationData[]> ReadAllApplicationDataAsync(string subjectId)
        {
            return await Task<ApplicationData[]>.Factory.FromAsync(Channel.BeginReadAllApplicationData, Channel.EndReadAllApplicationData, subjectId, null);
        }


        public void SaveApplicationData(string subjectId, ApplicationData[] applicationData)
        {
            this.Channel.SaveApplicationData(subjectId, applicationData);
        }



        public async Task SaveApplicationDataAsync(string subjectId, ApplicationData[] applicationData)
        {
            await Task.Factory.FromAsync(Channel.BeginSaveApplicationData, Channel.EndSaveApplicationData, subjectId, applicationData, null);
        }



        public void DeleteApplicationData(string subjectId, string applicationId)
        {
            this.Channel.DeleteApplicationData(subjectId, applicationId);
        }



        public async Task DeleteApplicationDataAsync(string subjectId, string applicationId)
        {
            await Task.Factory.FromAsync(Channel.BeginDeleteApplicationData, Channel.EndDeleteApplicationData, subjectId, applicationId, null);
        }



        public string[] GetApplicationIds()
        {
            return this.Channel.GetApplicationIds();
        }



        public async Task<string[]> GetApplicationIdsAsync()
        {
            return await Task<string[]>.Factory.FromAsync(Channel.BeginGetApplicationIds, Channel.EndGetApplicationIds, null);
        }

        public void PurgeApplicationData(string applicationId)
        {
            this.Channel.PurgeApplicationData(applicationId);
        }

       

        public async Task PurgeApplicationDataAsync(string applicationId)
        {
            await Task.Factory.FromAsync(Channel.BeginPurgeApplicationData, Channel.EndPurgeApplicationData, applicationId, null);
        }

  

        public PredefinedBatchOperation? ParsePredefinedBatchOperation(string operation)
        {
            return this.Channel.ParsePredefinedBatchOperation(operation);
        }

       

        public async Task<PredefinedBatchOperation?> ParsePredefinedBatchOperationAsync(string operation)
        {
            return await Task<PredefinedBatchOperation?>.Factory.FromAsync(Channel.BeginParsePredefinedBatchOperation, Channel.EndParsePredefinedBatchOperation, operation, null);
        }

        

        public string GetPredefinedBatchOperationName(PredefinedBatchOperation operation)
        {
            return this.Channel.GetPredefinedBatchOperationName(operation);
        }

      

        public async Task<string> GetPredefinedBatchOperationNameAsync(PredefinedBatchOperation operation)
        {
            return await Task<string>.Factory.FromAsync(Channel.BeginGetPredefinedBatchOperationName, Channel.EndGetPredefinedBatchOperationName, operation, null);
        }

    

        public PublishContextData[] ResolveItems(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions)
        {
            return this.Channel.ResolveItems(ids, resolveInstruction, targetIdsOrPurposes, readOptions);
        }

       

        public async Task<PublishContextData[]> ResolveItemsAsync(string[] ids, ResolveInstructionData resolveInstruction, string[] targetIdsOrPurposes, ReadOptions readOptions)
        {
            return await Task<PublishContextData[]>.Factory.FromAsync(Channel.BeginResolveItems(ids, resolveInstruction, targetIdsOrPurposes, readOptions, null, null), Channel.EndResolveItems);
        }

  

        public XElement GetSearchResultsXml(SearchQueryData filter)
        {
            return this.Channel.GetSearchResultsXml(filter);
        }



        public async Task<XElement> GetSearchResultsXmlAsync(SearchQueryData filter)
        {
            return await Task<XElement>.Factory.FromAsync(Channel.BeginGetSearchResultsXml, Channel.EndGetSearchResultsXml, filter, null);
        }


        public XElement GetSearchResultsXmlPaged(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return this.Channel.GetSearchResultsXmlPaged(filter, startRowIndex, maxRows);
        }


        public async Task<XElement> GetSearchResultsXmlPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return await Task<XElement>.Factory.FromAsync(Channel.BeginGetSearchResultsXmlPaged, Channel.EndGetSearchResultsXmlPaged, filter, startRowIndex, maxRows, null);
        }


        public IdentifiableObjectData[] GetSearchResults(SearchQueryData filter)
        {
            return this.Channel.GetSearchResults(filter);
        }


        public async Task<IdentifiableObjectData[]> GetSearchResultsAsync(SearchQueryData filter)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Channel.BeginGetSearchResults, Channel.EndGetSearchResults, filter, null);
        }



        public IdentifiableObjectData[] GetSearchResultsPaged(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return this.Channel.GetSearchResultsPaged(filter, startRowIndex, maxRows);
        }



        public async Task<IdentifiableObjectData[]> GetSearchResultsPagedAsync(SearchQueryData filter, int startRowIndex, int maxRows)
        {
            return await Task<IdentifiableObjectData[]>.Factory.FromAsync(Channel.BeginGetSearchResultsPaged, Channel.EndGetSearchResultsPaged, filter, startRowIndex, maxRows, null);
        }



        public RenderedItemData RenderItem(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose)
        {
            return this.Channel.RenderItem(itemId, templateId, publishInstruction, publicationTargetIdOrPurpose);
        }

        public async Task<RenderedItemData> RenderItemAsync(string itemId, string templateId, PublishInstructionData publishInstruction, string publicationTargetIdOrPurpose)
        {
            return await Task<RenderedItemData>.Factory.FromAsync(Channel.BeginRenderItem(itemId, templateId, publishInstruction, publicationTargetIdOrPurpose, null, null), Channel.EndRenderItem);
        }

        public RenderedItemData PreviewItem(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId)
        {
            return this.Channel.PreviewItem(itemData, templateData, publishInstruction, publicationTargetId);
        }



        public async Task<RenderedItemData> PreviewItemAsync(RepositoryLocalObjectData itemData, TemplateData templateData, PublishInstructionData publishInstruction, string publicationTargetId)
        {
            return await Task<RenderedItemData>.Factory.FromAsync(Channel.BeginPreviewItem(itemData, templateData, publishInstruction, publicationTargetId, null, null), Channel.EndPreviewItem);
        }


        public PublishTransactionData[] Publish(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
        {
            return this.Channel.Publish(ids, publishInstruction, targetIdsOrPurposes, priority, readOptions);
        }


        public async Task<PublishTransactionData[]> PublishAsync(string[] ids, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
        {
            return await Task<PublishTransactionData[]>.Factory.FromAsync(Channel.BeginPublish(ids, publishInstruction, targetIdsOrPurposes, priority, readOptions, null, null), Channel.EndPublish);
        }


        public PublishTransactionData[] UnPublish(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
        {
            return this.Channel.UnPublish(ids, unPublishInstruction, targetIdsOrPurposes, priority, readOptions);
        }

        public async Task<PublishTransactionData[]> UnPublishAsync(string[] ids, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, ReadOptions readOptions)
        {
            return await Task<PublishTransactionData[]>.Factory.FromAsync(Channel.BeginUnPublish(ids, unPublishInstruction, targetIdsOrPurposes, priority, readOptions, null, null), Channel.EndUnPublish);
        }

  
  
        public bool IsPublished(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext)
        {
            return this.Channel.IsPublished(itemId, publishingTargetIdOrPurpose, isPublishedInContext);
        }


        public async Task<bool> IsPublishedAsync(string itemId, string publishingTargetIdOrPurpose, bool isPublishedInContext)
        {
            return await Task<bool>.Factory.FromAsync(Channel.BeginIsPublished, Channel.EndIsPublished, itemId, publishingTargetIdOrPurpose, isPublishedInContext, null);
        }

       

        public RenderedItemData GetWorkItemSnapshot(string workItemId)
        {
            return this.Channel.GetWorkItemSnapshot(workItemId);
        }

        public async Task<RenderedItemData> GetWorkItemSnapshotAsync(string workItemId)
        {
            return await Task<RenderedItemData>.Factory.FromAsync(Channel.BeginGetWorkItemSnapshot, Channel.EndGetWorkItemSnapshot, workItemId, null);
        }



        public PublishInfoData[] GetListPublishInfo(string itemId)
        {
            return this.Channel.GetListPublishInfo(itemId);
        }

        public async Task<PublishInfoData[]> GetListPublishInfoAsync(string itemId)
        {
            return await Task<PublishInfoData[]>.Factory.FromAsync(Channel.BeginGetListPublishInfo, Channel.EndGetListPublishInfo, itemId, null);
        }

      

        public ActionFlags CastActions(int numericActions)
        {
            return this.Channel.CastActions(numericActions);
        }

        public async Task<ActionFlags> CastActionsAsync(int numericActions)
        {
            return await Task<ActionFlags>.Factory.FromAsync(Channel.BeginCastActions, Channel.EndCastActions, numericActions, null);
        }



        public void ValidateXml(IdentifiableObjectData data)
        {
            this.Channel.ValidateXml(data);
        }

        public async Task ValidateXmlAsync(IdentifiableObjectData data)
        {
            await Task.Factory.FromAsync(Channel.BeginValidateXml, Channel.EndValidateXml, data, null);
        }

        public bool IsValidTridionWebSchemaXml(SchemaData data)
        {
            return this.Channel.IsValidTridionWebSchemaXml(data);
        }

       

        public async Task<bool> IsValidTridionWebSchemaXmlAsync(SchemaData data)
        {
            return await Task<bool>.Factory.FromAsync(Channel.BeginIsValidTridionWebSchemaXml, Channel.EndIsValidTridionWebSchemaXml, data, null);
        }

       
        public ArrayOfTcmUri GetSubjectIdsWithApplicationData(string applicationId)
        {
            return this.Channel.GetSubjectIdsWithApplicationData(applicationId);
        }


        public async Task<ArrayOfTcmUri> GetSubjectIdsWithApplicationDataAsync(string applicationId)
        {
            return await Task<ArrayOfTcmUri>.Factory.FromAsync(Channel.BeginGetSubjectIdsWithApplicationData, Channel.EndGetSubjectIdsWithApplicationData, applicationId, null);
        }

     

        public ApplicationDataDictionary ReadApplicationDataForSubjectsIds(string[] subjectIds, string[] applicationIds)
        {
            return this.Channel.ReadApplicationDataForSubjectsIds(subjectIds, applicationIds);
        }

        

        public async Task<ApplicationDataDictionary> ReadApplicationDataForSubjectsIdsAsync(string[] subjectIds, string[] applicationIds)
        {
            return await Task<ApplicationDataDictionary>.Factory.FromAsync(Channel.BeginReadApplicationDataForSubjectsIds, Channel.EndReadApplicationDataForSubjectsIds, subjectIds, applicationIds, null);
        }

        

        public SecurityDescriptorDataDictionary GetSecurityDescriptorsForSubjectsIds(string[] subjectIds)
        {
            return this.Channel.GetSecurityDescriptorsForSubjectsIds(subjectIds);
        }

       

        public async Task<SecurityDescriptorDataDictionary> GetSecurityDescriptorsForSubjectsIdsAsync(string[] subjectIds)
        {
            return await Task<SecurityDescriptorDataDictionary>.Factory.FromAsync(Channel.BeginGetSecurityDescriptorsForSubjectsIds, Channel.EndGetSecurityDescriptorsForSubjectsIds, subjectIds, null);
        }


        public SecurityDescriptorDataDictionary GetContentSecurityDescriptorsForOrgItemIds(string[] organizationalItemIds)
        {
            return this.Channel.GetContentSecurityDescriptorsForOrgItemIds(organizationalItemIds);
        }

       

        public async Task<SecurityDescriptorDataDictionary> GetContentSecurityDescriptorsForOrgItemIdsAsync(string[] organizationalItemIds)
        {
            return await Task<SecurityDescriptorDataDictionary>.Factory.FromAsync(Channel.BeginGetContentSecurityDescriptorsForOrgItemIds, Channel.EndGetContentSecurityDescriptorsForOrgItemIds, organizationalItemIds, null);
        }


        public void ReIndex(string id)
        {
            this.Channel.ReIndex(id);
        }

      

        public async Task ReIndexAsync(string id)
        {
            await Task.Factory.FromAsync(Channel.BeginReIndex, Channel.EndReIndex, id, null);
        }

     

        public PredefinedQueue? CastPredefinedQueue(int queueId)
        {
            return this.Channel.CastPredefinedQueue(queueId);
        }

      

        public async Task<PredefinedQueue?> CastPredefinedQueueAsync(int queueId)
        {
            return await Task<PredefinedQueue?>.Factory.FromAsync(Channel.BeginCastPredefinedQueue, Channel.EndCastPredefinedQueue, queueId, null);
        }


        public int PurgeOldVersions(PurgeOldVersionsInstructionData instruction)
        {
            return this.Channel.PurgeOldVersions(instruction);
        }

        
        public async Task<int> PurgeOldVersionsAsync(PurgeOldVersionsInstructionData instruction)
        {
            return await Task<int>.Factory.FromAsync(Channel.BeginPurgeOldVersions, Channel.EndPurgeOldVersions, instruction, null);
        }

    
        public XElement GetListExternalLinks(string id)
        {
            return this.Channel.GetListExternalLinks(id);
        }





        public async Task<XElement> GetListExternalLinksAsync(string id)
        {
            return await Task< XElement>.Factory.FromAsync(Channel.BeginGetListExternalLinks, Channel.EndGetListExternalLinks, id, null);
        }

        public SearchQueryData ConvertXmlToSearchQuery(XElement searchQueryXml)
        {
            return this.Channel.ConvertXmlToSearchQuery(searchQueryXml);
        }

        public async Task<SearchQueryData> ConvertXmlToSearchQueryAsync(XElement searchQueryXml)
        {
            return await Task<SearchQueryData>.Factory.FromAsync(Channel.BeginConvertXmlToSearchQuery, Channel.EndConvertXmlToSearchQuery, searchQueryXml, null);
        }


        public XElement ConvertSearchQueryToXml(SearchQueryData searchQueryData)
        {
            return this.Channel.ConvertSearchQueryToXml(searchQueryData);
        }


        public async Task<XElement> ConvertSearchQueryToXmlAsync(SearchQueryData searchQueryData)
        {
            return await Task<XElement>.Factory.FromAsync(Channel.BeginConvertSearchQueryToXml, Channel.EndConvertSearchQueryToXml, searchQueryData, null);
        }


        public VersionedItemData CheckIn(string id, ReadOptions readBackOptions)
        {
            return this.CheckIn(id, true, null, readBackOptions);
        }

        public SchemaFieldsData ConvertXsdToSchemaFields(XElement xsd, SchemaPurpose purpose, ReadOptions readOptions)
        {
            return this.ConvertXsdToSchemaFields(xsd, purpose, null, readOptions);
        }

        public void EnlistInTransaction()
        {
            Channel.EnlistInTransaction();
        }

        public async Task EnlistInTransactionAsync()
        {
            await Task.Factory.FromAsync(Channel.BeginEnlistInTransaction, Channel.EndEnlistInTransaction, null);
        }

        public string GetSessionId()
        {
            return Channel.GetSessionId();
        }

        public async Task<string> GetSessionIdAsync()
        {
            return await Task<string>.Factory.FromAsync(Channel.BeginGetSessionId, Channel.EndGetSessionId, null);
        }

        public int GetSessionTransactionTimeout()
        {
            return Channel.GetSessionTransactionTimeout();
        }

        public async Task<int> GetSessionTransactionTimeoutAsync()
        {
            return await Task<int>.Factory.FromAsync(Channel.BeginGetSessionTransactionTimeout, Channel.EndGetSessionTransactionTimeout, null);
        }

        public SchemaData GetVirtualFolderTypeSchema(string namespaceUri)
        {
            return Channel.GetVirtualFolderTypeSchema(namespaceUri);
        }

        public async Task<SchemaData> GetVirtualFolderTypeSchemaAsync(string namespaceUri)
        {
            return await Task<SchemaData>.Factory.FromAsync(Channel.BeginGetVirtualFolderTypeSchema, Channel.EndGetVirtualFolderTypeSchema, namespaceUri, null);
        }

        public Task<ActivityInstanceData> ResumeActivityActivity(string activityInstanceId, ReadOptions readOptions = null)
        {
            throw new NotImplementedException();
        }

        public void SetSessionContextData(ApplicationData appData)
        {
            Channel.SetSessionContextData(appData);
        }

        public async Task SetSessionContextDataAsync(ApplicationData appData)
        {
            await Task.Factory.FromAsync(Channel.BeginSetSessionContextData, Channel.EndSetSessionContextData, appData, null);
        }

        public void SetSessionTransactionTimeout(int transactionTimeout)
        {
            Channel.SetSessionTransactionTimeout(transactionTimeout);
        }

        public async Task SetSessionTransactionTimeoutAsync(int transactionTimeout)
        {
            await Task.Factory.FromAsync(Channel.BeginSetSessionTransactionTimeout, Channel.EndSetSessionTransactionTimeout, transactionTimeout, null);
        }

        public void SetWebDavUrlPrefix(string prefix)
        {
            Channel.SetWebDavUrlPrefix(prefix);
        }

        public async Task SetWebDavUrlPrefixAsync(string prefix)
        {
            await Task.Factory.FromAsync(Channel.BeginSetWebDavUrlPrefix, Channel.EndSetWebDavUrlPrefix, prefix, null);
        }

        public bool StartCaching()
        {
            return Channel.StartCaching();
        }

        public async Task<bool> StartCachingAsync()
        {
            return await Task<bool>.Factory.FromAsync(Channel.BeginStartCaching, Channel.EndStartCaching, null);
        }

        public void StopCaching()
        {
            Channel.StopCaching();
        }

        public async Task StopCachingAsync()
        {
            await Task.Factory.FromAsync(Channel.BeginStopCaching, Channel.EndStopCaching, null);
        }

        public void TerminateSession()
        {
            Channel.TerminateSession();
        }

        public async Task TerminateSessionAsync()
        {
            await Task.Factory.FromAsync(Channel.BeginTerminateSession, Channel.EndTerminateSession, null);
        }

        public PublishTransactionData UndoPublishTransaction(string publishTransactionId, QueueMessagePriority? priority = default(QueueMessagePriority?), ReadOptions readBackOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<PublishTransactionData> UndoPublishTransactionAsync(string publishTransactionId, QueueMessagePriority? priority = default(QueueMessagePriority?), ReadOptions readBackOptions = null)
        {
            throw new NotImplementedException();
        }

        public UserData GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        public Task<UserData> GetCurrentUserAsync()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Finalizer
        /// </summary>
        ~AlchemyCoreServiceClient201603()
        {
            Dispose(false);
        }
    }
}
