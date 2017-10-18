using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ValidationResultData", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(ValidationWarningData)), KnownType(typeof(ValidationErrorData))]
	public class ValidationResultData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string MessageField;

		private string LocationField;

		private string SourceField;

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

		[DataMember(EmitDefaultValue = false, Order = 1)]
		public string Location
		{
			get
			{
				return this.LocationField;
			}
			set
			{
				this.LocationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 2)]
		public string Source
		{
			get
			{
				return this.SourceField;
			}
			set
			{
				this.SourceField = value;
			}
		}
	}
}
