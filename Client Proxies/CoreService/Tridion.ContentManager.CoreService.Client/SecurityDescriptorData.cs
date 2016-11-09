using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SecurityDescriptorData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SecurityDescriptorData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private Permissions PermissionsField;

		private Rights RightsField;

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
		public Permissions Permissions
		{
			get
			{
				return this.PermissionsField;
			}
			set
			{
				this.PermissionsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public Rights Rights
		{
			get
			{
				return this.RightsField;
			}
			set
			{
				this.RightsField = value;
			}
		}
	}
}
