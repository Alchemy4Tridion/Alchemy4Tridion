using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishSourceData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishSourceData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToPublicationData ContextPublicationField;

		private LinkToTargetTypeData TargetTypeField;

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
		public LinkToPublicationData ContextPublication
		{
			get
			{
				return this.ContextPublicationField;
			}
			set
			{
				this.ContextPublicationField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToTargetTypeData TargetType
		{
			get
			{
				return this.TargetTypeField;
			}
			set
			{
				this.TargetTypeField = value;
			}
		}
	}
}
