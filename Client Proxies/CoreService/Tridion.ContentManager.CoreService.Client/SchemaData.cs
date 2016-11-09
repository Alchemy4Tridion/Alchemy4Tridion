using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SchemaData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(BundleTypeData))]
	public class SchemaData : VersionedItemData
	{
		private LinkToMultimediaTypeData[] AllowedMultimediaTypesField;

		private LinkToProcessDefinitionData ComponentProcessField;

		private string DescriptionField;

		private bool? IsTridionWebSchemaField;

		private string NamespaceUriField;

		private SchemaPurpose? PurposeField;

		private string RootElementNameField;

		private string XsdField;

		private LinkToProcessDefinitionData BundleProcessField;

		private bool? DeleteBundleOnProcessFinishedField;

		private RegionDefinitionData RegionDefinitionField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToMultimediaTypeData[] AllowedMultimediaTypes
		{
			get
			{
				return this.AllowedMultimediaTypesField;
			}
			set
			{
				this.AllowedMultimediaTypesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData ComponentProcess
		{
			get
			{
				return this.ComponentProcessField;
			}
			set
			{
				this.ComponentProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
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

		[DataMember(EmitDefaultValue = false)]
		public bool? IsTridionWebSchema
		{
			get
			{
				return this.IsTridionWebSchemaField;
			}
			set
			{
				this.IsTridionWebSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string NamespaceUri
		{
			get
			{
				return this.NamespaceUriField;
			}
			set
			{
				this.NamespaceUriField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public SchemaPurpose? Purpose
		{
			get
			{
				return this.PurposeField;
			}
			set
			{
				this.PurposeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string RootElementName
		{
			get
			{
				return this.RootElementNameField;
			}
			set
			{
				this.RootElementNameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Xsd
		{
			get
			{
				return this.XsdField;
			}
			set
			{
				this.XsdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 8)]
		public LinkToProcessDefinitionData BundleProcess
		{
			get
			{
				return this.BundleProcessField;
			}
			set
			{
				this.BundleProcessField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 9)]
		public bool? DeleteBundleOnProcessFinished
		{
			get
			{
				return this.DeleteBundleOnProcessFinishedField;
			}
			set
			{
				this.DeleteBundleOnProcessFinishedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 10)]
		public RegionDefinitionData RegionDefinition
		{
			get
			{
				return this.RegionDefinitionField;
			}
			set
			{
				this.RegionDefinitionField = value;
			}
		}
	}
}
