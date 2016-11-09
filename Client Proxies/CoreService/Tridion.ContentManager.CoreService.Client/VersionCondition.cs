using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "VersionCondition", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum VersionCondition
	{
		[EnumMember]
		AllVersions = 1,
		[EnumMember]
		OnlyLatestVersions,
		[EnumMember]
		OnlyLatestAndCheckedOutVersions = 4
	}
}
