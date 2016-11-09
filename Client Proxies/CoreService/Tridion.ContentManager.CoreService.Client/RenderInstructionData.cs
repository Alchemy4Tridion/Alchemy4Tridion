using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "RenderInstructionData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class RenderInstructionData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private string BinaryStoragePathField;

		private string ExtensionXmlField;

		private RenderMode? RenderModeField;

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
		public string BinaryStoragePath
		{
			get
			{
				return this.BinaryStoragePathField;
			}
			set
			{
				this.BinaryStoragePathField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ExtensionXml
		{
			get
			{
				return this.ExtensionXmlField;
			}
			set
			{
				this.ExtensionXmlField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public RenderMode? RenderMode
		{
			get
			{
				return this.RenderModeField;
			}
			set
			{
				this.RenderModeField = value;
			}
		}
	}
}
