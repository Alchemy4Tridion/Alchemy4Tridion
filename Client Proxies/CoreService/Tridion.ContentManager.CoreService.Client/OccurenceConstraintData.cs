using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OccurenceConstraintData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class OccurenceConstraintData : ComponentPresentationConstraintData
	{
		private int? MaxOccursField;

		private int MinOccursField;

		[DataMember(EmitDefaultValue = false)]
		public int? MaxOccurs
		{
			get
			{
				return this.MaxOccursField;
			}
			set
			{
				this.MaxOccursField = value;
			}
		}

		[DataMember]
		public int MinOccurs
		{
			get
			{
				return this.MinOccursField;
			}
			set
			{
				this.MinOccursField = value;
			}
		}
	}
}
