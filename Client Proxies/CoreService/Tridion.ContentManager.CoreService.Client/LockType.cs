using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "LockType", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum LockType
	{
		[EnumMember]
		None = 0,
		[EnumMember]
		CheckedOut = 1,
		[EnumMember]
		Permanent = 2,
		[EnumMember]
		NewItem = 4,
		[EnumMember]
		InWorkflow = 8,
		[EnumMember]
		Reserved = 16,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
