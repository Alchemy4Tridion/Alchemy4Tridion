using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "ActivityConstraints", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum ActivityConstraints
	{
		[EnumMember]
		None = 0,
		[EnumMember]
		DenyBundleMetadataEditing = 1,
		[EnumMember]
		DenySubjectEditing = 2,
		[EnumMember]
		DenyAddRemoveWorkItem = 4,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
