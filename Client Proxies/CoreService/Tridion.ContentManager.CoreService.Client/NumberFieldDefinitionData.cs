using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "NumberFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class NumberFieldDefinitionData : ItemFieldDefinitionData
	{
		private double? DefaultValueField;

		private int? FractionDigitsField;

		private bool IsMaxValueExclusiveField;

		private bool IsMinValueExclusiveField;

		private NumberListDefinitionData ListField;

		private double? MaxValueField;

		private double? MinValueField;

		private string PatternField;

		private int? TotalDigitsField;

		[DataMember(EmitDefaultValue = false)]
		public double? DefaultValue
		{
			get
			{
				return this.DefaultValueField;
			}
			set
			{
				this.DefaultValueField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? FractionDigits
		{
			get
			{
				return this.FractionDigitsField;
			}
			set
			{
				this.FractionDigitsField = value;
			}
		}

		[DataMember]
		public bool IsMaxValueExclusive
		{
			get
			{
				return this.IsMaxValueExclusiveField;
			}
			set
			{
				this.IsMaxValueExclusiveField = value;
			}
		}

		[DataMember]
		public bool IsMinValueExclusive
		{
			get
			{
				return this.IsMinValueExclusiveField;
			}
			set
			{
				this.IsMinValueExclusiveField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public NumberListDefinitionData List
		{
			get
			{
				return this.ListField;
			}
			set
			{
				this.ListField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public double? MaxValue
		{
			get
			{
				return this.MaxValueField;
			}
			set
			{
				this.MaxValueField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public double? MinValue
		{
			get
			{
				return this.MinValueField;
			}
			set
			{
				this.MinValueField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Pattern
		{
			get
			{
				return this.PatternField;
			}
			set
			{
				this.PatternField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? TotalDigits
		{
			get
			{
				return this.TotalDigitsField;
			}
			set
			{
				this.TotalDigitsField = value;
			}
		}
	}
}
