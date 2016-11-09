using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "PublishPriority", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum PublishPriority
	{
		[EnumMember]
		Low = 2,
		[EnumMember]
		Normal = 4,
		[EnumMember]
		High = 6,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
