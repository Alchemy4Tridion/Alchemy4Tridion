using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "AccessControlListData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class AccessControlListData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private AccessControlEntryData[] AccessControlEntriesField;

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

		[DataMember(EmitDefaultValue = false)]
		public AccessControlEntryData[] AccessControlEntries
		{
			get
			{
				return this.AccessControlEntriesField;
			}
			set
			{
				this.AccessControlEntriesField = value;
			}
		}
	}
}
