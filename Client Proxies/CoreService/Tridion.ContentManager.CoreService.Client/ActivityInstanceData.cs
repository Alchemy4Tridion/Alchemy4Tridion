using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ActivityInstanceData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ActivityInstanceData : ActivityData
	{
		private LinkToActivityDefinitionData ActivityDefinitionField;

		private ActivityState? ActivityStateField;

		private ActivityConstraints? ActivityConstraintsField;

		private string ResumeBookmarkField;

		private string SuspendOrFailReasonField;

		private bool? IsExpirationExecutionField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToActivityDefinitionData ActivityDefinition
		{
			get
			{
				return this.ActivityDefinitionField;
			}
			set
			{
				this.ActivityDefinitionField = value;
			}
		}

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

		[DataMember(EmitDefaultValue = false, Order = 2)]
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

		[DataMember(EmitDefaultValue = false, Order = 3)]
		public string ResumeBookmark
		{
			get
			{
				return this.ResumeBookmarkField;
			}
			set
			{
				this.ResumeBookmarkField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public string SuspendOrFailReason
		{
			get
			{
				return this.SuspendOrFailReasonField;
			}
			set
			{
				this.SuspendOrFailReasonField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public bool? IsExpirationExecution
		{
			get
			{
				return this.IsExpirationExecutionField;
			}
			set
			{
				this.IsExpirationExecutionField = value;
			}
		}
	}
}
