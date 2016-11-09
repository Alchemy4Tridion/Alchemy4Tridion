using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "QueueMessageAction", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum QueueMessageAction
	{
		[EnumMember]
		None,
		[EnumMember]
		Insert,
		[EnumMember]
		Update,
		[EnumMember]
		Delete,
		[EnumMember]
		Reset,
		[EnumMember]
		ExpirationActivity,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
