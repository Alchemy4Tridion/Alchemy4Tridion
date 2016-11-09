using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "ActivityState", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum ActivityState
	{
		[EnumMember]
		Assigned = 1,
		[EnumMember]
		Started = 2,
		[EnumMember]
		Failed = 4,
		[EnumMember]
		Finished = 8,
		[EnumMember]
		Suspended = 16,
		[EnumMember]
		WaitingForWorkflowAgent = 32,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
