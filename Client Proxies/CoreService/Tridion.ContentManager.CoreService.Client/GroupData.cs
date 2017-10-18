using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "GroupData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class GroupData : TrusteeData
	{
		private ClaimMappingData[] ClaimMappingsField;

		private int? DefaultGroupIdField;

		private LinkWithIsEditableToRepositoryData[] ScopeField;

		private SystemPrivilegesDictionary InheritedSystemPrivilegesField;

		private SystemPrivilege[] SystemPrivilegesField;

		[DataMember(EmitDefaultValue = false)]
		public ClaimMappingData[] ClaimMappings
		{
			get
			{
				return this.ClaimMappingsField;
			}
			set
			{
				this.ClaimMappingsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? DefaultGroupId
		{
			get
			{
				return this.DefaultGroupIdField;
			}
			set
			{
				this.DefaultGroupIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkWithIsEditableToRepositoryData[] Scope
		{
			get
			{
				return this.ScopeField;
			}
			set
			{
				this.ScopeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 3)]
		public SystemPrivilegesDictionary InheritedSystemPrivileges
		{
			get
			{
				return this.InheritedSystemPrivilegesField;
			}
			set
			{
				this.InheritedSystemPrivilegesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public SystemPrivilege[] SystemPrivileges
		{
			get
			{
				return this.SystemPrivilegesField;
			}
			set
			{
				this.SystemPrivilegesField = value;
			}
		}
	}
}
