using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "SynchronizeFlags", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum SynchronizeFlags
	{
		[EnumMember]
		Basic = 0,
		[EnumMember]
		FixNamespace = 1,
		[EnumMember]
		RemoveUnknownFields = 2,
		[EnumMember]
		RemoveAdditionalValues = 4,
		[EnumMember]
		ApplyDefaultValuesForMissingMandatoryFields = 8,
		[EnumMember]
		ApplyDefaultValuesForMissingNonMandatoryFields = 16,
		[EnumMember]
		ApplyFilterXsltToXhtmlFields = 32,
		[EnumMember]
		ConvertFieldType = 64,
		[EnumMember]
		All = 2147483647,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
