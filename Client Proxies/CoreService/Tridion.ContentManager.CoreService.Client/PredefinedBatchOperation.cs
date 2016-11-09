using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name = "PredefinedBatchOperation", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public enum PredefinedBatchOperation
	{
		[EnumMember]
		CheckIn,
		[EnumMember]
		CheckOut,
		[EnumMember]
		Classify,
		[EnumMember]
		Copy,
		[EnumMember]
		Delete,
		[EnumMember]
		FinishActivity,
		[EnumMember]
		ForceFinishProcess,
		[EnumMember]
		Localize,
		[EnumMember]
		Move,
		[EnumMember]
		Publish,
		[EnumMember]
		ReClassify,
		[EnumMember]
		StartActivity,
		[EnumMember]
		UnClassify,
		[EnumMember]
		UnLocalize,
		[EnumMember]
		UnPublish,
		[EnumMember]
		UndoCheckOut,
		[EnumMember]
		DeleteTaxonomyNode,
		[EnumMember]
		SwitchUserEnabledState,
		[EnumMember]
		CopyToKeyword,
		[EnumMember]
		MoveToKeyword,
		[EnumMember]
		ReAssignActivity,
		[EnumMember]
		RestartActivity,
		[EnumMember]
		SuspendActivity,
		[EnumMember]
		ResumeActivity,
		[EnumMember]
		SynchronizeWithSchemaAndUpdate,
		[EnumMember]
		Promote,
		[EnumMember]
		Demote,
		[EnumMember]
		UnknownByClient = -2147483648
	}
}
