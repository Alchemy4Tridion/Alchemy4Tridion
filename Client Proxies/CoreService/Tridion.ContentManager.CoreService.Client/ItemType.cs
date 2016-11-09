using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "ItemType", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum ItemType
	{
		[EnumMember]
		None,
		[EnumMember]
		Publication,
		[EnumMember]
		Folder,
		[EnumMember]
		StructureGroup = 4,
		[EnumMember]
		Schema = 8,
		[EnumMember]
		Component = 16,
		[EnumMember]
		ComponentTemplate = 32,
		[EnumMember]
		Page = 64,
		[EnumMember]
		PageTemplate = 128,
		[EnumMember]
		TargetGroup = 256,
		[EnumMember]
		Category = 512,
		[EnumMember]
		Keyword = 1024,
		[EnumMember]
		TemplateBuildingBlock = 2048,
		[EnumMember]
		BusinessProcessType = 4096,
		[EnumMember]
		VirtualFolder = 8192,
		[EnumMember]
		PublicationTarget = 65537,
		[EnumMember]
		TargetType,
		[EnumMember]
		TargetDestination = 65540,
		[EnumMember]
		MultimediaType = 65544,
		[EnumMember]
		User = 65552,
		[EnumMember]
		Group = 65568,
		[EnumMember]
		DirectoryService = 65664,
		[EnumMember]
		DirectoryGroupMapping = 65792,
		[EnumMember]
		Batch = 66048,
		[EnumMember]
		MultipleOperations = 66048,
		[EnumMember]
		PublishTransaction = 66560,
		[EnumMember]
		WorkflowType = 67584,
		[EnumMember]
		ApprovalStatus = 131073,
		[EnumMember]
		ProcessDefinition,
		[EnumMember]
		ProcessInstance = 131076,
		[EnumMember]
		ProcessHistory = 131080,
		[EnumMember]
		ActivityDefinition = 131088,
		[EnumMember]
		ActivityInstance = 131104,
		[EnumMember]
		ActivityHistory = 131136,
		[EnumMember]
		WorkItem = 131200,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
