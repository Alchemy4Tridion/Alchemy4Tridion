using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ApprovalStatusData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ApprovalStatusData : SystemWideObjectData
	{
		private bool? IsDeletedField;

		private int? PositionField;

		[DataMember(EmitDefaultValue = false)]
		public bool? IsDeleted
		{
			get
			{
				return this.IsDeletedField;
			}
			set
			{
				this.IsDeletedField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? Position
		{
			get
			{
				return this.PositionField;
			}
			set
			{
				this.PositionField = value;
			}
		}
	}
}
