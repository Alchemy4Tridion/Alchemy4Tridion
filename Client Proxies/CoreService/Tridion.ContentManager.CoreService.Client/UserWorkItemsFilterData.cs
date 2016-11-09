using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "UserWorkItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class UserWorkItemsFilterData : WorkflowManagerFilterData
	{
		private ActivityState? ActivityStateField;

		private LinkToRepositoryData ContextRepositoryField;

		private LinkToVersionedItemData SubjectField;

		[DataMember(EmitDefaultValue = false)]
		public ActivityState? ActivityState
		{
			get
			{
				return this.ActivityStateField;
			}
			set
			{
				this.ActivityStateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ContextRepository
		{
			get
			{
				return this.ContextRepositoryField;
			}
			set
			{
				this.ContextRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToVersionedItemData Subject
		{
			get
			{
				return this.SubjectField;
			}
			set
			{
				this.SubjectField = value;
			}
		}
	}
}
