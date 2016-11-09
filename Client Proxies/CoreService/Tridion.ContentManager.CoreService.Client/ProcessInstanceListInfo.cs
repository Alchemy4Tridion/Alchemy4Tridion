using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessInstanceListInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ProcessInstanceListInfo : ListInfo
	{
		private ActivityType? ActivityDefinitionTypeField;

		private LinkToApprovalStatusData ApprovalStatusField;

		private ActivityInstanceData CurrentActivityField;

		[DataMember(EmitDefaultValue = false)]
		public ActivityType? ActivityDefinitionType
		{
			get
			{
				return this.ActivityDefinitionTypeField;
			}
			set
			{
				this.ActivityDefinitionTypeField = value;
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
		public ActivityInstanceData CurrentActivity
		{
			get
			{
				return this.CurrentActivityField;
			}
			set
			{
				this.CurrentActivityField = value;
			}
		}
	}
}
