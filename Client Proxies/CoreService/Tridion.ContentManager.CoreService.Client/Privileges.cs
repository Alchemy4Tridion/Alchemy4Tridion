using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "Privileges", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum Privileges
	{
		[EnumMember]
		None = 0,
		[EnumMember]
		SysAdmin = 1,
		[EnumMember]
		ReadOnly = 2,
		[EnumMember]
		IsElevated = 65536
	}
}
