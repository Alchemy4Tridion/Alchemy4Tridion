using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "UndoState", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum UndoState
	{
		[EnumMember]
		NotApplicable,
		[EnumMember]
		NoActionRequired,
		[EnumMember]
		Removed,
		[EnumMember]
		Reverted,
		[EnumMember]
		RevertFailed,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
