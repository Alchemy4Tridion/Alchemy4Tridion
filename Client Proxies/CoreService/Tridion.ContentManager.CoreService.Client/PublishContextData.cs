using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "PublishContextData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class PublishContextData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private ProcessedItemData[] ProcessedItemsField;

		private LinkToPublicationData PublicationField;

		private LinkToPublicationTargetData PublicationTargetField;

		private ResolvedItemData[] ResolvedItemsField;

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
		public ProcessedItemData[] ProcessedItems
		{
			get
			{
				return this.ProcessedItemsField;
			}
			set
			{
				this.ProcessedItemsField = value;
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

		[DataMember(EmitDefaultValue = false)]
		public LinkToPublicationTargetData PublicationTarget
		{
			get
			{
				return this.PublicationTargetField;
			}
			set
			{
				this.PublicationTargetField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public ResolvedItemData[] ResolvedItems
		{
			get
			{
				return this.ResolvedItemsField;
			}
			set
			{
				this.ResolvedItemsField = value;
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
