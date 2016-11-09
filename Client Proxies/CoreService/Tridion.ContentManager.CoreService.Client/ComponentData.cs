using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ComponentData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ComponentData : VersionedItemData
	{
		private LinkToApprovalStatusData ApprovalStatusField;

		private BinaryContentData BinaryContentField;

		private ComponentType? ComponentTypeField;

		private string ContentField;

		private bool? IsBasedOnMandatorySchemaField;

		private bool? IsBasedOnTridionWebSchemaField;

		private LinkToSchemaData SchemaField;

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
		public BinaryContentData BinaryContent
		{
			get
			{
				return this.BinaryContentField;
			}
			set
			{
				this.BinaryContentField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ComponentType? ComponentType
		{
			get
			{
				return this.ComponentTypeField;
			}
			set
			{
				this.ComponentTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Content
		{
			get
			{
				return this.ContentField;
			}
			set
			{
				this.ContentField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsBasedOnMandatorySchema
		{
			get
			{
				return this.IsBasedOnMandatorySchemaField;
			}
			set
			{
				this.IsBasedOnMandatorySchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsBasedOnTridionWebSchema
		{
			get
			{
				return this.IsBasedOnTridionWebSchemaField;
			}
			set
			{
				this.IsBasedOnTridionWebSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData Schema
		{
			get
			{
				return this.SchemaField;
			}
			set
			{
				this.SchemaField = value;
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
