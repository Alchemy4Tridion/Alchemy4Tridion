using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WhereUsedFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(UsedItemsFilterData)), KnownType(typeof(UsingItemsFilterData))]
	public class WhereUsedFilterData : SubjectRelatedListFilterData
	{
		private LinkToRepositoryData InRepositoryField;

		private ItemType[] ItemTypesField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData InRepository
		{
			get
			{
				return this.InRepositoryField;
			}
			set
			{
				this.InRepositoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ItemType[] ItemTypes
		{
			get
			{
				return this.ItemTypesField;
			}
			set
			{
				this.ItemTypesField = value;
			}
		}
	}
}
