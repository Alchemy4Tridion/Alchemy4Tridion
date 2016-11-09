using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BasedOnSchemaData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BasedOnSchemaData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string FieldField;

		private string FieldValueField;

		private LinkToSchemaData SchemaField;

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
		public string Field
		{
			get
			{
				return this.FieldField;
			}
			set
			{
				this.FieldField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FieldValue
		{
			get
			{
				return this.FieldValueField;
			}
			set
			{
				this.FieldValueField = value;
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
	}
}
