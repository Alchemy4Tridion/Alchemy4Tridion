using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ActivityInstancesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ActivityInstancesFilterData : WorkflowManagerFilterData
	{
		private ActivityState? ActivityStateField;

		private LinkToRepositoryData ContextRepositoryField;

		private bool? ForAllUsersField;

		private bool IncludeAdditionalDateColumnsField;

		private bool IncludeWorkItemsField;

		private LinkToProcessDefinitionData ProcessDefinitionField;

		private LinkToWorkflowTypeData WorkflowTypeField;

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
		public bool? ForAllUsers
		{
			get
			{
				return this.ForAllUsersField;
			}
			set
			{
				this.ForAllUsersField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IncludeAdditionalDateColumns
		{
			get
			{
				return this.IncludeAdditionalDateColumnsField;
			}
			set
			{
				this.IncludeAdditionalDateColumnsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IncludeWorkItems
		{
			get
			{
				return this.IncludeWorkItemsField;
			}
			set
			{
				this.IncludeWorkItemsField = value;
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
