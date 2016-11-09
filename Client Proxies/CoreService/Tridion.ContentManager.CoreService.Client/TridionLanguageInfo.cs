using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TridionLanguageInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TridionLanguageInfo : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private int LanguageIdField;

		private string NameField;

		private string NativeNameField;

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
		public int LanguageId
		{
			get
			{
				return this.LanguageIdField;
			}
			set
			{
				this.LanguageIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				this.NameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string NativeName
		{
			get
			{
				return this.NativeNameField;
			}
			set
			{
				this.NativeNameField = value;
			}
		}
	}
}
