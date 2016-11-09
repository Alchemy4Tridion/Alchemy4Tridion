using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RepositoryItemsFilterData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class RepositoryItemsFilterData : ItemsFilterData
	{
		private bool? ShowNewItemsField;

		[DataMember(EmitDefaultValue = false)]
		public bool? ShowNewItems
		{
			get
			{
				return this.ShowNewItemsField;
			}
			set
			{
				this.ShowNewItemsField = value;
			}
		}
	}
}
