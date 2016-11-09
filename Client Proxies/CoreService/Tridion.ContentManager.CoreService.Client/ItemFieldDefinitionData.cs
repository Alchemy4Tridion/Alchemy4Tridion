using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ItemFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(MultiLineTextFieldDefinitionData)), KnownType(typeof(SingleLineTextFieldDefinitionData)), KnownType(typeof(XhtmlFieldDefinitionData)), KnownType(typeof(NumberFieldDefinitionData)), KnownType(typeof(DateFieldDefinitionData)), KnownType(typeof(MultimediaLinkFieldDefinitionData)), KnownType(typeof(ComponentLinkFieldDefinitionData)), KnownType(typeof(ExternalLinkFieldDefinitionData)), KnownType(typeof(EmbeddedSchemaFieldDefinitionData)), KnownType(typeof(KeywordFieldDefinitionData))]
	public class ItemFieldDefinitionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string CustomUrlField;

		private string DescriptionField;

		private int MaxOccursField;

		private int MinOccursField;

		private string NameField;

		private XElement ExtensionXmlField;

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
		public string CustomUrl
		{
			get
			{
				return this.CustomUrlField;
			}
			set
			{
				this.CustomUrlField = value;
			}
		}

		[DataMember(IsRequired = true)]
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

		[DataMember(IsRequired = true)]
		public int MaxOccurs
		{
			get
			{
				return this.MaxOccursField;
			}
			set
			{
				this.MaxOccursField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public int MinOccurs
		{
			get
			{
				return this.MinOccursField;
			}
			set
			{
				this.MinOccursField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				this.NameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public XElement ExtensionXml
		{
			get
			{
				return this.ExtensionXmlField;
			}
			set
			{
				this.ExtensionXmlField = value;
			}
		}
	}
}
