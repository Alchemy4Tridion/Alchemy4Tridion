using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TrusteeData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(UserData)), KnownType(typeof(GroupData)), KnownType(typeof(AccessTokenData))]
	public class TrusteeData : SystemWideObjectData
	{
		private string DescriptionField;

		private GroupMembershipData[] GroupMembershipsField;

		private bool? IsPredefinedField;

		[DataMember(EmitDefaultValue = false)]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				this.DescriptionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public GroupMembershipData[] GroupMemberships
		{
			get
			{
				return this.GroupMembershipsField;
			}
			set
			{
				this.GroupMembershipsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPredefined
		{
			get
			{
				return this.IsPredefinedField;
			}
			set
			{
				this.IsPredefinedField = value;
			}
		}
	}
}
