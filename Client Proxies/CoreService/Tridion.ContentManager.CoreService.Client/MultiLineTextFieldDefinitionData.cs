using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "MultiLineTextFieldDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class MultiLineTextFieldDefinitionData : ItemFieldDefinitionData
	{
		private string DefaultValueField;

		private int HeightField;

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

		[DataMember(IsRequired = true)]
		public int Height
		{
			get
			{
				return this.HeightField;
			}
			set
			{
				this.HeightField = value;
			}
		}
	}
}
