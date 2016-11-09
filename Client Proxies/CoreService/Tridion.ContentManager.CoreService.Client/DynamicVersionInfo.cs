using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "DynamicVersionInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class DynamicVersionInfo : Info
	{
		private int? RevisionField;

		private DateTime? RevisionDateField;

		private LinkToUserData RevisorField;

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
		public DateTime? RevisionDate
		{
			get
			{
				return this.RevisionDateField;
			}
			set
			{
				this.RevisionDateField = value;
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
	}
}
