using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ExternalUser", Namespace = "http://www.sdltridion.com/Security"), KnownType(typeof(DirectoryServiceUser)), KnownType(typeof(WindowsUser))]
	public class ExternalUser : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string FullNameField;

		private string NameField;

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
		public string FullName
		{
			get
			{
				return this.FullNameField;
			}
			set
			{
				this.FullNameField = value;
			}
		}

		[DataMember(IsRequired = true)]
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
	}
}
