using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ApplicableActionsData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ApplicableActionsData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private ApplicableActionsDataDictionary ActionsField;

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
		public ApplicableActionsDataDictionary Actions
		{
			get
			{
				return this.ActionsField;
			}
			set
			{
				this.ActionsField = value;
			}
		}
	}
}
