using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "DeleteTaxonomyNodeMode", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum DeleteTaxonomyNodeMode
	{
		[EnumMember]
		DeleteBranch,
		[EnumMember]
		DeleteBranchIncludeChildPublications,
		[EnumMember]
		RemoveParentFromChildren,
		[EnumMember]
		AssignChildrenToGrandparents
	}
}
