using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WorkflowInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class WorkflowInfo : Info
	{
		private string ActivityDefinitionDescriptionField;

		private LinkToActivityInstanceData ActivityInstanceField;

		private LinkToTrusteeData AssigneeField;

		private DateTime? CreationDateField;

		private DateTime? FinishDateField;

		private LinkToUserData PerformerField;

		private string PreviousMessageField;

		private LinkToProcessInstanceData ProcessInstanceField;

		private DateTime? StartDateField;

		private ActivityState? ActivityStateField;

		private ActivityConstraints? ActivityConstraintsField;

		private DateTime? AssignmentDateField;

		private DateTime? DueDateField;

		[DataMember(EmitDefaultValue = false)]
		public string ActivityDefinitionDescription
		{
			get
			{
				return this.ActivityDefinitionDescriptionField;
			}
			set
			{
				this.ActivityDefinitionDescriptionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToActivityInstanceData ActivityInstance
		{
			get
			{
				return this.ActivityInstanceField;
			}
			set
			{
				this.ActivityInstanceField = value;
			}
		}

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
		public DateTime? CreationDate
		{
			get
			{
				return this.CreationDateField;
			}
			set
			{
				this.CreationDateField = value;
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
		public LinkToUserData Performer
		{
			get
			{
				return this.PerformerField;
			}
			set
			{
				this.PerformerField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PreviousMessage
		{
			get
			{
				return this.PreviousMessageField;
			}
			set
			{
				this.PreviousMessageField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessInstanceData ProcessInstance
		{
			get
			{
				return this.ProcessInstanceField;
			}
			set
			{
				this.ProcessInstanceField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 9)]
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

		[DataMember(EmitDefaultValue = false, Order = 10)]
		public ActivityConstraints? ActivityConstraints
		{
			get
			{
				return this.ActivityConstraintsField;
			}
			set
			{
				this.ActivityConstraintsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 11)]
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

		[DataMember(EmitDefaultValue = false, Order = 12)]
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
