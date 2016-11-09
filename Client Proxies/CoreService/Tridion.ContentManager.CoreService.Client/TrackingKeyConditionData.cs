using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TrackingKeyConditionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TrackingKeyConditionData : ConditionData
	{
		private LinkToKeywordData KeywordField;

		private NumericalConditionOperator? OperatorField;

		private double? ValueField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToKeywordData Keyword
		{
			get
			{
				return this.KeywordField;
			}
			set
			{
				this.KeywordField = value;
			}
		}

		[DataMember]
		public NumericalConditionOperator? Operator
		{
			get
			{
				return this.OperatorField;
			}
			set
			{
				this.OperatorField = value;
			}
		}

		[DataMember]
		public double? Value
		{
			get
			{
				return this.ValueField;
			}
			set
			{
				this.ValueField = value;
			}
		}
	}
}
