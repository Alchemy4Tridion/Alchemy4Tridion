using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "UsedItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class UsedItemsFilterData : WhereUsedFilterData
	{
		private bool? IncludeBlueprintParentItemField;

		private bool? IncludeExternalLinksField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeBlueprintParentItem
		{
			get
			{
				return this.IncludeBlueprintParentItemField;
			}
			set
			{
				this.IncludeBlueprintParentItemField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IncludeExternalLinks
		{
			get
			{
				return this.IncludeExternalLinksField;
			}
			set
			{
				this.IncludeExternalLinksField = value;
			}
		}
	}
}
