using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ResolvedBundleData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ResolvedBundleData : VirtualFolderData
	{
		private int ItemCountField;

		private string[] MappedItemsField;

		[DataMember]
		public int ItemCount
		{
			get
			{
				return this.ItemCountField;
			}
			set
			{
				this.ItemCountField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string[] MappedItems
		{
			get
			{
				return this.MappedItemsField;
			}
			set
			{
				this.MappedItemsField = value;
			}
		}
	}
}
