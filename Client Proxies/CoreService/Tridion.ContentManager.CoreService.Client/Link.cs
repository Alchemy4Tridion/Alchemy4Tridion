using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "Link", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(LinkToApprovalStatusData)), KnownType(typeof(LinkToUserData)), KnownType(typeof(LinkWithDescriptionUserData)), KnownType(typeof(LinkToSchemaData)), KnownType(typeof(ExpandableLinkToSchemaData)), KnownType(typeof(LinkToTridionActivityDefinitionData)), KnownType(typeof(ExpandableLinkToTridionActivityDefinitionData)), KnownType(typeof(LinkToTrusteeData)), KnownType(typeof(LinkToProcessData)), KnownType(typeof(LinkToActivityData)), KnownType(typeof(LinkToIdentifiableObjectData)), KnownType(typeof(LinkToActivityDefinitionData)), KnownType(typeof(LinkToWorkflowTypeData)), KnownType(typeof(LinkToProcessDefinitionData)), KnownType(typeof(LinkToRepositoryLocalObjectData)), KnownType(typeof(LinkToOrganizationalItemData)), KnownType(typeof(LinkToMultimediaTypeData)), KnownType(typeof(LinkToKeywordData)), KnownType(typeof(LinkToFolderData)), KnownType(typeof(LinkToComponentTemplateData)), KnownType(typeof(LinkToComponentData)), KnownType(typeof(LinkToTargetGroupData)), KnownType(typeof(LinkToBusinessProcessTypeData)), KnownType(typeof(LinkToPageTemplateData)), KnownType(typeof(LinkToTemplateBuildingBlockData)), KnownType(typeof(LinkToStructureGroupData)), KnownType(typeof(LinkToGroupData)), KnownType(typeof(LinkToActivityInstanceData)), KnownType(typeof(LinkToProcessInstanceData)), KnownType(typeof(LinkToCategoryData)), KnownType(typeof(LinkToPublicationData)), KnownType(typeof(LinkToTargetTypeData)), KnownType(typeof(LinkToVersionedItemData)), KnownType(typeof(LinkToPublicationTargetData)), KnownType(typeof(LinkToTemplateData)), KnownType(typeof(LinkToRepositoryData)), KnownType(typeof(LinkWithIsEditableToRepositoryData))]
	public class Link : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string IdRefField;

		private string TitleField;

		private string WebDavUrlField;

		private string DescriptionField;

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
		public string IdRef
		{
			get
			{
				return this.IdRefField;
			}
			set
			{
				this.IdRefField = value;
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
		public string WebDavUrl
		{
			get
			{
				return this.WebDavUrlField;
			}
			set
			{
				this.WebDavUrlField = value;
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
	}
}
