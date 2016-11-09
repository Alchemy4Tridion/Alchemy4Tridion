using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "DirectoryServiceUser", Namespace = "http://www.sdltridion.com/Security")]
	public class DirectoryServiceUser : ExternalUser
	{
		private AdditionalAttributes AdditionalAttributesField;

		private string DNField;

		[DataMember(EmitDefaultValue = false)]
		public AdditionalAttributes AdditionalAttributes
		{
			get
			{
				return this.AdditionalAttributesField;
			}
			set
			{
				this.AdditionalAttributesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string DN
		{
			get
			{
				return this.DNField;
			}
			set
			{
				this.DNField = value;
			}
		}
	}
}
