using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PageTemplateData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PageTemplateData : TemplateData
	{
		private LinkToApprovalStatusData ApprovalStatusField;

		private string FileExtensionField;

		private WorkflowInfo WorkflowInfoField;

		private LinkToSchemaData PageSchemaField;

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
		public string FileExtension
		{
			get
			{
				return this.FileExtensionField;
			}
			set
			{
				this.FileExtensionField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 3)]
		public LinkToSchemaData PageSchema
		{
			get
			{
				return this.PageSchemaField;
			}
			set
			{
				this.PageSchemaField = value;
			}
		}
	}
}
