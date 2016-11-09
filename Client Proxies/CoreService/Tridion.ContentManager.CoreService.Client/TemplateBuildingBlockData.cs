using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TemplateBuildingBlockData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TemplateBuildingBlockData : TemplateData
	{
		private LinkToApprovalStatusData ApprovalStatusField;

		private WorkflowInfo WorkflowInfoField;

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
		public WorkflowInfo WorkflowInfo
		{
			get
			{
				return this.WorkflowInfoField;
			}
			set
			{
				this.WorkflowInfoField = value;
			}
		}
	}
}
