using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ProcessesFilterData : WorkflowManagerFilterData
	{
		private LinkToUserData ForPerformerField;

		private LinkToProcessDefinitionData ForProcessDefinitionField;

		private LinkToRepositoryData ForRepositoryField;

		private ProcessType? ProcessTypeField;

		private LinkToIdentifiableObjectData ForSubjectField;

		private bool IncludeWorkflowTypeColumnsField;

		private bool? LegacyModeField;

		private LinkToWorkflowTypeData WorkflowTypeField;

		private bool IncludeSubjectsColumnField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData ForPerformer
		{
			get
			{
				return this.ForPerformerField;
			}
			set
			{
				this.ForPerformerField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData ForProcessDefinition
		{
			get
			{
				return this.ForProcessDefinitionField;
			}
			set
			{
				this.ForProcessDefinitionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ForRepository
		{
			get
			{
				return this.ForRepositoryField;
			}
			set
			{
				this.ForRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ProcessType? ProcessType
		{
			get
			{
				return this.ProcessTypeField;
			}
			set
			{
				this.ProcessTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public LinkToIdentifiableObjectData ForSubject
		{
			get
			{
				return this.ForSubjectField;
			}
			set
			{
				this.ForSubjectField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public bool IncludeWorkflowTypeColumns
		{
			get
			{
				return this.IncludeWorkflowTypeColumnsField;
			}
			set
			{
				this.IncludeWorkflowTypeColumnsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 6)]
		public bool? LegacyMode
		{
			get
			{
				return this.LegacyModeField;
			}
			set
			{
				this.LegacyModeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 7)]
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

		[DataMember(EmitDefaultValue = false, Order = 8)]
		public bool IncludeSubjectsColumn
		{
			get
			{
				return this.IncludeSubjectsColumnField;
			}
			set
			{
				this.IncludeSubjectsColumnField = value;
			}
		}
	}
}
