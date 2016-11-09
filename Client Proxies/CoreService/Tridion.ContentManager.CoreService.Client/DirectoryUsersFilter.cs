using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "DirectoryUsersFilter", Namespace = "http://www.sdltridion.com/Security")]
	public class DirectoryUsersFilter : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string SubtreeDNField;

		private UserNameSearchMode? UserNameSearchModeField;

		private string UserNameStartsWithField;

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
		public string SubtreeDN
		{
			get
			{
				return this.SubtreeDNField;
			}
			set
			{
				this.SubtreeDNField = value;
			}
		}

		[DataMember]
		public UserNameSearchMode? UserNameSearchMode
		{
			get
			{
				return this.UserNameSearchModeField;
			}
			set
			{
				this.UserNameSearchModeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string UserNameStartsWith
		{
			get
			{
				return this.UserNameStartsWithField;
			}
			set
			{
				this.UserNameStartsWithField = value;
			}
		}
	}
}
