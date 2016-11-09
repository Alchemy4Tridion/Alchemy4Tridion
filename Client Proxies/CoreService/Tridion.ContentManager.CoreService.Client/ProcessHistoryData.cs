using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessHistoryData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ProcessHistoryData : ProcessData
	{
		private DateTime? FinishDateField;

		private ProcessFinishReason? FinishReasonField;

		private string ProcessDefinitionTitleField;

		[DataMember(EmitDefaultValue = false)]
		public DateTime? FinishDate
		{
			get
			{
				return this.FinishDateField;
			}
			set
			{
				this.FinishDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ProcessFinishReason? FinishReason
		{
			get
			{
				return this.FinishReasonField;
			}
			set
			{
				this.FinishReasonField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ProcessDefinitionTitle
		{
			get
			{
				return this.ProcessDefinitionTitleField;
			}
			set
			{
				this.ProcessDefinitionTitleField = value;
			}
		}
	}
}
