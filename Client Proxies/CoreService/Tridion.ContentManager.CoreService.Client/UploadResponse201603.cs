using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "UploadResponse", WrapperNamespace = "http://www.sdltridion.com/ContentManager/CoreService/201603", IsWrapped = true)]
	public class UploadResponse201603 : IUploadResponse
	{
		[MessageHeader(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201603")]
		public string FilePath;

		public UploadResponse201603()
		{
		}

		public UploadResponse201603(string FilePath)
		{
			this.FilePath = FilePath;
		}
	}
}
