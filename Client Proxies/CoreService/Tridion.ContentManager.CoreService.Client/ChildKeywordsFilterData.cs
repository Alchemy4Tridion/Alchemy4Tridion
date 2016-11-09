using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ChildKeywordsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ChildKeywordsFilterData : KeywordRelatedFilterData
	{
		private LinkToCategoryData InCategoryField;

		private bool? IsAbstractField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToCategoryData InCategory
		{
			get
			{
				return this.InCategoryField;
			}
			set
			{
				this.InCategoryField = value;
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
	}
}
