using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "DecisionActivityFinishData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class DecisionActivityFinishData : ActivityFinishData
	{
		private LinkToActivityDefinitionData NextActivityField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToActivityDefinitionData NextActivity
		{
			get
			{
				return this.NextActivityField;
			}
			set
			{
				this.NextActivityField = value;
			}
		}
	}
}
