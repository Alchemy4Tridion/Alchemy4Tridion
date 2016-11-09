using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "KeywordFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class KeywordFieldDefinitionData : ItemFieldDefinitionData
	{
		private LinkToCategoryData CategoryField;

		private LinkToKeywordData DefaultValueField;

		private ListDefinitionData ListField;

		[DataMember(IsRequired = true)]
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
		public LinkToKeywordData DefaultValue
		{
			get
			{
				return this.DefaultValueField;
			}
			set
			{
				this.DefaultValueField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ListDefinitionData List
		{
			get
			{
				return this.ListField;
			}
			set
			{
				this.ListField = value;
			}
		}
	}
}
