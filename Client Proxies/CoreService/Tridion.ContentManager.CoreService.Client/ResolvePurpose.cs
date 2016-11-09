using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "ResolvePurpose", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum ResolvePurpose
	{
		[EnumMember]
		Publish,
		[EnumMember]
		UnPublish,
		[EnumMember]
		RePublish,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
