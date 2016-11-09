using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "WhereUsedCommentToken", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum WhereUsedCommentToken
	{
		[EnumMember]
		ParentItem,
		[EnumMember]
		LocalCopy,
		[EnumMember]
		OnlyOldVersions,
		[EnumMember]
		OnlyCheckedOutVersion,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
