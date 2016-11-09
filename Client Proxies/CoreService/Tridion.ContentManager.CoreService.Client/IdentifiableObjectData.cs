using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "IdentifiableObjectData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(SchemaData)), KnownType(typeof(GroupData)), KnownType(typeof(MultimediaTypeData)), KnownType(typeof(AccessTokenData)), KnownType(typeof(TargetTypeData)), KnownType(typeof(PublicationTargetData)), KnownType(typeof(ApprovalStatusData)), KnownType(typeof(BatchData)), KnownType(typeof(RegisteredTypeData)), KnownType(typeof(WorkflowTypeData)), KnownType(typeof(PublishTransactionData)), KnownType(typeof(ProcessDefinitionAssociationData)), KnownType(typeof(RepositoryLocalObjectData)), KnownType(typeof(ProcessDefinitionData)), KnownType(typeof(TridionProcessDefinitionData)), KnownType(typeof(OrganizationalItemData)), KnownType(typeof(FolderData)), KnownType(typeof(StructureGroupData)), KnownType(typeof(VirtualFolderData)), KnownType(typeof(ResolvedBundleData)), KnownType(typeof(CategoryData)), KnownType(typeof(BusinessProcessTypeData)), KnownType(typeof(KeywordData)), KnownType(typeof(TargetGroupData)), KnownType(typeof(VersionedItemData)), KnownType(typeof(UserData)), KnownType(typeof(PageData)), KnownType(typeof(TemplateData)), KnownType(typeof(ComponentTemplateData)), KnownType(typeof(PageTemplateData)), KnownType(typeof(TemplateBuildingBlockData)), KnownType(typeof(BundleTypeData)), KnownType(typeof(WorkflowObjectData)), KnownType(typeof(WorkItemData)), KnownType(typeof(ActivityDefinitionData)), KnownType(typeof(TridionActivityDefinitionData)), KnownType(typeof(ProcessData)), KnownType(typeof(ComponentData)), KnownType(typeof(ProcessInstanceData)), KnownType(typeof(PublishingTargetData)), KnownType(typeof(ProcessHistoryData)), KnownType(typeof(ActivityData)), KnownType(typeof(ActivityHistoryData)), KnownType(typeof(ActivityInstanceData)), KnownType(typeof(SystemWideObjectData)), KnownType(typeof(RepositoryData)), KnownType(typeof(PublicationData)), KnownType(typeof(BluePrintNodeData)), KnownType(typeof(TrusteeData))]
	public class IdentifiableObjectData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private AllowedActions AllowedActionsField;

		private string IdField;

		private bool? IsEditableField;

		private ListInfo ListInfoField;

		private string TitleField;

		private BasicVersionInfo VersionInfoField;

		private ExtensionPropertyDictionary ExtensionPropertiesField;

		private ApplicableActionsData ApplicableActionsField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public AllowedActions AllowedActions
		{
			get
			{
				return this.AllowedActionsField;
			}
			set
			{
				this.AllowedActionsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				this.IdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsEditable
		{
			get
			{
				return this.IsEditableField;
			}
			set
			{
				this.IsEditableField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ListInfo ListInfo
		{
			get
			{
				return this.ListInfoField;
			}
			set
			{
				this.ListInfoField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Title
		{
			get
			{
				return this.TitleField;
			}
			set
			{
				this.TitleField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public BasicVersionInfo VersionInfo
		{
			get
			{
				return this.VersionInfoField;
			}
			set
			{
				this.VersionInfoField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 6)]
		public ExtensionPropertyDictionary ExtensionProperties
		{
			get
			{
				return this.ExtensionPropertiesField;
			}
			set
			{
				this.ExtensionPropertiesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 7)]
		public ApplicableActionsData ApplicableActions
		{
			get
			{
				return this.ApplicableActionsField;
			}
			set
			{
				this.ApplicableActionsField = value;
			}
		}
	}
}
