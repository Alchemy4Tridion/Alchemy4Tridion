using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ComponentTemplateData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ComponentTemplateData : TemplateData
	{
		private bool? AllowOnPageField;

		private LinkToApprovalStatusData ApprovalStatusField;

		private string DynamicTemplateField;

		private bool? IsRepositoryPublishableField;

		private string OutputFormatField;

		private int? PriorityField;

		private LinkToSchemaData[] RelatedSchemasField;

		private LinkToCategoryData[] TrackingCategoriesField;

		private WorkflowInfo WorkflowInfoField;

		[DataMember(EmitDefaultValue = false)]
		public bool? AllowOnPage
		{
			get
			{
				return this.AllowOnPageField;
			}
			set
			{
				this.AllowOnPageField = value;
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
		public string DynamicTemplate
		{
			get
			{
				return this.DynamicTemplateField;
			}
			set
			{
				this.DynamicTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsRepositoryPublishable
		{
			get
			{
				return this.IsRepositoryPublishableField;
			}
			set
			{
				this.IsRepositoryPublishableField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string OutputFormat
		{
			get
			{
				return this.OutputFormatField;
			}
			set
			{
				this.OutputFormatField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? Priority
		{
			get
			{
				return this.PriorityField;
			}
			set
			{
				this.PriorityField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData[] RelatedSchemas
		{
			get
			{
				return this.RelatedSchemasField;
			}
			set
			{
				this.RelatedSchemasField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToCategoryData[] TrackingCategories
		{
			get
			{
				return this.TrackingCategoriesField;
			}
			set
			{
				this.TrackingCategoriesField = value;
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
