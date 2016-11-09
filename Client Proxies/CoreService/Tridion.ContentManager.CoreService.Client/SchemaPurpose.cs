using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "SchemaPurpose", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum SchemaPurpose
	{
		[EnumMember]
		Component,
		[EnumMember]
		Multimedia,
		[EnumMember]
		Embedded,
		[EnumMember]
		Metadata,
		[EnumMember]
		Protocol,
		[EnumMember]
		VirtualFolderType,
		[EnumMember]
		TemplateParameters,
		[EnumMember]
		Bundle,
		[EnumMember]
		Region,
		[EnumMember]
		Widget,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
