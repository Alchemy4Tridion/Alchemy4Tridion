using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ProcessInstanceData)), KnownType(typeof(ProcessHistoryData))]
	public class ProcessData : WorkflowObjectData
	{
		private ActivityData[] ActivitiesField;

		private bool? HasSnapshotsField;

		private LinkToIdentifiableObjectData[] SubjectsField;

		private LinkToUserData CreatorField;

		private LinkToWorkflowTypeData WorkflowTypeField;

		[DataMember(EmitDefaultValue = false)]
		public ActivityData[] Activities
		{
			get
			{
				return this.ActivitiesField;
			}
			set
			{
				this.ActivitiesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? HasSnapshots
		{
			get
			{
				return this.HasSnapshotsField;
			}
			set
			{
				this.HasSnapshotsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToIdentifiableObjectData[] Subjects
		{
			get
			{
				return this.SubjectsField;
			}
			set
			{
				this.SubjectsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 3)]
		public LinkToUserData Creator
		{
			get
			{
				return this.CreatorField;
			}
			set
			{
				this.CreatorField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public LinkToWorkflowTypeData WorkflowType
		{
			get
			{
				return this.WorkflowTypeField;
			}
			set
			{
				this.WorkflowTypeField = value;
			}
		}
	}
}
