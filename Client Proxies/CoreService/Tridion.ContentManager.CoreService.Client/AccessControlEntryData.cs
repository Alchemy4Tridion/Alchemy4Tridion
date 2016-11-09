using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "AccessControlEntryData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class AccessControlEntryData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private Permissions AllowedPermissionsField;

		private Rights AllowedRightsField;

		private Permissions DeniedPermissionsField;

		private Rights DeniedRightsField;

		private LinkToTrusteeData TrusteeField;

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
		public Permissions AllowedPermissions
		{
			get
			{
				return this.AllowedPermissionsField;
			}
			set
			{
				this.AllowedPermissionsField = value;
			}
		}

		[DataMember]
		public Rights AllowedRights
		{
			get
			{
				return this.AllowedRightsField;
			}
			set
			{
				this.AllowedRightsField = value;
			}
		}

		[DataMember]
		public Permissions DeniedPermissions
		{
			get
			{
				return this.DeniedPermissionsField;
			}
			set
			{
				this.DeniedPermissionsField = value;
			}
		}

		[DataMember]
		public Rights DeniedRights
		{
			get
			{
				return this.DeniedRightsField;
			}
			set
			{
				this.DeniedRightsField = value;
			}
		}

		[DataMember(IsRequired = true, EmitDefaultValue = false)]
		public LinkToTrusteeData Trustee
		{
			get
			{
				return this.TrusteeField;
			}
			set
			{
				this.TrusteeField = value;
			}
		}
	}
}
