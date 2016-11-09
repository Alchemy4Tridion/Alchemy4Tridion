using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "ConditionOperator", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum ConditionOperator
	{
		[EnumMember]
		Equals,
		[EnumMember]
		GreaterThan,
		[EnumMember]
		LessThan,
		[EnumMember]
		NotEqual,
		[EnumMember]
		StringEquals,
		[EnumMember]
		Contains,
		[EnumMember]
		StartsWith,
		[EnumMember]
		EndsWith,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
