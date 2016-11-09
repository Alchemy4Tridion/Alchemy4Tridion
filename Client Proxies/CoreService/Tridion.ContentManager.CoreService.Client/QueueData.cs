using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "QueueData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class QueueData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private int IdField;

		private int? NumberOfMessagesField;

		private string TitleField;

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

		[DataMember(IsRequired = true, EmitDefaultValue = false)]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				this.IdField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? NumberOfMessages
		{
			get
			{
				return this.NumberOfMessagesField;
			}
			set
			{
				this.NumberOfMessagesField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Title
		{
			get
			{
				return this.TitleField;
			}
			set
			{
				this.TitleField = value;
			}
		}
	}
}
