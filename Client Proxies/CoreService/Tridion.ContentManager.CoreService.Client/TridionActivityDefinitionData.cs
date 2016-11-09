using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TridionActivityDefinitionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TridionActivityDefinitionData : ActivityDefinitionData
	{
		private ActivityType? ActivityTypeField;

		private LinkToApprovalStatusData FinishApprovalStatusField;

		private LinkToTridionActivityDefinitionData[] NextActivityDefinitionsField;

		private string ScriptField;

		private bool? AllowOverrideDueDateField;

		private uint? PerformingTimeoutField;

		private string ScriptTypeField;

		private string ExpirationScriptField;

		private string ExpirationScriptTypeField;

		[DataMember(EmitDefaultValue = false)]
		public ActivityType? ActivityType
		{
			get
			{
				return this.ActivityTypeField;
			}
			set
			{
				this.ActivityTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToApprovalStatusData FinishApprovalStatus
		{
			get
			{
				return this.FinishApprovalStatusField;
			}
			set
			{
				this.FinishApprovalStatusField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToTridionActivityDefinitionData[] NextActivityDefinitions
		{
			get
			{
				return this.NextActivityDefinitionsField;
			}
			set
			{
				this.NextActivityDefinitionsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Script
		{
			get
			{
				return this.ScriptField;
			}
			set
			{
				this.ScriptField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 4)]
		public bool? AllowOverrideDueDate
		{
			get
			{
				return this.AllowOverrideDueDateField;
			}
			set
			{
				this.AllowOverrideDueDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public uint? PerformingTimeout
		{
			get
			{
				return this.PerformingTimeoutField;
			}
			set
			{
				this.PerformingTimeoutField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 6)]
		public string ScriptType
		{
			get
			{
				return this.ScriptTypeField;
			}
			set
			{
				this.ScriptTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 7)]
		public string ExpirationScript
		{
			get
			{
				return this.ExpirationScriptField;
			}
			set
			{
				this.ExpirationScriptField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 8)]
		public string ExpirationScriptType
		{
			get
			{
				return this.ExpirationScriptTypeField;
			}
			set
			{
				this.ExpirationScriptTypeField = value;
			}
		}
	}
}
