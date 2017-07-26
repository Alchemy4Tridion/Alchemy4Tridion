using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TemplateData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ComponentTemplateData)), KnownType(typeof(PageTemplateData)), KnownType(typeof(TemplateBuildingBlockData))]
	public class TemplateData : VersionedItemData
	{
		private BinaryContentData BinaryContentField;

		private string ContentField;

		private LinkToSchemaData ParameterSchemaField;

		private string TemplateTypeField;

		[DataMember(EmitDefaultValue = false)]
		public BinaryContentData BinaryContent
		{
			get
			{
				return this.BinaryContentField;
			}
			set
			{
				this.BinaryContentField = value;
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
		public LinkToSchemaData ParameterSchema
		{
			get
			{
				return this.ParameterSchemaField;
			}
			set
			{
				this.ParameterSchemaField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string TemplateType
		{
			get
			{
				return this.TemplateTypeField;
			}
			set
			{
				this.TemplateTypeField = value;
			}
		}
	}
}
