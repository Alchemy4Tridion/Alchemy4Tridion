using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "DateFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class DateFieldDefinitionData : ItemFieldDefinitionData
	{
		private DateTime? DefaultValueField;

		private bool IsMaxValueExclusiveField;

		private bool IsMinValueExclusiveField;

		private DateListDefinitionData ListField;

		private DateTime? MaxValueField;

		private DateTime? MinValueField;

		private string PatternField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? DefaultValue
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
		public DateListDefinitionData List
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
		public DateTime? MaxValue
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
		public DateTime? MinValue
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
	}
}
