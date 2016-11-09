using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ListDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(NumberListDefinitionData)), KnownType(typeof(SingleLineTextListDefinitionData)), KnownType(typeof(DateListDefinitionData))]
	public class ListDefinitionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private int HeightField;

		private ListType TypeField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public int Height
		{
			get
			{
				return this.HeightField;
			}
			set
			{
				this.HeightField = value;
			}
		}

		[DataMember(IsRequired = true)]
		public ListType Type
		{
			get
			{
				return this.TypeField;
			}
			set
			{
				this.TypeField = value;
			}
		}
	}
}
