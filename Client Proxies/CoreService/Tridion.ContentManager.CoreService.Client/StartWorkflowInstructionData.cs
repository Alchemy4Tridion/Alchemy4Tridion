using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "StartWorkflowInstructionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class StartWorkflowInstructionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ActivityTitleField;

		private LinkToTrusteeData AssigneeField;

		private DateTime? DueDateField;

		private LinkToProcessDefinitionData ProcessDefinitionField;

		private string ProcessInstanceTitleField;

		private LinkToIdentifiableObjectData[] SubjectsField;

		private LinkToWorkflowTypeData WorkflowTypeField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ActivityTitle
		{
			get
			{
				return this.ActivityTitleField;
			}
			set
			{
				this.ActivityTitleField = value;
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

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData ProcessDefinition
		{
			get
			{
				return this.ProcessDefinitionField;
			}
			set
			{
				this.ProcessDefinitionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ProcessInstanceTitle
		{
			get
			{
				return this.ProcessInstanceTitleField;
			}
			set
			{
				this.ProcessInstanceTitleField = value;
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

		[DataMember(EmitDefaultValue = false)]
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
