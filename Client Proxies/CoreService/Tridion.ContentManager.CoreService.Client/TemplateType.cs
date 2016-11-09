using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "TemplateType", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class TemplateType : IExtensibleDataObject
	{
		private ExtensionDataObject extensionDataField;

		private bool HasBinaryContentField;

		private int IdField;

		private string MimeTypeField;

		private string NameField;

		private string TitleField;

		private WebDavFileExtensionMapping[] WebDavFileExtensionMappingsField;

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
		public bool HasBinaryContent
		{
			get
			{
				return this.HasBinaryContentField;
			}
			set
			{
				this.HasBinaryContentField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
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
		public string MimeType
		{
			get
			{
				return this.MimeTypeField;
			}
			set
			{
				this.MimeTypeField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				this.NameField = value;
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

		[DataMember(EmitDefaultValue = false)]
		public WebDavFileExtensionMapping[] WebDavFileExtensionMappings
		{
			get
			{
				return this.WebDavFileExtensionMappingsField;
			}
			set
			{
				this.WebDavFileExtensionMappingsField = value;
			}
		}
	}
}
