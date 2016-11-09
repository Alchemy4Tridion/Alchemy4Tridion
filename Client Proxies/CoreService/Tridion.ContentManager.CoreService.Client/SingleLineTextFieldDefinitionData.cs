using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SingleLineTextFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SingleLineTextFieldDefinitionData : ItemFieldDefinitionData
	{
		private string DefaultValueField;

		private SingleLineTextListDefinitionData ListField;

		private int? MaxLengthField;

		private int? MinLengthField;

		private string PatternField;

		[DataMember(EmitDefaultValue = false)]
		public string DefaultValue
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
		public SingleLineTextListDefinitionData List
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
		public int? MaxLength
		{
			get
			{
				return this.MaxLengthField;
			}
			set
			{
				this.MaxLengthField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? MinLength
		{
			get
			{
				return this.MinLengthField;
			}
			set
			{
				this.MinLengthField = value;
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
