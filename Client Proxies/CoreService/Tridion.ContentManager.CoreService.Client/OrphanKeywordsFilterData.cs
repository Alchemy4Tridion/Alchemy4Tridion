using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OrphanKeywordsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class OrphanKeywordsFilterData : KeywordRelatedFilterData
	{
		private LinkToCategoryData RootCategoryField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToCategoryData RootCategory
		{
			get
			{
				return this.RootCategoryField;
			}
			set
			{
				this.RootCategoryField = value;
			}
		}
	}
}
