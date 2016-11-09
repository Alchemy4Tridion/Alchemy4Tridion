using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "FullVersionInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class FullVersionInfo : LimitedVersionInfo
	{
		private DateTime? CheckOutDateField;

		private LinkToUserData CheckOutUserField;

		private bool? IsNewField;

		private int? LastVersionField;

		private LockType? LockTypeField;

		private int? RevisionField;

		private LinkToUserData RevisorField;

		private string SystemCommentField;

		private int? VersionField;

		private string UserCommentField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? CheckOutDate
		{
			get
			{
				return this.CheckOutDateField;
			}
			set
			{
				this.CheckOutDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData CheckOutUser
		{
			get
			{
				return this.CheckOutUserField;
			}
			set
			{
				this.CheckOutUserField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? IsNew
		{
			get
			{
				return this.IsNewField;
			}
			set
			{
				this.IsNewField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? LastVersion
		{
			get
			{
				return this.LastVersionField;
			}
			set
			{
				this.LastVersionField = value;
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
		public int? Revision
		{
			get
			{
				return this.RevisionField;
			}
			set
			{
				this.RevisionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData Revisor
		{
			get
			{
				return this.RevisorField;
			}
			set
			{
				this.RevisorField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string SystemComment
		{
			get
			{
				return this.SystemCommentField;
			}
			set
			{
				this.SystemCommentField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? Version
		{
			get
			{
				return this.VersionField;
			}
			set
			{
				this.VersionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 9)]
		public string UserComment
		{
			get
			{
				return this.UserCommentField;
			}
			set
			{
				this.UserCommentField = value;
			}
		}
	}
}
