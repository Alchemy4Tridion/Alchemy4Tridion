using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "InstanceData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class InstanceData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToIdentifiableObjectData ContainerItemField;

		private string ContentField;

		private string MetadataField;

		private LinkToSchemaData SchemaField;

		private RegionData RegionField;

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
		public LinkToIdentifiableObjectData ContainerItem
		{
			get
			{
				return this.ContainerItemField;
			}
			set
			{
				this.ContainerItemField = value;
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

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public RegionData Region
		{
			get
			{
				return this.RegionField;
			}
			set
			{
				this.RegionField = value;
			}
		}
	}
}
