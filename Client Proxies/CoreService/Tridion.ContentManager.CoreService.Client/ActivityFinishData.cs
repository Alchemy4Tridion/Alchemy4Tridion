using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ActivityFinishData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(DecisionActivityFinishData))]
	public class ActivityFinishData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string MessageField;

		private LinkToTrusteeData NextAssigneeField;

		private DateTime? NextActivityDueDateField;

		private string NextActivityTitleField;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Message
		{
			get
			{
				return this.MessageField;
			}
			set
			{
				this.MessageField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToTrusteeData NextAssignee
		{
			get
			{
				return this.NextAssigneeField;
			}
			set
			{
				this.NextAssigneeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 2)]
		public DateTime? NextActivityDueDate
		{
			get
			{
				return this.NextActivityDueDateField;
			}
			set
			{
				this.NextActivityDueDateField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 3)]
		public string NextActivityTitle
		{
			get
			{
				return this.NextActivityTitleField;
			}
			set
			{
				this.NextActivityTitleField = value;
			}
		}
	}
}
