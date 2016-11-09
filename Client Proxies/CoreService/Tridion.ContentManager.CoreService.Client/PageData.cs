using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PageData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PageData : VersionedItemData
	{
		private LinkToApprovalStatusData ApprovalStatusField;

		private ComponentPresentationData[] ComponentPresentationsField;

		private string FileNameField;

		private bool? IsPageTemplateInheritedField;

		private LinkToPageTemplateData PageTemplateField;

		private WorkflowInfo WorkflowInfoField;

		private LinkToSchemaData RegionSchemaField;

		private RegionDictionary RegionsField;

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
		public ComponentPresentationData[] ComponentPresentations
		{
			get
			{
				return this.ComponentPresentationsField;
			}
			set
			{
				this.ComponentPresentationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FileName
		{
			get
			{
				return this.FileNameField;
			}
			set
			{
				this.FileNameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPageTemplateInherited
		{
			get
			{
				return this.IsPageTemplateInheritedField;
			}
			set
			{
				this.IsPageTemplateInheritedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToPageTemplateData PageTemplate
		{
			get
			{
				return this.PageTemplateField;
			}
			set
			{
				this.PageTemplateField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 6)]
		public LinkToSchemaData RegionSchema
		{
			get
			{
				return this.RegionSchemaField;
			}
			set
			{
				this.RegionSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 7)]
		public RegionDictionary Regions
		{
			get
			{
				return this.RegionsField;
			}
			set
			{
				this.RegionsField = value;
			}
		}
	}
}
