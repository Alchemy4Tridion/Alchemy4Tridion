using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BundleTypeData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BundleTypeData : SchemaData
	{
		private string[] MappedItemsField;

		private ResolvedBundleData[] ResolvedBundlesField;

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

		[DataMember(EmitDefaultValue = false)]
		public ResolvedBundleData[] ResolvedBundles
		{
			get
			{
				return this.ResolvedBundlesField;
			}
			set
			{
				this.ResolvedBundlesField = value;
			}
		}
	}
}
