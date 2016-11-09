using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "ProcessFinishReason", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum ProcessFinishReason
	{
		[EnumMember]
		CompletedNormally,
		[EnumMember]
		ForceFinished,
		[EnumMember]
		Terminated,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
