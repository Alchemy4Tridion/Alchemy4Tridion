using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ProcessDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(TridionProcessDefinitionData))]
	public class ProcessDefinitionData : RepositoryLocalObjectData
	{
		private ActivityDefinitionData[] ActivityDefinitionsField;

		private bool? StoreSnapshotField;

		[DataMember(EmitDefaultValue = false)]
		public ActivityDefinitionData[] ActivityDefinitions
		{
			get
			{
				return this.ActivityDefinitionsField;
			}
			set
			{
				this.ActivityDefinitionsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public bool? StoreSnapshot
		{
			get
			{
				return this.StoreSnapshotField;
			}
			set
			{
				this.StoreSnapshotField = value;
			}
		}
	}
}
