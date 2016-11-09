using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201501", ConfigurationName = "Alchemy4Tridion.Plugins.Clients.CoreService.ICoreServiceBatch")]
	public interface ICoreServiceBatch
	{
		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatch", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchResponse")]
		AccessTokenData ImpersonateBatch(string userName);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatch", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchResponse")]
		IAsyncResult BeginImpersonateBatch(string userName, AsyncCallback callback, object asyncState);

		AccessTokenData EndImpersonateBatch(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithTokenCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithToken", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithTokenResponse")]
		void ImpersonateBatchWithToken(AccessTokenData accessTokenData);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithToken", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithTokenResponse")]
		IAsyncResult BeginImpersonateBatchWithToken(AccessTokenData accessTokenData, AsyncCallback callback, object asyncState);

		void EndImpersonateBatchWithToken(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithClaimsCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithClaims", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithClaimsResponse")]
		AccessTokenData ImpersonateBatchWithClaims(ClaimData[] claims);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithClaims", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/ImpersonateBatchWithClaimsResponse")]
		IAsyncResult BeginImpersonateBatchWithClaims(ClaimData[] claims, AsyncCallback callback, object asyncState);

		AccessTokenData EndImpersonateBatchWithClaims(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchLocalizeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchLocalize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchLocalizeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchLocalize(WeakLink[] subjectLinks);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchLocalize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchLocalizeResponse")]
		IAsyncResult BeginBatchLocalize(WeakLink[] subjectLinks, AsyncCallback callback, object asyncState);

		string EndBatchLocalize(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnLocalizeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnLocalize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnLocalizeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchUnLocalize(WeakLink[] subjectLinks);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnLocalize", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnLocalizeResponse")]
		IAsyncResult BeginBatchUnLocalize(WeakLink[] subjectLinks, AsyncCallback callback, object asyncState);

		string EndBatchUnLocalize(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPromoteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPromote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPromoteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchPromote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPromote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPromoteResponse")]
		IAsyncResult BeginBatchPromote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction, AsyncCallback callback, object asyncState);

		string EndBatchPromote(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDemoteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDemote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDemoteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchDemote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDemote", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDemoteResponse")]
		IAsyncResult BeginBatchDemote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction, AsyncCallback callback, object asyncState);

		string EndBatchDemote(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopy", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchCopy(WeakLink[] subjectLinks, string destinationId, bool makeUnique);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopy", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyResponse")]
		IAsyncResult BeginBatchCopy(WeakLink[] subjectLinks, string destinationId, bool makeUnique, AsyncCallback callback, object asyncState);

		string EndBatchCopy(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMove", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchMove(WeakLink[] subjectLinks, string destinationId);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMove", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveResponse")]
		IAsyncResult BeginBatchMove(WeakLink[] subjectLinks, string destinationId, AsyncCallback callback, object asyncState);

		string EndBatchMove(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckInCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckIn", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckInResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchCheckIn(WeakLink[] subjectLinks, bool removePermanentLock, string userComment);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckIn", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckInResponse")]
		IAsyncResult BeginBatchCheckIn(WeakLink[] subjectLinks, bool removePermanentLock, string userComment, AsyncCallback callback, object asyncState);

		string EndBatchCheckIn(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchCheckOut(WeakLink[] subjectLinks, bool permanentLock);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCheckOutResponse")]
		IAsyncResult BeginBatchCheckOut(WeakLink[] subjectLinks, bool permanentLock, AsyncCallback callback, object asyncState);

		string EndBatchCheckOut(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDelete", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchDelete(WeakLink[] subjectLinks);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDelete", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteResponse")]
		IAsyncResult BeginBatchDelete(WeakLink[] subjectLinks, AsyncCallback callback, object asyncState);

		string EndBatchDelete(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPublishCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPublish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPublishResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchPublish(WeakLink[] subjectLinks, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPublish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchPublishResponse")]
		IAsyncResult BeginBatchPublish(WeakLink[] subjectLinks, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, AsyncCallback callback, object asyncState);

		string EndBatchPublish(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnPublishCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnPublish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnPublishResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchUnPublish(WeakLink[] subjectLinks, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnPublish", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnPublishResponse")]
		IAsyncResult BeginBatchUnPublish(WeakLink[] subjectLinks, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, AsyncCallback callback, object asyncState);

		string EndBatchUnPublish(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUndoCheckOutCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUndoCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUndoCheckOutResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchUndoCheckOut(WeakLink[] subjectLinks, bool permanentLock);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUndoCheckOut", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUndoCheckOutResponse")]
		IAsyncResult BeginBatchUndoCheckOut(WeakLink[] subjectLinks, bool permanentLock, AsyncCallback callback, object asyncState);

		string EndBatchUndoCheckOut(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchStartActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchStartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchStartActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchStartActivity(WeakLink[] activityInstanceLinks);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchStartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchStartActivityResponse")]
		IAsyncResult BeginBatchStartActivity(WeakLink[] activityInstanceLinks, AsyncCallback callback, object asyncState);

		string EndBatchStartActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchFinishActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchFinishActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchFinishActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchFinishActivity(WeakLink[] activityInstanceLinks, ActivityFinishData activityFinishData);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchFinishActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchFinishActivityResponse")]
		IAsyncResult BeginBatchFinishActivity(WeakLink[] activityInstanceLinks, ActivityFinishData activityFinishData, AsyncCallback callback, object asyncState);

		string EndBatchFinishActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchForceFinishProcessCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchForceFinishProcess", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchForceFinishProcessResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchForceFinishProcess(WeakLink[] processInstanceLinks, string approvalStatusId);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchForceFinishProcess", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchForceFinishProcessResponse")]
		IAsyncResult BeginBatchForceFinishProcess(WeakLink[] processInstanceLinks, string approvalStatusId, AsyncCallback callback, object asyncState);

		string EndBatchForceFinishProcess(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchClassify(WeakLink[] subjectLinks, string[] keywordIds);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchClassifyResponse")]
		IAsyncResult BeginBatchClassify(WeakLink[] subjectLinks, string[] keywordIds, AsyncCallback callback, object asyncState);

		string EndBatchClassify(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchUnClassify(WeakLink[] subjectLinks, string[] keywordIds);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchUnClassifyResponse")]
		IAsyncResult BeginBatchUnClassify(WeakLink[] subjectLinks, string[] keywordIds, AsyncCallback callback, object asyncState);

		string EndBatchUnClassify(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReClassifyCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReClassifyResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchReClassify(WeakLink[] subjectLinks, string[] keywordIdsToRemove, string[] keywordIdsToAdd);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReClassify", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReClassifyResponse")]
		IAsyncResult BeginBatchReClassify(WeakLink[] subjectLinks, string[] keywordIdsToRemove, string[] keywordIdsToAdd, AsyncCallback callback, object asyncState);

		string EndBatchReClassify(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteTaxonomyNodeCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteTaxonomyNode", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteTaxonomyNodeResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchDeleteTaxonomyNode(WeakLink[] subjectLinks, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteTaxonomyNode", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchDeleteTaxonomyNodeResponse")]
		IAsyncResult BeginBatchDeleteTaxonomyNode(WeakLink[] subjectLinks, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, AsyncCallback callback, object asyncState);

		string EndBatchDeleteTaxonomyNode(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSwitchUserEnabledStateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSwitchUserEnabledState", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSwitchUserEnabledStateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchSwitchUserEnabledState(WeakLink[] subjectLinks, bool isEnabled);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSwitchUserEnabledState", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSwitchUserEnabledStateResponse")]
		IAsyncResult BeginBatchSwitchUserEnabledState(WeakLink[] subjectLinks, bool isEnabled, AsyncCallback callback, object asyncState);

		string EndBatchSwitchUserEnabledState(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyToKeywordCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyToKeywordResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchCopyToKeyword(WeakLink[] subjectLinks, string destinationId);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchCopyToKeywordResponse")]
		IAsyncResult BeginBatchCopyToKeyword(WeakLink[] subjectLinks, string destinationId, AsyncCallback callback, object asyncState);

		string EndBatchCopyToKeyword(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveToKeywordCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveToKeywordResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchMoveToKeyword(WeakLink[] subjectLinks, string destinationId);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveToKeyword", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchMoveToKeywordResponse")]
		IAsyncResult BeginBatchMoveToKeyword(WeakLink[] subjectLinks, string destinationId, AsyncCallback callback, object asyncState);

		string EndBatchMoveToKeyword(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReAssignActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReAssignActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReAssignActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchReAssignActivity(WeakLink[] activityInstanceLinks, string newAssigneeId);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReAssignActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchReAssignActivityResponse")]
		IAsyncResult BeginBatchReAssignActivity(WeakLink[] activityInstanceLinks, string newAssigneeId, AsyncCallback callback, object asyncState);

		string EndBatchReAssignActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchRestartActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchRestartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchRestartActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchRestartActivity(WeakLink[] activityInstanceLinks);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchRestartActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchRestartActivityResponse")]
		IAsyncResult BeginBatchRestartActivity(WeakLink[] activityInstanceLinks, AsyncCallback callback, object asyncState);

		string EndBatchRestartActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSuspendActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSuspendActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSuspendActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchSuspendActivity(WeakLink[] activityInstanceLinks, string reason);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSuspendActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSuspendActivityResponse")]
		IAsyncResult BeginBatchSuspendActivity(WeakLink[] activityInstanceLinks, string reason, AsyncCallback callback, object asyncState);

		string EndBatchSuspendActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchResumeActivityCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchResumeActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchResumeActivityResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchResumeActivity(WeakLink[] activityInstanceLinks);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchResumeActivity", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchResumeActivityResponse")]
		IAsyncResult BeginBatchResumeActivity(WeakLink[] activityInstanceLinks, AsyncCallback callback, object asyncState);

		string EndBatchResumeActivity(IAsyncResult result);

		[FaultContract(typeof(CoreServiceFault), Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSynchronizeWithSchemaAndUpdateCoreServiceFaultFault", Name = "CoreServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), OperationContract(Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSynchronizeWithSchemaAndUpdate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSynchronizeWithSchemaAndUpdateResponse"), TransactionFlow(TransactionFlowOption.Allowed)]
		string BatchSynchronizeWithSchemaAndUpdate(WeakLink[] subjectLinks, SynchronizeOptions synchOptions);

		[OperationContract(AsyncPattern = true, Action = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSynchronizeWithSchemaAndUpdate", ReplyAction = "http://www.sdltridion.com/ContentManager/CoreService/201501/ICoreServiceBatch/BatchSynchronizeWithSchemaAndUpdateResponse")]
		IAsyncResult BeginBatchSynchronizeWithSchemaAndUpdate(WeakLink[] subjectLinks, SynchronizeOptions synchOptions, AsyncCallback callback, object asyncState);

		string EndBatchSynchronizeWithSchemaAndUpdate(IAsyncResult result);
	}
}
