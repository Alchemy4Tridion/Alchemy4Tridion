using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PurgeWorkflowHistoryInstructionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PurgeWorkflowHistoryInstructionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private DateTime? DeleteHistoryBeforeField;

		private LinkToPublicationData PublicationField;

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
		public DateTime? DeleteHistoryBefore
		{
			get
			{
				return this.DeleteHistoryBeforeField;
			}
			set
			{
				this.DeleteHistoryBeforeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToPublicationData Publication
		{
			get
			{
				return this.PublicationField;
			}
			set
			{
				this.PublicationField = value;
			}
		}
	}
}
