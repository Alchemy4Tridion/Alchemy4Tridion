using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublicationData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(BluePrintNodeData))]
	public class PublicationData : RepositoryData
	{
		private LinkToComponentTemplateData ComponentSnapshotTemplateField;

		private LinkToProcessDefinitionData ComponentTemplateProcessField;

		private LinkToComponentTemplateData DefaultComponentTemplateField;

		private LinkToPageTemplateData DefaultPageTemplateField;

		private LinkToTemplateBuildingBlockData DefaultTemplateBuildingBlockField;

		private string MultimediaPathField;

		private string MultimediaUrlField;

		private LinkToPageTemplateData PageSnapshotTemplateField;

		private LinkToProcessDefinitionData PageTemplateProcessField;

		private string PublicationPathField;

		private string PublicationTypeField;

		private string PublicationUrlField;

		private LinkToStructureGroupData RootStructureGroupField;

		private bool? ShareProcessAssociationsField;

		private LinkToProcessDefinitionData TemplateBundleProcessField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToComponentTemplateData ComponentSnapshotTemplate
		{
			get
			{
				return this.ComponentSnapshotTemplateField;
			}
			set
			{
				this.ComponentSnapshotTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData ComponentTemplateProcess
		{
			get
			{
				return this.ComponentTemplateProcessField;
			}
			set
			{
				this.ComponentTemplateProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToComponentTemplateData DefaultComponentTemplate
		{
			get
			{
				return this.DefaultComponentTemplateField;
			}
			set
			{
				this.DefaultComponentTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToPageTemplateData DefaultPageTemplate
		{
			get
			{
				return this.DefaultPageTemplateField;
			}
			set
			{
				this.DefaultPageTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToTemplateBuildingBlockData DefaultTemplateBuildingBlock
		{
			get
			{
				return this.DefaultTemplateBuildingBlockField;
			}
			set
			{
				this.DefaultTemplateBuildingBlockField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string MultimediaPath
		{
			get
			{
				return this.MultimediaPathField;
			}
			set
			{
				this.MultimediaPathField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string MultimediaUrl
		{
			get
			{
				return this.MultimediaUrlField;
			}
			set
			{
				this.MultimediaUrlField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToPageTemplateData PageSnapshotTemplate
		{
			get
			{
				return this.PageSnapshotTemplateField;
			}
			set
			{
				this.PageSnapshotTemplateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData PageTemplateProcess
		{
			get
			{
				return this.PageTemplateProcessField;
			}
			set
			{
				this.PageTemplateProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PublicationPath
		{
			get
			{
				return this.PublicationPathField;
			}
			set
			{
				this.PublicationPathField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PublicationType
		{
			get
			{
				return this.PublicationTypeField;
			}
			set
			{
				this.PublicationTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string PublicationUrl
		{
			get
			{
				return this.PublicationUrlField;
			}
			set
			{
				this.PublicationUrlField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToStructureGroupData RootStructureGroup
		{
			get
			{
				return this.RootStructureGroupField;
			}
			set
			{
				this.RootStructureGroupField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? ShareProcessAssociations
		{
			get
			{
				return this.ShareProcessAssociationsField;
			}
			set
			{
				this.ShareProcessAssociationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData TemplateBundleProcess
		{
			get
			{
				return this.TemplateBundleProcessField;
			}
			set
			{
				this.TemplateBundleProcessField = value;
			}
		}
	}
}
