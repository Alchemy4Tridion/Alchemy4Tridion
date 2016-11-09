using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "DynamicVersionResolvingConditions", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum DynamicVersionResolvingConditions
	{
		[EnumMember]
		Never = 0,
		[EnumMember]
		CheckedOutByUser = 1,
		[EnumMember]
		ReservedAndRevisedByUser = 2,
		[EnumMember]
		AssignedToUser = 4,
		[EnumMember]
		ReadableByUser = 15
	}
}
