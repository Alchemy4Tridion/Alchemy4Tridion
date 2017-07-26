using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "UploadResponse", WrapperNamespace = "http://www.sdltridion.com/ContentManager/CoreService/201603", IsWrapped = true)]
	public class UploadResponse
	{
		[MessageHeader(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201603")]
		public string FilePath;

		public UploadResponse()
		{
		}

		public UploadResponse(string FilePath)
		{
			this.FilePath = FilePath;
		}
	}
}
