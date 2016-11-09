using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TargetGroupData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TargetGroupData : RepositoryLocalObjectData
	{
		private ConditionData[] ConditionsField;

		private string DescriptionField;

		[DataMember(EmitDefaultValue = false)]
		public ConditionData[] Conditions
		{
			get
			{
				return this.ConditionsField;
			}
			set
			{
				this.ConditionsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				this.DescriptionField = value;
			}
		}
	}
}
