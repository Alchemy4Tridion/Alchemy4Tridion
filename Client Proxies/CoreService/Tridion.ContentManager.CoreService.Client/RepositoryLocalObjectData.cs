using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RepositoryLocalObjectData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ProcessDefinitionData)), KnownType(typeof(TridionProcessDefinitionData)), KnownType(typeof(OrganizationalItemData)), KnownType(typeof(FolderData)), KnownType(typeof(StructureGroupData)), KnownType(typeof(VirtualFolderData)), KnownType(typeof(ResolvedBundleData)), KnownType(typeof(CategoryData)), KnownType(typeof(BusinessProcessTypeData)), KnownType(typeof(KeywordData)), KnownType(typeof(TargetGroupData)), KnownType(typeof(VersionedItemData)), KnownType(typeof(ComponentData)), KnownType(typeof(PageData)), KnownType(typeof(TemplateData)), KnownType(typeof(ComponentTemplateData)), KnownType(typeof(PageTemplateData)), KnownType(typeof(TemplateBuildingBlockData)), KnownType(typeof(SchemaData)), KnownType(typeof(BundleTypeData))]
	public class RepositoryLocalObjectData : IdentifiableObjectData
	{
		private BluePrintInfo BluePrintInfoField;

		private bool? IsPublishedInContextField;

		private LocationInfo LocationInfoField;

		private string MetadataField;

		private LinkToSchemaData MetadataSchemaField;

		private LockInfo LockInfoField;

		[DataMember(EmitDefaultValue = false)]
		public BluePrintInfo BluePrintInfo
		{
			get
			{
				return this.BluePrintInfoField;
			}
			set
			{
				this.BluePrintInfoField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPublishedInContext
		{
			get
			{
				return this.IsPublishedInContextField;
			}
			set
			{
				this.IsPublishedInContextField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public LockInfo LockInfo
		{
			get
			{
				return this.LockInfoField;
			}
			set
			{
				this.LockInfoField = value;
			}
		}
	}
}
