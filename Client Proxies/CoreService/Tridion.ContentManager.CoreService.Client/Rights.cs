using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "Rights", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum Rights
	{
		[EnumMember]
		All = 262143,
		[EnumMember]
		None = 0,
		[EnumMember]
		PublicationAccess = 1,
		[EnumMember]
		PublicationManagement = 2,
		[EnumMember]
		FolderManagement = 4,
		[EnumMember]
		StructureGroupManagement = 8,
		[EnumMember]
		SchemaManagement = 16,
		[EnumMember]
		ComponentManagement = 32,
		[EnumMember]
		ComponentTemplateManagement = 64,
		[EnumMember]
		PageManagement = 128,
		[EnumMember]
		PageTemplateManagement = 256,
		[EnumMember]
		ProfileManagement = 512,
		[EnumMember]
		PublishManagement = 1024,
		[EnumMember]
		PermissionManagement = 2048,
		[EnumMember]
		WorkflowManagement = 4096,
		[EnumMember]
		CategoryManagement = 8192,
		[EnumMember]
		TemplateBuildingBlockManagement = 16384,
		[EnumMember]
		VirtualFolderManagement = 32768,
		[EnumMember]
		BundleManagement = 65536,
		[EnumMember]
		BusinessProcessTypeManagement = 131072,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
