using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "WorkflowObjectData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ActivityData)), KnownType(typeof(WorkItemData)), KnownType(typeof(ActivityInstanceData)), KnownType(typeof(ActivityHistoryData)), KnownType(typeof(ProcessData)), KnownType(typeof(ProcessInstanceData)), KnownType(typeof(ProcessHistoryData)), KnownType(typeof(ActivityDefinitionData)), KnownType(typeof(TridionActivityDefinitionData))]
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
