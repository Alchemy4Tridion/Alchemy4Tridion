using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RepositoryData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(PublicationData)), KnownType(typeof(BluePrintNodeData))]
	public class RepositoryData : SystemWideObjectData
	{
		private AccessControlListData AccessControlListField;

		private string CategoriesXsdField;

		private LinkToSchemaData DefaultMultimediaSchemaField;

		private bool? HasChildrenField;

		private string KeyField;

		private LocationInfo LocationInfoField;

		private string MetadataField;

		private LinkToSchemaData MetadataSchemaField;

		private LinkToRepositoryData[] ParentsField;

		private LinkToFolderData RootFolderField;

		private LinkToProcessDefinitionData TaskProcessField;

		private LinkToBusinessProcessTypeData BusinessProcessTypeField;

		private LinkToApprovalStatusData MinimalLocalizeApprovalStatusField;

		[DataMember(EmitDefaultValue = false)]
		public AccessControlListData AccessControlList
		{
			get
			{
				return this.AccessControlListField;
			}
			set
			{
				this.AccessControlListField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string CategoriesXsd
		{
			get
			{
				return this.CategoriesXsdField;
			}
			set
			{
				this.CategoriesXsdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData DefaultMultimediaSchema
		{
			get
			{
				return this.DefaultMultimediaSchemaField;
			}
			set
			{
				this.DefaultMultimediaSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? HasChildren
		{
			get
			{
				return this.HasChildrenField;
			}
			set
			{
				this.HasChildrenField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Key
		{
			get
			{
				return this.KeyField;
			}
			set
			{
				this.KeyField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LocationInfo LocationInfo
		{
			get
			{
				return this.LocationInfoField;
			}
			set
			{
				this.LocationInfoField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Metadata
		{
			get
			{
				return this.MetadataField;
			}
			set
			{
				this.MetadataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData MetadataSchema
		{
			get
			{
				return this.MetadataSchemaField;
			}
			set
			{
				this.MetadataSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData[] Parents
		{
			get
			{
				return this.ParentsField;
			}
			set
			{
				this.ParentsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToFolderData RootFolder
		{
			get
			{
				return this.RootFolderField;
			}
			set
			{
				this.RootFolderField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData TaskProcess
		{
			get
			{
				return this.TaskProcessField;
			}
			set
			{
				this.TaskProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 11)]
		public LinkToBusinessProcessTypeData BusinessProcessType
		{
			get
			{
				return this.BusinessProcessTypeField;
			}
			set
			{
				this.BusinessProcessTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 12)]
		public LinkToApprovalStatusData MinimalLocalizeApprovalStatus
		{
			get
			{
				return this.MinimalLocalizeApprovalStatusField;
			}
			set
			{
				this.MinimalLocalizeApprovalStatusField = value;
			}
		}
	}
}
