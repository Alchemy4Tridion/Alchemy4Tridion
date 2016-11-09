using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessInstanceData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ProcessInstanceData : ProcessData
	{
		private LinkToProcessDefinitionData ProcessDefinitionField;

		private VariablesDictionary VariablesField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToProcessDefinitionData ProcessDefinition
		{
			get
			{
				return this.ProcessDefinitionField;
			}
			set
			{
				this.ProcessDefinitionField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public VariablesDictionary Variables
		{
			get
			{
				return this.VariablesField;
			}
			set
			{
				this.VariablesField = value;
			}
		}
	}
}
