using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ServiceFault", Namespace = "http://www.sdltridion.com/ContentManager/R6"), KnownType(typeof(CoreServiceFault))]
	public class ServiceFault : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string CategoryField;

		private string ErrorCodeField;

		private string ExceptionNameField;

		private MessageList MessagesField;

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
		public string Category
		{
			get
			{
				return this.CategoryField;
			}
			set
			{
				this.CategoryField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ErrorCode
		{
			get
			{
				return this.ErrorCodeField;
			}
			set
			{
				this.ErrorCodeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ExceptionName
		{
			get
			{
				return this.ExceptionNameField;
			}
			set
			{
				this.ExceptionNameField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public MessageList Messages
		{
			get
			{
				return this.MessagesField;
			}
			set
			{
				this.MessagesField = value;
			}
		}
	}
}
