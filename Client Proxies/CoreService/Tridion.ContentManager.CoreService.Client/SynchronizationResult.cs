using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "SynchronizationResult", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class SynchronizationResult : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private SynchronizationActionData[] SynchronizationActionsField;

		private IdentifiableObjectData SynchronizedItemField;

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

		[DataMember]
		public SynchronizationActionData[] SynchronizationActions
		{
			get
			{
				return this.SynchronizationActionsField;
			}
			set
			{
				this.SynchronizationActionsField = value;
			}
		}

		[DataMember]
		public IdentifiableObjectData SynchronizedItem
		{
			get
			{
				return this.SynchronizedItemField;
			}
			set
			{
				this.SynchronizedItemField = value;
			}
		}
	}
}
