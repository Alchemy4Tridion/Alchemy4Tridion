using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "Permissions", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum Permissions
	{
		[EnumMember]
		None = 0,
		[EnumMember]
		Read = 1,
		[EnumMember]
		Write = 2,
		[EnumMember]
		Delete = 4,
		[EnumMember]
		Localize = 8,
		[EnumMember]
		All = 15,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
