using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "OperationInstruction", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class OperationInstruction : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private OperationMode ModeField;

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
		public OperationMode Mode
		{
			get
			{
				return this.ModeField;
			}
			set
			{
				this.ModeField = value;
			}
		}
	}
}
