using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ActivityHistoryData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ActivityHistoryData : ActivityData
	{
		private ActivityType? ActivityTypeField;

		private LinkToApprovalStatusData ApprovalStatusField;

		private string DescriptionField;

		private string ActivityDefinitionTitleField;

		[DataMember(EmitDefaultValue = false)]
		public ActivityType? ActivityType
		{
			get
			{
				return this.ActivityTypeField;
			}
			set
			{
				this.ActivityTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToApprovalStatusData ApprovalStatus
		{
			get
			{
				return this.ApprovalStatusField;
			}
			set
			{
				this.ApprovalStatusField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 3)]
		public string ActivityDefinitionTitle
		{
			get
			{
				return this.ActivityDefinitionTitleField;
			}
			set
			{
				this.ActivityDefinitionTitleField = value;
			}
		}
	}
}
