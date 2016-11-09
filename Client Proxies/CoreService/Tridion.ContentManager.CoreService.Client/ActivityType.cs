using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "ActivityType", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum ActivityType
	{
		[EnumMember]
		Normal,
		[EnumMember]
		Decision,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
