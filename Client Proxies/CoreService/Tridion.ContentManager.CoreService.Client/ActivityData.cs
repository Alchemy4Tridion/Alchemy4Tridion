using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ActivityData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ActivityInstanceData)), KnownType(typeof(ActivityHistoryData))]
	public class ActivityData : WorkflowObjectData
	{
		private LinkToTrusteeData AssigneeField;

		private DateTime? FinishDateField;

		private string FinishMessageField;

		private LinkToUserData OwnerField;

		private LinkToUserData[] PerformersField;

		private int? PositionField;

		private LinkToProcessData ProcessField;

		private DateTime? StartDateField;

		private DateTime? SuspendDateField;

		private WorkItemData[] WorkItemsField;

		private DateTime? AssignmentDateField;

		private DateTime? DueDateField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToTrusteeData Assignee
		{
			get
			{
				return this.AssigneeField;
			}
			set
			{
				this.AssigneeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? FinishDate
		{
			get
			{
				return this.FinishDateField;
			}
			set
			{
				this.FinishDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FinishMessage
		{
			get
			{
				return this.FinishMessageField;
			}
			set
			{
				this.FinishMessageField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData Owner
		{
			get
			{
				return this.OwnerField;
			}
			set
			{
				this.OwnerField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData[] Performers
		{
			get
			{
				return this.PerformersField;
			}
			set
			{
				this.PerformersField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? Position
		{
			get
			{
				return this.PositionField;
			}
			set
			{
				this.PositionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessData Process
		{
			get
			{
				return this.ProcessField;
			}
			set
			{
				this.ProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? StartDate
		{
			get
			{
				return this.StartDateField;
			}
			set
			{
				this.StartDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? SuspendDate
		{
			get
			{
				return this.SuspendDateField;
			}
			set
			{
				this.SuspendDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public WorkItemData[] WorkItems
		{
			get
			{
				return this.WorkItemsField;
			}
			set
			{
				this.WorkItemsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 10)]
		public DateTime? AssignmentDate
		{
			get
			{
				return this.AssignmentDateField;
			}
			set
			{
				this.AssignmentDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 11)]
		public DateTime? DueDate
		{
			get
			{
				return this.DueDateField;
			}
			set
			{
				this.DueDateField = value;
			}
		}
	}
}
