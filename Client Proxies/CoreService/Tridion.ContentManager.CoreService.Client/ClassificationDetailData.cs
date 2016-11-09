using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ClassificationDetailData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ClassificationDetailData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToCategoryData CategoryField;

		private string FieldNameField;

		private bool IsMetadataFieldField;

		private LinkToKeywordData[] KeywordsField;

		private string XPathField;

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
		public LinkToCategoryData Category
		{
			get
			{
				return this.CategoryField;
			}
			set
			{
				this.CategoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string FieldName
		{
			get
			{
				return this.FieldNameField;
			}
			set
			{
				this.FieldNameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool IsMetadataField
		{
			get
			{
				return this.IsMetadataFieldField;
			}
			set
			{
				this.IsMetadataFieldField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToKeywordData[] Keywords
		{
			get
			{
				return this.KeywordsField;
			}
			set
			{
				this.KeywordsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string XPath
		{
			get
			{
				return this.XPathField;
			}
			set
			{
				this.XPathField = value;
			}
		}
	}
}
