using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "UserData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(AccessTokenData))]
	public class UserData : TrusteeData
	{
		private bool? IsEnabledField;

		private bool? IsEnabledEditableField;

		private bool? IsPrivilegesEditableField;

		private int? LanguageIdField;

		private int? LocaleIdField;

		private int? PrivilegesField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IsEnabled
		{
			get
			{
				return this.IsEnabledField;
			}
			set
			{
				this.IsEnabledField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsEnabledEditable
		{
			get
			{
				return this.IsEnabledEditableField;
			}
			set
			{
				this.IsEnabledEditableField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsPrivilegesEditable
		{
			get
			{
				return this.IsPrivilegesEditableField;
			}
			set
			{
				this.IsPrivilegesEditableField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? LanguageId
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
		public int? LocaleId
		{
			get
			{
				return this.LocaleIdField;
			}
			set
			{
				this.LocaleIdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? Privileges
		{
			get
			{
				return this.PrivilegesField;
			}
			set
			{
				this.PrivilegesField = value;
			}
		}
	}
}
