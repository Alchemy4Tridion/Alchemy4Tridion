using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "PublishTransactionState", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum PublishTransactionState
	{
		[EnumMember]
		ScheduledForPublish,
		[EnumMember]
		WaitingForPublish,
		[EnumMember]
		InProgress,
		[EnumMember]
		ScheduledForDeployment,
		[EnumMember]
		WaitingForDeployment,
		[EnumMember]
		Failed,
		[EnumMember]
		Success,
		[EnumMember]
		Warning,
		[EnumMember]
		Resolving,
		[EnumMember]
		Rendering,
		[EnumMember]
		Throttled,
		[EnumMember]
		ReadyForTransport,
		[EnumMember]
		Transporting,
		[EnumMember]
		Deploying,
		[EnumMember]
		PreparingDeployment,
		[EnumMember]
		PreCommittingDeployment,
		[EnumMember]
		CommittingDeployment,
		[EnumMember]
		WaitingForUndo,
		[EnumMember]
		Undoing,
		[EnumMember]
		Undone,
		[EnumMember]
		UndoFailed,
		[EnumMember]
		WaitingForCdEnvironment,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
