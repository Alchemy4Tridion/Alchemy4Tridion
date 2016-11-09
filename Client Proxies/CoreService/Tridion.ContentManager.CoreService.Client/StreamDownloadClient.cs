using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class StreamDownloadClient : ClientBase<IStreamDownload>, IStreamDownload, IDisposable
	{
		private ClientBase<IStreamDownload>.BeginOperationDelegate onBeginDownloadBinaryContentDelegate;

		private ClientBase<IStreamDownload>.EndOperationDelegate onEndDownloadBinaryContentDelegate;

		private SendOrPostCallback onDownloadBinaryContentCompletedDelegate;

		private ClientBase<IStreamDownload>.BeginOperationDelegate onBeginDownloadBinaryContentByUserDelegate;

		private ClientBase<IStreamDownload>.EndOperationDelegate onEndDownloadBinaryContentByUserDelegate;

		private SendOrPostCallback onDownloadBinaryContentByUserCompletedDelegate;

		private ClientBase<IStreamDownload>.BeginOperationDelegate onBeginDownloadRenderedBinaryDelegate;

		private ClientBase<IStreamDownload>.EndOperationDelegate onEndDownloadRenderedBinaryDelegate;

		private SendOrPostCallback onDownloadRenderedBinaryCompletedDelegate;

		private ClientBase<IStreamDownload>.BeginOperationDelegate onBeginDownloadExternalBinaryContentDelegate;

		private ClientBase<IStreamDownload>.EndOperationDelegate onEndDownloadExternalBinaryContentDelegate;

		private SendOrPostCallback onDownloadExternalBinaryContentCompletedDelegate;

		public event EventHandler<DownloadBinaryContentCompletedEventArgs> DownloadBinaryContentCompleted;

		public event EventHandler<DownloadBinaryContentByUserCompletedEventArgs> DownloadBinaryContentByUserCompleted;

		public event EventHandler<DownloadRenderedBinaryCompletedEventArgs> DownloadRenderedBinaryCompleted;

		public event EventHandler<DownloadExternalBinaryContentCompletedEventArgs> DownloadExternalBinaryContentCompleted;

		public StreamDownloadClient()
		{
		}

		public StreamDownloadClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public StreamDownloadClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public StreamDownloadClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public StreamDownloadClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		public Stream DownloadBinaryContent(string itemIdOrTempFileId)
		{
			return base.Channel.DownloadBinaryContent(itemIdOrTempFileId);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDownloadBinaryContent(string itemIdOrTempFileId, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDownloadBinaryContent(itemIdOrTempFileId, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public Stream EndDownloadBinaryContent(IAsyncResult result)
		{
			return base.Channel.EndDownloadBinaryContent(result);
		}

		private IAsyncResult OnBeginDownloadBinaryContent(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string itemIdOrTempFileId = (string)inValues[0];
			return this.BeginDownloadBinaryContent(itemIdOrTempFileId, callback, asyncState);
		}

		private object[] OnEndDownloadBinaryContent(IAsyncResult result)
		{
			Stream stream = this.EndDownloadBinaryContent(result);
			return new object[]
			{
				stream
			};
		}

		private void OnDownloadBinaryContentCompleted(object state)
		{
			if (this.DownloadBinaryContentCompleted != null)
			{
				ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs)state;
				this.DownloadBinaryContentCompleted(this, new DownloadBinaryContentCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DownloadBinaryContentAsync(string itemIdOrTempFileId)
		{
			this.DownloadBinaryContentAsync(itemIdOrTempFileId, null);
		}

		public void DownloadBinaryContentAsync(string itemIdOrTempFileId, object userState)
		{
			if (this.onBeginDownloadBinaryContentDelegate == null)
			{
				this.onBeginDownloadBinaryContentDelegate = new ClientBase<IStreamDownload>.BeginOperationDelegate(this.OnBeginDownloadBinaryContent);
			}
			if (this.onEndDownloadBinaryContentDelegate == null)
			{
				this.onEndDownloadBinaryContentDelegate = new ClientBase<IStreamDownload>.EndOperationDelegate(this.OnEndDownloadBinaryContent);
			}
			if (this.onDownloadBinaryContentCompletedDelegate == null)
			{
				this.onDownloadBinaryContentCompletedDelegate = new SendOrPostCallback(this.OnDownloadBinaryContentCompleted);
			}
			base.InvokeAsync(this.onBeginDownloadBinaryContentDelegate, new object[]
			{
				itemIdOrTempFileId
			}, this.onEndDownloadBinaryContentDelegate, this.onDownloadBinaryContentCompletedDelegate, userState);
		}

		public Stream DownloadBinaryContentByUser(string itemIdOrTempFileId, AccessTokenData accessToken)
		{
			return base.Channel.DownloadBinaryContentByUser(itemIdOrTempFileId, accessToken);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDownloadBinaryContentByUser(string itemIdOrTempFileId, AccessTokenData accessToken, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDownloadBinaryContentByUser(itemIdOrTempFileId, accessToken, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public Stream EndDownloadBinaryContentByUser(IAsyncResult result)
		{
			return base.Channel.EndDownloadBinaryContentByUser(result);
		}

		private IAsyncResult OnBeginDownloadBinaryContentByUser(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string itemIdOrTempFileId = (string)inValues[0];
			AccessTokenData accessToken = (AccessTokenData)inValues[1];
			return this.BeginDownloadBinaryContentByUser(itemIdOrTempFileId, accessToken, callback, asyncState);
		}

		private object[] OnEndDownloadBinaryContentByUser(IAsyncResult result)
		{
			Stream stream = this.EndDownloadBinaryContentByUser(result);
			return new object[]
			{
				stream
			};
		}

		private void OnDownloadBinaryContentByUserCompleted(object state)
		{
			if (this.DownloadBinaryContentByUserCompleted != null)
			{
				ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs)state;
				this.DownloadBinaryContentByUserCompleted(this, new DownloadBinaryContentByUserCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DownloadBinaryContentByUserAsync(string itemIdOrTempFileId, AccessTokenData accessToken)
		{
			this.DownloadBinaryContentByUserAsync(itemIdOrTempFileId, accessToken, null);
		}

		public void DownloadBinaryContentByUserAsync(string itemIdOrTempFileId, AccessTokenData accessToken, object userState)
		{
			if (this.onBeginDownloadBinaryContentByUserDelegate == null)
			{
				this.onBeginDownloadBinaryContentByUserDelegate = new ClientBase<IStreamDownload>.BeginOperationDelegate(this.OnBeginDownloadBinaryContentByUser);
			}
			if (this.onEndDownloadBinaryContentByUserDelegate == null)
			{
				this.onEndDownloadBinaryContentByUserDelegate = new ClientBase<IStreamDownload>.EndOperationDelegate(this.OnEndDownloadBinaryContentByUser);
			}
			if (this.onDownloadBinaryContentByUserCompletedDelegate == null)
			{
				this.onDownloadBinaryContentByUserCompletedDelegate = new SendOrPostCallback(this.OnDownloadBinaryContentByUserCompleted);
			}
			base.InvokeAsync(this.onBeginDownloadBinaryContentByUserDelegate, new object[]
			{
				itemIdOrTempFileId,
				accessToken
			}, this.onEndDownloadBinaryContentByUserDelegate, this.onDownloadBinaryContentByUserCompletedDelegate, userState);
		}

		public Stream DownloadRenderedBinary(string path)
		{
			return base.Channel.DownloadRenderedBinary(path);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDownloadRenderedBinary(string path, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDownloadRenderedBinary(path, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public Stream EndDownloadRenderedBinary(IAsyncResult result)
		{
			return base.Channel.EndDownloadRenderedBinary(result);
		}

		private IAsyncResult OnBeginDownloadRenderedBinary(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string path = (string)inValues[0];
			return this.BeginDownloadRenderedBinary(path, callback, asyncState);
		}

		private object[] OnEndDownloadRenderedBinary(IAsyncResult result)
		{
			Stream stream = this.EndDownloadRenderedBinary(result);
			return new object[]
			{
				stream
			};
		}

		private void OnDownloadRenderedBinaryCompleted(object state)
		{
			if (this.DownloadRenderedBinaryCompleted != null)
			{
				ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs)state;
				this.DownloadRenderedBinaryCompleted(this, new DownloadRenderedBinaryCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DownloadRenderedBinaryAsync(string path)
		{
			this.DownloadRenderedBinaryAsync(path, null);
		}

		public void DownloadRenderedBinaryAsync(string path, object userState)
		{
			if (this.onBeginDownloadRenderedBinaryDelegate == null)
			{
				this.onBeginDownloadRenderedBinaryDelegate = new ClientBase<IStreamDownload>.BeginOperationDelegate(this.OnBeginDownloadRenderedBinary);
			}
			if (this.onEndDownloadRenderedBinaryDelegate == null)
			{
				this.onEndDownloadRenderedBinaryDelegate = new ClientBase<IStreamDownload>.EndOperationDelegate(this.OnEndDownloadRenderedBinary);
			}
			if (this.onDownloadRenderedBinaryCompletedDelegate == null)
			{
				this.onDownloadRenderedBinaryCompletedDelegate = new SendOrPostCallback(this.OnDownloadRenderedBinaryCompleted);
			}
			base.InvokeAsync(this.onBeginDownloadRenderedBinaryDelegate, new object[]
			{
				path
			}, this.onEndDownloadRenderedBinaryDelegate, this.onDownloadRenderedBinaryCompletedDelegate, userState);
		}

		public Stream DownloadExternalBinaryContent(string uri)
		{
			return base.Channel.DownloadExternalBinaryContent(uri);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginDownloadExternalBinaryContent(string uri, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginDownloadExternalBinaryContent(uri, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public Stream EndDownloadExternalBinaryContent(IAsyncResult result)
		{
			return base.Channel.EndDownloadExternalBinaryContent(result);
		}

		private IAsyncResult OnBeginDownloadExternalBinaryContent(object[] inValues, AsyncCallback callback, object asyncState)
		{
			string uri = (string)inValues[0];
			return this.BeginDownloadExternalBinaryContent(uri, callback, asyncState);
		}

		private object[] OnEndDownloadExternalBinaryContent(IAsyncResult result)
		{
			Stream stream = this.EndDownloadExternalBinaryContent(result);
			return new object[]
			{
				stream
			};
		}

		private void OnDownloadExternalBinaryContentCompleted(object state)
		{
			if (this.DownloadExternalBinaryContentCompleted != null)
			{
				ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<IStreamDownload>.InvokeAsyncCompletedEventArgs)state;
				this.DownloadExternalBinaryContentCompleted(this, new DownloadExternalBinaryContentCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void DownloadExternalBinaryContentAsync(string uri)
		{
			this.DownloadExternalBinaryContentAsync(uri, null);
		}

		public void DownloadExternalBinaryContentAsync(string uri, object userState)
		{
			if (this.onBeginDownloadExternalBinaryContentDelegate == null)
			{
				this.onBeginDownloadExternalBinaryContentDelegate = new ClientBase<IStreamDownload>.BeginOperationDelegate(this.OnBeginDownloadExternalBinaryContent);
			}
			if (this.onEndDownloadExternalBinaryContentDelegate == null)
			{
				this.onEndDownloadExternalBinaryContentDelegate = new ClientBase<IStreamDownload>.EndOperationDelegate(this.OnEndDownloadExternalBinaryContent);
			}
			if (this.onDownloadExternalBinaryContentCompletedDelegate == null)
			{
				this.onDownloadExternalBinaryContentCompletedDelegate = new SendOrPostCallback(this.OnDownloadExternalBinaryContentCompleted);
			}
			base.InvokeAsync(this.onBeginDownloadExternalBinaryContentDelegate, new object[]
			{
				uri
			}, this.onEndDownloadExternalBinaryContentDelegate, this.onDownloadExternalBinaryContentCompletedDelegate, userState);
		}

		public void Dispose()
		{
			ClientHelper.DisposeClient(this);
		}
	}
}
