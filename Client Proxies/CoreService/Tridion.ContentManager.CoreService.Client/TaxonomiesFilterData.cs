using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TaxonomiesFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(TaxonomiesOwlFilterData))]
	public class TaxonomiesFilterData : SubjectRelatedListFilterData
	{
		private LinkToRepositoryLocalObjectData[] ForItemsField;

		private bool? UseForNavigationField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryLocalObjectData[] ForItems
		{
			get
			{
				return this.ForItemsField;
			}
			set
			{
				this.ForItemsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? UseForNavigation
		{
			get
			{
				return this.UseForNavigationField;
			}
			set
			{
				this.UseForNavigationField = value;
			}
		}
	}
}
