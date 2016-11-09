using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ActivityDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(TridionActivityDefinitionData))]
	public class ActivityDefinitionData : WorkflowObjectData
	{
		private LinkToTrusteeData AssigneeField;

		private string DescriptionField;

		private LinkToProcessDefinitionData ProcessDefinitionField;

		private ActivityConstraints? ActivityConstraintsField;

		[DataMember]
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
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				this.DescriptionField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 3)]
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
	}
}
