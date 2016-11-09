using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), Flags, DataContract(Name = "Actions", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum Actions
	{
		[EnumMember]
		None = 0,
		[EnumMember]
		CheckOut = 1,
		[EnumMember]
		CheckIn = 2,
		[EnumMember]
		UndoCheckOut = 4,
		[EnumMember]
		HistoryList = 8,
		[EnumMember]
		Rollback = 16,
		[EnumMember]
		Localize = 32,
		[EnumMember]
		Unlocalize = 64,
		[EnumMember]
		Publish = 128,
		[EnumMember]
		UnPublish = 256,
		[EnumMember]
		RePublish = 512,
		[EnumMember]
		Search = 1024,
		[EnumMember]
		Edit = 2048,
		[EnumMember]
		AssignActivity = 4096,
		[EnumMember]
		View = 8192,
		[EnumMember]
		Delete = 16384,
		[EnumMember]
		Cut = 32768,
		[EnumMember]
		Copy = 65536,
		[EnumMember]
		Enable = 131072,
		[EnumMember]
		Disable = 262144,
		[EnumMember]
		PermissionManaged = 524288,
		[EnumMember]
		WorkflowManaged = 1048576,
		[EnumMember]
		BlueprintManaged = 2097152,
		[EnumMember]
		StartActivity = 4194304,
		[EnumMember]
		FinishActivity = 8388608,
		[EnumMember]
		RestartActivity = 16777216,
		[EnumMember]
		FinishProcess = 33554432,
		[EnumMember]
		Execute = 67108864,
		[EnumMember]
		Abort = 134217728,
		[EnumMember]
		Classification = 268435456,
		[EnumMember]
		AddItem = 536870912,
		[EnumMember]
		RemoveItem = 1073741824,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}