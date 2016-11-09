using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "VirtualFolderData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ResolvedBundleData))]
	public class VirtualFolderData : OrganizationalItemData
	{
		private string ConfigurationField;

		private LinkToSchemaData TypeSchemaField;

		private LinkToApprovalStatusData ApprovalStatusField;

		private string DescriptionField;

		private WorkflowInfo WorkflowInfoField;

		[DataMember(EmitDefaultValue = false)]
		public string Configuration
		{
			get
			{
				return this.ConfigurationField;
			}
			set
			{
				this.ConfigurationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData TypeSchema
		{
			get
			{
				return this.TypeSchemaField;
			}
			set
			{
				this.TypeSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 2)]
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

		[DataMember(EmitDefaultValue = false, Order = 3)]
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

		[DataMember(EmitDefaultValue = false, Order = 4)]
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
