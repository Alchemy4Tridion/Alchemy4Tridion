using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "EmbeddedSchemaFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class EmbeddedSchemaFieldDefinitionData : ItemFieldDefinitionData
	{
		private ItemFieldDefinitionData[] EmbeddedFieldsField;

		private LinkToSchemaData EmbeddedSchemaField;

		[DataMember(EmitDefaultValue = false)]
		public ItemFieldDefinitionData[] EmbeddedFields
		{
			get
			{
				return this.EmbeddedFieldsField;
			}
			set
			{
				this.EmbeddedFieldsField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public LinkToSchemaData EmbeddedSchema
		{
			get
			{
				return this.EmbeddedSchemaField;
			}
			set
			{
				this.EmbeddedSchemaField = value;
			}
		}
	}
}
