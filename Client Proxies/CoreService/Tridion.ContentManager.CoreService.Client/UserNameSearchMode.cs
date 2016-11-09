using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "UserNameSearchMode", Namespace = "http://www.sdltridion.com/Security")]
	public enum UserNameSearchMode
	{
		[EnumMember]
		UserNameOnly,
		[EnumMember]
		FullNameOnly
	}
}
