using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class CoreServiceBatchClient : ClientBase<ICoreServiceBatch>, ICoreServiceBatch, IDisposable
	{
		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginImpersonateBatchDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndImpersonateBatchDelegate;

		private SendOrPostCallback onImpersonateBatchCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginImpersonateBatchWithTokenDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndImpersonateBatchWithTokenDelegate;

		private SendOrPostCallback onImpersonateBatchWithTokenCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginImpersonateBatchWithClaimsDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndImpersonateBatchWithClaimsDelegate;

		private SendOrPostCallback onImpersonateBatchWithClaimsCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchLocalizeDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchLocalizeDelegate;

		private SendOrPostCallback onBatchLocalizeCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchUnLocalizeDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchUnLocalizeDelegate;

		private SendOrPostCallback onBatchUnLocalizeCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchPromoteDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchPromoteDelegate;

		private SendOrPostCallback onBatchPromoteCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchDemoteDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchDemoteDelegate;

		private SendOrPostCallback onBatchDemoteCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchCopyDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchCopyDelegate;

		private SendOrPostCallback onBatchCopyCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchMoveDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchMoveDelegate;

		private SendOrPostCallback onBatchMoveCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchCheckInDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchCheckInDelegate;

		private SendOrPostCallback onBatchCheckInCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchCheckOutDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchCheckOutDelegate;

		private SendOrPostCallback onBatchCheckOutCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchDeleteDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchDeleteDelegate;

		private SendOrPostCallback onBatchDeleteCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchPublishDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchPublishDelegate;

		private SendOrPostCallback onBatchPublishCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchUnPublishDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchUnPublishDelegate;

		private SendOrPostCallback onBatchUnPublishCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchUndoCheckOutDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchUndoCheckOutDelegate;

		private SendOrPostCallback onBatchUndoCheckOutCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchStartActivityDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchStartActivityDelegate;

		private SendOrPostCallback onBatchStartActivityCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchFinishActivityDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchFinishActivityDelegate;

		private SendOrPostCallback onBatchFinishActivityCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchForceFinishProcessDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchForceFinishProcessDelegate;

		private SendOrPostCallback onBatchForceFinishProcessCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchClassifyDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchClassifyDelegate;

		private SendOrPostCallback onBatchClassifyCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchUnClassifyDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchUnClassifyDelegate;

		private SendOrPostCallback onBatchUnClassifyCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchReClassifyDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchReClassifyDelegate;

		private SendOrPostCallback onBatchReClassifyCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchDeleteTaxonomyNodeDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchDeleteTaxonomyNodeDelegate;

		private SendOrPostCallback onBatchDeleteTaxonomyNodeCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchSwitchUserEnabledStateDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchSwitchUserEnabledStateDelegate;

		private SendOrPostCallback onBatchSwitchUserEnabledStateCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchCopyToKeywordDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchCopyToKeywordDelegate;

		private SendOrPostCallback onBatchCopyToKeywordCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchMoveToKeywordDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchMoveToKeywordDelegate;

		private SendOrPostCallback onBatchMoveToKeywordCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchReAssignActivityDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchReAssignActivityDelegate;

		private SendOrPostCallback onBatchReAssignActivityCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchRestartActivityDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchRestartActivityDelegate;

		private SendOrPostCallback onBatchRestartActivityCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchSuspendActivityDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchSuspendActivityDelegate;

		private SendOrPostCallback onBatchSuspendActivityCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchResumeActivityDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchResumeActivityDelegate;

		private SendOrPostCallback onBatchResumeActivityCompletedDelegate;

		private ClientBase<ICoreServiceBatch>.BeginOperationDelegate onBeginBatchSynchronizeWithSchemaAndUpdateDelegate;

		private ClientBase<ICoreServiceBatch>.EndOperationDelegate onEndBatchSynchronizeWithSchemaAndUpdateDelegate;

		private SendOrPostCallback onBatchSynchronizeWithSchemaAndUpdateCompletedDelegate;

		public event EventHandler<ImpersonateBatchCompletedEventArgs> ImpersonateBatchCompleted;

		public event EventHandler<AsyncCompletedEventArgs> ImpersonateBatchWithTokenCompleted;

		public event EventHandler<ImpersonateBatchWithClaimsCompletedEventArgs> ImpersonateBatchWithClaimsCompleted;

		public event EventHandler<BatchLocalizeCompletedEventArgs> BatchLocalizeCompleted;

		public event EventHandler<BatchUnLocalizeCompletedEventArgs> BatchUnLocalizeCompleted;

		public event EventHandler<BatchPromoteCompletedEventArgs> BatchPromoteCompleted;

		public event EventHandler<BatchDemoteCompletedEventArgs> BatchDemoteCompleted;

		public event EventHandler<BatchCopyCompletedEventArgs> BatchCopyCompleted;

		public event EventHandler<BatchMoveCompletedEventArgs> BatchMoveCompleted;

		public event EventHandler<BatchCheckInCompletedEventArgs> BatchCheckInCompleted;

		public event EventHandler<BatchCheckOutCompletedEventArgs> BatchCheckOutCompleted;

		public event EventHandler<BatchDeleteCompletedEventArgs> BatchDeleteCompleted;

		public event EventHandler<BatchPublishCompletedEventArgs> BatchPublishCompleted;

		public event EventHandler<BatchUnPublishCompletedEventArgs> BatchUnPublishCompleted;

		public event EventHandler<BatchUndoCheckOutCompletedEventArgs> BatchUndoCheckOutCompleted;

		public event EventHandler<BatchStartActivityCompletedEventArgs> BatchStartActivityCompleted;

		public event EventHandler<BatchFinishActivityCompletedEventArgs> BatchFinishActivityCompleted;

		public event EventHandler<BatchForceFinishProcessCompletedEventArgs> BatchForceFinishProcessCompleted;

		public event EventHandler<BatchClassifyCompletedEventArgs> BatchClassifyCompleted;

		public event EventHandler<BatchUnClassifyCompletedEventArgs> BatchUnClassifyCompleted;

		public event EventHandler<BatchReClassifyCompletedEventArgs> BatchReClassifyCompleted;

		public event EventHandler<BatchDeleteTaxonomyNodeCompletedEventArgs> BatchDeleteTaxonomyNodeCompleted;

		public event EventHandler<BatchSwitchUserEnabledStateCompletedEventArgs> BatchSwitchUserEnabledStateCompleted;

		public event EventHandler<BatchCopyToKeywordCompletedEventArgs> BatchCopyToKeywordCompleted;

		public event EventHandler<BatchMoveToKeywordCompletedEventArgs> BatchMoveToKeywordCompleted;

		public event EventHandler<BatchReAssignActivityCompletedEventArgs> BatchReAssignActivityCompleted;

		public event EventHandler<BatchRestartActivityCompletedEventArgs> BatchRestartActivityCompleted;

		public event EventHandler<BatchSuspendActivityCompletedEventArgs> BatchSuspendActivityCompleted;

		public event EventHandler<BatchResumeActivityCompletedEventArgs> BatchResumeActivityCompleted;

		public event EventHandler<BatchSynchronizeWithSchemaAndUpdateCompletedEventArgs> BatchSynchronizeWithSchemaAndUpdateCompleted;

		public CoreServiceBatchClient()
		{
		}

		public CoreServiceBatchClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public CoreServiceBatchClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public CoreServiceBatchClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public CoreServiceBatchClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		public AccessTokenData ImpersonateBatch(string userName)
		{
			return base.Channel.ImpersonateBatch(userName);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginImpersonateBatch(string userName, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginImpersonateBatch(userName, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public AccessTokenData EndImpersonateBatch(IAsyncResult result)
		{
			return base.Channel.EndImpersonateBatch(result);
		}

		private IAsyncResult OnBeginImpersonateBatch(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string userName = (string)inValues[0];
			return this.BeginImpersonateBatch(userName, callback, asyncState);
		}

		private object[] OnEndImpersonateBatch(IAsyncResult result)
		{
			AccessTokenData accessTokenData = this.EndImpersonateBatch(result);
			return new object[]
			{
				accessTokenData
			};
		}

		private void OnImpersonateBatchCompleted(object state)
		{
			if (this.ImpersonateBatchCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.ImpersonateBatchCompleted(this, new ImpersonateBatchCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ImpersonateBatchAsync(string userName)
		{
			this.ImpersonateBatchAsync(userName, null);
		}

		public void ImpersonateBatchAsync(string userName, object userState)
		{
			if (this.onBeginImpersonateBatchDelegate == null)
			{
				this.onBeginImpersonateBatchDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginImpersonateBatch);
			}
			if (this.onEndImpersonateBatchDelegate == null)
			{
				this.onEndImpersonateBatchDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndImpersonateBatch);
			}
			if (this.onImpersonateBatchCompletedDelegate == null)
			{
				this.onImpersonateBatchCompletedDelegate = new SendOrPostCallback(this.OnImpersonateBatchCompleted);
			}
			base.InvokeAsync(this.onBeginImpersonateBatchDelegate, new object[]
			{
				userName
			}, this.onEndImpersonateBatchDelegate, this.onImpersonateBatchCompletedDelegate, userState);
		}

		public void ImpersonateBatchWithToken(AccessTokenData accessTokenData)
		{
			base.Channel.ImpersonateBatchWithToken(accessTokenData);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginImpersonateBatchWithToken(AccessTokenData accessTokenData, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginImpersonateBatchWithToken(accessTokenData, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndImpersonateBatchWithToken(IAsyncResult result)
		{
			base.Channel.EndImpersonateBatchWithToken(result);
		}

		private IAsyncResult OnBeginImpersonateBatchWithToken(object[] inValues, AsyncCallback callback, object asyncState)
		{
			AccessTokenData accessTokenData = (AccessTokenData)inValues[0];
			return this.BeginImpersonateBatchWithToken(accessTokenData, callback, asyncState);
		}

		private object[] OnEndImpersonateBatchWithToken(IAsyncResult result)
		{
			this.EndImpersonateBatchWithToken(result);
			return null;
		}

		private void OnImpersonateBatchWithTokenCompleted(object state)
		{
			if (this.ImpersonateBatchWithTokenCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.ImpersonateBatchWithTokenCompleted(this, new AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ImpersonateBatchWithTokenAsync(AccessTokenData accessTokenData)
		{
			this.ImpersonateBatchWithTokenAsync(accessTokenData, null);
		}

		public void ImpersonateBatchWithTokenAsync(AccessTokenData accessTokenData, object userState)
		{
			if (this.onBeginImpersonateBatchWithTokenDelegate == null)
			{
				this.onBeginImpersonateBatchWithTokenDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginImpersonateBatchWithToken);
			}
			if (this.onEndImpersonateBatchWithTokenDelegate == null)
			{
				this.onEndImpersonateBatchWithTokenDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndImpersonateBatchWithToken);
			}
			if (this.onImpersonateBatchWithTokenCompletedDelegate == null)
			{
				this.onImpersonateBatchWithTokenCompletedDelegate = new SendOrPostCallback(this.OnImpersonateBatchWithTokenCompleted);
			}
			base.InvokeAsync(this.onBeginImpersonateBatchWithTokenDelegate, new object[]
			{
				accessTokenData
			}, this.onEndImpersonateBatchWithTokenDelegate, this.onImpersonateBatchWithTokenCompletedDelegate, userState);
		}

		public AccessTokenData ImpersonateBatchWithClaims(ClaimData[] claims)
		{
			return base.Channel.ImpersonateBatchWithClaims(claims);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginImpersonateBatchWithClaims(ClaimData[] claims, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginImpersonateBatchWithClaims(claims, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public AccessTokenData EndImpersonateBatchWithClaims(IAsyncResult result)
		{
			return base.Channel.EndImpersonateBatchWithClaims(result);
		}

		private IAsyncResult OnBeginImpersonateBatchWithClaims(object[] inValues, AsyncCallback callback, object asyncState)
		{
			ClaimData[] claims = (ClaimData[])inValues[0];
			return this.BeginImpersonateBatchWithClaims(claims, callback, asyncState);
		}

		private object[] OnEndImpersonateBatchWithClaims(IAsyncResult result)
		{
			AccessTokenData accessTokenData = this.EndImpersonateBatchWithClaims(result);
			return new object[]
			{
				accessTokenData
			};
		}

		private void OnImpersonateBatchWithClaimsCompleted(object state)
		{
			if (this.ImpersonateBatchWithClaimsCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.ImpersonateBatchWithClaimsCompleted(this, new ImpersonateBatchWithClaimsCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void ImpersonateBatchWithClaimsAsync(ClaimData[] claims)
		{
			this.ImpersonateBatchWithClaimsAsync(claims, null);
		}

		public void ImpersonateBatchWithClaimsAsync(ClaimData[] claims, object userState)
		{
			if (this.onBeginImpersonateBatchWithClaimsDelegate == null)
			{
				this.onBeginImpersonateBatchWithClaimsDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginImpersonateBatchWithClaims);
			}
			if (this.onEndImpersonateBatchWithClaimsDelegate == null)
			{
				this.onEndImpersonateBatchWithClaimsDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndImpersonateBatchWithClaims);
			}
			if (this.onImpersonateBatchWithClaimsCompletedDelegate == null)
			{
				this.onImpersonateBatchWithClaimsCompletedDelegate = new SendOrPostCallback(this.OnImpersonateBatchWithClaimsCompleted);
			}
			base.InvokeAsync(this.onBeginImpersonateBatchWithClaimsDelegate, new object[]
			{
				claims
			}, this.onEndImpersonateBatchWithClaimsDelegate, this.onImpersonateBatchWithClaimsCompletedDelegate, userState);
		}

		public string BatchLocalize(WeakLink[] subjectLinks)
		{
			return base.Channel.BatchLocalize(subjectLinks);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchLocalize(WeakLink[] subjectLinks, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchLocalize(subjectLinks, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchLocalize(IAsyncResult result)
		{
			return base.Channel.EndBatchLocalize(result);
		}

		private IAsyncResult OnBeginBatchLocalize(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			return this.BeginBatchLocalize(subjectLinks, callback, asyncState);
		}

		private object[] OnEndBatchLocalize(IAsyncResult result)
		{
			string text = this.EndBatchLocalize(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchLocalizeCompleted(object state)
		{
			if (this.BatchLocalizeCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchLocalizeCompleted(this, new BatchLocalizeCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchLocalizeAsync(WeakLink[] subjectLinks)
		{
			this.BatchLocalizeAsync(subjectLinks, null);
		}

		public void BatchLocalizeAsync(WeakLink[] subjectLinks, object userState)
		{
			if (this.onBeginBatchLocalizeDelegate == null)
			{
				this.onBeginBatchLocalizeDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchLocalize);
			}
			if (this.onEndBatchLocalizeDelegate == null)
			{
				this.onEndBatchLocalizeDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchLocalize);
			}
			if (this.onBatchLocalizeCompletedDelegate == null)
			{
				this.onBatchLocalizeCompletedDelegate = new SendOrPostCallback(this.OnBatchLocalizeCompleted);
			}
			base.InvokeAsync(this.onBeginBatchLocalizeDelegate, new object[]
			{
				subjectLinks
			}, this.onEndBatchLocalizeDelegate, this.onBatchLocalizeCompletedDelegate, userState);
		}

		public string BatchUnLocalize(WeakLink[] subjectLinks)
		{
			return base.Channel.BatchUnLocalize(subjectLinks);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchUnLocalize(WeakLink[] subjectLinks, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchUnLocalize(subjectLinks, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchUnLocalize(IAsyncResult result)
		{
			return base.Channel.EndBatchUnLocalize(result);
		}

		private IAsyncResult OnBeginBatchUnLocalize(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			return this.BeginBatchUnLocalize(subjectLinks, callback, asyncState);
		}

		private object[] OnEndBatchUnLocalize(IAsyncResult result)
		{
			string text = this.EndBatchUnLocalize(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchUnLocalizeCompleted(object state)
		{
			if (this.BatchUnLocalizeCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchUnLocalizeCompleted(this, new BatchUnLocalizeCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchUnLocalizeAsync(WeakLink[] subjectLinks)
		{
			this.BatchUnLocalizeAsync(subjectLinks, null);
		}

		public void BatchUnLocalizeAsync(WeakLink[] subjectLinks, object userState)
		{
			if (this.onBeginBatchUnLocalizeDelegate == null)
			{
				this.onBeginBatchUnLocalizeDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchUnLocalize);
			}
			if (this.onEndBatchUnLocalizeDelegate == null)
			{
				this.onEndBatchUnLocalizeDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchUnLocalize);
			}
			if (this.onBatchUnLocalizeCompletedDelegate == null)
			{
				this.onBatchUnLocalizeCompletedDelegate = new SendOrPostCallback(this.OnBatchUnLocalizeCompleted);
			}
			base.InvokeAsync(this.onBeginBatchUnLocalizeDelegate, new object[]
			{
				subjectLinks
			}, this.onEndBatchUnLocalizeDelegate, this.onBatchUnLocalizeCompletedDelegate, userState);
		}

		public string BatchPromote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction)
		{
			return base.Channel.BatchPromote(subjectLinks, destinationRepositoryId, instruction);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchPromote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchPromote(subjectLinks, destinationRepositoryId, instruction, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchPromote(IAsyncResult result)
		{
			return base.Channel.EndBatchPromote(result);
		}

		private IAsyncResult OnBeginBatchPromote(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string destinationRepositoryId = (string)inValues[1];
			OperationInstruction instruction = (OperationInstruction)inValues[2];
			return this.BeginBatchPromote(subjectLinks, destinationRepositoryId, instruction, callback, asyncState);
		}

		private object[] OnEndBatchPromote(IAsyncResult result)
		{
			string text = this.EndBatchPromote(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchPromoteCompleted(object state)
		{
			if (this.BatchPromoteCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchPromoteCompleted(this, new BatchPromoteCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchPromoteAsync(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction)
		{
			this.BatchPromoteAsync(subjectLinks, destinationRepositoryId, instruction, null);
		}

		public void BatchPromoteAsync(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction, object userState)
		{
			if (this.onBeginBatchPromoteDelegate == null)
			{
				this.onBeginBatchPromoteDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchPromote);
			}
			if (this.onEndBatchPromoteDelegate == null)
			{
				this.onEndBatchPromoteDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchPromote);
			}
			if (this.onBatchPromoteCompletedDelegate == null)
			{
				this.onBatchPromoteCompletedDelegate = new SendOrPostCallback(this.OnBatchPromoteCompleted);
			}
			base.InvokeAsync(this.onBeginBatchPromoteDelegate, new object[]
			{
				subjectLinks,
				destinationRepositoryId,
				instruction
			}, this.onEndBatchPromoteDelegate, this.onBatchPromoteCompletedDelegate, userState);
		}

		public string BatchDemote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction)
		{
			return base.Channel.BatchDemote(subjectLinks, destinationRepositoryId, instruction);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchDemote(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchDemote(subjectLinks, destinationRepositoryId, instruction, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchDemote(IAsyncResult result)
		{
			return base.Channel.EndBatchDemote(result);
		}

		private IAsyncResult OnBeginBatchDemote(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string destinationRepositoryId = (string)inValues[1];
			OperationInstruction instruction = (OperationInstruction)inValues[2];
			return this.BeginBatchDemote(subjectLinks, destinationRepositoryId, instruction, callback, asyncState);
		}

		private object[] OnEndBatchDemote(IAsyncResult result)
		{
			string text = this.EndBatchDemote(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchDemoteCompleted(object state)
		{
			if (this.BatchDemoteCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchDemoteCompleted(this, new BatchDemoteCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchDemoteAsync(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction)
		{
			this.BatchDemoteAsync(subjectLinks, destinationRepositoryId, instruction, null);
		}

		public void BatchDemoteAsync(WeakLink[] subjectLinks, string destinationRepositoryId, OperationInstruction instruction, object userState)
		{
			if (this.onBeginBatchDemoteDelegate == null)
			{
				this.onBeginBatchDemoteDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchDemote);
			}
			if (this.onEndBatchDemoteDelegate == null)
			{
				this.onEndBatchDemoteDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchDemote);
			}
			if (this.onBatchDemoteCompletedDelegate == null)
			{
				this.onBatchDemoteCompletedDelegate = new SendOrPostCallback(this.OnBatchDemoteCompleted);
			}
			base.InvokeAsync(this.onBeginBatchDemoteDelegate, new object[]
			{
				subjectLinks,
				destinationRepositoryId,
				instruction
			}, this.onEndBatchDemoteDelegate, this.onBatchDemoteCompletedDelegate, userState);
		}

		public string BatchCopy(WeakLink[] subjectLinks, string destinationId, bool makeUnique)
		{
			return base.Channel.BatchCopy(subjectLinks, destinationId, makeUnique);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchCopy(WeakLink[] subjectLinks, string destinationId, bool makeUnique, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchCopy(subjectLinks, destinationId, makeUnique, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchCopy(IAsyncResult result)
		{
			return base.Channel.EndBatchCopy(result);
		}

		private IAsyncResult OnBeginBatchCopy(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string destinationId = (string)inValues[1];
			bool makeUnique = (bool)inValues[2];
			return this.BeginBatchCopy(subjectLinks, destinationId, makeUnique, callback, asyncState);
		}

		private object[] OnEndBatchCopy(IAsyncResult result)
		{
			string text = this.EndBatchCopy(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchCopyCompleted(object state)
		{
			if (this.BatchCopyCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchCopyCompleted(this, new BatchCopyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchCopyAsync(WeakLink[] subjectLinks, string destinationId, bool makeUnique)
		{
			this.BatchCopyAsync(subjectLinks, destinationId, makeUnique, null);
		}

		public void BatchCopyAsync(WeakLink[] subjectLinks, string destinationId, bool makeUnique, object userState)
		{
			if (this.onBeginBatchCopyDelegate == null)
			{
				this.onBeginBatchCopyDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchCopy);
			}
			if (this.onEndBatchCopyDelegate == null)
			{
				this.onEndBatchCopyDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchCopy);
			}
			if (this.onBatchCopyCompletedDelegate == null)
			{
				this.onBatchCopyCompletedDelegate = new SendOrPostCallback(this.OnBatchCopyCompleted);
			}
			base.InvokeAsync(this.onBeginBatchCopyDelegate, new object[]
			{
				subjectLinks,
				destinationId,
				makeUnique
			}, this.onEndBatchCopyDelegate, this.onBatchCopyCompletedDelegate, userState);
		}

		public string BatchMove(WeakLink[] subjectLinks, string destinationId)
		{
			return base.Channel.BatchMove(subjectLinks, destinationId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchMove(WeakLink[] subjectLinks, string destinationId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchMove(subjectLinks, destinationId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchMove(IAsyncResult result)
		{
			return base.Channel.EndBatchMove(result);
		}

		private IAsyncResult OnBeginBatchMove(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string destinationId = (string)inValues[1];
			return this.BeginBatchMove(subjectLinks, destinationId, callback, asyncState);
		}

		private object[] OnEndBatchMove(IAsyncResult result)
		{
			string text = this.EndBatchMove(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchMoveCompleted(object state)
		{
			if (this.BatchMoveCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchMoveCompleted(this, new BatchMoveCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchMoveAsync(WeakLink[] subjectLinks, string destinationId)
		{
			this.BatchMoveAsync(subjectLinks, destinationId, null);
		}

		public void BatchMoveAsync(WeakLink[] subjectLinks, string destinationId, object userState)
		{
			if (this.onBeginBatchMoveDelegate == null)
			{
				this.onBeginBatchMoveDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchMove);
			}
			if (this.onEndBatchMoveDelegate == null)
			{
				this.onEndBatchMoveDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchMove);
			}
			if (this.onBatchMoveCompletedDelegate == null)
			{
				this.onBatchMoveCompletedDelegate = new SendOrPostCallback(this.OnBatchMoveCompleted);
			}
			base.InvokeAsync(this.onBeginBatchMoveDelegate, new object[]
			{
				subjectLinks,
				destinationId
			}, this.onEndBatchMoveDelegate, this.onBatchMoveCompletedDelegate, userState);
		}

		public string BatchCheckIn(WeakLink[] subjectLinks, bool removePermanentLock, string userComment)
		{
			return base.Channel.BatchCheckIn(subjectLinks, removePermanentLock, userComment);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchCheckIn(WeakLink[] subjectLinks, bool removePermanentLock, string userComment, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchCheckIn(subjectLinks, removePermanentLock, userComment, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchCheckIn(IAsyncResult result)
		{
			return base.Channel.EndBatchCheckIn(result);
		}

		private IAsyncResult OnBeginBatchCheckIn(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			bool removePermanentLock = (bool)inValues[1];
			string userComment = (string)inValues[2];
			return this.BeginBatchCheckIn(subjectLinks, removePermanentLock, userComment, callback, asyncState);
		}

		private object[] OnEndBatchCheckIn(IAsyncResult result)
		{
			string text = this.EndBatchCheckIn(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchCheckInCompleted(object state)
		{
			if (this.BatchCheckInCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchCheckInCompleted(this, new BatchCheckInCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchCheckInAsync(WeakLink[] subjectLinks, bool removePermanentLock, string userComment)
		{
			this.BatchCheckInAsync(subjectLinks, removePermanentLock, userComment, null);
		}

		public void BatchCheckInAsync(WeakLink[] subjectLinks, bool removePermanentLock, string userComment, object userState)
		{
			if (this.onBeginBatchCheckInDelegate == null)
			{
				this.onBeginBatchCheckInDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchCheckIn);
			}
			if (this.onEndBatchCheckInDelegate == null)
			{
				this.onEndBatchCheckInDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchCheckIn);
			}
			if (this.onBatchCheckInCompletedDelegate == null)
			{
				this.onBatchCheckInCompletedDelegate = new SendOrPostCallback(this.OnBatchCheckInCompleted);
			}
			base.InvokeAsync(this.onBeginBatchCheckInDelegate, new object[]
			{
				subjectLinks,
				removePermanentLock,
				userComment
			}, this.onEndBatchCheckInDelegate, this.onBatchCheckInCompletedDelegate, userState);
		}

		public string BatchCheckOut(WeakLink[] subjectLinks, bool permanentLock)
		{
			return base.Channel.BatchCheckOut(subjectLinks, permanentLock);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchCheckOut(WeakLink[] subjectLinks, bool permanentLock, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchCheckOut(subjectLinks, permanentLock, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchCheckOut(IAsyncResult result)
		{
			return base.Channel.EndBatchCheckOut(result);
		}

		private IAsyncResult OnBeginBatchCheckOut(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			bool permanentLock = (bool)inValues[1];
			return this.BeginBatchCheckOut(subjectLinks, permanentLock, callback, asyncState);
		}

		private object[] OnEndBatchCheckOut(IAsyncResult result)
		{
			string text = this.EndBatchCheckOut(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchCheckOutCompleted(object state)
		{
			if (this.BatchCheckOutCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchCheckOutCompleted(this, new BatchCheckOutCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchCheckOutAsync(WeakLink[] subjectLinks, bool permanentLock)
		{
			this.BatchCheckOutAsync(subjectLinks, permanentLock, null);
		}

		public void BatchCheckOutAsync(WeakLink[] subjectLinks, bool permanentLock, object userState)
		{
			if (this.onBeginBatchCheckOutDelegate == null)
			{
				this.onBeginBatchCheckOutDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchCheckOut);
			}
			if (this.onEndBatchCheckOutDelegate == null)
			{
				this.onEndBatchCheckOutDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchCheckOut);
			}
			if (this.onBatchCheckOutCompletedDelegate == null)
			{
				this.onBatchCheckOutCompletedDelegate = new SendOrPostCallback(this.OnBatchCheckOutCompleted);
			}
			base.InvokeAsync(this.onBeginBatchCheckOutDelegate, new object[]
			{
				subjectLinks,
				permanentLock
			}, this.onEndBatchCheckOutDelegate, this.onBatchCheckOutCompletedDelegate, userState);
		}

		public string BatchDelete(WeakLink[] subjectLinks)
		{
			return base.Channel.BatchDelete(subjectLinks);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchDelete(WeakLink[] subjectLinks, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchDelete(subjectLinks, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchDelete(IAsyncResult result)
		{
			return base.Channel.EndBatchDelete(result);
		}

		private IAsyncResult OnBeginBatchDelete(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			return this.BeginBatchDelete(subjectLinks, callback, asyncState);
		}

		private object[] OnEndBatchDelete(IAsyncResult result)
		{
			string text = this.EndBatchDelete(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchDeleteCompleted(object state)
		{
			if (this.BatchDeleteCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchDeleteCompleted(this, new BatchDeleteCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchDeleteAsync(WeakLink[] subjectLinks)
		{
			this.BatchDeleteAsync(subjectLinks, null);
		}

		public void BatchDeleteAsync(WeakLink[] subjectLinks, object userState)
		{
			if (this.onBeginBatchDeleteDelegate == null)
			{
				this.onBeginBatchDeleteDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchDelete);
			}
			if (this.onEndBatchDeleteDelegate == null)
			{
				this.onEndBatchDeleteDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchDelete);
			}
			if (this.onBatchDeleteCompletedDelegate == null)
			{
				this.onBatchDeleteCompletedDelegate = new SendOrPostCallback(this.OnBatchDeleteCompleted);
			}
			base.InvokeAsync(this.onBeginBatchDeleteDelegate, new object[]
			{
				subjectLinks
			}, this.onEndBatchDeleteDelegate, this.onBatchDeleteCompletedDelegate, userState);
		}

		public string BatchPublish(WeakLink[] subjectLinks, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority)
		{
			return base.Channel.BatchPublish(subjectLinks, publishInstruction, targetIdsOrPurposes, priority);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchPublish(WeakLink[] subjectLinks, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchPublish(subjectLinks, publishInstruction, targetIdsOrPurposes, priority, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchPublish(IAsyncResult result)
		{
			return base.Channel.EndBatchPublish(result);
		}

		private IAsyncResult OnBeginBatchPublish(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			PublishInstructionData publishInstruction = (PublishInstructionData)inValues[1];
			string[] targetIdsOrPurposes = (string[])inValues[2];
			PublishPriority? priority = (PublishPriority?)inValues[3];
			return this.BeginBatchPublish(subjectLinks, publishInstruction, targetIdsOrPurposes, priority, callback, asyncState);
		}

		private object[] OnEndBatchPublish(IAsyncResult result)
		{
			string text = this.EndBatchPublish(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchPublishCompleted(object state)
		{
			if (this.BatchPublishCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchPublishCompleted(this, new BatchPublishCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchPublishAsync(WeakLink[] subjectLinks, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority)
		{
			this.BatchPublishAsync(subjectLinks, publishInstruction, targetIdsOrPurposes, priority, null);
		}

		public void BatchPublishAsync(WeakLink[] subjectLinks, PublishInstructionData publishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, object userState)
		{
			if (this.onBeginBatchPublishDelegate == null)
			{
				this.onBeginBatchPublishDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchPublish);
			}
			if (this.onEndBatchPublishDelegate == null)
			{
				this.onEndBatchPublishDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchPublish);
			}
			if (this.onBatchPublishCompletedDelegate == null)
			{
				this.onBatchPublishCompletedDelegate = new SendOrPostCallback(this.OnBatchPublishCompleted);
			}
			base.InvokeAsync(this.onBeginBatchPublishDelegate, new object[]
			{
				subjectLinks,
				publishInstruction,
				targetIdsOrPurposes,
				priority
			}, this.onEndBatchPublishDelegate, this.onBatchPublishCompletedDelegate, userState);
		}

		public string BatchUnPublish(WeakLink[] subjectLinks, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority)
		{
			return base.Channel.BatchUnPublish(subjectLinks, unPublishInstruction, targetIdsOrPurposes, priority);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchUnPublish(WeakLink[] subjectLinks, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchUnPublish(subjectLinks, unPublishInstruction, targetIdsOrPurposes, priority, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchUnPublish(IAsyncResult result)
		{
			return base.Channel.EndBatchUnPublish(result);
		}

		private IAsyncResult OnBeginBatchUnPublish(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			UnPublishInstructionData unPublishInstruction = (UnPublishInstructionData)inValues[1];
			string[] targetIdsOrPurposes = (string[])inValues[2];
			PublishPriority? priority = (PublishPriority?)inValues[3];
			return this.BeginBatchUnPublish(subjectLinks, unPublishInstruction, targetIdsOrPurposes, priority, callback, asyncState);
		}

		private object[] OnEndBatchUnPublish(IAsyncResult result)
		{
			string text = this.EndBatchUnPublish(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchUnPublishCompleted(object state)
		{
			if (this.BatchUnPublishCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchUnPublishCompleted(this, new BatchUnPublishCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchUnPublishAsync(WeakLink[] subjectLinks, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority)
		{
			this.BatchUnPublishAsync(subjectLinks, unPublishInstruction, targetIdsOrPurposes, priority, null);
		}

		public void BatchUnPublishAsync(WeakLink[] subjectLinks, UnPublishInstructionData unPublishInstruction, string[] targetIdsOrPurposes, PublishPriority? priority, object userState)
		{
			if (this.onBeginBatchUnPublishDelegate == null)
			{
				this.onBeginBatchUnPublishDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchUnPublish);
			}
			if (this.onEndBatchUnPublishDelegate == null)
			{
				this.onEndBatchUnPublishDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchUnPublish);
			}
			if (this.onBatchUnPublishCompletedDelegate == null)
			{
				this.onBatchUnPublishCompletedDelegate = new SendOrPostCallback(this.OnBatchUnPublishCompleted);
			}
			base.InvokeAsync(this.onBeginBatchUnPublishDelegate, new object[]
			{
				subjectLinks,
				unPublishInstruction,
				targetIdsOrPurposes,
				priority
			}, this.onEndBatchUnPublishDelegate, this.onBatchUnPublishCompletedDelegate, userState);
		}

		public string BatchUndoCheckOut(WeakLink[] subjectLinks, bool permanentLock)
		{
			return base.Channel.BatchUndoCheckOut(subjectLinks, permanentLock);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchUndoCheckOut(WeakLink[] subjectLinks, bool permanentLock, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchUndoCheckOut(subjectLinks, permanentLock, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchUndoCheckOut(IAsyncResult result)
		{
			return base.Channel.EndBatchUndoCheckOut(result);
		}

		private IAsyncResult OnBeginBatchUndoCheckOut(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			bool permanentLock = (bool)inValues[1];
			return this.BeginBatchUndoCheckOut(subjectLinks, permanentLock, callback, asyncState);
		}

		private object[] OnEndBatchUndoCheckOut(IAsyncResult result)
		{
			string text = this.EndBatchUndoCheckOut(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchUndoCheckOutCompleted(object state)
		{
			if (this.BatchUndoCheckOutCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchUndoCheckOutCompleted(this, new BatchUndoCheckOutCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchUndoCheckOutAsync(WeakLink[] subjectLinks, bool permanentLock)
		{
			this.BatchUndoCheckOutAsync(subjectLinks, permanentLock, null);
		}

		public void BatchUndoCheckOutAsync(WeakLink[] subjectLinks, bool permanentLock, object userState)
		{
			if (this.onBeginBatchUndoCheckOutDelegate == null)
			{
				this.onBeginBatchUndoCheckOutDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchUndoCheckOut);
			}
			if (this.onEndBatchUndoCheckOutDelegate == null)
			{
				this.onEndBatchUndoCheckOutDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchUndoCheckOut);
			}
			if (this.onBatchUndoCheckOutCompletedDelegate == null)
			{
				this.onBatchUndoCheckOutCompletedDelegate = new SendOrPostCallback(this.OnBatchUndoCheckOutCompleted);
			}
			base.InvokeAsync(this.onBeginBatchUndoCheckOutDelegate, new object[]
			{
				subjectLinks,
				permanentLock
			}, this.onEndBatchUndoCheckOutDelegate, this.onBatchUndoCheckOutCompletedDelegate, userState);
		}

		public string BatchStartActivity(WeakLink[] activityInstanceLinks)
		{
			return base.Channel.BatchStartActivity(activityInstanceLinks);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchStartActivity(WeakLink[] activityInstanceLinks, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchStartActivity(activityInstanceLinks, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchStartActivity(IAsyncResult result)
		{
			return base.Channel.EndBatchStartActivity(result);
		}

		private IAsyncResult OnBeginBatchStartActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] activityInstanceLinks = (WeakLink[])inValues[0];
			return this.BeginBatchStartActivity(activityInstanceLinks, callback, asyncState);
		}

		private object[] OnEndBatchStartActivity(IAsyncResult result)
		{
			string text = this.EndBatchStartActivity(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchStartActivityCompleted(object state)
		{
			if (this.BatchStartActivityCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchStartActivityCompleted(this, new BatchStartActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchStartActivityAsync(WeakLink[] activityInstanceLinks)
		{
			this.BatchStartActivityAsync(activityInstanceLinks, null);
		}

		public void BatchStartActivityAsync(WeakLink[] activityInstanceLinks, object userState)
		{
			if (this.onBeginBatchStartActivityDelegate == null)
			{
				this.onBeginBatchStartActivityDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchStartActivity);
			}
			if (this.onEndBatchStartActivityDelegate == null)
			{
				this.onEndBatchStartActivityDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchStartActivity);
			}
			if (this.onBatchStartActivityCompletedDelegate == null)
			{
				this.onBatchStartActivityCompletedDelegate = new SendOrPostCallback(this.OnBatchStartActivityCompleted);
			}
			base.InvokeAsync(this.onBeginBatchStartActivityDelegate, new object[]
			{
				activityInstanceLinks
			}, this.onEndBatchStartActivityDelegate, this.onBatchStartActivityCompletedDelegate, userState);
		}

		public string BatchFinishActivity(WeakLink[] activityInstanceLinks, ActivityFinishData activityFinishData)
		{
			return base.Channel.BatchFinishActivity(activityInstanceLinks, activityFinishData);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchFinishActivity(WeakLink[] activityInstanceLinks, ActivityFinishData activityFinishData, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchFinishActivity(activityInstanceLinks, activityFinishData, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchFinishActivity(IAsyncResult result)
		{
			return base.Channel.EndBatchFinishActivity(result);
		}

		private IAsyncResult OnBeginBatchFinishActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] activityInstanceLinks = (WeakLink[])inValues[0];
			ActivityFinishData activityFinishData = (ActivityFinishData)inValues[1];
			return this.BeginBatchFinishActivity(activityInstanceLinks, activityFinishData, callback, asyncState);
		}

		private object[] OnEndBatchFinishActivity(IAsyncResult result)
		{
			string text = this.EndBatchFinishActivity(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchFinishActivityCompleted(object state)
		{
			if (this.BatchFinishActivityCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchFinishActivityCompleted(this, new BatchFinishActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchFinishActivityAsync(WeakLink[] activityInstanceLinks, ActivityFinishData activityFinishData)
		{
			this.BatchFinishActivityAsync(activityInstanceLinks, activityFinishData, null);
		}

		public void BatchFinishActivityAsync(WeakLink[] activityInstanceLinks, ActivityFinishData activityFinishData, object userState)
		{
			if (this.onBeginBatchFinishActivityDelegate == null)
			{
				this.onBeginBatchFinishActivityDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchFinishActivity);
			}
			if (this.onEndBatchFinishActivityDelegate == null)
			{
				this.onEndBatchFinishActivityDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchFinishActivity);
			}
			if (this.onBatchFinishActivityCompletedDelegate == null)
			{
				this.onBatchFinishActivityCompletedDelegate = new SendOrPostCallback(this.OnBatchFinishActivityCompleted);
			}
			base.InvokeAsync(this.onBeginBatchFinishActivityDelegate, new object[]
			{
				activityInstanceLinks,
				activityFinishData
			}, this.onEndBatchFinishActivityDelegate, this.onBatchFinishActivityCompletedDelegate, userState);
		}

		public string BatchForceFinishProcess(WeakLink[] processInstanceLinks, string approvalStatusId)
		{
			return base.Channel.BatchForceFinishProcess(processInstanceLinks, approvalStatusId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchForceFinishProcess(WeakLink[] processInstanceLinks, string approvalStatusId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchForceFinishProcess(processInstanceLinks, approvalStatusId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchForceFinishProcess(IAsyncResult result)
		{
			return base.Channel.EndBatchForceFinishProcess(result);
		}

		private IAsyncResult OnBeginBatchForceFinishProcess(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] processInstanceLinks = (WeakLink[])inValues[0];
			string approvalStatusId = (string)inValues[1];
			return this.BeginBatchForceFinishProcess(processInstanceLinks, approvalStatusId, callback, asyncState);
		}

		private object[] OnEndBatchForceFinishProcess(IAsyncResult result)
		{
			string text = this.EndBatchForceFinishProcess(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchForceFinishProcessCompleted(object state)
		{
			if (this.BatchForceFinishProcessCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchForceFinishProcessCompleted(this, new BatchForceFinishProcessCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchForceFinishProcessAsync(WeakLink[] processInstanceLinks, string approvalStatusId)
		{
			this.BatchForceFinishProcessAsync(processInstanceLinks, approvalStatusId, null);
		}

		public void BatchForceFinishProcessAsync(WeakLink[] processInstanceLinks, string approvalStatusId, object userState)
		{
			if (this.onBeginBatchForceFinishProcessDelegate == null)
			{
				this.onBeginBatchForceFinishProcessDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchForceFinishProcess);
			}
			if (this.onEndBatchForceFinishProcessDelegate == null)
			{
				this.onEndBatchForceFinishProcessDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchForceFinishProcess);
			}
			if (this.onBatchForceFinishProcessCompletedDelegate == null)
			{
				this.onBatchForceFinishProcessCompletedDelegate = new SendOrPostCallback(this.OnBatchForceFinishProcessCompleted);
			}
			base.InvokeAsync(this.onBeginBatchForceFinishProcessDelegate, new object[]
			{
				processInstanceLinks,
				approvalStatusId
			}, this.onEndBatchForceFinishProcessDelegate, this.onBatchForceFinishProcessCompletedDelegate, userState);
		}

		public string BatchClassify(WeakLink[] subjectLinks, string[] keywordIds)
		{
			return base.Channel.BatchClassify(subjectLinks, keywordIds);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchClassify(WeakLink[] subjectLinks, string[] keywordIds, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchClassify(subjectLinks, keywordIds, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchClassify(IAsyncResult result)
		{
			return base.Channel.EndBatchClassify(result);
		}

		private IAsyncResult OnBeginBatchClassify(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string[] keywordIds = (string[])inValues[1];
			return this.BeginBatchClassify(subjectLinks, keywordIds, callback, asyncState);
		}

		private object[] OnEndBatchClassify(IAsyncResult result)
		{
			string text = this.EndBatchClassify(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchClassifyCompleted(object state)
		{
			if (this.BatchClassifyCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchClassifyCompleted(this, new BatchClassifyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchClassifyAsync(WeakLink[] subjectLinks, string[] keywordIds)
		{
			this.BatchClassifyAsync(subjectLinks, keywordIds, null);
		}

		public void BatchClassifyAsync(WeakLink[] subjectLinks, string[] keywordIds, object userState)
		{
			if (this.onBeginBatchClassifyDelegate == null)
			{
				this.onBeginBatchClassifyDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchClassify);
			}
			if (this.onEndBatchClassifyDelegate == null)
			{
				this.onEndBatchClassifyDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchClassify);
			}
			if (this.onBatchClassifyCompletedDelegate == null)
			{
				this.onBatchClassifyCompletedDelegate = new SendOrPostCallback(this.OnBatchClassifyCompleted);
			}
			base.InvokeAsync(this.onBeginBatchClassifyDelegate, new object[]
			{
				subjectLinks,
				keywordIds
			}, this.onEndBatchClassifyDelegate, this.onBatchClassifyCompletedDelegate, userState);
		}

		public string BatchUnClassify(WeakLink[] subjectLinks, string[] keywordIds)
		{
			return base.Channel.BatchUnClassify(subjectLinks, keywordIds);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchUnClassify(WeakLink[] subjectLinks, string[] keywordIds, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchUnClassify(subjectLinks, keywordIds, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchUnClassify(IAsyncResult result)
		{
			return base.Channel.EndBatchUnClassify(result);
		}

		private IAsyncResult OnBeginBatchUnClassify(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string[] keywordIds = (string[])inValues[1];
			return this.BeginBatchUnClassify(subjectLinks, keywordIds, callback, asyncState);
		}

		private object[] OnEndBatchUnClassify(IAsyncResult result)
		{
			string text = this.EndBatchUnClassify(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchUnClassifyCompleted(object state)
		{
			if (this.BatchUnClassifyCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchUnClassifyCompleted(this, new BatchUnClassifyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchUnClassifyAsync(WeakLink[] subjectLinks, string[] keywordIds)
		{
			this.BatchUnClassifyAsync(subjectLinks, keywordIds, null);
		}

		public void BatchUnClassifyAsync(WeakLink[] subjectLinks, string[] keywordIds, object userState)
		{
			if (this.onBeginBatchUnClassifyDelegate == null)
			{
				this.onBeginBatchUnClassifyDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchUnClassify);
			}
			if (this.onEndBatchUnClassifyDelegate == null)
			{
				this.onEndBatchUnClassifyDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchUnClassify);
			}
			if (this.onBatchUnClassifyCompletedDelegate == null)
			{
				this.onBatchUnClassifyCompletedDelegate = new SendOrPostCallback(this.OnBatchUnClassifyCompleted);
			}
			base.InvokeAsync(this.onBeginBatchUnClassifyDelegate, new object[]
			{
				subjectLinks,
				keywordIds
			}, this.onEndBatchUnClassifyDelegate, this.onBatchUnClassifyCompletedDelegate, userState);
		}

		public string BatchReClassify(WeakLink[] subjectLinks, string[] keywordIdsToRemove, string[] keywordIdsToAdd)
		{
			return base.Channel.BatchReClassify(subjectLinks, keywordIdsToRemove, keywordIdsToAdd);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchReClassify(WeakLink[] subjectLinks, string[] keywordIdsToRemove, string[] keywordIdsToAdd, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchReClassify(subjectLinks, keywordIdsToRemove, keywordIdsToAdd, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchReClassify(IAsyncResult result)
		{
			return base.Channel.EndBatchReClassify(result);
		}

		private IAsyncResult OnBeginBatchReClassify(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string[] keywordIdsToRemove = (string[])inValues[1];
			string[] keywordIdsToAdd = (string[])inValues[2];
			return this.BeginBatchReClassify(subjectLinks, keywordIdsToRemove, keywordIdsToAdd, callback, asyncState);
		}

		private object[] OnEndBatchReClassify(IAsyncResult result)
		{
			string text = this.EndBatchReClassify(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchReClassifyCompleted(object state)
		{
			if (this.BatchReClassifyCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchReClassifyCompleted(this, new BatchReClassifyCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchReClassifyAsync(WeakLink[] subjectLinks, string[] keywordIdsToRemove, string[] keywordIdsToAdd)
		{
			this.BatchReClassifyAsync(subjectLinks, keywordIdsToRemove, keywordIdsToAdd, null);
		}

		public void BatchReClassifyAsync(WeakLink[] subjectLinks, string[] keywordIdsToRemove, string[] keywordIdsToAdd, object userState)
		{
			if (this.onBeginBatchReClassifyDelegate == null)
			{
				this.onBeginBatchReClassifyDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchReClassify);
			}
			if (this.onEndBatchReClassifyDelegate == null)
			{
				this.onEndBatchReClassifyDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchReClassify);
			}
			if (this.onBatchReClassifyCompletedDelegate == null)
			{
				this.onBatchReClassifyCompletedDelegate = new SendOrPostCallback(this.OnBatchReClassifyCompleted);
			}
			base.InvokeAsync(this.onBeginBatchReClassifyDelegate, new object[]
			{
				subjectLinks,
				keywordIdsToRemove,
				keywordIdsToAdd
			}, this.onEndBatchReClassifyDelegate, this.onBatchReClassifyCompletedDelegate, userState);
		}

		public string BatchDeleteTaxonomyNode(WeakLink[] subjectLinks, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
		{
			return base.Channel.BatchDeleteTaxonomyNode(subjectLinks, deleteTaxonomyNodeMode);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchDeleteTaxonomyNode(WeakLink[] subjectLinks, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchDeleteTaxonomyNode(subjectLinks, deleteTaxonomyNodeMode, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchDeleteTaxonomyNode(IAsyncResult result)
		{
			return base.Channel.EndBatchDeleteTaxonomyNode(result);
		}

		private IAsyncResult OnBeginBatchDeleteTaxonomyNode(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			DeleteTaxonomyNodeMode deleteTaxonomyNodeMode = (DeleteTaxonomyNodeMode)inValues[1];
			return this.BeginBatchDeleteTaxonomyNode(subjectLinks, deleteTaxonomyNodeMode, callback, asyncState);
		}

		private object[] OnEndBatchDeleteTaxonomyNode(IAsyncResult result)
		{
			string text = this.EndBatchDeleteTaxonomyNode(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchDeleteTaxonomyNodeCompleted(object state)
		{
			if (this.BatchDeleteTaxonomyNodeCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchDeleteTaxonomyNodeCompleted(this, new BatchDeleteTaxonomyNodeCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchDeleteTaxonomyNodeAsync(WeakLink[] subjectLinks, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode)
		{
			this.BatchDeleteTaxonomyNodeAsync(subjectLinks, deleteTaxonomyNodeMode, null);
		}

		public void BatchDeleteTaxonomyNodeAsync(WeakLink[] subjectLinks, DeleteTaxonomyNodeMode deleteTaxonomyNodeMode, object userState)
		{
			if (this.onBeginBatchDeleteTaxonomyNodeDelegate == null)
			{
				this.onBeginBatchDeleteTaxonomyNodeDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchDeleteTaxonomyNode);
			}
			if (this.onEndBatchDeleteTaxonomyNodeDelegate == null)
			{
				this.onEndBatchDeleteTaxonomyNodeDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchDeleteTaxonomyNode);
			}
			if (this.onBatchDeleteTaxonomyNodeCompletedDelegate == null)
			{
				this.onBatchDeleteTaxonomyNodeCompletedDelegate = new SendOrPostCallback(this.OnBatchDeleteTaxonomyNodeCompleted);
			}
			base.InvokeAsync(this.onBeginBatchDeleteTaxonomyNodeDelegate, new object[]
			{
				subjectLinks,
				deleteTaxonomyNodeMode
			}, this.onEndBatchDeleteTaxonomyNodeDelegate, this.onBatchDeleteTaxonomyNodeCompletedDelegate, userState);
		}

		public string BatchSwitchUserEnabledState(WeakLink[] subjectLinks, bool isEnabled)
		{
			return base.Channel.BatchSwitchUserEnabledState(subjectLinks, isEnabled);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchSwitchUserEnabledState(WeakLink[] subjectLinks, bool isEnabled, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchSwitchUserEnabledState(subjectLinks, isEnabled, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchSwitchUserEnabledState(IAsyncResult result)
		{
			return base.Channel.EndBatchSwitchUserEnabledState(result);
		}

		private IAsyncResult OnBeginBatchSwitchUserEnabledState(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			bool isEnabled = (bool)inValues[1];
			return this.BeginBatchSwitchUserEnabledState(subjectLinks, isEnabled, callback, asyncState);
		}

		private object[] OnEndBatchSwitchUserEnabledState(IAsyncResult result)
		{
			string text = this.EndBatchSwitchUserEnabledState(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchSwitchUserEnabledStateCompleted(object state)
		{
			if (this.BatchSwitchUserEnabledStateCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchSwitchUserEnabledStateCompleted(this, new BatchSwitchUserEnabledStateCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchSwitchUserEnabledStateAsync(WeakLink[] subjectLinks, bool isEnabled)
		{
			this.BatchSwitchUserEnabledStateAsync(subjectLinks, isEnabled, null);
		}

		public void BatchSwitchUserEnabledStateAsync(WeakLink[] subjectLinks, bool isEnabled, object userState)
		{
			if (this.onBeginBatchSwitchUserEnabledStateDelegate == null)
			{
				this.onBeginBatchSwitchUserEnabledStateDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchSwitchUserEnabledState);
			}
			if (this.onEndBatchSwitchUserEnabledStateDelegate == null)
			{
				this.onEndBatchSwitchUserEnabledStateDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchSwitchUserEnabledState);
			}
			if (this.onBatchSwitchUserEnabledStateCompletedDelegate == null)
			{
				this.onBatchSwitchUserEnabledStateCompletedDelegate = new SendOrPostCallback(this.OnBatchSwitchUserEnabledStateCompleted);
			}
			base.InvokeAsync(this.onBeginBatchSwitchUserEnabledStateDelegate, new object[]
			{
				subjectLinks,
				isEnabled
			}, this.onEndBatchSwitchUserEnabledStateDelegate, this.onBatchSwitchUserEnabledStateCompletedDelegate, userState);
		}

		public string BatchCopyToKeyword(WeakLink[] subjectLinks, string destinationId)
		{
			return base.Channel.BatchCopyToKeyword(subjectLinks, destinationId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchCopyToKeyword(WeakLink[] subjectLinks, string destinationId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchCopyToKeyword(subjectLinks, destinationId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchCopyToKeyword(IAsyncResult result)
		{
			return base.Channel.EndBatchCopyToKeyword(result);
		}

		private IAsyncResult OnBeginBatchCopyToKeyword(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string destinationId = (string)inValues[1];
			return this.BeginBatchCopyToKeyword(subjectLinks, destinationId, callback, asyncState);
		}

		private object[] OnEndBatchCopyToKeyword(IAsyncResult result)
		{
			string text = this.EndBatchCopyToKeyword(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchCopyToKeywordCompleted(object state)
		{
			if (this.BatchCopyToKeywordCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchCopyToKeywordCompleted(this, new BatchCopyToKeywordCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchCopyToKeywordAsync(WeakLink[] subjectLinks, string destinationId)
		{
			this.BatchCopyToKeywordAsync(subjectLinks, destinationId, null);
		}

		public void BatchCopyToKeywordAsync(WeakLink[] subjectLinks, string destinationId, object userState)
		{
			if (this.onBeginBatchCopyToKeywordDelegate == null)
			{
				this.onBeginBatchCopyToKeywordDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchCopyToKeyword);
			}
			if (this.onEndBatchCopyToKeywordDelegate == null)
			{
				this.onEndBatchCopyToKeywordDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchCopyToKeyword);
			}
			if (this.onBatchCopyToKeywordCompletedDelegate == null)
			{
				this.onBatchCopyToKeywordCompletedDelegate = new SendOrPostCallback(this.OnBatchCopyToKeywordCompleted);
			}
			base.InvokeAsync(this.onBeginBatchCopyToKeywordDelegate, new object[]
			{
				subjectLinks,
				destinationId
			}, this.onEndBatchCopyToKeywordDelegate, this.onBatchCopyToKeywordCompletedDelegate, userState);
		}

		public string BatchMoveToKeyword(WeakLink[] subjectLinks, string destinationId)
		{
			return base.Channel.BatchMoveToKeyword(subjectLinks, destinationId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchMoveToKeyword(WeakLink[] subjectLinks, string destinationId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchMoveToKeyword(subjectLinks, destinationId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchMoveToKeyword(IAsyncResult result)
		{
			return base.Channel.EndBatchMoveToKeyword(result);
		}

		private IAsyncResult OnBeginBatchMoveToKeyword(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			string destinationId = (string)inValues[1];
			return this.BeginBatchMoveToKeyword(subjectLinks, destinationId, callback, asyncState);
		}

		private object[] OnEndBatchMoveToKeyword(IAsyncResult result)
		{
			string text = this.EndBatchMoveToKeyword(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchMoveToKeywordCompleted(object state)
		{
			if (this.BatchMoveToKeywordCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchMoveToKeywordCompleted(this, new BatchMoveToKeywordCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchMoveToKeywordAsync(WeakLink[] subjectLinks, string destinationId)
		{
			this.BatchMoveToKeywordAsync(subjectLinks, destinationId, null);
		}

		public void BatchMoveToKeywordAsync(WeakLink[] subjectLinks, string destinationId, object userState)
		{
			if (this.onBeginBatchMoveToKeywordDelegate == null)
			{
				this.onBeginBatchMoveToKeywordDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchMoveToKeyword);
			}
			if (this.onEndBatchMoveToKeywordDelegate == null)
			{
				this.onEndBatchMoveToKeywordDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchMoveToKeyword);
			}
			if (this.onBatchMoveToKeywordCompletedDelegate == null)
			{
				this.onBatchMoveToKeywordCompletedDelegate = new SendOrPostCallback(this.OnBatchMoveToKeywordCompleted);
			}
			base.InvokeAsync(this.onBeginBatchMoveToKeywordDelegate, new object[]
			{
				subjectLinks,
				destinationId
			}, this.onEndBatchMoveToKeywordDelegate, this.onBatchMoveToKeywordCompletedDelegate, userState);
		}

		public string BatchReAssignActivity(WeakLink[] activityInstanceLinks, string newAssigneeId)
		{
			return base.Channel.BatchReAssignActivity(activityInstanceLinks, newAssigneeId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchReAssignActivity(WeakLink[] activityInstanceLinks, string newAssigneeId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchReAssignActivity(activityInstanceLinks, newAssigneeId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchReAssignActivity(IAsyncResult result)
		{
			return base.Channel.EndBatchReAssignActivity(result);
		}

		private IAsyncResult OnBeginBatchReAssignActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] activityInstanceLinks = (WeakLink[])inValues[0];
			string newAssigneeId = (string)inValues[1];
			return this.BeginBatchReAssignActivity(activityInstanceLinks, newAssigneeId, callback, asyncState);
		}

		private object[] OnEndBatchReAssignActivity(IAsyncResult result)
		{
			string text = this.EndBatchReAssignActivity(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchReAssignActivityCompleted(object state)
		{
			if (this.BatchReAssignActivityCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchReAssignActivityCompleted(this, new BatchReAssignActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchReAssignActivityAsync(WeakLink[] activityInstanceLinks, string newAssigneeId)
		{
			this.BatchReAssignActivityAsync(activityInstanceLinks, newAssigneeId, null);
		}

		public void BatchReAssignActivityAsync(WeakLink[] activityInstanceLinks, string newAssigneeId, object userState)
		{
			if (this.onBeginBatchReAssignActivityDelegate == null)
			{
				this.onBeginBatchReAssignActivityDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchReAssignActivity);
			}
			if (this.onEndBatchReAssignActivityDelegate == null)
			{
				this.onEndBatchReAssignActivityDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchReAssignActivity);
			}
			if (this.onBatchReAssignActivityCompletedDelegate == null)
			{
				this.onBatchReAssignActivityCompletedDelegate = new SendOrPostCallback(this.OnBatchReAssignActivityCompleted);
			}
			base.InvokeAsync(this.onBeginBatchReAssignActivityDelegate, new object[]
			{
				activityInstanceLinks,
				newAssigneeId
			}, this.onEndBatchReAssignActivityDelegate, this.onBatchReAssignActivityCompletedDelegate, userState);
		}

		public string BatchRestartActivity(WeakLink[] activityInstanceLinks)
		{
			return base.Channel.BatchRestartActivity(activityInstanceLinks);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchRestartActivity(WeakLink[] activityInstanceLinks, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchRestartActivity(activityInstanceLinks, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchRestartActivity(IAsyncResult result)
		{
			return base.Channel.EndBatchRestartActivity(result);
		}

		private IAsyncResult OnBeginBatchRestartActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] activityInstanceLinks = (WeakLink[])inValues[0];
			return this.BeginBatchRestartActivity(activityInstanceLinks, callback, asyncState);
		}

		private object[] OnEndBatchRestartActivity(IAsyncResult result)
		{
			string text = this.EndBatchRestartActivity(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchRestartActivityCompleted(object state)
		{
			if (this.BatchRestartActivityCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchRestartActivityCompleted(this, new BatchRestartActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchRestartActivityAsync(WeakLink[] activityInstanceLinks)
		{
			this.BatchRestartActivityAsync(activityInstanceLinks, null);
		}

		public void BatchRestartActivityAsync(WeakLink[] activityInstanceLinks, object userState)
		{
			if (this.onBeginBatchRestartActivityDelegate == null)
			{
				this.onBeginBatchRestartActivityDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchRestartActivity);
			}
			if (this.onEndBatchRestartActivityDelegate == null)
			{
				this.onEndBatchRestartActivityDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchRestartActivity);
			}
			if (this.onBatchRestartActivityCompletedDelegate == null)
			{
				this.onBatchRestartActivityCompletedDelegate = new SendOrPostCallback(this.OnBatchRestartActivityCompleted);
			}
			base.InvokeAsync(this.onBeginBatchRestartActivityDelegate, new object[]
			{
				activityInstanceLinks
			}, this.onEndBatchRestartActivityDelegate, this.onBatchRestartActivityCompletedDelegate, userState);
		}

		public string BatchSuspendActivity(WeakLink[] activityInstanceLinks, string reason)
		{
			return base.Channel.BatchSuspendActivity(activityInstanceLinks, reason);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchSuspendActivity(WeakLink[] activityInstanceLinks, string reason, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchSuspendActivity(activityInstanceLinks, reason, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchSuspendActivity(IAsyncResult result)
		{
			return base.Channel.EndBatchSuspendActivity(result);
		}

		private IAsyncResult OnBeginBatchSuspendActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] activityInstanceLinks = (WeakLink[])inValues[0];
			string reason = (string)inValues[1];
			return this.BeginBatchSuspendActivity(activityInstanceLinks, reason, callback, asyncState);
		}

		private object[] OnEndBatchSuspendActivity(IAsyncResult result)
		{
			string text = this.EndBatchSuspendActivity(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchSuspendActivityCompleted(object state)
		{
			if (this.BatchSuspendActivityCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchSuspendActivityCompleted(this, new BatchSuspendActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchSuspendActivityAsync(WeakLink[] activityInstanceLinks, string reason)
		{
			this.BatchSuspendActivityAsync(activityInstanceLinks, reason, null);
		}

		public void BatchSuspendActivityAsync(WeakLink[] activityInstanceLinks, string reason, object userState)
		{
			if (this.onBeginBatchSuspendActivityDelegate == null)
			{
				this.onBeginBatchSuspendActivityDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchSuspendActivity);
			}
			if (this.onEndBatchSuspendActivityDelegate == null)
			{
				this.onEndBatchSuspendActivityDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchSuspendActivity);
			}
			if (this.onBatchSuspendActivityCompletedDelegate == null)
			{
				this.onBatchSuspendActivityCompletedDelegate = new SendOrPostCallback(this.OnBatchSuspendActivityCompleted);
			}
			base.InvokeAsync(this.onBeginBatchSuspendActivityDelegate, new object[]
			{
				activityInstanceLinks,
				reason
			}, this.onEndBatchSuspendActivityDelegate, this.onBatchSuspendActivityCompletedDelegate, userState);
		}

		public string BatchResumeActivity(WeakLink[] activityInstanceLinks)
		{
			return base.Channel.BatchResumeActivity(activityInstanceLinks);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchResumeActivity(WeakLink[] activityInstanceLinks, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchResumeActivity(activityInstanceLinks, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchResumeActivity(IAsyncResult result)
		{
			return base.Channel.EndBatchResumeActivity(result);
		}

		private IAsyncResult OnBeginBatchResumeActivity(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] activityInstanceLinks = (WeakLink[])inValues[0];
			return this.BeginBatchResumeActivity(activityInstanceLinks, callback, asyncState);
		}

		private object[] OnEndBatchResumeActivity(IAsyncResult result)
		{
			string text = this.EndBatchResumeActivity(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchResumeActivityCompleted(object state)
		{
			if (this.BatchResumeActivityCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchResumeActivityCompleted(this, new BatchResumeActivityCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchResumeActivityAsync(WeakLink[] activityInstanceLinks)
		{
			this.BatchResumeActivityAsync(activityInstanceLinks, null);
		}

		public void BatchResumeActivityAsync(WeakLink[] activityInstanceLinks, object userState)
		{
			if (this.onBeginBatchResumeActivityDelegate == null)
			{
				this.onBeginBatchResumeActivityDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchResumeActivity);
			}
			if (this.onEndBatchResumeActivityDelegate == null)
			{
				this.onEndBatchResumeActivityDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchResumeActivity);
			}
			if (this.onBatchResumeActivityCompletedDelegate == null)
			{
				this.onBatchResumeActivityCompletedDelegate = new SendOrPostCallback(this.OnBatchResumeActivityCompleted);
			}
			base.InvokeAsync(this.onBeginBatchResumeActivityDelegate, new object[]
			{
				activityInstanceLinks
			}, this.onEndBatchResumeActivityDelegate, this.onBatchResumeActivityCompletedDelegate, userState);
		}

		public string BatchSynchronizeWithSchemaAndUpdate(WeakLink[] subjectLinks, SynchronizeOptions synchOptions)
		{
			return base.Channel.BatchSynchronizeWithSchemaAndUpdate(subjectLinks, synchOptions);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginBatchSynchronizeWithSchemaAndUpdate(WeakLink[] subjectLinks, SynchronizeOptions synchOptions, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginBatchSynchronizeWithSchemaAndUpdate(subjectLinks, synchOptions, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndBatchSynchronizeWithSchemaAndUpdate(IAsyncResult result)
		{
			return base.Channel.EndBatchSynchronizeWithSchemaAndUpdate(result);
		}

		private IAsyncResult OnBeginBatchSynchronizeWithSchemaAndUpdate(object[] inValues, AsyncCallback callback, object asyncState)
		{
			WeakLink[] subjectLinks = (WeakLink[])inValues[0];
			SynchronizeOptions synchOptions = (SynchronizeOptions)inValues[1];
			return this.BeginBatchSynchronizeWithSchemaAndUpdate(subjectLinks, synchOptions, callback, asyncState);
		}

		private object[] OnEndBatchSynchronizeWithSchemaAndUpdate(IAsyncResult result)
		{
			string text = this.EndBatchSynchronizeWithSchemaAndUpdate(result);
			return new object[]
			{
				text
			};
		}

		private void OnBatchSynchronizeWithSchemaAndUpdateCompleted(object state)
		{
			if (this.BatchSynchronizeWithSchemaAndUpdateCompleted != null)
			{
				ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<ICoreServiceBatch>.InvokeAsyncCompletedEventArgs)state;
				this.BatchSynchronizeWithSchemaAndUpdateCompleted(this, new BatchSynchronizeWithSchemaAndUpdateCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void BatchSynchronizeWithSchemaAndUpdateAsync(WeakLink[] subjectLinks, SynchronizeOptions synchOptions)
		{
			this.BatchSynchronizeWithSchemaAndUpdateAsync(subjectLinks, synchOptions, null);
		}

		public void BatchSynchronizeWithSchemaAndUpdateAsync(WeakLink[] subjectLinks, SynchronizeOptions synchOptions, object userState)
		{
			if (this.onBeginBatchSynchronizeWithSchemaAndUpdateDelegate == null)
			{
				this.onBeginBatchSynchronizeWithSchemaAndUpdateDelegate = new ClientBase<ICoreServiceBatch>.BeginOperationDelegate(this.OnBeginBatchSynchronizeWithSchemaAndUpdate);
			}
			if (this.onEndBatchSynchronizeWithSchemaAndUpdateDelegate == null)
			{
				this.onEndBatchSynchronizeWithSchemaAndUpdateDelegate = new ClientBase<ICoreServiceBatch>.EndOperationDelegate(this.OnEndBatchSynchronizeWithSchemaAndUpdate);
			}
			if (this.onBatchSynchronizeWithSchemaAndUpdateCompletedDelegate == null)
			{
				this.onBatchSynchronizeWithSchemaAndUpdateCompletedDelegate = new SendOrPostCallback(this.OnBatchSynchronizeWithSchemaAndUpdateCompleted);
			}
			base.InvokeAsync(this.onBeginBatchSynchronizeWithSchemaAndUpdateDelegate, new object[]
			{
				subjectLinks,
				synchOptions
			}, this.onEndBatchSynchronizeWithSchemaAndUpdateDelegate, this.onBatchSynchronizeWithSchemaAndUpdateCompletedDelegate, userState);
		}

		public void Dispose()
		{
			ClientHelper.DisposeClient(this);
		}
	}
}
