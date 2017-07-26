using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "AccessTokenData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class AccessTokenData : UserData
	{
		private DateTime ExpiresAtField;

		private string SignatureField;

		private SystemPrivilegesDictionary InheritedSystemPrivilegesField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime ExpiresAt
		{
			get
			{
				return this.ExpiresAtField;
			}
			set
			{
				this.ExpiresAtField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Signature
		{
			get
			{
				return this.SignatureField;
			}
			set
			{
				this.SignatureField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 2)]
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
	}
}
