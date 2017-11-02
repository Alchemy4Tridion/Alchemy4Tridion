using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "UploadRequest", WrapperNamespace = "http://www.sdltridion.com/ContentManager/CoreService/201501", IsWrapped = true)]
	public class UploadRequest201501 : IUploadRequest
	{
		[MessageHeader(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201501")]
		public AccessTokenData AccessToken;

		[MessageBodyMember(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201501", Order = 0)]
		public Stream UploadContent;

		public UploadRequest201501()
		{
		}

		public UploadRequest201501(AccessTokenData AccessToken, Stream UploadContent)
		{
			this.AccessToken = AccessToken;
			this.UploadContent = UploadContent;
		}
	}
}
