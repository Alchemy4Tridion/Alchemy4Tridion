using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "LoadFlags", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum LoadFlags
	{
		[EnumMember]
		None = 0,
		[EnumMember]
		WebDavUrls = 1,
		[EnumMember]
		KeywordXlinks = 2,
		[EnumMember]
		Expanded = 4,
		[EnumMember]
		IncludeAllowedActions = 8,
		[EnumMember]
		IncludeDynamicVersionInfo = 16,
		[EnumMember]
		ExpandLinks = 32
	}
}
