using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;


namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class StreamUploadClient : ClientBase<IStreamUpload>, IStreamUpload, IDisposable
	{
		private ClientBase<IStreamUpload>.BeginOperationDelegate onBeginUploadBinaryContentDelegate;

		private ClientBase<IStreamUpload>.EndOperationDelegate onEndUploadBinaryContentDelegate;

		private SendOrPostCallback onUploadBinaryContentCompletedDelegate;

		private ClientBase<IStreamUpload>.BeginOperationDelegate onBeginUploadBinaryByteArrayDelegate;

		private ClientBase<IStreamUpload>.EndOperationDelegate onEndUploadBinaryByteArrayDelegate;

		private SendOrPostCallback onUploadBinaryByteArrayCompletedDelegate;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UploadBinaryContentCompletedEventArgs> UploadBinaryContentCompleted;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler<UploadBinaryByteArrayCompletedEventArgs> UploadBinaryByteArrayCompleted;

		public StreamUploadClient()
		{
		}

		public StreamUploadClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public StreamUploadClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public StreamUploadClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public StreamUploadClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		UploadResponse IStreamUpload.UploadBinaryContent(UploadRequest request)
		{
			return base.Channel.UploadBinaryContent(request);
		}

		public string UploadBinaryContent(AccessTokenData AccessToken, Stream UploadContent)
		{
			return ((IStreamUpload)this).UploadBinaryContent(new UploadRequest
			{
				AccessToken = AccessToken,
				UploadContent = UploadContent
			}).FilePath;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		IAsyncResult IStreamUpload.BeginUploadBinaryContent(UploadRequest request, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUploadBinaryContent(request, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUploadBinaryContent(AccessTokenData AccessToken, Stream UploadContent, AsyncCallback callback, object asyncState)
		{
			return ((IStreamUpload)this).BeginUploadBinaryContent(new UploadRequest
			{
				AccessToken = AccessToken,
				UploadContent = UploadContent
			}, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		UploadResponse IStreamUpload.EndUploadBinaryContent(IAsyncResult result)
		{
			return base.Channel.EndUploadBinaryContent(result);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndUploadBinaryContent(IAsyncResult result)
		{
			return ((IStreamUpload)this).EndUploadBinaryContent(result).FilePath;
		}

		private IAsyncResult OnBeginUploadBinaryContent(object[] inValues, AsyncCallback callback, object asyncState)
		{
			AccessTokenData accessToken = (AccessTokenData)inValues[0];
			Stream uploadContent = (Stream)inValues[1];
			return this.BeginUploadBinaryContent(accessToken, uploadContent, callback, asyncState);
		}

		private object[] OnEndUploadBinaryContent(IAsyncResult result)
		{
			string text = this.EndUploadBinaryContent(result);
			return new object[]
			{
				text
			};
		}

		private void OnUploadBinaryContentCompleted(object state)
		{
			if (this.UploadBinaryContentCompleted != null)
			{
				ClientBase<IStreamUpload>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<IStreamUpload>.InvokeAsyncCompletedEventArgs)state;
				this.UploadBinaryContentCompleted(this, new UploadBinaryContentCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UploadBinaryContentAsync(AccessTokenData AccessToken, Stream UploadContent)
		{
			this.UploadBinaryContentAsync(AccessToken, UploadContent, null);
		}

		public void UploadBinaryContentAsync(AccessTokenData AccessToken, Stream UploadContent, object userState)
		{
			if (this.onBeginUploadBinaryContentDelegate == null)
			{
				this.onBeginUploadBinaryContentDelegate = new ClientBase<IStreamUpload>.BeginOperationDelegate(this.OnBeginUploadBinaryContent);
			}
			if (this.onEndUploadBinaryContentDelegate == null)
			{
				this.onEndUploadBinaryContentDelegate = new ClientBase<IStreamUpload>.EndOperationDelegate(this.OnEndUploadBinaryContent);
			}
			if (this.onUploadBinaryContentCompletedDelegate == null)
			{
				this.onUploadBinaryContentCompletedDelegate = new SendOrPostCallback(this.OnUploadBinaryContentCompleted);
			}
			base.InvokeAsync(this.onBeginUploadBinaryContentDelegate, new object[]
			{
				AccessToken,
				UploadContent
			}, this.onEndUploadBinaryContentDelegate, this.onUploadBinaryContentCompletedDelegate, userState);
		}

		public string UploadBinaryByteArray(AccessTokenData accessToken, byte[] data)
		{
			return base.Channel.UploadBinaryByteArray(accessToken, data);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public IAsyncResult BeginUploadBinaryByteArray(AccessTokenData accessToken, byte[] data, AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginUploadBinaryByteArray(accessToken, data, callback, asyncState);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string EndUploadBinaryByteArray(IAsyncResult result)
		{
			return base.Channel.EndUploadBinaryByteArray(result);
		}

		private IAsyncResult OnBeginUploadBinaryByteArray(object[] inValues, AsyncCallback callback, object asyncState)
		{
			AccessTokenData accessToken = (AccessTokenData)inValues[0];
			byte[] data = (byte[])inValues[1];
			return this.BeginUploadBinaryByteArray(accessToken, data, callback, asyncState);
		}

		private object[] OnEndUploadBinaryByteArray(IAsyncResult result)
		{
			string text = this.EndUploadBinaryByteArray(result);
			return new object[]
			{
				text
			};
		}

		private void OnUploadBinaryByteArrayCompleted(object state)
		{
			if (this.UploadBinaryByteArrayCompleted != null)
			{
				ClientBase<IStreamUpload>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (ClientBase<IStreamUpload>.InvokeAsyncCompletedEventArgs)state;
				this.UploadBinaryByteArrayCompleted(this, new UploadBinaryByteArrayCompletedEventArgs(invokeAsyncCompletedEventArgs.Results, invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		public void UploadBinaryByteArrayAsync(AccessTokenData accessToken, byte[] data)
		{
			this.UploadBinaryByteArrayAsync(accessToken, data, null);
		}

		public void UploadBinaryByteArrayAsync(AccessTokenData accessToken, byte[] data, object userState)
		{
			if (this.onBeginUploadBinaryByteArrayDelegate == null)
			{
				this.onBeginUploadBinaryByteArrayDelegate = new ClientBase<IStreamUpload>.BeginOperationDelegate(this.OnBeginUploadBinaryByteArray);
			}
			if (this.onEndUploadBinaryByteArrayDelegate == null)
			{
				this.onEndUploadBinaryByteArrayDelegate = new ClientBase<IStreamUpload>.EndOperationDelegate(this.OnEndUploadBinaryByteArray);
			}
			if (this.onUploadBinaryByteArrayCompletedDelegate == null)
			{
				this.onUploadBinaryByteArrayCompletedDelegate = new SendOrPostCallback(this.OnUploadBinaryByteArrayCompleted);
			}
			base.InvokeAsync(this.onBeginUploadBinaryByteArrayDelegate, new object[]
			{
				accessToken,
				data
			}, this.onEndUploadBinaryByteArrayDelegate, this.onUploadBinaryByteArrayCompletedDelegate, userState);
		}

		public void Dispose()
		{
			ClientHelper.DisposeClient(this);
		}
	}
}
