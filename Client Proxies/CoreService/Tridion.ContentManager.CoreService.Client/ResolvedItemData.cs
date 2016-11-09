using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "ResolvedItemData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class ResolvedItemData : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private LinkToIdentifiableObjectData ItemField;

		private string ItemPathField;

		private LinkToPublicationTargetData PublicationTargetField;

		private LinkToTemplateData TemplateField;

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
		public LinkToIdentifiableObjectData Item
		{
			get
			{
				return this.ItemField;
			}
			set
			{
				this.ItemField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string ItemPath
		{
			get
			{
				return this.ItemPathField;
			}
			set
			{
				this.ItemPathField = value;
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
		public LinkToTemplateData Template
		{
			get
			{
				return this.TemplateField;
			}
			set
			{
				this.TemplateField = value;
			}
		}
	}
}
