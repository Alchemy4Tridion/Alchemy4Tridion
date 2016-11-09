using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "KeywordData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class KeywordData : RepositoryLocalObjectData
	{
		private string DescriptionField;

		private bool? IsAbstractField;

		private bool? IsRootField;

		private string KeyField;

		private LinkToKeywordData[] ParentKeywordsField;

		private LinkToKeywordData[] RelatedKeywordsField;

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
		public bool? IsAbstract
		{
			get
			{
				return this.IsAbstractField;
			}
			set
			{
				this.IsAbstractField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsRoot
		{
			get
			{
				return this.IsRootField;
			}
			set
			{
				this.IsRootField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Key
		{
			get
			{
				return this.KeyField;
			}
			set
			{
				this.KeyField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToKeywordData[] ParentKeywords
		{
			get
			{
				return this.ParentKeywordsField;
			}
			set
			{
				this.ParentKeywordsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToKeywordData[] RelatedKeywords
		{
			get
			{
				return this.RelatedKeywordsField;
			}
			set
			{
				this.RelatedKeywordsField = value;
			}
		}
	}
}
