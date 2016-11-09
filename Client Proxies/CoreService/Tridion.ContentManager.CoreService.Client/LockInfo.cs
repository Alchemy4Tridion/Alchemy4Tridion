using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "LockInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class LockInfo : Info
	{
		private DateTime? LockDateField;

		private LockType? LockTypeField;

		private LinkToUserData LockUserField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? LockDate
		{
			get
			{
				return this.LockDateField;
			}
			set
			{
				this.LockDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LockType? LockType
		{
			get
			{
				return this.LockTypeField;
			}
			set
			{
				this.LockTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData LockUser
		{
			get
			{
				return this.LockUserField;
			}
			set
			{
				this.LockUserField = value;
			}
		}
	}
}
