using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WebDavFileExtensionMapping", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class WebDavFileExtensionMapping : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string FileExtensionField;

		private ItemType ItemTypeField;

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
		public string FileExtension
		{
			get
			{
				return this.FileExtensionField;
			}
			set
			{
				this.FileExtensionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ItemType ItemType
		{
			get
			{
				return this.ItemTypeField;
			}
			set
			{
				this.ItemTypeField = value;
			}
		}
	}
}
