using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "CustomerCharacteristicConditionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class CustomerCharacteristicConditionData : ConditionData
	{
		private string NameField;

		private ConditionOperator? OperatorField;

		private string ValueField;

		[DataMember(EmitDefaultValue = false)]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				this.NameField = value;
			}
		}

		[DataMember]
		public ConditionOperator? Operator
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

		[DataMember(EmitDefaultValue = false)]
		public string Value
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
