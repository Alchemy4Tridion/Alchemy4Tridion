using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BasicVersionInfo", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(FullVersionInfo)), KnownType(typeof(LimitedVersionInfo))]
	public class BasicVersionInfo : Info
	{
		private DateTime? CreationDateField;

		private DateTime? RevisionDateField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? CreationDate
		{
			get
			{
				return this.CreationDateField;
			}
			set
			{
				this.CreationDateField = value;
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
	}
}
