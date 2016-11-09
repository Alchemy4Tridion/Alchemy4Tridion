using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WorkflowObjectData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ActivityData)), KnownType(typeof(TridionActivityDefinitionData)), KnownType(typeof(ProcessData)), KnownType(typeof(ProcessInstanceData)), KnownType(typeof(ProcessHistoryData)), KnownType(typeof(ActivityHistoryData)), KnownType(typeof(ActivityDefinitionData)), KnownType(typeof(WorkItemData)), KnownType(typeof(ActivityInstanceData))]
	public class WorkflowObjectData : IdentifiableObjectData
	{
		private LinkToRepositoryData ContextRepositoryField;

		[DataMember(EmitDefaultValue = false)]
		public LinkToRepositoryData ContextRepository
		{
			get
			{
				return this.ContextRepositoryField;
			}
			set
			{
				this.ContextRepositoryField = value;
			}
		}
	}
}
