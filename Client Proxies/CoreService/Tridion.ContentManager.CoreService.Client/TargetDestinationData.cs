using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TargetDestinationData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TargetDestinationData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string ProtocolDataField;

		private LinkToSchemaData ProtocolSchemaField;

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

		[DataMember(EmitDefaultValue = false)]
		public string ProtocolData
		{
			get
			{
				return this.ProtocolDataField;
			}
			set
			{
				this.ProtocolDataField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToSchemaData ProtocolSchema
		{
			get
			{
				return this.ProtocolSchemaField;
			}
			set
			{
				this.ProtocolSchemaField = value;
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
