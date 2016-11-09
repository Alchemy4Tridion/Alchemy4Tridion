using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SchemaFieldsData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SchemaFieldsData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private ItemFieldDefinitionData[] FieldsField;

		private ItemFieldDefinitionData[] MetadataFieldsField;

		private string NamespaceUriField;

		private string RootElementNameField;

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
		public ItemFieldDefinitionData[] Fields
		{
			get
			{
				return this.FieldsField;
			}
			set
			{
				this.FieldsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ItemFieldDefinitionData[] MetadataFields
		{
			get
			{
				return this.MetadataFieldsField;
			}
			set
			{
				this.MetadataFieldsField = value;
			}
		}

		[DataMember]
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

		[DataMember]
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
	}
}
