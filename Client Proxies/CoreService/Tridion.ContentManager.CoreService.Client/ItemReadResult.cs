using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ItemReadResult", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ItemReadResult : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private CoreServiceFault ErrorField;

		private IdentifiableObjectData ItemField;

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

		[DataMember]
		public CoreServiceFault Error
		{
			get
			{
				return this.ErrorField;
			}
			set
			{
				this.ErrorField = value;
			}
		}

		[DataMember]
		public IdentifiableObjectData Item
		{
			get
			{
				return this.ItemField;
			}
			set
			{
				this.ItemField = value;
			}
		}
	}
}
